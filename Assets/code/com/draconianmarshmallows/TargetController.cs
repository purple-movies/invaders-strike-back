using System;
using UnityEngine;

public class TargetController : MonoBehaviour
{
    [SerializeField] Renderer spriteRenderer;
    [SerializeField] Collider2D circleCollider;
    [SerializeField] Rigidbody2D body;
    [SerializeField] GameObject explosionParticleSystem;

    public Action<TargetController> onDestroyed;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //if (collision.otherCollider.tag.Equals("Bomb"))

        if (collision.collider.tag.Equals("Bomb"))
        {
            Debug.Log("bombs collide !!!");

            Destroy(spriteRenderer);
            Destroy(circleCollider);
            Destroy(body);
            explosionParticleSystem.SetActive(true);
            Destroy(gameObject, 3f);

            if (onDestroyed != null) onDestroyed(this);
        }
    }
}
