using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.NPCs;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.UI
{
	// Token: 0x02000A70 RID: 2672
	[Token(Token = "0x2000A70")]
	public class BodySearchScreen : Singleton<BodySearchScreen>
	{
		// Token: 0x17000A35 RID: 2613
		// (get) Token: 0x060048BB RID: 18619 RVA: 0x00013050 File Offset: 0x00011250
		// (set) Token: 0x060048BC RID: 18620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A35")]
		public bool IsOpen
		{
			[Token(Token = "0x60048BB")]
			[Address(RVA = "0x4B7C30", Offset = "0x4B6630", VA = "0x1804B7C30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60048BC")]
			[Address(RVA = "0x4B7C40", Offset = "0x4B6640", VA = "0x1804B7C40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000A36 RID: 2614
		// (get) Token: 0x060048BD RID: 18621 RVA: 0x00013068 File Offset: 0x00011268
		// (set) Token: 0x060048BE RID: 18622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A36")]
		public bool TutorialOpen
		{
			[Token(Token = "0x60048BD")]
			[Address(RVA = "0x5CD9E0", Offset = "0x5CC3E0", VA = "0x1805CD9E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60048BE")]
			[Address(RVA = "0x5CD9F0", Offset = "0x5CC3F0", VA = "0x1805CD9F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060048BF RID: 18623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048BF")]
		[Address(RVA = "0x8FEA10", Offset = "0x8FD410", VA = "0x1808FEA10", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x060048C0 RID: 18624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048C0")]
		[Address(RVA = "0x8FE060", Offset = "0x8FCA60", VA = "0x1808FE060")]
		private void SetupSlots()
		{
		}

		// Token: 0x060048C1 RID: 18625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048C1")]
		[Address(RVA = "0x8FEC10", Offset = "0x8FD610", VA = "0x1808FEC10")]
		private void Update()
		{
		}

		// Token: 0x060048C2 RID: 18626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048C2")]
		[Address(RVA = "0x8FD9F0", Offset = "0x8FC3F0", VA = "0x1808FD9F0")]
		public void Open(NPC _searcher, float searchTime = 0f)
		{
		}

		// Token: 0x060048C3 RID: 18627 RVA: 0x00013080 File Offset: 0x00011280
		[Token(Token = "0x60048C3")]
		[Address(RVA = "0x8FD8D0", Offset = "0x8FC2D0", VA = "0x1808FD8D0")]
		private bool IsSlotConcealed(ItemSlotUI slot)
		{
			return default(bool);
		}

		// Token: 0x060048C4 RID: 18628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048C4")]
		[Address(RVA = "0x8FD930", Offset = "0x8FC330", VA = "0x1808FD930")]
		private void ItemDetected(ItemSlotUI slot)
		{
		}

		// Token: 0x060048C5 RID: 18629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048C5")]
		[Address(RVA = "0x8FE780", Offset = "0x8FD180", VA = "0x1808FE780")]
		public void SlotHeld(ItemSlotUI ui)
		{
		}

		// Token: 0x060048C6 RID: 18630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048C6")]
		[Address(RVA = "0x8FE910", Offset = "0x8FD310", VA = "0x1808FE910")]
		public void SlotReleased(ItemSlotUI ui)
		{
		}

		// Token: 0x060048C7 RID: 18631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048C7")]
		[Address(RVA = "0x8FD5A0", Offset = "0x8FBFA0", VA = "0x1808FD5A0")]
		public void Close(bool clear)
		{
		}

		// Token: 0x060048C8 RID: 18632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048C8")]
		[Address(RVA = "0x8FD9A0", Offset = "0x8FC3A0", VA = "0x1808FD9A0")]
		private void OpenTutorial()
		{
		}

		// Token: 0x060048C9 RID: 18633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048C9")]
		[Address(RVA = "0x8FD560", Offset = "0x8FBF60", VA = "0x1808FD560")]
		public void CloseTutorial()
		{
		}

		// Token: 0x060048CA RID: 18634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048CA")]
		[Address(RVA = "0x8FEE80", Offset = "0x8FD880", VA = "0x1808FEE80")]
		public BodySearchScreen()
		{
		}

		// Token: 0x040033A8 RID: 13224
		[Token(Token = "0x40033A8")]
		public const float MAX_SPEED_BOOST = 2.5f;

		// Token: 0x040033AB RID: 13227
		[Token(Token = "0x40033AB")]
		[FieldOffset(Offset = "0x2C")]
		public Color SlotRedColor;

		// Token: 0x040033AC RID: 13228
		[Token(Token = "0x40033AC")]
		[FieldOffset(Offset = "0x3C")]
		public Color SlotHighlightRedColor;

		// Token: 0x040033AD RID: 13229
		[Token(Token = "0x40033AD")]
		[FieldOffset(Offset = "0x4C")]
		public float GapTime;

		// Token: 0x040033AE RID: 13230
		[Token(Token = "0x40033AE")]
		[FieldOffset(Offset = "0x50")]
		[Header("References")]
		public Canvas Canvas;

		// Token: 0x040033AF RID: 13231
		[Token(Token = "0x40033AF")]
		[FieldOffset(Offset = "0x58")]
		public RectTransform Container;

		// Token: 0x040033B0 RID: 13232
		[Token(Token = "0x40033B0")]
		[FieldOffset(Offset = "0x60")]
		public RectTransform MinigameController;

		// Token: 0x040033B1 RID: 13233
		[Token(Token = "0x40033B1")]
		[FieldOffset(Offset = "0x68")]
		public RectTransform SlotContainer;

		// Token: 0x040033B2 RID: 13234
		[Token(Token = "0x40033B2")]
		[FieldOffset(Offset = "0x70")]
		public ItemSlotUI ItemSlotPrefab;

		// Token: 0x040033B3 RID: 13235
		[Token(Token = "0x40033B3")]
		[FieldOffset(Offset = "0x78")]
		public RectTransform SearchIndicator;

		// Token: 0x040033B4 RID: 13236
		[Token(Token = "0x40033B4")]
		[FieldOffset(Offset = "0x80")]
		public RectTransform SearchIndicatorStart;

		// Token: 0x040033B5 RID: 13237
		[Token(Token = "0x40033B5")]
		[FieldOffset(Offset = "0x88")]
		public RectTransform SearchIndicatorEnd;

		// Token: 0x040033B6 RID: 13238
		[Token(Token = "0x40033B6")]
		[FieldOffset(Offset = "0x90")]
		public Animation IndicatorAnimation;

		// Token: 0x040033B7 RID: 13239
		[Token(Token = "0x40033B7")]
		[FieldOffset(Offset = "0x98")]
		public Animation TutorialAnimation;

		// Token: 0x040033B8 RID: 13240
		[Token(Token = "0x40033B8")]
		[FieldOffset(Offset = "0xA0")]
		public RectTransform TutorialContainer;

		// Token: 0x040033B9 RID: 13241
		[Token(Token = "0x40033B9")]
		[FieldOffset(Offset = "0xA8")]
		public Animation ResetAnimation;

		// Token: 0x040033BA RID: 13242
		[Token(Token = "0x40033BA")]
		[FieldOffset(Offset = "0xB0")]
		private List<ItemSlotUI> slots;

		// Token: 0x040033BB RID: 13243
		[Token(Token = "0x40033BB")]
		[FieldOffset(Offset = "0xB8")]
		public UnityEvent onSearchClear;

		// Token: 0x040033BC RID: 13244
		[Token(Token = "0x40033BC")]
		[FieldOffset(Offset = "0xC0")]
		public UnityEvent onSearchFail;

		// Token: 0x040033BD RID: 13245
		[Token(Token = "0x40033BD")]
		[FieldOffset(Offset = "0xC8")]
		private Color defaultSlotColor;

		// Token: 0x040033BE RID: 13246
		[Token(Token = "0x40033BE")]
		[FieldOffset(Offset = "0xD8")]
		private Color defaultSlotHighlightColor;

		// Token: 0x040033BF RID: 13247
		[Token(Token = "0x40033BF")]
		[FieldOffset(Offset = "0xE8")]
		private ItemSlotUI concealedSlot;

		// Token: 0x040033C0 RID: 13248
		[Token(Token = "0x40033C0")]
		[FieldOffset(Offset = "0xF0")]
		private ItemSlotUI hoveredSlot;

		// Token: 0x040033C1 RID: 13249
		[Token(Token = "0x40033C1")]
		[FieldOffset(Offset = "0xF8")]
		private Color[] defaultItemIconColors;

		// Token: 0x040033C2 RID: 13250
		[Token(Token = "0x40033C2")]
		[FieldOffset(Offset = "0x100")]
		private float speedBoost;

		// Token: 0x040033C3 RID: 13251
		[Token(Token = "0x40033C3")]
		[FieldOffset(Offset = "0x108")]
		private NPC searcher;
	}
}
