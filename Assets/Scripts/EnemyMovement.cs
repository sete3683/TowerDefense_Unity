using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField, Range(0f, float.MaxValue)] private float moveSpeed = 1f;
    private EnemyMoney enemyMoney;

    private void Awake()
    {
        enemyMoney = GetComponent<EnemyMoney>();
    }

    private void OnEnable()
    {
        StartCoroutine(Move());
    }

    private void OnDisable()
    {
        ResetPosition();
    }

    private IEnumerator Move()
    {
        foreach (Tile tile in PathManager.Instance.path)
        {
            Vector3 startPos = transform.position;
            Vector3 endPos = tile.transform.position;
            float movePer = 0f;

            transform.LookAt(endPos);

            while (movePer < 1f)
            {
                movePer += moveSpeed * Time.deltaTime;
                transform.position = Vector3.Lerp(startPos, endPos, movePer);

                yield return new WaitForEndOfFrame();
            }
        }

        enemyMoney.Penalty();
        gameObject.SetActive(false);
    }

    private void ResetPosition()
    {
        transform.position = transform.parent.position;
    }
}
