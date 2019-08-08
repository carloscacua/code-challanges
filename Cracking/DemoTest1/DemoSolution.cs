// IMPORT LIBRARY PACKAGES NEEDED BY YOUR PROGRAM
// SOME CLASSES WITHIN A PACKAGE MAY BE RESTRICTED
// DEFINE ANY CLASS AND METHOD NEEDED
// CLASS BEGINS, THIS CLASS IS REQUIRED
using System;
using System.Collections.Generic;
public class DemoSolution
{
  //METHOD SIGNATURE BEGINS, THIS METHOD IS REQUIRED
    public int[] cellCompete(int[] states, int days)
    {
        var aux = new int[states.Length];

        aux = (int[])states.Clone();
        for (var i = 0; i < days; i++) 
        {
            states = (int[])aux.Clone();
            for(int j = 0; j < aux.Length; j++) 
            {
                aux[j] =  (j > 0 ? states[j - 1] : 0) == (j < states.Length - 1 ? states[j + 1] : 0)?0:1;
            }

        }
        return aux;

    }
  // METHOD SIGNATURE ENDS
}
