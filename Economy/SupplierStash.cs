using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.Interaction;
using ScheduleOne.Map;
using ScheduleOne.Storage;
using UnityEngine;

namespace ScheduleOne.Economy
{
	// Token: 0x020005FB RID: 1531
	[Token(Token = "0x20005FB")]
	public class SupplierStash : MonoBehaviour
	{
		// Token: 0x17000637 RID: 1591
		// (get) Token: 0x060025AE RID: 9646 RVA: 0x0000BAD8 File Offset: 0x00009CD8
		// (set) Token: 0x060025AF RID: 9647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000637")]
		public float CashAmount
		{
			[Token(Token = "0x60025AE")]
			[Address(RVA = "0x4E8A80", Offset = "0x4E7480", VA = "0x1804E8A80")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60025AF")]
			[Address(RVA = "0x6FF890", Offset = "0x6FE290", VA = "0x1806FF890")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060025B0 RID: 9648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025B0")]
		[Address(RVA = "0x6FEC70", Offset = "0x6FD670", VA = "0x1806FEC70", Slot = "4")]
		protected virtual void Awake()
		{
		}

		// Token: 0x060025B1 RID: 9649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025B1")]
		[Address(RVA = "0x6FF6A0", Offset = "0x6FE0A0", VA = "0x1806FF6A0", Slot = "5")]
		protected virtual void Start()
		{
		}

		// Token: 0x060025B2 RID: 9650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025B2")]
		[Address(RVA = "0x6FF7C0", Offset = "0x6FE1C0", VA = "0x1806FF7C0")]
		private void SupplierUnlocked()
		{
		}

		// Token: 0x060025B3 RID: 9651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025B3")]
		[Address(RVA = "0x6FF210", Offset = "0x6FDC10", VA = "0x1806FF210")]
		private void RecalculateCash()
		{
		}

		// Token: 0x060025B4 RID: 9652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025B4")]
		[Address(RVA = "0x6FF0A0", Offset = "0x6FDAA0", VA = "0x1806FF0A0")]
		private void Interacted()
		{
		}

		// Token: 0x060025B5 RID: 9653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025B5")]
		[Address(RVA = "0x6FF440", Offset = "0x6FDE40", VA = "0x1806FF440")]
		public void RemoveCash(float amount)
		{
		}

		// Token: 0x060025B6 RID: 9654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025B6")]
		[Address(RVA = "0x6FF800", Offset = "0x6FE200", VA = "0x1806FF800")]
		private void UpdateDeadDrop()
		{
		}

		// Token: 0x060025B7 RID: 9655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025B7")]
		[Address(RVA = "0x6FF840", Offset = "0x6FE240", VA = "0x1806FF840")]
		public SupplierStash()
		{
		}

		// Token: 0x04001D0C RID: 7436
		[Token(Token = "0x4001D0C")]
		[FieldOffset(Offset = "0x20")]
		public string locationDescription;

		// Token: 0x04001D0D RID: 7437
		[Token(Token = "0x4001D0D")]
		[FieldOffset(Offset = "0x28")]
		[Header("References")]
		public Supplier Supplier;

		// Token: 0x04001D0E RID: 7438
		[Token(Token = "0x4001D0E")]
		[FieldOffset(Offset = "0x30")]
		public StorageEntity Storage;

		// Token: 0x04001D0F RID: 7439
		[Token(Token = "0x4001D0F")]
		[FieldOffset(Offset = "0x38")]
		public InteractableObject IntObj;

		// Token: 0x04001D10 RID: 7440
		[Token(Token = "0x4001D10")]
		[FieldOffset(Offset = "0x40")]
		public OptimizedLight Light;

		// Token: 0x04001D11 RID: 7441
		[Token(Token = "0x4001D11")]
		[FieldOffset(Offset = "0x48")]
		public POI StashPoI;
	}
}
