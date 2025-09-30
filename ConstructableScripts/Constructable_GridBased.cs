using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Property.Utilities.Power;
using ScheduleOne.Tiles;
using UnityEngine;

namespace ScheduleOne.ConstructableScripts
{
	// Token: 0x020009DB RID: 2523
	[Token(Token = "0x20009DB")]
	public class Constructable_GridBased : Constructable
	{
		// Token: 0x1700099C RID: 2460
		// (get) Token: 0x0600450A RID: 17674 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700099C")]
		public FootprintTile OriginFootprint
		{
			[Token(Token = "0x600450A")]
			[Address(RVA = "0x8B64B0", Offset = "0x8B4EB0", VA = "0x1808B64B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700099D RID: 2461
		// (get) Token: 0x0600450B RID: 17675 RVA: 0x00012210 File Offset: 0x00010410
		[Token(Token = "0x1700099D")]
		public int FootprintX
		{
			[Token(Token = "0x600450B")]
			[Address(RVA = "0x8B63B0", Offset = "0x8B4DB0", VA = "0x1808B63B0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700099E RID: 2462
		// (get) Token: 0x0600450C RID: 17676 RVA: 0x00012228 File Offset: 0x00010428
		[Token(Token = "0x1700099E")]
		public int FootprintY
		{
			[Token(Token = "0x600450C")]
			[Address(RVA = "0x8B6430", Offset = "0x8B4E30", VA = "0x1808B6430")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700099F RID: 2463
		// (get) Token: 0x0600450D RID: 17677 RVA: 0x00012240 File Offset: 0x00010440
		[Token(Token = "0x1700099F")]
		public bool hasWaterSupply
		{
			[Token(Token = "0x600450D")]
			[Address(RVA = "0x48DCC0", Offset = "0x48C6C0", VA = "0x18048DCC0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170009A0 RID: 2464
		// (get) Token: 0x0600450E RID: 17678 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009A0")]
		public PowerNode PowerNode
		{
			[Token(Token = "0x600450E")]
			[Address(RVA = "0x66EF40", Offset = "0x66D940", VA = "0x18066EF40")]
			get
			{
				return null;
			}
		}

		// Token: 0x170009A1 RID: 2465
		// (get) Token: 0x0600450F RID: 17679 RVA: 0x00012258 File Offset: 0x00010458
		[Token(Token = "0x170009A1")]
		public bool isPowered
		{
			[Token(Token = "0x600450F")]
			[Address(RVA = "0x8B6510", Offset = "0x8B4F10", VA = "0x1808B6510")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170009A2 RID: 2466
		// (get) Token: 0x06004510 RID: 17680 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004511 RID: 17681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009A2")]
		public Grid OwnerGrid
		{
			[Token(Token = "0x6004510")]
			[Address(RVA = "0x567030", Offset = "0x565A30", VA = "0x180567030")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004511")]
			[Address(RVA = "0x8B6540", Offset = "0x8B4F40", VA = "0x1808B6540")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06004512 RID: 17682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004512")]
		[Address(RVA = "0x8B2830", Offset = "0x8B1230", VA = "0x1808B2830", Slot = "19")]
		public override void Awake()
		{
		}

		// Token: 0x06004513 RID: 17683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004513")]
		[Address(RVA = "0x8B3A60", Offset = "0x8B2460", VA = "0x1808B3A60", Slot = "6")]
		public override void OnStartServer()
		{
		}

		// Token: 0x06004514 RID: 17684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004514")]
		[Address(RVA = "0x8B3910", Offset = "0x8B2310", VA = "0x1808B3910", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x06004515 RID: 17685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004515")]
		[Address(RVA = "0x8B39F0", Offset = "0x8B23F0", VA = "0x1808B39F0", Slot = "4")]
		public override void OnStartNetwork()
		{
		}

		// Token: 0x06004516 RID: 17686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004516")]
		[Address(RVA = "0x8B33A0", Offset = "0x8B1DA0", VA = "0x1808B33A0", Slot = "33")]
		public virtual void InitializeConstructable_GridBased(Grid grid, Vector2 originCoordinate, float rotation)
		{
		}

		// Token: 0x06004517 RID: 17687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004517")]
		[Address(RVA = "0x8B3D70", Offset = "0x8B2770", VA = "0x1808B3D70")]
		private void ReceiveData()
		{
		}

		// Token: 0x06004518 RID: 17688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004518")]
		[Address(RVA = "0x8B5BC0", Offset = "0x8B45C0", VA = "0x1808B5BC0")]
		private void SetParent(Transform parent)
		{
		}

		// Token: 0x06004519 RID: 17689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004519")]
		[Address(RVA = "0x8B55F0", Offset = "0x8B3FF0", VA = "0x1808B55F0", Slot = "34")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		protected virtual void SetData(Guid gridGUID, Vector2 originCoordinate, float rotation)
		{
		}

		// Token: 0x0600451A RID: 17690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600451A")]
		[Address(RVA = "0x8B4A30", Offset = "0x8B3430", VA = "0x1808B4A30", Slot = "35")]
		public virtual void RepositionConstructable(Guid gridGUID, Vector2 originCoordinate, float rotation)
		{
		}

		// Token: 0x0600451B RID: 17691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600451B")]
		[Address(RVA = "0x8B4420", Offset = "0x8B2E20", VA = "0x1808B4420")]
		private void RefreshTransform()
		{
		}

		// Token: 0x0600451C RID: 17692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600451C")]
		[Address(RVA = "0x8B2940", Offset = "0x8B1340", VA = "0x1808B2940")]
		private void ClearPositionData()
		{
		}

		// Token: 0x0600451D RID: 17693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600451D")]
		[Address(RVA = "0x8B2A90", Offset = "0x8B1490", VA = "0x1808B2A90", Slot = "22")]
		public override void DestroyConstructable(bool callOnServer = true)
		{
		}

		// Token: 0x0600451E RID: 17694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600451E")]
		[Address(RVA = "0x8B2DC0", Offset = "0x8B17C0", VA = "0x1808B2DC0")]
		private void GenerateGridGUIDs()
		{
		}

		// Token: 0x0600451F RID: 17695 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600451F")]
		[Address(RVA = "0x8B3290", Offset = "0x8B1C90", VA = "0x1808B3290")]
		private string[] GetGridGUIDs()
		{
			return null;
		}

		// Token: 0x06004520 RID: 17696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004520")]
		[Address(RVA = "0x8B5880", Offset = "0x8B4280", VA = "0x1808B5880")]
		[TargetRpc]
		[ObserversRpc]
		protected void SetGridGUIDs(NetworkConnection target, string[] guids)
		{
		}

		// Token: 0x06004521 RID: 17697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004521")]
		[Address(RVA = "0x8B5A80", Offset = "0x8B4480", VA = "0x1808B5A80", Slot = "28")]
		public override void SetInvisible()
		{
		}

		// Token: 0x06004522 RID: 17698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004522")]
		[Address(RVA = "0x8B4A60", Offset = "0x8B3460", VA = "0x1808B4A60", Slot = "29")]
		public override void RestoreVisibility()
		{
		}

		// Token: 0x06004523 RID: 17699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004523")]
		[Address(RVA = "0x8B5C20", Offset = "0x8B4620", VA = "0x1808B5C20", Slot = "36")]
		public virtual void SetRoofVisible(bool vis)
		{
		}

		// Token: 0x06004524 RID: 17700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004524")]
		[Address(RVA = "0x8B2880", Offset = "0x8B1280", VA = "0x1808B2880")]
		public void CalculateFootprintTileIntersections()
		{
		}

		// Token: 0x06004525 RID: 17701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004525")]
		[Address(RVA = "0x8B57C0", Offset = "0x8B41C0", VA = "0x1808B57C0")]
		public void SetFootprintTileVisiblity(bool visible)
		{
		}

		// Token: 0x06004526 RID: 17702 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004526")]
		[Address(RVA = "0x8B3030", Offset = "0x8B1A30", VA = "0x1808B3030")]
		public FootprintTile GetFootprintTile(Coordinate coord)
		{
			return null;
		}

		// Token: 0x06004527 RID: 17703 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004527")]
		[Address(RVA = "0x8B3130", Offset = "0x8B1B30", VA = "0x1808B3130")]
		public List<FootprintTile> GetFootprintTiles()
		{
			return null;
		}

		// Token: 0x06004528 RID: 17704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004528")]
		[Address(RVA = "0x8B6090", Offset = "0x8B4A90", VA = "0x1808B6090")]
		public Constructable_GridBased()
		{
		}

		// Token: 0x06004529 RID: 17705 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004529")]
		[Address(RVA = "0x8B6020", Offset = "0x8B4A20", VA = "0x1808B6020")]
		[CompilerGenerated]
		private IEnumerator <ReceiveData>g__Routine|36_0()
		{
			return null;
		}

		// Token: 0x0600452B RID: 17707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600452B")]
		[Address(RVA = "0x8B3480", Offset = "0x8B1E80", VA = "0x1808B3480", Slot = "30")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x0600452C RID: 17708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600452C")]
		[Address(RVA = "0x8B33E0", Offset = "0x8B1DE0", VA = "0x1808B33E0", Slot = "31")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x0600452D RID: 17709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600452D")]
		[Address(RVA = "0x8434B0", Offset = "0x841EB0", VA = "0x1808434B0", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x0600452E RID: 17710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600452E")]
		[Address(RVA = "0x8B52E0", Offset = "0x8B3CE0", VA = "0x1808B52E0")]
		private void RpcWriter___Server_SetData_810381718(Guid gridGUID, Vector2 originCoordinate, float rotation)
		{
		}

		// Token: 0x0600452F RID: 17711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600452F")]
		[Address(RVA = "0x8B4B60", Offset = "0x8B3560", VA = "0x1808B4B60", Slot = "37")]
		protected virtual void RpcLogic___SetData_810381718(Guid gridGUID, Vector2 originCoordinate, float rotation)
		{
		}

		// Token: 0x06004530 RID: 17712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004530")]
		[Address(RVA = "0x8B5050", Offset = "0x8B3A50", VA = "0x1808B5050")]
		private void RpcReader___Server_SetData_810381718(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06004531 RID: 17713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004531")]
		[Address(RVA = "0x8B51A0", Offset = "0x8B3BA0", VA = "0x1808B51A0")]
		private void RpcWriter___Observers_SetGridGUIDs_2890081366(NetworkConnection target, string[] guids)
		{
		}

		// Token: 0x06004532 RID: 17714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004532")]
		[Address(RVA = "0x8B4E50", Offset = "0x8B3850", VA = "0x1808B4E50")]
		protected void RpcLogic___SetGridGUIDs_2890081366(NetworkConnection target, string[] guids)
		{
		}

		// Token: 0x06004533 RID: 17715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004533")]
		[Address(RVA = "0x8B5000", Offset = "0x8B3A00", VA = "0x1808B5000")]
		private void RpcReader___Observers_SetGridGUIDs_2890081366(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06004534 RID: 17716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004534")]
		[Address(RVA = "0x8B5490", Offset = "0x8B3E90", VA = "0x1808B5490")]
		private void RpcWriter___Target_SetGridGUIDs_2890081366(NetworkConnection target, string[] guids)
		{
		}

		// Token: 0x06004535 RID: 17717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004535")]
		[Address(RVA = "0x8B5140", Offset = "0x8B3B40", VA = "0x1808B5140")]
		private void RpcReader___Target_SetGridGUIDs_2890081366(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x170009A3 RID: 2467
		// (get) Token: 0x06004536 RID: 17718 RVA: 0x00012288 File Offset: 0x00010488
		// (set) Token: 0x06004537 RID: 17719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009A3")]
		public Guid SyncAccessor_OwnerGridGUID
		{
			[Token(Token = "0x6004536")]
			[Address(RVA = "0x8B6580", Offset = "0x8B4F80", VA = "0x1808B6580")]
			get
			{
				return default(Guid);
			}
			[Token(Token = "0x6004537")]
			[Address(RVA = "0x8B6660", Offset = "0x8B5060", VA = "0x1808B6660")]
			set
			{
			}
		}

		// Token: 0x06004538 RID: 17720 RVA: 0x000122A0 File Offset: 0x000104A0
		[Token(Token = "0x6004538")]
		[Address(RVA = "0x8B3AD0", Offset = "0x8B24D0", VA = "0x1808B3AD0", Slot = "38")]
		public virtual bool ReadSyncVar___ScheduleOne.ConstructableScripts.Constructable_GridBased(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return default(bool);
		}

		// Token: 0x170009A4 RID: 2468
		// (get) Token: 0x06004539 RID: 17721 RVA: 0x000122B8 File Offset: 0x000104B8
		// (set) Token: 0x0600453A RID: 17722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009A4")]
		public Vector2 SyncAccessor_OriginCoordinate
		{
			[Token(Token = "0x6004539")]
			[Address(RVA = "0x8B6560", Offset = "0x8B4F60", VA = "0x1808B6560")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x600453A")]
			[Address(RVA = "0x8B65A0", Offset = "0x8B4FA0", VA = "0x1808B65A0")]
			set
			{
			}
		}

		// Token: 0x170009A5 RID: 2469
		// (get) Token: 0x0600453B RID: 17723 RVA: 0x000122D0 File Offset: 0x000104D0
		// (set) Token: 0x0600453C RID: 17724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009A5")]
		public float SyncAccessor_Rotation
		{
			[Token(Token = "0x600453B")]
			[Address(RVA = "0x8B6590", Offset = "0x8B4F90", VA = "0x1808B6590")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600453C")]
			[Address(RVA = "0x8B6720", Offset = "0x8B5120", VA = "0x1808B6720")]
			set
			{
			}
		}

		// Token: 0x0600453D RID: 17725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600453D")]
		[Address(RVA = "0x8B25F0", Offset = "0x8B0FF0", VA = "0x1808B25F0", Slot = "39")]
		protected virtual void Awake_UserLogic_ScheduleOne.ConstructableScripts.Constructable_GridBased_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04003071 RID: 12401
		[Token(Token = "0x4003071")]
		[FieldOffset(Offset = "0x188")]
		[Header("Grid Based Constructable References")]
		public Transform buildPoint;

		// Token: 0x04003072 RID: 12402
		[Token(Token = "0x4003072")]
		[FieldOffset(Offset = "0x190")]
		public List<CoordinateFootprintTilePair> CoordinateFootprintTilePairs;

		// Token: 0x04003073 RID: 12403
		[Token(Token = "0x4003073")]
		[FieldOffset(Offset = "0x198")]
		public Transform ContentContainer;

		// Token: 0x04003074 RID: 12404
		[Token(Token = "0x4003074")]
		[FieldOffset(Offset = "0x1A0")]
		public Grid[] Grids;

		// Token: 0x04003075 RID: 12405
		[Token(Token = "0x4003075")]
		[FieldOffset(Offset = "0x1A8")]
		public List<GameObject> roofObjectsForVisibility;

		// Token: 0x04003076 RID: 12406
		[Token(Token = "0x4003076")]
		[FieldOffset(Offset = "0x1B0")]
		[Header("Power")]
		[SerializeField]
		protected bool AlwaysPowered;

		// Token: 0x04003077 RID: 12407
		[Token(Token = "0x4003077")]
		[FieldOffset(Offset = "0x1B8")]
		[SerializeField]
		protected PowerNode powerNode;

		// Token: 0x04003078 RID: 12408
		[Token(Token = "0x4003078")]
		[FieldOffset(Offset = "0x1C0")]
		[HideInInspector]
		public bool isGhost;

		// Token: 0x04003079 RID: 12409
		[Token(Token = "0x4003079")]
		[FieldOffset(Offset = "0x1C1")]
		protected bool dataChangedThisFrame;

		// Token: 0x0400307B RID: 12411
		[Token(Token = "0x400307B")]
		[FieldOffset(Offset = "0x1D0")]
		[SyncVar]
		public Guid OwnerGridGUID;

		// Token: 0x0400307C RID: 12412
		[Token(Token = "0x400307C")]
		[FieldOffset(Offset = "0x1E0")]
		[SyncVar]
		public Vector2 OriginCoordinate;

		// Token: 0x0400307D RID: 12413
		[Token(Token = "0x400307D")]
		[FieldOffset(Offset = "0x1E8")]
		[SyncVar]
		public float Rotation;

		// Token: 0x0400307E RID: 12414
		[Token(Token = "0x400307E")]
		[FieldOffset(Offset = "0x1F0")]
		public List<CoordinatePair> coordinatePairs;

		// Token: 0x0400307F RID: 12415
		[Token(Token = "0x400307F")]
		[FieldOffset(Offset = "0x1F8")]
		private Dictionary<GameObject, LayerMask> originalRoofLayers;

		// Token: 0x04003080 RID: 12416
		[Token(Token = "0x4003080")]
		[FieldOffset(Offset = "0x200")]
		protected bool roofVisible;

		// Token: 0x04003081 RID: 12417
		[Token(Token = "0x4003081")]
		[FieldOffset(Offset = "0x208")]
		public SyncVar<Guid> syncVar___OwnerGridGUID;

		// Token: 0x04003082 RID: 12418
		[Token(Token = "0x4003082")]
		[FieldOffset(Offset = "0x210")]
		public SyncVar<Vector2> syncVar___OriginCoordinate;

		// Token: 0x04003083 RID: 12419
		[Token(Token = "0x4003083")]
		[FieldOffset(Offset = "0x218")]
		public SyncVar<float> syncVar___Rotation;

		// Token: 0x04003084 RID: 12420
		[Token(Token = "0x4003084")]
		[FieldOffset(Offset = "0x220")]
		private bool NetworkInitialize___EarlyScheduleOne.ConstructableScripts.Constructable_GridBasedAssembly-CSharp.dll_Excuted;

		// Token: 0x04003085 RID: 12421
		[Token(Token = "0x4003085")]
		[FieldOffset(Offset = "0x221")]
		private bool NetworkInitialize__LateScheduleOne.ConstructableScripts.Constructable_GridBasedAssembly-CSharp.dll_Excuted;
	}
}
