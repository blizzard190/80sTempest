using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Restart : MonoBehaviour
{
    public GameObject canvas;

    private void Start()
    {
        canvas.SetActive(false);
    }

    public void Activate()
    {
        canvas.SetActive(true);
    }

    public void Retry()
    {
        SceneManager.LoadScene("Game");
    }
}
