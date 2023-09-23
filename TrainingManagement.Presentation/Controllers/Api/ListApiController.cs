using AspNetCore.ReportingServices.ReportProcessing.ReportObjectModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Channels;
using System.Threading.Tasks;
using TrainingManagement.Domain.ViewModels;
using TrainingManagment.Domain.Models;
using TrainingManagment.Domain.Models.Enums;
using TrainingManagment.Presentation.Controllers;
using TrainingManagment.Repository.Interfaces;
using TrainingManagment.Repository.Repositories;
using static TrainingManagment.Domain.Models.Enums.LookupEnum;

namespace TrainingManagement.Presentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
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
            try
            {
                var types = await _unitOfWork.Lookups.FindAllAsync(b => b.IsActive == true && b.IsDeleted == false && b.LookupCategoryId == (int)LookupEnum.CategoryCode.Topics);

                if (types != null && types.Any())
                {
                    return Ok(types);
                }
                else
                {
                    return StatusCode(500, new { message = "No topics found." });
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }


        [HttpGet("Types")]
        public async Task<IActionResult> GetTypes()
        {
            try
            {
                var types = await _unitOfWork.Lookups.FindAllAsync(b => b.IsActive == true && b.IsDeleted == false && b.LookupCategoryId == (int)LookupEnum.CategoryCode.Type);

                if (types != null && types.Any())
                {
                    return Ok(types);
                }
                else
                {
                   return StatusCode(500, new { message = "No types found." });
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }


        [HttpGet("Trainers")]
        public async Task<IActionResult> GetTrainers()
        {
            try
            {
                var trainers = await _unitOfWork.Lookups.FindAllAsync(b => b.IsActive == true && b.IsDeleted == false && b.LookupCategoryId == (int)LookupEnum.CategoryCode.TrainerName);

                if (trainers != null && trainers.Any())
                {
                    return Ok(trainers);
                }
                else
                {
                    return StatusCode(500, new { message = "No trainers found." });
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }


        [HttpPost("DeleteItem")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                if (id == 0)
                {
                    return BadRequest("Item ID is required.");
                }

                var item = await _unitOfWork.Lookups.GetByIdAsync(id);

                if (item == null)
                {

                    return StatusCode(500, new { message = "Item not found." });
                }


                item.IsActive = false;
                item.IsDeleted = true;
                _unitOfWork.Lookups.Update(item);
                await _unitOfWork.Complete();

                
                return Ok("Item deleted successfully.");
            }
            catch (Exception ex)
            {
             
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                if (id == 0)
                {
                    return StatusCode(404, new { message = "Wrong Id" });
                }

                var item = await _unitOfWork.Lookups.GetByIdAsync(id);
                if (item != null)
                {
                    return Ok(item);
                }
                return StatusCode(404, new { message = "Item not found." });

            }
            catch (Exception ex)
            {

                return StatusCode(500, ex.Message);
            }

        }

        [HttpPost("Edit")]
        public async Task<IActionResult> Edit(Lookup model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return StatusCode(404, new { message = "Item not found." });
                }

                if (model.Id != 0)
                {
                    var item = await _unitOfWork.Lookups.GetByIdAsync(model.Id);

                    if (item == null)
                    {
                        
                        return StatusCode(404, new { message = "Item not found." });
                    }

                    if (item.NameEn == model.NameEn && item.NameAr == model.NameAr)
                    {
                        // StatusCode should be 304 not modified status code
                        return StatusCode(200, new { message = "No changes made to the item." });
                    }

                    var duplicateItem = await _unitOfWork.Lookups
                        .FindAsync(x => (x.NameEn == model.NameEn || x.NameAr == model.NameAr) && x.Id != model.Id);

                    if (duplicateItem != null)
                    {
                        return StatusCode(409 , new { message = "An item with the same NameEn or NameAr already exists." });
                    }

                    item.NameEn = model.NameEn;
                    item.NameAr = model.NameAr;
                    item.ModifyBy = User.Identity.Name;
                    item.ModifyOn = DateTime.Now;

                    await _unitOfWork.Complete();

                }

                return Ok(new { message = "Item updated successfully." });
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex.Message);
            }
          
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
