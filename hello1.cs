public class Hello1
    {
        int OneToZero(int[] args)
        {
            int iCount = 0;
            for (int i = 0; i < args.Length; i++)
            {
                if (args[i] == 1)
                {
                    iCount++;
                    args[i] = 0;
                }
            }
            return iCount;
        }
        public static void Main(string[] args)
        {
            int[] iArr = { 1, 3, 4, 5, 1, 1, 7 };
            Hello1 test = new Hello1();
            int iNumOnes;
            System.Console.WriteLine("Values of the array: [ ");
            for (int i = 0; i < iArr.Length; i++)
            {
                System.Console.WriteLine(iArr[i] + " ");
            }
            System.Console.WriteLine("]");
            iNumOnes = test.OneToZero(iArr);
            System.Console.WriteLine("Number of ones = " + iNumOnes);
            System.Console.WriteLine("New values of the array: [ ");
            for (int i = 0; i < iArr.Length; i++)
            {
                System.Console.WriteLine(iArr[i] + "");
            }
            System.Console.WriteLine("]");
            //Console.ReadLine();
        }


    }
