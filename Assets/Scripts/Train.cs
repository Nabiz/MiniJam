using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Train : MonoBehaviour
{
    private Animator animator;
    private float animationSpeed = 1f;

    private void Start()
    {
        animator = GetComponent<Animator>();
        StopTrain();
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Z))
        {
            StartTrain();
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            StopTrain();
        }

    }

    public void StartTrain()
    {
        animator.speed = animationSpeed;
        GameManager.Instance.UseResources();
    }

    void StopTrain()
    {
        animator.speed = 0f;
        GameManager.Instance.NextNode();
    }

    public void StopOnFail()
    {
        animator.speed = 0f;
    }
}
