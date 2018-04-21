using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    [Header("Stats")]
    public Stats stats;

    public virtual void DoActions()
    {
        Debug.Log("Action");
    }

    void OnMouseDown()
    {
        DoActions();
    }
}
