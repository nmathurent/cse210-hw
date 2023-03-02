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

    public string DisplayGoal(Boolean selected) {
        return $"{this.GetGoalName()} ({this.GetGoalDescription()})";
    }

    public override int GetEarnedPoints() {
        return this.GetGoalPoints();
    }
}

