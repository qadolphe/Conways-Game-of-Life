/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridBST
{
    private BSTNode root;
    //private int size;

    public GridBST() {
      this.root = null;
      //this.size = 0;
    }

    public GridBST(BSTNode n) {
      this.root = n;
      //this.size = 1;
    }

    public BSTNode insert(BSTNode parent, BSTNode current) { //consider equal F?
      if (this.root == null) {
        this.root = current;
        return this.root;
      } else if (parent == null){
        return current;
      } else if (current.getF() < parent.getF()) {
        parent.setLeft(insert(parent.getLeft(), current));
        return parent;
      } else {
        parent.setRight(insert(parent.getRight(), current));
        return parent;
      }
    }

    public bool contains(BSTNode root, BSTNode key) {
      if (root == null){
        return false;
      }
      if (key.equals(root)){
          return true;
      }
      else if (key.getF() < root.getF()){
          return contains(root.getLeft(), key);
      }
      else {
          return contains(root.getRight(), key);
      }
      return false; //idk if this is needed
      }

    public BSTNode getMin(BSTNode current) {
      if (current.getLeft() == null) {
        return current;
      } else {
        return getMin(current.getLeft());
      }
    }

    public BSTNode getBase() {
      return this.root;
    }

    public BSTNode removeFromSubtree(BSTNode current, BSTNode key) {
      if (current == null){
              Debug.Log("Node does not exist!");
              return null;
          }
          if (key.getF() < current.getF()){
              current.setLeft(removeFromSubtree(current.getLeft(), key));
              return current;
          }
          else if (key.getF() > current.getF()){
              current.setRight(removeFromSubtree(current.getRight(), key));
              return current;
          }
          else {
              if (current.getRight() == null && current.getLeft() == null) {
                  current = null;
                  return null;
              }
              else if (current.getRight() != null && current.getLeft() == null){
                  return current.getRight();
              }
              else if (current.getRight() == null && current.getLeft() != null){
                  return current.getLeft();
              }
              else {
                  BSTNode temp = getMin(current.getRight());
                  current.setRight(removeFromSubtree(current.getRight(), temp));
                  current = temp;
                  return current;
                  //not deleted here because we are replacing the root with the
                  //sucessor and the sucessor gets deleted
              }

          }
    }

    public void buildInOrderTraversal(BSTNode current, List<BSTNode> list) {
      if (current == null){
        Debug.Log("Node dont exist");
        return;
      }
      if (current.getLeft() != null){
          buildInOrderTraversal(current.getLeft(), list);
      }
      list.Add(current);

      if (current.getRight() != null){
          buildInOrderTraversal(current.getRight(), list);
      }
    }
}
*/
