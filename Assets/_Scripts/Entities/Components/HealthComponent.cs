using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthComponent : MonoBehaviour, Visitable
{
    [Header("Stats")]
    [SerializeField] private float currentHP;
    public float CurrentHP { get {return currentHP;} set {currentHP = value;}}
    [SerializeField] private float maxHP;
    public float MaxHP { get {return maxHP;} set {maxHP = value;}}
    [SerializeField] private float regeneratedHP;
    public float RegeneratedHP { get {return regeneratedHP;} set {regeneratedHP = value;}}

    public event Action healthEvent;

    public void Accept(StatsComponentVisitor visitor){
        visitor.Visit(this);
    }

    private void Awake(){
        healthEvent += GetComponent<Entity>().OnCollapse;
    }

    private void Update(){
        if (currentHP <= 0) healthEvent.Invoke();
    }

    private void Regenerate(){
        
    }
}
