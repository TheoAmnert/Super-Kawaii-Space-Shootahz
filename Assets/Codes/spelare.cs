using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spelare : MonoBehaviour
{ // Gjort av Oscar
    #region Variablar
    [SerializeField, Range(1, 8)]
    public float speed;
    [SerializeField]
    KeyCode left;
    [SerializeField]
    KeyCode right;
    public KeyCode shoot;

    [SerializeField]
    GameObject bullet;

    #endregion
    #region Health
    public int _health = 100;

    public int AlienSkott = 20;
    public int health
    {
        get
        {
            return _health;
        }
        set
        {
            if (value <= 0)
            {
                _health = 0;
                Destroy(gameObject); // Om hp blir 0 s� d�r spelaren
            }
            else if (value >= 100)
            {
                _health = 100;
            }
            else
            {
                _health = value;
            }
        }
        
    }
    public void OnCollisionEnter(Collision collision) // Om man blir tr�ffat av "Alienskott" s� f�rlorar man hp och �ven aktiverar camerashake
    {
        if (collision.gameObject.tag == "AlienSkott")
        {
            _health -= AlienSkott;
            CameraShake.shakeDuration = 0.5f;
        }
    }
    #endregion

    void Update()
    {
        #region Movement
        if (Input.GetKey(right)) // Simpel r�relse kod, om man trycker A s� �ndras vector v�rdet�s� man r�r sig v�nster, D �ndras till h�ger
        {
            transform.position += new Vector3(speed, 0, 0) * Time.deltaTime;
            print("Hej");

        }
        if (Input.GetKey(left))
        {
            transform.position -= new Vector3(speed, 0, 0) * Time.deltaTime;
            print("Hejd");
        }
        #endregion
        #region Shooting
        if (Input.GetKeyDown(shoot)) // Om man trycker p� skjut knappen s� skapas en bullet, fr�n en prefab
        {
            Instantiate(bullet, transform.position, bullet.transform.rotation);
        }
        #endregion
    }
}
