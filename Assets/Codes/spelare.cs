using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spelare : MonoBehaviour
{
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
    private int _health = 100;
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
    #endregion

    void Update()
    {
        #region Movement
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
        #endregion
        #region Shooting
        if (Input.GetKeyDown(shoot))
        {
            Instantiate(bullet, transform.position, bullet.transform.rotation);
        }
        #endregion
    }
}
