using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoiseGen
{
    public class PathFind
    {
        private MapNodes mapNodes;
        private List<MapNodes.Node> nodeList;
        private Queue<MapNodes.Node> queueNodes;
        private Rectangle start;

        public PathFind(MapNodes m, Rectangle s)
        {
            nodeList = new List<MapNodes.Node>();
            mapNodes = m;
            start = s;
        }

        public List<MapNodes.Node> FindBFSPath()
        {
            mapNodes.ResetNodes();
            queueNodes = new Queue<MapNodes.Node>();
            queueNodes.Enqueue(mapNodes.GetSelectedNode(start));
            while (queueNodes.Count > 0)
            {
                MapNodes.Node next = queueNodes.Peek();
                if (next.isEnd)
                {
                    while (next != mapNodes.GetSelectedNode(start))
                    {
                        nodeList.Add(next);
                        next = next.parent;
                    }
                    return nodeList;
                }
                else 
                {
                    if (isEligibleNode(next.index + 1))
                    {
                        QPush(next.index + 1, next);
                    }
                    if (isEligibleNode(next.index - 1))
                    {
                        QPush(next.index - 1, next);
                    }
                    if (isEligibleNode(next.index - mapNodes.width))
                    {
                        QPush(next.index - mapNodes.width, next);
                    }
                    if (isEligibleNode(next.index + mapNodes.width))
                    {
                        QPush(next.index + mapNodes.width, next);
                    }

                }
                queueNodes.Dequeue();
            }
            return null;
        }

        private void QPush(int i, MapNodes.Node n)
        {
            mapNodes.nodeGrid[i].parent = n;
            mapNodes.nodeGrid[i].visited = true;
            queueNodes.Enqueue(mapNodes.nodeGrid[i]);
        }


        public bool isEligibleNode(int n)
        {
            if (!mapNodes.nodeGrid[n].isBorder || !mapNodes.nodeGrid[n].isBlocking || !!mapNodes.nodeGrid[n].visited)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



    }

}
