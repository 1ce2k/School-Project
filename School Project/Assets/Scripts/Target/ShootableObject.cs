using System.Collections;
using UnityEngine;

public class ShootableObject : MonoBehaviour
{
	public int currentHealth = 3;

	public void Damage(int damageAmount)
	{
		currentHealth -= damageAmount;

		if (currentHealth <= 0)
		{
			FindObjectOfType<Score>().AddScore();
			gameObject.SetActive(false);
		}
	}
}
