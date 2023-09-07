using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class adventurer_script : MonoBehaviour
{
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void OnMouseDown()
    {
        animator.SetTrigger("active");
    }
}

