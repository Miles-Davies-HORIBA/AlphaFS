﻿/*  Copyright (C) 2008-2018 Peter Palotas, Jeffrey Jangli, Alexandr Normuradov
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

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Globalization;
using System.Reflection;

namespace AlphaFS.UnitTest
{
   public partial class AlphaFS_Directory_CountFileSystemObjectsTest
   {
      // Pattern: <class>_<function>_<scenario>_<expected result>


      [TestMethod]
      public void AlphaFS_Directory_CountFileSystemObjects_FilesOnly_Recursive_LocalAndNetwork_Success()
      {
         Directory_CountFileSystemObjects_FilesOnly_Recursive(false);
         Directory_CountFileSystemObjects_FilesOnly_Recursive(true);
      }


      private void Directory_CountFileSystemObjects_FilesOnly_Recursive(bool isNetwork)
      {
         UnitTestConstants.PrintUnitTestHeader(isNetwork);

         using (var tempRoot = new TemporaryDirectory(isNetwork ? Alphaleonis.Win32.Filesystem.Path.LocalToUnc(UnitTestConstants.TempPath) : UnitTestConstants.TempPath, MethodBase.GetCurrentMethod().Name))
         {
            var folder = tempRoot.RandomDirectoryFullPath;

            Console.WriteLine("\nInput Directory Path: [{0}]", folder);


            const int maxFso = 10;
            const int expectedFso = 20;

            UnitTestConstants.CreateDirectoriesAndFiles(folder, maxFso, false, false, false);


            var fsoCount = Alphaleonis.Win32.Filesystem.Directory.CountFileSystemObjects(folder, "*", Alphaleonis.Win32.Filesystem.DirectoryEnumerationOptions.Files | Alphaleonis.Win32.Filesystem.DirectoryEnumerationOptions.Recursive);

            Console.WriteLine("\n\tTotal file system objects = [{0}]", fsoCount);


            Assert.AreEqual(expectedFso, fsoCount, string.Format(CultureInfo.InvariantCulture, "The number of file system objects are not equal, but are expected to."));
         }
         
         Console.WriteLine();
      }
   }
}