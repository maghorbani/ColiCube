using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private float initialPosition;
    [SerializeField] private Transform playerTransform;
    [SerializeField] private Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        initialPosition = playerTransform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        float score = playerTransform.position.z - initialPosition;
        scoreText.text = score.ToString("0");
    }
}
