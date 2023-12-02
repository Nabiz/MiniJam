using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HuntGame : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] TMP_Text secText;
    [SerializeField] TMP_Text clickText;
    [SerializeField] Summary summary;

    int sec = 12;
    int clickCount = 0;

    private void Start()
    {
        Invoke("MinusTime", 1f);
    }
    // Update is called once per frame

    public void KillAnimal()
    {
        clickCount += 1;
        clickText.text = clickCount.ToString();
    }
    void MinusTime()
    {
        sec -= 1;
        secText.text = sec.ToString() + " s";
        if (sec > 0)
        {
            Invoke("MinusTime", 1f);
        }
        else
        {
            Invoke("EndMineGame", 1f);
        }

    }

    void EndMineGame()
    {
        summary.gameObject.SetActive(true);
        summary.CalculateSummary(clickCount, 0);
        gameObject.SetActive(false);
    }
}
