﻿using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;
using Assets.Scripts;
using System.Collections.Generic;

public class GameTest : MonoBehaviour {

    GameEngine engine;

    void Awake()
    {
        engine = Camera.main.GetComponent<GameEngine>();
    }
	// Use this for initialization
	void Start () {
    }
	
	// Update is called once per frame
	void Update () {
        
	}


}
