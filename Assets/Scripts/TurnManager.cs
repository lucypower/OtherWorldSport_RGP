using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class TurnManager : MonoBehaviour
{
    GameManager m_gameManager;
    Pins[] m_pinsActive;
    ScoreSystem m_scoreSystem;
    RespawnBalls m_respawnBalls;

    [SerializeField] private GameObject m_pins;
    [SerializeField] private Transform m_pinsSpawn;
    [SerializeField] private TMP_Text m_text;
    [SerializeField] private GameObject m_pinSpawned;

    public int m_round;

    private void Awake()
    {
        m_gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        m_scoreSystem = GetComponent<ScoreSystem>();
        m_respawnBalls = GetComponent<RespawnBalls>();
    }

    public void StartGame()
    {
        SpawnPins();

        m_round = 1;
        m_text.text = "Round : " + m_round;

        m_scoreSystem.m_score = 0;
        m_scoreSystem.UpdateScore();
        
        //m_respawnBalls.SpawnBalls();
    }

    public void SpawnPins()
    {
        m_pinSpawned = Instantiate(m_pins, m_pinsSpawn.transform.position, Quaternion.identity);
        m_pinsActive = GameObject.Find("Pins(Clone)").GetComponentsInChildren<Pins>();
    }

    private void EndGame()
    {
        Destroy(m_pinSpawned, 1.5f);
        m_text.text = "Game Over!";
        m_gameManager.m_gameStarted = false;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            if (m_gameManager.m_isFirstBowl)
            {
                m_gameManager.m_isFirstBowl = false;
            }
            else if (!m_gameManager.m_isFirstBowl && m_round < 10)
            {
                m_gameManager.m_isFirstBowl = true;

                Destroy(m_pinSpawned, 1.5f);

                Invoke(nameof(SpawnPins), 2.0f);

                m_round++;
                m_text.text = "Round : " + m_round;
            }
            else
            {
                EndGame();
            }
        }
    }
}
