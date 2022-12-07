using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateOther : MonoBehaviour
{
    public enum Type {Armor}
    public Type type;

    // Start is called before the first frame update
    void Start()
    {
        if (type == Type.Armor)
        {
            Player.instance.IncreaseHealth();
        }
    }
}
