using UnityEngine;

public class EndTrigger : MonoBehaviour {

    public GameManager gameManager;

    //Detect collision on the trigger
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            gameManager.CompleteLevel();
        }
    }

}
