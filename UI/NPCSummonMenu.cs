using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.NPCs;
using UnityEngine;

namespace ScheduleOne.UI
{
	// Token: 0x02000ACC RID: 2764
	[Token(Token = "0x2000ACC")]
	public class NPCSummonMenu : Singleton<NPCSummonMenu>
	{
		// Token: 0x17000A8A RID: 2698
		// (get) Token: 0x06004B01 RID: 19201 RVA: 0x00013728 File Offset: 0x00011928
		// (set) Token: 0x06004B02 RID: 19202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A8A")]
		public bool IsOpen
		{
			[Token(Token = "0x6004B01")]
			[Address(RVA = "0x4B7C30", Offset = "0x4B6630", VA = "0x1804B7C30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004B02")]
			[Address(RVA = "0x4B7C40", Offset = "0x4B6640", VA = "0x1804B7C40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06004B03 RID: 19203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B03")]
		[Address(RVA = "0x920210", Offset = "0x91EC10", VA = "0x180920210", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x06004B04 RID: 19204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B04")]
		[Address(RVA = "0x91FB80", Offset = "0x91E580", VA = "0x18091FB80")]
		private void Exit(ExitAction exit)
		{
		}

		// Token: 0x06004B05 RID: 19205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B05")]
		[Address(RVA = "0x91FC10", Offset = "0x91E610", VA = "0x18091FC10")]
		public void Open(List<NPC> npcs, Action<NPC> _callback)
		{
		}

		// Token: 0x06004B06 RID: 19206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B06")]
		[Address(RVA = "0x91F930", Offset = "0x91E330", VA = "0x18091F930")]
		public void Close()
		{
		}

		// Token: 0x06004B07 RID: 19207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B07")]
		[Address(RVA = "0x91FBD0", Offset = "0x91E5D0", VA = "0x18091FBD0")]
		public void NPCSelected(NPC npc)
		{
		}

		// Token: 0x06004B08 RID: 19208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B08")]
		[Address(RVA = "0x920300", Offset = "0x91ED00", VA = "0x180920300")]
		public NPCSummonMenu()
		{
		}

		// Token: 0x040035FA RID: 13818
		[Token(Token = "0x40035FA")]
		[FieldOffset(Offset = "0x30")]
		[Header("References")]
		public Canvas Canvas;

		// Token: 0x040035FB RID: 13819
		[Token(Token = "0x40035FB")]
		[FieldOffset(Offset = "0x38")]
		public RectTransform Container;

		// Token: 0x040035FC RID: 13820
		[Token(Token = "0x40035FC")]
		[FieldOffset(Offset = "0x40")]
		public RectTransform EntryContainer;

		// Token: 0x040035FD RID: 13821
		[Token(Token = "0x40035FD")]
		[FieldOffset(Offset = "0x48")]
		public RectTransform[] Entries;

		// Token: 0x040035FE RID: 13822
		[Token(Token = "0x40035FE")]
		[FieldOffset(Offset = "0x50")]
		private Action<NPC> callback;
	}
}
