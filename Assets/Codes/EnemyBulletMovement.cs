using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletMovement : MonoBehaviour
{
    //GJORT AV ELLIOT 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    //Obejcted åker neråt
    void Update()
    {
        transform.position -= new Vector3(0, 15, 0) * Time.deltaTime;
    }
    //Om Obejcted kolliderar med ett annat objected med taggen "HiddenWall" kommer den att förstöras
    private void OnCollisionEnter(Collision collision)
    {
        print("bullet touch");
        if (collision.gameObject.tag == "HiddenWall")
        {
            print("bullet Destroy");
            Destroy(gameObject);


        }
    }
    }
