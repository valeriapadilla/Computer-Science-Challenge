using System.Collections.Generic;

public class Solution {
    public int LongestValidParentheses(string s) {
        int sum = 0;
        Stack<int> indexValid = new Stack<int>();
        int indexInvalid = -1;

        for(int i=0; i<s.Length; i++){
            if(s[i]=='('){
                indexValid.Push(i);
            }
            else{
                if(indexValid.Count>0){
                    indexValid.Pop();
                    int start = indexValid.Count > 0 ? indexValid.Peek() : indexInvalid;
                    int longValid = i - start;
                    sum = Math.Max(sum,longValid);
                }
                else{
                indexInvalid = i;
                }
            }
        }
        return sum;
    }
}
