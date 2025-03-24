using System;
using UnityEngine;

public class fightSceneManager : MonoBehaviour
{
    public GameObject player;
    public GameObject monster;
    private Monster theMonster;
    public float Health, MaxHealth;
    [SerializeField]
    private HealthBarManager healthBar;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.theMonster = new Monster("Dolphinwarrior2");
        Fight f = new Fight(this.theMonster);
        f.startFight(player, monster);
        healthBar.SetMaxHealth(MaxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}