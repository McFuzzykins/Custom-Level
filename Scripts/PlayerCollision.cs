using UnityEngine;
using TMPro;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    private InputHandler _input;
    private TextMeshProUGUI text;
    public GameObject hidden;

    void Start()
    {
        _input = FindObjectOfType<InputHandler>();
        text = GetComponentInChildren<TextMeshProUGUI>();
        text.text = "Jumps: " + movement.amountOfJumps;
    }

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "jump")
        {
            movement.jumpPill = true;
            ++movement.amountOfJumps;
        }
    }
    
    void OnTriggerEnter()
    {
        if (hidden.active == false)
        {
            hidden.SetActive(true);
        }
        else
        {
            hidden.GetComponentInChildren<MeshRenderer>().enabled = false;
        }
    }

    void Update()
    {
        text.text = "Jumps: " + movement.amountOfJumps;
    }
}
