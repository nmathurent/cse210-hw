using System.IO;
// Eternal Quest Program    Week 09-10
// Author : Nelson Mathurent
// Date:    Mar 01, 2023

public class ProcessGoals
{
    private List<Goal> _goalList = new List<Goal>();
    private int _currentScore = 0;

    public int GetTotalScore() {
        return _currentScore;
    }
    public void SetTotalScore(int currentScore) {
        _currentScore = currentScore;
    }

    public void AddNewGoal() {
        string typeOfGoal;
        string typeOfGoalDesc = "";
        string goalName;
        string goalDesc;
        int goalPoints = 0;
        int numberOfTimes = 0;
        int extraBonus = 0;
        Boolean isNumerical = false;

        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("   1. Simple Goal");
        Console.WriteLine("   2. Eternal Goal");
        Console.WriteLine("   3. Checklist Goal");
        Console.WriteLine("   4. Negative Goal");
        Console.Write("Which type of goal would you like to create? ");
        typeOfGoal = Console.ReadLine();

        switch (typeOfGoal)
        {
                case "1":
                    typeOfGoalDesc = "SimpleGoal";
                    break;
                case "2":
                    typeOfGoalDesc = "EternalGoal";
                    break;
                case "3":
                    typeOfGoalDesc = "ChecklistGoal";
                    break;
                case "4":
                    typeOfGoalDesc = "NegativeGoal";
                    break;
        }
        Console.Write("What is the name of your goal? ");
        goalName = Console.ReadLine();
        Console.Write("What is the short description of it? ");
        goalDesc = Console.ReadLine();

        while (!isNumerical) {
                Console.Write("What is the amount of points associated with this goal? ");  
                isNumerical = int.TryParse(Console.ReadLine(), out goalPoints); 
        }

        if (typeOfGoal == "3") {
 
            // Validate the user enter a  numeric value
            isNumerical = false;
            while (!isNumerical) {
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");  
                isNumerical = int.TryParse(Console.ReadLine(), out numberOfTimes); 
            }
            // Validate the user enter a  numeric value
            isNumerical = false;
            while (!isNumerical) {
                Console.Write("What is the bonus for accomplishing it that many times? ");  
                isNumerical = int.TryParse(Console.ReadLine(), out extraBonus); 
            }
        }
        Console.WriteLine($"{typeOfGoalDesc} {goalName} {goalDesc} {goalPoints}");
        switch (typeOfGoal)
        {
                case "1":
                    _goalList.Add(new SimpleGoal(typeOfGoalDesc, goalName, goalDesc, goalPoints ));
                    break;
                case "2":
                    _goalList.Add(new EternalGoal(typeOfGoalDesc, goalName, goalDesc, goalPoints ));
                    break;
                case "3":
                    _goalList.Add(new CheckListGoal(typeOfGoalDesc, goalName, goalDesc, goalPoints, numberOfTimes, extraBonus ));
                    break;
                case "4":
                    _goalList.Add(new NegativeGoal(typeOfGoalDesc, goalName, goalDesc, goalPoints ));
                    break;
        }
        // SimpleGoal goal = new SimpleGoal(typeOfGoalDesc, goalName, goalDesc, goalPoints );
        // _goalList.Add(goal);
    }

    public void ListGoals() {
        int goalCount = 0;
        Console.WriteLine("The goals are:");
        foreach (Goal goal in _goalList)
        {
            goalCount += 1;
            Console.WriteLine($"{goalCount}. {goal.DisplayGoal()}" );
        }
    }

    public void RecordEvent() {
        int goalCount = 0;
        int goalNumber = 0;
        int numberOfPointsEarned = 0;
        Boolean isNumerical = false;

        Console.WriteLine("The goals are:");
        foreach (Goal goal in _goalList)
        {
            goalCount += 1;
            Console.WriteLine($"{goalCount}. {goal.GetGoalName()}" );
        }
        // Validate the user enter a  numeric value
        isNumerical = false;
        while (!isNumerical) {
            Console.Write("Which goal did you accomplish? ");  
            isNumerical = int.TryParse(Console.ReadLine(), out goalNumber); 
        }
        numberOfPointsEarned = _goalList[goalNumber - 1].RecordEvent();
        _currentScore += numberOfPointsEarned;
        string earnedLost = _goalList[goalNumber - 1].GetGoalType() == "NegativeGoal" ? "lost":"earned";
        Console.WriteLine($"Congratulations! You have {earnedLost} {numberOfPointsEarned} points!" );
        Console.WriteLine($"You now have {_currentScore} points.\n" );
    }

    public void SaveGoals(){
        string fileName = RequestFileName();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            // Writing curren score to the file
            outputFile.WriteLine($"{this._currentScore}");
    
            // Writing goals to the file
            foreach (Goal goal in _goalList)
            {
                outputFile.WriteLine($"{goal.GetStringRepresentation()}");
                Console.WriteLine($"{goal.GetStringRepresentation()}");
            }
        }
    }

    public void LoadGoals(){
        string fileName = RequestFileName();
        int    lineNo   = 0;

        // Remove all goals from the list
        _goalList.Clear();

        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            lineNo += 1;
            if (lineNo == 1) {
                _currentScore = int.Parse(line);
            } else {
                _goalList.Add(CreateGoal(line));
            }
        }
    }

    public string RequestFileName(){
        string fileName = "";
        // Validate the filename is entered by the user and it is not leaved blank
        while (fileName == "") {
            Console.Write("What is the filename for the goal file? ");  
            fileName = Console.ReadLine(); 
        }
        return fileName;
    }

    public Goal CreateGoal(string line){
        // Following line is used to extract the Type of Goal from the line
        string typeOfGoal = line.Substring(0, line.IndexOf(":"));
            
        // Split each line of the file in an arry of strings
        string[] parts = line.Split("|");

        string goalName = parts[0].Substring(parts[0].IndexOf(":") + 1);
        string goalDesc = parts[1];
        int    goalPoints = int.Parse(parts[2]);
        switch (typeOfGoal)
        {
            case "SimpleGoal":
                Boolean   goalCompleted = Boolean.Parse(parts[3]);
                SimpleGoal goalS = new SimpleGoal(typeOfGoal, goalName, goalDesc, goalPoints);
                goalS.SetGoalCompleted(goalCompleted);
                return goalS;
            case "EternalGoal":
                EternalGoal goalE = new EternalGoal(typeOfGoal, goalName, goalDesc, goalPoints);
                return goalE;
            case "ChecklistGoal":
                int    extraBonus    = int.Parse(parts[3]);
                int    numberOfTimes = int.Parse(parts[4]);
                int    numberCompleted = int.Parse(parts[5]);
                CheckListGoal goalC = new CheckListGoal(typeOfGoal, goalName, goalDesc, goalPoints, numberOfTimes, extraBonus);
                goalC.SetNumberCompleted(numberCompleted);
                return goalC;
            case "NegativeGoal":
                NegativeGoal goalN = new NegativeGoal(typeOfGoal, goalName, goalDesc, goalPoints);
                return goalN;
            default:
                return new Goal(typeOfGoal, goalName, goalDesc, goalPoints);;
        }
    }

    public void DisplayUserScore(){

        Console.WriteLine($"\nYou have {this._currentScore} points.\n");  
 
    }

}

