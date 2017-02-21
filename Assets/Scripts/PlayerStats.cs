using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour {

public float maxHP;
public float currentHP;
public float speed;
public int exp;

public int level;
	// Use this for initialization
	void Start () {
		currentHP = maxHP;
		level = 1;
	}
	
	// Update is called once per frame
	void Update () {
		level = exp/10 + 1;
	}
	public void takeDamage(float damage) {
		currentHP -= damage;
	}
	public void gainEXP(int bounty) {
		exp += bounty;
		level = exp/10 + 1;
	}
}
