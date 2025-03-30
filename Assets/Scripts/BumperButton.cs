using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperButton : MonoBehaviour
{
    [SerializeField] private GameObject[] m_bumpers;
    GameManager m_gameManager;
    TurnManager m_turnManager;

    private void Awake()
    {
        m_gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        m_turnManager = GameObject.Find("CountPins").GetComponent<TurnManager>();
    }

    public void ButtonPressed()
    {
        Debug.Log("Pressed");

        if (!m_gameManager.m_gameStarted)
        {
            m_gameManager.m_gameStarted = true;
            m_gameManager.m_isFirstBowl = true;
            m_turnManager.StartGame();
        }
        else
        {
            for (int i = 0; i < m_bumpers.Length; i++)
            {
                if (m_bumpers[i].activeInHierarchy)
                {
                    m_bumpers[i].SetActive(false);
                }
                else
                {
                    m_bumpers[i].SetActive(true);
                }
            }
        }
    }

    public void ButtonReleased()
    {
        Debug.Log("Released");
    }
}
