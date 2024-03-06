using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10_Day3_3
{
    internal class Car
    {
        private string _brand;
        private int _maxSpeed;
        private int _currentSpeed;

        public Car(string brand, int maxSpeed)
        {
            this._brand = brand;
            this._maxSpeed = maxSpeed;
            this._currentSpeed = 0;
        }

        public void SpeedChange(int speedChange)
        {
            _currentSpeed += speedChange;
            if (_currentSpeed>_maxSpeed) { _currentSpeed = _maxSpeed; }
            else if (_currentSpeed<0) { _currentSpeed = 0; }
        }

        public int CurrentSpeed()
        { return _currentSpeed; }

        public int MaxSpeed()
        { return _maxSpeed;}

        public string Brand()
        { return _brand; }

        public override string ToString()
        {
            return $"Brand: {this._brand}\r\nMax Speed: {this._maxSpeed} km/h";
        }

    }
}
