using System;
using System.ComponentModel.DataAnnotations;

namespace MvcSpoon.Models
{
    public class Spoon
    {
        public int Id { get; set; }
        public string TypeOfSpoon { get; set; }

        public string Material { get; set; }
        public decimal Measurement { get; set; }
        public string Color { get; set; }
        public decimal Weight { get; set; }
        public decimal Price { get; set; }
    }
}