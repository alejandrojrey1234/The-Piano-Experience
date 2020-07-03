using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectScene : MonoBehaviour
{
    public void concierto()
    {
        SceneManager.LoadScene(2);
    }

    public void casa()
    {
        SceneManager.LoadScene(3);
    }

}
