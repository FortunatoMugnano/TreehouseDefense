using System;
using System.Collections.Generic;
using System.Text;

namespace TreehouseTowerDefense
{
    class Invader
    {
        private readonly Path _path;

        private int _pathStep = 0;

        public MapLocation Location => _path.GetLocationAt(_pathStep);

        public int Healt { get; set; } = 2;

        public bool HasScored => _pathStep >= _path.Length;

        public bool IsNeutralized => Healt <= 0;

        public bool IsActive => !(IsNeutralized || HasScored);

        public Invader(Path path)
        {
            _path = path;
        }

        public void Move() => _pathStep += 1;

        public void DecreaseHealt (int factor)
        {
            Healt -= factor;
        }
        
    }
}
