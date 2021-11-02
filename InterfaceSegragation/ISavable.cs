using System.Runtime.Serialization.Formatters.Binary;

namespace InterfaceSegragation
{
    public interface ISavable
    {
        string SerialiseToJsonString(string id);

        object SerialiseToBinaryFormatter(string id);

        byte[] SerialiseToByteArray(string id);

        T SerialiseToType<T>(string id);
    }
}