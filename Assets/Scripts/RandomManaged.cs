using UnityEngine;
using System.Collections;

public class RandomManaged : MonoBehaviour {

	RandomNumberManaged.MyClass rand;


	// Use this for initialization
	void Start () {
		rand = new RandomNumberManaged.MyClass();
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log( "Random Number from Managed Plugin:" + rand.GetRandom() );
	}
}
