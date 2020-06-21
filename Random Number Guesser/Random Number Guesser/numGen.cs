using System;
using System.Collections.Generic;
using System.Text;

namespace Random_Number_Guesser
{
    class numGen
    {
        //in this class the random number will actually be selected 
        int lowerValue = 1;//what the lowest random number selected could be
        int upperValue = 10; //the highest random number that could be selected
        Random randNum = new Random();
        public int getLowerValue
        {
            get => lowerValue;
            //to get read acces for the lower value
            
        }
        public int setLowerValue
        {
            set => lowerValue = value;
            //to get write access for the lower value
        }

        public int randomNumberSelect(int lowBand, int highBand)
        {
            int num = randNum.Next(lowBand, highBand);

            return num;
        }
        
    }

    
}
