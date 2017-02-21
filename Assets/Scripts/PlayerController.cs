using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public GameObject bullet;
	private PlayerStats stats;
	// Use this for initialization
	void Start () {
		stats = GetComponent<PlayerStats>();
	}
	
	// Update is called once per frame
	void Update () {
		if (stats.currentHP <= 0) {
			Destroy(this.gameObject);
		}
		if (Input.GetAxis("Horizontal") != 0 ) {
			this.gameObject.transform.Translate(Input.GetAxis("Horizontal") * Vector2.right * Time.deltaTime * stats.speed);
		}
		if (Input.GetAxis("Vertical") != 0 ) {
			this.gameObject.transform.Translate(Input.GetAxis("Vertical") * Vector2.up * Time.deltaTime * stats.speed);
		}
		if (Input.GetKeyDown(KeyCode.Space)) {
			Instantiate(bullet,this.gameObject.transform.position, Quaternion.identity);
		}
	}
}
