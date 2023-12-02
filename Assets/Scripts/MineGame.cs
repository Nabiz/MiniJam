using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MineGame : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] TMP_Text secText;
    [SerializeField] TMP_Text clickText;

    int sec = 10;
    int clickCount = 0;
    bool canHit = true;

    private void Start()
    {
        Invoke("MinusTime", 1f);
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && canHit)
        {
            clickCount++;
            clickText.text = clickCount.ToString(); 
        }
    }

    void MinusTime()
    {
        sec -= 1;
        secText.text = sec.ToString() + " s";
        if(sec>0)
        {
            Invoke("MinusTime", 1f);
        }
        else
        {
            canHit = false;
            Invoke("EndMineGame", 1f);
        }
    }

    void EndMineGame()
    {
        gameObject.SetActive(false);
    }
}
