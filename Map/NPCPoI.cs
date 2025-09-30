using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.NPCs;

namespace ScheduleOne.Map
{
	// Token: 0x02000CFE RID: 3326
	[Token(Token = "0x2000CFE")]
	public class NPCPoI : POI
	{
		// Token: 0x17000D17 RID: 3351
		// (get) Token: 0x06005E11 RID: 24081 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005E12 RID: 24082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000D17")]
		public NPC NPC
		{
			[Token(Token = "0x6005E11")]
			[Address(RVA = "0x506BA0", Offset = "0x5055A0", VA = "0x180506BA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005E12")]
			[Address(RVA = "0x592AE0", Offset = "0x5914E0", VA = "0x180592AE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06005E13 RID: 24083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E13")]
		[Address(RVA = "0xA612F0", Offset = "0xA5FCF0", VA = "0x180A612F0", Slot = "5")]
		public override void InitializeUI()
		{
		}

		// Token: 0x06005E14 RID: 24084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E14")]
		[Address(RVA = "0xA61400", Offset = "0xA5FE00", VA = "0x180A61400")]
		public void SetNPC(NPC npc)
		{
		}

		// Token: 0x06005E15 RID: 24085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E15")]
		[Address(RVA = "0xA61520", Offset = "0xA5FF20", VA = "0x180A61520")]
		public NPCPoI()
		{
		}
	}
}
