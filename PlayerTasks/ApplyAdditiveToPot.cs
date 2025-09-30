using System;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using ScheduleOne.ObjectScripts;
using ScheduleOne.PlayerTasks.Tasks;

namespace ScheduleOne.PlayerTasks
{
	// Token: 0x02000354 RID: 852
	[Token(Token = "0x2000354")]
	public class ApplyAdditiveToPot : PourIntoPotTask
	{
		// Token: 0x17000392 RID: 914
		// (get) Token: 0x060012D6 RID: 4822 RVA: 0x00007FE0 File Offset: 0x000061E0
		[Token(Token = "0x17000392")]
		protected override bool UseCoverage
		{
			[Token(Token = "0x60012D6")]
			[Address(RVA = "0x48DCC0", Offset = "0x48C6C0", VA = "0x18048DCC0", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000393 RID: 915
		// (get) Token: 0x060012D7 RID: 4823 RVA: 0x00007FF8 File Offset: 0x000061F8
		[Token(Token = "0x17000393")]
		protected override Pot.ECameraPosition CameraPosition
		{
			[Token(Token = "0x60012D7")]
			[Address(RVA = "0x58DD70", Offset = "0x58C770", VA = "0x18058DD70", Slot = "16")]
			get
			{
				return Pot.ECameraPosition.Closeup;
			}
		}

		// Token: 0x060012D8 RID: 4824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012D8")]
		[Address(RVA = "0x58DB30", Offset = "0x58C530", VA = "0x18058DB30")]
		public ApplyAdditiveToPot(Pot _pot, ItemInstance _itemInstance, Pourable _pourablePrefab)
		{
		}

		// Token: 0x060012D9 RID: 4825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012D9")]
		[Address(RVA = "0x58D950", Offset = "0x58C350", VA = "0x18058D950", Slot = "9")]
		public override void Update()
		{
		}

		// Token: 0x060012DA RID: 4826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012DA")]
		[Address(RVA = "0x58D850", Offset = "0x58C250", VA = "0x18058D850", Slot = "17")]
		protected override void FullyCovered()
		{
		}

		// Token: 0x04001206 RID: 4614
		[Token(Token = "0x4001206")]
		[FieldOffset(Offset = "0xC8")]
		private AdditiveDefinition def;
	}
}
