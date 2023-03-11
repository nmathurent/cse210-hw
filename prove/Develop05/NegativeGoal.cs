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

}

