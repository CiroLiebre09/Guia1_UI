using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Suma : MonoBehaviour
{
    public TMP_InputField input_suma1;
    public TMP_InputField input_suma2;
    public TextMeshProUGUI txt_Resultado;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Sumar()
    {
        int parsearNum1 = int.Parse(input_suma1.text);
        int parsearNum2 = int.Parse(input_suma2.text);
        int suma = parsearNum1 + parsearNum2;
        string resultado = (suma).ToString();
        txt_Resultado.text = "el resultado de la suma entre los dos números ingresados es " + resultado;
    } 
}
