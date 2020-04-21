using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wymiana_Kart_TCG.Models
{
    public class Point
    {
        public int PointId { get; set; }
        public string PointName { get; set; }
        public string PointShortDescription { get; set; }
        public string PointLongDescription { get; set; }
        public int PointPrice { get; set; }
        public string PointImgUrl { get; set; }
        public string PointImgThumbnailUrl { get; set; }
        public bool IsPointOnDiscount { get; set; }
        public bool IsPointAvailableToTrade { get; set; }
        public int PointCategoryId { get; set; }
        public PointCategory PointCategory { get; set; }
        public string Notes { get; set; }
    }
}
