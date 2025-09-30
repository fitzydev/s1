using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Graffiti
{
	// Token: 0x02000590 RID: 1424
	[Token(Token = "0x2000590")]
	[Serializable]
	public struct UShort2
	{
		// Token: 0x0600205F RID: 8287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600205F")]
		[Address(RVA = "0x684AE0", Offset = "0x6834E0", VA = "0x180684AE0")]
		public UShort2(ushort x, ushort y)
		{
		}

		// Token: 0x06002060 RID: 8288 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002060")]
		[Address(RVA = "0x684A50", Offset = "0x683450", VA = "0x180684A50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002061 RID: 8289 RVA: 0x0000A7B8 File Offset: 0x000089B8
		[Token(Token = "0x6002061")]
		[Address(RVA = "0x684AF0", Offset = "0x6834F0", VA = "0x180684AF0")]
		public static UShort2 operator +(UShort2 a, UShort2 b)
		{
			return default(UShort2);
		}

		// Token: 0x06002062 RID: 8290 RVA: 0x0000A7D0 File Offset: 0x000089D0
		[Token(Token = "0x6002062")]
		[Address(RVA = "0x684B30", Offset = "0x683530", VA = "0x180684B30")]
		public static UShort2 operator -(UShort2 a, UShort2 b)
		{
			return default(UShort2);
		}

		// Token: 0x06002063 RID: 8291 RVA: 0x0000A7E8 File Offset: 0x000089E8
		[Token(Token = "0x6002063")]
		[Address(RVA = "0x684B10", Offset = "0x683510", VA = "0x180684B10")]
		public static implicit operator Vector2(UShort2 uShort2)
		{
			return default(Vector2);
		}

		// Token: 0x04001A64 RID: 6756
		[Token(Token = "0x4001A64")]
		[FieldOffset(Offset = "0x0")]
		public ushort X;

		// Token: 0x04001A65 RID: 6757
		[Token(Token = "0x4001A65")]
		[FieldOffset(Offset = "0x2")]
		public ushort Y;
	}
}
