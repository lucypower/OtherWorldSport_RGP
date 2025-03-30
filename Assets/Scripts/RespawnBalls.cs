using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnBalls : MonoBehaviour
{
    public Material[] m_materials;
    public GameObject[] m_balls;

    GameManager m_gameManager;
    public GameObject m_ballToSpawn;
    [SerializeField] private GameObject[] m_spawnLocations;
    public bool m_ballsSpawned;

    private void Awake()
    {
        m_gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        m_ballsSpawned = false;

        m_ballToSpawn = m_balls[0];
    }

    private void Update()
    {
        if (m_gameManager.m_isFirstBowl && !m_ballsSpawned)
        {
            m_ballsSpawned = true;

            SpawnBalls();
        }
        else if (!m_gameManager.m_isFirstBowl)
        {
            m_ballsSpawned = false;
        }
    }

    public void SpawnBalls()
    {
        for (int i = 0; i < m_spawnLocations.Length; i++)
        {
            Instantiate(m_ballToSpawn, m_spawnLocations[i].transform.position, Quaternion.identity);
        }
    }
}
