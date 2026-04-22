using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MayoriaDeEdadUI : MonoBehaviour
{

    //Crear los elementos de UI para permitir al usuario ingresar dos nros enteros y que al presionar un bot muestre en pantalla el resultado de la suma de los nros ingresados
    //Incluir un titulo de UI y (opcioal) si alguno de los numeros ingresados es negtivo mostrar error en el resultado 

    public TMP_InputField input_IngresoEdad;
    public TextMeshProUGUI txt_Resultado;


    void Start()
    {
        
    }


    void Update()
    {
        
    }

    public void CheckLegalAge()
    {
        int userAge = int.Parse(input_IngresoEdad.text);
        if(userAge < 18)
        {
            txt_Resultado.text = "No es mayor";
        }
        else
        {
            txt_Resultado.text = "Es mayor";
        }
    }
}
