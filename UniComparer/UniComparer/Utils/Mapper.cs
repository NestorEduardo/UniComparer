using UniComparer.Models;

namespace UniComparer.Utils
{
    public static class Mapper
    {
        public static string GradePeriodCaregoryDurationToString(AcademicPeriodCategory academicPeriodCategory, int academicPeriodNumber)
        {
            string gradeOfferDurationString = string.Empty;
            int months = academicPeriodCategory.NumberOfMonths * academicPeriodNumber;
            int years = months / 12;
            int residualOfMonths = months % 12;

            if (years == 0 && residualOfMonths == 1)
            {
                gradeOfferDurationString = $"{residualOfMonths} mes";
            }
            else if (years == 0 && residualOfMonths >= 2)
            {
                gradeOfferDurationString = $"{residualOfMonths} meses";
            }
            else if (years == 1 && residualOfMonths == 0)
            {
                gradeOfferDurationString = $"{residualOfMonths} año";
            }
            else if (years >= 2 && residualOfMonths == 0)
            {
                gradeOfferDurationString = $"{years} años";
            }
            else if (years == 1 && residualOfMonths <= 1)
            {
                gradeOfferDurationString = $"{years} año y {residualOfMonths} mes";
            }
            else if (years == 1 && residualOfMonths >= 2)
            {
                gradeOfferDurationString = $"{years} año y {residualOfMonths} meses";
            }
            else if (years >= 2 && residualOfMonths == 1)
            {
                gradeOfferDurationString = $"{years} años y {residualOfMonths} mes";
            }
            else if (years >= 2 && residualOfMonths >= 2)
            {
                gradeOfferDurationString = $"{years} años y {residualOfMonths} meses";
            }

            return gradeOfferDurationString;
        }
    }
}
