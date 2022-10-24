using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    [SerializeField] private bool isPlaceable;
    [SerializeField] private Tower tower;

    public bool IsPlaceable { get { return isPlaceable; } }

    private void OnMouseDown()
    {
        if (isPlaceable)
        {
            isPlaceable = !tower.CreateTower(transform);
        }
    }
}
