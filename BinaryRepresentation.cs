class Solution {
    public string findDigitsInBinary(int A) {
        List<int> listBinary = new List<int>();{
            if (A == 0){
                return "0";
            }
        }
            while (A>0){
                int result;
                Math.DivRem(A,2,out result); 
                listBinary.Add(result);
                A = A / 2;
            }
            listBinary.Reverse();
                string resultBinary = "";
                for (int i=0; i<listBinary.Count;i++){
                    resultBinary += listBinary[i].ToString();
                }
                return resultBinary;
            
    }
}
