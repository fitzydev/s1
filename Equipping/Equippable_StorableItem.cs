using System;
using Il2CppDummyDll;

namespace ScheduleOne.Equipping
{
	// Token: 0x020009D5 RID: 2517
	[Token(Token = "0x20009D5")]
	public class Equippable_StorableItem : Equippable
	{
		// Token: 0x060044C3 RID: 17603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044C3")]
		[Address(RVA = "0x8BDA50", Offset = "0x8BC450", VA = "0x1808BDA50", Slot = "6")]
		protected virtual void Update()
		{
		}

		// Token: 0x060044C4 RID: 17604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044C4")]
		[Address(RVA = "0x8BD6C0", Offset = "0x8BC0C0", VA = "0x1808BD6C0")]
		protected void CheckLookingAtStorageObject()
		{
		}

		// Token: 0x060044C5 RID: 17605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044C5")]
		[Address(RVA = "0x8BD8D0", Offset = "0x8BC2D0", VA = "0x1808BD8D0", Slot = "5")]
		public override void Unequip()
		{
		}

		// Token: 0x060044C6 RID: 17606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044C6")]
		[Address(RVA = "0x8BD6D0", Offset = "0x8BC0D0", VA = "0x1808BD6D0", Slot = "7")]
		protected virtual void StartBuildingStoredItem()
		{
		}

		// Token: 0x060044C7 RID: 17607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044C7")]
		[Address(RVA = "0x8BD7D0", Offset = "0x8BC1D0", VA = "0x1808BD7D0", Slot = "8")]
		protected virtual void StopBuildingStoredItem()
		{
		}

		// Token: 0x060044C8 RID: 17608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044C8")]
		[Address(RVA = "0x8B84C0", Offset = "0x8B6EC0", VA = "0x1808B84C0")]
		public Equippable_StorableItem()
		{
		}

		// Token: 0x04003047 RID: 12359
		[Token(Token = "0x4003047")]
		[FieldOffset(Offset = "0x30")]
		protected bool isBuildingStoredItem;

		// Token: 0x04003048 RID: 12360
		[Token(Token = "0x4003048")]
		[FieldOffset(Offset = "0x31")]
		protected bool lookingAtStorageObject;

		// Token: 0x04003049 RID: 12361
		[Token(Token = "0x4003049")]
		[FieldOffset(Offset = "0x34")]
		protected float rotation;
	}
}
