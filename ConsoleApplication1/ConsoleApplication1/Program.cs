using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Lion newLion = new Lion();

            newLion.Name = ("Mufasa");
            Console.WriteLine("This lion is named " + newLion.Name);
            Console.WriteLine("This lion has " + newLion.NumberLegs + " number of legs.");
            Console.WriteLine("This lion has a tail. (T/F)? " + newLion.Tail);
            Console.WriteLine("This lion lands on all fours. (T/F)? " + newLion.allFours);           
            Console.WriteLine("This lion has fur. (T/F)? " + newLion.Fur);
            newLion.King = true;
            Console.WriteLine("This lion is the king of the jungle. (T/F)? " + newLion.King);
            newLion.Mane = true;
            Console.WriteLine("This lion has a mane. (T/F)? " + newLion.Mane);
            Console.WriteLine(" ");

            Tiger newTiger = new Tiger();
            newTiger.Name = ("Eustace");
            Console.WriteLine("This tiger is named " + newTiger.Name);
            Console.WriteLine("This tiger has " + newTiger.NumberLegs + " number of legs.");
            Console.WriteLine("This tiger has a tail. (T/F)? " + newTiger.Tail);
            Console.WriteLine("This tiger lands on all fours. (T/F)? " + newTiger.allFours);
            Console.WriteLine("This tiger has fur. (T/F)? " + newTiger.Fur);
            Console.WriteLine("This tiger has stripes. (T/F)? " + newTiger.Stripes);
            newTiger.Sleep = false;
            Console.WriteLine("This tiger sleeps standing up. (T/F)? " + newTiger.Sleep);
            Console.WriteLine(" ");


            Crocodile newCrocodile = new Crocodile();
            newCrocodile.Name = ("Dundee");
            Console.WriteLine("This crocodile is named " + newCrocodile.Name);
            Console.WriteLine("This crocodile has " + newCrocodile.NumberLegs + " number of legs.");
            Console.WriteLine("This crocodile has a tail. (T/F)? " + newCrocodile.Tail);
            Console.WriteLine("This crocodile has scales. (T/F)? " + newCrocodile.HasScales); 
            Console.WriteLine("This crocodile swims. (T/F)? " + newCrocodile.doesSwim);
            Console.WriteLine("This crocodile is green. (T/F)? " + newCrocodile.Green);
            newCrocodile.Land = false;
            Console.WriteLine("This crocodile goes on land. (T/F)? " + newCrocodile.Land);
            Console.WriteLine(" ");

            Marlin newMarlin = new Marlin();
            newMarlin.Name = ("Nemo");
            Console.WriteLine("This Marlin is named " + newMarlin.Name);
            Console.WriteLine("This Marlin has " + newMarlin.NumberLegs + " number of legs.");
            Console.WriteLine("This Marlin has a tail. (T/F)? " + newMarlin.Tail);
            Console.WriteLine("This Marlin has scales. (T/F)? " + newMarlin.HasScales);
            Console.WriteLine("This Marlin swims. (T/F)? " + newMarlin.doesSwim);
            Console.WriteLine("This Marlin has a sword nose. (T/F)? " + newMarlin.Swordnose);            
            Console.WriteLine("This Marlin has fins (T/F)? " + newMarlin.Fins);
            Console.WriteLine(" ");


            Penguin newPenguin = new Penguin();
            newPenguin.Name = ("Popper");
            Console.WriteLine("This Penguin is named " + newPenguin.Name);
            Console.WriteLine("This Penguin has " + newPenguin.NumberLegs + " number of legs.");
            Console.WriteLine("This Penguin has a tail. (T/F)? " + newPenguin.Tail);
            Console.WriteLine("This Penguin has a beak. (T/F)? " + newPenguin.Beak);
            Console.WriteLine("This Penguin lays eggs. (T/F)? " + newPenguin.Eggs);
            Console.WriteLine("This Penguin does not fly. (T/F)? " + newPenguin.Flys);
            Console.WriteLine("This Penguin lives in cold weather. (T/F)? " + newPenguin.weather);
            Console.WriteLine(" ");


            Eagle newEagle = new Eagle();
            newEagle.Name = ("Freedom");
            Console.WriteLine("This Eagle is named " + newEagle.Name);
            Console.WriteLine("This Eagle has " + newEagle.NumberLegs + " number of legs.");
            Console.WriteLine("This Eagle has a tail. (T/F)? " + newEagle.Tail);
            Console.WriteLine("This Eagle has a beak. (T/F)? " + newEagle.Beak);
            Console.WriteLine("This Eagle lays eggs. (T/F)? " + newEagle.Eggs);
            Console.WriteLine("This Eagle does not fly. (T/F)? " + newEagle.flys);
            Console.WriteLine("This Eagle is naturally bald. (T/F)? " + newEagle.bald);
            Console.WriteLine(" ");

            Console.ReadLine();
        }
    }
}
