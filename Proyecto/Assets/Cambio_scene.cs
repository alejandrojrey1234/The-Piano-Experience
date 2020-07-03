using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cambio_scene : MonoBehaviour
{

public void PlayGame(string NombreEscena)
    {
        SceneManager.LoadScene("Concierto_scene");
    }
}
