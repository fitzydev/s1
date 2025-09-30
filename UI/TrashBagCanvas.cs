using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.UI.Input;
using UnityEngine;

namespace ScheduleOne.UI
{
	// Token: 0x02000B11 RID: 2833
	[Token(Token = "0x2000B11")]
	public class TrashBagCanvas : Singleton<TrashBagCanvas>
	{
		// Token: 0x17000ACF RID: 2767
		// (get) Token: 0x06004CDB RID: 19675 RVA: 0x00013CE0 File Offset: 0x00011EE0
		// (set) Token: 0x06004CDC RID: 19676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000ACF")]
		public bool IsOpen
		{
			[Token(Token = "0x6004CDB")]
			[Address(RVA = "0x4B7C30", Offset = "0x4B6630", VA = "0x1804B7C30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004CDC")]
			[Address(RVA = "0x4B7C40", Offset = "0x4B6640", VA = "0x1804B7C40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06004CDD RID: 19677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CDD")]
		[Address(RVA = "0x939070", Offset = "0x937A70", VA = "0x180939070")]
		public void Open()
		{
		}

		// Token: 0x06004CDE RID: 19678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CDE")]
		[Address(RVA = "0x939040", Offset = "0x937A40", VA = "0x180939040")]
		public void Close()
		{
		}

		// Token: 0x06004CDF RID: 19679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CDF")]
		[Address(RVA = "0x9390A0", Offset = "0x937AA0", VA = "0x1809390A0")]
		public TrashBagCanvas()
		{
		}

		// Token: 0x040037B8 RID: 14264
		[Token(Token = "0x40037B8")]
		[FieldOffset(Offset = "0x30")]
		[Header("References")]
		public Canvas Canvas;

		// Token: 0x040037B9 RID: 14265
		[Token(Token = "0x40037B9")]
		[FieldOffset(Offset = "0x38")]
		public InputPrompt InputPrompt;
	}
}
