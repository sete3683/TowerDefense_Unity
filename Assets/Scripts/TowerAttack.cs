using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerAttack : MonoBehaviour
{
    [SerializeField] private int damage;
    [SerializeField] private ParticleSystem attackParcitle;

    private TargetSystem targetSystem;

    void Start()
    {
        targetSystem = GetComponent<TargetSystem>();
    }

    private void Update()
    {
        var emissionModule = attackParcitle.emission;
        emissionModule.enabled = targetSystem.HasTarget;
    }
}
