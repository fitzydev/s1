using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.Misc;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Product.Packaging;
using ScheduleOne.Vehicles;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Police
{
	// Token: 0x020007F8 RID: 2040
	[Token(Token = "0x20007F8")]
	public class RoadCheckpoint : NetworkBehaviour
	{
		// Token: 0x170007F6 RID: 2038
		// (get) Token: 0x060037DB RID: 14299 RVA: 0x0000F138 File Offset: 0x0000D338
		// (set) Token: 0x060037DC RID: 14300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007F6")]
		public RoadCheckpoint.ECheckpointState ActivationState
		{
			[Token(Token = "0x60037DB")]
			[Address(RVA = "0x548840", Offset = "0x547240", VA = "0x180548840")]
			[CompilerGenerated]
			get
			{
				return RoadCheckpoint.ECheckpointState.Disabled;
			}
			[Token(Token = "0x60037DC")]
			[Address(RVA = "0x7EF5A0", Offset = "0x7EDFA0", VA = "0x1807EF5A0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170007F7 RID: 2039
		// (get) Token: 0x060037DD RID: 14301 RVA: 0x0000F150 File Offset: 0x0000D350
		// (set) Token: 0x060037DE RID: 14302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007F7")]
		public bool Gate1Open
		{
			[Token(Token = "0x60037DD")]
			[Address(RVA = "0x538700", Offset = "0x537100", VA = "0x180538700")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60037DE")]
			[Address(RVA = "0x7EECE0", Offset = "0x7ED6E0", VA = "0x1807EECE0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170007F8 RID: 2040
		// (get) Token: 0x060037DF RID: 14303 RVA: 0x0000F168 File Offset: 0x0000D368
		// (set) Token: 0x060037E0 RID: 14304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007F8")]
		public bool Gate2Open
		{
			[Token(Token = "0x60037DF")]
			[Address(RVA = "0x633810", Offset = "0x632210", VA = "0x180633810")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60037E0")]
			[Address(RVA = "0x7EED70", Offset = "0x7ED770", VA = "0x1807EED70")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x060037E1 RID: 14305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037E1")]
		[Address(RVA = "0x7EDBF0", Offset = "0x7EC5F0", VA = "0x1807EDBF0", Slot = "19")]
		public virtual void Awake()
		{
		}

		// Token: 0x060037E2 RID: 14306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037E2")]
		[Address(RVA = "0x7EF040", Offset = "0x7EDA40", VA = "0x1807EF040", Slot = "20")]
		protected virtual void Update()
		{
		}

		// Token: 0x060037E3 RID: 14307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037E3")]
		[Address(RVA = "0x7ED950", Offset = "0x7EC350", VA = "0x1807ED950", Slot = "21")]
		protected virtual void ApplyState()
		{
		}

		// Token: 0x060037E4 RID: 14308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037E4")]
		[Address(RVA = "0x7EDD60", Offset = "0x7EC760", VA = "0x1807EDD60")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public void Enable(NetworkConnection conn)
		{
		}

		// Token: 0x060037E5 RID: 14309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037E5")]
		[Address(RVA = "0x7EDC40", Offset = "0x7EC640", VA = "0x1807EDC40")]
		[ObserversRpc(RunLocally = true)]
		public void Disable()
		{
		}

		// Token: 0x060037E6 RID: 14310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037E6")]
		[Address(RVA = "0x7EECE0", Offset = "0x7ED6E0", VA = "0x1807EECE0")]
		public void SetGate1Open(bool o)
		{
		}

		// Token: 0x060037E7 RID: 14311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037E7")]
		[Address(RVA = "0x7EED70", Offset = "0x7ED770", VA = "0x1807EED70")]
		public void SetGate2Open(bool o)
		{
		}

		// Token: 0x060037E8 RID: 14312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037E8")]
		[Address(RVA = "0x7EE510", Offset = "0x7ECF10", VA = "0x1807EE510")]
		private void ResetTrafficCones()
		{
		}

		// Token: 0x060037E9 RID: 14313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037E9")]
		[Address(RVA = "0x7EE300", Offset = "0x7ECD00", VA = "0x1807EE300")]
		public void PlayerDetected(Player player)
		{
		}

		// Token: 0x060037EA RID: 14314 RVA: 0x0000F180 File Offset: 0x0000D380
		[Token(Token = "0x60037EA")]
		[Address(RVA = "0x7EEE00", Offset = "0x7ED800", VA = "0x1807EEE00")]
		private bool TryGetNearestAssignedNPC(out NPC npc, out float distance)
		{
			return default(bool);
		}

		// Token: 0x060037EB RID: 14315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037EB")]
		[Address(RVA = "0x7EF4D0", Offset = "0x7EDED0", VA = "0x1807EF4D0")]
		public RoadCheckpoint()
		{
		}

		// Token: 0x060037EC RID: 14316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037EC")]
		[Address(RVA = "0x7EE030", Offset = "0x7ECA30", VA = "0x1807EE030", Slot = "22")]
		public virtual void NetworkInitialize___Early()
		{
		}

		// Token: 0x060037ED RID: 14317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037ED")]
		[Address(RVA = "0x7EDFC0", Offset = "0x7EC9C0", VA = "0x1807EDFC0", Slot = "23")]
		public virtual void NetworkInitialize__Late()
		{
		}

		// Token: 0x060037EE RID: 14318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037EE")]
		[Address(RVA = "0x5B3020", Offset = "0x5B1A20", VA = "0x1805B3020", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x060037EF RID: 14319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037EF")]
		[Address(RVA = "0x7EEAA0", Offset = "0x7ED4A0", VA = "0x1807EEAA0")]
		private void RpcWriter___Observers_Enable_328543758(NetworkConnection conn)
		{
		}

		// Token: 0x060037F0 RID: 14320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037F0")]
		[Address(RVA = "0x7EE8A0", Offset = "0x7ED2A0", VA = "0x1807EE8A0")]
		public void RpcLogic___Enable_328543758(NetworkConnection conn)
		{
		}

		// Token: 0x060037F1 RID: 14321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037F1")]
		[Address(RVA = "0x7EE900", Offset = "0x7ED300", VA = "0x1807EE900")]
		private void RpcReader___Observers_Enable_328543758(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060037F2 RID: 14322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037F2")]
		[Address(RVA = "0x7EEBB0", Offset = "0x7ED5B0", VA = "0x1807EEBB0")]
		private void RpcWriter___Target_Enable_328543758(NetworkConnection conn)
		{
		}

		// Token: 0x060037F3 RID: 14323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037F3")]
		[Address(RVA = "0x7EE940", Offset = "0x7ED340", VA = "0x1807EE940")]
		private void RpcReader___Target_Enable_328543758(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060037F4 RID: 14324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037F4")]
		[Address(RVA = "0x7EE980", Offset = "0x7ED380", VA = "0x1807EE980")]
		private void RpcWriter___Observers_Disable_2166136261()
		{
		}

		// Token: 0x060037F5 RID: 14325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037F5")]
		[Address(RVA = "0x7EE710", Offset = "0x7ED110", VA = "0x1807EE710")]
		public void RpcLogic___Disable_2166136261()
		{
		}

		// Token: 0x060037F6 RID: 14326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037F6")]
		[Address(RVA = "0x7EE8C0", Offset = "0x7ED2C0", VA = "0x1807EE8C0")]
		private void RpcReader___Observers_Disable_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x170007F9 RID: 2041
		// (get) Token: 0x060037F7 RID: 14327 RVA: 0x0000F198 File Offset: 0x0000D398
		// (set) Token: 0x060037F8 RID: 14328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007F9")]
		public bool SyncAccessor_<Gate1Open>k__BackingField
		{
			[Token(Token = "0x60037F7")]
			[Address(RVA = "0x538700", Offset = "0x537100", VA = "0x180538700")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60037F8")]
			[Address(RVA = "0x7EF5B0", Offset = "0x7EDFB0", VA = "0x1807EF5B0")]
			set
			{
			}
		}

		// Token: 0x060037F9 RID: 14329 RVA: 0x0000F1B0 File Offset: 0x0000D3B0
		[Token(Token = "0x60037F9")]
		[Address(RVA = "0x7EE360", Offset = "0x7ECD60", VA = "0x1807EE360", Slot = "24")]
		public virtual bool ReadSyncVar___ScheduleOne.Police.RoadCheckpoint(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return default(bool);
		}

		// Token: 0x170007FA RID: 2042
		// (get) Token: 0x060037FA RID: 14330 RVA: 0x0000F1C8 File Offset: 0x0000D3C8
		// (set) Token: 0x060037FB RID: 14331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007FA")]
		public bool SyncAccessor_<Gate2Open>k__BackingField
		{
			[Token(Token = "0x60037FA")]
			[Address(RVA = "0x633810", Offset = "0x632210", VA = "0x180633810")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60037FB")]
			[Address(RVA = "0x7EF670", Offset = "0x7EE070", VA = "0x1807EF670")]
			set
			{
			}
		}

		// Token: 0x060037FC RID: 14332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037FC")]
		[Address(RVA = "0x7ED990", Offset = "0x7EC390", VA = "0x1807ED990", Slot = "25")]
		protected virtual void Awake_UserLogic_ScheduleOne.Police.RoadCheckpoint_Assembly-CSharp.dll()
		{
		}

		// Token: 0x040026E3 RID: 9955
		[Token(Token = "0x40026E3")]
		public const float MAX_TIME_OPEN = 15f;

		// Token: 0x040026E5 RID: 9957
		[Token(Token = "0x40026E5")]
		[FieldOffset(Offset = "0x11C")]
		protected RoadCheckpoint.ECheckpointState appliedState;

		// Token: 0x040026E8 RID: 9960
		[Token(Token = "0x40026E8")]
		[FieldOffset(Offset = "0x128")]
		public List<NPC> AssignedNPCs;

		// Token: 0x040026E9 RID: 9961
		[Token(Token = "0x40026E9")]
		[FieldOffset(Offset = "0x130")]
		[Header("Settings")]
		public EStealthLevel MaxStealthLevel;

		// Token: 0x040026EA RID: 9962
		[Token(Token = "0x40026EA")]
		[FieldOffset(Offset = "0x134")]
		public bool OpenForNPCs;

		// Token: 0x040026EB RID: 9963
		[Token(Token = "0x40026EB")]
		[FieldOffset(Offset = "0x135")]
		public bool EnabledOnStart;

		// Token: 0x040026EC RID: 9964
		[Token(Token = "0x40026EC")]
		[FieldOffset(Offset = "0x138")]
		[Header("References")]
		[SerializeField]
		protected GameObject container;

		// Token: 0x040026ED RID: 9965
		[Token(Token = "0x40026ED")]
		[FieldOffset(Offset = "0x140")]
		public CarStopper Stopper1;

		// Token: 0x040026EE RID: 9966
		[Token(Token = "0x40026EE")]
		[FieldOffset(Offset = "0x148")]
		public CarStopper Stopper2;

		// Token: 0x040026EF RID: 9967
		[Token(Token = "0x40026EF")]
		[FieldOffset(Offset = "0x150")]
		public VehicleDetector SearchArea1;

		// Token: 0x040026F0 RID: 9968
		[Token(Token = "0x40026F0")]
		[FieldOffset(Offset = "0x158")]
		public VehicleDetector SearchArea2;

		// Token: 0x040026F1 RID: 9969
		[Token(Token = "0x40026F1")]
		[FieldOffset(Offset = "0x160")]
		public VehicleObstacle VehicleObstacle1;

		// Token: 0x040026F2 RID: 9970
		[Token(Token = "0x40026F2")]
		[FieldOffset(Offset = "0x168")]
		public VehicleObstacle VehicleObstacle2;

		// Token: 0x040026F3 RID: 9971
		[Token(Token = "0x40026F3")]
		[FieldOffset(Offset = "0x170")]
		public VehicleDetector NPCVehicleDetectionArea1;

		// Token: 0x040026F4 RID: 9972
		[Token(Token = "0x40026F4")]
		[FieldOffset(Offset = "0x178")]
		public VehicleDetector NPCVehicleDetectionArea2;

		// Token: 0x040026F5 RID: 9973
		[Token(Token = "0x40026F5")]
		[FieldOffset(Offset = "0x180")]
		public VehicleDetector ImmediateVehicleDetector;

		// Token: 0x040026F6 RID: 9974
		[Token(Token = "0x40026F6")]
		[FieldOffset(Offset = "0x188")]
		public Rigidbody[] TrafficCones;

		// Token: 0x040026F7 RID: 9975
		[Token(Token = "0x40026F7")]
		[FieldOffset(Offset = "0x190")]
		public Transform[] StandPoints;

		// Token: 0x040026F8 RID: 9976
		[Token(Token = "0x40026F8")]
		[FieldOffset(Offset = "0x198")]
		protected Dictionary<Rigidbody, Tuple<Vector3, Quaternion>> trafficConeOriginalTransforms;

		// Token: 0x040026F9 RID: 9977
		[Token(Token = "0x40026F9")]
		[FieldOffset(Offset = "0x1A0")]
		private float timeSinceGate1Open;

		// Token: 0x040026FA RID: 9978
		[Token(Token = "0x40026FA")]
		[FieldOffset(Offset = "0x1A4")]
		private bool vehicleDetectedSinceGate1Open;

		// Token: 0x040026FB RID: 9979
		[Token(Token = "0x40026FB")]
		[FieldOffset(Offset = "0x1A8")]
		private float timeSinceGate2Open;

		// Token: 0x040026FC RID: 9980
		[Token(Token = "0x40026FC")]
		[FieldOffset(Offset = "0x1AC")]
		private bool vehicleDetectedSinceGate2Open;

		// Token: 0x040026FD RID: 9981
		[Token(Token = "0x40026FD")]
		[FieldOffset(Offset = "0x1B0")]
		public UnityEvent<Player> onPlayerWalkThrough;

		// Token: 0x040026FE RID: 9982
		[Token(Token = "0x40026FE")]
		[FieldOffset(Offset = "0x1B8")]
		public SyncVar<bool> syncVar___<Gate1Open>k__BackingField;

		// Token: 0x040026FF RID: 9983
		[Token(Token = "0x40026FF")]
		[FieldOffset(Offset = "0x1C0")]
		public SyncVar<bool> syncVar___<Gate2Open>k__BackingField;

		// Token: 0x04002700 RID: 9984
		[Token(Token = "0x4002700")]
		[FieldOffset(Offset = "0x1C8")]
		private bool NetworkInitialize___EarlyScheduleOne.Police.RoadCheckpointAssembly-CSharp.dll_Excuted;

		// Token: 0x04002701 RID: 9985
		[Token(Token = "0x4002701")]
		[FieldOffset(Offset = "0x1C9")]
		private bool NetworkInitialize__LateScheduleOne.Police.RoadCheckpointAssembly-CSharp.dll_Excuted;

		// Token: 0x020007F9 RID: 2041
		[Token(Token = "0x20007F9")]
		public enum ECheckpointState
		{
			// Token: 0x04002703 RID: 9987
			[Token(Token = "0x4002703")]
			Disabled,
			// Token: 0x04002704 RID: 9988
			[Token(Token = "0x4002704")]
			Enabled
		}
	}
}
