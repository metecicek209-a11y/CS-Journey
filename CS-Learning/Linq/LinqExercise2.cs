using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Learning.Linq
{
    public abstract class User
    {
        public string Department { get; set; }
        public int Wage { get; }
        public User(string _department, int _wage)
        {

            Department = _department;
            Wage = _wage;
        
        }
    }
    public class ComputerEngineer : User
    {
        public ComputerEngineer(string _department, int _wage) : base(_department, _wage) { }
        // we need to use public in constructores
    
    }
    internal class LinqExercise2
    {

        public static void Run()
        {
            //   User mete = new User("Engineering " , 24000);
            // user is abstract therefore we cant create an object using it
            ComputerEngineer Mete = new ComputerEngineer("Engineering", 240000);
            ComputerEngineer Marla = new ComputerEngineer("Engineering", 40000);
            ComputerEngineer Dino = new ComputerEngineer("Engineering", 50000);

            List<User>  Database= new List<User>();
            Database.Add(Dino);
            Database.Add(Marla);
            Database.Add(Mete);


            RankWages(Database);
            FindLowest(Database);
        }
        public static void RankWages(List<User> userList)
        {
            var list = userList.OrderByDescending(x => x.Wage);
            //List<User> myList = userList.OrderByDescending(x => x.Wage);
            foreach(User element in list)
            {
                Console.WriteLine($"{element.Department} {element.Wage}");
            }
        }
        public static void FindLowest(List<User> userList)
        {
            int lowestWage = userList.Min(x => x.Wage);
            User lowestWageHolder = userList.Where(x => x.Wage == lowestWage).FirstOrDefault();
            // where returns a list not a single object
            Console.WriteLine($"Lowest wage holders department is {lowestWageHolder.Department}" +
                $"and his/her wage is {lowestWageHolder.Wage}");
        
        
        }
    }
}
   