using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class objekdata
{
    public float r;
    public float g;
    public float b;
    public float x;
    public float y;
    public float z;
    public string names;
    public objekdata(objek obj,dataobjek dataobj)
    {
        r = obj.r;
        g = obj.g;
        b = obj.b;
        x=obj.transform.localScale.x;
        y=obj.transform.localScale.z;
        z=obj.transform.localScale.z;
        foreach (string str in dataobj.name)
        {
            names += str; 
        }
    }
}
