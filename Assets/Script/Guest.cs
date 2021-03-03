using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Guest : MonoBehaviour
{
    public void LoadingNewScene()
    {
        SceneManager.LoadScene("PreparationGuest");
    }
}
