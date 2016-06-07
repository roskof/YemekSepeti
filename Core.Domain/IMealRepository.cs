using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain
{
    public interface IMealRepository
    {
        List<Meal> GetMealListByIdList(List<string> mealIdList);
    }
}
