﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour {

    public PlayerHealth playerHealth;
    public GameObject enemy;
    public float spawnTime = 5f;
    public Transform[] spawnPoints;
	// Use this for initialization
	void Start () {

        InvokeRepeating("Spawn", spawnTime, spawnTime);
		
	}

    void Spawn()
    {
        if (playerHealth.currentHealth <= 0f)
        {
            return;
        }
        int spawnPointIndex = Random.Range(0, spawnPoints.Length);

        Instantiate(enemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
    }
	// Update is called once per frame
	void Update () {
		
	}
}
