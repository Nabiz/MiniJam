using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    [SerializeField] GameObject decisionDialog;

    public void showDesisionDialog()
    {
        decisionDialog.SetActive(true);
    }
}
