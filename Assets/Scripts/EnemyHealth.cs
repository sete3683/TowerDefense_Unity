using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] private int maxHealth;
    private EnemyMoney enemyMoney;
    private int curHealth;

    private void Awake()
    {
        enemyMoney = GetComponent<EnemyMoney>();
    }

    private void OnEnable()
    {
        curHealth = maxHealth;
    }

    private void OnParticleCollision(GameObject other)
    {
        if (--curHealth <= 0)
        {
            enemyMoney.Reward();
            gameObject.SetActive(false);
        }
    }
}
