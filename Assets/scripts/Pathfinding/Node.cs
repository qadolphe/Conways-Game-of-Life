/*using System.Collections;
using System;

public class Node
{
    private int G; //distance from start GridNodes
    private int H; //distance to end node
    private int F; //G + H
    private int blocked; // 1 if blocked, 0 if not.

    private int x;
    private int y;
    private Node prev; //previos node in search
    private Node start;
    private Node end;

    private Node BSTl; //left child in BST
    private Node BSTr;

    public Node(int x, int y)
    {
        this.blocked = 0;
        this.x = x;
        this.y = y;
    }

    public void setPrev(Node n)
    {
        this.prev = n;
    }

    public Node getPrev()
    {
        return this.prev;
    }

    public int getX()
    {
        return this.x;
    }

    public int getY()
    {
        return this.y;
    }

    public Node getLeft()
    {
        return this.left;
    }

    public Node getRight()
    {
        return this.right;
    }

    public void setLeft(Node n)
    {
        this.left = n;
    }

    public void setRight(Node n)
    {
        this.right = n;
    }

    private int getLocalDist(Node n)
    {
        int nx = n.getX();
        int ny = n.getY();
        int dx = Mathf.Abs(nx - this.x);
        int dy = Mathf.Abs(ny - this.y);

        if (dx == dy)
        {
            return 14;
        }
        return 10;
    }

    public int calcG(Node n)
    {
        this.start = n;

        if (this.equals(n))
        {
            return 0;
        }
        else
        {
            if (this.prev == null)
            {
                this.prev = this.start;
            }
            this.G = getLocalDist(this.prev) + this.prev.calcG(n);
            return this.G;
        }
    }

    public int calcH(Node n)
    {
        this.end = n;
        int nx = n.getX();
        int ny = n.getY();
        int dx = Mathf.Abs(nx - this.x);
        int dy = Mathf.Abs(ny - this.y);
        int diag;

        if (dx > dy)
        {
            diag = dy * 14;
            this.H = diag + (dx - dy) * 10;
        }
        else
        {
            diag = dx * 14;
            this.H = diag + (dy - dx) * 10;
        }
        return this.H;
    }

    public int getF(Node start, Node end)
    {
        this.F = calcG(start) + calcH(end);
        return this.F;
    }

    public bool isWall()
    {
        return Convert.ToBoolean(this.blocked);
    }

    public bool equals(Node n)
    {
        if (n == null)
        {
            return false;
        }
        if (n.getX() == this.x && n.getY() == this.y)
        {
            return true;
        }
        return false;
    }

    public string toString()
    {
        return "(" + this.x + ", " + this.y + ")";
    }
}*/
