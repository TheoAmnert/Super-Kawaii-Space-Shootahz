using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skott : MonoBehaviour
{
   // Gjort av Oscar, koden för att bulleten ska röra sig uppåt
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, 15, 0) * Time.deltaTime;
    }
}
