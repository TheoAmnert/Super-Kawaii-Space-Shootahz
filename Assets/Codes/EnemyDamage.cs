using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{

    //GJORT AV ELLIOT 
    // Start is called before the first frame update
    void Start()
    {

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
            Destroy(gameObject);
        }
    }
}
