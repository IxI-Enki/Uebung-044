/*-----------------------------------------------------------------------------
 *                      HTBLA-Leonding / Class: 3ACIF                          
 *-----------------------------------------------------------------------------
 *                      Jan Ritt                                               
 *-----------------------------------------------------------------------------
 *  Description:  The Program outputs the first occurrence of a Vocal in a taxt
 *                upper and lower case ignored
 *-----------------------------------------------------------------------------
*/

/*_________________________________libraries_________________________________*/
using System;                   //  
using System.Text;              //  Unicode Symbols
using System.Threading;         //  Thread.Sleep(1000) = 1 sec

/*---------------------------------- START ----------------------------------*/
namespace FilterVocals      //  
{                           //
  public class Program      //
  {                         //
    static void Main()      //
    {
      ///*----------------------- console_settings ------------------------*///
      const int cWidth = 53;                     //  console width
      const int cHeight = 30;                    //  & height
      Console.SetWindowSize(cWidth, cHeight);    //
      Console.OutputEncoding = Encoding.UTF8;    //  Unicode Symbols

      /*----------------------------- VARIABLES -----------------------------*/
      string userInput,                       //  
             vocalCache = "",
             vocalCacheOut = "";
      char[] vocalLower = new char[5];
      vocalLower = ['a', 'e', 'i', 'o', 'u'];
      char[] vocalUpper = new char[5];
      vocalUpper = ['A', 'E', 'I', 'O', 'U'];

      int index, length;
      bool empty;

      /*-------------------------------- HEAD -------------------------------*/
      Console.Clear();
      Console.Write("\n             Vokale aus Text extrahieren             " +
      /* cWidth: */ "\n=====================================================");

      Console.Write("\n Text: ");
      userInput = Console.ReadLine();

      empty = (userInput.Length > 0) ? true : false;
      if (empty)
      {
        for (index = 0; index < userInput.Length; index++)
        {
          for (int i = 0; i < 5; i++)
          {
            if (userInput[index] == vocalLower[i] || userInput[index] == vocalUpper[i])
            {
              vocalCache = vocalCache + userInput[index];
              vocalLower[i] = ' ';
              vocalUpper[i] = ' ';
            }
          }
        }
        length = vocalCache.Length;
        for (index = 0; length > index; index++)
        {
          if (vocalCache[index] != ' ')
          {
            vocalCacheOut = vocalCacheOut + vocalCache[index];
          }
        }
      }
      else
      { Console.Write("\n"); }

      Console.Write($"\n Der Text \"{userInput}\" enthält {vocalCacheOut.Length} Vokale: {vocalCacheOut}");

      /*-------------------------------- END --------------------------------*/
      Console.Write("\n Zum beenden Eingabetaste drücken..");
      Console.ReadLine();    //  wait for [enter]
      Console.Clear();       //
    }
  }
}