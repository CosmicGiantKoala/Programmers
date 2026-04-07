using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace CodingTestIDE
{
    public class Exam468371 : Exam
    {
        private List<Signal> _signalList = new List<Signal>();
        
        public override void Run()
        {
            
            List<int[]> signals = new List<int[]>();
            
            for (int a=0; a < 5; a++)
            {
                var input = Console.ReadLine();
                if (input == string.Empty) break;
                var value = input.Split(',');
                signals.Add(new int[3]);
                for (int b = 0; b < value.Length; b++)
                {
                    signals[a][b] = int.Parse(value[b]);
                }
            }
            
            int answer = -1;
            int signalCount = signals.Count;
            int[] signalWeight = new int[signalCount];
            for (int i = 0; i < signalCount; i++)
            {
                signalWeight[i] = signals[i][0] + signals[i][1] + signals[i][2];
                _signalList.Add(new Signal(signals[i][0], signals[i][1], signals[i][2]));
            }
            HashSet<int> distinctSignalWeight = new HashSet<int>(signalWeight);
            bool isSameWeight = distinctSignalWeight.Count == 1;

            int maxLoop = 0;
            if (isSameWeight)
            {
                maxLoop = signalWeight[0];
            }
            else
            {
                maxLoop = distinctSignalWeight.Aggregate((total, value) => total * value);
            }

            for (int i = 1; i < maxLoop; i++)
            {
                var result = true; 
                foreach (var signal in _signalList)
                {
                    var execute = signal.Update();
                    result = result && execute;
                }

                if (result)
                {
                    answer = i;
                    break;
                }
            }
            
            Console.WriteLine(answer);
        }

        private class Signal
        {
            private int _idx =0;
            private int[] _timeTable = new int[3];
            private int _currentSignalTime;
            private int _updateCount;
            private CurrentSignal _currentSignal = CurrentSignal.Green;
            
            public Signal(int g, int y, int r)
            {
                _timeTable[0] = g;
                _timeTable[1] = y;
                _timeTable[2] = r;
                _currentSignalTime = _timeTable[0];
            }

            public bool Update()
            {
                _updateCount++;
                if (_currentSignalTime < _updateCount)
                {
                   _idx++;
                   if (_idx > 2)
                   {
                       _idx = 0;
                   }
                   _currentSignalTime = _timeTable[_idx];
                   _currentSignal= (CurrentSignal)_idx;
                   _updateCount = 1;
                }
                return _currentSignal == CurrentSignal.Yellow;
            }
            
            private enum CurrentSignal
            {
                Green =0,
                Yellow =1,
                Red =2,
            }
        }
    }
}