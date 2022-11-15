using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    //Score Av Axel
    Score score;
    //GJORT AV ELLIOT 
    // Start is called before the first frame update
    void Start()
    {
        score = FindObjectOfType<Score>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    //den här gör så att om objected kolliderar med andra object med taggen "Player" eller "Skott" kommer den här objected förstöras
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
         
        }

        if (collision.gameObject.tag == "Skott")
        {
            if (score != null)
            {
                score.Player1Score += 50;
            }
           
            Destroy(gameObject);
        }
    }
}
