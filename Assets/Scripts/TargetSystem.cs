using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSystem : MonoBehaviour
{
    [SerializeField] private Transform head;
    [SerializeField] private Transform target;
    [SerializeField, Range(0f, float.MaxValue)] private float radius;

    public Transform Target { get; }
    public bool HasTarget { get; set; }

    void Update()
    {
        FindTarget();
        AimTarget();
    }

    private void FindTarget()
    {
        Collider[] targets = Physics.OverlapSphere(transform.position, radius, 1 << 6);
        HasTarget = targets.Length > 0;

        float minDistance = float.MaxValue;
        float distance;

        foreach (Collider collider in targets)
        {
            distance = Vector3.Distance(collider.transform.position, transform.position);

            if (distance < minDistance)
            {
                minDistance = distance;
                target = collider.transform;
            }
        }
    }

    private void AimTarget()
    {
        head.LookAt(target);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, radius);
    }
}
