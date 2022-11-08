using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    //GJORT AV ELLIOT 
    //Variabler som gör att man ser i Unity
    [SerializeField]
    float speed;
    public Vector3 direction = new Vector3(0, 1, 0);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    //Den här gör så att Objected åker neråt på bestämt hastighet
    void Update()
    {
        transform.position -= new Vector3(0, speed, 0) * Time.deltaTime;
    }
    //Om Obejcted kolliderar med ett annat objected med taggen "HiddenWall" kommer den att förstöras
    private void OnCollisionEnter(Collision collision)
    {
        print("touch");
        if (collision.gameObject.tag == "HiddenWall")
        {
            print("Destroy");
            Destroy(gameObject);
            

        }
    }
    }
