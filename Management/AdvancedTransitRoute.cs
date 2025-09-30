using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using ScheduleOne.Persistence.Datas;

namespace ScheduleOne.Management
{
	// Token: 0x020004C8 RID: 1224
	[Token(Token = "0x20004C8")]
	public class AdvancedTransitRoute : TransitRoute
	{
		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x06001826 RID: 6182 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001827 RID: 6183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700044E")]
		public ManagementItemFilter Filter
		{
			[Token(Token = "0x6001826")]
			[Address(RVA = "0x4423B0", Offset = "0x440DB0", VA = "0x1804423B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001827")]
			[Address(RVA = "0x4423E0", Offset = "0x440DE0", VA = "0x1804423E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06001828 RID: 6184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001828")]
		[Address(RVA = "0x5FB620", Offset = "0x5FA020", VA = "0x1805FB620")]
		public AdvancedTransitRoute(ITransitEntity source, ITransitEntity destination)
		{
		}

		// Token: 0x06001829 RID: 6185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001829")]
		[Address(RVA = "0x5FB6B0", Offset = "0x5FA0B0", VA = "0x1805FB6B0")]
		public AdvancedTransitRoute(AdvancedTransitRouteData data)
		{
		}

		// Token: 0x0600182A RID: 6186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600182A")]
		[Address(RVA = "0x5FB3A0", Offset = "0x5F9DA0", VA = "0x1805FB3A0")]
		public ItemInstance GetItemReadyToMove()
		{
			return null;
		}

		// Token: 0x0600182B RID: 6187 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600182B")]
		[Address(RVA = "0x5FAFC0", Offset = "0x5F99C0", VA = "0x1805FAFC0")]
		public AdvancedTransitRouteData GetData()
		{
			return null;
		}
	}
}
