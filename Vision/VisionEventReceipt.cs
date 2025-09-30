using System;
using FishNet.Object;
using Il2CppDummyDll;

namespace ScheduleOne.Vision
{
	// Token: 0x02000384 RID: 900
	[Token(Token = "0x2000384")]
	[Serializable]
	public class VisionEventReceipt
	{
		// Token: 0x06001421 RID: 5153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001421")]
		[Address(RVA = "0x5C4F30", Offset = "0x5C3930", VA = "0x1805C4F30")]
		public VisionEventReceipt(NetworkObject target, EVisualState state)
		{
		}

		// Token: 0x06001422 RID: 5154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001422")]
		[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
		public VisionEventReceipt()
		{
		}

		// Token: 0x040012FF RID: 4863
		[Token(Token = "0x40012FF")]
		[FieldOffset(Offset = "0x10")]
		public NetworkObject Target;

		// Token: 0x04001300 RID: 4864
		[Token(Token = "0x4001300")]
		[FieldOffset(Offset = "0x18")]
		public EVisualState State;
	}
}
