using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FreePlay : MonoBehaviour
{
    [SerializeField] private string thing = "FreePlay";
    public void enterFreePlay() {
      SceneManager.LoadScene(thing);
    }


}
