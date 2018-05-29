/*  Copyright (C) 2008-2018 Peter Palotas, Jeffrey Jangli, Alexandr Normuradov
 *  
 *  Permission is hereby granted, free of charge, to any person obtaining a copy 
 *  of this software and associated documentation files (the "Software"), to deal 
 *  in the Software without restriction, including without limitation the rights 
 *  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell 
 *  copies of the Software, and to permit persons to whom the Software is 
 *  furnished to do so, subject to the following conditions:
 *  
 *  The above copyright notice and this permission notice shall be included in 
 *  all copies or substantial portions of the Software.
 *  
 *  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR 
 *  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, 
 *  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE 
 *  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER 
 *  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, 
 *  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN 
 *  THE SOFTWARE. 
 */

using System;

namespace AlphaFS.UnitTest
{
   /// <summary>Containts static variables, used by unit tests.</summary>
   public static partial class UnitTestConstants
   {
      /// <summary>Returns a random folder name or file name, possibly with diacritic characters.</summary>
      public static string GetRandomFileName()
      {
         var randomFileName = System.IO.Path.GetRandomFileName();

         switch (new Random(DateTime.Now.Millisecond).Next(1, 3))
         {
            case 1:
               return randomFileName.Replace("a", "ä").Replace("e", "ë").Replace("i", "ï").Replace("o", "ö").Replace("u", "ü");

            case 2:
               return randomFileName.Replace("a", "á").Replace("e", "é").Replace("i", "í").Replace("o", "ó").Replace("u", "ú");

            case 3:
               return randomFileName.Replace("a", "â").Replace("e", "ê").Replace("i", "î").Replace("o", "ô").Replace("u", "û");

            default:
               return randomFileName;
         }
      }
   }
}
