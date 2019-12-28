using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntcodeComputer
{
    class Operations
    {
        public void Add(ref int[] input, int[] opcode)
        {
            //Map the instruction to variables
            int pos1 = opcode[0];
            int pos2 = opcode[1];
            int storagePos = opcode[2];

            //Sum both integers
            int addedNumber = input[pos1] + input[pos2];

            //Replace the added number in its position
            input[storagePos] = addedNumber;
        }

        public void Multiply(ref int[] input, int[] opcode)
        {
            //Map the instruction to variables
            int pos1 = opcode[0];
            int pos2 = opcode[1];
            int storagePos = opcode[2];

            //Multiply both integers
            int multipliedNumber = input[pos1] + input[pos2];

            //Replace the added number in its position
            input[storagePos] = multipliedNumber;
        }
    }
}
