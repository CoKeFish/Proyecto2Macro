using System;
using System.IO.Ports;
using TMPro;
using UnityEngine;

public class DropDownPort : MonoBehaviour
{
    public TMP_Dropdown Dropdown;

    // Start is called before the first frame update
    private void Start()
    {
        refres();
    }

    // Update is called once per frame
    private void Update()
    {
    }

    public void refres()
    {
        Dropdown.ClearOptions();
        var ports = SerialPort.GetPortNames();
        foreach (var portName in ports)
            try
            {
                Debug.Log(portName); //read available port names      
                Dropdown.options.Add(new TMP_Dropdown.OptionData(portName));
            }
            catch (SystemException)
            {
            }
    }
}