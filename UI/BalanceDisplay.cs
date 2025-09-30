using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace ScheduleOne.UI
{
	// Token: 0x02000A6D RID: 2669
	[Token(Token = "0x2000A6D")]
	public class BalanceDisplay : MonoBehaviour
	{
		// Token: 0x17000A30 RID: 2608
		// (get) Token: 0x060048A6 RID: 18598 RVA: 0x00012FF0 File Offset: 0x000111F0
		// (set) Token: 0x060048A7 RID: 18599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A30")]
		public bool active
		{
			[Token(Token = "0x60048A6")]
			[Address(RVA = "0x4BE260", Offset = "0x4BCC60", VA = "0x1804BE260")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60048A7")]
			[Address(RVA = "0x4F3A70", Offset = "0x4F2470", VA = "0x1804F3A70")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000A31 RID: 2609
		// (get) Token: 0x060048A8 RID: 18600 RVA: 0x00013008 File Offset: 0x00011208
		// (set) Token: 0x060048A9 RID: 18601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A31")]
		public float timeSinceActiveSet
		{
			[Token(Token = "0x60048A8")]
			[Address(RVA = "0x4A37C0", Offset = "0x4A21C0", VA = "0x1804A37C0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60048A9")]
			[Address(RVA = "0x882010", Offset = "0x880A10", VA = "0x180882010")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x060048AA RID: 18602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048AA")]
		[Address(RVA = "0x8FC330", Offset = "0x8FAD30", VA = "0x1808FC330", Slot = "4")]
		protected virtual void Update()
		{
		}

		// Token: 0x060048AB RID: 18603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048AB")]
		[Address(RVA = "0x8FC2D0", Offset = "0x8FACD0", VA = "0x1808FC2D0")]
		public void SetBalance(float balance)
		{
		}

		// Token: 0x060048AC RID: 18604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048AC")]
		[Address(RVA = "0x8FC320", Offset = "0x8FAD20", VA = "0x1808FC320")]
		public void Show()
		{
		}

		// Token: 0x060048AD RID: 18605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048AD")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public BalanceDisplay()
		{
		}

		// Token: 0x04003397 RID: 13207
		[Token(Token = "0x4003397")]
		public const float RESIDUAL_TIME = 3f;

		// Token: 0x04003398 RID: 13208
		[Token(Token = "0x4003398")]
		public const float FADE_TIME = 0.25f;

		// Token: 0x04003399 RID: 13209
		[Token(Token = "0x4003399")]
		[FieldOffset(Offset = "0x20")]
		[Header("References")]
		public CanvasGroup Group;

		// Token: 0x0400339A RID: 13210
		[Token(Token = "0x400339A")]
		[FieldOffset(Offset = "0x28")]
		public TextMeshProUGUI BalanceLabel;
	}
}
