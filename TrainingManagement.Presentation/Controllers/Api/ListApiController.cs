using AspNetCore.ReportingServices.ReportProcessing.ReportObjectModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ServiceModel.Channels;
using System.Threading.Tasks;
using TrainingManagement.Domain.ViewModels;
using TrainingManagment.Domain.Models;
using TrainingManagment.Domain.Models.Enums;
using TrainingManagment.Presentation.Controllers;
using TrainingManagment.Repository.Interfaces;
using TrainingManagment.Repository.Repositories;

namespace TrainingManagement.Presentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    //[Authorize]
    public class ListApiController : ControllerBase
    {
        private readonly ILogger<ListApiController> _logger;
        private readonly IUnitOfWork _unitOfWork;

        public ListApiController(IUnitOfWork unitOfWork, ILogger<ListApiController> logger)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        [HttpGet("Topics")]
        public async Task<IActionResult> GetTopics()
        {
            var types = await _unitOfWork.Lookups.FindAllAsync(b => b.IsActive == true && b.IsDeleted == false && b.LookupCategoryId == (int)LookupEnum.CategoryCode.Topics);
            return Ok(types);
        }

        [HttpGet("Types")]
        public async Task<IActionResult> GetTypes()
        {
            var types = await _unitOfWork.Lookups.FindAllAsync(b => b.IsActive == true && b.IsDeleted == false && b.LookupCategoryId == (int)LookupEnum.CategoryCode.Type);
            return Ok(types);
        }

        [HttpGet("Trainers")]
        public async Task<IActionResult> GetTrainers()
        {
            var trainers = await _unitOfWork.Lookups.FindAllAsync(b => b.IsActive == true && b.IsDeleted == false && b.LookupCategoryId == (int)LookupEnum.CategoryCode.TrainerName);
            return Ok(trainers);
        }

        [HttpPost("DeleteItem")]
        public async Task<IActionResult> Delete(int id)
        {

            if (id != 0)
            {
                var item = await _unitOfWork.Lookups.GetByIdAsync(id);

                if (item == null)
                {
                    var message = "The item not found";
                    return NotFound(message);
                }

                item.IsActive = false;
                item.IsDeleted = true;
                _unitOfWork.Lookups.Update(item);
                await _unitOfWork.Complete();

            }

            return Ok();
        }

        [HttpPost("Edit")]
        public async Task<IActionResult> Edit(Lookup model)
        {
            if (!ModelState.IsValid)
            {
                var message = "The item not found";
                return NotFound(message);
            }

            if (model.Id != 0)
            {
                var item = await _unitOfWork.Lookups.GetByIdAsync(model.Id);

                if (item == null)
                {
                    var message = "The item not found";
                    return NotFound(message);
                }
                var updated = new Lookup
                {
                    NameEn = model.NameEn,
                    NameAr = model.NameAr
                };

                //item.IsActive = true;
                //item.IsDeleted = false;
                _unitOfWork.Lookups.Update(updated);
                await _unitOfWork.Complete();

            }

            return Ok();
        }


        [HttpPost("AddItem")]
        public async Task<IActionResult> Add(AddLookupViewModel viewModel)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                var nameEnExist = await _unitOfWork.Lookups.FindAsync(lookup => lookup.NameEn == viewModel.NameEn);
                var nameArExist = await _unitOfWork.Lookups.FindAsync(lookup => lookup.NameAr == viewModel.NameAr);

                if ((nameEnExist != null && nameEnExist.IsDeleted == false && nameEnExist.IsActive == true) ||
                           (nameArExist != null && nameArExist.IsDeleted == false && nameArExist.IsActive == true))
                {
                    return BadRequest(new { message = "Item already exists" });
                }
                // if statements in details 
                #region

                //if(nameEnExist != null || nameArExist != null)
                //{
                //    if (nameEnExist != null )
                //    {
                //        if(nameEnExist.NameEn == viewModel.NameEn)
                //        {
                //            if(nameEnExist.IsDeleted != true && nameEnExist.IsActive != false)
                //            {
                //               return BadRequest(new { message = $"{nameEnExist.NameEn} already exists" });
                //            }

                //        }
                //    }
                //    if (nameArExist != null)
                //    {
                //        if(nameArExist.NameAr == viewModel.NameAr)
                //        {
                //            if (nameArExist.IsDeleted != true && nameArExist.IsActive != false)
                //            {
                //                return BadRequest(new { message = $"{nameArExist.NameAr} already exists" });
                //            }
                //        }
                //    }
                //}
                #endregion

                if (nameEnExist != null && nameArExist != null)
                {

                    if (nameEnExist.IsDeleted == true && nameEnExist.IsActive == false)
                    {
                        var item = await _unitOfWork.Lookups.GetByIdAsync(nameEnExist.Id);
                        item.ModifyBy = User.Identity.Name;
                        item.ModifyOn = DateTime.Now;
                        item.IsActive = true;
                        item.IsDeleted = false;

                        await _unitOfWork.Complete();
                        return Ok(new { message = "Item restored successfully" });
                    }
                }

                var itemToAdd = new Lookup
                {
                    CreatedBy = User.Identity.Name,
                    CreatedOn = DateTime.Now,
                    IsActive = true,
                    IsDeleted = false,
                    LookupCategoryId = viewModel.LookupCategoryId,
                    NameEn = viewModel.NameEn,
                    NameAr = viewModel.NameAr
                };

                var lookup = await _unitOfWork.Lookups.AddAsync(itemToAdd);

                await _unitOfWork.Complete();

                return Ok(new { message = "Item added successfully" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.ToString() } );
            }

        }


    }
}
