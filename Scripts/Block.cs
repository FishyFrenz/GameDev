using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{

    Level lvl;

    // Start is called before the first frame update
    void Start()
    {
        lvl = FindObjectOfType<Level>();
        lvl.CountBlock();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject, 0f); // 0f = delay
        lvl.BlockDestoryed();
    }
}
