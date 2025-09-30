using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace ScheduleOne.DevUtilities
{
	// Token: 0x0200076C RID: 1900
	[Token(Token = "0x200076C")]
	public class ValueTracker
	{
		// Token: 0x06003367 RID: 13159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003367")]
		[Address(RVA = "0x78DE20", Offset = "0x78C820", VA = "0x18078DE20")]
		public ValueTracker(float HistoryDuration)
		{
		}

		// Token: 0x06003368 RID: 13160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003368")]
		[Address(RVA = "0x78D790", Offset = "0x78C190", VA = "0x18078D790")]
		public void Destroy()
		{
		}

		// Token: 0x06003369 RID: 13161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003369")]
		[Address(RVA = "0x78DD60", Offset = "0x78C760", VA = "0x18078DD60")]
		public void Update()
		{
		}

		// Token: 0x0600336A RID: 13162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600336A")]
		[Address(RVA = "0x78DC60", Offset = "0x78C660", VA = "0x18078DC60")]
		public void SubmitValue(float value)
		{
		}

		// Token: 0x0600336B RID: 13163 RVA: 0x0000E298 File Offset: 0x0000C498
		[Token(Token = "0x600336B")]
		[Address(RVA = "0x78DBC0", Offset = "0x78C5C0", VA = "0x18078DBC0")]
		public float RecordedHistoryLength()
		{
			return 0f;
		}

		// Token: 0x0600336C RID: 13164 RVA: 0x0000E2B0 File Offset: 0x0000C4B0
		[Token(Token = "0x600336C")]
		[Address(RVA = "0x78DA70", Offset = "0x78C470", VA = "0x18078DA70")]
		public float GetLowestValue()
		{
			return 0f;
		}

		// Token: 0x0600336D RID: 13165 RVA: 0x0000E2C8 File Offset: 0x0000C4C8
		[Token(Token = "0x600336D")]
		[Address(RVA = "0x78D8E0", Offset = "0x78C2E0", VA = "0x18078D8E0")]
		public float GetAverageValue()
		{
			return 0f;
		}

		// Token: 0x040023AB RID: 9131
		[Token(Token = "0x40023AB")]
		[FieldOffset(Offset = "0x10")]
		private float historyDuration;

		// Token: 0x040023AC RID: 9132
		[Token(Token = "0x40023AC")]
		[FieldOffset(Offset = "0x18")]
		private List<ValueTracker.Value> valueHistory;

		// Token: 0x0200076D RID: 1901
		[Token(Token = "0x200076D")]
		public class Value
		{
			// Token: 0x0600336E RID: 13166 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600336E")]
			[Address(RVA = "0x78DFD0", Offset = "0x78C9D0", VA = "0x18078DFD0")]
			public Value(float val, float time)
			{
			}

			// Token: 0x040023AD RID: 9133
			[Token(Token = "0x40023AD")]
			[FieldOffset(Offset = "0x10")]
			public float val;

			// Token: 0x040023AE RID: 9134
			[Token(Token = "0x40023AE")]
			[FieldOffset(Offset = "0x14")]
			public float time;
		}
	}
}
