using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowPhysics : MonoBehaviour
{
    [SerializeField] float arrowSpeed = 20f;
    [SerializeField] Rigidbody2D myRigidBody;
    [SerializeField] int arrowDamage = 50;

    // Start is called before the first frame update
    void Start()
    {
        myRigidBody.velocity = transform.right * arrowSpeed;
    }

    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        var health = otherCollider.GetComponent<Enemy>();

        if (health != null)
        {
            health.TakeDamage(arrowDamage);
            Destroy(gameObject);
        }
        Destroy(gameObject);
    }
}
