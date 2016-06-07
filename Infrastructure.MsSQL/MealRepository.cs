using Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.MsSQL
{
   public class MealRepository : IMealRepository
    {
        public List<Meal> GetMealListByIdList(List<string> mealIdList)
        {
            throw new NotImplementedException();
        }
    }
}
