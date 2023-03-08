// Eternal Quest Program    Week 09-10
// Author : Nelson Mathurent
// Date:    Mar 07, 2023

public class NegativeGoal : Goal
{
    // Constructor that has two parameters, the activity name and the description.
    public NegativeGoal(string goalType, string goalName, string goalDescription, int goalPoints): base(goalType, goalName, goalDescription,goalPoints)
    {
        this.SetGoalPoints(goalPoints * -1);
    }

    public override string DisplayGoal() {
        string goalSelected;
        goalSelected = this.IsComplete() ? "X": " ";
        return $"[{goalSelected}] {this.GetGoalName()} ({this.GetGoalDescription()})";
    }


    public override Boolean IsComplete() {
        return false;
    }

    public override int RecordEvent() {
        if (this.IsComplete()) {
            return 0;
        } else {
            return this.GetGoalPoints();
        }
    }

    public override string GetStringRepresentation() {
        return $"EternalGoal:{this.GetGoalName()}|{this.GetGoalDescription()}|{this.GetGoalPoints()}";
    }
}

