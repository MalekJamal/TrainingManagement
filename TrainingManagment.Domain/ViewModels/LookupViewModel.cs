using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingManagment.Domain.Models;

namespace TrainingManagement.Domain.ViewModels
{
    public class LookupViewModel
    {

        [Key]
        public int Id { get; set; }

        public int Code { get; set; }

        [Required]
        public string NameEn { get; set; }

        [Required]
        public string NameAr { get; set; }

        public string Description { get; set; }
        public int LookupCategoryId { get; set; }

        [ForeignKey("LookupCategoryId")]  // Specify the foreign key relationship
        public LookupCategory LookupCategory { get; set; }

    }
}
