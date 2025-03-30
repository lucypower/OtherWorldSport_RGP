using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroppedBallRespawn : MonoBehaviour
{
    private Vector3 m_startLocation;

    private void Awake()
    {
        m_startLocation = transform.position;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            transform.position = m_startLocation;
        }
    }
}
