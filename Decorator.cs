using System;
using System.ComponentModel;
namespace Decorator.Examples
{
    class MainApp
    {
        static void Main()
        {
            // Create ConcreteComponent and two Decorators
            ConcreteChristmastree c = new ConcreteChristmastree();
            ConcreteDecoratorA d1 = new ConcreteDecoratorA();
            ConcreteDecoratorB d2 = new ConcreteDecoratorB();

            // Link decorators
            d1.SetTree(c);
            d2.SetTree(d1);

            d2.DecorateTree();

            // Wait for user
            Console.Read();
        }
    }
    // "Component"
    abstract class Christmastree
    {
        public abstract void DecorateTree();
    }

    // "ConcreteComponent"
    class ConcreteChristmastree : Christmastree
    {
        protected string yellowBalls;
        protected string light;

        public override void DecorateTree()
        {
            yellowBalls = "yellow balls";

            Console.WriteLine("This Christmas tree is decorated with {0}",yellowBalls);
        }
    }
    // "Decorator"
    abstract class Decorator : Christmastree
    {
        protected Christmastree cristmasTree;

        public void SetTree(Christmastree cristmasTree)
        {
            this.cristmasTree = cristmasTree;
        }
        public override void DecorateTree()
        {
            if (cristmasTree != null)
            {
                cristmasTree.DecorateTree();
            }

        }
    }

    // "ConcreteDecoratorA"
    class ConcreteDecoratorA : Decorator
    {
        private string blueBalls;

        public override void DecorateTree()
        {
            base.DecorateTree();
            blueBalls = "blue balls";
            Console.WriteLine("ConcreteDecoratorA has added {0}", blueBalls);
        }
    }

    // "ConcreteDecoratorB" 
    class ConcreteDecoratorB : Decorator
    {
        private string newLight;

        public override void DecorateTree()
        {
            base.DecorateTree();
            newLight = "blue";
            SwitchOnTheLight(newLight);
            //SwitchOffTheLight(newLight);
        }

        public void SwitchOnTheLight(string light)
        {
            Console.WriteLine("ConcreteDecoratorB has turned on {0} light", light);
        }

        public void SwitchOffTheLight(string light)
        {
            Console.WriteLine("ConcreteDecoratorB has turned off {0} light", light);
        }
    }
}
