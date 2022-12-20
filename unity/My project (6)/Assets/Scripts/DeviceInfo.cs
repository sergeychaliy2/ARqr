using UnityEngine;

//Класс, инкапсулирующий данные об устройстве.
[CreateAssetMenu (fileName = "Data", menuName = "ScriptableObjects/Device")]
public class DeviceInfo : ScriptableObject
{
    public uint id_device;
    public int manufactureYear;
    public int serviceLife;
    public int serie;
}