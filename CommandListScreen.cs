using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.UI.MainMenu;
using UnityEngine;

namespace ScheduleOne
{
	// Token: 0x02000291 RID: 657
	[Token(Token = "0x2000291")]
	public class CommandListScreen : MainMenuScreen
	{
		// Token: 0x06000DC6 RID: 3526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DC6")]
		[Address(RVA = "0xA9F970", Offset = "0xA9E370", VA = "0x180A9F970")]
		private void Start()
		{
		}

		// Token: 0x06000DC7 RID: 3527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DC7")]
		[Address(RVA = "0xA9FDF0", Offset = "0xA9E7F0", VA = "0x180A9FDF0")]
		public CommandListScreen()
		{
		}

		// Token: 0x04000DED RID: 3565
		[Token(Token = "0x4000DED")]
		[FieldOffset(Offset = "0x50")]
		public RectTransform CommandEntryContainer;

		// Token: 0x04000DEE RID: 3566
		[Token(Token = "0x4000DEE")]
		[FieldOffset(Offset = "0x58")]
		public RectTransform CommandEntryPrefab;

		// Token: 0x04000DEF RID: 3567
		[Token(Token = "0x4000DEF")]
		[FieldOffset(Offset = "0x60")]
		private List<RectTransform> commandEntries;
	}
}
