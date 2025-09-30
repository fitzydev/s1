using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.AvatarFramework.Emotions
{
	// Token: 0x02000A30 RID: 2608
	[Token(Token = "0x2000A30")]
	[Serializable]
	public class AvatarEmotionPreset
	{
		// Token: 0x06004771 RID: 18289 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004771")]
		[Address(RVA = "0x8ECA90", Offset = "0x8EB490", VA = "0x1808ECA90")]
		public static AvatarEmotionPreset Lerp(AvatarEmotionPreset start, AvatarEmotionPreset end, AvatarEmotionPreset neutralPreset, float lerp)
		{
			return null;
		}

		// Token: 0x06004772 RID: 18290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004772")]
		[Address(RVA = "0x8ECE30", Offset = "0x8EB830", VA = "0x1808ECE30")]
		public AvatarEmotionPreset()
		{
		}

		// Token: 0x04003248 RID: 12872
		[Token(Token = "0x4003248")]
		[FieldOffset(Offset = "0x10")]
		public string PresetName;

		// Token: 0x04003249 RID: 12873
		[Token(Token = "0x4003249")]
		[FieldOffset(Offset = "0x18")]
		public Texture2D FaceTexture;

		// Token: 0x0400324A RID: 12874
		[Token(Token = "0x400324A")]
		[FieldOffset(Offset = "0x20")]
		public Eye.EyeLidConfiguration LeftEyeRestingState;

		// Token: 0x0400324B RID: 12875
		[Token(Token = "0x400324B")]
		[FieldOffset(Offset = "0x28")]
		public Eye.EyeLidConfiguration RightEyeRestingState;

		// Token: 0x0400324C RID: 12876
		[Token(Token = "0x400324C")]
		[FieldOffset(Offset = "0x30")]
		[Range(-30f, 30f)]
		public float BrowAngleChange_L;

		// Token: 0x0400324D RID: 12877
		[Token(Token = "0x400324D")]
		[FieldOffset(Offset = "0x34")]
		[Range(-30f, 30f)]
		public float BrowAngleChange_R;

		// Token: 0x0400324E RID: 12878
		[Token(Token = "0x400324E")]
		[FieldOffset(Offset = "0x38")]
		[Range(-1f, 1f)]
		public float BrowHeightChange_L;

		// Token: 0x0400324F RID: 12879
		[Token(Token = "0x400324F")]
		[FieldOffset(Offset = "0x3C")]
		[Range(-1f, 1f)]
		public float BrowHeightChange_R;
	}
}
