using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProGen : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private int capHeight(int height) {
		const int max = 4;
		const int min = 0;

		if(height > max)
			return max;
		else if(height < min)
			return min;
		else
			return height;
	}

	private int getNextHeight(int twobefore, int onebefore, int[] variancechances, Int32 seed) {
		return onebefore + (onebefore - twobefore) + getVariance(variancechances, seed);
	}

	private int getVariance(int[] chances, Int32 seed) {
		System.Random rand = new System.Random(seed);

		int chancessum = 0;
		foreach(var cur in chances)
			chancessum += cur;

		int choice = rand.Next(0, chancessum);

		int last = 0;

		for(int i = 0; i < chances.Length; i++) {
			if(choice >= last && choice < last + chances[i])
				return i - 2;

			last += chances[i];
		}

		return 0;
	}
}
