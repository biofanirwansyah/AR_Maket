﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objek : MonoBehaviour
{
    public Color color;
    public float r;
    public float g;
    public float b;
    public float a;
    Vector3 temp;
    Renderer rend;
    public int index;
    public string name;
    public dataobjek names;
    public buttonScript clrred;
    public buttonScript clrsave;
    public buttonScript clrload;//tambahkansendiri warnanya
    
    private void Start()
    {
       clrred= GameObject.Find("red").GetComponent(typeof(buttonScript)) as buttonScript;
        clrsave = GameObject.Find("save").GetComponent(typeof(buttonScript)) as buttonScript;
        clrload = GameObject.Find("load").GetComponent(typeof(buttonScript)) as buttonScript;
        names = GameObject.Find("dataobjek").GetComponent(typeof(dataobjek)) as dataobjek;
    }
    
    //tambahkansendiri warnanya
    private void Update()
    {
   
         if (clrred.red == 1)
        {
            merah();
            index = 0;
        }
        else
        {

        }
        if (clrsave.save == 1)
        {
            SaveObjek();
           
        }
        else
        {

        }
        if (clrload.load == 1)
        {
            LoadObjek();
           
        }
        else
        {

        }
    }
    
    
    private void OnMouseDown()
    {
        index = 1;
        name = this.gameObject.name;
    }
    //dari sini
    private void OnMouseEnter()
    {
        name = this.gameObject.name;
        color = new Color(0f, 0f, 0f, 1f);
        GameObject.Find(name).GetComponent<Renderer>().material.color = color;
    }
    private void OnMouseExit()
    {
        name = this.gameObject.name;
        GameObject.Find(name).GetComponent<Renderer>().material.color = Color.white;
    }
    //sampai sini
    public void merah()
    {
        if (index == 1)
        {
            r = 1f;
            g = 0f;
            b = 0f;
            a = 1f;
            color = new Color(r, g, b, a);
            GameObject.Find(name).GetComponent<Renderer>().material.color = color;
        }
    }
    
    public void kuning()
    {
        if (index == 1)
        {
            r = 1f;
            g = 0.92f;
            b = 0.016f;
            a = 1f;
            color = new Color(r, g, b, a);
            GameObject.Find(name).GetComponent<Renderer>().material.color = color;
        }
    }
    public void hijau()
    {
        if (index == 1)
        {
            r = 0f;
            g = 1f;
            b = 0f;
            a = 1f;
            color = new Color(r, g, b, a);
            GameObject.Find(name).GetComponent<Renderer>().material.color = color;
        }
    }

    public void biru()
    {
        if (index == 1)
        {
            r = 0f;
            g = 0f;
            b = 1f;
            a = 1f;
            color = new Color(r, g, b, a);
            GameObject.Find(name).GetComponent<Renderer>().material.color = color;
        }
    }
    public void SaveObjek()
    {
        saveandload.SaveObjek(this);
    }

    public void LoadObjek()
    {
        objekdata data = saveandload.LoadObjek();

        r = data.r;
        g = data.g;
        b = data.b;
        temp = transform.localScale;
        temp.x = data.x;
        temp.y = data.y;
        temp.z = data.z;
        transform.localScale = temp;
        color = new Color(r, g, b, a);
        GameObject.Find(name).GetComponent<Renderer>().material.color = color;
    }

    public void SizeX() {
        temp = transform.localScale;
        temp.x += 1f;
        Debug.Log(temp.x);
        transform.localScale = temp;
        
    }

    public void SizeY()
    {
        temp = transform.localScale;
        temp.y += 1f;
        Debug.Log(temp.y);
        transform.localScale = temp;
    }

    public void SizeZ()
    {
        temp = transform.localScale;
        temp.z += 1f;
        Debug.Log(temp.z);
        transform.localScale = temp;
    }

    public void SizeminX()
    {
        temp = transform.localScale;
        temp.x -= 1f;
        Debug.Log(temp.x);
        transform.localScale = temp;

    }

    public void SizeminY()
    {
        temp = transform.localScale;
        temp.y -= 1f;
        Debug.Log(temp.y);
        transform.localScale = temp;
    }

    public void SizeminZ()
    {
        temp = transform.localScale;
        temp.z -= 1f;
        Debug.Log(temp.z);
        transform.localScale = temp;
    }
}
