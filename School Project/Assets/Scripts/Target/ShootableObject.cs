using System.Collections;
using UnityEngine;

public class ShootableObject : MonoBehaviour
{
	public int currentHealth = 3;
	public int _hitsCounter;

   public void Update()
    {
        
    }
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