using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour {

    public int NumberOfLevels = 2;

    //Load the next level
	public void LoadNextLevel()
    {
        int currLevelIdx = SceneManager.GetActiveScene().buildIndex;
        int nextLevelIdx = (currLevelIdx + 1) % NumberOfLevels;
        SceneManager.LoadScene(nextLevelIdx);
    }

}
