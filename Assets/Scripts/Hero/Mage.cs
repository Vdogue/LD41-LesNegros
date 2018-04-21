using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mage : Hero {

	// Use this for initialization
    protected override void Start () {
		
	}
	
	// Update is called once per frame
    protected override void Update () {
		
	}

    protected override void DoActions()
    {
        base.DoActions();
        Debug.Log("Action from mage");
    }
}
