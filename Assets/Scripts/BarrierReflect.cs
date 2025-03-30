using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrierReflect : MonoBehaviour
{
    [SerializeField] private float m_bounce;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            Rigidbody ballRB = collision.rigidbody;

            ballRB.AddExplosionForce(m_bounce, collision.contacts[0].point, 2);
        }
    }
}
