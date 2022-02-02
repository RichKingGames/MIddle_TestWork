using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;

public class PanelView : MonoBehaviour
{
    [SerializeField]
    private PanelController _controller;
    [SerializeField]
    private PanelModel _model;

    [SerializeField]
    private GameObject _panel;

    [SerializeField]
    private TextMeshProUGUI _scoreText;
    [SerializeField]
    private TextMeshProUGUI _healthText;

    [SerializeField]
    private Button _mainButton;
    [SerializeField]
    private Text _buttonText;


    public void ActivatePanel()
    {
        _mainButton.onClick.RemoveAllListeners();
        _mainButton.onClick.AddListener(() => _model.ButtonAction());
        _mainButton.onClick.AddListener(() => _panel.SetActive(false));

        _scoreText.text = $"Score: {_model.Score}";
        _healthText.text = $"Health: {_model.Health}";
        _buttonText.text = _model.ButtonText;

        _panel.SetActive(true);
    }
}
