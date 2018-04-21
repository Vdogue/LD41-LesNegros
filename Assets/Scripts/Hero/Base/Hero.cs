using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public enum Perks { WAR, HEAL, MAGE };

public abstract class Hero : MonoBehaviour
{
    [Header("Stats")]
    public float health;
    public float maxHealth;
    public float dexterity;
    public float strenght;
    public float intellect;
    public Perks perk;
    public Factions faction = Factions.ALLIED;
    private const int _defaultAddValue = 5; 

    [Header("Spells")]
    public List<Spell> spells;
    public Spell actualSpell;
    public float loadingSpell;

    [Header("UI")]
    public Slider energyBar;
    public Slider healthBar;

    protected virtual void Start()
    {
        actualSpell = spells[0];
    }

    protected virtual void Update()
    {
        AddLoad(dexterity * Time.deltaTime);
        energyBar.value = loadingSpell / actualSpell.releaseCost;
        healthBar.value = health / maxHealth;

    }
    private void AddLoad(float value)
    {
        loadingSpell += value;
        if (loadingSpell >= actualSpell.releaseCost)
        {
            loadingSpell = 0;
            Fire(actualSpell.damage);   
        }
    }

    protected virtual void DoActions()
    {
        AddLoad(strenght);
    }

    protected virtual void OnMouseDown()
    {
        DoActions();
    }

    protected virtual void Fire(int damage)
    {
        Debug.Log("BAM " + damage + " dans la gueule !");
    }

  
}
