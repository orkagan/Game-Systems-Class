using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    public float maxHealth;
    public float currentHealth;
    public Gradient healthColour;
    public Image healthBar;
    void Update()
    {
        healthBar.fillAmount = Mathf.Clamp01(currentHealth / maxHealth);
        healthBar.color = healthColour.Evaluate(healthBar.fillAmount);
    }
}
