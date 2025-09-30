using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.EntityFramework;
using ScheduleOne.ObjectScripts;

namespace ScheduleOne.Management
{
	// Token: 0x020004DE RID: 1246
	[Token(Token = "0x20004DE")]
	public class PackagingStationConfiguration : EntityConfiguration
	{
		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x06001923 RID: 6435 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001924 RID: 6436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000469")]
		public PackagingStation Station
		{
			[Token(Token = "0x6001923")]
			[Address(RVA = "0x4423B0", Offset = "0x440DB0", VA = "0x1804423B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001924")]
			[Address(RVA = "0x4423E0", Offset = "0x440DE0", VA = "0x1804423E0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700046A RID: 1130
		// (get) Token: 0x06001925 RID: 6437 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001926 RID: 6438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700046A")]
		public TransitRoute DestinationRoute
		{
			[Token(Token = "0x6001925")]
			[Address(RVA = "0x432BA0", Offset = "0x4315A0", VA = "0x180432BA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001926")]
			[Address(RVA = "0x4BEDD0", Offset = "0x4BD7D0", VA = "0x1804BEDD0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06001927 RID: 6439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001927")]
		[Address(RVA = "0x60ECD0", Offset = "0x60D6D0", VA = "0x18060ECD0")]
		public PackagingStationConfiguration(ConfigurationReplicator replicator, IConfigurable configurable, PackagingStation station)
		{
		}

		// Token: 0x06001928 RID: 6440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001928")]
		[Address(RVA = "0x5FD4E0", Offset = "0x5FBEE0", VA = "0x1805FD4E0", Slot = "5")]
		public override void Reset()
		{
		}

		// Token: 0x06001929 RID: 6441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001929")]
		[Address(RVA = "0x60E980", Offset = "0x60D380", VA = "0x18060E980")]
		private void DestinationChanged(BuildableItem item)
		{
		}

		// Token: 0x0600192A RID: 6442 RVA: 0x00008FD0 File Offset: 0x000071D0
		[Token(Token = "0x600192A")]
		[Address(RVA = "0x60EAC0", Offset = "0x60D4C0", VA = "0x18060EAC0")]
		public bool DestinationFilter(BuildableItem obj, out string reason)
		{
			return default(bool);
		}

		// Token: 0x0600192B RID: 6443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600192B")]
		[Address(RVA = "0x5FD520", Offset = "0x5FBF20", VA = "0x1805FD520", Slot = "6")]
		public override void Selected()
		{
		}

		// Token: 0x0600192C RID: 6444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600192C")]
		[Address(RVA = "0x5FD1E0", Offset = "0x5FBBE0", VA = "0x1805FD1E0", Slot = "7")]
		public override void Deselected()
		{
		}

		// Token: 0x0600192D RID: 6445 RVA: 0x00008FE8 File Offset: 0x000071E8
		[Token(Token = "0x600192D")]
		[Address(RVA = "0x60EC60", Offset = "0x60D660", VA = "0x18060EC60", Slot = "8")]
		public override bool ShouldSave()
		{
			return default(bool);
		}

		// Token: 0x0600192E RID: 6446 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600192E")]
		[Address(RVA = "0x60EBD0", Offset = "0x60D5D0", VA = "0x18060EBD0", Slot = "9")]
		public override string GetSaveString()
		{
			return null;
		}

		// Token: 0x04001623 RID: 5667
		[Token(Token = "0x4001623")]
		[FieldOffset(Offset = "0x40")]
		public NPCField AssignedPackager;

		// Token: 0x04001624 RID: 5668
		[Token(Token = "0x4001624")]
		[FieldOffset(Offset = "0x48")]
		public ObjectField Destination;
	}
}
