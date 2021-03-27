using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Recuperacion_Emily.Models
{
    public class Product
    {
      [Key]
      [Range(typeof(int),"1","99999")]
    public int ProductID { get; set; }
    [Required]
    [StringLength(30,MinimumLength =3,ErrorMessage ="Ingrese entre 3 a 30 caracteres")]
    public string Description { get; set; }
    [DataType(DataType.Currency)]
    [Required]
    public double Price { get; set; }
    [DataType(DataType.Date)]
    public DateTime LastBuy { get; set; }


    }
}