using System;
using System.IO;

namespace exam._2._Methods_and_Error_Handling
{
    
    public static class ExceptionHandling
    {
        
        // TRY-CATCH-FINALLY
        public static void TryCatchFinally()
        {
            try
            {
                
            }
            catch (NullReferenceException)
            {
                
            }
            catch (FileNotFoundException)
            {

            }
            catch (DivideByZeroException)
            {

            }
            finally
            {
                Console.WriteLine("Errors handled!");
            }
        }
        
    }
    
}