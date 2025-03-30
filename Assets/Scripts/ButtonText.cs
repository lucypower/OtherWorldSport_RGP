using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ButtonText : MonoBehaviour
{
    GameManager m_gameManager;
    [SerializeField] private TMP_Text m_text;

    private void Awake()
    {
        m_gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    private void Update()
    {
        if (m_gameManager.m_gameStarted)
        {
            m_text.text = "Press button for bumper control";
        }
        else
        {
            m_text.text = "Press button to start game";
        }
    }
}
