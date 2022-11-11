using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toGun : MonoBehaviour
{
  [SerializeField] private string thing = "GliderGun";
  public void goToGun() {
    SceneManager.LoadScene(thing);
  }
}
