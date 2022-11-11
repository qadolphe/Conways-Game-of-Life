using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toMenu : MonoBehaviour
{
  [SerializeField] private string thing = "Menu";
  public void goToMenu() {
    SceneManager.LoadScene(thing);
  }
}
