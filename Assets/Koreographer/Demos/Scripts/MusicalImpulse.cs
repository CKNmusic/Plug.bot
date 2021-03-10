//----------------------------------------------
//            	   Koreographer                 
//    Copyright © 2014-2016 Sonic Bloom, LLC    
//----------------------------------------------

using UnityEngine;

namespace SonicBloom.Koreo.Demos
{
	[RequireComponent(typeof(Rigidbody))]
	[AddComponentMenu("Koreographer/Demos/Musical Impulse")]
	public class MusicalImpulse : MonoBehaviour
	{
		public bool isLight;
		[EventID]
		public string eventID;
		public float jumpSpeed = 3f;

		Rigidbody rigidbodyCom;
		Light light;

		void Start()
		{
			// Register for Koreography Events.  This sets up the callback.
			if (!isLight)
			{
				rigidbodyCom = GetComponent<Rigidbody>();
				Koreographer.Instance.RegisterForEvents(eventID, AddImpulse);
			}
			else
			{
				
			}



		}

		void OnDestroy()
		{
			// Sometimes the Koreographer Instance gets cleaned up before hand.
			//  No need to worry in that case.
			if (Koreographer.Instance != null)
			{
				Koreographer.Instance.UnregisterForAllEvents(this);
			}
		}
		
		void AddImpulse(KoreographyEvent evt)
		{
			// Add impulse by overriding the Vertical component of the Velocity.
			Vector3 vel = rigidbodyCom.velocity;
			vel.y = jumpSpeed;

			rigidbodyCom.velocity = vel;
		}
	}
}
