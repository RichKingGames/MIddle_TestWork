using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreModel : MonoBehaviour
{
    public int CurrentScore = 0;

    public int TargetScore;

    public void Initialize(int targetScore)
    {
        CurrentScore = 0;
        TargetScore = targetScore;
    }
    public void Initialize()
    {
        CurrentScore = 0;
        TargetScore = 10;
    }
}
