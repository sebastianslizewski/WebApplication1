using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Wymiana_Kart_TCG.Models
{
    public class PointCategory
    {
        [Key]
        public int PointCategoryId { get; set; }
        public string PointCategoryName { get; set; }
        public string PointCategoryDescription { get; set; }
        public List<Point> Points { get; set; }
    }
}
