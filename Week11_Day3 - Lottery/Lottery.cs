using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week11_Day3_3___Lottery
{
    internal class Lottery
    {
        int[] _ballsDrawn;
        int _lastBallDrawnIndex;
        List<int> _possibleNumbers;
        Random _random;

        public Lottery(int maxValue, int nrOfWantedBalls)
        {
            _ballsDrawn = new int[nrOfWantedBalls];
            _lastBallDrawnIndex = 0;
            _possibleNumbers = new List<int>();
            for (int i = 1;i<=maxValue; i++)
            {
                _possibleNumbers.Add(i);
            }
            _random = new Random();
        }

        public int DrawNextNumber()
        {
            //numbers must be unique aka cant be equal to previously drawn numbers
            int newDraw = _possibleNumbers[_random.Next(_possibleNumbers.Count)];
            _possibleNumbers.Remove(newDraw);
            _ballsDrawn[_lastBallDrawnIndex] = newDraw;
            _lastBallDrawnIndex++;
            return newDraw;
        }

        public int[] DrawAllNumbers()
        {
            //numbers must be unique aka cant be equal to previously drawn numbers
            while (_ballsDrawn.Contains(0))
            {
                _ = DrawNextNumber();
            }
            return _ballsDrawn;
        }

        public bool IsLotteryFinished()
        {
            if (_ballsDrawn.Last() != 0)
            {
                return true;
            }
            return false;
        }

        public int[] GetPreviousDraws()
        {
            return _ballsDrawn;
        }
    }
}
