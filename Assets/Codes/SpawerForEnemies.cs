using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawerForEnemies : MonoBehaviour
{

    float timer;
    public Transform[] prefabs;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 5)
        {
            int rng = Random.Range(0, prefabs.Length);
            Instantiate(prefabs[rng], new Vector3(Random.Range(-11, 12), 9, 0), prefabs[rng].transform.rotation);
            // Instantiate(prefab2, new Vector3(Random.Range(-10, 9), Random.Range(-4, 4), 0),prefab2.transform.rotation);
            timer = 0;
        }
    }
}
