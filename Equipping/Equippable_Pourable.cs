using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.ObjectScripts;
using ScheduleOne.PlayerTasks;
using UnityEngine;

namespace ScheduleOne.Equipping
{
	// Token: 0x020009CD RID: 2509
	[Token(Token = "0x20009CD")]
	public class Equippable_Pourable : Equippable_Viewmodel
	{
		// Token: 0x17000985 RID: 2437
		// (get) Token: 0x06004483 RID: 17539 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004484 RID: 17540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000985")]
		public virtual string InteractionLabel
		{
			[Token(Token = "0x6004483")]
			[Address(RVA = "0x4573D0", Offset = "0x455DD0", VA = "0x1804573D0", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004484")]
			[Address(RVA = "0x5FD1C0", Offset = "0x5FBBC0", VA = "0x1805FD1C0", Slot = "12")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06004485 RID: 17541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004485")]
		[Address(RVA = "0x8B9D00", Offset = "0x8B8700", VA = "0x1808B9D00", Slot = "6")]
		protected override void Update()
		{
		}

		// Token: 0x06004486 RID: 17542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004486")]
		[Address(RVA = "0x8B9C90", Offset = "0x8B8690", VA = "0x1808B9C90", Slot = "13")]
		protected virtual void StartPourTask(Pot pot)
		{
		}

		// Token: 0x06004487 RID: 17543 RVA: 0x00011F40 File Offset: 0x00010140
		[Token(Token = "0x6004487")]
		[Address(RVA = "0x8B9C40", Offset = "0x8B8640", VA = "0x1808B9C40", Slot = "14")]
		protected virtual bool CanPour(Pot pot, out string reason)
		{
			return default(bool);
		}

		// Token: 0x06004488 RID: 17544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004488")]
		[Address(RVA = "0x8BA130", Offset = "0x8B8B30", VA = "0x1808BA130")]
		public Equippable_Pourable()
		{
		}

		// Token: 0x04003004 RID: 12292
		[Token(Token = "0x4003004")]
		[FieldOffset(Offset = "0x70")]
		[Header("Pourable settings")]
		public float InteractionRange;

		// Token: 0x04003005 RID: 12293
		[Token(Token = "0x4003005")]
		[FieldOffset(Offset = "0x78")]
		public Pourable PourablePrefab;
	}
}
