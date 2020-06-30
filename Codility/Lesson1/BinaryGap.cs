using System;

namespace Codility.Lesson1
{
    public class BinaryGap
    {
        public int solution(int N)
        {
            int currentGap = 0;
            int longestGap = 0;

            string stringBinaryRepresentation = Convert.ToString(N, 2);

            for (int i = 0; i < stringBinaryRepresentation.Length; i++)
            {
                if (stringBinaryRepresentation[i] == '0')
                {
                    currentGap += 1;
                }
                else
                {
                    if (currentGap > longestGap)
                    {
                        longestGap = currentGap; 
                    }
                    currentGap = 0;
                }
            }

            return longestGap;
        }
    }
}
