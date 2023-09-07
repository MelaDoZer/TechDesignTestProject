using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chest_script : MonoBehaviour
{
    Animator animator;
    public GameObject object_to_activate;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void OnMouseDown()
    {
        animator.SetTrigger("active");
        object_to_activate.SetActive(true);
    }
}
