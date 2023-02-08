using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Northwind.Model
{

    [ModelMetadataType(typeof(ProductMetadata))]
    public partial class Product
    {
        /// <summary>
        /// Anotación de estructura (mapeo)
        /// </summary>
        [ScaffoldColumn(false)]
        [NotMapped]
        public string? PictureBase64 { get; set; }

        public class ProductMetadata
        {
            public int ProductId { get; set; }

            /// <summary>
            /// Anotación de presentación y validación.
            /// </summary>
            [Display(Name = "Nombre de producto")]
            [Required(ErrorMessage = "El {0} es requerido.")]
            [StringLength(40, ErrorMessage = "El {0} permite un máximo de {1} caracteres")]
            public string ProductName { get; set; } = null!;

            public int? SupplierId { get; set; }

            public int? CategoryId { get; set; }

            [Display(Name = "Cantidad por unidad")]
            [Required(ErrorMessage = "La {0} es requerida.")]
            [MaxLength(20, ErrorMessage = "La {0} permite un máximo de {1} caracteres")]
            public string? QuantityPerUnit { get; set; }

            [Display(Name = "Precio por unidad")]
            [Required(ErrorMessage = "El {0} es requerido.")]
            public decimal? UnitPrice { get; set; }

            [Display(Name = "Unidades en Inventario")]
            [Required(ErrorMessage = "Las {0} son requeridas.")]
            public short? UnitsInStock { get; set; }

            public bool Discontinued { get; set; }
        }
    }
}
