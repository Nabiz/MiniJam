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
        SetCoal(100);
        SetFood(50);
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
        if (brokenEngine)
        {
            AddCoal(Convert.ToInt32(- coalUse * engineerBuff * 2.5));
            AddFood(-humanCount * 2);
        }
        else
        {
            AddCoal(Convert.ToInt32(-coalUse * engineerBuff));
            AddFood(-humanCount);
        }
    }

    public void enableEngineerBuff()
    {
        engineerBuff = 0.8f;
    }

    public void breakEngine()
    {
        brokenEngine = true;
    }

    public void NextNode()
    {
        nodes[currentNode].showDesisionDialog();
        currentNode++;
    }

}
