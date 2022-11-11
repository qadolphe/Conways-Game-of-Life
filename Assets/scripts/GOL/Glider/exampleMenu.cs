using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class exampleMenu : MonoBehaviour
{
  [SerializeField] private string thing = "GOLexamplemenu";
  public void toExampleMenu() {
    SceneManager.LoadScene(thing);
  }
}
