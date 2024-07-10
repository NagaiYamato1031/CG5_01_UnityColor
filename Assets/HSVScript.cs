using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HSVScript : MonoBehaviour
{
	[Range(0.0f, 1.0f)]
	public float H = 0.0f, S = 1.0f, V = 1.0f;

	private Material material;

	// Start is called before the first frame update
	void Start()
	{
		material = GetComponent<Renderer>().material;
	}

	// Update is called once per frame
	void Update()
	{
		material.color = Color.HSVToRGB(H, S, V);
	}
}
