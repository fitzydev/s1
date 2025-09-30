using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x02000AF1 RID: 2801
	[Token(Token = "0x2000AF1")]
	public class StaminaBar : MonoBehaviour
	{
		// Token: 0x06004C1B RID: 19483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C1B")]
		[Address(RVA = "0x935860", Offset = "0x934260", VA = "0x180935860")]
		private void Awake()
		{
		}

		// Token: 0x06004C1C RID: 19484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C1C")]
		[Address(RVA = "0x9359B0", Offset = "0x9343B0", VA = "0x1809359B0")]
		private void PlayerSpawned()
		{
		}

		// Token: 0x06004C1D RID: 19485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C1D")]
		[Address(RVA = "0x935B80", Offset = "0x934580", VA = "0x180935B80")]
		private void UpdateStaminaBar(float change)
		{
		}

		// Token: 0x06004C1E RID: 19486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C1E")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public StaminaBar()
		{
		}

		// Token: 0x06004C1F RID: 19487 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C1F")]
		[Address(RVA = "0x935B10", Offset = "0x934510", VA = "0x180935B10")]
		[CompilerGenerated]
		private IEnumerator <UpdateStaminaBar>g__Routine|7_0()
		{
			return null;
		}

		// Token: 0x0400371A RID: 14106
		[Token(Token = "0x400371A")]
		public const float StaminaShowTime = 1.5f;

		// Token: 0x0400371B RID: 14107
		[Token(Token = "0x400371B")]
		public const float StaminaFadeTime = 0.5f;

		// Token: 0x0400371C RID: 14108
		[Token(Token = "0x400371C")]
		[FieldOffset(Offset = "0x20")]
		[Header("References")]
		public Slider[] Sliders;

		// Token: 0x0400371D RID: 14109
		[Token(Token = "0x400371D")]
		[FieldOffset(Offset = "0x28")]
		public CanvasGroup Group;

		// Token: 0x0400371E RID: 14110
		[Token(Token = "0x400371E")]
		[FieldOffset(Offset = "0x30")]
		private Coroutine routine;
	}
}
