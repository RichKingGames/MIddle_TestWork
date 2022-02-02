using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreController : MonoBehaviour
{
    [SerializeField]
    private ScoreModel _model;
    [SerializeField]
    private ScoreView _view;

    [SerializeField]
    private PanelController _panels;

    private void Start()
    {
        Init();
    }
    public void Init()
    {
        _model.Initialize();
        _view.SetGUIScore();
    }
    public void SetScore()
    {
        _model.CurrentScore++;
        _view.SetGUIScore();

        if (_model.TargetScore == _model.CurrentScore)
            _panels.ActivatePanel(true);
    }

    public string GetScore()
    {
        return $"{_model.CurrentScore}/{_model.TargetScore}";
    }
}
