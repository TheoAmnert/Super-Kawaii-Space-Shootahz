using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spelare : MonoBehaviour
{
    [SerializeField, Range(1, 8)]
    public float speed;
    [SerializeField]
    KeyCode left;
    [SerializeField]
    KeyCode right;
    public KeyCode shoot;

    [SerializeField]
    GameObject bullet;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(right))
        {
            transform.position += new Vector3(speed, 0, 0) * Time.deltaTime;
            print("Hej");

        }
        if (Input.GetKey(left))
        {
            transform.position -= new Vector3(speed, 0, 0) * Time.deltaTime;
            print("Hejd");
        }
        if (Input.GetKeyDown(shoot))
        {
            Instantiate(bullet, transform.position, bullet.transform.rotation);
        }

    }
}
