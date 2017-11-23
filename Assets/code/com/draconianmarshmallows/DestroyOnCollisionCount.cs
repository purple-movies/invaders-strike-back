using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnCollisionCount : MonoBehaviour
{
    private int hitPoints = 10;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        subtrackLife();
    }

    private void OnParticleCollision(GameObject other)
    {
        subtrackLife();
    }

    private void subtrackLife()
    {
        hitPoints--;
        if (hitPoints < 0) Destroy(gameObject);

        Debug.Log("hit points : " + hitPoints);
    }
}
