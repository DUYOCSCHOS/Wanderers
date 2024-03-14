using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Effect : ScriptableObject
{
    public new string name;
    public string description;
    public Sprite sprite;

    public float duration;

    public Effect(string name, string description, Sprite sprite){
        this.name = name;
        this.description = description;
        this.sprite = sprite;
    }

    
}
