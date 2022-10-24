using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    [SerializeField] private GameObject enemy;
    [SerializeField] private int poolSize;
    [SerializeField] private float spawnTime;

    private GameObject[] pool;
    private WaitForSeconds spawnTimer;
    private int poolIndex;

    private void Start()
    {
        PopulatePool();
        spawnTimer = new WaitForSeconds(spawnTime);
        poolIndex = 0;
        StartCoroutine(Spawn());
    }

    private void PopulatePool()
    {
        pool = new GameObject[poolSize];

        for (int i = 0; i < poolSize; i++)
        {
            pool[i] = Instantiate(enemy, transform.position, Quaternion.identity, transform);
            pool[i].SetActive(false);
        }
    }

    private IEnumerator Spawn()
    {
        while (true)
        {
            if (!pool[poolIndex].activeSelf)
            {
                pool[poolIndex].SetActive(true);
                poolIndex = (poolIndex + 1) % poolSize;
            }

            yield return spawnTimer;
        }
    }
}
