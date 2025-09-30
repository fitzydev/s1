using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Growing
{
	// Token: 0x02000928 RID: 2344
	[Token(Token = "0x2000928")]
	public class Additive : MonoBehaviour
	{
		// Token: 0x0600402F RID: 16431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600402F")]
		[Address(RVA = "0x85D950", Offset = "0x85C350", VA = "0x18085D950")]
		public Additive()
		{
		}

		// Token: 0x04002D10 RID: 11536
		[Token(Token = "0x4002D10")]
		[FieldOffset(Offset = "0x20")]
		public string AdditiveName;

		// Token: 0x04002D11 RID: 11537
		[Token(Token = "0x4002D11")]
		[FieldOffset(Offset = "0x28")]
		public string AssetPath;

		// Token: 0x04002D12 RID: 11538
		[Token(Token = "0x4002D12")]
		[FieldOffset(Offset = "0x30")]
		[Header("Plant effector settings")]
		public float QualityChange;

		// Token: 0x04002D13 RID: 11539
		[Token(Token = "0x4002D13")]
		[FieldOffset(Offset = "0x34")]
		public float YieldChange;

		// Token: 0x04002D14 RID: 11540
		[Token(Token = "0x4002D14")]
		[FieldOffset(Offset = "0x38")]
		public float GrowSpeedMultiplier;

		// Token: 0x04002D15 RID: 11541
		[Token(Token = "0x4002D15")]
		[FieldOffset(Offset = "0x3C")]
		public float InstantGrowth;
	}
}
