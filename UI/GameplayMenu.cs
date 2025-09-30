using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.UI
{
	// Token: 0x02000A9D RID: 2717
	[Token(Token = "0x2000A9D")]
	public class GameplayMenu : Singleton<GameplayMenu>
	{
		// Token: 0x17000A5F RID: 2655
		// (get) Token: 0x060049E7 RID: 18919 RVA: 0x00013458 File Offset: 0x00011658
		// (set) Token: 0x060049E8 RID: 18920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A5F")]
		public bool IsOpen
		{
			[Token(Token = "0x60049E7")]
			[Address(RVA = "0x4B7C30", Offset = "0x4B6630", VA = "0x1804B7C30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60049E8")]
			[Address(RVA = "0x4B7C40", Offset = "0x4B6640", VA = "0x1804B7C40")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000A60 RID: 2656
		// (get) Token: 0x060049E9 RID: 18921 RVA: 0x00013470 File Offset: 0x00011670
		[Token(Token = "0x17000A60")]
		public bool CharacterScreenEnabled
		{
			[Token(Token = "0x60049E9")]
			[Address(RVA = "0x48DCC0", Offset = "0x48C6C0", VA = "0x18048DCC0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000A61 RID: 2657
		// (get) Token: 0x060049EA RID: 18922 RVA: 0x00013488 File Offset: 0x00011688
		// (set) Token: 0x060049EB RID: 18923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A61")]
		public GameplayMenu.EGameplayScreen CurrentScreen
		{
			[Token(Token = "0x60049EA")]
			[Address(RVA = "0x6737E0", Offset = "0x6721E0", VA = "0x1806737E0")]
			[CompilerGenerated]
			get
			{
				return GameplayMenu.EGameplayScreen.Phone;
			}
			[Token(Token = "0x60049EB")]
			[Address(RVA = "0x673170", Offset = "0x671B70", VA = "0x180673170")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x060049EC RID: 18924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049EC")]
		[Address(RVA = "0x916680", Offset = "0x915080", VA = "0x180916680", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x060049ED RID: 18925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049ED")]
		[Address(RVA = "0x915A80", Offset = "0x914480", VA = "0x180915A80")]
		public void Exit(ExitAction exit)
		{
		}

		// Token: 0x060049EE RID: 18926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049EE")]
		[Address(RVA = "0x916980", Offset = "0x915380", VA = "0x180916980", Slot = "7")]
		protected virtual void Update()
		{
		}

		// Token: 0x060049EF RID: 18927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049EF")]
		[Address(RVA = "0x916430", Offset = "0x914E30", VA = "0x180916430")]
		public void SetScreen(GameplayMenu.EGameplayScreen screen)
		{
		}

		// Token: 0x060049F0 RID: 18928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049F0")]
		[Address(RVA = "0x915B50", Offset = "0x914550", VA = "0x180915B50")]
		public void SetIsOpen(bool open)
		{
		}

		// Token: 0x060049F1 RID: 18929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049F1")]
		[Address(RVA = "0x916CC0", Offset = "0x9156C0", VA = "0x180916CC0")]
		public GameplayMenu()
		{
		}

		// Token: 0x060049F2 RID: 18930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049F2")]
		[Address(RVA = "0x916880", Offset = "0x915280", VA = "0x180916880")]
		[CompilerGenerated]
		private void <Update>g__PrepAppOpen|22_0()
		{
		}

		// Token: 0x060049F3 RID: 18931 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049F3")]
		[Address(RVA = "0x916800", Offset = "0x915200", VA = "0x180916800")]
		[CompilerGenerated]
		private IEnumerator <SetIsOpen>g__SetIsOpenRoutine|24_0(bool open)
		{
			return null;
		}

		// Token: 0x040034B3 RID: 13491
		[Token(Token = "0x40034B3")]
		public const float OpenVerticalOffset = 0.02f;

		// Token: 0x040034B4 RID: 13492
		[Token(Token = "0x40034B4")]
		public const float ClosedVerticalOffset = -2f;

		// Token: 0x040034B5 RID: 13493
		[Token(Token = "0x40034B5")]
		public const float OpenTime = 0.06f;

		// Token: 0x040034B6 RID: 13494
		[Token(Token = "0x40034B6")]
		public const float SlideTime = 0.12f;

		// Token: 0x040034B9 RID: 13497
		[Token(Token = "0x40034B9")]
		[FieldOffset(Offset = "0x30")]
		[Header("References")]
		public Camera OverlayCamera;

		// Token: 0x040034BA RID: 13498
		[Token(Token = "0x40034BA")]
		[FieldOffset(Offset = "0x38")]
		public Light OverlayLight;

		// Token: 0x040034BB RID: 13499
		[Token(Token = "0x40034BB")]
		[FieldOffset(Offset = "0x40")]
		[Header("Settings")]
		public float ContainerOffset_PhoneScreen;

		// Token: 0x040034BC RID: 13500
		[Token(Token = "0x40034BC")]
		[FieldOffset(Offset = "0x48")]
		private Coroutine openCloseRoutine;

		// Token: 0x040034BD RID: 13501
		[Token(Token = "0x40034BD")]
		[FieldOffset(Offset = "0x50")]
		private Coroutine screenChangeRoutine;

		// Token: 0x02000A9E RID: 2718
		[Token(Token = "0x2000A9E")]
		public enum EGameplayScreen
		{
			// Token: 0x040034BF RID: 13503
			[Token(Token = "0x40034BF")]
			Phone,
			// Token: 0x040034C0 RID: 13504
			[Token(Token = "0x40034C0")]
			Character
		}
	}
}
