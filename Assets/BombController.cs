using UnityEngine;

public class BombController : MonoBehaviour
{
    [SerializeField] Renderer spriteRenderer;
    [SerializeField] Collider2D circleCollider;
    [SerializeField] Rigidbody2D body;
    [SerializeField] GameObject explosionParticleSystem;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(spriteRenderer);
        Destroy(circleCollider);
        Destroy(body);
        explosionParticleSystem.SetActive(true);
        Destroy(gameObject, 3f);
    }
}
