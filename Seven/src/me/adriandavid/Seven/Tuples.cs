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
	public class Tuples {
		public static void Main() {
			//C#7 Tuples
			var tuple7 = ("Julien Missial", "E295481", 170000.0);
			Console.WriteLine("\nC#7 Tuples:\t\t\t" + tuple7);

			//Pre C#7 Tuples, Tuple Structs; System.ValueTuple
			ValueTuple<string, string, int> tuple6_s = new ValueTuple<string, string, int> (
							"Julien Missial", "E295481", 170000);
			Console.WriteLine("Pre C#7 Tuples, Tuple Structs:\t" + tuple6_s);

			//Pre C#7 Tuples, Tuple Classes; System.Tuple <>
			Tuple<string, string, int> tuple6_c = new Tuple<string, string, int> (
							"Julien Missial", "E295481", 170000);
			//You can also use ValueTuple.Create("Julien Missial", "E295481", 170000);
			Console.WriteLine("Pre C#7 Tuples, Tuple Classes:\t" + tuple6_c + "\n");
		}
	}
}