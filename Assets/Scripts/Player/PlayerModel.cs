using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerModel : MonoBehaviour
{
    public int MaxHealth = 100;
    public int CurrentHealth = 100;
    public float Speed = 5;
    public int CollectedItemCount = 0;
    public Vector2 StartPosition;

    public void Init()
    {
        CurrentHealth = 100;
        CollectedItemCount = 0;
    }

}
