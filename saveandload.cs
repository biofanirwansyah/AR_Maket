using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class saveandload
{
    public static void SaveObjek(objek obj)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/player.fun";
        FileStream stream = new FileStream(path, FileMode.Create);
        objekdata data = new objekdata(obj);
        formatter.Serialize(stream, data);
        stream.Close();

    }

    public static objekdata LoadObjek()
    {
        string path = Application.persistentDataPath + "/player.fun";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);
            objekdata data = formatter.Deserialize(stream) as objekdata;
            stream.Close();
            return data;
        }
        else
        {
            Debug.LogError("Save File Tidak Ditemukan di " + path);
            return null;
        }
    }
}
