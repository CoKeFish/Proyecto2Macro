using System.IO.Ports;
using TMPro;
using UnityEngine;

public class SerialObject : MonoBehaviour
{
    public TMP_Text puerto;
    public TMP_Text baudrate;
    private SerialPort _port;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
    }

    private void Funcionar()
    {
        _port = new SerialPort(puerto.text, int.Parse(baudrate.text));
    }
}