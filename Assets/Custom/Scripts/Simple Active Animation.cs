using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleActiveAnimation : MonoBehaviour
{
    public Animator activarAnimator;
    public GameObject sensor;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Card")
        {
            ActiveAnimation();
        }
    }


    public void ActiveAnimation()
    {
        activarAnimator.enabled = true;
    }
}
