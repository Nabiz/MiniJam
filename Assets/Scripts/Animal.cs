using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Animal : MonoBehaviour
{
    [SerializeField] HuntGame huntGame;
    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("KILL");
        huntGame.KillAnimal();
        gameObject.SetActive(false);
    }
}
