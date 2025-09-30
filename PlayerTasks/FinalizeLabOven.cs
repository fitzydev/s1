using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.ObjectScripts;
using UnityEngine;

namespace ScheduleOne.PlayerTasks
{
	// Token: 0x02000358 RID: 856
	[Token(Token = "0x2000358")]
	public class FinalizeLabOven : Task
	{
		// Token: 0x17000397 RID: 919
		// (get) Token: 0x060012F0 RID: 4848 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060012F1 RID: 4849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000397")]
		public LabOven Oven
		{
			[Token(Token = "0x60012F0")]
			[Address(RVA = "0x4DBC30", Offset = "0x4DA630", VA = "0x1804DBC30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60012F1")]
			[Address(RVA = "0x4DC750", Offset = "0x4DB150", VA = "0x1804DC750")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060012F2 RID: 4850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012F2")]
		[Address(RVA = "0x594C60", Offset = "0x593660", VA = "0x180594C60")]
		public FinalizeLabOven(LabOven oven)
		{
		}

		// Token: 0x060012F3 RID: 4851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012F3")]
		[Address(RVA = "0x594C20", Offset = "0x593620", VA = "0x180594C20", Slot = "9")]
		public override void Update()
		{
		}

		// Token: 0x060012F4 RID: 4852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012F4")]
		[Address(RVA = "0x5947C0", Offset = "0x5931C0", VA = "0x1805947C0", Slot = "6")]
		public override void StopTask()
		{
		}

		// Token: 0x060012F5 RID: 4853 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012F5")]
		[Address(RVA = "0x594750", Offset = "0x593150", VA = "0x180594750")]
		private IEnumerator StartSequence()
		{
			return null;
		}

		// Token: 0x060012F6 RID: 4854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012F6")]
		[Address(RVA = "0x594020", Offset = "0x592A20", VA = "0x180594020")]
		public void Collision(Collision col)
		{
		}

		// Token: 0x060012F7 RID: 4855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012F7")]
		[Address(RVA = "0x594470", Offset = "0x592E70", VA = "0x180594470")]
		private void Shatter()
		{
		}

		// Token: 0x060012F8 RID: 4856 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012F8")]
		[Address(RVA = "0x594BB0", Offset = "0x5935B0", VA = "0x180594BB0")]
		[CompilerGenerated]
		private IEnumerator <Shatter>g__Routine|17_0()
		{
			return null;
		}

		// Token: 0x04001214 RID: 4628
		[Token(Token = "0x4001214")]
		public const float MAX_DISTANCE_FROM_IMPACT_POINT = 0.1f;

		// Token: 0x04001215 RID: 4629
		[Token(Token = "0x4001215")]
		[FieldOffset(Offset = "0x98")]
		public float SMASH_VELOCITY_THRESHOLD;

		// Token: 0x04001216 RID: 4630
		[Token(Token = "0x4001216")]
		[FieldOffset(Offset = "0x9C")]
		public float SMASH_COOLDOWN;

		// Token: 0x04001217 RID: 4631
		[Token(Token = "0x4001217")]
		public const int REQUIRED_IMPACTS = 3;

		// Token: 0x04001219 RID: 4633
		[Token(Token = "0x4001219")]
		[FieldOffset(Offset = "0xA8")]
		private Coroutine startSequence;

		// Token: 0x0400121A RID: 4634
		[Token(Token = "0x400121A")]
		[FieldOffset(Offset = "0xB0")]
		private LabOvenHammer hammer;

		// Token: 0x0400121B RID: 4635
		[Token(Token = "0x400121B")]
		[FieldOffset(Offset = "0xB8")]
		private int impactCount;

		// Token: 0x0400121C RID: 4636
		[Token(Token = "0x400121C")]
		[FieldOffset(Offset = "0xBC")]
		private float timeSinceLastImpact;
	}
}
