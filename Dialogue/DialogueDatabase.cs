using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Dialogue
{
	// Token: 0x0200062E RID: 1582
	[Token(Token = "0x200062E")]
	[CreateAssetMenu(fileName = "New Dialogue Database", menuName = "Dialogue/Dialogue Database")]
	[Serializable]
	public class DialogueDatabase : ScriptableObject
	{
		// Token: 0x17000650 RID: 1616
		// (get) Token: 0x060026F1 RID: 9969 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000650")]
		private List<DialogueModule> runtimeModules
		{
			[Token(Token = "0x60026F1")]
			[Address(RVA = "0x555970", Offset = "0x554370", VA = "0x180555970")]
			get
			{
				return null;
			}
		}

		// Token: 0x060026F2 RID: 9970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026F2")]
		[Address(RVA = "0x4423F0", Offset = "0x440DF0", VA = "0x1804423F0")]
		public void Initialize(DialogueHandler _handler)
		{
		}

		// Token: 0x060026F3 RID: 9971 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026F3")]
		[Address(RVA = "0x6F0C70", Offset = "0x6EF670", VA = "0x1806F0C70")]
		public DialogueModule GetModule(EDialogueModule moduleType)
		{
			return null;
		}

		// Token: 0x060026F4 RID: 9972 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026F4")]
		[Address(RVA = "0x6F0860", Offset = "0x6EF260", VA = "0x1806F0860")]
		public DialogueChain GetChain(EDialogueModule moduleType, string key)
		{
			return null;
		}

		// Token: 0x060026F5 RID: 9973 RVA: 0x0000C060 File Offset: 0x0000A260
		[Token(Token = "0x60026F5")]
		[Address(RVA = "0x6F0F80", Offset = "0x6EF980", VA = "0x1806F0F80")]
		public bool HasChain(EDialogueModule moduleType, string key)
		{
			return default(bool);
		}

		// Token: 0x060026F6 RID: 9974 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026F6")]
		[Address(RVA = "0x6F0A40", Offset = "0x6EF440", VA = "0x1806F0A40")]
		public string GetLine(EDialogueModule moduleType, string key)
		{
			return null;
		}

		// Token: 0x060026F7 RID: 9975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026F7")]
		[Address(RVA = "0x6F10C0", Offset = "0x6EFAC0", VA = "0x1806F10C0")]
		public DialogueDatabase()
		{
		}

		// Token: 0x04001DE6 RID: 7654
		[Token(Token = "0x4001DE6")]
		[FieldOffset(Offset = "0x18")]
		public List<DialogueModule> Modules;

		// Token: 0x04001DE7 RID: 7655
		[Token(Token = "0x4001DE7")]
		[FieldOffset(Offset = "0x20")]
		public List<Entry> GenericEntries;

		// Token: 0x04001DE8 RID: 7656
		[Token(Token = "0x4001DE8")]
		[FieldOffset(Offset = "0x28")]
		private DialogueHandler handler;
	}
}
