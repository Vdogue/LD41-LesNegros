using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warrior : Hero {

    Warrior()
    {
        perk = Perks.WAR;
    }

	// Use this for initialization
    protected override void Start () {
		
	}
	
	// Update is called once per frame
    protected override void Update () {
		
	}

    protected override void DoActions()
    {
        base.DoActions();
        Debug.Log("Action from warrior");
    }
}
