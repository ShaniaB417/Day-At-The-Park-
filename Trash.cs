using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trash : MonoBehaviour
{
    private bool isInsideTrashcan = false;
    private float timer = 0f;
    public float maxTimeInsideTrashcan = 5f; // Maximum time allowed inside the trashcan

    private void Update()
    {
        if (isInsideTrashcan)
        {
            timer += Time.deltaTime;
            if (timer >= maxTimeInsideTrashcan)
            {
                // Trash has been inside the trashcan for too long
                GameManager.instance.ResetTimerAndScore();
                Destroy(gameObject); // Destroy the trash object
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Trashcan"))
        {
            isInsideTrashcan = true;
            timer = 0f; // Reset the timer when entering the trashcan
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Trashcan"))
        {
            isInsideTrashcan = false;
            timer = 0f; // Reset the timer when leaving the trashcan
        }
    }
}
