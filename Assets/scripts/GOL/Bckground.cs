using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bckground : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 offset;
    public Sprite square;
    public float scale;

    // Update is called once per frame
    void Update()
    {
      offset = new Vector3(Grid.width * Grid.cellSize/2, Grid.height * Grid.cellSize/2, 432);
      square = this.GetComponent<Sprite>();
      //transform.localScale = new Vector3(1, 1, 0);
      transform.localScale = new Vector3(Grid.width * Grid.cellSize * (float)1.55, Grid.height * Grid.cellSize*scale * (float)1.55, 1);
      transform.position = offset;
    }
}
