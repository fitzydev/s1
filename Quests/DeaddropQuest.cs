using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Economy;
using ScheduleOne.Persistence.Datas;

namespace ScheduleOne.Quests
{
	// Token: 0x020002F0 RID: 752
	[Token(Token = "0x20002F0")]
	public class DeaddropQuest : Quest
	{
		// Token: 0x17000373 RID: 883
		// (get) Token: 0x060010F0 RID: 4336 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060010F1 RID: 4337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000373")]
		public DeadDrop Drop
		{
			[Token(Token = "0x60010F0")]
			[Address(RVA = "0x672D50", Offset = "0x671750", VA = "0x180672D50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60010F1")]
			[Address(RVA = "0x672DF0", Offset = "0x6717F0", VA = "0x180672DF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060010F2 RID: 4338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010F2")]
		[Address(RVA = "0xAD37D0", Offset = "0xAD21D0", VA = "0x180AD37D0", Slot = "34")]
		public override void Begin(bool network = true)
		{
		}

		// Token: 0x060010F3 RID: 4339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010F3")]
		[Address(RVA = "0xAD3E50", Offset = "0xAD2850", VA = "0x180AD3E50")]
		public void SetDrop(DeadDrop drop)
		{
		}

		// Token: 0x060010F4 RID: 4340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010F4")]
		[Address(RVA = "0xAD3CC0", Offset = "0xAD26C0", VA = "0x180AD3CC0", Slot = "43")]
		protected override void MinPass()
		{
		}

		// Token: 0x060010F5 RID: 4341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010F5")]
		[Address(RVA = "0xAD3D80", Offset = "0xAD2780", VA = "0x180AD3D80")]
		private void OnDestroy()
		{
		}

		// Token: 0x060010F6 RID: 4342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010F6")]
		[Address(RVA = "0xAD3910", Offset = "0xAD2310", VA = "0x180AD3910", Slot = "39")]
		public override void End()
		{
		}

		// Token: 0x060010F7 RID: 4343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010F7")]
		[Address(RVA = "0xAD3FE0", Offset = "0xAD29E0", VA = "0x180AD3FE0", Slot = "40")]
		public override void SetQuestState(EQuestState state, bool network = true)
		{
		}

		// Token: 0x060010F8 RID: 4344 RVA: 0x00007CE0 File Offset: 0x00005EE0
		[Token(Token = "0x60010F8")]
		[Address(RVA = "0xAD40E0", Offset = "0xAD2AE0", VA = "0x180AD40E0", Slot = "53")]
		public override bool ShouldSave()
		{
			return default(bool);
		}

		// Token: 0x060010F9 RID: 4345 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010F9")]
		[Address(RVA = "0xAD39A0", Offset = "0xAD23A0", VA = "0x180AD39A0", Slot = "54")]
		public override SaveData GetSaveData()
		{
			return null;
		}

		// Token: 0x060010FA RID: 4346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010FA")]
		[Address(RVA = "0xAD4180", Offset = "0xAD2B80", VA = "0x180AD4180")]
		public DeaddropQuest()
		{
		}

		// Token: 0x040010D3 RID: 4307
		[Token(Token = "0x40010D3")]
		[FieldOffset(Offset = "0x0")]
		public static List<DeaddropQuest> DeaddropQuests;
	}
}
