using UnityEngine;

//Класс, отвечающий за загрузку информации об имеющихся устройствах из базы данных, где каждый элемент данных представляет собой ScriptableObject.
public class ScriptableLoader : DeviceLoader
{
    //TODO: Реализовать метод GetDevice(), который загружает устройство из базы по идентификатору id_device.
    public DeviceInfo GetDevice(uint id_device)
    {
        DeviceInfo[] devices = Resources.LoadAll("Database", typeof(ScriptableObject)) as DeviceInfo[];
        foreach (DeviceInfo device in devices) if (device.id_device == id_device) return device;
        return null;
    }
}