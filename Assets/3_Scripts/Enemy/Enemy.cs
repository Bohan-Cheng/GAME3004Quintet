using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
	public float startSpeed = 10f;

	[HideInInspector]
	public float speed;

	public float startHealth = 100;
	private float health;

	public int worth = 50;

	//public GameObject deathEffect;

	//[Header("Unity Stuff")]
	//public Image healthBar;

	private bool isDead = false;

	bool isAttacking = false;

	void Start()
	{
		speed = startSpeed;
		health = startHealth;
	}

	public void TakeDamage(float amount)
	{
		health -= amount;
		//healthBar.fillAmount = health / startHealth;

		if (health <= 0 && !isDead)
		{
			Die();
			ScoreManager.playerScore += 7;
		}
	}

	public void DoAttack()
    {
		isAttacking = true;
		GetComponent<NavMeshAgent>().isStopped = true;
    }

	public void Slow(float pct)
	{
		speed = startSpeed * (1f - pct);
	}

	void Die()
	{
		isDead = true;


		//GameObject effect = (GameObject)Instantiate(deathEffect, transform.position, Quaternion.identity);
		//Destroy(effect, 5f);


		Destroy(gameObject);
	}
}
