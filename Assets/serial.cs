using System;
using System.IO.Ports;
using TMPro;
using UnityEngine;

public class serial : MonoBehaviour
{
    public TMP_Text TMPText;

    private readonly SerialPort port = new("COM3", 9600);

    // Start is called before the first frame update
    private void Start()
    {
        port.Open();
        port.ReadTimeout = 0;

        TMPText.text = "Hola mundo";
    }

    // Update is called once per frame
    private void Update()
    {
        if (port.IsOpen)
        {
            Console.Write("Funciona");
            try
            {
                //char let = (char)port.ReadChar();
                var a = port.ReadTo("\n");
                if (a == "")
                {
                    Debug.Log("Vacio");
                }
                else
                {
                    TMPText.text = a;
                    Debug.Log(a);
                }
            }
            catch (SystemException)
            {
            }
        }
    }

    private void OnDestroy()
    {
        port.Close();
    }
}