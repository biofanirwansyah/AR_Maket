using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zoominout : MonoBehaviour
{
    public float minfov = 15f;
    public float maxfov = 90f;
    public float sensitive = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float fov = Camera.main.fieldOfView;
        fov += Input.GetAxis("Mouse ScrollWheel") * sensitive;
        fov = Mathf.Clamp(fov, minfov, maxfov);
        Camera.main.fieldOfView = fov;
    }
}
