using System;
using Il2CppDummyDll;
using ScheduleOne.AvatarFramework.Equipping;
using ScheduleOne.ItemFramework;
using UnityEngine;

namespace ScheduleOne.Equipping
{
	// Token: 0x020009D7 RID: 2519
	[Token(Token = "0x20009D7")]
	public class Equippable_Viewmodel : Equippable_StorableItem
	{
		// Token: 0x060044CC RID: 17612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044CC")]
		[Address(RVA = "0x8BE150", Offset = "0x8BCB50", VA = "0x1808BE150", Slot = "4")]
		public override void Equip(ItemInstance item)
		{
		}

		// Token: 0x060044CD RID: 17613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044CD")]
		[Address(RVA = "0x8BE580", Offset = "0x8BCF80", VA = "0x1808BE580", Slot = "5")]
		public override void Unequip()
		{
		}

		// Token: 0x060044CE RID: 17614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044CE")]
		[Address(RVA = "0x8BE400", Offset = "0x8BCE00", VA = "0x1808BE400", Slot = "9")]
		protected virtual void PlayEquipAnimation()
		{
		}

		// Token: 0x060044CF RID: 17615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044CF")]
		[Address(RVA = "0x8BE4C0", Offset = "0x8BCEC0", VA = "0x1808BE4C0", Slot = "10")]
		protected virtual void PlayUnequipAnimation()
		{
		}

		// Token: 0x060044D0 RID: 17616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044D0")]
		[Address(RVA = "0x8BDFE0", Offset = "0x8BC9E0", VA = "0x1808BDFE0")]
		public Equippable_Viewmodel()
		{
		}

		// Token: 0x0400304B RID: 12363
		[Token(Token = "0x400304B")]
		[FieldOffset(Offset = "0x38")]
		[Header("Viewmodel settings")]
		public Vector3 localPosition;

		// Token: 0x0400304C RID: 12364
		[Token(Token = "0x400304C")]
		[FieldOffset(Offset = "0x44")]
		public Vector3 localEulerAngles;

		// Token: 0x0400304D RID: 12365
		[Token(Token = "0x400304D")]
		[FieldOffset(Offset = "0x50")]
		public Vector3 localScale;

		// Token: 0x0400304E RID: 12366
		[Token(Token = "0x400304E")]
		[FieldOffset(Offset = "0x60")]
		[Header("Third person animation settings")]
		public AvatarEquippable AvatarEquippable;
	}
}
