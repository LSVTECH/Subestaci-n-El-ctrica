using UnityEngine;

public class AnimationTrigger : MonoBehaviour
{
    public Animator animator;
    public string boolParameterName = "isNear";
    public Collider playerCollider;

    public AudioSource openPopUpSound;

    public GameObject popupPiezas;


    private void OnTriggerEnter(Collider other)
    {
        if (other == playerCollider)
        {
            animator.SetBool(boolParameterName, true);

            openPopUpSound.Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other == playerCollider)
        {
            animator.SetBool(boolParameterName, false);
        }
    }

    public void PopupPiezas()
    {
        popupPiezas.SetActive(true);
        animator.SetBool(boolParameterName, true);
    }

    public void SoltarPiezas()
    {
        popupPiezas.SetActive(false);
        animator.SetBool (boolParameterName, false);
    }
}

