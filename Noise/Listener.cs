using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Noise
{
	// Token: 0x0200049E RID: 1182
	[Token(Token = "0x200049E")]
	public class Listener : MonoBehaviour
	{
		// Token: 0x1700042F RID: 1071
		// (get) Token: 0x06001723 RID: 5923 RVA: 0x00008AA8 File Offset: 0x00006CA8
		// (set) Token: 0x06001724 RID: 5924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700042F")]
		public float SquaredHearingRange
		{
			[Token(Token = "0x6001723")]
			[Address(RVA = "0x4A37D0", Offset = "0x4A21D0", VA = "0x1804A37D0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6001724")]
			[Address(RVA = "0x4A4D10", Offset = "0x4A3710", VA = "0x1804A4D10")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06001725 RID: 5925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001725")]
		[Address(RVA = "0x5E95F0", Offset = "0x5E7FF0", VA = "0x1805E95F0")]
		public void Awake()
		{
		}

		// Token: 0x06001726 RID: 5926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001726")]
		[Address(RVA = "0x5E9720", Offset = "0x5E8120", VA = "0x1805E9720")]
		public void OnEnable()
		{
		}

		// Token: 0x06001727 RID: 5927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001727")]
		[Address(RVA = "0x5E96A0", Offset = "0x5E80A0", VA = "0x1805E96A0")]
		public void OnDisable()
		{
		}

		// Token: 0x06001728 RID: 5928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001728")]
		[Address(RVA = "0x5E9680", Offset = "0x5E8080", VA = "0x1805E9680")]
		public void Notify(NoiseEvent nEvent)
		{
		}

		// Token: 0x06001729 RID: 5929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001729")]
		[Address(RVA = "0x583E00", Offset = "0x582800", VA = "0x180583E00")]
		public Listener()
		{
		}

		// Token: 0x0400152D RID: 5421
		[Token(Token = "0x400152D")]
		[FieldOffset(Offset = "0x0")]
		public static List<Listener> listeners;

		// Token: 0x0400152E RID: 5422
		[Token(Token = "0x400152E")]
		[FieldOffset(Offset = "0x20")]
		[Range(0.1f, 5f)]
		[Header("Settings")]
		public float Sensitivity;

		// Token: 0x0400152F RID: 5423
		[Token(Token = "0x400152F")]
		[FieldOffset(Offset = "0x28")]
		public Transform HearingOrigin;

		// Token: 0x04001531 RID: 5425
		[Token(Token = "0x4001531")]
		[FieldOffset(Offset = "0x38")]
		public Listener.HearingEvent onNoiseHeard;

		// Token: 0x0200049F RID: 1183
		// (Invoke) Token: 0x0600172C RID: 5932
		[Token(Token = "0x200049F")]
		public delegate void HearingEvent(NoiseEvent nEvent);
	}
}
