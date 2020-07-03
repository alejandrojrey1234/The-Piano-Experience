using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_selector : MonoBehaviour
{
    public void Cargar_Concierto()
    {
        SceneManager.LoadScene(2);
    }

    public void Cargar_Casa()
    {
        SceneManager.LoadScene(3);
    }
}
