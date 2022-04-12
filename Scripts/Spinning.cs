using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinning : MonoBehaviour
{
    [SerializeField] Sprite penguin2;
    float degreesPerSecond = 10000;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 newPosition = new Vector3(0, 120, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, degreesPerSecond, 0) * Time.deltaTime);
    }
}
