using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinCount : MonoBehaviour
{    
    public GameObject[] m_activePins;

    public int CountPins()
    {
        m_activePins = GameObject.FindGameObjectsWithTag("Pin");
        Debug.Log(m_activePins.Length);

        return m_activePins.Length;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            CountPins();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            CountPins();
        }
    }
}
