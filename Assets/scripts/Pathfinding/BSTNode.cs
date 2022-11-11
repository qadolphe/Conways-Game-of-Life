/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BSTNode
{
    private int F; //G + H
    private int x;
    private int y;
    private BSTNode left; //left child in BST
    private BSTNode right;
    private GridNode g;


    public BSTNode(int x, int y, GridNode n) {
      this.x = x;
      this.y = y;
      this.left = null;
      this.right = null;
      this.g = n;
    }
    public BSTNode getLeft() {
      return this.left;
    }

    public BSTNode getRight() {
      return this.right;
    }

    public void setLeft(BSTNode n) {
      this.left = n;
    }

    public void setRight(BSTNode n) {
      this.right = n;
    }

    public void setF(int n) {
      this.F = n;
    }

    public int getF() {
      return this.F;
    }

    public int getX() {
      return this.x;
    }

    public int getY() {
      return this.y;
    }

    public bool equals(BSTNode n) {
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

    public GridNode getGrid() {
      return this.g;
    }


}
*/
