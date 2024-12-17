public class Solution {
    public int MaxCount(int[] banned, int n, int maxSum) {
        int i = 1;
        int actualSum = 0;
        int count = 0;
        Array.Sort(banned);
        while(i <= n){
            bool isBanned = false;
            for(int j = 0; j < banned.Length; j++){
                if(i == banned[j]){
                    isBanned = true;
                }
                else if(i < banned[j]){
                    break;
                }
            }

            if(!isBanned){
                int previousActualSum = actualSum;
                int futureSum = actualSum + i;
                if(futureSum <= maxSum){
                   actualSum = futureSum;
                   count++;
                }
                else{
                    break;
                }
            }
            i++;
        }

        return count;
    }
}