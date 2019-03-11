using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Animal : MonoBehaviour
{
	public UnityEvent Event;

	public string characterName;
	public FloatData health;
	public FloatData speed;
	public bool canMove;

	protected Color newColor;
	
	public Color skinColor;

	// Use this for initialization
	private void Start () 
	{
		Event.Invoke();
	}
	
	// Update is called once per frame
	private void Update () 
	{
		
	}

	public void Move()
	{
		print("move");
	}
}
