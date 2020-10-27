﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallSpawner : MonoBehaviour
{
    public GameObject Ball;
    public float padding;
    private float XMin, XMax, YMin, YMax;

    // Start is called before the first frame update
    void Start()
    {
        Camera mainCamera = Camera.main;
        XMin = mainCamera.ViewportToWorldPoint(new Vector3(0,0,0)).x + padding;
        XMax = mainCamera.ViewportToWorldPoint(new Vector3(1,0,0)).x - padding;
        YMin = mainCamera.ViewportToWorldPoint(new Vector3(0,0,0)).y + padding;
        YMax = mainCamera.ViewportToWorldPoint(new Vector3(0,1,0)).y - padding;

        Instantiate(Ball, new Vector3(XMin, YMin, 0), Quaternion.identity);
        Instantiate(Ball, new Vector3(XMin, YMax, 0), Quaternion.identity);
        Instantiate(Ball, new Vector3(XMax, YMin, 0), Quaternion.identity);
        Instantiate(Ball, new Vector3(XMax, YMax, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
