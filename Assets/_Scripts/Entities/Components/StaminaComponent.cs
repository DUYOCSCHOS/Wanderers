using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaminaComponent : MonoBehaviour, Visitable
{
    [Header("Stats")]
    [SerializeField] private float currentSP;
    public float CurrentSP { get {return currentSP;} set {currentSP = value;}}
    [SerializeField] private float maxSP = 100;
    public float MaxSP { get {return maxSP;} set {maxSP = value;}}
    [SerializeField] private float regeneratedSP = 1;
    public float RegeneratedSP { get {return regeneratedSP;} set {regeneratedSP = value;}}

    public void Accept(StatsComponentVisitor visitor){
        visitor.Visit(this);
    }

    private void Update(){
        if (currentSP <= 0) {Regenerate();}
        // if (out of combat for ..3-4 secs) => RecoverSP
    }

    private void Regenerate(){
        currentSP += regeneratedSP;
        if (currentSP >= maxSP){
            currentSP = maxSP;
            return;
        }
        // delay ... secs
        Regenerate();
    }
}
