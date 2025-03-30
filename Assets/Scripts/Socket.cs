using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Socket : MonoBehaviour
{
    public bool m_isPlaced;

    public void OnSocketPlaced()
    {
        m_isPlaced = true;
    }

    public void OnSocketRemoved()
    {
        m_isPlaced = false;
    }
}
