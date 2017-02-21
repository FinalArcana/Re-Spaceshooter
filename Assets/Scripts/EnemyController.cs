using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

private EnemyStats stats;

public float touchDamage;
	// Use this for initialization
	void Start () {
		stats = this.gameObject.GetComponent<EnemyStats>();
	}
	
	// Update is called once per frame
	void Update () {
		GameObject player = GameObject.FindWithTag("Player");
		if (player != null) {
			if(stats.currentHP <= 0) {
			player.GetComponent<PlayerStats>().gainEXP(stats.bounty);
			Destroy(this.gameObject);
			}
			this.gameObject.transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, Time.deltaTime * stats.speed);
		}
	}
	/// <summary>
	/// Sent when another object enters a trigger collider attached to this
	/// object (2D physics only).
	/// </summary>
	/// <param name="other">The other Collider2D involved in this collision.</param>
	void OnTriggerEnter2D(Collider2D other) {
		if (other.tag == "Player") {
			Debug.Log("Player crashes with enemy!");
			other.GetComponent<PlayerStats>().takeDamage(touchDamage);
		}
	}
}
