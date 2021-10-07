using System;
using System.Collections.Generic;
using System.Linq;

namespace Choose_Your_Class
{

    public class Store
    {
        public List<Bag> ListOfAllBags;
        public List<Bag> UserCollection;
      
        public Store()
        {

        Bag FendiBaguette = new Bag((Type)Brand.Fendi, Type.Baguette, "Monogram", 3290);
        Bag FendiPeekaboo = new Bag((Type)Brand.Fendi, Type.Peekaboo, "Beige Sheepskin", 6700);
        Bag FendiFendiFirst = new Bag((Type)Brand.Fendi, Type.Fendi_First, "Black", 3490);
        Bag FendiSunshine = new Bag((Type)Brand.Fendi, Type.Sunshine_Tote, "Brown Leather", 2950);


        Bag GucciDionysus = new Bag((Type)Brand.Gucci, Type.Dionysus, "GG Supreme and Beige", 2450);
        Bag GucciJackie = new Bag((Type)Brand.Gucci, Type.Jackie, "GG Supreme Canvas", 1980);

        Bag LouisVuittonKeepall = new Bag((Type)Brand.Louis_Vuitton, Type.Keepall_55, "Monogram Macassar", 2360);
        Bag LouisVuittonPochetteMetis = new Bag((Type)Brand.Louis_Vuitton, Type.Pochette_Metis, "Monogram Empreinte Turtledove", 2570);
        Bag LouisVuittonSpeedy = new Bag((Type)Brand.Louis_Vuitton, Type.Speedy_30_Bandouliere, "Monogram", 1680);


       Bag ChanelClassicFlap = new Bag((Type)Brand.Chanel, Type.Classic_Flap, "Black Lambskin with Gold Hardware", 7800);
       Bag Chanel19 = new Bag((Type)Brand.Chanel, Type.Chanel_19, "Brown Lambskin with Gold Hardware", 5700);

       Bag HermesBirkin = new Bag((Type)Brand.Hermes, Type.Birkin_30, "Black (Like New)", 20950);

       Bag DiorLadyDior = new Bag((Type)Brand.Dior, Type.Lady_Dior, "Brick Red Cannage Lambskin", 4900);
       Bag DiorSaddleBag = new Bag((Type)Brand.Dior, Type.Saddle_Bag, "Black Ultramatte Calfskin", 3950);

       Bag YSLLouLou = new Bag((Type)Brand.YSL, Type.LouLou_Puffer, "Brown Quilted Suede", 2150);
       Bag YSLJamie = new Bag((Type)Brand.YSL, Type.Jamie, "Magenta Boucle Tweed", 1950);
       Bag YSLRiveGauche = new Bag((Type)Brand.YSL, Type.Rive_Gauche_Tote, "White Linen and Black Leather", 1250);

       Bag PradaCrystal = new Bag((Type)Brand.Prada, Type.Crystal_Re_Edition, "Black with Artificial Crystals", 1720);
       Bag PradaCleo = new Bag((Type)Brand.Prada, Type.Cleo, "Desert Beige", 2400);

        ListOfAllBags = new List<Bag>() { FendiBaguette, FendiPeekaboo, FendiFendiFirst, FendiSunshine, GucciDionysus, GucciJackie, LouisVuittonKeepall, LouisVuittonPochetteMetis, LouisVuittonSpeedy, ChanelClassicFlap, Chanel19, HermesBirkin, DiorLadyDior, DiorSaddleBag, YSLLouLou, YSLJamie, YSLRiveGauche, PradaCrystal, PradaCleo};
        UserCollection = new List<Bag>() { };
        }



        public Bag AllBagPurchase()
        {
            Console.WriteLine("Please Select a bag that you would like to purchase: ");
            int index = 1;
            foreach (Bag b in ListOfAllBags)
            {
                Console.WriteLine(index + ". " + " \t" + b.Brand + " \t" + b.Type + " in " + b.Color + " Price: $" + b.Price);
                index++;
            }
            return ListOfAllBags[Convert.ToInt32(Console.ReadLine()) - 1];
        }



        public Bag SelectedBagPurchase()
        {
            int index = 1;
            foreach (var value in Enum.GetValues(typeof(Brand)))
            {
                Console.WriteLine(index + ". " + value);
                index++;
            }
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Select a bag from " + ((Brand)choice - 1) + " that you would like to purchase: ");
            List<Bag> selectedBrands = (from b in ListOfAllBags
                                        where b.Brand == ((Brand)choice - 1)
                                        select b).ToList();
            int j = 1;
            foreach (var selectedBrand in selectedBrands)
            {
                Console.WriteLine(j + ". " + selectedBrand.Brand + " \t" + selectedBrand.Type + " \t" + selectedBrand.Color + " \t" + selectedBrand.Price);
                j++;
            }
            return selectedBrands[Convert.ToInt32(Console.ReadLine()) - 1];
        }



        public void ViewUserCollection()
        {
            if(!UserCollection.Any())
            {
                Console.WriteLine("Your collection is looking a little bare... perhaps it's time to treat yo-self!");
            }else{
                Console.WriteLine("Your collection is impressive!");
                int index = 1;
                foreach (Bag b in UserCollection)
                {
                    Console.WriteLine(index + ". " + " \t" + b.Brand + " \t" + b.Type + " in " + b.Color + " Price: $" + b.Price);
                    index++;
                }
            }
        }

        public Bag SellBag()
        {

             Console.WriteLine("Please Select a bag that you would like to sell: ");
             int index = 1;
             foreach (Bag b in UserCollection)
             {
               Console.WriteLine(index + ". " + " \t" + b.Brand + " \t" + b.Type + " in " + b.Color + " Price: $" + b.Price);
               index++;
             }
                return UserCollection[Convert.ToInt32(Console.ReadLine()) - 1];
        }
           
     
    }
}
