using System;

namespace AdvancedConceptsMosh
{
    public struct NewStruct
    {
        private int _number;
        public int publicNumber { get { return _number; } 
                                  set { _number = value; } 
                                }

        public void ShowNumber()
        {
            Console.WriteLine($"{_number}");
        }
    }
}
