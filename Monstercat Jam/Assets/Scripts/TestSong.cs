using UnityEngine;
using System.Collections;

public class TestSong : MonoBehaviour
{
    public Transform BlueNote;
    public Transform GreenNote;
    public Transform RedNote;
    public Transform YellowNote;

    //Length of the song
    public float songlength = 0;

    //Key pressed to hit the note
    public KeyCode keyBlue;
    public KeyCode keyGreen;
    public KeyCode keyRed;
    public KeyCode keyYellow;

    //Used to destroy the note once somethign happens
    public static string destroyBlue = "n";
    public static string destroyGreen = "n";
    public static string destroyRed = "n";
    public static string destroyYellow = "n";

    // Use this for initialization
    void Start()
    {
	
	}

    void FixedUpdate()
    {
        songlength += Time.deltaTime;

        if((songlength >= .1) && (songlength <= .125))
            Instantiate(BlueNote, BlueNote.position, BlueNote.rotation);

        if((songlength >= 1) && (songlength <= 1.025))
            Instantiate(YellowNote, YellowNote.position, YellowNote.rotation);

        if((songlength >= 1.75) && (songlength <= 1.775))
            Instantiate(RedNote, RedNote.position, RedNote.rotation);

        if((songlength >= 2.75) && (songlength <= 2.775))
            Instantiate(GreenNote, GreenNote.position, GreenNote.rotation);

        if((songlength >= 3.5) && (songlength <= 3.525))
            Instantiate(RedNote, RedNote.position, RedNote.rotation);

        if((songlength >= 4) && (songlength <= 4.025))
            Instantiate(GreenNote, GreenNote.position, GreenNote.rotation);

        if((songlength >= 4.5) && (songlength <= 4.525))
            Instantiate(YellowNote, YellowNote.position, YellowNote.rotation);

        if((songlength >= 4.5) && (songlength <= 4.525))
            Instantiate(RedNote, RedNote.position, RedNote.rotation);

    }

    //Checkes if key is pressed when note collieds at bottom
    void OnTriggerStay2D(Collider2D other)
    {
        //Deletes note when note reaches bottom
        if((Input.GetKeyDown(keyBlue)) && (other.gameObject.name == "Blue Note(Clone)"))
            destroyBlue = "y";

        if((Input.GetKeyDown(keyGreen)) && (other.gameObject.name == "Green Note(Clone)"))
            destroyGreen = "y";

        if((Input.GetKeyDown(keyRed)) && (other.gameObject.name == "Red Note(Clone)"))
            destroyRed = "y";

        if((Input.GetKeyDown(keyYellow)) && (other.gameObject.name == "Yellow Note(Clone)"))
            destroyYellow = "y";

    }

    // Update is called once per frame
    void Update()
    {
	
	}
}
