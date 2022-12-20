//»нтерфейс, определ€ющий список методов дл€ классов, реализующих загрузку информации об устройствах из базы данных.
interface DeviceLoader
{
    public DeviceInfo GetDevice(uint id_device);
}