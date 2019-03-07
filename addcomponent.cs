using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class addcomponent : MonoBehaviour
{



    public GameObject[] allObjects;
    private void Start()
    {
        allObjects = (GameObject[])Object.FindObjectsOfType(typeof(GameObject));
        foreach (GameObject obj in allObjects)
            obj.AddComponent(typeof(objek));
        foreach (GameObject obj in allObjects)
            obj.AddComponent(typeof(MeshCollider));
    }
       
            
}
