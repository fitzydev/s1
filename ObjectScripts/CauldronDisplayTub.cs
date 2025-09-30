using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x02000C9A RID: 3226
	[Token(Token = "0x2000C9A")]
	public class CauldronDisplayTub : MonoBehaviour
	{
		// Token: 0x06005883 RID: 22659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005883")]
		[Address(RVA = "0xA0BB50", Offset = "0xA0A550", VA = "0x180A0BB50")]
		public void Configure(CauldronDisplayTub.EContents contentsType, float fillLevel)
		{
		}

		// Token: 0x06005884 RID: 22660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005884")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public CauldronDisplayTub()
		{
		}

		// Token: 0x04004123 RID: 16675
		[Token(Token = "0x4004123")]
		[FieldOffset(Offset = "0x20")]
		public Transform CocaLeafContainer;

		// Token: 0x04004124 RID: 16676
		[Token(Token = "0x4004124")]
		[FieldOffset(Offset = "0x28")]
		public Transform Container_Min;

		// Token: 0x04004125 RID: 16677
		[Token(Token = "0x4004125")]
		[FieldOffset(Offset = "0x30")]
		public Transform Container_Max;

		// Token: 0x02000C9B RID: 3227
		[Token(Token = "0x2000C9B")]
		public enum EContents
		{
			// Token: 0x04004127 RID: 16679
			[Token(Token = "0x4004127")]
			None,
			// Token: 0x04004128 RID: 16680
			[Token(Token = "0x4004128")]
			CocaLeaf
		}
	}
}
