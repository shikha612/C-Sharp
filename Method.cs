class Method
    {
        static void CountValue(char [] arr)
       {
            int vowel = 0; int cons = 0;
            
            for(int i = arr.Length-1; i>=0; i--)
            {  
              System.Console.WriteLine(arr[i]);
              }           
             for (int i = 0; i < arr.Length; i++)   
             
            {
                if (arr[i] == 'a' || arr[i] == 'e' || arr[i] == 'i' || arr[i] == 'o' || arr[i] == 'u' )
               
                {
                    vowel++;
                }
                else
                    cons++;
            }
            System.Console.WriteLine("vowel:{0} cons:{1}", vowel, cons); 
        }
         static void Main()
       {
       System.Console.WriteLine("Enter the string");  
       string name = System.Convert.ToString(System.Console.ReadLine());
            char[] arr = name.ToCharArray();
            CountValue(arr);
            System.Console.ReadLine();
}        
    } 
        

