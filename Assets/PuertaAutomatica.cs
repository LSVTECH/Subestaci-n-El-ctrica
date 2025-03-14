using UnityEngine;

public class PuertaAutomatica : MonoBehaviour
{
    public GameObject PuertaIzq, PuertaDrc;
    public Animator PuertaAnimIzq, PuertaAnimDrc;

    private void Start()
    {
        // Se obtiene el componente Animator de cada puerta
        PuertaAnimIzq = PuertaIzq.GetComponent<Animator>();
        PuertaAnimDrc = PuertaDrc.GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            PuertaAnimDrc.SetBool("Player", true);
            PuertaAnimIzq.SetBool("Player", true);
            Debug.Log("Abriendo puerta");
        }
        else
        {
            PuertaAnimDrc.SetBool("Player", false);
            PuertaAnimIzq.SetBool("Player", false);
            Debug.Log("Cerrando puerta");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            PuertaAnimDrc.SetBool("Player", false);
            PuertaAnimIzq.SetBool("Player", false);
            Debug.Log("Abriendo puerta");
        }
        else
        {
            PuertaAnimDrc.SetBool("Player", true);
            PuertaAnimIzq.SetBool("Player", true);
            Debug.Log("Cerrando puerta");
        }
    }
}
