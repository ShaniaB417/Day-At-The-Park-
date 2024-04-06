using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trashcan : MonoBehaviour
{
    public int scoreValue = 10; // Score value when trash is placed in the trashcan

    private void OnTriggerEnter(Collider other)
    {
        // Check if the collided object has the "Trash" tag
        if (other.CompareTag("Trash"))
        {
            // Increase score
            GameManager.instance.AddScore(scoreValue);

            // Optionally, you can destroy the trash object when it's placed in the trashcan
            Destroy(other.gameObject);
        }
    }
}
