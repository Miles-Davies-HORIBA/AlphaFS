/*  Copyright (C) 2008-2017 Peter Palotas, Jeffrey Jangli, Alexandr Normuradov
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

using System.Security;

namespace Alphaleonis.Win32.Filesystem
{
   public static partial class Directory
   {
      /// <summary>[AlphaFS] Gets the unique identifier for a directory. The identifier is composed of a 64-bit volume serial number and 128-bit file system entry identifier.</summary>
      /// <remarks>Directory IDs are not guaranteed to be unique over time, because file systems are free to reuse them. In some cases, the file ID for a directory can change over time.</remarks>
      /// <param name="path">The path to the directory.</param>
      [SecurityCritical]
      public static FileIdInfo GetFileIdInfo(string path)
      {
         return File.GetFileIdInfoCore(null, path, PathFormat.RelativePath);
      }


      /// <summary>[AlphaFS] Gets the unique identifier for a directory. The identifier is composed of a 64-bit volume serial number and 128-bit file system entry identifier.</summary>
      /// <remarks>Directory IDs are not guaranteed to be unique over time, because file systems are free to reuse them. In some cases, the file ID for a directory can change over time.</remarks>
      /// <param name="path">The path to the directory.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      [SecurityCritical]
      public static FileIdInfo GetFileIdInfo(string path, PathFormat pathFormat)
      {
         return File.GetFileIdInfoCore(null, path, pathFormat);
      }




      /// <summary>[AlphaFS] Gets the unique identifier for a directory. The identifier is composed of a 64-bit volume serial number and 128-bit file system entry identifier.</summary>
      /// <remarks>Directory IDs are not guaranteed to be unique over time, because file systems are free to reuse them. In some cases, the file ID for a directory can change over time.</remarks>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">The path to the directory.</param>
      [SecurityCritical]
      public static FileIdInfo GetFileIdTransacted(KernelTransaction transaction, string path)
      {
         return File.GetFileIdInfoCore(transaction, path, PathFormat.RelativePath);
      }


      /// <summary>[AlphaFS] Gets the unique identifier for a directory. The identifier is composed of a 64-bit volume serial number and 128-bit file system entry identifier.</summary>
      /// <remarks>Directory IDs are not guaranteed to be unique over time, because file systems are free to reuse them. In some cases, the file ID for a directory can change over time.</remarks>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">The path to the directory.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      [SecurityCritical]
      public static FileIdInfo GetFileIdTransacted(KernelTransaction transaction, string path, PathFormat pathFormat)
      {
         return File.GetFileIdInfoCore(transaction, path, pathFormat);
      }
   }
}
