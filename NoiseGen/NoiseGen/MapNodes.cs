using System;
using System.Collections.Generic;
using System.Drawing;


public class MapNodes
{
    private int nodeSize;
    private int maxSizeXY;
    private Node emptyNode;
    public int width { get; set; }
    public int height { get; set; }
    public Node[] nodeGrid { get; set; }
    public Rectangle[] nodeRect { get; set; }

    public class Node 
    {
        public Rectangle rect{ get; set; }
        public bool isBorder{ get; set; }
        public bool isStart { get; set; }
        public bool isEnd { get; set; }
        public bool isBlocking { get; set; }
        public int index { get; set; }
        public Node parent;
        public bool visited;
        public Node(int x, int y, int w, int h)
        {
            rect = new Rectangle(x,y,w,h);
            isBlocking = false;
            isStart = false;
            isEnd = false;
            isBorder = false;
            visited = false;
        }
    }
    public void ResetNodes()
    {
        for (int i = 0; i < nodeGrid.Length; i++)
        {
            nodeGrid[i].visited = false;
            nodeGrid[i].parent = null;
        }
    }

    public MapNodes(int w, int h, int mXY)
    {
        width = w;
        height = h;

        if (w - h == 0)
        {
            nodeSize = mXY / w;
        }
        else
        {
            nodeSize = mXY / Math.Max(w, h);
        }
        nodeSize = Math.Max(1, nodeSize);
        maxSizeXY = mXY - 2 * nodeSize;
        SetRectangles();
    }

    private void SetRectangles()
    {
        nodeGrid = new Node[width * height];
        nodeRect = new Rectangle[width * height];
        int y = nodeSize * -1; //offset first pass
        int x = nodeSize;
        for (int i = 0; i < width * height; i++)
        {
            if (i % width == 0)
            {
                y += nodeSize;
                x = 0;
            }
            nodeGrid[i] = new Node(x, y, nodeSize, nodeSize);
            nodeGrid[i].index = i;
            nodeRect[i] = nodeGrid[i].rect;

            if (i < width || width * height - i < width + 1 || 
                i % width == 0 || i % width == width - 1)
            {
                nodeGrid[i].isBorder = true;
                nodeGrid[i].isBlocking = true;
            }
            x += nodeSize;
        }
    }

    public Rectangle GetSelectedNode(int x, int y)
    {
        for (int i = 0; i < width * height; i++)
        {
            if (nodeGrid[i].rect.Contains(x, y))
            {
                return nodeGrid[i].rect;
            }
        }
        return new Rectangle();
    }
    public Node GetSelectedNode(Rectangle r)
    {
        for (int i = 0; i < height * width; i++)
        {
            if (r == nodeGrid[i].rect)
            {
                return nodeGrid[i];
            }
        }
        return emptyNode;
    }

    public bool isBorderRectangle(Rectangle r)
    {
        for (int i = 0; i < height * width; i++)
        {
            if (r == nodeGrid[i].rect && nodeGrid[i].isBorder)
            {
                return true;
            }
        }
        return false;
    }
    public bool isBlocking(Rectangle r)
    {
        for (int i = 0; i < height * width; i++)
        {
            if (r == nodeGrid[i].rect && nodeGrid[i].isBlocking)
            {
                return true;
            }
        }
        return false;
    }
}


   