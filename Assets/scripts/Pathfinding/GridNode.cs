/*  using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GridNode
{
    private int G; //distance from start GridNodes
    private int H; //distance to end node
    private int F; //G + H
    private int blocked; // 1 if blocked, 0 if not.
    private int x;
    private int y;
    private GridNode prev; //previos node in search
    private BSTNode node;
    private GridNode start;
    private GridNode end;

    public GridNode(int x, int y) {
      this.blocked = 0;
      this.x = x;
      this.y = y;
      this.node = new BSTNode(x,y, this);
      this.start = null;
      this.end = null;
    }

    public GridNode(int x, int y, GridNode start, GridNode end) {
      this.blocked = 0;
      this.x = x;
      this.y = y;
      this.node = new BSTNode(x,y, this);
      this.start = start;
      this.end = end;
    }

    public int getX() {
      return this.x;
    }

    public int getY() {
      return this.y;
    }

    public void setX(int x) {
      this.x = x;
    }

    public void setY(int y) {
      this.y = y;
    }

    public int getG() {
      return this.G;
    }

    public int getH() {
      return this.H;
    }

    public bool isWall() {
      return Convert.ToBoolean(this.blocked);
    }

    // public GridNode getLeft() {
    //   return this.leftc;
    // }
    //
    // public GridNode getRight() {
    //   return this.rightc;
    // }

    public int getF() {
      if (end == null) {
        this.F = this.G + this.H;
        this.node.setF(this.F);
        return this.F;
      }
      this.F = calcG(this.start) + calcH(this.end);
      this.node.setF(this.F);
      return this.F;
    }

    public int getF(GridNode start, GridNode end) {
      calcG(start);
      calcH(end);
      return getF();
    }

    public void setPrev(GridNode n) {
        this.prev = n;
    }

    public GridNode getPrev() {
      return this.prev;
    }

    public BSTNode getNode() {
      if (this.node == null) {
        this.node = new BSTNode(this.x,this.y, this);
        getF();
      }
      return this.node;
    }

    // public void setLeft(GridNode n) {
    //   this.leftc = n;
    // }
    //
    // public void setRight(GridNode n) {
    //   this.rightc = n;
    // }

    public int calcH(GridNode n) {
        this.end = n;
      int nx = n.getX();
      int ny = n.getY();
      int dx = Mathf.Abs(nx - this.x);
      int dy = Mathf.Abs(ny - this.y);
      int diag;

      if (dx > dy) {
        diag = dy * 14;
        this.H = diag + (dx - dy) * 10;
      } else {
        diag = dx * 14;
        this.H = diag + (dy - dx) * 10;
      }
      return this.H;
    }

    public int calcG(GridNode n) {
        this.start = n;

      if (this.equals(n)) {
        return 0;
      } else {
        if (this.prev == null)
            {
                this.prev = this.start;
            }
        this.G = getLocalDist(this.prev) + this.prev.calcG(n);
        return this.G;
      }
    }


    private int getLocalDist(GridNode n) {
      int nx = n.getX();
      int ny = n.getY();
      int dx = Mathf.Abs(nx - this.x);
      int dy = Mathf.Abs(ny - this.y);

      if (dx == dy) {
        return 14;
      }
      return 10;
    }

    public bool equals(GridNode n) {
      if (n == null) {
        return false;
      }
      if (n.getX()==this.x && n.getY()==this.y) {
        return true;
      }
      return false;
    }

    public string toString() {
      return "(" + this.x + ", " + this.y + ")";
    }
}
*/
