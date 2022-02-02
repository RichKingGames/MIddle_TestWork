using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelController : MonoBehaviour
{
    [SerializeField]
    private PanelView _view;
    [SerializeField]
    private PanelModel _model;


    [SerializeField]
    private PlayerController _player;
    [SerializeField]
    private ScoreController _score;
    [SerializeField]
    private LevelController _level;

    public void ActivatePanel(bool isWin)
    {
        _player.Init();

        if (isWin)
        {
            _model.ButtonAction = () => _level.NextLevel();
            _model.ButtonText = "Next";
        }
        else
        {
            _model.ButtonAction = () => _level.ResetCurrentLevel();
            _model.ButtonText = "Reset";
        }
            
        
        _model.Health = _player.GetHealth();
        _model.Score = _score.GetScore();
        _view.ActivatePanel();
    }
}
