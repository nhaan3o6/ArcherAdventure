﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLevel : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Invoke("CompleteLevel", 0f);
        }
    }
    private void CompleteLevel()
    {
        int curScene = SceneManager.GetActiveScene().buildIndex;
        curScene++;
        SceneManager.LoadScene(curScene);
    }
}
