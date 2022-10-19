using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] private int maxHealth = 5;
    private int curHealth;

    private void Start()
    {
        curHealth = maxHealth;
    }

    private void OnParticleCollision(GameObject other)
    {
        Destroy(gameObject);
    }
}
