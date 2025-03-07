using UnityEngine;

public class AnimationTrigger : MonoBehaviour
{
    public Animator animator;
    public string boolParameterName = "isNear";
    public Collider playerCollider;

    public AudioSource openPopUpSound;

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
}

