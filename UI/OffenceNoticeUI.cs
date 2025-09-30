using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.Police;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x02000AE6 RID: 2790
	[Token(Token = "0x2000AE6")]
	public class OffenceNoticeUI : Singleton<OffenceNoticeUI>
	{
		// Token: 0x06004BCF RID: 19407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BCF")]
		[Address(RVA = "0x92DDC0", Offset = "0x92C7C0", VA = "0x18092DDC0")]
		public void ShowOffenceNotice(Offense offence)
		{
		}

		// Token: 0x06004BD0 RID: 19408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BD0")]
		[Address(RVA = "0x92E1A0", Offset = "0x92CBA0", VA = "0x18092E1A0")]
		protected void Update()
		{
		}

		// Token: 0x06004BD1 RID: 19409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BD1")]
		[Address(RVA = "0x92E350", Offset = "0x92CD50", VA = "0x18092E350")]
		public OffenceNoticeUI()
		{
		}

		// Token: 0x040036CC RID: 14028
		[Token(Token = "0x40036CC")]
		[FieldOffset(Offset = "0x28")]
		[Header("References")]
		[SerializeField]
		protected GameObject container;

		// Token: 0x040036CD RID: 14029
		[Token(Token = "0x40036CD")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected List<Text> charges;

		// Token: 0x040036CE RID: 14030
		[Token(Token = "0x40036CE")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		protected List<Text> penalties;
	}
}
