using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarManager : MonoBehaviour
{
	public float Health, MaxHealth, Width, Height;

	[SerializeField]
	private RectTransform healthBar;

	public void SetMaxHealth(float MaxHealth)
	{
		MaxHealth = Inhabitant.getMaxHP();
	}
	public void setHealth(float health)
	{
		Health = Inhabitant.getCurrHp();
		float newWidth = (Health / MaxHealth) * Width;
		healthBar.sizeDelta = new Vector2(newWidth,Height);
	}
}
