using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cambioEscena : MonoBehaviour
{
   public void cambiarescena(string NombreEscena)
    {
        SceneManager.LoadScene("Concierto_scene");
    }
}
