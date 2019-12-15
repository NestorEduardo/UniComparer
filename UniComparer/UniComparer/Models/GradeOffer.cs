using UniComparer.Utils;

namespace UniComparer.Models
{
    public class GradeOffer : BaseEntity
    {
        public string Description { get; set; }
        public int CreditsNumber { get; set; }
        public int AcademicPeriodNumber { get; set; }
        public decimal Cost { get; set; }
        public int GradeId { get; set; }
        public string PensumUrl { get; set; }
        public decimal InscriptionPrice { get; set; }
        public decimal CreditsPrice { get; set; }
        public virtual AcademicPeriodCategory AcademicPeriodCategory { get; set; }
        public virtual University University { get; set; }
        public virtual Grade Grade { get; set; }
        public string GradeOfferDuration => Mapper.GradePeriodCaregoryDurationToString(AcademicPeriodCategory, AcademicPeriodNumber);
        public int MonthsDuration => AcademicPeriodCategory.NumberOfMonths * AcademicPeriodNumber;
    }
}
