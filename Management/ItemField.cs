using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using ScheduleOne.Persistence.Datas;
using UnityEngine.Events;

namespace ScheduleOne.Management
{
	// Token: 0x020004E3 RID: 1251
	[Token(Token = "0x20004E3")]
	public class ItemField : ConfigField
	{
		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x06001948 RID: 6472 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001949 RID: 6473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700046E")]
		public ItemDefinition SelectedItem
		{
			[Token(Token = "0x6001948")]
			[Address(RVA = "0x42FFB0", Offset = "0x42E9B0", VA = "0x18042FFB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001949")]
			[Address(RVA = "0x42FFE0", Offset = "0x42E9E0", VA = "0x18042FFE0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x0600194A RID: 6474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600194A")]
		[Address(RVA = "0x637240", Offset = "0x635C40", VA = "0x180637240")]
		public ItemField(EntityConfiguration parentConfig)
		{
		}

		// Token: 0x0600194B RID: 6475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600194B")]
		[Address(RVA = "0x6371A0", Offset = "0x635BA0", VA = "0x1806371A0")]
		public void SetItem(ItemDefinition item, bool network)
		{
		}

		// Token: 0x0600194C RID: 6476 RVA: 0x00009030 File Offset: 0x00007230
		[Token(Token = "0x600194C")]
		[Address(RVA = "0x637060", Offset = "0x635A60", VA = "0x180637060", Slot = "4")]
		public override bool IsValueDefault()
		{
			return default(bool);
		}

		// Token: 0x0600194D RID: 6477 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600194D")]
		[Address(RVA = "0x636F90", Offset = "0x635990", VA = "0x180636F90")]
		public ItemFieldData GetData()
		{
			return null;
		}

		// Token: 0x0600194E RID: 6478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600194E")]
		[Address(RVA = "0x6370B0", Offset = "0x635AB0", VA = "0x1806370B0")]
		public void Load(ItemFieldData data)
		{
		}

		// Token: 0x0400163D RID: 5693
		[Token(Token = "0x400163D")]
		[FieldOffset(Offset = "0x20")]
		public bool CanSelectNone;

		// Token: 0x0400163E RID: 5694
		[Token(Token = "0x400163E")]
		[FieldOffset(Offset = "0x28")]
		public List<ItemDefinition> Options;

		// Token: 0x0400163F RID: 5695
		[Token(Token = "0x400163F")]
		[FieldOffset(Offset = "0x30")]
		public UnityEvent<ItemDefinition> onItemChanged;
	}
}
