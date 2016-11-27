//put credit and stuff here when i rember to

using UnityEngine;
using System.Collections;

public class NoteController : MonoBehaviour
{


	//Use this for initialization
	void Start()
    {
        if(gameObject.name == "Red Note(Clone)")
            GetComponent<Rigidbody2D>().velocity = new Vector2(-.60f, -1);
        if(gameObject.name == "Blue Note(Clone)")
            GetComponent<Rigidbody2D>().velocity = new Vector2(-.20f, -1);
        if(gameObject.name == "Green Note(Clone)")
            GetComponent<Rigidbody2D>().velocity = new Vector2(.20f, -1);
        if(gameObject.name == "Yellow Note(Clone)")
            GetComponent<Rigidbody2D>().velocity = new Vector2(.60f, -1);

    }
	
	//Update is called once per frame
	void Update()
    {
        //Destroys the note
	    if ((TestSong.destroyBlue == "y") && (gameObject.name == "Blue Note"))
            Destroy(gameObject);

        if((TestSong.destroyGreen == "y") && (gameObject.name == "Green Note"))
            Destroy(gameObject);

        if((TestSong.destroyRed == "y") && (gameObject.name == "Red Note"))
            Destroy(gameObject);

        if((TestSong.destroyYellow == "y") && (gameObject.name == "Yellow Note"))
            Destroy(gameObject);

    }
}
