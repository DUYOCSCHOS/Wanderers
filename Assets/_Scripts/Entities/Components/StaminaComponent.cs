using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaminaComponent : MonoBehaviour, VisitableComponent
{
    [Header("Stats")]
    [SerializeField] private float currentSP;
    public float CurrentSP { get {return currentSP;} set {currentSP = value;}}
    [SerializeField] private float maxSP = 100;
    public float MaxSP { get {return maxSP;} set {maxSP = value;}}
    [SerializeField] private float regeneratedSP = 1;
    public float RegeneratedSP { get {return regeneratedSP;} set {regeneratedSP = value;}}

    public void Accept(ComponentVisitor visitor){
        visitor.Visit(this);
    }

    private void Start(){
        currentSP = maxSP;
    }

    private void Update(){
        currentSP = Mathf.Clamp(currentSP, 0, maxSP);
        if (currentSP <= 0){
            Regenerate();
        }
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
