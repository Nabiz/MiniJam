using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [SerializeField] GUI gui;
    [SerializeField] Train train;
    [SerializeField] Node[] nodes;
    [SerializeField] Failure failure;
    [SerializeField] FinalNode finalNode;

    int humanCount;
    int coalCount;
    int foodCount;

    int coalUse = 20;

    bool brokenEngine = false;
    float engineerBuff = 1;

    int currentNode = 0;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        SetHuman(10);
        SetCoal(120);
        SetFood(75);
    }

    public int GetHumanCount()
    {
        return humanCount;
    }

    public void AddHuman(int human)
    {
        humanCount += human;
        humanCount = Mathf.Max(humanCount, 0);
        gui.SetHumanCountText(humanCount);
    }

    public void AddCoal(int coal)
    {
        coalCount += coal;
        coalCount = Mathf.Max(coalCount, 0);
        gui.SetCoalCountText(coalCount);
    }

    public void AddFood(int food)
    {
        foodCount += food;
        foodCount = Mathf.Max(foodCount, 0);
        gui.SetFoodCountText(foodCount);
    }

    void SetHuman(int human)
    {
        humanCount = human;
        humanCount = Mathf.Max(humanCount, 0);
        gui.SetHumanCountText(humanCount);
    }

    void SetCoal(int coal)
    {
        coalCount = coal;
        coalCount = Mathf.Max(coalCount, 0);
        gui.SetCoalCountText(coalCount);
    }

    void SetFood(int food)
    {
        foodCount = food;
        foodCount = Mathf.Max(foodCount, 0);
        gui.SetFoodCountText(foodCount);
    }
    public void UseResources()
    {
        int coalUsed;
        int foodUsed;
        if (brokenEngine)
        {
            coalUsed = Convert.ToInt32(coalUse * engineerBuff * 2.5);
            foodUsed = humanCount * 2;
            if(coalUsed > coalCount || foodUsed > foodCount)
            {
                train.StopOnFail();
                failure.ShowFailScreen();
            }
            else
            {
                AddCoal(-coalUsed);
                AddFood(-foodUsed);
            }
        }
        else
        {
            coalUsed = Convert.ToInt32(coalUse * engineerBuff);
            foodUsed = humanCount;
            if (coalUsed > coalCount || foodUsed > foodCount)
            {
                train.StopOnFail();
                failure.ShowFailScreen();
            }
            else
            {
                AddCoal(-coalUsed);
                AddFood(-foodUsed);
            }
        }
    }

    public void EnableEngineerBuff()
    {
        engineerBuff = 0.8f;
    }

    public void BreakEngine()
    {
        brokenEngine = true;
    }

    public void NextNode()
    {
        if(currentNode == 10)
        {
            finalNode.GameSummary();
        }
        else
        {
            nodes[currentNode].showDesisionDialog();
            currentNode++;
        }
    }

    public bool CheckEpicWin()
    {
        return (foodCount >= 50 && humanCount >= 10 && coalCount >= 50);
    }

}
