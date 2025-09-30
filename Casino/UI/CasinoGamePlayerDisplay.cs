using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace ScheduleOne.Casino.UI
{
	// Token: 0x020007ED RID: 2029
	[Token(Token = "0x20007ED")]
	public class CasinoGamePlayerDisplay : MonoBehaviour
	{
		// Token: 0x0600374C RID: 14156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600374C")]
		[Address(RVA = "0x7E40E0", Offset = "0x7E2AE0", VA = "0x1807E40E0")]
		public void RefreshPlayers()
		{
		}

		// Token: 0x0600374D RID: 14157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600374D")]
		[Address(RVA = "0x7E45A0", Offset = "0x7E2FA0", VA = "0x1807E45A0")]
		public void RefreshScores()
		{
		}

		// Token: 0x0600374E RID: 14158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600374E")]
		[Address(RVA = "0x7E3FD0", Offset = "0x7E29D0", VA = "0x1807E3FD0")]
		public void Bind(CasinoGamePlayers players)
		{
		}

		// Token: 0x0600374F RID: 14159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600374F")]
		[Address(RVA = "0x7E4730", Offset = "0x7E3130", VA = "0x1807E4730")]
		public void Unbind()
		{
		}

		// Token: 0x06003750 RID: 14160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003750")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public CasinoGamePlayerDisplay()
		{
		}

		// Token: 0x0400268E RID: 9870
		[Token(Token = "0x400268E")]
		[FieldOffset(Offset = "0x20")]
		public CasinoGamePlayers BindedPlayers;

		// Token: 0x0400268F RID: 9871
		[Token(Token = "0x400268F")]
		[FieldOffset(Offset = "0x28")]
		[Header("References")]
		public TextMeshProUGUI TitleLabel;

		// Token: 0x04002690 RID: 9872
		[Token(Token = "0x4002690")]
		[FieldOffset(Offset = "0x30")]
		public RectTransform[] PlayerEntries;
	}
}
