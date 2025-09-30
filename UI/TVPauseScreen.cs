using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.TV;
using UnityEngine;

namespace ScheduleOne.UI
{
	// Token: 0x02000A6C RID: 2668
	[Token(Token = "0x2000A6C")]
	public class TVPauseScreen : MonoBehaviour
	{
		// Token: 0x17000A2F RID: 2607
		// (get) Token: 0x0600489E RID: 18590 RVA: 0x00012FD8 File Offset: 0x000111D8
		// (set) Token: 0x0600489F RID: 18591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A2F")]
		public bool IsPaused
		{
			[Token(Token = "0x600489E")]
			[Address(RVA = "0x4B9020", Offset = "0x4B7A20", VA = "0x1804B9020")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600489F")]
			[Address(RVA = "0x4B9030", Offset = "0x4B7A30", VA = "0x1804B9030")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060048A0 RID: 18592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048A0")]
		[Address(RVA = "0x90DF80", Offset = "0x90C980", VA = "0x18090DF80")]
		private void Awake()
		{
		}

		// Token: 0x060048A1 RID: 18593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048A1")]
		[Address(RVA = "0x90E050", Offset = "0x90CA50", VA = "0x18090E050")]
		private void Exit(ExitAction action)
		{
		}

		// Token: 0x060048A2 RID: 18594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048A2")]
		[Address(RVA = "0x90E0C0", Offset = "0x90CAC0", VA = "0x18090E0C0")]
		public void Pause()
		{
		}

		// Token: 0x060048A3 RID: 18595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048A3")]
		[Address(RVA = "0x90E0F0", Offset = "0x90CAF0", VA = "0x18090E0F0")]
		public void Resume()
		{
		}

		// Token: 0x060048A4 RID: 18596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048A4")]
		[Address(RVA = "0x90E020", Offset = "0x90CA20", VA = "0x18090E020")]
		public void Back()
		{
		}

		// Token: 0x060048A5 RID: 18597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048A5")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public TVPauseScreen()
		{
		}

		// Token: 0x04003396 RID: 13206
		[Token(Token = "0x4003396")]
		[FieldOffset(Offset = "0x28")]
		public TVApp App;
	}
}
