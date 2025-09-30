using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.Levelling;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Loaders;

namespace ScheduleOne.Graffiti
{
	// Token: 0x02000588 RID: 1416
	[Token(Token = "0x2000588")]
	public class GraffitiManager : NetworkSingleton<GraffitiManager>, IBaseSaveable, ISaveable
	{
		// Token: 0x1700057B RID: 1403
		// (get) Token: 0x06001FD2 RID: 8146 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001FD3 RID: 8147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700057B")]
		public List<SpraySurface> SpraySurfaces
		{
			[Token(Token = "0x6001FD2")]
			[Address(RVA = "0x62FD10", Offset = "0x62E710", VA = "0x18062FD10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001FD3")]
			[Address(RVA = "0x630490", Offset = "0x62EE90", VA = "0x180630490")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700057C RID: 1404
		// (get) Token: 0x06001FD4 RID: 8148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700057C")]
		public string SaveFolderName
		{
			[Token(Token = "0x6001FD4")]
			[Address(RVA = "0x672D90", Offset = "0x671790", VA = "0x180672D90", Slot = "26")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700057D RID: 1405
		// (get) Token: 0x06001FD5 RID: 8149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700057D")]
		public string SaveFileName
		{
			[Token(Token = "0x6001FD5")]
			[Address(RVA = "0x672D60", Offset = "0x671760", VA = "0x180672D60", Slot = "27")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700057E RID: 1406
		// (get) Token: 0x06001FD6 RID: 8150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700057E")]
		public Loader Loader
		{
			[Token(Token = "0x6001FD6")]
			[Address(RVA = "0x548950", Offset = "0x547350", VA = "0x180548950", Slot = "28")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700057F RID: 1407
		// (get) Token: 0x06001FD7 RID: 8151 RVA: 0x0000A608 File Offset: 0x00008808
		[Token(Token = "0x1700057F")]
		public bool ShouldSaveUnderFolder
		{
			[Token(Token = "0x6001FD7")]
			[Address(RVA = "0x4B7AD0", Offset = "0x4B64D0", VA = "0x1804B7AD0", Slot = "29")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000580 RID: 1408
		// (get) Token: 0x06001FD8 RID: 8152 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001FD9 RID: 8153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000580")]
		public List<string> LocalExtraFiles
		{
			[Token(Token = "0x6001FD8")]
			[Address(RVA = "0x672D40", Offset = "0x671740", VA = "0x180672D40", Slot = "30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001FD9")]
			[Address(RVA = "0x672DD0", Offset = "0x6717D0", VA = "0x180672DD0", Slot = "31")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000581 RID: 1409
		// (get) Token: 0x06001FDA RID: 8154 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001FDB RID: 8155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000581")]
		public List<string> LocalExtraFolders
		{
			[Token(Token = "0x6001FDA")]
			[Address(RVA = "0x672D50", Offset = "0x671750", VA = "0x180672D50", Slot = "32")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001FDB")]
			[Address(RVA = "0x672DF0", Offset = "0x6717F0", VA = "0x180672DF0", Slot = "33")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000582 RID: 1410
		// (get) Token: 0x06001FDC RID: 8156 RVA: 0x0000A620 File Offset: 0x00008820
		// (set) Token: 0x06001FDD RID: 8157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000582")]
		public bool HasChanged
		{
			[Token(Token = "0x6001FDC")]
			[Address(RVA = "0x5381D0", Offset = "0x536BD0", VA = "0x1805381D0", Slot = "34")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001FDD")]
			[Address(RVA = "0x672DC0", Offset = "0x6717C0", VA = "0x180672DC0", Slot = "35")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000583 RID: 1411
		// (get) Token: 0x06001FDE RID: 8158 RVA: 0x0000A638 File Offset: 0x00008838
		[Token(Token = "0x17000583")]
		public int LoadOrder
		{
			[Token(Token = "0x6001FDE")]
			[Address(RVA = "0x5385F0", Offset = "0x536FF0", VA = "0x1805385F0", Slot = "25")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		// Token: 0x06001FDF RID: 8159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FDF")]
		[Address(RVA = "0x671C90", Offset = "0x670690", VA = "0x180671C90", Slot = "20")]
		public override void Awake()
		{
		}

		// Token: 0x06001FE0 RID: 8160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FE0")]
		[Address(RVA = "0x672160", Offset = "0x670B60", VA = "0x180672160", Slot = "6")]
		public override void OnStartServer()
		{
		}

		// Token: 0x06001FE1 RID: 8161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FE1")]
		[Address(RVA = "0x672B10", Offset = "0x671510", VA = "0x180672B10")]
		private void Update()
		{
		}

		// Token: 0x06001FE2 RID: 8162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FE2")]
		[Address(RVA = "0x672030", Offset = "0x670A30", VA = "0x180672030", Slot = "49")]
		public virtual void InitializeSaveable()
		{
		}

		// Token: 0x06001FE3 RID: 8163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FE3")]
		[Address(RVA = "0x672620", Offset = "0x671020", VA = "0x180672620")]
		private void SprayPaintPurchaseCountChanged(float newValue)
		{
		}

		// Token: 0x06001FE4 RID: 8164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FE4")]
		[Address(RVA = "0x672620", Offset = "0x671020", VA = "0x180672620")]
		private void RankChange(FullRank oldRank, FullRank newRank)
		{
		}

		// Token: 0x06001FE5 RID: 8165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FE5")]
		[Address(RVA = "0x6728E0", Offset = "0x6712E0", VA = "0x1806728E0")]
		private void UpdateSprayPaintStockVariable()
		{
		}

		// Token: 0x06001FE6 RID: 8166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FE6")]
		[Address(RVA = "0x671D10", Offset = "0x670710", VA = "0x180671D10", Slot = "50")]
		public virtual string GetSaveString()
		{
			return null;
		}

		// Token: 0x06001FE7 RID: 8167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FE7")]
		[Address(RVA = "0x672520", Offset = "0x670F20", VA = "0x180672520")]
		public void QueueSurfaceToReplicate(SpraySurface surface, NetworkConnection conn)
		{
		}

		// Token: 0x06001FE8 RID: 8168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FE8")]
		[Address(RVA = "0x672630", Offset = "0x671030", VA = "0x180672630")]
		public void RemoveFromReplicationQueueIfPresent(SpraySurface surface)
		{
		}

		// Token: 0x06001FE9 RID: 8169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FE9")]
		[Address(RVA = "0x672710", Offset = "0x671110", VA = "0x180672710")]
		private void ReplicateSurface()
		{
		}

		// Token: 0x06001FEA RID: 8170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FEA")]
		[Address(RVA = "0x672BA0", Offset = "0x6715A0", VA = "0x180672BA0")]
		public GraffitiManager()
		{
		}

		// Token: 0x06001FEB RID: 8171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FEB")]
		[Address(RVA = "0x672110", Offset = "0x670B10", VA = "0x180672110", Slot = "22")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06001FEC RID: 8172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FEC")]
		[Address(RVA = "0x6720C0", Offset = "0x670AC0", VA = "0x1806720C0", Slot = "23")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06001FED RID: 8173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FED")]
		[Address(RVA = "0x5B3020", Offset = "0x5B1A20", VA = "0x1805B3020", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06001FEE RID: 8174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FEE")]
		[Address(RVA = "0x671C40", Offset = "0x670640", VA = "0x180671C40", Slot = "51")]
		protected virtual void Awake_UserLogic_ScheduleOne.Graffiti.GraffitiManager_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04001A22 RID: 6690
		[Token(Token = "0x4001A22")]
		private const string SPRAY_PAINT_STOCK_VARIABLE = "SprayPaintStock";

		// Token: 0x04001A23 RID: 6691
		[Token(Token = "0x4001A23")]
		private const string SPRAY_PAINTS_PURCHASED_VARIABLE = "SprayPaintsPurchased";

		// Token: 0x04001A25 RID: 6693
		[Token(Token = "0x4001A25")]
		[FieldOffset(Offset = "0x128")]
		private GraffitiLoader loader;

		// Token: 0x04001A2A RID: 6698
		[Token(Token = "0x4001A2A")]
		[FieldOffset(Offset = "0x148")]
		private List<Tuple<SpraySurface, NetworkConnection>> surfaceReplicationQueue;

		// Token: 0x04001A2B RID: 6699
		[Token(Token = "0x4001A2B")]
		[FieldOffset(Offset = "0x150")]
		private float timeUntilNextReplication;

		// Token: 0x04001A2C RID: 6700
		[Token(Token = "0x4001A2C")]
		[FieldOffset(Offset = "0x154")]
		private bool NetworkInitialize___EarlyScheduleOne.Graffiti.GraffitiManagerAssembly-CSharp.dll_Excuted;

		// Token: 0x04001A2D RID: 6701
		[Token(Token = "0x4001A2D")]
		[FieldOffset(Offset = "0x155")]
		private bool NetworkInitialize__LateScheduleOne.Graffiti.GraffitiManagerAssembly-CSharp.dll_Excuted;
	}
}
