using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Agreement : MonoBehaviour
{
    public void NextScene()
    {
        SceneManager.LoadScene(2);
    }

    public void BackScene()
    {
        Debug.Log("cojest");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
