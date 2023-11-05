using UnityEngine;

public class TriggerAnimation : MonoBehaviour
{
    public GameObject objectToAnimate; // Oggetto da animare
    public Animator animator;

    private void Start()
    {
        if (animator == null)
        {
            Debug.LogError("Nessun Animator trovato sull'oggetto.");
        }

        if (objectToAnimate == null)
        {
            Debug.LogError("Specificare l'oggetto da animare nell'Inspector.");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            print(objectToAnimate);
            print(animator);
            if (animator != null)
            {
                animator.SetBool("IsOpen", true);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (animator != null)
            {
                animator.SetBool("IsOpen", false);
            }
        }
    }
}


