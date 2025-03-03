using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Flag : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Player wins!");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
