﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WaveSpawner : MonoBehaviour {

    public static int EnemiesAlive = 0;

    public Wave[] waves;

    public Transform carPrefab;
    public Transform spawnPoint;

    public float timeBetweenWaves = 5f;
    [SerializeField]
    private float countdown = 2f;

    public Text waveCountdownText;

    public GameManager gameManager;

    
    private int waveNumber = 0;

    public int JumlahWave;
    public int EnemyKeluarTiapWave;
    void Update()
    {
        
        if(EnemiesAlive > 0)
        {
           // Debug.Log("enemy alive");
            return;
        }

        if (waveNumber == waves.Length)
        {
            gameManager.WinLevel();
            this.enabled = false;
        }

        if (countdown <= 0f) {
            StartCoroutine(SpawnWave());
            countdown = timeBetweenWaves;
            
        }
        
       
        countdown -= Time.deltaTime;

        countdown = Mathf.Clamp(countdown, 0f, Mathf.Infinity);

        waveCountdownText.text = ""  + string.Format("{0:00.00:}", countdown);
    }

    IEnumerator SpawnWave()
    {
        PlayerStats.Rounds++;

        Wave wave = waves[waveNumber];

        for (int i = 0; i < wave.count; i++)
        {
            SpawnEnemy(wave.enemy);
            yield return new WaitForSeconds(1f / wave.rate);
        }
        waveNumber++;

        
        
        Debug.Log(JumlahWave);
        
    }



    void SpawnEnemy(GameObject enemy)
    {
        Instantiate(carPrefab, spawnPoint.position, spawnPoint.rotation);
        EnemiesAlive++;
        EnemyKeluarTiapWave++;
    }

    

}
