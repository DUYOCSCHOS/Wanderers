using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : Entity, VisitableComponent
{
    public static Player Instance { get; private set; }

    public Stats stats = new();
    public AbilitySystem abilitySystem;
    public EffectSystem effectSystem;

    [SerializeField] List<VisitableComponent> visitableComponents = new();

    private void Awake(){
        Instance = this;
        abilitySystem = GetComponentInChildren<AbilitySystem>();
        effectSystem = GetComponentInChildren<EffectSystem>();
        visitableComponents.Add(gameObject.GetOrAddComponent<HealthComponent>());
        visitableComponents.Add(gameObject.GetOrAddComponent<ManaComponent>());
        visitableComponents.Add(gameObject.GetOrAddComponent<StaminaComponent>());
    }

    public void Accept(ComponentVisitor visitor){
        foreach (var visitableComponent in visitableComponents){
            visitableComponent.Accept(visitor);
        }
    }

    public override void OnCollapse(){
        // die
    }
}
