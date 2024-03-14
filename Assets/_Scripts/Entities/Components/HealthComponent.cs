using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthComponent : MonoBehaviour, VisitableComponent
{
    [Header("Stats")]
    [SerializeField] private float currentHP;
    public float CurrentHP { get {return currentHP;} set {currentHP = value;}}
    [SerializeField] private float maxHP;
    public float MaxHP { get {return maxHP;} set {maxHP = value;}}
    [SerializeField] private float regeneratedHP;
    public float RegeneratedHP { get {return regeneratedHP;} set {regeneratedHP = value;}}

    public event Action CollapseEvent;

    public void Accept(ComponentVisitor visitor){
        visitor.Visit(this);
    }

    private void Awake(){
        CollapseEvent += GetComponent<Entity>().OnCollapse;
    }

    private void Start(){
        currentHP = maxHP;
    }

    private void Update(){
        currentHP = Mathf.Clamp(currentHP, 0, maxHP);
        if (currentHP <= 0) CollapseEvent.Invoke();
    }

    private void Regenerate(){
        
    }
}
