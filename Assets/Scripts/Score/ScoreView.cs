using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreView : MonoBehaviour
{
    [SerializeField]
    private ScoreController _controller;
    [SerializeField]
    private ScoreModel _model;

    [SerializeField]
    private TextMeshProUGUI _scoreText;

    public void SetGUIScore()
    {
        _scoreText.text = $"Score: {_model.CurrentScore}/{_model.TargetScore}";
    }
}
