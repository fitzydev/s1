using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.EntityFramework;
using ScheduleOne.ObjectScripts;

namespace ScheduleOne.Management
{
	// Token: 0x020004DB RID: 1243
	[Token(Token = "0x20004DB")]
	public class LabOvenConfiguration : EntityConfiguration
	{
		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x060018F8 RID: 6392 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060018F9 RID: 6393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000462")]
		public LabOven Oven
		{
			[Token(Token = "0x60018F8")]
			[Address(RVA = "0x4423B0", Offset = "0x440DB0", VA = "0x1804423B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60018F9")]
			[Address(RVA = "0x4423E0", Offset = "0x440DE0", VA = "0x1804423E0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x060018FA RID: 6394 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060018FB RID: 6395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000463")]
		public TransitRoute DestinationRoute
		{
			[Token(Token = "0x60018FA")]
			[Address(RVA = "0x432BA0", Offset = "0x4315A0", VA = "0x180432BA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60018FB")]
			[Address(RVA = "0x4BEDD0", Offset = "0x4BD7D0", VA = "0x1804BEDD0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x060018FC RID: 6396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018FC")]
		[Address(RVA = "0x607650", Offset = "0x606050", VA = "0x180607650")]
		public LabOvenConfiguration(ConfigurationReplicator replicator, IConfigurable configurable, LabOven oven)
		{
		}

		// Token: 0x060018FD RID: 6397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018FD")]
		[Address(RVA = "0x5FD4E0", Offset = "0x5FBEE0", VA = "0x1805FD4E0", Slot = "5")]
		public override void Reset()
		{
		}

		// Token: 0x060018FE RID: 6398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018FE")]
		[Address(RVA = "0x607300", Offset = "0x605D00", VA = "0x180607300")]
		private void DestinationChanged(BuildableItem item)
		{
		}

		// Token: 0x060018FF RID: 6399 RVA: 0x00008F28 File Offset: 0x00007128
		[Token(Token = "0x60018FF")]
		[Address(RVA = "0x607440", Offset = "0x605E40", VA = "0x180607440")]
		public bool DestinationFilter(BuildableItem obj, out string reason)
		{
			return default(bool);
		}

		// Token: 0x06001900 RID: 6400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001900")]
		[Address(RVA = "0x5FD520", Offset = "0x5FBF20", VA = "0x1805FD520", Slot = "6")]
		public override void Selected()
		{
		}

		// Token: 0x06001901 RID: 6401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001901")]
		[Address(RVA = "0x5FD1E0", Offset = "0x5FBBE0", VA = "0x1805FD1E0", Slot = "7")]
		public override void Deselected()
		{
		}

		// Token: 0x06001902 RID: 6402 RVA: 0x00008F40 File Offset: 0x00007140
		[Token(Token = "0x6001902")]
		[Address(RVA = "0x6075E0", Offset = "0x605FE0", VA = "0x1806075E0", Slot = "8")]
		public override bool ShouldSave()
		{
			return default(bool);
		}

		// Token: 0x06001903 RID: 6403 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001903")]
		[Address(RVA = "0x607550", Offset = "0x605F50", VA = "0x180607550", Slot = "9")]
		public override string GetSaveString()
		{
			return null;
		}

		// Token: 0x04001613 RID: 5651
		[Token(Token = "0x4001613")]
		[FieldOffset(Offset = "0x40")]
		public NPCField AssignedChemist;

		// Token: 0x04001614 RID: 5652
		[Token(Token = "0x4001614")]
		[FieldOffset(Offset = "0x48")]
		public ObjectField Destination;
	}
}
