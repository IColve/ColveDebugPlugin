using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class ColveTest : MonoBehaviour 
{
	public void TestLog()
	{
		ColveDebugView.Log(Random.Range(0, 10000).ToString());
	}
}
