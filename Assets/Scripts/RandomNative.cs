using UnityEngine;
using System.Collections;
using System.Runtime.InteropServices;

public class RandomNative : MonoBehaviour
{
	[DllImport("RandomNumberNative")]
	private static extern int GetRandom();

	// Use this for initialization
	void Start()
	{
	}

	void Update()
	{
		print("Random Number from Native Plugin: " + GetRandom());
	}

}