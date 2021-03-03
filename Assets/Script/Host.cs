using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Host : MonoBehaviour
{
    public void LoadingNewScene()
    {
        SceneManager.LoadScene("PreparationHost");
    }
}
