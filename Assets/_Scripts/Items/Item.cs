using UnityEngine;

public class Item : ScriptableObject
{
    public enum Tier {
        S,  // yellow
        A,  // purple
        B,  // blue
        C,  // green
        D   // grey
    }

    public new string name;
    public string description;
    public Tier tier;
    public Sprite sprite;
    public int stack;
}
