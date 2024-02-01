using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mealbuilder builder;
            Shop shop = new Shop();
            builder = new BrunchComboBuilder();
            shop.Construct(builder);
            builder.Meal.show();

            builder = new LunchBuilder();
            shop.Construct(builder);
            builder.Meal.show();

            builder = new SnacksBuilder();
            shop.Construct(builder);
            builder.Meal.show();

            builder = new DinnerBuilder();
            shop.Construct(builder);
            builder.Meal.show();
            Console.ReadKey();
        }
    }

    class Shop
    {
        public void Construct(Mealbuilder mealbuilder)
        {
            mealbuilder.meal1();
            mealbuilder.meal2();
            mealbuilder.meal3();
            mealbuilder.meal4();
        }
    }


    abstract class Mealbuilder
    {
        protected Meal meal;
        public Meal Meal
        {
            get { return meal; }
        }
        public abstract void meal1();
        public abstract void meal2();
        public abstract void meal3();
        public abstract void meal4();

    }

    class Meal
    {
        private string _Mealype;
        private Dictionary<string, string> Meals = new Dictionary<string, string>();
        public Meal(string mealtype)
        {
            this._Mealype = mealtype;
        }
        public string this[string key]
        {
            get { return Meals[key]; }
            set { Meals[key] = value; }
        }

        public void show()
        {
            Console.WriteLine("----------------");
            Console.WriteLine("Combo type {0}: ", _Mealype);
            Console.WriteLine("Meal1: {0}: ", Meals["Meal1"]);
            Console.WriteLine("Meal2: {0}: ", Meals["Meal2"]);
            Console.WriteLine("Meal3: {0}: ", Meals["Meal3"]);
            Console.WriteLine("Meal4: {0}: ", Meals["Meal4"]);
        }
    }

    class BrunchComboBuilder : Mealbuilder
    {
        public BrunchComboBuilder()
        {
            meal = new Meal("Brunch Combo");
        }
        public override void meal1()
        {
            meal["Meal1"] = "Fruit salad";
        }

        public override void meal2()
        {
            meal["Meal2"] = "Boiled egg";
        }

        public override void meal3()
        {
            meal["Meal3"] = "Poha";
        }

        public override void meal4()
        {
            meal["Meal4"] = "Juice";
        }
    }
    class LunchBuilder : Mealbuilder
    {
        public LunchBuilder()
        {
            meal = new Meal("Lunch Combo");
        }
        public override void meal1()
        {
            meal["Meal1"] = "Rice";
        }

        public override void meal2()
        {
            meal["Meal2"] = "Pulse";
        }

        public override void meal3()
        {
            meal["Meal3"] = "Mutter Paneer";
        }

        public override void meal4()
        {
            meal["Meal4"] = "Soft Drink";
        }
    }

    class SnacksBuilder : Mealbuilder
    {
        public SnacksBuilder()
        {
            meal = new Meal("Snacks Combo");
        }
        public override void meal1()
        {
            meal["Meal1"] = "Hot dog";
        }

        public override void meal2()
        {
            meal["Meal2"] = "Pattice";
        }

        public override void meal3()
        {
            meal["Meal3"] = "Biscuit";
        }

        public override void meal4()
        {
            meal["Meal4"] = "Tea or Coffee";
        }
    }
    class DinnerBuilder : Mealbuilder
    {
        public DinnerBuilder()
        {
            meal = new Meal("Dinner Combo");
        }
        public override void meal1()
        {
            meal["Meal1"] = "Chapati";
        }

        public override void meal2()
        {
            meal["Meal2"] = "Mix Veg";
        }

        public override void meal3()
        {
            meal["Meal3"] = "Dal";
        }

        public override void meal4()
        {
            meal["Meal4"] = "Ice cream";
        }
    }

}
