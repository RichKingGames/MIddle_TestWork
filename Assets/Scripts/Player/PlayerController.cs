using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private PlayerView _view;
    [SerializeField]
    private PlayerModel _model;

    [SerializeField]
    private ScoreController _score;
    [SerializeField]
    private PanelController _panel;


    private void Awake()
    {
        _model.StartPosition = transform.position;
    }
    public void ChangePosition(Vector2 targetPos)
    {
        if ((Vector2)transform.position != targetPos)
            transform.position = Vector2.MoveTowards(transform.position, targetPos, _model.Speed * Time.deltaTime);
    }

    public void Init()
    {
        transform.position = _model.StartPosition;
        _model.CurrentHealth = _model.MaxHealth;

        _view.Init();
    }

    public void GetFood(int healthCount)
    {
        if (_model.CurrentHealth + healthCount < _model.MaxHealth)
            _model.CurrentHealth += healthCount;
        else
            _model.CurrentHealth = _model.MaxHealth;

        _score.SetScore();
    }

    public void GetHit(int damage)
    {
        if (_model.CurrentHealth - damage > 0)
            _model.CurrentHealth -= damage;
        else
        {
            _model.CurrentHealth = 0;
            _panel.ActivatePanel(false);
        }

        _view.RefreshHeathText();       
    }

    public string GetHealth()
    {
        return _model.CurrentHealth.ToString();
    }
}
