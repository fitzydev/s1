using System;
using Il2CppDummyDll;

namespace ScheduleOne.Vision
{
	// Token: 0x02000377 RID: 887
	[Token(Token = "0x2000377")]
	[Serializable]
	public class EntityVisualState
	{
		// Token: 0x060013D1 RID: 5073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013D1")]
		[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
		public EntityVisualState()
		{
		}

		// Token: 0x040012AB RID: 4779
		[Token(Token = "0x40012AB")]
		[FieldOffset(Offset = "0x10")]
		public EVisualState state;

		// Token: 0x040012AC RID: 4780
		[Token(Token = "0x40012AC")]
		[FieldOffset(Offset = "0x18")]
		public string label;

		// Token: 0x040012AD RID: 4781
		[Token(Token = "0x40012AD")]
		[FieldOffset(Offset = "0x20")]
		public Action stateDestroyed;
	}
}
