using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool m_isFirstBowl;
    public bool m_gameStarted;

    private void Awake()
    {
        m_isFirstBowl = true;
        m_gameStarted = false;
    }
}
