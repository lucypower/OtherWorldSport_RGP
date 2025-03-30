using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveHitPins : MonoBehaviour
{
    Pins[] m_pins;
    ScoreSystem m_scoreSystem;
    PinCount m_pinCount;

    public bool m_bowling = true;
    // TODO: NEED SOMETHING TO LET THIS KNOW TO GET ARRAY OF PINS ON FIRST ROLL< NEED BOOL SOMEWHERE
    // TODO: KEEP TRACK OF WHAT BOWL IT IS SO SCORE CAN BE CALCULATED CORRECTLY / HAVE IT REURN THE NUMBER OF PINS HIT NOT LEFT

    public GameObject[] m_activePins; // TODO: could turn to a list once instantiating pins is implemented
  
    private void Update()
    {
        if (m_bowling)
        {
            m_bowling = false;

            m_scoreSystem = GetComponent<ScoreSystem>();
            m_pinCount = GetComponent<PinCount>();

            
        }
    }

    public int CountPins()
    {
        m_activePins = GameObject.FindGameObjectsWithTag("Pin");
        Debug.Log(m_activePins.Length);

        m_pins = GameObject.Find("Pins(Clone)").GetComponentsInChildren<Pins>();

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

            for (int i = 0; i < m_pins.Length; i++)
            {
                if (m_pins[i].m_isKnockedOver)
                {
                    m_scoreSystem.m_score++;
                    Destroy(m_pins[i].gameObject);
                    m_bowling = true;
                    Invoke(nameof(CountPins), 0.5f);
                }
            }

            Destroy(other.gameObject);
        }
    }

    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.CompareTag("Ball"))
    //    {
    //        CountPins();
    //    }
    //}

    //public int CountPins()
    //{
    //    m_activePins = GameObject.FindGameObjectsWithTag("Pin");
    //    Debug.Log(m_activePins.Length);

    //    return m_activePins.Length;
    //}
}
