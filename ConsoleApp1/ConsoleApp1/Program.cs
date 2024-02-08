using System;
using System.Linq;
using System.Collections.Generic;
using System.Xml.Schema;

/// <summary>
/// we want to compare arr[0] with arr[1] and send smaller number to back
/// </summary>
public class Solution
{
    public int MaxProfit(int[] prices)
    {
        //input: [7, 1, 4, 3, 6, 3]
        int max = 0;
        int min = prices[0];

        for (int i = 0; i < prices.Length; i++)
        {
            if (prices[i] < min)
            {
                min = prices[i];
            }
            else if (prices[i] - min > max)
            {
                max = prices[i] - min;
            }
        }

        return max;
    }
    
    public int[] ProductExceptSelf(int[] nums) {
        for (int i = 0; i < nums.Length; i++)
        {
            
        }
    }
}

//thoughts
//iterate through array 
//compare first value to 2nd value - is 2nd value lower than first? if yes then we set that as our lowest variable
//carry on through the array and minus this number from every value after this number and find the largest from that

//or
//iterate through, take away every number after the value we are currently on, find largest difference 