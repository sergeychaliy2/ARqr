using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

//Класс, отвечающий за отображение данных об устройстве на GUI.
public class DeviceInfoVisualizer : MonoBehaviour
{
    private readonly DeviceLoader loader;
    public void 

    public DeviceInfoVisualizer() => loader = new ScriptableLoader();

    private void Update()
    {
        DeviceInfo device = loader.GetDevice(1);
        Debug.Log(device.name + " " + device.serie);
    }

    public void ShowInfo(uint id_device)
    {
        DeviceInfo device = loader.GetDevice(id_device);
        //TODO: Реализовать отображение данных об устройстве на GUI.
    }

    /*
     * TODO: Реализовать метод ClearInfo(), который будет очищать GUI
     * после того, как камера не видит QR - код.
     */
    public void ClearInfo()
    {
        
    }
}
