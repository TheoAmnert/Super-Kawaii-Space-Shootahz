using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    //GJORT AV ELLIOT 
    //Variabler som gör att man ser i Unity
    [SerializeField]
    GameObject bullet;
    float timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    //Den här gör så att varje andre sekund så kommer den duplikera "Bullet" från unity
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
