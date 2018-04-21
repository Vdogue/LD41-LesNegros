using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mage : Hero {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public override void DoActions()
    {
        base.DoActions();
        Debug.Log("Action from mage");
    }
}
