using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalNode : MonoBehaviour
{
    [SerializeField] GameManager gameManager;
    [SerializeField] GameObject success;
    [SerializeField] GameObject epicSuccess;

    public void GameSummary()
    {
        if (gameManager.CheckEpicWin())
        {
            epicSuccess.SetActive(true);
        }
        else
        {
            success.SetActive(true);
        }
    }
}
