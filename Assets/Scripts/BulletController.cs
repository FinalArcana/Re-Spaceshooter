using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour {

	public float damage;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		this.gameObject.transform.Translate (Vector2.up * Time.deltaTime * 20f);
		if (gameObject.transform.position.y >= 20f) {
			Destroy(this.gameObject);
		}
	}
	/// <summary>
	/// Sent when another object enters a trigger collider attached to this
	/// object (2D physics only).
	/// </summary>
	/// <param name="other">The other Collider2D involved in this collision.</param>
	void OnTriggerEnter2D(Collider2D other) {
		if (other.tag == "Enemy") {
			Debug.Log("Player shot an enemy!");
			other.GetComponent<EnemyStats>().takeDamage(damage);
			Destroy(this.gameObject);
		}
	}
}
