using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    //GJORT AV ELLIOT 
    //Variabler som g�r att man ser i Unity
    [SerializeField]
    GameObject bullet;
    float timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    //Den h�r g�r s� att varje andre sekund s� kommer den duplikera "Bullet" fr�n unity
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 2)
        {
            Instantiate(bullet, transform.position, bullet.transform.rotation);
            timer = 0;
        }
    }
}
