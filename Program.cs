using System.ComponentModel;

namespace NITFSD2
{
    internal class Program
    {

        public delegate int MyDelegateFunction(int first, int second);
        public static void DoWork()
        {
            MyDelegateFunction myFunction = new MyDelegateFunction(Add);

            var ans = myFunction(10, 90);

            MyDelegateFunction myFuntions=new MyDelegateFunction(Add);

            myFuntions += Subtract;
            myFuntions += Multiply;

            var result = myFuntions.Invoke(100,90);

            Console.WriteLine("Answer = " + ans);
            Console.WriteLine("Answer = " + result);

        }

        private static int Multiply(int first, int second)
        {
            return first + second;
        }
        private static int Add(int first, int second)
        {
            return first + second;
        }

        private static int Subtract(int first, int second)
        {
            return first + second;
        }
        static void Main(string[] args)
        {
            DoWork();

            #region Exception Handling
            //int choice = 0;
            //int div = 0;
            //int n = 0;
            //while (choice != -1)
            //{
            //    try
            //    {
            //        Console.WriteLine("Enter a divider");
            //        div = int.Parse(Console.ReadLine());

            //        Console.WriteLine("Enter a Main number");
            //        n = int.Parse(Console.ReadLine());
            //        int result = Calculate(div, n);
            //        Console.WriteLine(result);
            //    }
            //    catch (System.DivideByZeroException ex) {
            //        Console.WriteLine("Divider is zero this input can't be given as zero");
            //    }
            //    catch(MyOwnException ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }
            //    catch (Exception ex)
            //    { 
            //        Console.WriteLine("Internal error " );
            //    }
            //    finally
            //    {
            //        div = 0; n = 0;
            //    }
            //    Console.WriteLine("Please enter your choice if choice is -1 the exit, else continue");
            //    choice = int.Parse(Console.ReadLine());
            //}
            #endregion


        }

        /// <summary>
        ///  This function is used for calculation
        /// </summary>
        /// <param name="div">Divider number</param>
        /// <param name="n">Core number</param>
        /// <returns>integer number</returns>
        /// <exception cref="DivideByZeroException">if you give divider is zero you will get this exception</exception>
        /// <exception cref="Exception">THis is general exception</exception>
        public static int Calculate(int div, int n)
        {
            int res = 0;

            try
            {
                res = n / div;

            }
            catch (DivideByZeroException ex )
            {
                throw new MyOwnException("Please check your input");
            }
            catch (Exception ex)
            {
                throw new Exception("Please contact admin. there is internal exception");
            }

            return res;
        }
    }
}
