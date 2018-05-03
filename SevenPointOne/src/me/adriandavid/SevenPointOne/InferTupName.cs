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

namespace src.me.adriandavid.SevenPointOne {
	public class InferTupName {
		//main()
		static void Main() {
			//This is how named tuples work
			Console.WriteLine("\nThis is how named tuples work.");
			var name = (first: "Adrian", sur:"Finlay");
			Console.WriteLine("My name is " + name.sur + "," + name.first + ".");

			//Pre C#7
			var cities6 = (Istanbul: "Istanbul", Dubai: "Dubai", Paris: "Paris", Bangkok: "Bangkok");
			//C#7
			var (Istantbul, Dubai, Paris, Bangkok) = ("Istanbul", "Dubai", "Paris", "Bangkok");
			var cities = (Istanbul, Dubai, Paris, Bangkok); //The names of Tuple Elements are inferred

			Console.WriteLine("\nFamous cities around the world:");

			//Observe the auto inferred Tuple Names: The name is inferred from the variable name
			Console.WriteLine(cities.Istanbul);
			Console.WriteLine(cities.Dubai);
			Console.WriteLine(cities.Paris);
			Console.WriteLine(cities.Bangkok);

			Console.WriteLine();
			
		}
	}
}