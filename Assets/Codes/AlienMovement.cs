using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienMovement : MonoBehaviour
{
    //GJORT AV ELLIOT 

    //Variabler som gör att man ser i Unity
    [SerializeField]
    float speed;
    Vector3 direction = new Vector3(0, 0, 0);
    [SerializeField]
    float speed2;
    // Start is called before the first frame update
    void Start()
    {
       
        //Den här bestämmer åt vilket "X" håll objected ska börja med att åka
        int x = Random.Range(0, 2);
        if (x == 0)
        {
            x = -1;
        }
        direction.x = x;
    }

    // Update is called once per frame
    //Simpelt att den åker neråt och att den har en hastighet mot hållet den åker mot
    void Update()
    {
        transform.position -= new Vector3(0, speed2, 0) * Time.deltaTime;
        transform.position += direction * speed * Time.deltaTime;
    }

    //Om Obejcted kolliderar med ett annat objected med taggen "HiddenWall" kommer den åka motsatta hållet i "X" delen
    private void OnCollisionEnter(Collision collision)
    {
        print("touch");
        if (collision.gameObject.tag == "HiddenWall")
        {
            print("hej");
            direction.x = -direction.x;

        }
     
    }
}
