using System;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using Il2CppDummyDll;
using ScheduleOne.ObjectScripts.Cash;
using UnityEngine;

namespace ScheduleOne.ItemFramework
{
	// Token: 0x020009E4 RID: 2532
	[Token(Token = "0x20009E4")]
	public class CashPickup : ItemPickup
	{
		// Token: 0x06004552 RID: 17746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004552")]
		[Address(RVA = "0x8B1D90", Offset = "0x8B0790", VA = "0x1808B1D90")]
		private void Start()
		{
		}

		// Token: 0x06004553 RID: 17747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004553")]
		[Address(RVA = "0x8B1830", Offset = "0x8B0230", VA = "0x1808B1830", Slot = "20")]
		protected override void Hovered()
		{
		}

		// Token: 0x06004554 RID: 17748 RVA: 0x00012330 File Offset: 0x00010530
		[Token(Token = "0x6004554")]
		[Address(RVA = "0x48DCC0", Offset = "0x48C6C0", VA = "0x18048DCC0", Slot = "21")]
		protected override bool CanPickup()
		{
			return default(bool);
		}

		// Token: 0x06004555 RID: 17749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004555")]
		[Address(RVA = "0x8B1B50", Offset = "0x8B0550", VA = "0x1808B1B50", Slot = "22")]
		protected override void Pickup()
		{
		}

		// Token: 0x06004556 RID: 17750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004556")]
		[Address(RVA = "0x8B1D90", Offset = "0x8B0790", VA = "0x1808B1D90")]
		private void ValueChanged(float oldValue, float newValue, bool asServer)
		{
		}

		// Token: 0x06004557 RID: 17751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004557")]
		[Address(RVA = "0x8B1DA0", Offset = "0x8B07A0", VA = "0x1808B1DA0")]
		private void UpdateCashStackVisuals()
		{
		}

		// Token: 0x06004558 RID: 17752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004558")]
		[Address(RVA = "0x8B1E30", Offset = "0x8B0830", VA = "0x1808B1E30")]
		public CashPickup()
		{
		}

		// Token: 0x06004559 RID: 17753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004559")]
		[Address(RVA = "0x8B1920", Offset = "0x8B0320", VA = "0x1808B1920", Slot = "23")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x0600455A RID: 17754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600455A")]
		[Address(RVA = "0x8B18C0", Offset = "0x8B02C0", VA = "0x1808B18C0", Slot = "24")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x0600455B RID: 17755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600455B")]
		[Address(RVA = "0x6806A0", Offset = "0x67F0A0", VA = "0x1806806A0", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x170009A9 RID: 2473
		// (get) Token: 0x0600455C RID: 17756 RVA: 0x00012348 File Offset: 0x00010548
		// (set) Token: 0x0600455D RID: 17757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009A9")]
		public float SyncAccessor_Value
		{
			[Token(Token = "0x600455C")]
			[Address(RVA = "0x5386B0", Offset = "0x5370B0", VA = "0x1805386B0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600455D")]
			[Address(RVA = "0x8B1E50", Offset = "0x8B0850", VA = "0x1808B1E50")]
			set
			{
			}
		}

		// Token: 0x0600455E RID: 17758 RVA: 0x00012360 File Offset: 0x00010560
		[Token(Token = "0x600455E")]
		[Address(RVA = "0x8B1C50", Offset = "0x8B0650", VA = "0x1808B1C50", Slot = "26")]
		public virtual bool ReadSyncVar___ScheduleOne.ItemFramework.CashPickup(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return default(bool);
		}

		// Token: 0x0600455F RID: 17759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600455F")]
		[Address(RVA = "0x8B1660", Offset = "0x8B0060", VA = "0x1808B1660", Slot = "19")]
		public override void Awake()
		{
		}

		// Token: 0x0400309A RID: 12442
		[Token(Token = "0x400309A")]
		[FieldOffset(Offset = "0x150")]
		[SyncVar(OnChange = "ValueChanged")]
		public float Value;

		// Token: 0x0400309B RID: 12443
		[Token(Token = "0x400309B")]
		[FieldOffset(Offset = "0x154")]
		public bool PlayCashPickupSound;

		// Token: 0x0400309C RID: 12444
		[Token(Token = "0x400309C")]
		[FieldOffset(Offset = "0x158")]
		[Header("References")]
		public CashStackVisuals CashStackVisuals;

		// Token: 0x0400309D RID: 12445
		[Token(Token = "0x400309D")]
		[FieldOffset(Offset = "0x160")]
		public SyncVar<float> syncVar___Value;

		// Token: 0x0400309E RID: 12446
		[Token(Token = "0x400309E")]
		[FieldOffset(Offset = "0x168")]
		private bool NetworkInitialize___EarlyScheduleOne.ItemFramework.CashPickupAssembly-CSharp.dll_Excuted;

		// Token: 0x0400309F RID: 12447
		[Token(Token = "0x400309F")]
		[FieldOffset(Offset = "0x169")]
		private bool NetworkInitialize__LateScheduleOne.ItemFramework.CashPickupAssembly-CSharp.dll_Excuted;
	}
}
