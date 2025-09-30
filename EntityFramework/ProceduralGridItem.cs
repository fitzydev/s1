using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Property;
using ScheduleOne.Tiles;
using UnityEngine;

namespace ScheduleOne.EntityFramework
{
	// Token: 0x020005A7 RID: 1447
	[Token(Token = "0x20005A7")]
	public class ProceduralGridItem : BuildableItem
	{
		// Token: 0x170005AA RID: 1450
		// (get) Token: 0x0600213F RID: 8511 RVA: 0x0000AAD0 File Offset: 0x00008CD0
		[Token(Token = "0x170005AA")]
		public int FootprintXSize
		{
			[Token(Token = "0x600213F")]
			[Address(RVA = "0x69AA90", Offset = "0x699490", VA = "0x18069AA90")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170005AB RID: 1451
		// (get) Token: 0x06002140 RID: 8512 RVA: 0x0000AAE8 File Offset: 0x00008CE8
		[Token(Token = "0x170005AB")]
		public int FootprintYSize
		{
			[Token(Token = "0x6002140")]
			[Address(RVA = "0x69ABE0", Offset = "0x6995E0", VA = "0x18069ABE0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06002141 RID: 8513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002141")]
		[Address(RVA = "0x6985A0", Offset = "0x696FA0", VA = "0x1806985A0", Slot = "47")]
		public override void Awake()
		{
		}

		// Token: 0x06002142 RID: 8514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002142")]
		[Address(RVA = "0x699840", Offset = "0x698240", VA = "0x180699840", Slot = "11")]
		public override void OnStartClient()
		{
		}

		// Token: 0x06002143 RID: 8515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002143")]
		[Address(RVA = "0x69A440", Offset = "0x698E40", VA = "0x18069A440", Slot = "51")]
		protected override void SendInitToClient(NetworkConnection conn)
		{
		}

		// Token: 0x06002144 RID: 8516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002144")]
		[Address(RVA = "0x69A130", Offset = "0x698B30", VA = "0x18069A130")]
		[ServerRpc(RequireOwnership = false)]
		public void SendProceduralGridItemData(ItemInstance instance, int _rotation, List<CoordinateProceduralTilePair> _footprintTileMatches, string GUID)
		{
		}

		// Token: 0x06002145 RID: 8517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002145")]
		[Address(RVA = "0x6991B0", Offset = "0x697BB0", VA = "0x1806991B0", Slot = "65")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public virtual void InitializeProceduralGridItem(NetworkConnection conn, ItemInstance instance, int _rotation, List<CoordinateProceduralTilePair> _footprintTileMatches, string GUID)
		{
		}

		// Token: 0x06002146 RID: 8518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002146")]
		[Address(RVA = "0x698F70", Offset = "0x697970", VA = "0x180698F70", Slot = "66")]
		public virtual void InitializeProceduralGridItem(ItemInstance instance, int _rotation, List<CoordinateProceduralTilePair> _footprintTileMatches, string GUID)
		{
		}

		// Token: 0x06002147 RID: 8519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002147")]
		[Address(RVA = "0x69A5A0", Offset = "0x698FA0", VA = "0x18069A5A0", Slot = "67")]
		protected virtual void SetProceduralGridData(int _rotation, List<CoordinateProceduralTilePair> _footprintTileMatches)
		{
		}

		// Token: 0x06002148 RID: 8520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002148")]
		[Address(RVA = "0x6999F0", Offset = "0x6983F0", VA = "0x1806999F0")]
		private void RefreshTransform()
		{
		}

		// Token: 0x06002149 RID: 8521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002149")]
		[Address(RVA = "0x698740", Offset = "0x697140", VA = "0x180698740")]
		private void ClearPositionData()
		{
		}

		// Token: 0x0600214A RID: 8522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600214A")]
		[Address(RVA = "0x698870", Offset = "0x697270", VA = "0x180698870", Slot = "55")]
		public override void DestroyItem(bool callOnServer = true)
		{
		}

		// Token: 0x0600214B RID: 8523 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600214B")]
		[Address(RVA = "0x698E80", Offset = "0x697880", VA = "0x180698E80", Slot = "49")]
		protected override Property GetProperty([Optional] Transform searchTransform)
		{
			return null;
		}

		// Token: 0x0600214C RID: 8524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600214C")]
		[Address(RVA = "0x698680", Offset = "0x697080", VA = "0x180698680", Slot = "68")]
		public virtual void CalculateFootprintTileIntersections()
		{
		}

		// Token: 0x0600214D RID: 8525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600214D")]
		[Address(RVA = "0x69A4E0", Offset = "0x698EE0", VA = "0x18069A4E0")]
		public void SetFootprintTileVisiblity(bool visible)
		{
		}

		// Token: 0x0600214E RID: 8526 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600214E")]
		[Address(RVA = "0x698D80", Offset = "0x697780", VA = "0x180698D80")]
		public FootprintTile GetFootprintTile(Coordinate coord)
		{
			return null;
		}

		// Token: 0x0600214F RID: 8527 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600214F")]
		[Address(RVA = "0x6989C0", Offset = "0x6973C0", VA = "0x1806989C0", Slot = "60")]
		public override BuildableItemData GetBaseData()
		{
			return null;
		}

		// Token: 0x06002150 RID: 8528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002150")]
		[Address(RVA = "0x69A9C0", Offset = "0x6993C0", VA = "0x18069A9C0")]
		public ProceduralGridItem()
		{
		}

		// Token: 0x06002151 RID: 8529 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002151")]
		[Address(RVA = "0x69A8E0", Offset = "0x6992E0", VA = "0x18069A8E0")]
		[CompilerGenerated]
		private IEnumerator <OnStartClient>g__WaitForDataSend|10_0()
		{
			return null;
		}

		// Token: 0x06002153 RID: 8531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002153")]
		[Address(RVA = "0x69A950", Offset = "0x699350", VA = "0x18069A950")]
		[CompilerGenerated]
		private IEnumerator <SetProceduralGridData>g__Routine|15_0()
		{
			return null;
		}

		// Token: 0x06002155 RID: 8533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002155")]
		[Address(RVA = "0x699540", Offset = "0x697F40", VA = "0x180699540", Slot = "62")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06002156 RID: 8534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002156")]
		[Address(RVA = "0x6994D0", Offset = "0x697ED0", VA = "0x1806994D0", Slot = "63")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06002157 RID: 8535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002157")]
		[Address(RVA = "0x669880", Offset = "0x668280", VA = "0x180669880", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06002158 RID: 8536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002158")]
		[Address(RVA = "0x69A130", Offset = "0x698B30", VA = "0x18069A130")]
		private void RpcWriter___Server_SendProceduralGridItemData_638911643(ItemInstance instance, int _rotation, List<CoordinateProceduralTilePair> _footprintTileMatches, string GUID)
		{
		}

		// Token: 0x06002159 RID: 8537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002159")]
		[Address(RVA = "0x699CE0", Offset = "0x6986E0", VA = "0x180699CE0")]
		public void RpcLogic___SendProceduralGridItemData_638911643(ItemInstance instance, int _rotation, List<CoordinateProceduralTilePair> _footprintTileMatches, string GUID)
		{
		}

		// Token: 0x0600215A RID: 8538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600215A")]
		[Address(RVA = "0x699DF0", Offset = "0x6987F0", VA = "0x180699DF0")]
		private void RpcReader___Server_SendProceduralGridItemData_638911643(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x0600215B RID: 8539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600215B")]
		[Address(RVA = "0x69A2B0", Offset = "0x698CB0", VA = "0x18069A2B0")]
		private void RpcWriter___Target_InitializeProceduralGridItem_3164718044(NetworkConnection conn, ItemInstance instance, int _rotation, List<CoordinateProceduralTilePair> _footprintTileMatches, string GUID)
		{
		}

		// Token: 0x0600215C RID: 8540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600215C")]
		[Address(RVA = "0x699CA0", Offset = "0x6986A0", VA = "0x180699CA0", Slot = "69")]
		public virtual void RpcLogic___InitializeProceduralGridItem_3164718044(NetworkConnection conn, ItemInstance instance, int _rotation, List<CoordinateProceduralTilePair> _footprintTileMatches, string GUID)
		{
		}

		// Token: 0x0600215D RID: 8541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600215D")]
		[Address(RVA = "0x699EC0", Offset = "0x6988C0", VA = "0x180699EC0")]
		private void RpcReader___Target_InitializeProceduralGridItem_3164718044(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600215E RID: 8542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600215E")]
		[Address(RVA = "0x699F90", Offset = "0x698990", VA = "0x180699F90")]
		private void RpcWriter___Observers_InitializeProceduralGridItem_3164718044(NetworkConnection conn, ItemInstance instance, int _rotation, List<CoordinateProceduralTilePair> _footprintTileMatches, string GUID)
		{
		}

		// Token: 0x0600215F RID: 8543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600215F")]
		[Address(RVA = "0x699D20", Offset = "0x698720", VA = "0x180699D20")]
		private void RpcReader___Observers_InitializeProceduralGridItem_3164718044(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x170005AC RID: 1452
		// (get) Token: 0x06002160 RID: 8544 RVA: 0x0000AB30 File Offset: 0x00008D30
		// (set) Token: 0x06002161 RID: 8545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005AC")]
		public int SyncAccessor_Rotation
		{
			[Token(Token = "0x6002160")]
			[Address(RVA = "0x69AD30", Offset = "0x699730", VA = "0x18069AD30")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002161")]
			[Address(RVA = "0x69AD40", Offset = "0x699740", VA = "0x18069AD40")]
			set
			{
			}
		}

		// Token: 0x06002162 RID: 8546 RVA: 0x0000AB48 File Offset: 0x00008D48
		[Token(Token = "0x6002162")]
		[Address(RVA = "0x6998D0", Offset = "0x6982D0", VA = "0x1806998D0", Slot = "70")]
		public virtual bool ReadSyncVar___ScheduleOne.EntityFramework.ProceduralGridItem(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return default(bool);
		}

		// Token: 0x170005AD RID: 1453
		// (get) Token: 0x06002163 RID: 8547 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002164 RID: 8548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005AD")]
		public List<CoordinateProceduralTilePair> SyncAccessor_footprintTileMatches
		{
			[Token(Token = "0x6002163")]
			[Address(RVA = "0x6975E0", Offset = "0x695FE0", VA = "0x1806975E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002164")]
			[Address(RVA = "0x69ADF0", Offset = "0x6997F0", VA = "0x18069ADF0")]
			set
			{
			}
		}

		// Token: 0x06002165 RID: 8549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002165")]
		[Address(RVA = "0x6984E0", Offset = "0x696EE0", VA = "0x1806984E0", Slot = "71")]
		protected virtual void Awake_UserLogic_ScheduleOne.EntityFramework.ProceduralGridItem_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04001AF3 RID: 6899
		[Token(Token = "0x4001AF3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		[Header("Grid item data")]
		public List<CoordinateFootprintTilePair> CoordinateFootprintTilePairs;

		// Token: 0x04001AF4 RID: 6900
		[Token(Token = "0x4001AF4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		public ProceduralTile.EProceduralTileType ProceduralTileType;

		// Token: 0x04001AF5 RID: 6901
		[Token(Token = "0x4001AF5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1DC")]
		[SyncVar]
		[HideInInspector]
		public int Rotation;

		// Token: 0x04001AF6 RID: 6902
		[Token(Token = "0x4001AF6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		[SyncVar]
		[HideInInspector]
		public List<CoordinateProceduralTilePair> footprintTileMatches;

		// Token: 0x04001AF7 RID: 6903
		[Token(Token = "0x4001AF7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		public SyncVar<int> syncVar___Rotation;

		// Token: 0x04001AF8 RID: 6904
		[Token(Token = "0x4001AF8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		public SyncVar<List<CoordinateProceduralTilePair>> syncVar___footprintTileMatches;

		// Token: 0x04001AF9 RID: 6905
		[Token(Token = "0x4001AF9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private bool NetworkInitialize___EarlyScheduleOne.EntityFramework.ProceduralGridItemAssembly-CSharp.dll_Excuted;

		// Token: 0x04001AFA RID: 6906
		[Token(Token = "0x4001AFA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1F9")]
		private bool NetworkInitialize__LateScheduleOne.EntityFramework.ProceduralGridItemAssembly-CSharp.dll_Excuted;

		// Token: 0x020005A8 RID: 1448
		[Token(Token = "0x20005A8")]
		public class FootprintTileMatch
		{
			// Token: 0x06002166 RID: 8550 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002166")]
			[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
			public FootprintTileMatch()
			{
			}

			// Token: 0x04001AFB RID: 6907
			[Token(Token = "0x4001AFB")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FootprintTile footprint;

			// Token: 0x04001AFC RID: 6908
			[Token(Token = "0x4001AFC")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ProceduralTile matchedTile;
		}
	}
}
