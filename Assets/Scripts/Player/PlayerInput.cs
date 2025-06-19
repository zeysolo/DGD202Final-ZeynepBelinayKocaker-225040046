using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    PlayerMover playerMover;

    float horizontal;
    float vertical;
    void Start()
    {
        playerMover = GetComponent<PlayerMover>();  
    }

    // Update is called once per frame
    void Update()
    {
        horizontal= Input.GetAxis("Horizontal");
        vertical= Input.GetAxis("Vertical");

        Vector2 input = new Vector2(horizontal, vertical);  
        playerMover.Move(input);
    }
}
