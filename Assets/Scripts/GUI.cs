using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GUI : MonoBehaviour
{
    [SerializeField] TMP_Text humanText;
    [SerializeField] TMP_Text coalText;
    [SerializeField] TMP_Text foodText;

    public void SetHumanCountText(int humanCount)
    {
        humanText.text = humanCount.ToString();
    }

    public void SetCoalCountText(int humanCount)
    {
        humanText.text = humanCount.ToString();
    }

    public void SetFoodCountText(int humanCount)
    {
        humanText.text = humanCount.ToString();
    }
}
