using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour
{
    private const float HORIZONTAL_VELOCITY = .05f;

    [SerializeField] private GameObject bombPrefab;
    [SerializeField] private Transform bombSpawnPoint;

    private float horizontalVelocity = HORIZONTAL_VELOCITY;
    private Vector3 positionHolder;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        horizontalVelocity = -horizontalVelocity;
    }

    private void Update()
    {
        positionHolder = transform.position;
        positionHolder.x += horizontalVelocity;
        transform.position = positionHolder;

        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(bombPrefab, bombSpawnPoint.position, Quaternion.identity);
        }
    }
}
