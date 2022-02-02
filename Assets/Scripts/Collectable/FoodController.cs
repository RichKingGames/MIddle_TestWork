using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodController : MonoBehaviour
{
    [SerializeField]
    private FoodModel _model;
    [SerializeField]
    private FoodView _view;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var player = collision.gameObject.GetComponent<PlayerController>();

        if (player)
            player.GetFood(_model.HealthCount);

        Destroy(gameObject);
    }
}
