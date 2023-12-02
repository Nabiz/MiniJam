using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    int human_count;
    int coal_count;
    int food_count;

    private void Awake()
    {
        Instance = this;
    }

    void AddHuman(int human)
    {
        human_count = human;
    }

    void AddCoal(int coal)
    {
        coal_count = coal;
    }

    void AddFood(int food)
    {
        food_count = food;
    }



}
