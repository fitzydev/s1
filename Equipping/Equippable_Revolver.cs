using System;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using UnityEngine;

namespace ScheduleOne.Equipping
{
	// Token: 0x020009D4 RID: 2516
	[Token(Token = "0x20009D4")]
	public class Equippable_Revolver : Equippable_RangedWeapon
	{
		// Token: 0x060044BD RID: 17597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044BD")]
		[Address(RVA = "0x8BD430", Offset = "0x8BBE30", VA = "0x1808BD430", Slot = "4")]
		public override void Equip(ItemInstance item)
		{
		}

		// Token: 0x060044BE RID: 17598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044BE")]
		[Address(RVA = "0x8BD470", Offset = "0x8BBE70", VA = "0x1808BD470", Slot = "11")]
		public override void Fire()
		{
		}

		// Token: 0x060044BF RID: 17599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044BF")]
		[Address(RVA = "0x8BD4E0", Offset = "0x8BBEE0", VA = "0x1808BD4E0", Slot = "13")]
		public override void Reload()
		{
		}

		// Token: 0x060044C0 RID: 17600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044C0")]
		[Address(RVA = "0x8BD4B0", Offset = "0x8BBEB0", VA = "0x1808BD4B0", Slot = "14")]
		protected override void NotifyIncrementalReload()
		{
		}

		// Token: 0x060044C1 RID: 17601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044C1")]
		[Address(RVA = "0x8BD600", Offset = "0x8BC000", VA = "0x1808BD600")]
		private void SetDisplayedBullets(int count)
		{
		}

		// Token: 0x060044C2 RID: 17602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044C2")]
		[Address(RVA = "0x8BD6B0", Offset = "0x8BC0B0", VA = "0x1808BD6B0")]
		public Equippable_Revolver()
		{
		}

		// Token: 0x04003046 RID: 12358
		[Token(Token = "0x4003046")]
		[FieldOffset(Offset = "0x1A8")]
		public Transform[] Bullets;
	}
}
