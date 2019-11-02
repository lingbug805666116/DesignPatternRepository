using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern
{
    public class SimpleFactory
    {
        public static Food MakeFood(FoodType foodType)
        {
            Food food = null;
            if (foodType == FoodType.Patato)
            {
                food = new Patato();
            }
            else if (foodType == FoodType.TomatoWithEggs)
            {
                food = new TomatoWithEggs();
            }
            else if (foodType == FoodType.Chicken)
            {
                food = new Chicken();
            }
            return food;
        }
    }

    public enum FoodType
    {
        Patato, TomatoWithEggs, Chicken
    }
}
