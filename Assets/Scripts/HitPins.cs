using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitPins : MonoBehaviour
{
    private IEnumerator m_coroutine;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Pin"))
        {
            DestroyPin(1.0f, collision.gameObject);
        }
    }

    IEnumerator DestroyPin(float waitTime, GameObject pin)
    {
        pin.SetActive(false);
        yield return new WaitForSeconds(waitTime);
    }
}
