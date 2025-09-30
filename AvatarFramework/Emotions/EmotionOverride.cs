using System;
using Il2CppDummyDll;

namespace ScheduleOne.AvatarFramework.Emotions
{
	// Token: 0x02000A27 RID: 2599
	[Token(Token = "0x2000A27")]
	public class EmotionOverride
	{
		// Token: 0x06004743 RID: 18243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004743")]
		[Address(RVA = "0x6CDDF0", Offset = "0x6CC7F0", VA = "0x1806CDDF0")]
		public EmotionOverride(string emotion, string label, int priority)
		{
		}

		// Token: 0x04003223 RID: 12835
		[Token(Token = "0x4003223")]
		[FieldOffset(Offset = "0x10")]
		public string Emotion;

		// Token: 0x04003224 RID: 12836
		[Token(Token = "0x4003224")]
		[FieldOffset(Offset = "0x18")]
		public string Label;

		// Token: 0x04003225 RID: 12837
		[Token(Token = "0x4003225")]
		[FieldOffset(Offset = "0x20")]
		public int Priority;
	}
}
