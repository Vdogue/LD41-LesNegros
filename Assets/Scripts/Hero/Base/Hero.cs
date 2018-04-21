using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    [Header("Stats")]
    public float health;
    public float dexterity;
    public float strenght;
    public float intellect;

    protected virtual void Start()
    {

    }

    protected virtual void Update()
    {

    }

    protected virtual void DoActions()
    {
        Debug.Log("Action");
    }

    protected virtual void OnMouseDown()
    {
        DoActions();
    }
}
