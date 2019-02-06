﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : Animal
{
	public Color finColor;
	

	// Use this for initialization
	void Start ()
	{
		GetComponent<SpriteRenderer>().color = skinColor;
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.Rotate(0,1,0);
	}
}
