using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
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
	// Token: 0x020005C4 RID: 1476
	[Token(Token = "0x20005C4")]
	public class Packager : Employee, IConfigurable
	{
		// Token: 0x170005F0 RID: 1520
		// (get) Token: 0x06002311 RID: 8977 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005F0")]
		public EntityConfiguration Configuration
		{
			[Token(Token = "0x6002311")]
			[Address(RVA = "0x6D0280", Offset = "0x6CEC80", VA = "0x1806D0280", Slot = "125")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005F1 RID: 1521
		// (get) Token: 0x06002312 RID: 8978 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002313 RID: 8979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005F1")]
		protected PackagerConfiguration configuration
		{
			[Token(Token = "0x6002312")]
			[Address(RVA = "0x6D0280", Offset = "0x6CEC80", VA = "0x1806D0280")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002313")]
			[Address(RVA = "0x6D02B0", Offset = "0x6CECB0", VA = "0x1806D02B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170005F2 RID: 1522
		// (get) Token: 0x06002314 RID: 8980 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005F2")]
		public ConfigurationReplicator ConfigReplicator
		{
			[Token(Token = "0x6002314")]
			[Address(RVA = "0x68D390", Offset = "0x68BD90", VA = "0x18068D390", Slot = "126")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005F3 RID: 1523
		// (get) Token: 0x06002315 RID: 8981 RVA: 0x0000B130 File Offset: 0x00009330
		[Token(Token = "0x170005F3")]
		public EConfigurableType ConfigurableType
		{
			[Token(Token = "0x6002315")]
			[Address(RVA = "0x6D0270", Offset = "0x6CEC70", VA = "0x1806D0270", Slot = "127")]
			get
			{
				return EConfigurableType.Pot;
			}
		}

		// Token: 0x170005F4 RID: 1524
		// (get) Token: 0x06002316 RID: 8982 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002317 RID: 8983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005F4")]
		public WorldspaceUIElement WorldspaceUI
		{
			[Token(Token = "0x6002316")]
			[Address(RVA = "0x68D3D0", Offset = "0x68BDD0", VA = "0x18068D3D0", Slot = "128")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002317")]
			[Address(RVA = "0x6D0290", Offset = "0x6CEC90", VA = "0x1806D0290", Slot = "129")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170005F5 RID: 1525
		// (get) Token: 0x06002318 RID: 8984 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002319 RID: 8985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005F5")]
		public NetworkObject CurrentPlayerConfigurer
		{
			[Token(Token = "0x6002318")]
			[Address(RVA = "0x68D3B0", Offset = "0x68BDB0", VA = "0x18068D3B0", Slot = "130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002319")]
			[Address(RVA = "0x6CF400", Offset = "0x6CDE00", VA = "0x1806CF400", Slot = "131")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600231A RID: 8986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600231A")]
		[Address(RVA = "0x6CF7B0", Offset = "0x6CE1B0", VA = "0x1806CF7B0", Slot = "145")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetConfigurer(NetworkObject player)
		{
		}

		// Token: 0x170005F6 RID: 1526
		// (get) Token: 0x0600231B RID: 8987 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005F6")]
		public Sprite TypeIcon
		{
			[Token(Token = "0x600231B")]
			[Address(RVA = "0x68D3C0", Offset = "0x68BDC0", VA = "0x18068D3C0", Slot = "133")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005F7 RID: 1527
		// (get) Token: 0x0600231C RID: 8988 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005F7")]
		public Transform Transform
		{
			[Token(Token = "0x600231C")]
			[Address(RVA = "0x506E30", Offset = "0x505830", VA = "0x180506E30", Slot = "134")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005F8 RID: 1528
		// (get) Token: 0x0600231D RID: 8989 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005F8")]
		public Transform UIPoint
		{
			[Token(Token = "0x600231D")]
			[Address(RVA = "0x689F00", Offset = "0x688900", VA = "0x180689F00", Slot = "135")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005F9 RID: 1529
		// (get) Token: 0x0600231E RID: 8990 RVA: 0x0000B148 File Offset: 0x00009348
		[Token(Token = "0x170005F9")]
		public bool CanBeSelected
		{
			[Token(Token = "0x600231E")]
			[Address(RVA = "0x48DCC0", Offset = "0x48C6C0", VA = "0x18048DCC0", Slot = "137")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170005FA RID: 1530
		// (get) Token: 0x0600231F RID: 8991 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005FA")]
		public Property ParentProperty
		{
			[Token(Token = "0x600231F")]
			[Address(RVA = "0x689EF0", Offset = "0x6888F0", VA = "0x180689EF0", Slot = "138")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002320 RID: 8992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002320")]
		[Address(RVA = "0x6CDE50", Offset = "0x6CC850", VA = "0x1806CDE50", Slot = "109")]
		protected override void AssignProperty(Property prop, bool warp)
		{
		}

		// Token: 0x06002321 RID: 8993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002321")]
		[Address(RVA = "0x688890", Offset = "0x687290", VA = "0x180688890", Slot = "110")]
		protected override void UnassignProperty()
		{
		}

		// Token: 0x06002322 RID: 8994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002322")]
		[Address(RVA = "0x6CF3C0", Offset = "0x6CDDC0", VA = "0x1806CF3C0", Slot = "115")]
		protected override void ResetConfiguration()
		{
		}

		// Token: 0x06002323 RID: 8995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002323")]
		[Address(RVA = "0x6CE220", Offset = "0x6CCC20", VA = "0x1806CE220", Slot = "116")]
		protected override void Fire()
		{
		}

		// Token: 0x06002324 RID: 8996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002324")]
		[Address(RVA = "0x6CF180", Offset = "0x6CDB80", VA = "0x1806CF180", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x06002325 RID: 8997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002325")]
		[Address(RVA = "0x6CF650", Offset = "0x6CE050", VA = "0x1806CF650", Slot = "146")]
		public void SendConfigurationToClient(NetworkConnection conn)
		{
		}

		// Token: 0x06002326 RID: 8998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002326")]
		[Address(RVA = "0x6CFC70", Offset = "0x6CE670", VA = "0x1806CFC70", Slot = "117")]
		protected override void UpdateBehaviour()
		{
		}

		// Token: 0x06002327 RID: 8999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002327")]
		[Address(RVA = "0x6CFB90", Offset = "0x6CE590", VA = "0x1806CFB90")]
		private void StartPackaging(PackagingStation station)
		{
		}

		// Token: 0x06002328 RID: 9000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002328")]
		[Address(RVA = "0x68CAD0", Offset = "0x68B4D0", VA = "0x18068CAD0")]
		private void StartPress(BrickPress press)
		{
		}

		// Token: 0x06002329 RID: 9001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002329")]
		[Address(RVA = "0x6CFA20", Offset = "0x6CE420", VA = "0x1806CFA20")]
		private void StartMoveItem(PackagingStation station)
		{
		}

		// Token: 0x0600232A RID: 9002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600232A")]
		[Address(RVA = "0x6CF920", Offset = "0x6CE320", VA = "0x1806CF920")]
		private void StartMoveItem(BrickPress press)
		{
		}

		// Token: 0x0600232B RID: 9003 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600232B")]
		[Address(RVA = "0x6CEC00", Offset = "0x6CD600", VA = "0x1806CEC00")]
		protected PackagingStation GetStationToAttend()
		{
			return null;
		}

		// Token: 0x0600232C RID: 9004 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600232C")]
		[Address(RVA = "0x6CE580", Offset = "0x6CCF80", VA = "0x1806CE580")]
		protected BrickPress GetBrickPress()
		{
			return null;
		}

		// Token: 0x0600232D RID: 9005 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600232D")]
		[Address(RVA = "0x6CE9C0", Offset = "0x6CD3C0", VA = "0x1806CE9C0")]
		protected PackagingStation GetStationMoveItems()
		{
			return null;
		}

		// Token: 0x0600232E RID: 9006 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600232E")]
		[Address(RVA = "0x6CE340", Offset = "0x6CCD40", VA = "0x1806CE340")]
		protected BrickPress GetBrickPressMoveItems()
		{
			return null;
		}

		// Token: 0x0600232F RID: 9007 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600232F")]
		[Address(RVA = "0x6CED60", Offset = "0x6CD760", VA = "0x1806CED60")]
		protected AdvancedTransitRoute GetTransitRouteReady(out ItemInstance item)
		{
			return null;
		}

		// Token: 0x06002330 RID: 9008 RVA: 0x0000B160 File Offset: 0x00009360
		[Token(Token = "0x6002330")]
		[Address(RVA = "0x6CF8E0", Offset = "0x6CE2E0", VA = "0x1806CF8E0", Slot = "118")]
		protected override bool ShouldIdle()
		{
			return default(bool);
		}

		// Token: 0x06002331 RID: 9009 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002331")]
		[Address(RVA = "0x6CE6E0", Offset = "0x6CD0E0", VA = "0x1806CE6E0", Slot = "119")]
		public override EmployeeHome GetHome()
		{
			return null;
		}

		// Token: 0x06002332 RID: 9010 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002332")]
		[Address(RVA = "0x6CDF60", Offset = "0x6CC960", VA = "0x1806CDF60", Slot = "139")]
		public WorldspaceUIElement CreateWorldspaceUI()
		{
			return null;
		}

		// Token: 0x06002333 RID: 9011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002333")]
		[Address(RVA = "0x6CE190", Offset = "0x6CCB90", VA = "0x1806CE190", Slot = "140")]
		public void DestroyWorldspaceUI()
		{
		}

		// Token: 0x06002334 RID: 9012 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002334")]
		[Address(RVA = "0x6CE700", Offset = "0x6CD100", VA = "0x1806CE700", Slot = "94")]
		public override NPCData GetNPCData()
		{
			return null;
		}

		// Token: 0x06002335 RID: 9013 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002335")]
		[Address(RVA = "0x6CE930", Offset = "0x6CD330", VA = "0x1806CE930", Slot = "95")]
		public override DynamicSaveData GetSaveData()
		{
			return null;
		}

		// Token: 0x06002336 RID: 9014 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002336")]
		[Address(RVA = "0x6D01F0", Offset = "0x6CEBF0", VA = "0x1806D01F0", Slot = "96")]
		public override List<string> WriteData(string parentFolderPath)
		{
			return null;
		}

		// Token: 0x06002337 RID: 9015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002337")]
		[Address(RVA = "0x6D0250", Offset = "0x6CEC50", VA = "0x1806D0250")]
		public Packager()
		{
		}

		// Token: 0x06002338 RID: 9016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002338")]
		[Address(RVA = "0x6CEFD0", Offset = "0x6CD9D0", VA = "0x1806CEFD0", Slot = "99")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06002339 RID: 9017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002339")]
		[Address(RVA = "0x6CEF70", Offset = "0x6CD970", VA = "0x1806CEF70", Slot = "100")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x0600233A RID: 9018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600233A")]
		[Address(RVA = "0x687D80", Offset = "0x686780", VA = "0x180687D80", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x0600233B RID: 9019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600233B")]
		[Address(RVA = "0x6CF520", Offset = "0x6CDF20", VA = "0x1806CF520")]
		private void RpcWriter___Server_SetConfigurer_3323014238(NetworkObject player)
		{
		}

		// Token: 0x0600233C RID: 9020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600233C")]
		[Address(RVA = "0x6CF400", Offset = "0x6CDE00", VA = "0x1806CF400", Slot = "147")]
		public void RpcLogic___SetConfigurer_3323014238(NetworkObject player)
		{
		}

		// Token: 0x0600233D RID: 9021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600233D")]
		[Address(RVA = "0x6CF4A0", Offset = "0x6CDEA0", VA = "0x1806CF4A0")]
		private void RpcReader___Server_SetConfigurer_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x170005FB RID: 1531
		// (get) Token: 0x0600233E RID: 9022 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600233F RID: 9023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005FB")]
		public NetworkObject SyncAccessor_<CurrentPlayerConfigurer>k__BackingField
		{
			[Token(Token = "0x600233E")]
			[Address(RVA = "0x68D3B0", Offset = "0x68BDB0", VA = "0x18068D3B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600233F")]
			[Address(RVA = "0x6D02D0", Offset = "0x6CECD0", VA = "0x1806D02D0")]
			set
			{
			}
		}

		// Token: 0x06002340 RID: 9024 RVA: 0x0000B178 File Offset: 0x00009378
		[Token(Token = "0x6002340")]
		[Address(RVA = "0x6CF300", Offset = "0x6CDD00", VA = "0x1806CF300", Slot = "148")]
		public virtual bool ReadSyncVar___ScheduleOne.Employees.Packager(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return default(bool);
		}

		// Token: 0x06002341 RID: 9025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002341")]
		[Address(RVA = "0x6CDF10", Offset = "0x6CC910", VA = "0x1806CDF10", Slot = "64")]
		public override void Awake()
		{
		}

		// Token: 0x04001BC0 RID: 7104
		[Token(Token = "0x4001BC0")]
		[FieldOffset(Offset = "0x380")]
		[Header("References")]
		public Sprite typeIcon;

		// Token: 0x04001BC1 RID: 7105
		[Token(Token = "0x4001BC1")]
		[FieldOffset(Offset = "0x388")]
		[SerializeField]
		protected ConfigurationReplicator configReplicator;

		// Token: 0x04001BC2 RID: 7106
		[Token(Token = "0x4001BC2")]
		[FieldOffset(Offset = "0x390")]
		public PackagingStationBehaviour PackagingBehaviour;

		// Token: 0x04001BC3 RID: 7107
		[Token(Token = "0x4001BC3")]
		[FieldOffset(Offset = "0x398")]
		public BrickPressBehaviour BrickPressBehaviour;

		// Token: 0x04001BC4 RID: 7108
		[Token(Token = "0x4001BC4")]
		[FieldOffset(Offset = "0x3A0")]
		[Header("UI")]
		public PackagerUIElement WorldspaceUIPrefab;

		// Token: 0x04001BC5 RID: 7109
		[Token(Token = "0x4001BC5")]
		[FieldOffset(Offset = "0x3A8")]
		public Transform uiPoint;

		// Token: 0x04001BC6 RID: 7110
		[Token(Token = "0x4001BC6")]
		[FieldOffset(Offset = "0x3B0")]
		[Header("Settings")]
		public int MaxAssignedStations;

		// Token: 0x04001BC7 RID: 7111
		[Token(Token = "0x4001BC7")]
		[FieldOffset(Offset = "0x3B4")]
		[Header("Proficiency Settings")]
		public float PackagingSpeedMultiplier;

		// Token: 0x04001BCB RID: 7115
		[Token(Token = "0x4001BCB")]
		[FieldOffset(Offset = "0x3D0")]
		public SyncVar<NetworkObject> syncVar___<CurrentPlayerConfigurer>k__BackingField;

		// Token: 0x04001BCC RID: 7116
		[Token(Token = "0x4001BCC")]
		[FieldOffset(Offset = "0x3D8")]
		private bool NetworkInitialize___EarlyScheduleOne.Employees.PackagerAssembly-CSharp.dll_Excuted;

		// Token: 0x04001BCD RID: 7117
		[Token(Token = "0x4001BCD")]
		[FieldOffset(Offset = "0x3D9")]
		private bool NetworkInitialize__LateScheduleOne.Employees.PackagerAssembly-CSharp.dll_Excuted;
	}
}
