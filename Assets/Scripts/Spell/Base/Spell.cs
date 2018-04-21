using UnityEngine;
using System.Collections;
using System.Collections.Generic;


[CreateAssetMenu(fileName = "NewSpell", menuName = "Spells/New", order = 1)]
public class Spell : ScriptableObject
{
    public List<Perks> possibleFor;
    public Factions dedicatedTo;
    public int releaseCost;
    public int damage;
}
