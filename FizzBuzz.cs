class Solution {
    public List<string> fizzBuzz(int A) {
        var fizzBuzzList = new List<string>();
        for (int i=1;i < A+1; i++){
            if ((i % 3 == 0) && (i % 5 == 0)){
               fizzBuzzList.Add("FizzBuzz");
            }
            else if (i % 3 == 0){
               fizzBuzzList.Add("Fizz");
            }
            else if (i % 5 == 0){
                fizzBuzzList.Add("Buzz");
            }
            else {
                fizzBuzzList.Add(i.ToString());
            }
        }
        return fizzBuzzList;
    }
}
