// Eternal Quest Program    Week 09-10
// Author : Nelson Mathurent
// Date:    Mar 01, 2023

public class ProcessGoals
{
    private List<Goal> _goalList;
    private int _totalScore;

    public int GetTotalScore() {
        return _totalScore;
    }
    public void GetTotalScore(int totalScore) {
        _totalScore = totalScore;
    }

    public void AddNewGoal() {
        return $"{this.GetGoalName()} ({this.GetGoalDescription()})";
    }
}

