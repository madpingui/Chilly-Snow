using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    private float score;
    public Text scoreText;
    public float movementSpeed;

    private float rotationSpeed;
    private bool movingLeft;

    private void Start()
    {
        movingLeft = true;
        score = 0;
    }

    private void Update()
    {
        score += Time.deltaTime;
        scoreText.text = score.ToString("0");
        transform.Translate(Vector3.down * Time.deltaTime * movementSpeed);

        if (Input.GetMouseButtonDown(0))
        {
            rotationSpeed = 0.1f;
            movingLeft = !movingLeft;
        }

        if (Input.GetMouseButton(0))
        {
            rotationSpeed += 0.5f * Time.deltaTime;
        }

        if (movingLeft)
        {
            transform.Rotate(0, 0, rotationSpeed);
        }
        else
        {
            transform.Rotate(0, 0, -rotationSpeed);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Obstacle")
        {
            Die();
        }
    }
    
    void Die()
    {
        print("Dead");
        Destroy(gameObject);
    }
}
