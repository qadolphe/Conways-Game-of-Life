/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeGrid
{
    // Start is called before the first frame update
    private int width;
    private int height;
    private Node[,] board;
    private float cellSize; // probably not good practice to have this static public
    private TextMesh[,] updatetxt;


    public MazeGrid(int width, int height, float cellSize) {
        this.width = width;
        this.height = height;
        this.cellSize = cellSize;

        board = new Node[width, height];
        updatetxt = new TextMesh[width, height];

        for (int x = 0; x < width; x++) {
          for (int y = 0; y < height; y++) {
            board[x,y] = new Node(x,y);
            Debug.DrawLine(GetPosition(x,y), GetPosition(x,y+1), Color.black, 1000f); // draws vertical lines
            //maybe change later to implement my own line functions
            Debug.DrawLine(GetPosition(x,y), GetPosition(x+1,y), Color.black, 1000f); // draws horizontal lines
          }
          Debug.DrawLine(GetPosition(0, height), GetPosition(width, height), Color.black, 1000f); //top-most line
          Debug.DrawLine(GetPosition(width, 0), GetPosition(width, height), Color.black, 1000f); //left-most line
        }
      }

    public MazeGrid(int width, int height, float cellSize, Node start, Node end)
    {
        this.width = width;
        this.height = height;
        this.cellSize = cellSize;

        board = new Node[width, height];
        updatetxt = new TextMesh[width, height];

        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                board[x, y] = new Node(x, y, start, end);
                Debug.DrawLine(GetPosition(x, y), GetPosition(x, y + 1), Color.black, 1000f); // draws vertical lines
                                                                                              //maybe change later to implement my own line functions
                Debug.DrawLine(GetPosition(x, y), GetPosition(x + 1, y), Color.black, 1000f); // draws horizontal lines
            }
            Debug.DrawLine(GetPosition(0, height), GetPosition(width, height), Color.black, 1000f); //top-most line
            Debug.DrawLine(GetPosition(width, 0), GetPosition(width, height), Color.black, 1000f); //left-most line
        }
    }

    public Vector3 GetPosition(int x, int y) {
        return new Vector3(x, y) * cellSize;
      }

      public Node getNode(int x, int y) {
        return board[x,y];
      }

      public List<Node> getNeighbors(Node n) {
        List<Node> neighbors = new List<Node>();
        int x = n.getX();
        int y = n.getY();

        if (y>0){
          if (!board[x, y-1].isWall()) {
            neighbors.Add(board[x, y-1]);
          }
          if (x>0 && !board[x-1, y-1].isWall()){
            neighbors.Add(board[x-1, y-1]);
          }
          if (x<this.width - 1 && !board[x+1, y-1].isWall()){
            neighbors.Add(board[x+1, y-1]);
          }
        }
        if (x>0){
          if (!board[x-1, y].isWall()) {
            neighbors.Add(board[x-1, y]);
          }
          if (y<this.height - 1 && !board[x-1, y+1].isWall()){
            neighbors.Add(board[x-1, y+1]);
          }
        }

        if (y<this.height - 1){
          if (!board[x, y+1].isWall()){
            neighbors.Add(board[x, y+1]);
          }
          if (x<this.width - 1 && !board[x+1, y+1].isWall()){
            neighbors.Add(board[x+1, y+1]);
          }
        }
        if (x<this.width - 1){
          if (!board[x+1, y].isWall()){
            neighbors.Add(board[x+1, y]);
          }
        }

        return neighbors;
      }
}
*/
