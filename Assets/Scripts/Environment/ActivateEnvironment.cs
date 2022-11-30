using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateEnvironment : MonoBehaviour
{
    public string pieceName;

    void Start()
    {
        foreach (EnvironmentPiece piece in EnvironmentManager.instance.environmentPieces)
        {
            if (pieceName == piece.name && piece.enabled == true)
            {
                Destroy(this.gameObject);
                Debug.Log("Piece already enabled.");
            }
        }

        EnvironmentManager.instance.EnablePiece(pieceName);
        Debug.Log("Piece enabled!");
        Destroy(this.gameObject, 3f);
    }
}
