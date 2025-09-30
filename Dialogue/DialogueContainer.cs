using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Dialogue
{
	// Token: 0x0200064A RID: 1610
	[Token(Token = "0x200064A")]
	[Serializable]
	public class DialogueContainer : ScriptableObject
	{
		// Token: 0x17000657 RID: 1623
		// (get) Token: 0x06002768 RID: 10088 RVA: 0x0000C330 File Offset: 0x0000A530
		// (set) Token: 0x06002769 RID: 10089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000657")]
		public bool allowExit
		{
			[Token(Token = "0x6002768")]
			[Address(RVA = "0x4A3720", Offset = "0x4A2120", VA = "0x1804A3720")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002769")]
			[Address(RVA = "0x6A5700", Offset = "0x6A4100", VA = "0x1806A5700")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000658 RID: 1624
		// (get) Token: 0x0600276A RID: 10090 RVA: 0x0000C348 File Offset: 0x0000A548
		[Token(Token = "0x17000658")]
		public bool AllowExit
		{
			[Token(Token = "0x600276A")]
			[Address(RVA = "0x6E93D0", Offset = "0x6E7DD0", VA = "0x1806E93D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600276B RID: 10091 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600276B")]
		[Address(RVA = "0x6E9100", Offset = "0x6E7B00", VA = "0x1806E9100")]
		public DialogueNodeData GetDialogueNodeByLabel(string dialogueNodeLabel)
		{
			return null;
		}

		// Token: 0x0600276C RID: 10092 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600276C")]
		[Address(RVA = "0x6E8F40", Offset = "0x6E7940", VA = "0x1806E8F40")]
		public BranchNodeData GetBranchNodeByLabel(string branchLabel)
		{
			return null;
		}

		// Token: 0x0600276D RID: 10093 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600276D")]
		[Address(RVA = "0x6E9020", Offset = "0x6E7A20", VA = "0x1806E9020")]
		public DialogueNodeData GetDialogueNodeByGUID(string dialogueNodeGUID)
		{
			return null;
		}

		// Token: 0x0600276E RID: 10094 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600276E")]
		[Address(RVA = "0x6E8E60", Offset = "0x6E7860", VA = "0x1806E8E60")]
		public BranchNodeData GetBranchNodeByGUID(string branchGUID)
		{
			return null;
		}

		// Token: 0x0600276F RID: 10095 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600276F")]
		[Address(RVA = "0x6E91E0", Offset = "0x6E7BE0", VA = "0x1806E91E0")]
		public NodeLinkData GetLink(string baseChoiceOrOptionGUID)
		{
			return null;
		}

		// Token: 0x06002770 RID: 10096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002770")]
		[Address(RVA = "0x6A5700", Offset = "0x6A4100", VA = "0x1806A5700")]
		public void SetAllowExit(bool allowed)
		{
		}

		// Token: 0x06002771 RID: 10097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002771")]
		[Address(RVA = "0x6E92C0", Offset = "0x6E7CC0", VA = "0x1806E92C0")]
		public DialogueContainer()
		{
		}

		// Token: 0x04001E36 RID: 7734
		[Token(Token = "0x4001E36")]
		[FieldOffset(Offset = "0x20")]
		public List<NodeLinkData> NodeLinks;

		// Token: 0x04001E37 RID: 7735
		[Token(Token = "0x4001E37")]
		[FieldOffset(Offset = "0x28")]
		public List<DialogueNodeData> DialogueNodeData;

		// Token: 0x04001E38 RID: 7736
		[Token(Token = "0x4001E38")]
		[FieldOffset(Offset = "0x30")]
		public List<BranchNodeData> BranchNodeData;
	}
}
