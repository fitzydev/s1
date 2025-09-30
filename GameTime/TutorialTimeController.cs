using System;
using EasyButtons;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.GameTime
{
	// Token: 0x020002C4 RID: 708
	[Token(Token = "0x20002C4")]
	public class TutorialTimeController : MonoBehaviour
	{
		// Token: 0x06000F3E RID: 3902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F3E")]
		[Address(RVA = "0xACED10", Offset = "0xACD710", VA = "0x180ACED10")]
		private void Awake()
		{
		}

		// Token: 0x06000F3F RID: 3903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F3F")]
		[Address(RVA = "0xACF070", Offset = "0xACDA70", VA = "0x180ACF070")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000F40 RID: 3904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F40")]
		[Address(RVA = "0xACF1E0", Offset = "0xACDBE0", VA = "0x180ACF1E0")]
		private void Update()
		{
		}

		// Token: 0x06000F41 RID: 3905 RVA: 0x00007668 File Offset: 0x00005868
		[Token(Token = "0x6000F41")]
		[Address(RVA = "0xACEF00", Offset = "0xACD900", VA = "0x180ACEF00")]
		private int GetCurrentKeyFrameStart()
		{
			return 0;
		}

		// Token: 0x06000F42 RID: 3906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F42")]
		[Address(RVA = "0xACEFB0", Offset = "0xACD9B0", VA = "0x180ACEFB0")]
		[Button]
		public void IncrementKeyframe()
		{
		}

		// Token: 0x06000F43 RID: 3907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F43")]
		[Address(RVA = "0xACEE60", Offset = "0xACD860", VA = "0x180ACEE60")]
		public void Disable()
		{
		}

		// Token: 0x06000F44 RID: 3908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F44")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public TutorialTimeController()
		{
		}

		// Token: 0x04000F48 RID: 3912
		[Token(Token = "0x4000F48")]
		[FieldOffset(Offset = "0x20")]
		public AnimationCurve TimeProgressionCurve;

		// Token: 0x04000F49 RID: 3913
		[Token(Token = "0x4000F49")]
		[FieldOffset(Offset = "0x28")]
		public TutorialTimeController.KeyFrame[] KeyFrames;

		// Token: 0x04000F4A RID: 3914
		[Token(Token = "0x4000F4A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private int currentKeyFrameIndex;

		// Token: 0x04000F4B RID: 3915
		[Token(Token = "0x4000F4B")]
		[FieldOffset(Offset = "0x34")]
		private bool disabled;

		// Token: 0x020002C5 RID: 709
		[Token(Token = "0x20002C5")]
		[Serializable]
		public struct KeyFrame
		{
			// Token: 0x04000F4C RID: 3916
			[Token(Token = "0x4000F4C")]
			[FieldOffset(Offset = "0x0")]
			public int Time;

			// Token: 0x04000F4D RID: 3917
			[Token(Token = "0x4000F4D")]
			[FieldOffset(Offset = "0x4")]
			public float SpeedMultiplier;

			// Token: 0x04000F4E RID: 3918
			[Token(Token = "0x4000F4E")]
			[FieldOffset(Offset = "0x8")]
			public string Note;
		}
	}
}
