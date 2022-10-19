using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSystem : MonoBehaviour
{
    [SerializeField] private Transform head;
    [SerializeField] private Transform target;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        AimHead();
    }

    private void AimHead()
    {
        head.LookAt(target);
    }
}
