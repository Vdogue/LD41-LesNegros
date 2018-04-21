using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum Perks { WAR, HEAL, MAGE };

public class Hero : MonoBehaviour
{
    [Header("Stats")]
    public float health;
    public float dexterity;
    public float strenght;
    public float intellect;
    public Perks perk;
    public Factions faction = Factions.ALLIED;
    private const int _defaultAddValue = 5; 

    List<Spell> spells;
    Spell actualSpell;
    int loadingSpell;

    protected Hero()
    {

    }



    protected virtual void Start()
    {

    }

    protected virtual void Update()
    {
        AddLoad(_defaultAddValue);   
    }
    private void AddLoad(int damage)
    {
        loadingSpell += damage;
        if (loadingSpell >= actualSpell.releaseCost)
        {
            loadingSpell = loadingSpell % actualSpell.releaseCost;
            Fire(actualSpell.damage);   
        }
    }

    protected virtual void OnMouseDown()
    {
        AddLoad((int)(actualSpell.releaseCost/100 * strenght));
    }

    protected virtual void Fire(int damage)
    {
        Debug.Log("BAM " + damage + " dans la gueule !");
    }

  
}
