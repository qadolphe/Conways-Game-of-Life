/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tester : MonoBehaviour
{
    private MazeGrid maze;
    private Node current;
    private Node past;
    void Start()
    {

        Node start = new Node(4,2);
        Node end = new Node(1,5);
        int tempint;

        maze = new MazeGrid(10, 10, 10, start, end);



        GridBST grod = new GridBST();
        List<Node> check = new List<Node>(); //slow but works for now



        List<Node> neighbors = maze.getNeighbors(start);
        BSTNode root = neighbors[0].getNode();
        current = start;
        List<BSTNode> print = new List<BSTNode>();

        //while (!end.equals(current)) {
        for (int i = 0; i < 2; i++) {
          foreach (Node node in neighbors) {
            tempint = node.getF();
            node.setPrev(current);
            if (node.getF() > tempint)
                {
                    node.setPrev(past);
                }
            node.getF(start, end);
            //Debug.Log("Node: " + node.toString() + " , F: " + node.getF(start, end));
            if (grod.contains(root, node.getNode())) {
              grod.removeFromSubtree(root, node.getNode());
              grod.insert(root, node.getNode());
            } else {
              grod.insert(root, node.getNode());
            }
          }
            past = current;
            current = null;
          while (current == null) {
            current = grod.getMin(root).getGrid();
            if (check.Contains(current)) {
              grod.removeFromSubtree(root, current.getNode());
              current = null;
            } else {
              check.Add(current);
            }
          }

          Debug.Log("Continsy: " + grod.contains(root,current.getNode()));
          if (current.equals(root.getGrid())) {
            root = current.getNode();
          }
          grod.removeFromSubtree(root, current.getNode());

          Debug.Log("BST Min: " + current.toString());
          Debug.Log("Continsn: " + grod.contains(root,current.getNode()));

          neighbors = maze.getNeighbors(current);

          grod.buildInOrderTraversal(root, print);

          Debug.Log("In check: ");
          foreach (Node p in check) {
            Debug.Log("Node: " + p.toString());
          }
        }





    }

    // Update is called once per frame
    void Update()
    {

    }
}
*/
