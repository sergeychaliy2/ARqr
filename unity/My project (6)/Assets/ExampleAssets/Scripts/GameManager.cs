
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.InputSystem.LowLevel.InputEventTrace;

namespace Polimorf
{

    public class GameManager : ScriptableLoader
    {
        DeviceInfo deviceInfo = new DeviceInfo(1, 2, 3);
        // Start is called before the first frame update
        public string deviceinfo;
        void Start()
        {
            deviceinfo = " ";
        }

        // Update is called once per frame
        public void ButClick()
        {
            deviceinfo = GetDevice(deviceInfo);
            Debug.Log(deviceinfo);
        }
    }
}
