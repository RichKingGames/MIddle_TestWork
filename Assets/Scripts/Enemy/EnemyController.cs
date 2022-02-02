using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField]
    private EnemyModel _model;
    [SerializeField]
    private EnemyView _view;

    private void Update()
    {
        if(transform.position != _model.TargetPoint.position)
        {
            transform.position = Vector2.MoveTowards(transform.position,
            _model.TargetPoint.position, _model.MoveSpeed * Time.deltaTime);
        }
        else
        {
            _model.TargetPoint = _model.TargetPoint == _model.FirstPoint ? 
                _model.SecondPoint : _model.FirstPoint;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var player = collision.GetComponent<PlayerController>();
        if (player)
            player.GetHit(_model.Damage);
    }
}
