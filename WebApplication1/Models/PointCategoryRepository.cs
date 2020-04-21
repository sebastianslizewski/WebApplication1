using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wymiana_Kart_TCG.Models
{
    public class PointCategoryRepository: IPointCategoryRepository
    {
        private readonly AppDbContext _appDbContext;

        public PointCategoryRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<PointCategory> AllPointsCategories => _appDbContext.PointCatergories;
    }
}
