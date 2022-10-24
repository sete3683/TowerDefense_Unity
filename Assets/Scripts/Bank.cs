using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Bank : MonoBehaviour
{
    [SerializeField, Range(0, 9999)] private int maxMoney;
    [SerializeField, Range(0, 9999)] private int startMoney;
    [SerializeField] private TextMeshProUGUI moneyText;
    private int curMoney;

    public static Bank instance;

    private void Awake()
    {
        startMoney = Mathf.Min(maxMoney, startMoney);
        curMoney = startMoney;
        UpdateMoneyText();

        instance = this;
    }

    public void Deposit(int amount)
    {
        curMoney = Mathf.Min(maxMoney, curMoney + amount);
        UpdateMoneyText();
    }

    public void Withdraw(int amount)
    {
        curMoney = Mathf.Max(0, curMoney - amount);
        UpdateMoneyText();
    }

    public bool CanWithdraw(int amount)
    {
        return curMoney >= amount;
    }

    private void UpdateMoneyText()
    {
        moneyText.text = curMoney.ToString();
    }
}
