using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsMaterialChange : MonoBehaviour
{
    [SerializeField] private PhysicMaterial m_physics;    

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Alley"))
        {
            GetComponent<Collider>().material = m_physics;
        }
    }
}
