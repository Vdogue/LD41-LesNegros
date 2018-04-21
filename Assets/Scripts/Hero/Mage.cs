using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mage : Hero {

    public Mage()
    {
        perk = Perks.MAGE;
    }

	// Use this for initialization
    protected override void Start ()
    {
        base.Start();
    }
	
	// Update is called once per frame
    protected override void Update () {
        base.Update();
    }

    protected override void DoActions()
    {
        base.DoActions();
        Debug.Log("Action from mage");
    }
}
