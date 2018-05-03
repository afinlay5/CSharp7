/*
Copyright (C) 2018 Adrian D. Finlay. All rights reserved.

Licensed under the MIT License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    https://opensource.org/licenses/MIT

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER INCLUDING AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
==============================================================================
**/

using System;

namespace src.me.adriandavid.Seven {
	public class RefLocal {
		//Ref Method
		public static ref double ref_local (double [] m) {
			return ref m[1];
		}

		//main()
		public static void Main() {
			//Array[2] of double
			double[] arr = {2.1,3.4};
			//Let's print the contents - 2.1,3.4
			Console.WriteLine("\nThe values are:");
			foreach (double d in arr) { Console.WriteLine(d); }

			//Ref Local - By reference, to the second index.
			ref var i = ref ref_local (arr);
			//Let's change the value at this reference
			//This will change the value at arr[1]!
			i = 1.1;

			//It is now 2.1, 1,1
			Console.WriteLine("\nThe values are now:");
			foreach (double d in arr) { Console.WriteLine(d); }
		}
	}
}