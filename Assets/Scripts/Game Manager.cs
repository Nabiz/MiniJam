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
    bool engineerBuff = false;

    int currentNode = 0;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        SetHuman(10);
        SetCoal(100);
        SetFood(25);
    }

    void AddHuman(int human)
    {
        humanCount += human;
        humanCount = Mathf.Max(humanCount, 0);
        gui.SetHumanCountText(humanCount);
    }

    void AddCoal(int coal)
    {
        coalCount += coal;
        coalCount = Mathf.Max(coalCount, 0);
        gui.SetCoalCountText(coalCount);
    }

    void AddFood(int food)
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
        AddCoal(-coalUse);
        AddFood(-humanCount);
    }
    public void NextNode()
    {
        nodes[currentNode].showDesisionDialog();
        currentNode++;
    }

}
