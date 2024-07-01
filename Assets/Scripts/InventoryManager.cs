using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public int valor1;
    public int valor2;
    public int[] numerosDePaola;

    private void Start()
    {
        Impresora();
        AsiSeUsaUnFor();
    }

    private void Impresora() 
    {
        //Debug.Log(numerosDePaola[0] + " " + numerosDePaola[1] + " " + numerosDePaola[2] + " " + numerosDePaola[3] + " " + numerosDePaola[4]);
    }
    
    private void AsiSeUsaUnFor() 
    {
        for (int i = 0; i < numerosDePaola.Length; i++)
        {
            if (numerosDePaola[i] >= 0)
            {
                Debug.Log("en la posición: " + i + " soy: " + numerosDePaola[i] + " Por lo tanto soy mayor o igual que 0");
            }
            else
            {
                Debug.Log("en la posición: " + i + " soy: " + numerosDePaola[i] + " Por lo tanto soy menor que 0 :3");
            }

        }
    }

    public void BotonQueIncrementa() 
    {
        valor1++;
        Debug.Log(valor1);
    }
}
