using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Lighting
{
	// Token: 0x02000519 RID: 1305
	[Token(Token = "0x2000519")]
	[RequireComponent(typeof(ReflectionProbe))]
	public class ReflectionProbeUpdater : MonoBehaviour
	{
		// Token: 0x06001A8A RID: 6794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A8A")]
		[Address(RVA = "0x64C1A0", Offset = "0x64ABA0", VA = "0x18064C1A0")]
		private void OnValidate()
		{
		}

		// Token: 0x06001A8B RID: 6795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A8B")]
		[Address(RVA = "0x64C280", Offset = "0x64AC80", VA = "0x18064C280")]
		private void Start()
		{
		}

		// Token: 0x06001A8C RID: 6796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A8C")]
		[Address(RVA = "0x64C5C0", Offset = "0x64AFC0", VA = "0x18064C5C0")]
		private void UpdateProbe()
		{
		}

		// Token: 0x06001A8D RID: 6797 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A8D")]
		[Address(RVA = "0x64C230", Offset = "0x64AC30", VA = "0x18064C230")]
		private IEnumerator ProcessQueue()
		{
			return null;
		}

		// Token: 0x06001A8E RID: 6798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A8E")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public ReflectionProbeUpdater()
		{
		}

		// Token: 0x040016E5 RID: 5861
		[Token(Token = "0x40016E5")]
		[FieldOffset(Offset = "0x20")]
		public ReflectionProbe Probe;

		// Token: 0x040016E6 RID: 5862
		[Token(Token = "0x40016E6")]
		[FieldOffset(Offset = "0x0")]
		private static List<ReflectionProbe> renderQueue;

		// Token: 0x040016E7 RID: 5863
		[Token(Token = "0x40016E7")]
		[FieldOffset(Offset = "0x8")]
		private static Coroutine RenderRoutine;
	}
}
