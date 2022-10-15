using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private float waitTime = 1f;

    void Start()
    {
        StartCoroutine(Move());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Move()
    {
        foreach (Path path in PathManager.instance.route)
        {
            transform.position = path.transform.position;
            yield return new WaitForSeconds(waitTime);
        }
    }
}
