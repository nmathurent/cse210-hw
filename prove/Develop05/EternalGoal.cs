// Eternal Quest Program    Week 09-10
// Author : Nelson Mathurent
// Date:    Mar 05, 2023

public class EternalGoal : Goal
{
    // Constructor that has two parameters, the activity name and the description.
    public EternalGoal(string goalType, string goalName, string goalDescription, int goalPoints): base(goalType, goalName, goalDescription,goalPoints)
    {
    }

    public override string DisplayGoal() {
        string goalSelected;
        goalSelected = this.IsComplete() ? "X": "";
        return $"[{goalSelected}] {this.GetGoalName()} ({this.GetGoalDescription()})";
    }


    public override Boolean IsComplete() {
        return false;
    }

    public override int RecordEvent() {
        Console.WriteLine($"Eternal Goal:  {this.GetGoalType()} ==> this.GetGoalPoints()");
        if (this.IsComplete()) {
            return 0;
        } else {
            return this.GetGoalPoints();
        }
    }
}

