using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
	//Use this for initialization
	void Start ()
    {
	
	}
	
	//Update is called once per frame
	void Update()
    {
	
	}

    //Loads the Main Menu
    public void LoadMainMenu()
    {
        //float fadeTime = GameObject.Find("Canvas").GetComponent<Fading>().BeginFade(1);
        //FadePause();
        SceneManager.LoadScene("MainMenu");
    }

    //Loads Title scene
    public void LoadTitle()
    {
        SceneManager.LoadScene("Title");
    }

    //Loads the Options Menu
    public void LoadOptionsMenu()
    {
        SceneManager.LoadScene("OptionsMenu");
    }

    //Loads the Album Select Scene
    public void LoadAlbumSelect()
    {
        SceneManager.LoadScene("AlbumSelect");
    }

    //Loads the Song Select scene
    public void LoadSongSelect()
    {
        SceneManager.LoadScene("SongSelect");
    }

    //Loads the Difficulty Select scene
    public void LoadDifficultySelect()
    {
        SceneManager.LoadScene("DifficultySelect");
    }

    //Pause for the fade
    IEnumerator FadePause()
    {
        yield return new WaitForSeconds(5);
    }
}
