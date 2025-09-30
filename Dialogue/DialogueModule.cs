using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Dialogue
{
	// Token: 0x02000644 RID: 1604
	[Token(Token = "0x2000644")]
	public class DialogueModule : MonoBehaviour
	{
		// Token: 0x0600275D RID: 10077 RVA: 0x0000C2E8 File Offset: 0x0000A4E8
		[Token(Token = "0x600275D")]
		[Address(RVA = "0x6F5870", Offset = "0x6F4270", VA = "0x1806F5870")]
		public Entry GetEntry(string key)
		{
			return default(Entry);
		}

		// Token: 0x0600275E RID: 10078 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600275E")]
		[Address(RVA = "0x6F5790", Offset = "0x6F4190", VA = "0x1806F5790")]
		public DialogueChain GetChain(string key)
		{
			return null;
		}

		// Token: 0x0600275F RID: 10079 RVA: 0x0000C300 File Offset: 0x0000A500
		[Token(Token = "0x600275F")]
		[Address(RVA = "0x6F5A80", Offset = "0x6F4480", VA = "0x1806F5A80")]
		public bool HasChain(string key)
		{
			return default(bool);
		}

		// Token: 0x06002760 RID: 10080 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002760")]
		[Address(RVA = "0x6F5970", Offset = "0x6F4370", VA = "0x1806F5970")]
		public string GetLine(string key)
		{
			return null;
		}

		// Token: 0x06002761 RID: 10081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002761")]
		[Address(RVA = "0x6F5AB0", Offset = "0x6F44B0", VA = "0x1806F5AB0")]
		public DialogueModule()
		{
		}

		// Token: 0x04001E20 RID: 7712
		[Token(Token = "0x4001E20")]
		[FieldOffset(Offset = "0x20")]
		public EDialogueModule ModuleType;

		// Token: 0x04001E21 RID: 7713
		[Token(Token = "0x4001E21")]
		[FieldOffset(Offset = "0x28")]
		public List<Entry> Entries;
	}
}
