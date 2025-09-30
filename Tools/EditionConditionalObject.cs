using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Tools
{
	// Token: 0x020008F8 RID: 2296
	[Token(Token = "0x20008F8")]
	public class EditionConditionalObject : MonoBehaviour
	{
		// Token: 0x06003F7E RID: 16254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F7E")]
		[Address(RVA = "0x85FFF0", Offset = "0x85E9F0", VA = "0x18085FFF0")]
		private void Awake()
		{
		}

		// Token: 0x06003F7F RID: 16255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F7F")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public EditionConditionalObject()
		{
		}

		// Token: 0x04002C7F RID: 11391
		[Token(Token = "0x4002C7F")]
		[FieldOffset(Offset = "0x20")]
		public EditionConditionalObject.EType type;

		// Token: 0x020008F9 RID: 2297
		[Token(Token = "0x20008F9")]
		public enum EType
		{
			// Token: 0x04002C81 RID: 11393
			[Token(Token = "0x4002C81")]
			ActiveInDemo,
			// Token: 0x04002C82 RID: 11394
			[Token(Token = "0x4002C82")]
			ActiveInFullGame
		}
	}
}
