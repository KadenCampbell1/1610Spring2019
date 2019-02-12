using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ChangeColorEvent : MonoBehaviour
{
	public UnityEvent colorEvent;

	public void ChangeColor()
	{
		GetComponent<SpriteRenderer>().color = Color.black;
	}

	// Use this for initialization
	void Start () 
	{
		colorEvent.Invoke();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
