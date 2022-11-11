using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toGlider : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private string thing = "Glider";
    public void goToGlider() {
      SceneManager.LoadScene(thing);
    }
}
