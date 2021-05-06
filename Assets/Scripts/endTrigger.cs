using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endTrigger : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        FindObjectOfType<GameManager>().completeLevel();
    }
}
