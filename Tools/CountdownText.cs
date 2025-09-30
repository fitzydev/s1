using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace ScheduleOne.Tools
{
	// Token: 0x020008F3 RID: 2291
	[Token(Token = "0x20008F3")]
	public class CountdownText : MonoBehaviour
	{
		// Token: 0x06003F6A RID: 16234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F6A")]
		[Address(RVA = "0x85F900", Offset = "0x85E300", VA = "0x18085F900")]
		private void Start()
		{
		}

		// Token: 0x06003F6B RID: 16235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F6B")]
		[Address(RVA = "0x85FA20", Offset = "0x85E420", VA = "0x18085FA20")]
		private void Update()
		{
		}

		// Token: 0x06003F6C RID: 16236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F6C")]
		[Address(RVA = "0x85FA20", Offset = "0x85E420", VA = "0x18085FA20")]
		private void UpdateCountdown()
		{
		}

		// Token: 0x06003F6D RID: 16237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F6D")]
		[Address(RVA = "0x85F760", Offset = "0x85E160", VA = "0x18085F760")]
		private string FormatTime(TimeSpan timeSpan)
		{
			return null;
		}

		// Token: 0x06003F6E RID: 16238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F6E")]
		[Address(RVA = "0x85FB30", Offset = "0x85E530", VA = "0x18085FB30")]
		public CountdownText()
		{
		}

		// Token: 0x04002C6F RID: 11375
		[Token(Token = "0x4002C6F")]
		[FieldOffset(Offset = "0x20")]
		public TextMeshProUGUI TimeLabel;

		// Token: 0x04002C70 RID: 11376
		[Token(Token = "0x4002C70")]
		[FieldOffset(Offset = "0x28")]
		[Header("Date Setting")]
		public int Year;

		// Token: 0x04002C71 RID: 11377
		[Token(Token = "0x4002C71")]
		[FieldOffset(Offset = "0x2C")]
		public int Month;

		// Token: 0x04002C72 RID: 11378
		[Token(Token = "0x4002C72")]
		[FieldOffset(Offset = "0x30")]
		public int Day;

		// Token: 0x04002C73 RID: 11379
		[Token(Token = "0x4002C73")]
		[FieldOffset(Offset = "0x34")]
		public int Hour;

		// Token: 0x04002C74 RID: 11380
		[Token(Token = "0x4002C74")]
		[FieldOffset(Offset = "0x38")]
		public int Minute;

		// Token: 0x04002C75 RID: 11381
		[Token(Token = "0x4002C75")]
		[FieldOffset(Offset = "0x3C")]
		public int Second;

		// Token: 0x04002C76 RID: 11382
		[Token(Token = "0x4002C76")]
		[FieldOffset(Offset = "0x40")]
		private DateTime targetPDTDate;
	}
}
