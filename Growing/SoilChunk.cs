using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.PlayerTasks;
using UnityEngine;

namespace ScheduleOne.Growing
{
	// Token: 0x0200092F RID: 2351
	[Token(Token = "0x200092F")]
	public class SoilChunk : Clickable
	{
		// Token: 0x17000901 RID: 2305
		// (get) Token: 0x0600404B RID: 16459 RVA: 0x000110B8 File Offset: 0x0000F2B8
		// (set) Token: 0x0600404C RID: 16460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000901")]
		public float CurrentLerp
		{
			[Token(Token = "0x600404B")]
			[Address(RVA = "0x4E8A80", Offset = "0x4E7480", VA = "0x1804E8A80")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600404C")]
			[Address(RVA = "0x6FF890", Offset = "0x6FE290", VA = "0x1806FF890")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x0600404D RID: 16461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600404D")]
		[Address(RVA = "0x875660", Offset = "0x874060", VA = "0x180875660", Slot = "8")]
		protected virtual void Awake()
		{
		}

		// Token: 0x0600404E RID: 16462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600404E")]
		[Address(RVA = "0x875710", Offset = "0x874110", VA = "0x180875710")]
		public void SetLerpedTransform(float _lerp)
		{
		}

		// Token: 0x0600404F RID: 16463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600404F")]
		[Address(RVA = "0x875A10", Offset = "0x874410", VA = "0x180875A10", Slot = "6")]
		public override void StartClick(RaycastHit hit)
		{
		}

		// Token: 0x06004050 RID: 16464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004050")]
		[Address(RVA = "0x875AF0", Offset = "0x8744F0", VA = "0x180875AF0")]
		public void StopLerp()
		{
		}

		// Token: 0x06004051 RID: 16465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004051")]
		[Address(RVA = "0x875B80", Offset = "0x874580", VA = "0x180875B80")]
		public SoilChunk()
		{
		}

		// Token: 0x06004052 RID: 16466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004052")]
		[Address(RVA = "0x875B10", Offset = "0x874510", VA = "0x180875B10")]
		[CompilerGenerated]
		private IEnumerator <StartClick>g__Lerp|12_0()
		{
			return null;
		}

		// Token: 0x04002D33 RID: 11571
		[Token(Token = "0x4002D33")]
		[FieldOffset(Offset = "0x58")]
		public Transform EndTransform;

		// Token: 0x04002D34 RID: 11572
		[Token(Token = "0x4002D34")]
		[FieldOffset(Offset = "0x60")]
		public float LerpTime;

		// Token: 0x04002D35 RID: 11573
		[Token(Token = "0x4002D35")]
		[FieldOffset(Offset = "0x64")]
		private Vector3 localPos_Start;

		// Token: 0x04002D36 RID: 11574
		[Token(Token = "0x4002D36")]
		[FieldOffset(Offset = "0x70")]
		private Vector3 localEulerAngles_Start;

		// Token: 0x04002D37 RID: 11575
		[Token(Token = "0x4002D37")]
		[FieldOffset(Offset = "0x7C")]
		private Vector3 localScale_Start;

		// Token: 0x04002D38 RID: 11576
		[Token(Token = "0x4002D38")]
		[FieldOffset(Offset = "0x88")]
		private Coroutine lerpRoutine;
	}
}
