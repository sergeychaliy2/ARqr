using Polimorf;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : IDeviceLoader
{
    // Start is called before the first frame update
    public string deviceinfo;
    void Start()
    {
        deviceinfo = " ";
    }

    // Update is called once per frame
    public void ButClick()
    {
        deviceinfo= DeviceInfo.GetDevice();
        Debug.Log(deviceinfo);
    }
}
