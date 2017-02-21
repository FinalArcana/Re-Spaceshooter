using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {
	public int enemyCount;
	public GameObject enemy;
	// Use this for initialization
	void Start () {
		enemyCount = 0;
	}
	
	// Update is called once per frame
	void Update () {
		enemyCount = GameObject.FindGameObjectsWithTag("Enemy").Length;
		if (enemyCount <= 0) {
			GameObject player = GameObject.FindGameObjectWithTag("Player");
			int playerLevel = player.GetComponent<PlayerStats>().level;
			int spawnCount = Random.Range(1, playerLevel + 1);
			int spawnHP = (int)Mathf.Ceil( (playerLevel + 1) / spawnCount );
			float spawnSpeed = (float)playerLevel/2f;
			for(int i = 1; i <= spawnCount; i++) {
				Debug.Log("LV : " + playerLevel + " | Spawn enemy with " + spawnHP + " HP");
				GameObject spawn = Instantiate(enemy, new Vector2(Random.Range(-6f,6f), Random.Range(0f,4f)), Quaternion.identity);
				EnemyStats spawnStats = spawn.GetComponent<EnemyStats>();
				spawnStats.maxHP = spawnHP;
				spawnStats.speed = spawnSpeed;
				spawnStats.bounty = spawnHP;
			}
		}
	}
}
