using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelection : MonoBehaviour
{
	public GameObject[] characters;
	public int selectedCharacter;

	void Start(){
		PlayerPrefs.GetInt ("NewColor");
		//selectedCharacter = PlayerPrefs.GetInt("selectedCharacter");
	}

	void Update() {
		//PlayerPrefs.SetInt("selectedCharacter", selectedCharacter);
	}

	public void NextCharacter()
	{
		characters[selectedCharacter].SetActive(false);
		selectedCharacter = (selectedCharacter + 1) % characters.Length;
		characters[selectedCharacter].SetActive(true);
		//PlayerPrefs.SetInt("selectedCharacter", selectedCharacter);
	}

	public void PreviousCharacter()
	{
		characters[selectedCharacter].SetActive(false);
		selectedCharacter--;
		if (selectedCharacter < 0)
		{
			selectedCharacter += characters.Length;
		}
		characters[selectedCharacter].SetActive(true);
		//PlayerPrefs.SetInt("selectedCharacter", selectedCharacter);
	}

	public void StartGame()
	{
		PlayerPrefs.SetInt("selectedCharacter", selectedCharacter);
		Application.LoadLevel("Menu");
		//SceneManager.LoadScene(1, LoadSceneMode.Single);
	}

	
}
