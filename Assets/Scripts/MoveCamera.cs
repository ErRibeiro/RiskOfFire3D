using UnityEngine;

public class MoveCamera : MonoBehaviour {

    public Transform player;
    //keeps the camera as a first person camera. all it is doing is following the player's position
    void Update() {
        transform.position = player.transform.position;
    }
}
