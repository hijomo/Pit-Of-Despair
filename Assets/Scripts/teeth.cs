using UnityEngine;
using System.Collections;

public class teeth : MonoBehaviour
{

	private Animator ani;
	private AudioSource aus;
	// Use this for initialization
	void Start ()
	{
		ani = GetComponent<Animator> ();
		aus = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.J)) {
			ani.SetTrigger ("eat");
			aus.PlayDelayed (0.4f);
		}
	}
}
