using System;
using Il2CppDummyDll;

namespace ScheduleOne.Dialogue
{
	// Token: 0x02000651 RID: 1617
	[Token(Token = "0x2000651")]
	[Serializable]
	public class NodeLinkData
	{
		// Token: 0x0600277E RID: 10110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600277E")]
		[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
		public NodeLinkData()
		{
		}

		// Token: 0x04001E44 RID: 7748
		[Token(Token = "0x4001E44")]
		[FieldOffset(Offset = "0x10")]
		public string BaseDialogueOrBranchNodeGuid;

		// Token: 0x04001E45 RID: 7749
		[Token(Token = "0x4001E45")]
		[FieldOffset(Offset = "0x18")]
		public string BaseChoiceOrOptionGUID;

		// Token: 0x04001E46 RID: 7750
		[Token(Token = "0x4001E46")]
		[FieldOffset(Offset = "0x20")]
		public string TargetNodeGuid;
	}
}
