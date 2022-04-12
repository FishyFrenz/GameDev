using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    [SerializeField] int breakableBlocks;

    SceneLoader sL;

    void Start()
    {
        sL = FindObjectOfType<SceneLoader>();
    }

    private void CountBlock()
    {
        breakableBlocks++;
    }
    
    private void BlockDestoryed()
    {
        breakableBlocks--;
        if (breakableBlocks <= 0)
        {
            sL.LoadNextScene();
        }
    }
}
