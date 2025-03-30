using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIButton : MonoBehaviour
{
    RespawnBalls m_respawnBalls;
    [SerializeField] private TMP_Text m_text;

    private GameObject[] m_balls;
    MeshRenderer[] m_meshRenderer;
    

    private void Awake()
    {
        m_respawnBalls = GameObject.Find("BallTable").GetComponent<RespawnBalls>();

        m_text.text = "Red ball selected";
    }

    public void RedButton()
    {
        m_respawnBalls.m_ballToSpawn = m_respawnBalls.m_balls[0];

        m_text.text = "Red ball selected";

        FindBalls();
        ChangeMaterial(0);
    }

    public void BlueButton()
    {
        m_respawnBalls.m_ballToSpawn = m_respawnBalls.m_balls[1];

        m_text.text = "Blue ball selected";

        FindBalls();
        ChangeMaterial(1);
    }

    public void GreenButton()
    {
        m_respawnBalls.m_ballToSpawn = m_respawnBalls.m_balls[2];

        m_text.text = "Green ball selected";

        FindBalls();
        ChangeMaterial(2);
    }

    private void FindBalls()
    {
        m_balls = GameObject.FindGameObjectsWithTag("Ball");

        Debug.Log("Found Balls");
    }

    private void ChangeMaterial(int materialNo)
    {
        for (int i = 0; i < m_balls.Length; i++)
        {
            m_balls[i].GetComponent<MeshRenderer>().material = m_respawnBalls.m_materials[materialNo];
        }

        Debug.Log("Change Colour");
    }
}
