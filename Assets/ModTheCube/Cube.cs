﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    
    void Start()
    {
        transform.position = new Vector3(0, 1, 5);
        transform.localScale = Vector3.one * 3f;

        
        InvokeRepeating("ChangeColour", 2.5f, 2.5f);
    }

    public void ChangeColour()
    {
        Material material = Renderer.material;
        material.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
    }

    void Update()
    {
        transform.Rotate(20.0f * Time.deltaTime, 0.0f, 0.0f);
    }
}
