using System;
using System.IO.Ports;
using TMPro;
using UnityEngine;

public class SerialObject : MonoBehaviour
{
    public TMP_Text puerto;

    public TMP_Text salida;
    public TMP_InputField baudrate;
    private SerialPort _port;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        if (_port != null)
        {
            if (_port.IsOpen)
            {
                Console.Write("Funciona");
                try
                {
                    //char let = (char)port.ReadChar();
                    var a = _port.ReadTo("\n");
                    if (a == "")
                    {
                        Debug.Log("Vacio");
                    }
                    else
                    {
                        salida.text = a;
                        Debug.Log(a);
                    }
                }
                catch (SystemException)
                {
                }
            }
        }
    }

    public void Conectar()
    {
        //Debug.Log(puerto.text);
        int a = int.Parse(baudrate.text);
        Debug.Log(a);
        _port = new SerialPort(puerto.text, int.Parse(baudrate.text));
        _port.Open();
        _port.ReadTimeout = 0;
    }

    private void OnDestroy()
    {
        _port?.Close();
    }
}