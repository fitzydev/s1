using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.Levelling;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x02000AFF RID: 2815
	[Token(Token = "0x2000AFF")]
	public class RankUpCanvas : MonoBehaviour, IPostSleepEvent
	{
		// Token: 0x17000AC4 RID: 2756
		// (get) Token: 0x06004C7D RID: 19581 RVA: 0x00013BD8 File Offset: 0x00011DD8
		// (set) Token: 0x06004C7E RID: 19582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AC4")]
		public bool IsRunning
		{
			[Token(Token = "0x6004C7D")]
			[Address(RVA = "0x4B9020", Offset = "0x4B7A20", VA = "0x1804B9020", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004C7E")]
			[Address(RVA = "0x4B9030", Offset = "0x4B7A30", VA = "0x1804B9030")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000AC5 RID: 2757
		// (get) Token: 0x06004C7F RID: 19583 RVA: 0x00013BF0 File Offset: 0x00011DF0
		// (set) Token: 0x06004C80 RID: 19584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AC5")]
		public int Order
		{
			[Token(Token = "0x6004C7F")]
			[Address(RVA = "0x47D5D0", Offset = "0x47BFD0", VA = "0x18047D5D0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6004C80")]
			[Address(RVA = "0x47D7A0", Offset = "0x47C1A0", VA = "0x18047D7A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06004C81 RID: 19585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C81")]
		[Address(RVA = "0x9331C0", Offset = "0x931BC0", VA = "0x1809331C0")]
		public void Start()
		{
		}

		// Token: 0x06004C82 RID: 19586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C82")]
		[Address(RVA = "0x932930", Offset = "0x931330", VA = "0x180932930")]
		private void QueuePostSleepEvent()
		{
		}

		// Token: 0x06004C83 RID: 19587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C83")]
		[Address(RVA = "0x932AD0", Offset = "0x9314D0", VA = "0x180932AD0", Slot = "6")]
		public void StartEvent()
		{
		}

		// Token: 0x06004C84 RID: 19588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C84")]
		[Address(RVA = "0x932370", Offset = "0x930D70", VA = "0x180932370")]
		public void EndEvent()
		{
		}

		// Token: 0x06004C85 RID: 19589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C85")]
		[Address(RVA = "0x9329D0", Offset = "0x9313D0", VA = "0x1809329D0")]
		public void RankUp(FullRank oldRank, FullRank newRank)
		{
		}

		// Token: 0x06004C86 RID: 19590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C86")]
		[Address(RVA = "0x932430", Offset = "0x930E30", VA = "0x180932430")]
		private void PlayRankupAnimation(FullRank oldRank, FullRank newRank, bool playSound)
		{
		}

		// Token: 0x06004C87 RID: 19591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C87")]
		[Address(RVA = "0x933450", Offset = "0x931E50", VA = "0x180933450")]
		public RankUpCanvas()
		{
		}

		// Token: 0x0400374E RID: 14158
		[Token(Token = "0x400374E")]
		[FieldOffset(Offset = "0x28")]
		public Animation OpenCloseAnim;

		// Token: 0x0400374F RID: 14159
		[Token(Token = "0x400374F")]
		[FieldOffset(Offset = "0x30")]
		public Animation RankUpAnim;

		// Token: 0x04003750 RID: 14160
		[Token(Token = "0x4003750")]
		[FieldOffset(Offset = "0x38")]
		public TextMeshProUGUI OldRankLabel;

		// Token: 0x04003751 RID: 14161
		[Token(Token = "0x4003751")]
		[FieldOffset(Offset = "0x40")]
		public TextMeshProUGUI NewRankLabel;

		// Token: 0x04003752 RID: 14162
		[Token(Token = "0x4003752")]
		[FieldOffset(Offset = "0x48")]
		public Canvas Canvas;

		// Token: 0x04003753 RID: 14163
		[Token(Token = "0x4003753")]
		[FieldOffset(Offset = "0x50")]
		public GameObject UnlockedItemsContainer;

		// Token: 0x04003754 RID: 14164
		[Token(Token = "0x4003754")]
		[FieldOffset(Offset = "0x58")]
		public CanvasGroup UnlockedItemsCanvasGroup;

		// Token: 0x04003755 RID: 14165
		[Token(Token = "0x4003755")]
		[FieldOffset(Offset = "0x60")]
		public RectTransform[] UnlockedItems;

		// Token: 0x04003756 RID: 14166
		[Token(Token = "0x4003756")]
		[FieldOffset(Offset = "0x68")]
		public TextMeshProUGUI ExtraUnlocksLabel;

		// Token: 0x04003757 RID: 14167
		[Token(Token = "0x4003757")]
		[FieldOffset(Offset = "0x70")]
		public AudioSourceController SoundEffect;

		// Token: 0x04003758 RID: 14168
		[Token(Token = "0x4003758")]
		[FieldOffset(Offset = "0x78")]
		public Slider ProgressSlider;

		// Token: 0x04003759 RID: 14169
		[Token(Token = "0x4003759")]
		[FieldOffset(Offset = "0x80")]
		public TextMeshProUGUI ProgressLabel;

		// Token: 0x0400375A RID: 14170
		[Token(Token = "0x400375A")]
		[FieldOffset(Offset = "0x88")]
		public AudioSourceController BlipSound;

		// Token: 0x0400375B RID: 14171
		[Token(Token = "0x400375B")]
		[FieldOffset(Offset = "0x90")]
		public AudioSourceController ClickSound;

		// Token: 0x0400375C RID: 14172
		[Token(Token = "0x400375C")]
		[FieldOffset(Offset = "0x98")]
		private Coroutine coroutine;

		// Token: 0x0400375D RID: 14173
		[Token(Token = "0x400375D")]
		[FieldOffset(Offset = "0xA0")]
		private List<Tuple<FullRank, FullRank>> queuedRankUps;
	}
}
