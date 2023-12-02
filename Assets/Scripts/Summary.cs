using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Summary : MonoBehaviour
{
    int food = 0;
    int coal = 0;
    [SerializeField] TMP_Text summaryText;
    
    private void setSummaryText()
    {
        summaryText.text = "Otrzymujesz " + Mathf.Max(food, coal).ToString() + "sztuk zasobu";
    }
    public void CalculateSummary(int food, int coal)
    {
        this.food = 5*food;
        this.coal = Convert.ToInt32(GameManager.Instance.GetHumanCount() * 0.1f * coal);
        setSummaryText();
    }
    public void AddFood()
    {
        GameManager.Instance.AddFood(food);
    }

    public void AddCoal()
    {
        GameManager.Instance.AddCoal(coal);
    }
}
