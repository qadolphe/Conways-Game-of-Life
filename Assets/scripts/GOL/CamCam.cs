using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamCam : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 offset;
    public Camera cam;

    // void Start()
    // {
    //
    // }

    // Update is called once per frame
    void Update()
    {
      offset = new Vector3(Grid.width * Grid.cellSize/2, Grid.height * Grid.cellSize/2, -20);
      cam = this.GetComponent<Camera>();
      if (Grid.width * 1080 > Grid.height * 1920) {
        cam.orthographicSize = (int)(Grid.width * Grid.cellSize/3.55);
      } else {
        cam.orthographicSize = Grid.height * Grid.cellSize/2;
      }

      transform.position = offset;
    }
}
