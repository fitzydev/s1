using System;
using Il2CppDummyDll;
using ScheduleOne.AvatarFramework;
using UnityEngine.Events;

namespace ScheduleOne.Cutscenes
{
	// Token: 0x02000792 RID: 1938
	[Token(Token = "0x2000792")]
	public class EndCutscene : Cutscene
	{
		// Token: 0x06003446 RID: 13382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003446")]
		[Address(RVA = "0x7A2010", Offset = "0x7A0A10", VA = "0x1807A2010", Slot = "5")]
		public override void Play()
		{
		}

		// Token: 0x06003447 RID: 13383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003447")]
		[Address(RVA = "0x7A20C0", Offset = "0x7A0AC0", VA = "0x1807A20C0")]
		public void StandUp()
		{
		}

		// Token: 0x06003448 RID: 13384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003448")]
		[Address(RVA = "0x7A20A0", Offset = "0x7A0AA0", VA = "0x1807A20A0")]
		public void RunStart()
		{
		}

		// Token: 0x06003449 RID: 13385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003449")]
		[Address(RVA = "0x7A1F70", Offset = "0x7A0970", VA = "0x1807A1F70")]
		public void EngineStart()
		{
		}

		// Token: 0x0600344A RID: 13386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600344A")]
		[Address(RVA = "0x7A1F90", Offset = "0x7A0990", VA = "0x1807A1F90")]
		public void On3rdPerson()
		{
		}

		// Token: 0x0600344B RID: 13387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600344B")]
		[Address(RVA = "0x79F400", Offset = "0x79DE00", VA = "0x18079F400")]
		public EndCutscene()
		{
		}

		// Token: 0x0400245E RID: 9310
		[Token(Token = "0x400245E")]
		[FieldOffset(Offset = "0x58")]
		public UnityEvent onStandUp;

		// Token: 0x0400245F RID: 9311
		[Token(Token = "0x400245F")]
		[FieldOffset(Offset = "0x60")]
		public UnityEvent onRunStart;

		// Token: 0x04002460 RID: 9312
		[Token(Token = "0x4002460")]
		[FieldOffset(Offset = "0x68")]
		public UnityEvent onEngineStart;

		// Token: 0x04002461 RID: 9313
		[Token(Token = "0x4002461")]
		[FieldOffset(Offset = "0x70")]
		public Avatar Avatar;
	}
}
