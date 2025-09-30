using System;
using System.Runtime.InteropServices;
using FishNet.Serializing.Helping;
using Il2CppDummyDll;

namespace ScheduleOne.Messaging
{
	// Token: 0x020004BB RID: 1211
	[Token(Token = "0x20004BB")]
	[Serializable]
	public class Response
	{
		// Token: 0x06001800 RID: 6144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001800")]
		[Address(RVA = "0x6106C0", Offset = "0x60F0C0", VA = "0x1806106C0")]
		public Response(string _text, string _label, [Optional] Action _callback, bool _disableDefaultResponseBehaviour = false)
		{
		}

		// Token: 0x06001801 RID: 6145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001801")]
		[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
		public Response()
		{
		}

		// Token: 0x0400159D RID: 5533
		[Token(Token = "0x400159D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string text;

		// Token: 0x0400159E RID: 5534
		[Token(Token = "0x400159E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string label;

		// Token: 0x0400159F RID: 5535
		[Token(Token = "0x400159F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[CodegenExclude]
		public Action callback;

		// Token: 0x040015A0 RID: 5536
		[Token(Token = "0x40015A0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool disableDefaultResponseBehaviour;
	}
}
