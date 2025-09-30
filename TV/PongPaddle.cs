using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.TV
{
	// Token: 0x020002AC RID: 684
	[Token(Token = "0x20002AC")]
	public class PongPaddle : MonoBehaviour
	{
		// Token: 0x17000310 RID: 784
		// (get) Token: 0x06000E3B RID: 3643 RVA: 0x00007170 File Offset: 0x00005370
		// (set) Token: 0x06000E3C RID: 3644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000310")]
		public float TargetY
		{
			[Token(Token = "0x6000E3B")]
			[Address(RVA = "0x485C90", Offset = "0x484690", VA = "0x180485C90")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000E3C")]
			[Address(RVA = "0x485CD0", Offset = "0x4846D0", VA = "0x180485CD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000E3D RID: 3645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E3D")]
		[Address(RVA = "0x485CD0", Offset = "0x4846D0", VA = "0x180485CD0")]
		public void SetTargetY(float y)
		{
		}

		// Token: 0x06000E3E RID: 3646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E3E")]
		[Address(RVA = "0xABD530", Offset = "0xABBF30", VA = "0x180ABD530")]
		private void Update()
		{
		}

		// Token: 0x06000E3F RID: 3647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E3F")]
		[Address(RVA = "0xABD530", Offset = "0xABBF30", VA = "0x180ABD530")]
		private void UpdateMove()
		{
		}

		// Token: 0x06000E40 RID: 3648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E40")]
		[Address(RVA = "0x583E00", Offset = "0x582800", VA = "0x180583E00")]
		public PongPaddle()
		{
		}

		// Token: 0x04000E7B RID: 3707
		[Token(Token = "0x4000E7B")]
		public const float BOUND_Y = 160f;

		// Token: 0x04000E7C RID: 3708
		[Token(Token = "0x4000E7C")]
		public const float MOVE_SPEED = 20f;

		// Token: 0x04000E7D RID: 3709
		[Token(Token = "0x4000E7D")]
		[FieldOffset(Offset = "0x20")]
		public float SpeedMultiplier;

		// Token: 0x04000E7F RID: 3711
		[Token(Token = "0x4000E7F")]
		[FieldOffset(Offset = "0x28")]
		public RectTransform Rect;
	}
}
