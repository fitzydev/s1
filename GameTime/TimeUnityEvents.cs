using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.GameTime
{
	// Token: 0x020002C3 RID: 707
	[Token(Token = "0x20002C3")]
	public class TimeUnityEvents : MonoBehaviour
	{
		// Token: 0x06000F38 RID: 3896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F38")]
		[Address(RVA = "0xACE500", Offset = "0xACCF00", VA = "0x180ACE500")]
		private void Start()
		{
		}

		// Token: 0x06000F39 RID: 3897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F39")]
		[Address(RVA = "0x5C9DE0", Offset = "0x5C87E0", VA = "0x1805C9DE0")]
		private void HourPass()
		{
		}

		// Token: 0x06000F3A RID: 3898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F3A")]
		[Address(RVA = "0x5D52A0", Offset = "0x5D3CA0", VA = "0x1805D52A0")]
		private void DayPass()
		{
		}

		// Token: 0x06000F3B RID: 3899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F3B")]
		[Address(RVA = "0x5D5280", Offset = "0x5D3C80", VA = "0x1805D5280")]
		private void SleepStart()
		{
		}

		// Token: 0x06000F3C RID: 3900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F3C")]
		[Address(RVA = "0xACE4E0", Offset = "0xACCEE0", VA = "0x180ACE4E0")]
		private void SleepEnd()
		{
		}

		// Token: 0x06000F3D RID: 3901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F3D")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public TimeUnityEvents()
		{
		}

		// Token: 0x04000F44 RID: 3908
		[Token(Token = "0x4000F44")]
		[FieldOffset(Offset = "0x20")]
		public UnityEvent onHourPass;

		// Token: 0x04000F45 RID: 3909
		[Token(Token = "0x4000F45")]
		[FieldOffset(Offset = "0x28")]
		public UnityEvent onDayPass;

		// Token: 0x04000F46 RID: 3910
		[Token(Token = "0x4000F46")]
		[FieldOffset(Offset = "0x30")]
		public UnityEvent onSleepStart;

		// Token: 0x04000F47 RID: 3911
		[Token(Token = "0x4000F47")]
		[FieldOffset(Offset = "0x38")]
		public UnityEvent onSleepEnd;
	}
}
