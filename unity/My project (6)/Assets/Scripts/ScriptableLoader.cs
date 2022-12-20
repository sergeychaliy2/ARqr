using System;
using UnityEngine;

//Класс, отвечающий за загрузку информации об имеющихся устройствах из базы данных, где каждый элемент данных представляет собой ScriptableObject.
public class ScriptableLoader : DeviceLoader
{
    //TODO: Реализовать метод GetDevice(), который загружает устройство из базы по идентификатору id_device.
    public DeviceInfo GetDevice(uint id_device)
    {
        Debug.Log($"Идентификатор устройства: {id_device}");
        throw new NotImplementedException();
    }
}