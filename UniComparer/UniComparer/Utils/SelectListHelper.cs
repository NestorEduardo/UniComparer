using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace UniComparer.Utils
{
    public static class SelectListHelper
    {
        public static List<SelectListItem> BindSortingOptionsSelectList()
        {
            return new List<SelectListItem>
                {
                    new SelectListItem { Text = "Ordenar Por", Value = ((int)GradeOfferSortingOptions.None).ToString()},
                    new SelectListItem { Text = "Costo de inscripción - Mayor a menor", Value = ((int)GradeOfferSortingOptions.CostoInscripcionMayorMenor).ToString()},
                    new SelectListItem { Text = "Costo de inscripción - Menor a mayor", Value = ((int)GradeOfferSortingOptions.CostoInscripcionMenorMayor).ToString()},
                    new SelectListItem { Text = "Costo de créditos - Mayor a menor", Value = ((int)GradeOfferSortingOptions.CostoCreditosMayorMenor).ToString()},
                    new SelectListItem { Text = "Costo de créditos - Menor a mayor", Value = ((int)GradeOfferSortingOptions.CostoCreditosMenorMayor).ToString()},
                    new SelectListItem { Text = "Costo de la carrera - Mayor a menor", Value = ((int)GradeOfferSortingOptions.CostoCarreraMayorMenor).ToString()},
                    new SelectListItem { Text = "Costo de la carrera- Menor a mayor", Value = ((int)GradeOfferSortingOptions.CostoCarreraMenorMayor).ToString()},
                    new SelectListItem { Text = "Cantidad de créditos - Mayor a menor", Value = ((int)GradeOfferSortingOptions.CantidadCreditosMayorMenor).ToString()},
                    new SelectListItem { Text = "Cantidad de créditos - Menor a mayor", Value = ((int)GradeOfferSortingOptions.CantidadCreditosMenorMayor).ToString()},
                    new SelectListItem { Text = "Duración de la carrera - Mayor a menor", Value = ((int)GradeOfferSortingOptions.DuracionCarreraMayorMenor).ToString()},
                    new SelectListItem { Text = "Duración de la carrera - Menor a mayor", Value = ((int)GradeOfferSortingOptions.DuracionCarreraMenorMayor).ToString()},
                };
        }
    }
}
