using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Gliderstart : MonoBehaviour
{
    [SerializeField] private GridColors gridColors;
    private gol_data gol;

    private void Start()
    {
      gol = new gol_data(20, 20, 10f); //set font to 10
      gridColors.SetGrid(gol);
      gol.setState(2, 15, 1);
      gol.setState(3, 15, 1);
      gol.setState(4, 15, 1);
      gol.setState(3, 17, 1);
      gol.setState(4, 16, 1);

    }

    public void oneStep() {
      gol.updateBoard();
    }

    public void clearBoard() {
      gol.clearBoard();
      gol.setState(2, 15, 1);
      gol.setState(3, 15, 1);
      gol.setState(4, 15, 1);
      gol.setState(3, 17, 1);
      gol.setState(4, 16, 1);
    }

    // Update is called once per frame
    private void Update() {
      if (Input.GetMouseButtonDown(0)) {
        Vector3 pos3d = GetMousePosition();
        int x = (int)pos3d.x;
        int y = (int)pos3d.y;
        Grid.getCoords(ref x,ref y);
        int current = gol.getState(x,y);
        gol.setState(x,y, 1 - current);
      }

      if (Input.GetKeyDown("space")) {
        StartCoroutine(gol.play_gol());
      }
    }

    private Vector3 GetMousePosition() {
      Vector3 mouse = Input.mousePosition;
      Camera cam = Camera.main;
      Vector3 vec = cam.ScreenToWorldPoint(mouse);

      return vec;
    }
}
