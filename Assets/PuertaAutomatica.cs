using UnityEngine;

public class PuertaAutomatica : MonoBehaviour
{
    public GameObject PuertaIzq, PuertaDrc;
    private Animator PuertaAnimIzq, PuertaAnimDrc;

    private void Start()
    {
        // Se obtiene y verifica el componente Animator de cada puerta
        if (PuertaIzq != null) PuertaAnimIzq = PuertaIzq.GetComponent<Animator>();
        if (PuertaDrc != null) PuertaAnimDrc = PuertaDrc.GetComponent<Animator>();

        if (PuertaAnimIzq == null || PuertaAnimDrc == null)
        {
            Debug.LogError("Uno o más Animator no fueron encontrados en las puertas.");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PuertaAnimDrc?.SetBool("Player", true);
            PuertaAnimIzq?.SetBool("Player", true);
           // Debug.Log("Abriendo puerta");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PuertaAnimDrc?.SetBool("Player", false);
            PuertaAnimIzq?.SetBool("Player", false);
           // Debug.Log("Cerrando puerta");
        }
    }
}
