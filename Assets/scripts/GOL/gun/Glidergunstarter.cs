using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Glidergunstarter : MonoBehaviour
{
    [SerializeField] private GridColors gridColors;
    private gol_data gol;

    private void Start()
    {
      gol = new gol_data(60, 30, 10f); //set font to 10
      gridColors.SetGrid(gol);
      gol.setState(9, 20, 1);
      gol.setState(9, 21, 1);
      gol.setState(10, 20, 1);
      gol.setState(10, 21, 1);

      gol.setState(19, 19, 1);
      gol.setState(19, 20, 1);
      gol.setState(19, 21, 1);
      gol.setState(20, 22, 1);
      gol.setState(20, 18, 1);
      gol.setState(21, 17, 1);
      gol.setState(22, 17, 1);
      gol.setState(21, 23, 1);
      gol.setState(22, 23, 1);

      gol.setState(23, 20, 1);
      gol.setState(24, 22, 1);
      gol.setState(24, 18, 1);
      gol.setState(25, 19, 1);
      gol.setState(25, 20, 1);
      gol.setState(25, 21, 1);
      gol.setState(26, 20, 1);


      gol.setState(29, 21, 1);
      gol.setState(29, 22, 1);
      gol.setState(29, 23, 1);
      gol.setState(30, 21, 1);
      gol.setState(30, 22, 1);
      gol.setState(30, 23, 1);
      gol.setState(31, 24, 1);
      gol.setState(31, 20, 1);

      gol.setState(33, 24, 1);
      gol.setState(33, 20, 1);
      gol.setState(33, 25, 1);
      gol.setState(33, 19, 1);

      gol.setState(43, 23, 1);
      gol.setState(43, 22, 1);
      gol.setState(44, 23, 1);
      gol.setState(44, 22, 1);
    }

    public void oneStep() {
      gol.updateBoard();
    }

    public void clearBoard() {
      gol.clearBoard();
      gol.setState(9, 20, 1);
      gol.setState(9, 21, 1);
      gol.setState(10, 20, 1);
      gol.setState(10, 21, 1);

      gol.setState(19, 19, 1);
      gol.setState(19, 20, 1);
      gol.setState(19, 21, 1);
      gol.setState(20, 22, 1);
      gol.setState(20, 18, 1);
      gol.setState(21, 17, 1);
      gol.setState(22, 17, 1);
      gol.setState(21, 23, 1);
      gol.setState(22, 23, 1);

      gol.setState(23, 20, 1);
      gol.setState(24, 22, 1);
      gol.setState(24, 18, 1);
      gol.setState(25, 19, 1);
      gol.setState(25, 20, 1);
      gol.setState(25, 21, 1);
      gol.setState(26, 20, 1);


      gol.setState(29, 21, 1);
      gol.setState(29, 22, 1);
      gol.setState(29, 23, 1);
      gol.setState(30, 21, 1);
      gol.setState(30, 22, 1);
      gol.setState(30, 23, 1);
      gol.setState(31, 24, 1);
      gol.setState(31, 20, 1);

      gol.setState(33, 24, 1);
      gol.setState(33, 20, 1);
      gol.setState(33, 25, 1);
      gol.setState(33, 19, 1);

      gol.setState(43, 23, 1);
      gol.setState(43, 22, 1);
      gol.setState(44, 23, 1);
      gol.setState(44, 22, 1);
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
