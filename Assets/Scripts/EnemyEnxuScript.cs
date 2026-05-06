using UnityEngine;

public class EnemyEnxuScript : MonoBehaviour
{
    int speed = 1;
    bool facingLeft = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > -5 && facingLeft)
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }

        if (transform.position.x < 4 && !facingLeft)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }

        if(transform.position.x <= -5)
        {
            facingLeft = false;
        }

        if(transform.position.x >= 4)
        {
            facingLeft = true;
        }
    }
}