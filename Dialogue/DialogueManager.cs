using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;

namespace ScheduleOne.Dialogue
{
	// Token: 0x02000642 RID: 1602
	[Token(Token = "0x2000642")]
	public class DialogueManager : Singleton<DialogueManager>
	{
		// Token: 0x06002759 RID: 10073 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002759")]
		[Address(RVA = "0x6F5570", Offset = "0x6F3F70", VA = "0x1806F5570")]
		public DialogueModule Get(EDialogueModule moduleType)
		{
			return null;
		}

		// Token: 0x0600275A RID: 10074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600275A")]
		[Address(RVA = "0x6F5700", Offset = "0x6F4100", VA = "0x1806F5700")]
		public DialogueManager()
		{
		}

		// Token: 0x04001E1D RID: 7709
		[Token(Token = "0x4001E1D")]
		[FieldOffset(Offset = "0x28")]
		public DialogueDatabase DefaultDatabase;

		// Token: 0x04001E1E RID: 7710
		[Token(Token = "0x4001E1E")]
		[FieldOffset(Offset = "0x30")]
		public List<DialogueModule> DefaultModules;
	}
}
