using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using CodeMonkey.Utils;


public class Grid
{
    public static int width;
    public static int height;
    private int[,,] board;
    public static float cellSize; // probably not good practice to have this static public
    private TextMesh[,] updatetxt;


    public Grid(int width, int height, float cellSize, int sortingOrder) {
        Grid.width = width;
        Grid.height = height;
        Grid.cellSize = cellSize;

        board = new int[width, height,2];
        updatetxt = new TextMesh[width, height];

        for (int x = 0; x < width; x++) {
          for (int y = 0; y < height; y++) {


            Debug.DrawLine(GetPosition(x,y), GetPosition(x,y+1), Color.black, 1000f); // draws vertical lines
            //maybe change later to implement my own line functions
            Debug.DrawLine(GetPosition(x,y), GetPosition(x+1,y), Color.black, 1000f); // draws horizontal lines
          }
          Debug.DrawLine(GetPosition(0, height), GetPosition(width, height), Color.black, 1000f); //top-most line
          Debug.DrawLine(GetPosition(width, 0), GetPosition(width, height), Color.black, 1000f); //left-most line
        }


    }

    public int getState(int x, int y) {
      if (x>=0 && y >=0 && x < width && y < height) {
        return board[x,y,0];
      }
      return -1;
    }

    public void setState(int x, int y, int state) {
      if (x>=0 && y >=0 && x < width && y < height) {
        board[x,y,0] = state;
        //updatetxt[x,y].text = board[x,y,0].ToString();

      }
    }

    public void setSortingOrder(int x, int y, int sortingOrder) {
      if (x>=0 && y >=0 && x < width && y < height) {
        board[x,y,1] = sortingOrder;
        //updatetxt[x,y].GetComponent<MeshRenderer>().sortingOrder = sortingOrder;
      }
    }

    public static void getCoords(ref int x, ref int y) {

      x = x / (int)cellSize;
      y = y / (int)cellSize;
    }

    public Vector3 GetPosition(int x, int y) {
      return new Vector3(x, y) * cellSize;
    }

    private TextMesh CreateText(string text, Transform parent, Vector3 localPos,
                 int fontS, Color color, TextAnchor textAn, TextAlignment textAl,
                 int sortingOrder) {
        GameObject go = new GameObject("Griddy", typeof(TextMesh));
        Transform transform = go.transform;
        transform.SetParent(parent, false);
        transform.localPosition = localPos;
        TextMesh txm = go.GetComponent<TextMesh>(); //dont think i need most stuff below
        txm.anchor = textAn;
        txm.alignment = textAl;
        txm.text = text;
        txm.fontSize = fontS;
        txm.color = color;
        txm.GetComponent<MeshRenderer>().sortingOrder = sortingOrder;
        return txm;
    }
}
