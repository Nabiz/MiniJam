using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [SerializeField] GUI gui;

    int humanCount;
    int coalCount;
    int foodCount;

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
    }

    void AddCoal(int coal)
    {
        coalCount += coal;
    }

    void AddFood(int food)
    {
        foodCount += food;
    }

    void SetHuman(int human)
    {
        humanCount = human;
        gui.SetHumanCountText(humanCount);
    }

    void SetCoal(int coal)
    {
        coalCount = coal;
        gui.SetCoalCountText(coalCount);
    }

    void SetFood(int food)
    {
        foodCount = food;
        gui.SetFoodCountText(food);
    }



}
