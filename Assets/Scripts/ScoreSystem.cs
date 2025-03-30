using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreSystem : MonoBehaviour
{
    RemoveHitPins m_pins;
    GameManager m_gameManager;
    [SerializeField] private TMP_Text m_text;

    public int m_score;
    private int m_pinsStillUp;
    private int m_pinsStillUp1;
    private int m_pinsKnockedDown;


    private void Awake()
    {
        m_gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        m_pins = GetComponent<RemoveHitPins>();
    }

    private void Update()
    {
        
    }

    public void PinsUp()
    {
        m_pinsStillUp = m_pins.CountPins();
    }

    //public void CalculateScore()
    //{
    //    if (!m_gameManager.m_isFirstBowl)
    //    {
    //        PinsUp();

    //        m_pinsKnockedDown = 10 - m_pinsStillUp;
    //        m_pinsStillUp1 = m_pinsStillUp;

    //        m_score += m_pinsKnockedDown;
    //    }
    //    else
    //    {
    //        PinsUp();

    //        m_pinsStillUp = m_pinsStillUp1 - m_pinsStillUp;

    //        m_pinsKnockedDown -= m_pinsStillUp;

    //        m_score += m_pinsKnockedDown;
    //    }
    //}

    public void UpdateScore()
    {
        m_text.text = "Score : " + m_score;
    }

    private void OnTriggerExit(Collider other)
    {
        UpdateScore();
    }
}
