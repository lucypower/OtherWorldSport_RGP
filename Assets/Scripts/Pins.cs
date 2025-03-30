using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pins : MonoBehaviour
{
    public bool m_isKnockedOver;

    private void Start()
    {
        m_isKnockedOver = false;
    }

    // TODO: EMPTY GAMEOBJECTS OF PIN POSITIONS, DESTROY ON KNOCKING DOWN AND THEN RE INSTANTIATE THEM, INSTEAD OF SETTING NOT ACTIVE
    // TODO: ADAPT SO PINS THAT ARE KNOCKED OVER BY PINS COUNT TOO

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball") || collision.gameObject.CompareTag("Pin"))
        {
            m_isKnockedOver = true;
        }
    }
}
