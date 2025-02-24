using System.Collections.Generic;

public class Solution {
    public int RomanToInt(string s) {
        Dictionary<char,int> roman = new Dictionary<char,int>()
        {
            {'I',1},{'V',5},{'X',10},{'L',50}, {'C',100}, {'D',500},{'M',1000}
        };
        int accumulator = 0;
        int prevValue = 0;
        int currentValue;

        for(int i=s.Length-1;i>=0;i--){
            currentValue = roman[s[i]];
            if(currentValue >= prevValue){
                accumulator += currentValue;
            }
            else{
                accumulator -= currentValue;
            }
            prevValue = currentValue;
        }
        return accumulator;
    }
}
