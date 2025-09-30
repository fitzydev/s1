using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.Map;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Loaders;

namespace ScheduleOne.Levelling
{
	// Token: 0x0200051F RID: 1311
	[Token(Token = "0x200051F")]
	public class LevelManager : NetworkSingleton<LevelManager>, IBaseSaveable, ISaveable
	{
		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x06001AA9 RID: 6825 RVA: 0x00009528 File Offset: 0x00007728
		// (set) Token: 0x06001AAA RID: 6826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004A8")]
		public ERank Rank
		{
			[Token(Token = "0x6001AA9")]
			[Address(RVA = "0x548860", Offset = "0x547260", VA = "0x180548860")]
			[CompilerGenerated]
			get
			{
				return ERank.Street_Rat;
			}
			[Token(Token = "0x6001AAA")]
			[Address(RVA = "0x63DAA0", Offset = "0x63C4A0", VA = "0x18063DAA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x06001AAB RID: 6827 RVA: 0x00009540 File Offset: 0x00007740
		// (set) Token: 0x06001AAC RID: 6828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004A9")]
		public int Tier
		{
			[Token(Token = "0x6001AAB")]
			[Address(RVA = "0x542EE0", Offset = "0x5418E0", VA = "0x180542EE0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001AAC")]
			[Address(RVA = "0x63DAB0", Offset = "0x63C4B0", VA = "0x18063DAB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x06001AAD RID: 6829 RVA: 0x00009558 File Offset: 0x00007758
		// (set) Token: 0x06001AAE RID: 6830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004AA")]
		public int XP
		{
			[Token(Token = "0x6001AAD")]
			[Address(RVA = "0x63DA40", Offset = "0x63C440", VA = "0x18063DA40")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001AAE")]
			[Address(RVA = "0x63DAC0", Offset = "0x63C4C0", VA = "0x18063DAC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x06001AAF RID: 6831 RVA: 0x00009570 File Offset: 0x00007770
		// (set) Token: 0x06001AB0 RID: 6832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004AB")]
		public int TotalXP
		{
			[Token(Token = "0x6001AAF")]
			[Address(RVA = "0x5489A0", Offset = "0x5473A0", VA = "0x1805489A0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001AB0")]
			[Address(RVA = "0x548DF0", Offset = "0x5477F0", VA = "0x180548DF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x06001AB1 RID: 6833 RVA: 0x00009588 File Offset: 0x00007788
		[Token(Token = "0x170004AC")]
		public float XPToNextTier
		{
			[Token(Token = "0x6001AB1")]
			[Address(RVA = "0x63D9D0", Offset = "0x63C3D0", VA = "0x18063D9D0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x06001AB2 RID: 6834 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004AD")]
		public string SaveFolderName
		{
			[Token(Token = "0x6001AB2")]
			[Address(RVA = "0x63D9A0", Offset = "0x63C3A0", VA = "0x18063D9A0", Slot = "26")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x06001AB3 RID: 6835 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004AE")]
		public string SaveFileName
		{
			[Token(Token = "0x6001AB3")]
			[Address(RVA = "0x63D970", Offset = "0x63C370", VA = "0x18063D970", Slot = "27")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x06001AB4 RID: 6836 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004AF")]
		public Loader Loader
		{
			[Token(Token = "0x6001AB4")]
			[Address(RVA = "0x63D950", Offset = "0x63C350", VA = "0x18063D950", Slot = "28")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x06001AB5 RID: 6837 RVA: 0x000095A0 File Offset: 0x000077A0
		[Token(Token = "0x170004B0")]
		public bool ShouldSaveUnderFolder
		{
			[Token(Token = "0x6001AB5")]
			[Address(RVA = "0x4B7AD0", Offset = "0x4B64D0", VA = "0x1804B7AD0", Slot = "29")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x06001AB6 RID: 6838 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001AB7 RID: 6839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004B1")]
		public List<string> LocalExtraFiles
		{
			[Token(Token = "0x6001AB6")]
			[Address(RVA = "0x63D960", Offset = "0x63C360", VA = "0x18063D960", Slot = "30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001AB7")]
			[Address(RVA = "0x63DA60", Offset = "0x63C460", VA = "0x18063DA60", Slot = "31")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x06001AB8 RID: 6840 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001AB9 RID: 6841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004B2")]
		public List<string> LocalExtraFolders
		{
			[Token(Token = "0x6001AB8")]
			[Address(RVA = "0x630180", Offset = "0x62EB80", VA = "0x180630180", Slot = "32")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001AB9")]
			[Address(RVA = "0x63DA80", Offset = "0x63C480", VA = "0x18063DA80", Slot = "33")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x06001ABA RID: 6842 RVA: 0x000095B8 File Offset: 0x000077B8
		// (set) Token: 0x06001ABB RID: 6843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004B3")]
		public bool HasChanged
		{
			[Token(Token = "0x6001ABA")]
			[Address(RVA = "0x63D930", Offset = "0x63C330", VA = "0x18063D930", Slot = "34")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001ABB")]
			[Address(RVA = "0x63DA50", Offset = "0x63C450", VA = "0x18063DA50", Slot = "35")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x06001ABC RID: 6844 RVA: 0x000095D0 File Offset: 0x000077D0
		[Token(Token = "0x170004B4")]
		public int LoadOrder
		{
			[Token(Token = "0x6001ABC")]
			[Address(RVA = "0x63D940", Offset = "0x63C340", VA = "0x18063D940", Slot = "25")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		// Token: 0x06001ABD RID: 6845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ABD")]
		[Address(RVA = "0x63AC50", Offset = "0x639650", VA = "0x18063AC50", Slot = "20")]
		public override void Awake()
		{
		}

		// Token: 0x06001ABE RID: 6846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ABE")]
		[Address(RVA = "0x63D780", Offset = "0x63C180", VA = "0x18063D780", Slot = "19")]
		protected override void Start()
		{
		}

		// Token: 0x06001ABF RID: 6847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ABF")]
		[Address(RVA = "0x63BBA0", Offset = "0x63A5A0", VA = "0x18063BBA0", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x06001AC0 RID: 6848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AC0")]
		[Address(RVA = "0x63B870", Offset = "0x63A270", VA = "0x18063B870", Slot = "49")]
		public virtual void InitializeSaveable()
		{
		}

		// Token: 0x06001AC1 RID: 6849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AC1")]
		[Address(RVA = "0x63AA40", Offset = "0x639440", VA = "0x18063AA40")]
		[ServerRpc(RequireOwnership = false)]
		public void AddXP(int xp)
		{
		}

		// Token: 0x06001AC2 RID: 6850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AC2")]
		[Address(RVA = "0x63A8F0", Offset = "0x6392F0", VA = "0x18063A8F0")]
		[ObserversRpc]
		private void AddXPLocal(int xp)
		{
		}

		// Token: 0x06001AC3 RID: 6851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AC3")]
		[Address(RVA = "0x63D190", Offset = "0x63BB90", VA = "0x18063D190")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public void SetData(NetworkConnection conn, ERank rank, int tier, int xp, int totalXp)
		{
		}

		// Token: 0x06001AC4 RID: 6852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AC4")]
		[Address(RVA = "0x63D520", Offset = "0x63BF20", VA = "0x18063D520")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public void SetUnlockedRegions(NetworkConnection conn, List<EMapRegion> unlockedRegions)
		{
		}

		// Token: 0x06001AC5 RID: 6853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AC5")]
		[Address(RVA = "0x63B640", Offset = "0x63A040", VA = "0x18063B640")]
		[ObserversRpc]
		private void IncreaseTierNetworked(FullRank before, FullRank after)
		{
		}

		// Token: 0x06001AC6 RID: 6854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AC6")]
		[Address(RVA = "0x63B7B0", Offset = "0x63A1B0", VA = "0x18063B7B0")]
		private void IncreaseTier()
		{
		}

		// Token: 0x06001AC7 RID: 6855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AC7")]
		[Address(RVA = "0x63B1A0", Offset = "0x639BA0", VA = "0x18063B1A0", Slot = "50")]
		public virtual string GetSaveString()
		{
			return null;
		}

		// Token: 0x06001AC8 RID: 6856 RVA: 0x000095E8 File Offset: 0x000077E8
		[Token(Token = "0x6001AC8")]
		[Address(RVA = "0x63AD50", Offset = "0x639750", VA = "0x18063AD50")]
		public FullRank GetFullRank()
		{
			return default(FullRank);
		}

		// Token: 0x06001AC9 RID: 6857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AC9")]
		[Address(RVA = "0x63A660", Offset = "0x639060", VA = "0x18063A660")]
		public void AddUnlockable(Unlockable unlockable)
		{
		}

		// Token: 0x06001ACA RID: 6858 RVA: 0x00009600 File Offset: 0x00007800
		[Token(Token = "0x6001ACA")]
		[Address(RVA = "0x63B330", Offset = "0x639D30", VA = "0x18063B330")]
		public int GetTotalXPForRank(FullRank fullrank)
		{
			return 0;
		}

		// Token: 0x06001ACB RID: 6859 RVA: 0x00009618 File Offset: 0x00007818
		[Token(Token = "0x6001ACB")]
		[Address(RVA = "0x63AD70", Offset = "0x639770", VA = "0x18063AD70")]
		public FullRank GetFullRank(int totalXp)
		{
			return default(FullRank);
		}

		// Token: 0x06001ACC RID: 6860 RVA: 0x00009630 File Offset: 0x00007830
		[Token(Token = "0x6001ACC")]
		[Address(RVA = "0x63B5D0", Offset = "0x639FD0", VA = "0x18063B5D0")]
		public int GetXPForTier(ERank rank)
		{
			return 0;
		}

		// Token: 0x06001ACD RID: 6861 RVA: 0x00009648 File Offset: 0x00007848
		[Token(Token = "0x6001ACD")]
		[Address(RVA = "0x63B030", Offset = "0x639A30", VA = "0x18063B030")]
		public static float GetOrderLimitMultiplier(FullRank rank)
		{
			return 0f;
		}

		// Token: 0x06001ACE RID: 6862 RVA: 0x00009660 File Offset: 0x00007860
		[Token(Token = "0x6001ACE")]
		[Address(RVA = "0x63B0F0", Offset = "0x639AF0", VA = "0x18063B0F0")]
		private static float GetRankOrderLimitMultiplier(ERank rank)
		{
			return 0f;
		}

		// Token: 0x06001ACF RID: 6863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ACF")]
		[Address(RVA = "0x63D7D0", Offset = "0x63C1D0", VA = "0x18063D7D0")]
		public LevelManager()
		{
		}

		// Token: 0x06001AD0 RID: 6864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AD0")]
		[Address(RVA = "0x63B950", Offset = "0x63A350", VA = "0x18063B950", Slot = "22")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06001AD1 RID: 6865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AD1")]
		[Address(RVA = "0x63B900", Offset = "0x63A300", VA = "0x18063B900", Slot = "23")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06001AD2 RID: 6866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AD2")]
		[Address(RVA = "0x5B3020", Offset = "0x5B1A20", VA = "0x1805B3020", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06001AD3 RID: 6867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AD3")]
		[Address(RVA = "0x63AA40", Offset = "0x639440", VA = "0x18063AA40")]
		private void RpcWriter___Server_AddXP_3316948804(int xp)
		{
		}

		// Token: 0x06001AD4 RID: 6868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AD4")]
		[Address(RVA = "0x63A8F0", Offset = "0x6392F0", VA = "0x18063A8F0")]
		public void RpcLogic___AddXP_3316948804(int xp)
		{
		}

		// Token: 0x06001AD5 RID: 6869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AD5")]
		[Address(RVA = "0x63C880", Offset = "0x63B280", VA = "0x18063C880")]
		private void RpcReader___Server_AddXP_3316948804(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06001AD6 RID: 6870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AD6")]
		[Address(RVA = "0x63A8F0", Offset = "0x6392F0", VA = "0x18063A8F0")]
		private void RpcWriter___Observers_AddXPLocal_3316948804(int xp)
		{
		}

		// Token: 0x06001AD7 RID: 6871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AD7")]
		[Address(RVA = "0x63BCA0", Offset = "0x63A6A0", VA = "0x18063BCA0")]
		private void RpcLogic___AddXPLocal_3316948804(int xp)
		{
		}

		// Token: 0x06001AD8 RID: 6872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AD8")]
		[Address(RVA = "0x63C560", Offset = "0x63AF60", VA = "0x18063C560")]
		private void RpcReader___Observers_AddXPLocal_3316948804(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001AD9 RID: 6873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AD9")]
		[Address(RVA = "0x63CB80", Offset = "0x63B580", VA = "0x18063CB80")]
		private void RpcWriter___Observers_SetData_20965027(NetworkConnection conn, ERank rank, int tier, int xp, int totalXp)
		{
		}

		// Token: 0x06001ADA RID: 6874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ADA")]
		[Address(RVA = "0x63C370", Offset = "0x63AD70", VA = "0x18063C370")]
		public void RpcLogic___SetData_20965027(NetworkConnection conn, ERank rank, int tier, int xp, int totalXp)
		{
		}

		// Token: 0x06001ADB RID: 6875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ADB")]
		[Address(RVA = "0x63C710", Offset = "0x63B110", VA = "0x18063C710")]
		private void RpcReader___Observers_SetData_20965027(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001ADC RID: 6876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ADC")]
		[Address(RVA = "0x63CE80", Offset = "0x63B880", VA = "0x18063CE80")]
		private void RpcWriter___Target_SetData_20965027(NetworkConnection conn, ERank rank, int tier, int xp, int totalXp)
		{
		}

		// Token: 0x06001ADD RID: 6877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ADD")]
		[Address(RVA = "0x63CA10", Offset = "0x63B410", VA = "0x18063CA10")]
		private void RpcReader___Target_SetData_20965027(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001ADE RID: 6878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ADE")]
		[Address(RVA = "0x63CD40", Offset = "0x63B740", VA = "0x18063CD40")]
		private void RpcWriter___Observers_SetUnlockedRegions_563230222(NetworkConnection conn, List<EMapRegion> unlockedRegions)
		{
		}

		// Token: 0x06001ADF RID: 6879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ADF")]
		[Address(RVA = "0x63C3F0", Offset = "0x63ADF0", VA = "0x18063C3F0")]
		public void RpcLogic___SetUnlockedRegions_563230222(NetworkConnection conn, List<EMapRegion> unlockedRegions)
		{
		}

		// Token: 0x06001AE0 RID: 6880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AE0")]
		[Address(RVA = "0x63C820", Offset = "0x63B220", VA = "0x18063C820")]
		private void RpcReader___Observers_SetUnlockedRegions_563230222(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001AE1 RID: 6881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AE1")]
		[Address(RVA = "0x63D030", Offset = "0x63BA30", VA = "0x18063D030")]
		private void RpcWriter___Target_SetUnlockedRegions_563230222(NetworkConnection conn, List<EMapRegion> unlockedRegions)
		{
		}

		// Token: 0x06001AE2 RID: 6882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AE2")]
		[Address(RVA = "0x63CB20", Offset = "0x63B520", VA = "0x18063CB20")]
		private void RpcReader___Target_SetUnlockedRegions_563230222(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001AE3 RID: 6883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AE3")]
		[Address(RVA = "0x63B640", Offset = "0x63A040", VA = "0x18063B640")]
		private void RpcWriter___Observers_IncreaseTierNetworked_3953286437(FullRank before, FullRank after)
		{
		}

		// Token: 0x06001AE4 RID: 6884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AE4")]
		[Address(RVA = "0x63C250", Offset = "0x63AC50", VA = "0x18063C250")]
		private void RpcLogic___IncreaseTierNetworked_3953286437(FullRank before, FullRank after)
		{
		}

		// Token: 0x06001AE5 RID: 6885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AE5")]
		[Address(RVA = "0x63C5C0", Offset = "0x63AFC0", VA = "0x18063C5C0")]
		private void RpcReader___Observers_IncreaseTierNetworked_3953286437(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001AE6 RID: 6886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AE6")]
		[Address(RVA = "0x63AB80", Offset = "0x639580", VA = "0x18063AB80", Slot = "51")]
		protected virtual void Awake_UserLogic_ScheduleOne.Levelling.LevelManager_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04001703 RID: 5891
		[Token(Token = "0x4001703")]
		public const int TIERS_PER_RANK = 5;

		// Token: 0x04001704 RID: 5892
		[Token(Token = "0x4001704")]
		public const int XP_PER_TIER_MIN = 200;

		// Token: 0x04001705 RID: 5893
		[Token(Token = "0x4001705")]
		public const int XP_PER_TIER_MAX = 2500;

		// Token: 0x04001707 RID: 5895
		[Token(Token = "0x4001707")]
		[FieldOffset(Offset = "0x124")]
		private int rankCount;

		// Token: 0x0400170B RID: 5899
		[Token(Token = "0x400170B")]
		[FieldOffset(Offset = "0x138")]
		public Action<FullRank, FullRank> onRankUp;

		// Token: 0x0400170C RID: 5900
		[Token(Token = "0x400170C")]
		[FieldOffset(Offset = "0x140")]
		public Action<FullRank, FullRank> onRankChanged;

		// Token: 0x0400170D RID: 5901
		[Token(Token = "0x400170D")]
		[FieldOffset(Offset = "0x148")]
		public Dictionary<FullRank, List<Unlockable>> Unlockables;

		// Token: 0x0400170E RID: 5902
		[Token(Token = "0x400170E")]
		[FieldOffset(Offset = "0x150")]
		private RankLoader loader;

		// Token: 0x04001713 RID: 5907
		[Token(Token = "0x4001713")]
		[FieldOffset(Offset = "0x170")]
		private bool NetworkInitialize___EarlyScheduleOne.Levelling.LevelManagerAssembly-CSharp.dll_Excuted;

		// Token: 0x04001714 RID: 5908
		[Token(Token = "0x4001714")]
		[FieldOffset(Offset = "0x171")]
		private bool NetworkInitialize__LateScheduleOne.Levelling.LevelManagerAssembly-CSharp.dll_Excuted;
	}
}
