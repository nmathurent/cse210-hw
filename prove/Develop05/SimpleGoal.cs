// Eternal Quest Program    Week 09-10
// Author : Nelson Mathurent
// Date:    Mar 01, 2023

public class SimpleGoal : Goal
{
    private Boolean _goalCompleted;

    public Boolean GetGoalCompleted() {
        return _goalCompleted;
    }
    public void SetGoalCompleted(Boolean goalCompleted) {
        _goalCompleted = goalCompleted;
    }

    // Constructor that has two parameters, the activity name and the description.
    public SimpleGoal(string goalType, string goalName, string goalDescription, int goalPoints): base(goalType, goalName, goalDescription,goalPoints)
    {
        _goalCompleted = false;
    }

    public override string DisplayGoal() {
        string goalSelected;
        goalSelected = this.IsComplete() ? "X": " ";
        return $"[{goalSelected}] {this.GetGoalName()} ({this.GetGoalDescription()})";
    }


    public override Boolean IsComplete() {
        return _goalCompleted;
    }

    public override int RecordEvent() {
        if (this.IsComplete()) {
            return 0;
        } else {
            _goalCompleted = true;
            return this.GetGoalPoints();
        }
    }
}

