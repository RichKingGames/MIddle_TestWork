using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class PlayerView : MonoBehaviour
{
    [SerializeField]
    private PlayerModel _model;
    [SerializeField]
    private PlayerController _controller;

    [SerializeField]
    private TextMeshProUGUI _healthText;

    private Vector2 _lastMousePosition;


    private void Start()
    {
        Init();
    }

    
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _lastMousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            _controller.ChangePosition(_lastMousePosition);
        }
        else
        {
            _controller.ChangePosition(_lastMousePosition);
        }
       
    }

    public void Init()
    {
        _lastMousePosition = _controller.transform.position;
        RefreshHeathText();
    }

    public void RefreshHeathText()
    {
        _healthText.text = $"Health: {_model.CurrentHealth}";
    }

}
