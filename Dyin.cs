using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dyin : MonoBehaviour
{
    [SerializeField] int damage = 100;

    public int getDamage()
    {
        return damage;
    }

    public void hit()
    {
        Destroy(gameObject);
    }
}
