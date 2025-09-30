using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;

namespace ScheduleOne.Management
{
	// Token: 0x020004FD RID: 1277
	[Token(Token = "0x20004FD")]
	public class ManagementItemFilter
	{
		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x060019FF RID: 6655 RVA: 0x000092D0 File Offset: 0x000074D0
		// (set) Token: 0x06001A00 RID: 6656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000496")]
		public ManagementItemFilter.EMode Mode
		{
			[Token(Token = "0x60019FF")]
			[Address(RVA = "0x42D220", Offset = "0x42BC20", VA = "0x18042D220")]
			[CompilerGenerated]
			get
			{
				return ManagementItemFilter.EMode.Whitelist;
			}
			[Token(Token = "0x6001A00")]
			[Address(RVA = "0x493F90", Offset = "0x492990", VA = "0x180493F90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x06001A01 RID: 6657 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001A02 RID: 6658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000497")]
		public List<ItemDefinition> Items
		{
			[Token(Token = "0x6001A01")]
			[Address(RVA = "0x42FFB0", Offset = "0x42E9B0", VA = "0x18042FFB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001A02")]
			[Address(RVA = "0x42FFE0", Offset = "0x42E9E0", VA = "0x18042FFE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06001A03 RID: 6659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A03")]
		[Address(RVA = "0x63FAA0", Offset = "0x63E4A0", VA = "0x18063FAA0")]
		public ManagementItemFilter(ManagementItemFilter.EMode mode)
		{
		}

		// Token: 0x06001A04 RID: 6660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A04")]
		[Address(RVA = "0x493F90", Offset = "0x492990", VA = "0x180493F90")]
		public void SetMode(ManagementItemFilter.EMode mode)
		{
		}

		// Token: 0x06001A05 RID: 6661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A05")]
		[Address(RVA = "0x63F790", Offset = "0x63E190", VA = "0x18063F790")]
		public void AddItem(ItemDefinition item)
		{
		}

		// Token: 0x06001A06 RID: 6662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A06")]
		[Address(RVA = "0x63FA40", Offset = "0x63E440", VA = "0x18063FA40")]
		public void RemoveItem(ItemDefinition item)
		{
		}

		// Token: 0x06001A07 RID: 6663 RVA: 0x000092E8 File Offset: 0x000074E8
		[Token(Token = "0x6001A07")]
		[Address(RVA = "0x63F840", Offset = "0x63E240", VA = "0x18063F840")]
		public bool Contains(ItemDefinition item)
		{
			return default(bool);
		}

		// Token: 0x06001A08 RID: 6664 RVA: 0x00009300 File Offset: 0x00007500
		[Token(Token = "0x6001A08")]
		[Address(RVA = "0x63F8A0", Offset = "0x63E2A0", VA = "0x18063F8A0")]
		public bool DoesItemMeetFilter(ItemInstance item)
		{
			return default(bool);
		}

		// Token: 0x06001A09 RID: 6665 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A09")]
		[Address(RVA = "0x63F950", Offset = "0x63E350", VA = "0x18063F950")]
		public string GetDescription()
		{
			return null;
		}

		// Token: 0x020004FE RID: 1278
		[Token(Token = "0x20004FE")]
		public enum EMode
		{
			// Token: 0x04001692 RID: 5778
			[Token(Token = "0x4001692")]
			Whitelist,
			// Token: 0x04001693 RID: 5779
			[Token(Token = "0x4001693")]
			Blacklist
		}
	}
}
