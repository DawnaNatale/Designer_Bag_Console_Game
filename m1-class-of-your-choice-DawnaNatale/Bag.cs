using System;
using System.Collections.Generic;

namespace Choose_Your_Class
{
    public class Bag
    {

        public string Color { get; set; }
        public int Price { get; set; }
        public Type Type { get; set; }
        public Brand Brand { get; set; }

        public Bag()
        {

        }

        public Bag(Type _Brand, Type _Type, string _Color, int _Price)
        {
            this.Brand = (Brand)_Brand;
            this.Type = _Type;
            this.Color = _Color;
            this.Price = _Price;
        }


        //public void ChooseType()
        //{
        //    int index = 1;
        //    foreach (var value in Enum.GetValues(typeof(Type)))
        //    {
        //        Console.WriteLine(index + ". " + value);
        //        index++;
        //    }
        //    int choice = Convert.ToInt32(Console.ReadLine());
        //    Type = (Type)choice;
        //}

    }

    public enum Type
    {
        Baguette,
        Peekaboo,
        Sunshine_Tote,
        Fendi_First,
        Dionysus,
        Jackie,
        Keepall_55,
        Pochette_Metis,
        Speedy_30_Bandouliere,
        Classic_Flap,
        Chanel_19,
        Birkin_30,
        Lady_Dior,
        Saddle_Bag,
        LouLou_Puffer,
        Jamie,
        Rive_Gauche_Tote,
        Crystal_Re_Edition,
        Cleo

    }

    public enum Brand
    {
        Fendi,
        Gucci,
        Louis_Vuitton,
        Chanel,
        Hermes,
        Dior,
        YSL,
        Prada
    }
}