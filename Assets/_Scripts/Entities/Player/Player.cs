using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : Entity, Visitable
{
    public static Player Instance { get; private set; }

    [SerializeField] List<Visitable> visitableComponents = new();

    private void Awake(){
        Instance = this;
        visitableComponents.Add(gameObject.GetOrAddComponent<HealthComponent>());
        visitableComponents.Add(gameObject.GetOrAddComponent<ManaComponent>());
        visitableComponents.Add(gameObject.GetOrAddComponent<StaminaComponent>());
    }

    public void Accept(StatsComponentVisitor visitor){
        foreach (var visitableComponent in visitableComponents){
            visitableComponent.Accept(visitor);
        }
    }

    public override void OnCollapse(){
        // die
    }
}
