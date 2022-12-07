using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class testscript : MonoBehaviour
{
    public TextMeshProUGUI campos;
    public TextMeshProUGUI levelpos;

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Level") != null) levelpos.text = "Level: " + GameObject.FindGameObjectWithTag("Level").transform.position;

        campos.text = "Cam: " + GameObject.FindGameObjectWithTag("MainCamera").transform.position;

    }
}
