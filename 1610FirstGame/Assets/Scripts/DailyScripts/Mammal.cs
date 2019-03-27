using UnityEngine.Events;

namespace DailyScripts
{
	public class Mammal : Animal
	{
		public int furCount = 10000;
		public float eatingSpeed = 0.4f;
		public bool canEat = true;
		public UnityEvent myEvent;


		// Use this for initialization
		void Start () 
		{
			myEvent.Invoke();
		}
	
		// Update is called once per frame
		void Update () 
		{
		
		}
	}
}
