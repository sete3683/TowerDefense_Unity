using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] private int maxHealth = 5;
    private int curHealth;

    private void OnEnable()
    {
        curHealth = maxHealth;
    }

    private void OnParticleCollision(GameObject other)
    {
        if (curHealth <= 0)
            gameObject.SetActive(false);
    }
}
