using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour
{


	public GameObject human;
	private float nextHuman;
	public float humanCoolDown;
	// Use this for initialization
	void Start ()
	{
		nextHuman = Time.time + humanCoolDown;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Time.time >= nextHuman) {
			Instantiate (human, new Vector3 (-18.0f, 1.15f, 0f), Quaternion.identity);
			nextHuman = Time.time + humanCoolDown;

		}
	}
}
