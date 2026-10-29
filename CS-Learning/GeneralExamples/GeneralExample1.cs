using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Learning.GeneralExamples
{
    internal class GeneralExample1
    {
        public static void Run()
        {

            SpecialKeyboard F75 = new SpecialKeyboard("Redragon", "Wireless", 2200, 8);
            SpecialKeyboard Fly = new SpecialKeyboard("Redragon", "Mechanical", 950, 6);
            SpecialKeyboard Runner = new SpecialKeyboard("Redragon", "Membrane", 600, 4);
            SpecialKeyboard Kumara = new SpecialKeyboard("Redragon", "Mechanical", 1500, 10);
            SpecialKeyboard K552 = new SpecialKeyboard("Redragon", "Mechanical", 1200, 7);

            SpecialKeyboard G213 = new SpecialKeyboard("Logitech", "Membrane", 1800, 6);
            SpecialKeyboard G413 = new SpecialKeyboard("Logitech", "Mechanical", 2800, 10);
            SpecialKeyboard MXKeys = new SpecialKeyboard("Logitech", "Wireless", 3500, 8);
            SpecialKeyboard G915 = new SpecialKeyboard("Logitech", "Wireless", 6500, 12);
            SpecialKeyboard K120 = new SpecialKeyboard("Logitech", "Membrane", 450, 3);

            SpecialKeyboard K55 = new SpecialKeyboard("Corsair", "Membrane", 1900, 6);
            SpecialKeyboard K70 = new SpecialKeyboard("Corsair", "Mechanical", 4200, 11);
            SpecialKeyboard K65 = new SpecialKeyboard("Corsair", "Mechanical", 3200, 9);
            SpecialKeyboard K100 = new SpecialKeyboard("Corsair", "Mechanical", 7500, 12);
            SpecialKeyboard K57 = new SpecialKeyboard("Corsair", "Wireless", 2900, 7);


            List<SpecialKeyboard> Database = new List<SpecialKeyboard>();
            Database.Add(F75);
            Database.Add(Fly);
            Database.Add(Runner);
            Database.Add(Kumara);
            Database.Add(K552);

            Database.Add(G213);
            Database.Add(G413);
            Database.Add(MXKeys);
            Database.Add(G915);
            Database.Add(K120);

            Database.Add(K55);
            Database.Add(K70);
            Database.Add(K65);
            Database.Add(K100);
            Database.Add(K57);



            void BrandWriter(List<SpecialKeyboard> KeyboardList)
            {
                foreach(Keyboard value in KeyboardList)
                {
                    Console.WriteLine(value.Brand);
                }
            }

            void CheapestFinder(List<SpecialKeyboard> KeyboardList)
            {
                // minby finds the lowest number in the parenthesis type based on what
                // min returns an integer
                Keyboard CheapestKeyboard = KeyboardList.MinBy(x => x.Price);
                Console.Write($"From {CheapestKeyboard.Brand} with {CheapestKeyboard.Type} type" +
                    $" for a price of {CheapestKeyboard.Price} ");

            }
            void UpdatePrice(List<SpecialKeyboard> KeyboardList, string _brand, string _type, int _price , int NewPrice)
            {

                Keyboard SelectedKeyboard = KeyboardList.Where(x => x.Brand == _brand && 
                x.Type == _type && x.Price == _price).FirstOrDefault();
                int temp = SelectedKeyboard.Price;
                SelectedKeyboard.Price = NewPrice;

                Console.WriteLine($"The old price was {temp} and the new price is {SelectedKeyboard.Price} of {SelectedKeyboard.Brand}");
            
            
            }
            void OrderByLifeSpan(List<SpecialKeyboard> currentDatabase)
            {
                // order by ienumerable donduruyor list degil
                //List<Keyboard> orderedList = currentDatabase.OrderBy(x => x.LifeSpan).ToList();
                IEnumerable <Keyboard> orderedList = currentDatabase.OrderBy(x => x.LifeSpan);
                foreach(Keyboard current in orderedList)
                {
                    Console.WriteLine(current.Brand + "  " + current.Type + "  "+ current.LifeSpan);
                }
            }
            void FindCheapestInEachBrand(List<SpecialKeyboard> currentDatabase)
            {

            }
        }
        public abstract class Keyboard
        {
            public string Brand { get; set; }
            public string Type { get; }
            public int Price { get; set; }
            public int LifeSpan { get; }

            public Keyboard(string _brand, string _type, int _price, int _lifeSpan)
            {

                Brand = _brand;
                Type = _type;
                Price = _price;
                LifeSpan = _lifeSpan;
                
            }

        }
        public interface IWrite
        {
            public void Write<T>(T value );
        }

        // This list represents the keyboards that I have
        public class SpecialKeyboard : Keyboard, IWrite
        {
            public SpecialKeyboard(string _brand, string _type, int _price, int _lifeSpan)
                : base(_brand,_type,_price,_lifeSpan) { }

            public void Write<T>(T value)
            {
                Console.WriteLine(value);
            }

        }
        // A new list will be generated for the keyboard that I plan to purchase
    }
}
