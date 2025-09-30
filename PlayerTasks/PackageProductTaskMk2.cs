using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Packaging;

namespace ScheduleOne.PlayerTasks
{
	// Token: 0x02000360 RID: 864
	[Token(Token = "0x2000360")]
	public class PackageProductTaskMk2 : Task
	{
		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x06001325 RID: 4901 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001326 RID: 4902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003A0")]
		public override string TaskName
		{
			[Token(Token = "0x6001325")]
			[Address(RVA = "0x5904C0", Offset = "0x58EEC0", VA = "0x1805904C0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001326")]
			[Address(RVA = "0x5904E0", Offset = "0x58EEE0", VA = "0x1805904E0", Slot = "5")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06001327 RID: 4903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001327")]
		[Address(RVA = "0x5B1770", Offset = "0x5B0170", VA = "0x1805B1770")]
		public PackageProductTaskMk2(PackagingStationMk2 _station)
		{
		}

		// Token: 0x06001328 RID: 4904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001328")]
		[Address(RVA = "0x5B1430", Offset = "0x5AFE30", VA = "0x1805B1430", Slot = "6")]
		public override void StopTask()
		{
		}

		// Token: 0x0400123B RID: 4667
		[Token(Token = "0x400123B")]
		[FieldOffset(Offset = "0xA0")]
		protected PackagingStationMk2 station;

		// Token: 0x0400123C RID: 4668
		[Token(Token = "0x400123C")]
		[FieldOffset(Offset = "0xA8")]
		protected FunctionalPackaging Packaging;

		// Token: 0x0400123D RID: 4669
		[Token(Token = "0x400123D")]
		[FieldOffset(Offset = "0xB0")]
		protected List<FunctionalProduct> Products;
	}
}
