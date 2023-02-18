using System;

class Program
{
    static void Main(string[] args)
    {
        string optionSel = "";

        while (optionSel != "4"){
            Console.Clear();
            Console.WriteLine("Menu options:");
            Console.WriteLine("   1. Start breathing activity");
            Console.WriteLine("   2. Start reflecting activity");
            Console.WriteLine("   3. Start listing activity");
            Console.WriteLine("   4. Quit");
            Console.Write("Select a choice from the menu: ");
            optionSel = Console.ReadLine();

            switch (optionSel)
            {
                case "1":
                    BreathingActivity bActivity = new BreathingActivity("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                    bActivity.DisplayStartingMessage();
                    bActivity.RunBreathingActivity();
                    bActivity.DisplayEndingMessage();
                    break;
                case "2":
                    ReflectingActivity rActivity = new ReflectingActivity("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                    rActivity.DisplayStartingMessage();
                    rActivity.DisplayEndingMessage();
                    break;
                case "3":
                    ListingActivity lActivity = new ListingActivity("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                    lActivity.DisplayStartingMessage();
                    lActivity.DisplayEndingMessage();
                    break;
            }
        }
        

    }
        
}