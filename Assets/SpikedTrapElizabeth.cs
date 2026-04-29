using UnityEngine;

public class SpikedTrapElizabeth : MonoBehaviour
{
    public GameManager gameManager;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameManager = gameObject.GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            gameManager.LoseLife();
            Debug.Log("oUCH");
        }
    }




}
