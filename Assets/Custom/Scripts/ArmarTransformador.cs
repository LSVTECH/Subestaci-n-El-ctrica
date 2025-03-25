using UnityEngine;

public class ArmarTransformador : MonoBehaviour
{
    public int puntosMeta = 6;
    public int puntos = 0;

    public GameObject fbxConfite;

    public void SumaPuntos()
    {
        puntos++;

        if (puntos == 6)
        {
            Debug.Log("Armaste el transformador yeeeei");
            // TODO: Poner la funcion que va hacer al llegar a 6 puntos
            fbxConfite.SetActive(true);
        }
    }
    public void TransformadorArmado()
    {
     
    }
}
