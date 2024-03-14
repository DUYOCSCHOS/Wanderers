using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public static InputManager Instance { get; private set; }

    private void Awake(){
        Instance = this;
    }

    private async void Update(){
        if (Input.GetKeyDown(KeyCode.Space)){
            await TestDebug();
        }
    }

    private async Task TestDebug(){
        await Task.Delay(5000);
        Debug.Log("hello");
    }
}
