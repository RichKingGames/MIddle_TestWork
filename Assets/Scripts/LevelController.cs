using System;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    [SerializeField]
    private LevelView _view;
    [SerializeField]
    private LevelModel _model;

    [SerializeField]
    private ControllerContainer _container;


    private void Awake()
    {
        _model.CurrentLevel = 0;
        _model.LevelCount = _model.LevelPrefabs.Length;
    }
    public void ResetCurrentLevel()
    {
        Destroy(_model.CurrentLevelObject);
        _model.CurrentLevelObject = Instantiate(_model.LevelPrefabs[_model.CurrentLevel]);
        _container.PlayerController.Init();
        _container.ScoreController.Init();
    }

    public void NextLevel()
    {
        _model.CurrentLevel++;
        if (_model.CurrentLevel == _model.LevelCount)
            _model.CurrentLevel = 0;

        Destroy(_model.CurrentLevelObject);
        _model.CurrentLevelObject = Instantiate(_model.LevelPrefabs[_model.CurrentLevel]);
        _container.PlayerController.Init();
        _container.ScoreController.Init();
    }
}