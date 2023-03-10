using System;

class Program
{
    static void Main(string[] args)
    {
        string optionSel = "";

        ProcessGoals runProcess = new ProcessGoals();

        while (optionSel != "6"){
            //Console.Clear();
            runProcess.DisplayUserScore();
            Console.WriteLine("Menu options:");
            Console.WriteLine("   1. Create New Goal");
            Console.WriteLine("   2. List Goals");
            Console.WriteLine("   3. Save Goals");
            Console.WriteLine("   4. Load Goals");
            Console.WriteLine("   5. Record Event");
            Console.WriteLine("   6. Quit");
            Console.Write("Select a choice from the menu: ");
            optionSel = Console.ReadLine();

            switch (optionSel)
            {
                case "1":
                    runProcess.AddNewGoal();
                    break;
                case "2":
                    runProcess.ListGoals();
                    break;
                case "3":
                    runProcess.SaveGoals();
                    break;
                case "4":
                    runProcess.LoadGoals();
                    break;
                case "5":
                    runProcess.RecordEvent();
                    break;
            }
        }
        

    }
        
}