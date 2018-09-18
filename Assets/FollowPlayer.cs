using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    public Transform player;

    public Vector3 offset;

	// Update is called once per frame
	void Update () {
        //NOTE: This 'transform' is the Transform of THIS game object! :D
        transform.position = player.position + offset;
	}
}
