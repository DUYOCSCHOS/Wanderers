using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManaComponent : MonoBehaviour, VisitableComponent
{
    [Header("Stats")]
    [SerializeField] private float currentMP;
    public float CurrentMP { get {return currentMP;} set {currentMP = value;}}
    [SerializeField] private float maxMP;
    public float MaxMP { get {return maxMP;} set {maxMP = value;}}
    [SerializeField] private float regeneratedMP;
    public float RegeneratedMP { get {return regeneratedMP;} set {regeneratedMP = value;}}

    public void Accept(ComponentVisitor visitor){
        visitor.Visit(this);
    }

    private void Start(){
        currentMP = maxMP;
    }

    private void Update(){
        currentMP = Mathf.Clamp(currentMP, 0, maxMP);
    }

    private void Regenerate(){
        
    }
}
