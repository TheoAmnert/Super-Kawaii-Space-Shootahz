using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    //Den h�r koden ber�ttar att Scoren p� sk�rmen n�r man spelar ska s�ga Score och sedan vad spelaren har f�r score.
    public int Player1Score;
    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {

        scoreText = GetComponent<Text>();

    }
    // Update is called once per frame
    void Update()
    {

        scoreText.text = "Kill-count " + Player1Score.ToString();
    }
}
