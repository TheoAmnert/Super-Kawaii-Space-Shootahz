using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienMovement : MonoBehaviour
{
    [SerializeField]
    float speed;
    Vector3 direction = new Vector3(0, 0, 0);
    [SerializeField]
    float speed2;
    // Start is called before the first frame update
    void Start()
    {
       
        int x = Random.Range(0, 2);
        if (x == 0)
        {
            x = -1;
        }
        direction.x = x;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(0, speed2, 0) * Time.deltaTime;
        transform.position += direction * speed * Time.deltaTime;
    }

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
