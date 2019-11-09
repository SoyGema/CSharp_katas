// Factor number

class Solution {
    public List<int> allFactors(int A) {
        List<int> allFactorsList = new List<int>();
        for (int i=1; i<A+1; i++)
        {
            if (A % i == 0) 
            {
            allFactorsList.Add(i);
            }
        }
        return allFactorsList;
    }
}
