using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    //GJORT AV ELLIOT 
    //Variabler som g�r att man ser i Unity
    [SerializeField]
    float speed;
    public Vector3 direction = new Vector3(0, 1, 0);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    //Den h�r g�r s� att Objected �ker ner�t p� best�mt hastighet
    void Update()
    {
        transform.position -= new Vector3(0, speed, 0) * Time.deltaTime;
    }
}
