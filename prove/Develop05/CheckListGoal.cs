// Eternal Quest Program    Week 09-10
// Author : Nelson Mathurent
// Date:    Mar 01, 2023

public class CheckListGoal : Goal
{
    private int _numberOfTimes;
    private int _numberCompleted;
    private int _extraBonus;

    public int GetNumberOfTimes() {
        return _numberOfTimes;
    }
    public void SetNumberOfTimes(int numberOfTimes) {
        _numberOfTimes = numberOfTimes;
    }

    public int GetExtraBonus() {
        return _extraBonus;
    }
    public void SetExtraBonus(int extraBonus) {
        _extraBonus = extraBonus;
    }
    public int GetNumberCompleted() {
        return _numberCompleted;
    }
    public void SetNumberCompleted(int numberCompleted) {
        _numberCompleted = numberCompleted;
    }

    // Constructor that has two parameters, the activity name and the description.
    public CheckListGoal(string goalType, string goalName, string goalDescription, int goalPoints, int numberOfTimes, int extraBonus): base(goalType, goalName, goalDescription,goalPoints)
    {
        _numberOfTimes = numberOfTimes;
        _extraBonus = extraBonus;
        _numberCompleted = 0;
    }

    public override string DisplayGoal() {
        string goalSelected;
        goalSelected = this.IsComplete() ? "X": " ";
        return $"[{goalSelected}] {this.GetGoalName()} ({this.GetGoalDescription()}) -- Currently completed: {this._numberCompleted}/{this._numberOfTimes}";
    }


    public override Boolean IsComplete() {
        return _numberCompleted < _numberOfTimes ? false:true;
    }

    public override int RecordEvent() {
        if (this.IsComplete()) {
            return 0;
        } else {
            _numberCompleted += 1;
            if (_numberCompleted == _numberOfTimes) { ShowCongratulations(this._extraBonus);}
            return _numberCompleted == _numberOfTimes ? this.GetGoalPoints() + this._extraBonus:this.GetGoalPoints();
        }
    }

    public override string GetStringRepresentation() {
        return $"ChecklistGoal:{this.GetGoalName()}|{this.GetGoalDescription()}|{this.GetGoalPoints()}|{this._extraBonus}|{this._numberOfTimes}|{this._numberCompleted}";
    }

    public void ShowCongratulations(int extraBonus)
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(5);

        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime)
        {
            currentTime = DateTime.Now;
           foreach (char letter in "*** Extra Points ***")
           {
             Console.Write($"{letter}");
             Thread.Sleep(100);
           }
           foreach (char letter in "*** Extra Points ***")
           {
             Console.Write("\b \b"); // Erase the characters
           }
           Console.Write($"  You have earned {extraBonus} points!");
           Thread.Sleep(600);
           foreach (char letter in "  You have earned {extraBonus} points!")
           {
             Console.Write("\b \b"); // Erase the characters
           }
        }
    }

}

