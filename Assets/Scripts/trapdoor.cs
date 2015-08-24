using UnityEngine;
using System.Collections;

public class trapdoor : MonoBehaviour
{
	private BoxCollider2D bc;
	// Use this for initialization
	void Start ()
	{
		bc = GetComponent<BoxCollider2D> ();

	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.Space)) {
			bc.enabled = false;
		}

		if (Input.GetKeyUp (KeyCode.Space)) {
			bc.enabled = true;
		}

	}
}

