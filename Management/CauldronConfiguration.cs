using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.EntityFramework;
using ScheduleOne.ObjectScripts;

namespace ScheduleOne.Management
{
	// Token: 0x020004D5 RID: 1237
	[Token(Token = "0x20004D5")]
	public class CauldronConfiguration : EntityConfiguration
	{
		// Token: 0x17000453 RID: 1107
		// (get) Token: 0x060018A1 RID: 6305 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060018A2 RID: 6306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000453")]
		public Cauldron Station
		{
			[Token(Token = "0x60018A1")]
			[Address(RVA = "0x4423B0", Offset = "0x440DB0", VA = "0x1804423B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60018A2")]
			[Address(RVA = "0x4423E0", Offset = "0x440DE0", VA = "0x1804423E0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x060018A3 RID: 6307 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060018A4 RID: 6308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000454")]
		public TransitRoute DestinationRoute
		{
			[Token(Token = "0x60018A3")]
			[Address(RVA = "0x432BA0", Offset = "0x4315A0", VA = "0x180432BA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60018A4")]
			[Address(RVA = "0x4BEDD0", Offset = "0x4BD7D0", VA = "0x1804BEDD0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x060018A5 RID: 6309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018A5")]
		[Address(RVA = "0x5FDE90", Offset = "0x5FC890", VA = "0x1805FDE90")]
		public CauldronConfiguration(ConfigurationReplicator replicator, IConfigurable configurable, Cauldron cauldron)
		{
		}

		// Token: 0x060018A6 RID: 6310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018A6")]
		[Address(RVA = "0x5FD4E0", Offset = "0x5FBEE0", VA = "0x1805FD4E0", Slot = "5")]
		public override void Reset()
		{
		}

		// Token: 0x060018A7 RID: 6311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018A7")]
		[Address(RVA = "0x5FDB40", Offset = "0x5FC540", VA = "0x1805FDB40")]
		private void DestinationChanged(BuildableItem item)
		{
		}

		// Token: 0x060018A8 RID: 6312 RVA: 0x00008DF0 File Offset: 0x00006FF0
		[Token(Token = "0x60018A8")]
		[Address(RVA = "0x5FDC80", Offset = "0x5FC680", VA = "0x1805FDC80")]
		public bool DestinationFilter(BuildableItem obj, out string reason)
		{
			return default(bool);
		}

		// Token: 0x060018A9 RID: 6313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018A9")]
		[Address(RVA = "0x5FD520", Offset = "0x5FBF20", VA = "0x1805FD520", Slot = "6")]
		public override void Selected()
		{
		}

		// Token: 0x060018AA RID: 6314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018AA")]
		[Address(RVA = "0x5FD1E0", Offset = "0x5FBBE0", VA = "0x1805FD1E0", Slot = "7")]
		public override void Deselected()
		{
		}

		// Token: 0x060018AB RID: 6315 RVA: 0x00008E08 File Offset: 0x00007008
		[Token(Token = "0x60018AB")]
		[Address(RVA = "0x5FDE20", Offset = "0x5FC820", VA = "0x1805FDE20", Slot = "8")]
		public override bool ShouldSave()
		{
			return default(bool);
		}

		// Token: 0x060018AC RID: 6316 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018AC")]
		[Address(RVA = "0x5FDD90", Offset = "0x5FC790", VA = "0x1805FDD90", Slot = "9")]
		public override string GetSaveString()
		{
			return null;
		}

		// Token: 0x040015F3 RID: 5619
		[Token(Token = "0x40015F3")]
		[FieldOffset(Offset = "0x40")]
		public NPCField AssignedChemist;

		// Token: 0x040015F4 RID: 5620
		[Token(Token = "0x40015F4")]
		[FieldOffset(Offset = "0x48")]
		public ObjectField Destination;
	}
}
