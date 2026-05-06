using UnityEngine;

public class HealthPackRafiqa : MonoBehaviour
{

    public GameManager gameManager;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameManager = FindFirstObjectByType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
           gameManager.Heal();
           Debug.Log("You found a heart pack! You regained 1 heart.");
        }
    }
}
