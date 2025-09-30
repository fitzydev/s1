using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.EntityFramework;
using ScheduleOne.ObjectScripts;

namespace ScheduleOne.Management
{
	// Token: 0x020004D4 RID: 1236
	[Token(Token = "0x20004D4")]
	public class BrickPressConfiguration : EntityConfiguration
	{
		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x06001893 RID: 6291 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001894 RID: 6292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000451")]
		public BrickPress BrickPress
		{
			[Token(Token = "0x6001893")]
			[Address(RVA = "0x4423B0", Offset = "0x440DB0", VA = "0x1804423B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001894")]
			[Address(RVA = "0x4423E0", Offset = "0x440DE0", VA = "0x1804423E0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000452 RID: 1106
		// (get) Token: 0x06001895 RID: 6293 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001896 RID: 6294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000452")]
		public TransitRoute DestinationRoute
		{
			[Token(Token = "0x6001895")]
			[Address(RVA = "0x432BA0", Offset = "0x4315A0", VA = "0x180432BA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001896")]
			[Address(RVA = "0x4BEDD0", Offset = "0x4BD7D0", VA = "0x1804BEDD0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06001897 RID: 6295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001897")]
		[Address(RVA = "0x5FD5B0", Offset = "0x5FBFB0", VA = "0x1805FD5B0")]
		public BrickPressConfiguration(ConfigurationReplicator replicator, IConfigurable configurable, BrickPress station)
		{
		}

		// Token: 0x06001898 RID: 6296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001898")]
		[Address(RVA = "0x5FD4E0", Offset = "0x5FBEE0", VA = "0x1805FD4E0", Slot = "5")]
		public override void Reset()
		{
		}

		// Token: 0x06001899 RID: 6297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001899")]
		[Address(RVA = "0x5FD200", Offset = "0x5FBC00", VA = "0x1805FD200")]
		private void DestinationChanged(BuildableItem item)
		{
		}

		// Token: 0x0600189A RID: 6298 RVA: 0x00008DC0 File Offset: 0x00006FC0
		[Token(Token = "0x600189A")]
		[Address(RVA = "0x5FD340", Offset = "0x5FBD40", VA = "0x1805FD340")]
		public bool DestinationFilter(BuildableItem obj, out string reason)
		{
			return default(bool);
		}

		// Token: 0x0600189B RID: 6299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600189B")]
		[Address(RVA = "0x5FD520", Offset = "0x5FBF20", VA = "0x1805FD520", Slot = "6")]
		public override void Selected()
		{
		}

		// Token: 0x0600189C RID: 6300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600189C")]
		[Address(RVA = "0x5FD1E0", Offset = "0x5FBBE0", VA = "0x1805FD1E0", Slot = "7")]
		public override void Deselected()
		{
		}

		// Token: 0x0600189D RID: 6301 RVA: 0x00008DD8 File Offset: 0x00006FD8
		[Token(Token = "0x600189D")]
		[Address(RVA = "0x5FD540", Offset = "0x5FBF40", VA = "0x1805FD540", Slot = "8")]
		public override bool ShouldSave()
		{
			return default(bool);
		}

		// Token: 0x0600189E RID: 6302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600189E")]
		[Address(RVA = "0x5FD450", Offset = "0x5FBE50", VA = "0x1805FD450", Slot = "9")]
		public override string GetSaveString()
		{
			return null;
		}

		// Token: 0x040015EF RID: 5615
		[Token(Token = "0x40015EF")]
		[FieldOffset(Offset = "0x40")]
		public NPCField AssignedPackager;

		// Token: 0x040015F0 RID: 5616
		[Token(Token = "0x40015F0")]
		[FieldOffset(Offset = "0x48")]
		public ObjectField Destination;
	}
}
