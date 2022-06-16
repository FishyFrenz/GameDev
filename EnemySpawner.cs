using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] List<WaveConfig> waveConfigs;
    [SerializeField] int startingWave = 0;
    [SerializeField] bool looping = false;


    IEnumerator Start()
    {
        do
        {
            yield return StartCoroutine(SpawnAllWaves());
        }
        while (looping);
    }

    private IEnumerator SpawnAllWaves()
    {
        for (int waveIndex = startingWave; waveIndex < waveConfigs.Count; waveIndex++)
        {
            var currentWave = waveConfigs[waveIndex];
            yield return StartCoroutine(SpawnAllEnemiesInWave(currentWave));
        }
    }

    private IEnumerator SpawnAllEnemiesInWave(WaveConfig wC)
    {
        for (int i = 0; i <wC.getnumberOfEnemies(); i++)
        {
            var newEnemy = Instantiate(wC.getEnemyPrefab(), wC.getWaypoint()[0].transform.position,Quaternion.identity);
            newEnemy.GetComponent<EP>().setWaveConfig(wC);
            yield return new WaitForSeconds(wC.gettimeBetweenSpawns());
        }
    }

}
