using TrainingManagment.Domain.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace TrainingManagment.Domain.Models
{
    public class Session : BaseEntity
    {
        [Key]
        public int SessionId { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Start Date is required.")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime StartDate { get; set; }

        [DataType(DataType.Date), Required]
        public DateTime ExpectedEndDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime ActualEndDate { get; set; }

        [Required]
        public LookupEnum.Year Year { get; set; }

        [Required]
        public string TraineeName { get; set; }

        // Use enums to represent these fields
        public LookupEnum.enTrainingType TrainingType { get; set; }

        public LookupEnum.TrainingTopics TrainingTopic { get; set; }

        public LookupEnum.Status Status { get; set; }

        public LookupEnum.Result Result { get; set; }
        public LookupEnum.Trainer TrainerName { get; set; }

        [DataType(DataType.Date)]
        public DateTime FinalPresentationDate { get; set; }

        public double EvaluationScore { get; set; }

        public string Comment { get; set; }

        // Navigation properties to refer to related Lookup entities
        public Lookup TrainingTypeLookup { get; set; }

        public Lookup TrainingTopicLookup { get; set; }

        public Lookup StatusLookup { get; set; }

        public Lookup ResultLookup { get; set; }

        public Lookup TrainerLookup { get; set; }
    }

}
