using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : MonoBehaviour {

public float maxHP;
public float currentHP;
public float speed;
public int bounty;
	// Use this for initialization
	void Start () {
		currentHP = maxHP;
	}
	
	// Update is called once per frame
	void Update () {

	}
	public void takeDamage(float damage) {
		currentHP -= damage;
	}
}
