using System;

namespace DIKUCanteen
{
    class Program
    {
        static void Main(string[] args){
            // Enitializes the canteen to only have 1 cup to reach limit fast. 
            var canteen = new Canteen("DIKU Canteen", 1);
            // Enitializes with a two students, and a CanteenBoardMember
            var s1 = new Student("Andreas", "Student", 25);
            var s2 = new Student("Himi", "Student", 24);
            var cbm1 = new CanteenBoardMember("Peter", "Student", 24);
            Console.WriteLine("------initalial setting-------");
            Console.WriteLine(canteen);
            Console.WriteLine($" Student 1 Has a cup: {s1.HasCup}");
            Console.WriteLine($" Student 2 Has a cup: {s2.HasCup}");
            Console.WriteLine($" CanteenBoardMember 1 Has a cup: {cbm1.HasCup}");
            Console.WriteLine("------student 1 takes a cup from the canteen-------");
            s1.TakeCup(canteen);
            Console.WriteLine($" Student 1 Has a cup: {s1.HasCup}");
            Console.WriteLine(canteen);
            Console.WriteLine("------student 2 tries to take a cup from the canteen, but is unsuccesfull-------");
            s2.TakeCup(canteen);
            Console.WriteLine($" Student 2 Has a cup: {s2.HasCup}");
            Console.WriteLine(canteen);
            Console.WriteLine("------CanteenBoardMember 1 buys a cup for the canteen-------");
            cbm1.BuyCup(canteen);
            Console.WriteLine(canteen);
            Console.WriteLine("------student 2 again tries to take a cup from the canteen, and is now succesfull-------");
            s2.TakeCup(canteen);
            Console.WriteLine($" Student 2 Has a cup: {s2.HasCup}");
            Console.WriteLine(canteen);
            Console.WriteLine("------Both student 1 and student 2 returns their cups to the canteen-------");
            s1.ReturnCup(canteen);
            s2.ReturnCup(canteen);
            Console.WriteLine(canteen);
            Console.WriteLine("------CanteenBoardmember 1 takes a cup from the canteen-------");
            cbm1.TakeCup(canteen);
            Console.WriteLine($" CanteenBoardmember 1 Has a cup: {cbm1.HasCup}");
            Console.WriteLine(canteen);
            Console.WriteLine("------CanteenBoardmember 1 tries to take a second cup from the canteen but is unsuccesfull-------");
            cbm1.TakeCup(canteen);
            Console.WriteLine($" CanteenBoardmember 1 Has a cup: {cbm1.HasCup}");
            Console.WriteLine(canteen);
            Console.WriteLine("---- CanteenBoardmember 1 tries to buy 5 additional cups exceeding the CupBudget of 5---");
            cbm1.BuyCup(canteen);
            Console.WriteLine(canteen);
            cbm1.BuyCup(canteen);
            Console.WriteLine(canteen);
            cbm1.BuyCup(canteen);
            Console.WriteLine(canteen);
            cbm1.BuyCup(canteen);
            Console.WriteLine(canteen);
            cbm1.BuyCup(canteen);
            Console.WriteLine(canteen);
            Console.WriteLine("---- CanteenBoardmember 1 is unable to buy the final cup because the budget is used up---");
        }
    }
}

