using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.NPCs;
using ScheduleOne.Persistence.Datas;
using UnityEngine.Events;

namespace ScheduleOne.Management
{
	// Token: 0x020004E4 RID: 1252
	[Token(Token = "0x20004E4")]
	public class NPCField : ConfigField
	{
		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x0600194F RID: 6479 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001950 RID: 6480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700046F")]
		public NPC SelectedNPC
		{
			[Token(Token = "0x600194F")]
			[Address(RVA = "0x42FFB0", Offset = "0x42E9B0", VA = "0x18042FFB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001950")]
			[Address(RVA = "0x42FFE0", Offset = "0x42E9E0", VA = "0x18042FFE0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06001951 RID: 6481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001951")]
		[Address(RVA = "0x640D80", Offset = "0x63F780", VA = "0x180640D80")]
		public NPCField(EntityConfiguration parentConfig)
		{
		}

		// Token: 0x06001952 RID: 6482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001952")]
		[Address(RVA = "0x640CA0", Offset = "0x63F6A0", VA = "0x180640CA0")]
		public void SetNPC(NPC npc, bool network)
		{
		}

		// Token: 0x06001953 RID: 6483 RVA: 0x00009048 File Offset: 0x00007248
		[Token(Token = "0x6001953")]
		[Address(RVA = "0x640920", Offset = "0x63F320", VA = "0x180640920")]
		public bool DoesNPCMatchRequirement(NPC npc)
		{
			return default(bool);
		}

		// Token: 0x06001954 RID: 6484 RVA: 0x00009060 File Offset: 0x00007260
		[Token(Token = "0x6001954")]
		[Address(RVA = "0x640AC0", Offset = "0x63F4C0", VA = "0x180640AC0", Slot = "4")]
		public override bool IsValueDefault()
		{
			return default(bool);
		}

		// Token: 0x06001955 RID: 6485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001955")]
		[Address(RVA = "0x6409E0", Offset = "0x63F3E0", VA = "0x1806409E0")]
		public NPCFieldData GetData()
		{
			return null;
		}

		// Token: 0x06001956 RID: 6486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001956")]
		[Address(RVA = "0x640B10", Offset = "0x63F510", VA = "0x180640B10")]
		public void Load(NPCFieldData data)
		{
		}

		// Token: 0x04001641 RID: 5697
		[Token(Token = "0x4001641")]
		[FieldOffset(Offset = "0x20")]
		public Type TypeRequirement;

		// Token: 0x04001642 RID: 5698
		[Token(Token = "0x4001642")]
		[FieldOffset(Offset = "0x28")]
		public UnityEvent<NPC> onNPCChanged;
	}
}
