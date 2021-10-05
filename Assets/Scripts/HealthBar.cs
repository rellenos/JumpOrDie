using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{

    public Image healthBar;

    Mage player;

    public float actualHeatlh;
    public float maxHealth;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Mage>();
    }

    void Update()
    {
        healthBar.fillAmount = player.HpPercent;
    }
}
