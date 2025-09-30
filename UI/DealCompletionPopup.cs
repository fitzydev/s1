using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.DevUtilities;
using ScheduleOne.Economy;
using ScheduleOne.Quests;
using ScheduleOne.UI.Relations;
using TMPro;
using UnityEngine;

namespace ScheduleOne.UI
{
	// Token: 0x02000A8B RID: 2699
	[Token(Token = "0x2000A8B")]
	public class DealCompletionPopup : Singleton<DealCompletionPopup>
	{
		// Token: 0x17000A4E RID: 2638
		// (get) Token: 0x06004972 RID: 18802 RVA: 0x000132F0 File Offset: 0x000114F0
		// (set) Token: 0x06004973 RID: 18803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A4E")]
		public bool IsPlaying
		{
			[Token(Token = "0x6004972")]
			[Address(RVA = "0x4B7C30", Offset = "0x4B6630", VA = "0x1804B7C30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004973")]
			[Address(RVA = "0x4B7C40", Offset = "0x4B6640", VA = "0x1804B7C40")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06004974 RID: 18804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004974")]
		[Address(RVA = "0x908F80", Offset = "0x907980", VA = "0x180908F80", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x06004975 RID: 18805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004975")]
		[Address(RVA = "0x909000", Offset = "0x907A00", VA = "0x180909000")]
		public void PlayPopup(Customer customer, float satisfaction, float originalRelationshipDelta, float basePayment, List<Contract.BonusPayment> bonuses)
		{
		}

		// Token: 0x06004976 RID: 18806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004976")]
		[Address(RVA = "0x909160", Offset = "0x907B60", VA = "0x180909160")]
		private void SetRelationshipLabel(float delta)
		{
		}

		// Token: 0x06004977 RID: 18807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004977")]
		[Address(RVA = "0x9092D0", Offset = "0x907CD0", VA = "0x1809092D0")]
		public DealCompletionPopup()
		{
		}

		// Token: 0x04003441 RID: 13377
		[Token(Token = "0x4003441")]
		[FieldOffset(Offset = "0x30")]
		[Header("References")]
		public Canvas Canvas;

		// Token: 0x04003442 RID: 13378
		[Token(Token = "0x4003442")]
		[FieldOffset(Offset = "0x38")]
		public RectTransform Container;

		// Token: 0x04003443 RID: 13379
		[Token(Token = "0x4003443")]
		[FieldOffset(Offset = "0x40")]
		public CanvasGroup Group;

		// Token: 0x04003444 RID: 13380
		[Token(Token = "0x4003444")]
		[FieldOffset(Offset = "0x48")]
		public Animation Anim;

		// Token: 0x04003445 RID: 13381
		[Token(Token = "0x4003445")]
		[FieldOffset(Offset = "0x50")]
		public TextMeshProUGUI Title;

		// Token: 0x04003446 RID: 13382
		[Token(Token = "0x4003446")]
		[FieldOffset(Offset = "0x58")]
		public TextMeshProUGUI PaymentLabel;

		// Token: 0x04003447 RID: 13383
		[Token(Token = "0x4003447")]
		[FieldOffset(Offset = "0x60")]
		public TextMeshProUGUI SatisfactionValueLabel;

		// Token: 0x04003448 RID: 13384
		[Token(Token = "0x4003448")]
		[FieldOffset(Offset = "0x68")]
		public RelationCircle RelationCircle;

		// Token: 0x04003449 RID: 13385
		[Token(Token = "0x4003449")]
		[FieldOffset(Offset = "0x70")]
		public TextMeshProUGUI RelationshipLabel;

		// Token: 0x0400344A RID: 13386
		[Token(Token = "0x400344A")]
		[FieldOffset(Offset = "0x78")]
		public Gradient SatisfactionGradient;

		// Token: 0x0400344B RID: 13387
		[Token(Token = "0x400344B")]
		[FieldOffset(Offset = "0x80")]
		public AudioSourceController SoundEffect;

		// Token: 0x0400344C RID: 13388
		[Token(Token = "0x400344C")]
		[FieldOffset(Offset = "0x88")]
		public TextMeshProUGUI[] BonusLabels;

		// Token: 0x0400344D RID: 13389
		[Token(Token = "0x400344D")]
		[FieldOffset(Offset = "0x90")]
		private Coroutine routine;
	}
}
