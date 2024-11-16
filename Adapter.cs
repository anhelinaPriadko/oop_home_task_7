using System;
namespace AdapterExample
{
    // старі джинси
    class OldJeans
    {
        public string MatchOldJeans()
        {
            return "old jeans";
        }
    }
    // принцип того що для чогось нового потрібні нові джинси
    interface INewJeans
    {
        string MatchNewJeans();
    }

    // нові джинси
    class NewJeans : INewJeans
    {
        public string MatchNewJeans()
        {
            return "new jeans";
        }
    }
   

    class Adapter : INewJeans
    {
        private readonly OldJeans jeansToAdapt;
        public Adapter(OldJeans jeansToAdapt)
        {
            this.jeansToAdapt = jeansToAdapt;
        }

        public string MatchNewJeans()
        {
            return jeansToAdapt.MatchOldJeans();
        }
    }

     class  NewSweater
     {

        public static void MatchNewOutfit(INewJeans jeans)
        {
            Console.WriteLine("This new sweater matches with {0}", jeans.MatchNewJeans());
        }
     }

    public class AdapterDemo
    {
        static void Main()
        {
            // нові джинси і новий светр
            var newJeans = new NewJeans();
            NewSweater.MatchNewOutfit(newJeans);

            // опля і старі джинси під новий светр теж як нові
            var oldJeans = new OldJeans();
            var adapter = new Adapter(oldJeans);
            NewSweater.MatchNewOutfit(adapter);            
            Console.ReadKey();
        }
    }
}
