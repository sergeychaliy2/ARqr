using UnityEngine;

//�����, ��������������� ������ �� ����������.
[CreateAssetMenu (fileName = "Data", menuName = "ScriptableObjects/Device")]
public class DeviceInfo : ScriptableObject
{
    public uint id_device;
    public int manufactureYear;
    public int serviceLife;
    public int serie;
}