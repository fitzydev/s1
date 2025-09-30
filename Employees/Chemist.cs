using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Management;
using ScheduleOne.NPCs.Behaviour;
using ScheduleOne.ObjectScripts;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Property;
using ScheduleOne.UI.Management;
using UnityEngine;

namespace ScheduleOne.Employees
{
	// Token: 0x020005B6 RID: 1462
	[Token(Token = "0x20005B6")]
	public class Chemist : Employee, IConfigurable
	{
		// Token: 0x170005C8 RID: 1480
		// (get) Token: 0x06002218 RID: 8728 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005C8")]
		public EntityConfiguration Configuration
		{
			[Token(Token = "0x6002218")]
			[Address(RVA = "0x68D3B0", Offset = "0x68BDB0", VA = "0x18068D3B0", Slot = "125")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005C9 RID: 1481
		// (get) Token: 0x06002219 RID: 8729 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600221A RID: 8730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005C9")]
		protected ChemistConfiguration configuration
		{
			[Token(Token = "0x6002219")]
			[Address(RVA = "0x68D3B0", Offset = "0x68BDB0", VA = "0x18068D3B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600221A")]
			[Address(RVA = "0x68D410", Offset = "0x68BE10", VA = "0x18068D410")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170005CA RID: 1482
		// (get) Token: 0x0600221B RID: 8731 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005CA")]
		public ConfigurationReplicator ConfigReplicator
		{
			[Token(Token = "0x600221B")]
			[Address(RVA = "0x68D390", Offset = "0x68BD90", VA = "0x18068D390", Slot = "126")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005CB RID: 1483
		// (get) Token: 0x0600221C RID: 8732 RVA: 0x0000AD88 File Offset: 0x00008F88
		[Token(Token = "0x170005CB")]
		public EConfigurableType ConfigurableType
		{
			[Token(Token = "0x600221C")]
			[Address(RVA = "0x68D3A0", Offset = "0x68BDA0", VA = "0x18068D3A0", Slot = "127")]
			get
			{
				return EConfigurableType.Pot;
			}
		}

		// Token: 0x170005CC RID: 1484
		// (get) Token: 0x0600221D RID: 8733 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600221E RID: 8734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005CC")]
		public WorldspaceUIElement WorldspaceUI
		{
			[Token(Token = "0x600221D")]
			[Address(RVA = "0x68D3E0", Offset = "0x68BDE0", VA = "0x18068D3E0", Slot = "128")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600221E")]
			[Address(RVA = "0x68D3F0", Offset = "0x68BDF0", VA = "0x18068D3F0", Slot = "129")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170005CD RID: 1485
		// (get) Token: 0x0600221F RID: 8735 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002220 RID: 8736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005CD")]
		public NetworkObject CurrentPlayerConfigurer
		{
			[Token(Token = "0x600221F")]
			[Address(RVA = "0x689F10", Offset = "0x688910", VA = "0x180689F10", Slot = "130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002220")]
			[Address(RVA = "0x68C510", Offset = "0x68AF10", VA = "0x18068C510", Slot = "131")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06002221 RID: 8737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002221")]
		[Address(RVA = "0x68C8C0", Offset = "0x68B2C0", VA = "0x18068C8C0", Slot = "145")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetConfigurer(NetworkObject player)
		{
		}

		// Token: 0x170005CE RID: 1486
		// (get) Token: 0x06002222 RID: 8738 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005CE")]
		public Sprite TypeIcon
		{
			[Token(Token = "0x6002222")]
			[Address(RVA = "0x68D3C0", Offset = "0x68BDC0", VA = "0x18068D3C0", Slot = "133")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005CF RID: 1487
		// (get) Token: 0x06002223 RID: 8739 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005CF")]
		public Transform Transform
		{
			[Token(Token = "0x6002223")]
			[Address(RVA = "0x506E30", Offset = "0x505830", VA = "0x180506E30", Slot = "134")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005D0 RID: 1488
		// (get) Token: 0x06002224 RID: 8740 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005D0")]
		public Transform UIPoint
		{
			[Token(Token = "0x6002224")]
			[Address(RVA = "0x68D3D0", Offset = "0x68BDD0", VA = "0x18068D3D0", Slot = "135")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005D1 RID: 1489
		// (get) Token: 0x06002225 RID: 8741 RVA: 0x0000ADA0 File Offset: 0x00008FA0
		[Token(Token = "0x170005D1")]
		public bool CanBeSelected
		{
			[Token(Token = "0x6002225")]
			[Address(RVA = "0x48DCC0", Offset = "0x48C6C0", VA = "0x18048DCC0", Slot = "137")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170005D2 RID: 1490
		// (get) Token: 0x06002226 RID: 8742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005D2")]
		public Property ParentProperty
		{
			[Token(Token = "0x6002226")]
			[Address(RVA = "0x689EF0", Offset = "0x6888F0", VA = "0x180689EF0", Slot = "138")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002227 RID: 8743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002227")]
		[Address(RVA = "0x68A0C0", Offset = "0x688AC0", VA = "0x18068A0C0", Slot = "109")]
		protected override void AssignProperty(Property prop, bool warp)
		{
		}

		// Token: 0x06002228 RID: 8744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002228")]
		[Address(RVA = "0x688890", Offset = "0x687290", VA = "0x180688890", Slot = "110")]
		protected override void UnassignProperty()
		{
		}

		// Token: 0x06002229 RID: 8745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002229")]
		[Address(RVA = "0x68C4E0", Offset = "0x68AEE0", VA = "0x18068C4E0", Slot = "115")]
		protected override void ResetConfiguration()
		{
		}

		// Token: 0x0600222A RID: 8746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600222A")]
		[Address(RVA = "0x68A480", Offset = "0x688E80", VA = "0x18068A480", Slot = "116")]
		protected override void Fire()
		{
		}

		// Token: 0x0600222B RID: 8747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600222B")]
		[Address(RVA = "0x68C2C0", Offset = "0x68ACC0", VA = "0x18068C2C0", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x0600222C RID: 8748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600222C")]
		[Address(RVA = "0x68C760", Offset = "0x68B160", VA = "0x18068C760", Slot = "146")]
		public void SendConfigurationToClient(NetworkConnection conn)
		{
		}

		// Token: 0x0600222D RID: 8749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600222D")]
		[Address(RVA = "0x68D190", Offset = "0x68BB90", VA = "0x18068D190", Slot = "117")]
		protected override void UpdateBehaviour()
		{
		}

		// Token: 0x0600222E RID: 8750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600222E")]
		[Address(RVA = "0x68CB50", Offset = "0x68B550", VA = "0x18068CB50")]
		private void TryStartNewTask()
		{
		}

		// Token: 0x0600222F RID: 8751 RVA: 0x0000ADB8 File Offset: 0x00008FB8
		[Token(Token = "0x600222F")]
		[Address(RVA = "0x68A030", Offset = "0x688A30", VA = "0x18068A030")]
		private bool AnyWorkInProgress()
		{
			return default(bool);
		}

		// Token: 0x06002230 RID: 8752 RVA: 0x0000ADD0 File Offset: 0x00008FD0
		[Token(Token = "0x6002230")]
		[Address(RVA = "0x68C9F0", Offset = "0x68B3F0", VA = "0x18068C9F0", Slot = "118")]
		protected override bool ShouldIdle()
		{
			return default(bool);
		}

		// Token: 0x06002231 RID: 8753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002231")]
		[Address(RVA = "0x68CA90", Offset = "0x68B490", VA = "0x18068CA90")]
		private void StartChemistryStation(ChemistryStation station)
		{
		}

		// Token: 0x06002232 RID: 8754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002232")]
		[Address(RVA = "0x68CA50", Offset = "0x68B450", VA = "0x18068CA50")]
		private void StartCauldron(Cauldron cauldron)
		{
		}

		// Token: 0x06002233 RID: 8755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002233")]
		[Address(RVA = "0x68CAD0", Offset = "0x68B4D0", VA = "0x18068CAD0")]
		private void StartLabOven(LabOven oven)
		{
		}

		// Token: 0x06002234 RID: 8756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002234")]
		[Address(RVA = "0x68A440", Offset = "0x688E40", VA = "0x18068A440")]
		private void FinishLabOven(LabOven oven)
		{
		}

		// Token: 0x06002235 RID: 8757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002235")]
		[Address(RVA = "0x68CB10", Offset = "0x68B510", VA = "0x18068CB10")]
		private void StartMixingStation(MixingStation station)
		{
		}

		// Token: 0x06002236 RID: 8758 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002236")]
		[Address(RVA = "0x68B080", Offset = "0x689A80", VA = "0x18068B080", Slot = "119")]
		public override EmployeeHome GetHome()
		{
			return null;
		}

		// Token: 0x06002237 RID: 8759 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002237")]
		[Address(RVA = "0x68B0A0", Offset = "0x689AA0", VA = "0x18068B0A0")]
		public List<LabOven> GetLabOvensReadyToFinish()
		{
			return null;
		}

		// Token: 0x06002238 RID: 8760 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002238")]
		[Address(RVA = "0x68B5B0", Offset = "0x689FB0", VA = "0x18068B5B0")]
		public List<LabOven> GetLabOvensReadyToStart()
		{
			return null;
		}

		// Token: 0x06002239 RID: 8761 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002239")]
		[Address(RVA = "0x68AD40", Offset = "0x689740", VA = "0x18068AD40")]
		public List<ChemistryStation> GetChemistryStationsReadyToStart()
		{
			return null;
		}

		// Token: 0x0600223A RID: 8762 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600223A")]
		[Address(RVA = "0x68A840", Offset = "0x689240", VA = "0x18068A840")]
		public List<Cauldron> GetCauldronsReadyToStart()
		{
			return null;
		}

		// Token: 0x0600223B RID: 8763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600223B")]
		[Address(RVA = "0x68BAB0", Offset = "0x68A4B0", VA = "0x18068BAB0")]
		public List<MixingStation> GetMixingStationsReadyToStart()
		{
			return null;
		}

		// Token: 0x0600223C RID: 8764 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600223C")]
		[Address(RVA = "0x68B310", Offset = "0x689D10", VA = "0x18068B310")]
		protected List<LabOven> GetLabOvensReadyToMove()
		{
			return null;
		}

		// Token: 0x0600223D RID: 8765 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600223D")]
		[Address(RVA = "0x68AAA0", Offset = "0x6894A0", VA = "0x18068AAA0")]
		protected List<ChemistryStation> GetChemStationsReadyToMove()
		{
			return null;
		}

		// Token: 0x0600223E RID: 8766 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600223E")]
		[Address(RVA = "0x68A5A0", Offset = "0x688FA0", VA = "0x18068A5A0")]
		protected List<Cauldron> GetCauldronsReadyToMove()
		{
			return null;
		}

		// Token: 0x0600223F RID: 8767 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600223F")]
		[Address(RVA = "0x68B810", Offset = "0x68A210", VA = "0x18068B810")]
		protected List<MixingStation> GetMixStationsReadyToMove()
		{
			return null;
		}

		// Token: 0x06002240 RID: 8768 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002240")]
		[Address(RVA = "0x68A180", Offset = "0x688B80", VA = "0x18068A180", Slot = "139")]
		public WorldspaceUIElement CreateWorldspaceUI()
		{
			return null;
		}

		// Token: 0x06002241 RID: 8769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002241")]
		[Address(RVA = "0x68A3B0", Offset = "0x688DB0", VA = "0x18068A3B0", Slot = "140")]
		public void DestroyWorldspaceUI()
		{
		}

		// Token: 0x06002242 RID: 8770 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002242")]
		[Address(RVA = "0x68BDD0", Offset = "0x68A7D0", VA = "0x18068BDD0", Slot = "94")]
		public override NPCData GetNPCData()
		{
			return null;
		}

		// Token: 0x06002243 RID: 8771 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002243")]
		[Address(RVA = "0x68C000", Offset = "0x68AA00", VA = "0x18068C000", Slot = "95")]
		public override DynamicSaveData GetSaveData()
		{
			return null;
		}

		// Token: 0x06002244 RID: 8772 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002244")]
		[Address(RVA = "0x68D320", Offset = "0x68BD20", VA = "0x18068D320", Slot = "96")]
		public override List<string> WriteData(string parentFolderPath)
		{
			return null;
		}

		// Token: 0x06002245 RID: 8773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002245")]
		[Address(RVA = "0x68D380", Offset = "0x68BD80", VA = "0x18068D380")]
		public Chemist()
		{
		}

		// Token: 0x06002246 RID: 8774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002246")]
		[Address(RVA = "0x68C110", Offset = "0x68AB10", VA = "0x18068C110", Slot = "99")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06002247 RID: 8775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002247")]
		[Address(RVA = "0x68C090", Offset = "0x68AA90", VA = "0x18068C090", Slot = "100")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06002248 RID: 8776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002248")]
		[Address(RVA = "0x687D80", Offset = "0x686780", VA = "0x180687D80", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06002249 RID: 8777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002249")]
		[Address(RVA = "0x68C630", Offset = "0x68B030", VA = "0x18068C630")]
		private void RpcWriter___Server_SetConfigurer_3323014238(NetworkObject player)
		{
		}

		// Token: 0x0600224A RID: 8778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600224A")]
		[Address(RVA = "0x68C510", Offset = "0x68AF10", VA = "0x18068C510", Slot = "147")]
		public void RpcLogic___SetConfigurer_3323014238(NetworkObject player)
		{
		}

		// Token: 0x0600224B RID: 8779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600224B")]
		[Address(RVA = "0x68C5B0", Offset = "0x68AFB0", VA = "0x18068C5B0")]
		private void RpcReader___Server_SetConfigurer_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x170005D3 RID: 1491
		// (get) Token: 0x0600224C RID: 8780 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600224D RID: 8781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005D3")]
		public NetworkObject SyncAccessor_<CurrentPlayerConfigurer>k__BackingField
		{
			[Token(Token = "0x600224C")]
			[Address(RVA = "0x689F10", Offset = "0x688910", VA = "0x180689F10")]
			get
			{
				return null;
			}
			[Token(Token = "0x600224D")]
			[Address(RVA = "0x68D430", Offset = "0x68BE30", VA = "0x18068D430")]
			set
			{
			}
		}

		// Token: 0x0600224E RID: 8782 RVA: 0x0000ADE8 File Offset: 0x00008FE8
		[Token(Token = "0x600224E")]
		[Address(RVA = "0x68C420", Offset = "0x68AE20", VA = "0x18068C420", Slot = "148")]
		public virtual bool ReadSyncVar___ScheduleOne.Employees.Chemist(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return default(bool);
		}

		// Token: 0x0600224F RID: 8783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600224F")]
		[Address(RVA = "0x6859C0", Offset = "0x6843C0", VA = "0x1806859C0", Slot = "64")]
		public override void Awake()
		{
		}

		// Token: 0x04001B4D RID: 6989
		[Token(Token = "0x4001B4D")]
		public const int MAX_ASSIGNED_STATIONS = 4;

		// Token: 0x04001B4E RID: 6990
		[Token(Token = "0x4001B4E")]
		[FieldOffset(Offset = "0x380")]
		[Header("References")]
		public Sprite typeIcon;

		// Token: 0x04001B4F RID: 6991
		[Token(Token = "0x4001B4F")]
		[FieldOffset(Offset = "0x388")]
		[SerializeField]
		protected ConfigurationReplicator configReplicator;

		// Token: 0x04001B50 RID: 6992
		[Token(Token = "0x4001B50")]
		[FieldOffset(Offset = "0x390")]
		[Header("Behaviours")]
		public StartChemistryStationBehaviour StartChemistryStationBehaviour;

		// Token: 0x04001B51 RID: 6993
		[Token(Token = "0x4001B51")]
		[FieldOffset(Offset = "0x398")]
		public StartLabOvenBehaviour StartLabOvenBehaviour;

		// Token: 0x04001B52 RID: 6994
		[Token(Token = "0x4001B52")]
		[FieldOffset(Offset = "0x3A0")]
		public FinishLabOvenBehaviour FinishLabOvenBehaviour;

		// Token: 0x04001B53 RID: 6995
		[Token(Token = "0x4001B53")]
		[FieldOffset(Offset = "0x3A8")]
		public StartCauldronBehaviour StartCauldronBehaviour;

		// Token: 0x04001B54 RID: 6996
		[Token(Token = "0x4001B54")]
		[FieldOffset(Offset = "0x3B0")]
		public StartMixingStationBehaviour StartMixingStationBehaviour;

		// Token: 0x04001B55 RID: 6997
		[Token(Token = "0x4001B55")]
		[FieldOffset(Offset = "0x3B8")]
		[Header("UI")]
		public ChemistUIElement WorldspaceUIPrefab;

		// Token: 0x04001B56 RID: 6998
		[Token(Token = "0x4001B56")]
		[FieldOffset(Offset = "0x3C0")]
		public Transform uiPoint;

		// Token: 0x04001B5A RID: 7002
		[Token(Token = "0x4001B5A")]
		[FieldOffset(Offset = "0x3E0")]
		public SyncVar<NetworkObject> syncVar___<CurrentPlayerConfigurer>k__BackingField;

		// Token: 0x04001B5B RID: 7003
		[Token(Token = "0x4001B5B")]
		[FieldOffset(Offset = "0x3E8")]
		private bool NetworkInitialize___EarlyScheduleOne.Employees.ChemistAssembly-CSharp.dll_Excuted;

		// Token: 0x04001B5C RID: 7004
		[Token(Token = "0x4001B5C")]
		[FieldOffset(Offset = "0x3E9")]
		private bool NetworkInitialize__LateScheduleOne.Employees.ChemistAssembly-CSharp.dll_Excuted;
	}
}
