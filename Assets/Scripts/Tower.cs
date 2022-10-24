using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    [SerializeField] private int price;

    public bool CreateTower(Transform transform)
    {
        if (Bank.instance.CanWithdraw(price))
        {
            Bank.instance.Withdraw(price);
            Instantiate(gameObject, transform);

            return true;
        }
        else
        {
            return false;
        }
    }
}
