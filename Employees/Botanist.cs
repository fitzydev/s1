using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Dialogue;
using ScheduleOne.ItemFramework;
using ScheduleOne.Management;
using ScheduleOne.NPCs.Behaviour;
using ScheduleOne.ObjectScripts;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Property;
using ScheduleOne.UI.Management;
using UnityEngine;

namespace ScheduleOne.Employees
{
	// Token: 0x020005B3 RID: 1459
	[Token(Token = "0x20005B3")]
	public class Botanist : Employee, IConfigurable
	{
		// Token: 0x170005BA RID: 1466
		// (get) Token: 0x060021CE RID: 8654 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005BA")]
		public EntityConfiguration Configuration
		{
			[Token(Token = "0x60021CE")]
			[Address(RVA = "0x689ED0", Offset = "0x6888D0", VA = "0x180689ED0", Slot = "125")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005BB RID: 1467
		// (get) Token: 0x060021CF RID: 8655 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060021D0 RID: 8656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005BB")]
		protected BotanistConfiguration configuration
		{
			[Token(Token = "0x60021CF")]
			[Address(RVA = "0x689ED0", Offset = "0x6888D0", VA = "0x180689ED0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60021D0")]
			[Address(RVA = "0x689F50", Offset = "0x688950", VA = "0x180689F50")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170005BC RID: 1468
		// (get) Token: 0x060021D1 RID: 8657 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005BC")]
		public ConfigurationReplicator ConfigReplicator
		{
			[Token(Token = "0x60021D1")]
			[Address(RVA = "0x689EC0", Offset = "0x6888C0", VA = "0x180689EC0", Slot = "126")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005BD RID: 1469
		// (get) Token: 0x060021D2 RID: 8658 RVA: 0x0000AC68 File Offset: 0x00008E68
		[Token(Token = "0x170005BD")]
		public EConfigurableType ConfigurableType
		{
			[Token(Token = "0x60021D2")]
			[Address(RVA = "0x58DD70", Offset = "0x58C770", VA = "0x18058DD70", Slot = "127")]
			get
			{
				return EConfigurableType.Pot;
			}
		}

		// Token: 0x170005BE RID: 1470
		// (get) Token: 0x060021D3 RID: 8659 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060021D4 RID: 8660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005BE")]
		public WorldspaceUIElement WorldspaceUI
		{
			[Token(Token = "0x60021D3")]
			[Address(RVA = "0x689F20", Offset = "0x688920", VA = "0x180689F20", Slot = "128")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60021D4")]
			[Address(RVA = "0x689F30", Offset = "0x688930", VA = "0x180689F30", Slot = "129")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170005BF RID: 1471
		// (get) Token: 0x060021D5 RID: 8661 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060021D6 RID: 8662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005BF")]
		public NetworkObject CurrentPlayerConfigurer
		{
			[Token(Token = "0x60021D5")]
			[Address(RVA = "0x689EE0", Offset = "0x6888E0", VA = "0x180689EE0", Slot = "130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60021D6")]
			[Address(RVA = "0x688240", Offset = "0x686C40", VA = "0x180688240", Slot = "131")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060021D7 RID: 8663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021D7")]
		[Address(RVA = "0x6885F0", Offset = "0x686FF0", VA = "0x1806885F0", Slot = "145")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetConfigurer(NetworkObject player)
		{
		}

		// Token: 0x170005C0 RID: 1472
		// (get) Token: 0x060021D8 RID: 8664 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005C0")]
		public Sprite TypeIcon
		{
			[Token(Token = "0x60021D8")]
			[Address(RVA = "0x689F00", Offset = "0x688900", VA = "0x180689F00", Slot = "133")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005C1 RID: 1473
		// (get) Token: 0x060021D9 RID: 8665 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005C1")]
		public Transform Transform
		{
			[Token(Token = "0x60021D9")]
			[Address(RVA = "0x506E30", Offset = "0x505830", VA = "0x180506E30", Slot = "134")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005C2 RID: 1474
		// (get) Token: 0x060021DA RID: 8666 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005C2")]
		public Transform UIPoint
		{
			[Token(Token = "0x60021DA")]
			[Address(RVA = "0x689F10", Offset = "0x688910", VA = "0x180689F10", Slot = "135")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005C3 RID: 1475
		// (get) Token: 0x060021DB RID: 8667 RVA: 0x0000AC80 File Offset: 0x00008E80
		[Token(Token = "0x170005C3")]
		public bool CanBeSelected
		{
			[Token(Token = "0x60021DB")]
			[Address(RVA = "0x48DCC0", Offset = "0x48C6C0", VA = "0x18048DCC0", Slot = "137")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170005C4 RID: 1476
		// (get) Token: 0x060021DC RID: 8668 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005C4")]
		public Property ParentProperty
		{
			[Token(Token = "0x60021DC")]
			[Address(RVA = "0x689EF0", Offset = "0x6888F0", VA = "0x180689EF0", Slot = "138")]
			get
			{
				return null;
			}
		}

		// Token: 0x060021DD RID: 8669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021DD")]
		[Address(RVA = "0x688840", Offset = "0x687240", VA = "0x180688840", Slot = "70")]
		protected override void Start()
		{
		}

		// Token: 0x060021DE RID: 8670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021DE")]
		[Address(RVA = "0x6888D0", Offset = "0x6872D0", VA = "0x1806888D0", Slot = "117")]
		protected override void UpdateBehaviour()
		{
		}

		// Token: 0x060021DF RID: 8671 RVA: 0x0000AC98 File Offset: 0x00008E98
		[Token(Token = "0x60021DF")]
		[Address(RVA = "0x687BA0", Offset = "0x6865A0", VA = "0x180687BA0")]
		private bool IsEntityAccessible(ITransitEntity entity)
		{
			return default(bool);
		}

		// Token: 0x060021E0 RID: 8672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021E0")]
		[Address(RVA = "0x688780", Offset = "0x687180", VA = "0x180688780")]
		private void StartAction(Pot pot, PotActionBehaviour.EActionType actionType)
		{
		}

		// Token: 0x060021E1 RID: 8673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021E1")]
		[Address(RVA = "0x688800", Offset = "0x687200", VA = "0x180688800")]
		private void StartDryingRack(DryingRack rack)
		{
		}

		// Token: 0x060021E2 RID: 8674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021E2")]
		[Address(RVA = "0x688850", Offset = "0x687250", VA = "0x180688850")]
		private void StopDryingRack(DryingRack rack)
		{
		}

		// Token: 0x060021E3 RID: 8675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021E3")]
		[Address(RVA = "0x687FF0", Offset = "0x6869F0", VA = "0x180687FF0", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x060021E4 RID: 8676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021E4")]
		[Address(RVA = "0x688490", Offset = "0x686E90", VA = "0x180688490", Slot = "146")]
		public void SendConfigurationToClient(NetworkConnection conn)
		{
		}

		// Token: 0x060021E5 RID: 8677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021E5")]
		[Address(RVA = "0x685900", Offset = "0x684300", VA = "0x180685900", Slot = "109")]
		protected override void AssignProperty(Property prop, bool warp)
		{
		}

		// Token: 0x060021E6 RID: 8678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021E6")]
		[Address(RVA = "0x688890", Offset = "0x687290", VA = "0x180688890", Slot = "110")]
		protected override void UnassignProperty()
		{
		}

		// Token: 0x060021E7 RID: 8679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021E7")]
		[Address(RVA = "0x688210", Offset = "0x686C10", VA = "0x180688210", Slot = "115")]
		protected override void ResetConfiguration()
		{
		}

		// Token: 0x060021E8 RID: 8680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021E8")]
		[Address(RVA = "0x686100", Offset = "0x684B00", VA = "0x180686100", Slot = "116")]
		protected override void Fire()
		{
		}

		// Token: 0x060021E9 RID: 8681 RVA: 0x0000ACB0 File Offset: 0x00008EB0
		[Token(Token = "0x60021E9")]
		[Address(RVA = "0x685A30", Offset = "0x684430", VA = "0x180685A30")]
		private bool CanMoveDryableToRack(out QualityItemInstance dryable, out DryingRack destinationRack, out int moveQuantity)
		{
			return default(bool);
		}

		// Token: 0x060021EA RID: 8682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021EA")]
		[Address(RVA = "0x686410", Offset = "0x684E10", VA = "0x180686410")]
		public QualityItemInstance GetDryableInSupplies()
		{
			return null;
		}

		// Token: 0x060021EB RID: 8683 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021EB")]
		[Address(RVA = "0x6861C0", Offset = "0x684BC0", VA = "0x1806861C0")]
		private DryingRack GetAssignedDryingRackFor(QualityItemInstance dryable, out int rackInputCapacity)
		{
			return null;
		}

		// Token: 0x060021EC RID: 8684 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021EC")]
		[Address(RVA = "0x6866E0", Offset = "0x6850E0", VA = "0x1806866E0")]
		public ItemInstance GetItemInSupplies(string id)
		{
			return null;
		}

		// Token: 0x060021ED RID: 8685 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021ED")]
		[Address(RVA = "0x687920", Offset = "0x686320", VA = "0x180687920")]
		public ItemInstance GetSeedInSupplies()
		{
			return null;
		}

		// Token: 0x060021EE RID: 8686 RVA: 0x0000ACC8 File Offset: 0x00008EC8
		[Token(Token = "0x60021EE")]
		[Address(RVA = "0x688720", Offset = "0x687120", VA = "0x180688720", Slot = "118")]
		protected override bool ShouldIdle()
		{
			return default(bool);
		}

		// Token: 0x060021EF RID: 8687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021EF")]
		[Address(RVA = "0x6866C0", Offset = "0x6850C0", VA = "0x1806866C0", Slot = "119")]
		public override EmployeeHome GetHome()
		{
			return null;
		}

		// Token: 0x060021F0 RID: 8688 RVA: 0x0000ACE0 File Offset: 0x00008EE0
		[Token(Token = "0x60021F0")]
		[Address(RVA = "0x685760", Offset = "0x684160", VA = "0x180685760")]
		private bool AreThereUnspecifiedPots()
		{
			return default(bool);
		}

		// Token: 0x060021F1 RID: 8689 RVA: 0x0000ACF8 File Offset: 0x00008EF8
		[Token(Token = "0x60021F1")]
		[Address(RVA = "0x685530", Offset = "0x683F30", VA = "0x180685530")]
		private bool AreThereNullDestinationPots()
		{
			return default(bool);
		}

		// Token: 0x060021F2 RID: 8690 RVA: 0x0000AD10 File Offset: 0x00008F10
		[Token(Token = "0x60021F2")]
		[Address(RVA = "0x687C30", Offset = "0x686630", VA = "0x180687C30")]
		private bool IsMissingRequiredMaterials()
		{
			return default(bool);
		}

		// Token: 0x060021F3 RID: 8691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021F3")]
		[Address(RVA = "0x686E40", Offset = "0x685840", VA = "0x180686E40")]
		private Pot GetPotForWatering(float threshold, bool excludeFullyGrowm)
		{
			return null;
		}

		// Token: 0x060021F4 RID: 8692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021F4")]
		[Address(RVA = "0x686CF0", Offset = "0x6856F0", VA = "0x180686CF0")]
		private Pot GetPotForSoilSour()
		{
			return null;
		}

		// Token: 0x060021F5 RID: 8693 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021F5")]
		[Address(RVA = "0x6871E0", Offset = "0x685BE0", VA = "0x1806871E0")]
		private List<Pot> GetPotsReadyForSeed()
		{
			return null;
		}

		// Token: 0x060021F6 RID: 8694 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021F6")]
		private T GetAccessableEntity<T>(T entity) where T : ITransitEntity
		{
			return null;
		}

		// Token: 0x060021F7 RID: 8695 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021F7")]
		private List<T> GetAccessableEntities<T>(List<T> list) where T : ITransitEntity
		{
			return null;
		}

		// Token: 0x060021F8 RID: 8696 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021F8")]
		[Address(RVA = "0x685EA0", Offset = "0x6848A0", VA = "0x180685EA0")]
		private List<Pot> FilterPotsForSpecifiedSeed(List<Pot> pots)
		{
			return null;
		}

		// Token: 0x060021F9 RID: 8697 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021F9")]
		[Address(RVA = "0x686B90", Offset = "0x685590", VA = "0x180686B90")]
		private Pot GetPotForAdditives(out int additiveNumber)
		{
			return null;
		}

		// Token: 0x060021FA RID: 8698 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021FA")]
		[Address(RVA = "0x687070", Offset = "0x685A70", VA = "0x180687070")]
		private List<Pot> GetPotsForHarvest()
		{
			return null;
		}

		// Token: 0x060021FB RID: 8699 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021FB")]
		[Address(RVA = "0x6875B0", Offset = "0x685FB0", VA = "0x1806875B0")]
		private List<DryingRack> GetRacksToStart()
		{
			return null;
		}

		// Token: 0x060021FC RID: 8700 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021FC")]
		[Address(RVA = "0x687720", Offset = "0x686120", VA = "0x180687720")]
		private List<DryingRack> GetRacksToStop()
		{
			return null;
		}

		// Token: 0x060021FD RID: 8701 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021FD")]
		[Address(RVA = "0x687350", Offset = "0x685D50", VA = "0x180687350")]
		private List<DryingRack> GetRacksReadyToMove()
		{
			return null;
		}

		// Token: 0x060021FE RID: 8702 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021FE")]
		[Address(RVA = "0x685BE0", Offset = "0x6845E0", VA = "0x180685BE0", Slot = "139")]
		public WorldspaceUIElement CreateWorldspaceUI()
		{
			return null;
		}

		// Token: 0x060021FF RID: 8703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021FF")]
		[Address(RVA = "0x685E10", Offset = "0x684810", VA = "0x180685E10", Slot = "140")]
		public void DestroyWorldspaceUI()
		{
		}

		// Token: 0x06002200 RID: 8704 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002200")]
		[Address(RVA = "0x686960", Offset = "0x685360", VA = "0x180686960", Slot = "94")]
		public override NPCData GetNPCData()
		{
			return null;
		}

		// Token: 0x06002201 RID: 8705 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002201")]
		[Address(RVA = "0x687890", Offset = "0x686290", VA = "0x180687890", Slot = "95")]
		public override DynamicSaveData GetSaveData()
		{
			return null;
		}

		// Token: 0x06002202 RID: 8706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002202")]
		[Address(RVA = "0x689DF0", Offset = "0x6887F0", VA = "0x180689DF0", Slot = "96")]
		public override List<string> WriteData(string parentFolderPath)
		{
			return null;
		}

		// Token: 0x06002203 RID: 8707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002203")]
		[Address(RVA = "0x689E50", Offset = "0x688850", VA = "0x180689E50")]
		public Botanist()
		{
		}

		// Token: 0x06002205 RID: 8709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002205")]
		[Address(RVA = "0x687E40", Offset = "0x686840", VA = "0x180687E40", Slot = "99")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06002206 RID: 8710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002206")]
		[Address(RVA = "0x687DC0", Offset = "0x6867C0", VA = "0x180687DC0", Slot = "100")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06002207 RID: 8711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002207")]
		[Address(RVA = "0x687D80", Offset = "0x686780", VA = "0x180687D80", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06002208 RID: 8712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002208")]
		[Address(RVA = "0x688360", Offset = "0x686D60", VA = "0x180688360")]
		private void RpcWriter___Server_SetConfigurer_3323014238(NetworkObject player)
		{
		}

		// Token: 0x06002209 RID: 8713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002209")]
		[Address(RVA = "0x688240", Offset = "0x686C40", VA = "0x180688240", Slot = "147")]
		public void RpcLogic___SetConfigurer_3323014238(NetworkObject player)
		{
		}

		// Token: 0x0600220A RID: 8714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600220A")]
		[Address(RVA = "0x6882E0", Offset = "0x686CE0", VA = "0x1806882E0")]
		private void RpcReader___Server_SetConfigurer_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x170005C5 RID: 1477
		// (get) Token: 0x0600220B RID: 8715 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600220C RID: 8716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005C5")]
		public NetworkObject SyncAccessor_<CurrentPlayerConfigurer>k__BackingField
		{
			[Token(Token = "0x600220B")]
			[Address(RVA = "0x689EE0", Offset = "0x6888E0", VA = "0x180689EE0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600220C")]
			[Address(RVA = "0x689F70", Offset = "0x688970", VA = "0x180689F70")]
			set
			{
			}
		}

		// Token: 0x0600220D RID: 8717 RVA: 0x0000AD40 File Offset: 0x00008F40
		[Token(Token = "0x600220D")]
		[Address(RVA = "0x688150", Offset = "0x686B50", VA = "0x180688150", Slot = "148")]
		public virtual bool ReadSyncVar___ScheduleOne.Employees.Botanist(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return default(bool);
		}

		// Token: 0x0600220E RID: 8718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600220E")]
		[Address(RVA = "0x6859C0", Offset = "0x6843C0", VA = "0x1806859C0", Slot = "64")]
		public override void Awake()
		{
		}

		// Token: 0x04001B2C RID: 6956
		[Token(Token = "0x4001B2C")]
		[FieldOffset(Offset = "0x380")]
		public float CRITICAL_WATERING_THRESHOLD;

		// Token: 0x04001B2D RID: 6957
		[Token(Token = "0x4001B2D")]
		[FieldOffset(Offset = "0x384")]
		public float WATERING_THRESHOLD;

		// Token: 0x04001B2E RID: 6958
		[Token(Token = "0x4001B2E")]
		[FieldOffset(Offset = "0x388")]
		public float TARGET_WATER_LEVEL_MIN;

		// Token: 0x04001B2F RID: 6959
		[Token(Token = "0x4001B2F")]
		[FieldOffset(Offset = "0x38C")]
		public float TARGET_WATER_LEVEL_MAX;

		// Token: 0x04001B30 RID: 6960
		[Token(Token = "0x4001B30")]
		[FieldOffset(Offset = "0x390")]
		public float SOIL_POUR_TIME;

		// Token: 0x04001B31 RID: 6961
		[Token(Token = "0x4001B31")]
		[FieldOffset(Offset = "0x394")]
		public float WATER_POUR_TIME;

		// Token: 0x04001B32 RID: 6962
		[Token(Token = "0x4001B32")]
		[FieldOffset(Offset = "0x398")]
		public float ADDITIVE_POUR_TIME;

		// Token: 0x04001B33 RID: 6963
		[Token(Token = "0x4001B33")]
		[FieldOffset(Offset = "0x39C")]
		public float SEED_SOW_TIME;

		// Token: 0x04001B34 RID: 6964
		[Token(Token = "0x4001B34")]
		[FieldOffset(Offset = "0x3A0")]
		public float HARVEST_TIME;

		// Token: 0x04001B35 RID: 6965
		[Token(Token = "0x4001B35")]
		[FieldOffset(Offset = "0x3A8")]
		[Header("References")]
		public Sprite typeIcon;

		// Token: 0x04001B36 RID: 6966
		[Token(Token = "0x4001B36")]
		[FieldOffset(Offset = "0x3B0")]
		[SerializeField]
		protected ConfigurationReplicator configReplicator;

		// Token: 0x04001B37 RID: 6967
		[Token(Token = "0x4001B37")]
		[FieldOffset(Offset = "0x3B8")]
		public PotActionBehaviour PotActionBehaviour;

		// Token: 0x04001B38 RID: 6968
		[Token(Token = "0x4001B38")]
		[FieldOffset(Offset = "0x3C0")]
		public StartDryingRackBehaviour StartDryingRackBehaviour;

		// Token: 0x04001B39 RID: 6969
		[Token(Token = "0x4001B39")]
		[FieldOffset(Offset = "0x3C8")]
		public StopDryingRackBehaviour StopDryingRackBehaviour;

		// Token: 0x04001B3A RID: 6970
		[Token(Token = "0x4001B3A")]
		[FieldOffset(Offset = "0x3D0")]
		[Header("UI")]
		public BotanistUIElement WorldspaceUIPrefab;

		// Token: 0x04001B3B RID: 6971
		[Token(Token = "0x4001B3B")]
		[FieldOffset(Offset = "0x3D8")]
		public Transform uiPoint;

		// Token: 0x04001B3C RID: 6972
		[Token(Token = "0x4001B3C")]
		[FieldOffset(Offset = "0x3E0")]
		[Header("Settings")]
		public int MaxAssignedPots;

		// Token: 0x04001B3D RID: 6973
		[Token(Token = "0x4001B3D")]
		[FieldOffset(Offset = "0x3E8")]
		public DialogueContainer NoAssignedStationsDialogue;

		// Token: 0x04001B3E RID: 6974
		[Token(Token = "0x4001B3E")]
		[FieldOffset(Offset = "0x3F0")]
		public DialogueContainer UnspecifiedPotsDialogue;

		// Token: 0x04001B3F RID: 6975
		[Token(Token = "0x4001B3F")]
		[FieldOffset(Offset = "0x3F8")]
		public DialogueContainer NullDestinationPotsDialogue;

		// Token: 0x04001B40 RID: 6976
		[Token(Token = "0x4001B40")]
		[FieldOffset(Offset = "0x400")]
		public DialogueContainer MissingMaterialsDialogue;

		// Token: 0x04001B41 RID: 6977
		[Token(Token = "0x4001B41")]
		[FieldOffset(Offset = "0x408")]
		public DialogueContainer NoPotsRequireWorkDialogue;

		// Token: 0x04001B45 RID: 6981
		[Token(Token = "0x4001B45")]
		[FieldOffset(Offset = "0x428")]
		public SyncVar<NetworkObject> syncVar___<CurrentPlayerConfigurer>k__BackingField;

		// Token: 0x04001B46 RID: 6982
		[Token(Token = "0x4001B46")]
		[FieldOffset(Offset = "0x430")]
		private bool NetworkInitialize___EarlyScheduleOne.Employees.BotanistAssembly-CSharp.dll_Excuted;

		// Token: 0x04001B47 RID: 6983
		[Token(Token = "0x4001B47")]
		[FieldOffset(Offset = "0x431")]
		private bool NetworkInitialize__LateScheduleOne.Employees.BotanistAssembly-CSharp.dll_Excuted;
	}
}
