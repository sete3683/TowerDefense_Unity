using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoney : MonoBehaviour
{
    [SerializeField] private int moneyReward;
    [SerializeField] private int moneyPenalty;

    public void Reward()
    {
        Bank.instance.Deposit(moneyReward);
    }

    public void Penalty()
    {
        Bank.instance.Withdraw(moneyPenalty);
    }
}
