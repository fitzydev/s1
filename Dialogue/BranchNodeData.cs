using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Dialogue
{
	// Token: 0x02000647 RID: 1607
	[Token(Token = "0x2000647")]
	[Serializable]
	public class BranchNodeData
	{
		// Token: 0x06002764 RID: 10084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002764")]
		[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
		public BranchNodeData()
		{
		}

		// Token: 0x04001E2C RID: 7724
		[Token(Token = "0x4001E2C")]
		[FieldOffset(Offset = "0x10")]
		public string Guid;

		// Token: 0x04001E2D RID: 7725
		[Token(Token = "0x4001E2D")]
		[FieldOffset(Offset = "0x18")]
		public string BranchLabel;

		// Token: 0x04001E2E RID: 7726
		[Token(Token = "0x4001E2E")]
		[FieldOffset(Offset = "0x20")]
		public Vector2 Position;

		// Token: 0x04001E2F RID: 7727
		[Token(Token = "0x4001E2F")]
		[FieldOffset(Offset = "0x28")]
		public BranchOptionData[] options;
	}
}
