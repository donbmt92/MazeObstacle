using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hitScore = 0;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Hit")
        {
            hitScore++;
            Debug.Log("Dammn u hit the wall many time: " + hitScore);
        }
    }
}
