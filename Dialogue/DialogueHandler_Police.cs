using System;
using Il2CppDummyDll;
using ScheduleOne.Police;
using UnityEngine;

namespace ScheduleOne.Dialogue
{
	// Token: 0x0200063E RID: 1598
	[Token(Token = "0x200063E")]
	public class DialogueHandler_Police : ControlledDialogueHandler
	{
		// Token: 0x06002748 RID: 10056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002748")]
		[Address(RVA = "0x6F38F0", Offset = "0x6F22F0", VA = "0x1806F38F0", Slot = "4")]
		protected override void Awake()
		{
		}

		// Token: 0x06002749 RID: 10057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002749")]
		[Address(RVA = "0x42DA80", Offset = "0x42C480", VA = "0x18042DA80", Slot = "17")]
		public override void Hovered()
		{
		}

		// Token: 0x0600274A RID: 10058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600274A")]
		[Address(RVA = "0x6F3D60", Offset = "0x6F2760", VA = "0x1806F3D60", Slot = "18")]
		public override void Interacted()
		{
		}

		// Token: 0x0600274B RID: 10059 RVA: 0x0000C240 File Offset: 0x0000A440
		[Token(Token = "0x600274B")]
		[Address(RVA = "0x6F3A20", Offset = "0x6F2420", VA = "0x1806F3A20")]
		private bool CanTalk_Checkpoint()
		{
			return default(bool);
		}

		// Token: 0x0600274C RID: 10060 RVA: 0x0000C258 File Offset: 0x0000A458
		[Token(Token = "0x600274C")]
		[Address(RVA = "0x6F3B70", Offset = "0x6F2570", VA = "0x1806F3B70", Slot = "11")]
		protected override int CheckBranch(string branchLabel)
		{
			return 0;
		}

		// Token: 0x0600274D RID: 10061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600274D")]
		[Address(RVA = "0x6E8600", Offset = "0x6E7000", VA = "0x1806E8600")]
		public DialogueHandler_Police()
		{
		}

		// Token: 0x04001E17 RID: 7703
		[Token(Token = "0x4001E17")]
		[FieldOffset(Offset = "0xB8")]
		[Header("References")]
		public DialogueContainer CheckpointRequestDialogue;

		// Token: 0x04001E18 RID: 7704
		[Token(Token = "0x4001E18")]
		[FieldOffset(Offset = "0xC0")]
		private PoliceOfficer officer;
	}
}
