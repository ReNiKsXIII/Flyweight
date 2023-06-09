﻿using System;
using System.Collections.Generic;
using System.Text;

namespace flyweight
{
    public class TreeManager
    {
        private Dictionary<Point, int> _trees = new Dictionary<Point, int>();

        public void AddTree(Point coordinate, int age)
        {
            _trees[coordinate] = age;
        }

        public void DisplayTrees()
        {
            Tree tree = new Tree();
            foreach (Point point in _trees.Keys)
            {
                tree.Display(point.X, point.Y, _trees[point]);
            }
        }
    }
}