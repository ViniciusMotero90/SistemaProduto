using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SilkRoad.Models
{
    [Table("Product")]
    public class Product
    {
        [Display(Name="Id")]
        [Column("Id")]
        public int Id { get; set; }
        [Display(Name = "Name")]
        [Column("Name")]
        public string Name { get; set; }
        [Display(Name = "Weight")]
        [Column("Weight")]
        public double Weight { get; set; }
        [Display(Name = "Price")]
        [Column("Price")]
        public double Price { get; set; }
        [Display(Name = "UrlImage")]
        [Column("UrlImage")]
        public string UrlImage { get; set; }
    }
}