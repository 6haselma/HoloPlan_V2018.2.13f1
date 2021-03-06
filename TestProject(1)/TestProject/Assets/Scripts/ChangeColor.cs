﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour {
public Renderer renderer;
public Material notSelected;
public Material selected;

private int count = 0;

public Material red;
public Material green;
	
	void Start () {
		renderer = GetComponent<Renderer> ();
		renderer.enabled = true;
	}


	void OnMouseDown () {
		Material selectedMat = notSelected;
		
		if (Input.GetMouseButtonDown (0)) {
			count += 1;
		
			if (count % 4 == 0)  {
				selectedMat = notSelected;
				}

			else if (count % 4 == 1)  {
				selectedMat = selected;
				}

			else if (count % 4 == 2)  {
				selectedMat = red;
				}

			else if (count % 4 == 3)  {
				selectedMat = green;
				}
		Debug.Log("Index: " + count);
		renderer.sharedMaterial = selectedMat;
		}
		
	}
}
