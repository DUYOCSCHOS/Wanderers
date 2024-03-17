using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public static InputManager Instance { get; private set; }

    [SerializeField] Food food;

    private void Awake(){
        Instance = this;
    }

    private void Update(){
        if (Input.GetKeyDown(KeyCode.Space)){
            TestDebug();
        }
    }

    private void TestDebug(){
        food.Consume();
    }
}
