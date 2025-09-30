using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.Law;
using ScheduleOne.Product.Packaging;
using ScheduleOne.Vehicles;
using UnityEngine;

namespace ScheduleOne.UI
{
	// Token: 0x02000AD8 RID: 2776
	[Token(Token = "0x2000AD8")]
	public class ArrestNoticeScreen : Singleton<ArrestNoticeScreen>
	{
		// Token: 0x17000A96 RID: 2710
		// (get) Token: 0x06004B6F RID: 19311 RVA: 0x000138F0 File Offset: 0x00011AF0
		// (set) Token: 0x06004B70 RID: 19312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A96")]
		public bool isOpen
		{
			[Token(Token = "0x6004B6F")]
			[Address(RVA = "0x4B7C30", Offset = "0x4B6630", VA = "0x1804B7C30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004B70")]
			[Address(RVA = "0x4B7C40", Offset = "0x4B6640", VA = "0x1804B7C40")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06004B71 RID: 19313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B71")]
		[Address(RVA = "0x9135D0", Offset = "0x911FD0", VA = "0x1809135D0", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x06004B72 RID: 19314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B72")]
		[Address(RVA = "0x914580", Offset = "0x912F80", VA = "0x180914580")]
		private void PlayerSpawned()
		{
		}

		// Token: 0x06004B73 RID: 19315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B73")]
		[Address(RVA = "0x913E10", Offset = "0x912810", VA = "0x180913E10")]
		private void Exit(ExitAction action)
		{
		}

		// Token: 0x06004B74 RID: 19316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B74")]
		[Address(RVA = "0x913F00", Offset = "0x912900", VA = "0x180913F00")]
		public void Open()
		{
		}

		// Token: 0x06004B75 RID: 19317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B75")]
		[Address(RVA = "0x913910", Offset = "0x912310", VA = "0x180913910")]
		public void Close()
		{
		}

		// Token: 0x06004B76 RID: 19318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B76")]
		[Address(RVA = "0x914650", Offset = "0x913050", VA = "0x180914650")]
		public void RecordCrimes()
		{
		}

		// Token: 0x06004B77 RID: 19319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B77")]
		[Address(RVA = "0x914AE0", Offset = "0x9134E0", VA = "0x180914AE0")]
		private void RecordPossession(EStealthLevel maxStealthLevel)
		{
		}

		// Token: 0x06004B78 RID: 19320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B78")]
		[Address(RVA = "0x9139C0", Offset = "0x9123C0", VA = "0x1809139C0")]
		private void ConfiscateItems(EStealthLevel maxStealthLevel)
		{
		}

		// Token: 0x06004B79 RID: 19321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B79")]
		[Address(RVA = "0x9137D0", Offset = "0x9121D0", VA = "0x1809137D0")]
		private void ClearEntries()
		{
		}

		// Token: 0x06004B7A RID: 19322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B7A")]
		[Address(RVA = "0x915210", Offset = "0x913C10", VA = "0x180915210")]
		public ArrestNoticeScreen()
		{
		}

		// Token: 0x06004B7B RID: 19323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B7B")]
		[Address(RVA = "0x9151A0", Offset = "0x913BA0", VA = "0x1809151A0")]
		[CompilerGenerated]
		private IEnumerator <Close>g__CloseRoutine|17_0()
		{
			return null;
		}

		// Token: 0x04003677 RID: 13943
		[Token(Token = "0x4003677")]
		public const float VEHICLE_POSSESSION_TIMEOUT = 30f;

		// Token: 0x04003679 RID: 13945
		[Token(Token = "0x4003679")]
		[FieldOffset(Offset = "0x30")]
		[Header("References")]
		public Canvas Canvas;

		// Token: 0x0400367A RID: 13946
		[Token(Token = "0x400367A")]
		[FieldOffset(Offset = "0x38")]
		public CanvasGroup CanvasGroup;

		// Token: 0x0400367B RID: 13947
		[Token(Token = "0x400367B")]
		[FieldOffset(Offset = "0x40")]
		public RectTransform CrimeEntryContainer;

		// Token: 0x0400367C RID: 13948
		[Token(Token = "0x400367C")]
		[FieldOffset(Offset = "0x48")]
		public RectTransform PenaltyEntryContainer;

		// Token: 0x0400367D RID: 13949
		[Token(Token = "0x400367D")]
		[FieldOffset(Offset = "0x50")]
		[Header("Prefabs")]
		public RectTransform CrimeEntryPrefab;

		// Token: 0x0400367E RID: 13950
		[Token(Token = "0x400367E")]
		[FieldOffset(Offset = "0x58")]
		public RectTransform PenaltyEntryPrefab;

		// Token: 0x0400367F RID: 13951
		[Token(Token = "0x400367F")]
		[FieldOffset(Offset = "0x60")]
		private Dictionary<Crime, int> recordedCrimes;

		// Token: 0x04003680 RID: 13952
		[Token(Token = "0x4003680")]
		[FieldOffset(Offset = "0x68")]
		private LandVehicle vehicle;
	}
}
