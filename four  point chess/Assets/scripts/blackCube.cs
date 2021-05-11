using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blackCude : MonoBehaviour
{
    private GameObject obj;
    private Renderer render;
    void Start()
    {
        obj = GameObject.Find("Cube");
        render = obj.GetComponent<Renderer>();
        render.material = null;
        render.material.color = Color.black;

    }
}