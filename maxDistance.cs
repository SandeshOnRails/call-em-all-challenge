using System;

class MaxDistance {
	  
    
    public int getMaxDistance (char[] letters) {


        if(letters == null) {

            return 0;
        }
           
        if (letters.Length < 2) {
            return 0;
        }

        int min_value = int.MaxValue;

        int result = 0;

        for (int i =0; i < letters.Length; i++) {

          if (isCharValid(letters[i])) {

            result = Math.Max(result, (int)char.ToLower(letters[i]) - min_value-1);
            min_value = Math.Min(min_value, (int)char.ToLower(letters[i]));

            }

        }


        return result;

    }


    public bool isCharValid(char c) {

          c = char.ToLower(c);

          if ((int)c >= 97 && (int)c <= 122) {
             return true;
           }

          return false;
    }


	  static void Main () {

	    char[] test1 = {'g', 'b', 'c','j', 'b', 'd', 'h', 'a' };
      char[] test2 = {'z', 'x', 'y'};
      char[] test3 = {};
      char[] test4 = {'x', 'z'};
      char[] test5 = {'x', '@', 'z'};
      char[] test6 = null;
      char[] test7 = {'g', 'B', 'c','J', 'B', 'd', 'h', 'a' };
      char[] test8 = {'z', 'b', 'c', 'a', 'd'};


	  MaxDistance maxDist = new MaxDistance();

	  Console.WriteLine(maxDist.getMaxDistance(test1));
	  Console.WriteLine(maxDist.getMaxDistance(test2));
	  Console.WriteLine(maxDist.getMaxDistance(test3));
	  Console.WriteLine(maxDist.getMaxDistance(test4));
	  Console.WriteLine(maxDist.getMaxDistance(test5));
    Console.WriteLine(maxDist.getMaxDistance(test6));
    Console.WriteLine(maxDist.getMaxDistance(test7));
    Console.WriteLine(maxDist.getMaxDistance(test8));







	  }


}