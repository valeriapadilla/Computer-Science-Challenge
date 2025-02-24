public class Solution {
    public void Rotate(int[][] matrix) {
        int top = 0;
        int dimension = matrix.Length - 1;
        int left = top;
        int right = dimension;
        int temp;

        while(left<right){
            for(int i=0; i<right-left;i++){
                top = left;
                dimension = right;
                temp = matrix[top][left+i];
                matrix[top][left+i] = matrix[dimension-i][left];
                matrix[dimension-i][left] = matrix[dimension][right-i];
                matrix[dimension][right-i] = matrix[top+i][right];
                matrix[top+i][right] = temp;
            }
            left +=1;
            right -=1;
        }
    }
};
