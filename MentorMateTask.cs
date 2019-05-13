namespace _program
{
    using System;

    public class Program
    {
        public static void Main()
        {			
            int n = int.Parse(Console.ReadLine());
            int outsideDash = n;
	    int topStars = n;
	    int middleDash = n;
			
	//First for loop for drawing the top side of the image. For example if n = 5 this will be the result:
	//-----*****-----*****----------*****-----*****-----
        //----*******---*******--------*******---*******----
        //---*********-*********------*********-*********---
            for (int i = 0; i <= n/2; i++)
            {
				string outDash = new string('-', outsideDash);
				string stars = new string('*', topStars);
				string midDash = new string('-', middleDash);
				
				outsideDash -= 1;
				topStars +=2;
				middleDash -=2;
				
				string row = outDash + stars + midDash + stars + outDash;
				row += row;
				
				Console.WriteLine(row);
				
            }
			
			int nStars = n;
			int downMiddleDash = 1;
			topStars -= 2;
			
	//Second for loop for drawing the bottom side of the image. For example if n = 5 this will be the result:
	//--*****-*********-*****----*****-*********-*****--
        //-*****---*******---*****--*****---*******---*****-
        //*****-----*****-----**********-----*****-----*****
			for (int i = 0; i <= n/2; i++)
            {
				string downOutDash = new String('-', outsideDash);
				string downOutStars = new String('*', nStars);
				string downMidDash = new String('-', downMiddleDash);
				string downMidStars = new String('*', topStars);
				
				outsideDash -=1;
				downMiddleDash +=2;
				topStars -= 2;
				
				string row = downOutDash + downOutStars + downMidDash + downMidStars + downMidDash + downOutStars + downOutDash;
				row += row;
				
				Console.WriteLine(row);
				
			}
			
        }
    }
}
