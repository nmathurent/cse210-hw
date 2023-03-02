// Eternal Quest Program    Week 09-10
// Author : Nelson Mathurent
// Date:    Mar 01, 2023

public class Goal
{
    private string _goalType;
    private string _goalName;
    private string _goalDescription;
    private int _goalPoints;

    // Getters / Setters

    public string GetGoalType() {
        return _goalType;
    }
    public void SetGoalType(string goalType) {
        _goalType = goalType;
    } 

    public string GetGoalName() {
        return _goalName;
    }
    public void SetGoalName(string goalName) {
        _goalName = goalName;
    }
    public string GetGoalDescription() {
        return _goalDescription;
    }
    public void SetGoalDescription(string goalDescription) {
        _goalDescription = goalDescription;
    }
    public int GetGoalPoints() {
        return _goalPoints;
    }
    public void SetGoalPoints(int goalPoints) {
        _goalPoints = goalPoints;
    } 

    // Constructor that has two parameters, one for the activity name and one for the description.
    public Goal(string goalType, string goalName, string goalDescription, int goalPoints)
    {
        _goalType = goalType;
        _goalName = goalName;
        _goalDescription = goalDescription;
        _goalPoints = goalPoints;
    }

    public virtual int GetEarnedPoints() {
        return 0;
    }

}