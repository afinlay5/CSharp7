/*
	Taken from "What's new in C#7.0" by Microsoft Corporation. Copyright (C) 2018
	https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-7#generalized-async-return-types
**/

using System.Threading.Tasks;

namespace src.me.adriandavid.Seven {
	public class GenAsyncReturn {
		public async ValueTask<int> Func() {  
   			await Task.Delay(100);     
   			return 5; 
		}
	}
}