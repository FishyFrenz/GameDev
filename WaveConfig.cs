using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Enemy Wave Config")]
public class WaveConfig : ScriptableObject
{
    [SerializeField] GameObject enemyPrefab;
    [SerializeField] GameObject pathPrefab;
    [SerializeField] float timeBetweenSpawns = 10f;
    [SerializeField] float spawnRandomFactor = 5f;
    [SerializeField] int numberOfEnemies = 5;
    [SerializeField] float moveSpeed = 1f;

    public GameObject getEnemyPrefab()
    {
        return enemyPrefab;
    }

    public float gettimeBetweenSpawns()
    {
        return timeBetweenSpawns;
    }

    public float getspawnRandomFactor()
    {
        return spawnRandomFactor;
    }

    public int getnumberOfEnemies()
    {
        return numberOfEnemies;
    }

    public float getmoveSpeed()
    {
        return moveSpeed;
    }

    public List<Transform> getWaypoint()
    {
        var waveWaypoints = new List<Transform>();
        foreach (Transform child in pathPrefab.transform)
        {
            waveWaypoints.Add(child);
        }
        return waveWaypoints;
    }

}
