using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skott : MonoBehaviour
{
   // Gjort av Oscar, koden f�r att bulleten ska r�ra sig upp�t
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, 15, 0) * Time.deltaTime;
    }
}
