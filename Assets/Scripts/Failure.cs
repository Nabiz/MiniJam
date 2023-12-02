using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Failure : MonoBehaviour
{
    [SerializeField] GameObject decisionDialog;

    public void ShowFailScreen()
    {
        decisionDialog.SetActive(true);
    }
}
