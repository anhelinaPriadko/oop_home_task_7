using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Examples
{
    class MainApp
    {
        public static void Main()
        {
            Facade facade = new Facade();
            facade.MondayChores();
            facade.TuesdayChores();
            
            Console.Read();
        }
    }


    class HoverTheFloor
    {
        public void Chore()
        {
            Console.WriteLine("Hover the floor\n");
        }
    }

    class DoTheDishes
    {
        public void Chore()
        {
            Console.WriteLine("Do the dishes\n");
        }
    }

    class CookMeal
    {
        public void Chore()
        {
            Console.WriteLine("Cook meal\n");
        }
    }

    class MopTheFloor
    {
        public void Chore()
        {
            Console.WriteLine("Mop the floor\n");
        }
    }

    class DoTheLaundary
    {
        public void Chore()
        {
            Console.WriteLine("Do the Laundary\n");
        }
    }
    

    class Facade
    {
        HoverTheFloor hoover;
        DoTheDishes dishes;
        DoTheLaundary laundary;
        CookMeal meal;
        MopTheFloor mop;

        public Facade()
        {
            hoover = new HoverTheFloor();
            dishes = new DoTheDishes();
            laundary = new DoTheLaundary();
            meal = new CookMeal();
            mop = new MopTheFloor();
        }

        public void MondayChores()
        {
            Console.WriteLine("\n---- Monday chores ----");
            hoover.Chore();
            mop.Chore();
            meal.Chore();
            dishes.Chore();
        }

        public void TuesdayChores()
        {
            Console.WriteLine("\n---- Tuesday chores ----");
            laundary.Chore();
            meal.Chore();
            dishes.Chore();
        }
    }
}
