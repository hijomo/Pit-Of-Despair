using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class HumanMover : MonoBehaviour
{


	private Rigidbody2D rb ;
	private bool pause;
	public float speed;
	public float pauseSpeed;
	private float pauseStart;
	public float pauseTime;
	private bool caught = false;
	private CatNames catNames;
	// Use this for initialization
	void Start ()
	{
		rb = GetComponent<Rigidbody2D> ();
		catNames = new CatNames ();
	}

	void OnTriggerEnter2D (Collider2D other)
	{

		pause = true;
		pauseStart = Time.time;
		Debug.Log ("entered collider" + other.name);
		if (other.tag == "Pit") {
			caught = true;
			Destroy (gameObject, 4.0f);
		}
	}

	// Update is called once per frame
	void Update ()
	{

		if (!caught) {
			if (rb.velocity.x <= 10 && !pause) {
				rb.AddForce (Vector3.right * speed * Time.deltaTime);
			}
			if (pause && rb.velocity.x > 1) {
				rb.AddForce (Vector3.left * pauseSpeed * Time.deltaTime);
			}

			if (pause && Time.time > pauseStart + pauseTime) {
				pause = false;
				Debug.Log ("pause ended");
			}

		}

		if (caught) {
		
		}


//		Debug.Log (rb.velocity);





	}
}




public class CatNames
{
	private	List<string> catNames = new List<string> (new string[]
	{
		"Alfie",
		"Angel",
		"Argus",
		"Arwen",
		"Ashton",
		"Baby",
		"Bailey",
		"Bassil",
		"Beage",
		"Bender",
		"Benny",
		"Big Red",
		"Big Sammy",
		"Binka",
		"Binx",
		"Blackie",
		"Bobo",
		"Boogie",
		"Boris",
		"Bowser",
		"Brandy",
		"Buddy",
		"Butterscotch",
		"Cally",
		"Caramel",
		"Casey",
		"Catherine",
		"Cece",
		"Celine",
		"Cherio",
		"Chloe",
		"Churchill",
		"Cinders",
		"Clarence",
		"Claude",
		"Cleo",
		"Coffee",
		"Cookie",
		"Cooper",
		"Cosmo",
		"Couch Potato",
		"Daisy",
		"Dakota",
		"Dark Moon",
		"David",
		"Denver",
		"Diesel",
		"Dilon",
		"Disney",
		"Dissy",
		"Divine",
		"Dude",
		"Ebony",
		"Enzo",
		"Faggie",
		"Fagison",
		"Felix",
		"Ferris",
		"Fifi",
		"Flowerbee",
		"Fluffernet",
		"Fluffy",
		"Fosters",
		"Freckles",
		"Frollo",
		"Freckuls",
		"Fudge",
		"Fudge",
		"Fuffie",
		"Gabrielle",
		"Gadget",
		"Gary",
		"Ginger",
		"Gipsy",
		"Gizmo",
		"Gore",
		"Grace",
		"Griswald",
		"Grizz",
		"Grizzabella",
		"Harley",
		"Hazel",
		"Henry",
		"Hex",
		"Hoppy",
		"Indy",
		"Izzy",
		"Jasmine",
		"Jay",
		"Jinx",
		"Jon",
		"Jymes Dean",
		"Katie",
		"Kelee",
		"Kenny",
		"Kirby",
		"Kitty",
		"Kliff",
		"Kool Kat",
		"Lady",
		"Larry",
		"Lera",
		"Lexie",
		"Lincoln",
		"Little",
		"Lucy",
		"Mac",
		"Mackie",
		"Marbles",
		"Mario",
		"Marley",
		"Marmelade",
		"Martin",
		"Max",
		"Maxine",
		"Merlin",
		"Micky",
		"Midnight",
		"Mippen",
		"Misty",
		"Missy",
		"Mittens",
		"Mitzy",
		"Molly",
		"Moon Pie",
		"Moriarty",
		"Moritz",
		"Moses",
		"Mozart",
		"Ms Kitty",
		"Myah",
		"Nala",
		"Natasha",
		"Nemo",
		"Niglet",
		"Nikita",
		"Noodles",
		"Noodlehead",
		"Oliver",
		"Oreo",
		"Orwell",
		"Oscar",
		"Panda",
		"Patsy",
		"Paws",
		"Peanut",
		"Peter",
		"Phoebe",
		"Pinkle",
		"Plinky",
		"Poocat",
		"Pooder",
		"Pookie",
		"Prince",
		"Princess",
		"Pumpkin",
		"Punkin",
		"Purr",
		"Rajha",
		"Ralph",
		"Rascal",
		"Romeo",
		"Roxie",
		"Rylie",
		"Sadie",
		"Salem",
		"Sammy",
		"Sasha",
		"Scooter",
		"Scout",
		"Secret",
		"Shadow",
		"Shane",
		"Shelby",
		"Simba",
		"Simon",
		"Simpson",
		"Slippers",
		"Smudge",
		"Sophie",
		"Soushi",
		"Sparkle",
		"Sputnick",
		"Stanley",
		"Starlett",
		"Sticky",
		"Stimpy",
		"Stray",
		"Sugar",
		"Sunny",
		"Tater",
		"Tigger",
		"Tinkerbell",
		"Tina",
		"Tiny",
		"Tobi",
		"Tori",
		"Tricia",
		"Tucker",
		"Tuna",
		"Twiggy",
		"Walter",
		"Whiskers",
		"Willow",
		"Wyatt",
		"Xman",
		"Zakkie",
		"Zebra"
	});

	System.Random rnd = new System.Random ();

	public string GetCatName ()
	{

		return catNames [rnd.Next (catNames.Count)];


	}


}