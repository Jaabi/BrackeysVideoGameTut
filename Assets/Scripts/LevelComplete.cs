using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour {

    //Load the next level
	public void LoadNextLevel()
    {
        int currLevelIdx = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currLevelIdx + 1);
    }

}
