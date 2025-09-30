using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Tiles;
using UnityEngine;

namespace ScheduleOne.EntityFramework
{
	// Token: 0x0200059F RID: 1439
	[Token(Token = "0x200059F")]
	public class GridItem : BuildableItem
	{
		// Token: 0x170005A0 RID: 1440
		// (get) Token: 0x060020EF RID: 8431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005A0")]
		public FootprintTile OriginFootprint
		{
			[Token(Token = "0x60020EF")]
			[Address(RVA = "0x697580", Offset = "0x695F80", VA = "0x180697580")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005A1 RID: 1441
		// (get) Token: 0x060020F0 RID: 8432 RVA: 0x0000A9C8 File Offset: 0x00008BC8
		[Token(Token = "0x170005A1")]
		public int FootprintX
		{
			[Token(Token = "0x60020F0")]
			[Address(RVA = "0x6972E0", Offset = "0x695CE0", VA = "0x1806972E0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170005A2 RID: 1442
		// (get) Token: 0x060020F1 RID: 8433 RVA: 0x0000A9E0 File Offset: 0x00008BE0
		[Token(Token = "0x170005A2")]
		public int FootprintY
		{
			[Token(Token = "0x60020F1")]
			[Address(RVA = "0x697430", Offset = "0x695E30", VA = "0x180697430")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170005A3 RID: 1443
		// (get) Token: 0x060020F2 RID: 8434 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060020F3 RID: 8435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005A3")]
		public Grid OwnerGrid
		{
			[Token(Token = "0x60020F2")]
			[Address(RVA = "0x6975E0", Offset = "0x695FE0", VA = "0x1806975E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60020F3")]
			[Address(RVA = "0x6975F0", Offset = "0x695FF0", VA = "0x1806975F0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x060020F4 RID: 8436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020F4")]
		[Address(RVA = "0x6944A0", Offset = "0x692EA0", VA = "0x1806944A0", Slot = "47")]
		public override void Awake()
		{
		}

		// Token: 0x060020F5 RID: 8437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020F5")]
		[Address(RVA = "0x695300", Offset = "0x693D00", VA = "0x180695300", Slot = "11")]
		public override void OnStartClient()
		{
		}

		// Token: 0x060020F6 RID: 8438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020F6")]
		[Address(RVA = "0x696BE0", Offset = "0x6955E0", VA = "0x180696BE0", Slot = "51")]
		protected override void SendInitToClient(NetworkConnection conn)
		{
		}

		// Token: 0x060020F7 RID: 8439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020F7")]
		[Address(RVA = "0x696A50", Offset = "0x695450", VA = "0x180696A50")]
		[ServerRpc(RequireOwnership = false)]
		public void SendGridItemData(ItemInstance instance, string gridGUID, Vector2 originCoordinate, int rotation, string GUID)
		{
		}

		// Token: 0x060020F8 RID: 8440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020F8")]
		[Address(RVA = "0x694E30", Offset = "0x693830", VA = "0x180694E30", Slot = "65")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public virtual void InitializeGridItem(NetworkConnection conn, ItemInstance instance, string gridGUID, Vector2 originCoordinate, int rotation, string GUID)
		{
		}

		// Token: 0x060020F9 RID: 8441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020F9")]
		[Address(RVA = "0x694C40", Offset = "0x693640", VA = "0x180694C40", Slot = "66")]
		public virtual void InitializeGridItem(ItemInstance instance, Grid grid, Vector2 originCoordinate, int rotation, string GUID)
		{
		}

		// Token: 0x060020FA RID: 8442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020FA")]
		[Address(RVA = "0x696D80", Offset = "0x695780", VA = "0x180696D80")]
		protected void SetGridData(Guid gridGUID, Vector2 originCoordinate, int rotation)
		{
		}

		// Token: 0x060020FB RID: 8443 RVA: 0x0000A9F8 File Offset: 0x00008BF8
		[Token(Token = "0x60020FB")]
		[Address(RVA = "0x696FF0", Offset = "0x6959F0", VA = "0x180696FF0")]
		private int ValidateRotation(int rotation)
		{
			return 0;
		}

		// Token: 0x060020FC RID: 8444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020FC")]
		[Address(RVA = "0x695390", Offset = "0x693D90", VA = "0x180695390")]
		private void ProcessGridData()
		{
		}

		// Token: 0x060020FD RID: 8445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020FD")]
		[Address(RVA = "0x695B60", Offset = "0x694560", VA = "0x180695B60")]
		private void RefreshTransform()
		{
		}

		// Token: 0x060020FE RID: 8446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020FE")]
		[Address(RVA = "0x694780", Offset = "0x693180", VA = "0x180694780")]
		private void ClearPositionData()
		{
		}

		// Token: 0x060020FF RID: 8447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020FF")]
		[Address(RVA = "0x694910", Offset = "0x693310", VA = "0x180694910", Slot = "55")]
		public override void DestroyItem(bool callOnServer = true)
		{
		}

		// Token: 0x06002100 RID: 8448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002100")]
		[Address(RVA = "0x694600", Offset = "0x693000", VA = "0x180694600", Slot = "67")]
		public virtual void CalculateFootprintTileIntersections()
		{
		}

		// Token: 0x06002101 RID: 8449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002101")]
		[Address(RVA = "0x696CC0", Offset = "0x6956C0", VA = "0x180696CC0")]
		public void SetFootprintTileVisiblity(bool visible)
		{
		}

		// Token: 0x06002102 RID: 8450 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002102")]
		[Address(RVA = "0x694A30", Offset = "0x693430", VA = "0x180694A30")]
		public FootprintTile GetFootprintTile(Coordinate coord)
		{
			return null;
		}

		// Token: 0x06002103 RID: 8451 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002103")]
		[Address(RVA = "0x694B30", Offset = "0x693530", VA = "0x180694B30")]
		public Tile GetParentTileAtFootprintCoordinate(Coordinate footprintCoord)
		{
			return null;
		}

		// Token: 0x06002104 RID: 8452 RVA: 0x0000AA10 File Offset: 0x00008C10
		[Token(Token = "0x6002104")]
		[Address(RVA = "0x6946C0", Offset = "0x6930C0", VA = "0x1806946C0", Slot = "68")]
		public virtual bool CanShareTileWith(List<GridItem> obstacles)
		{
			return default(bool);
		}

		// Token: 0x06002105 RID: 8453 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002105")]
		[Address(RVA = "0x694940", Offset = "0x693340", VA = "0x180694940", Slot = "60")]
		public override BuildableItemData GetBaseData()
		{
			return null;
		}

		// Token: 0x06002106 RID: 8454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002106")]
		[Address(RVA = "0x697210", Offset = "0x695C10", VA = "0x180697210")]
		public GridItem()
		{
		}

		// Token: 0x06002107 RID: 8455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002107")]
		[Address(RVA = "0x696F10", Offset = "0x695910", VA = "0x180696F10")]
		[CompilerGenerated]
		private IEnumerator <OnStartClient>g__WaitForDataSend|18_0()
		{
			return null;
		}

		// Token: 0x06002109 RID: 8457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002109")]
		[Address(RVA = "0x696F80", Offset = "0x695980", VA = "0x180696F80")]
		[CompilerGenerated]
		private IEnumerator <ProcessGridData>g__Routine|25_0()
		{
			return null;
		}

		// Token: 0x0600210B RID: 8459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600210B")]
		[Address(RVA = "0x6951D0", Offset = "0x693BD0", VA = "0x1806951D0", Slot = "62")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x0600210C RID: 8460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600210C")]
		[Address(RVA = "0x6951B0", Offset = "0x693BB0", VA = "0x1806951B0", Slot = "63")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x0600210D RID: 8461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600210D")]
		[Address(RVA = "0x669880", Offset = "0x668280", VA = "0x180669880", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x0600210E RID: 8462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600210E")]
		[Address(RVA = "0x6966E0", Offset = "0x6950E0", VA = "0x1806966E0")]
		private void RpcWriter___Server_SendGridItemData_2821640832(ItemInstance instance, string gridGUID, Vector2 originCoordinate, int rotation, string GUID)
		{
		}

		// Token: 0x0600210F RID: 8463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600210F")]
		[Address(RVA = "0x696190", Offset = "0x694B90", VA = "0x180696190")]
		public void RpcLogic___SendGridItemData_2821640832(ItemInstance instance, string gridGUID, Vector2 originCoordinate, int rotation, string GUID)
		{
		}

		// Token: 0x06002110 RID: 8464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002110")]
		[Address(RVA = "0x6962F0", Offset = "0x694CF0", VA = "0x1806962F0")]
		private void RpcReader___Server_SendGridItemData_2821640832(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06002111 RID: 8465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002111")]
		[Address(RVA = "0x696890", Offset = "0x695290", VA = "0x180696890")]
		private void RpcWriter___Target_InitializeGridItem_1883577149(NetworkConnection conn, ItemInstance instance, string gridGUID, Vector2 originCoordinate, int rotation, string GUID)
		{
		}

		// Token: 0x06002112 RID: 8466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002112")]
		[Address(RVA = "0x6960B0", Offset = "0x694AB0", VA = "0x1806960B0", Slot = "69")]
		public virtual void RpcLogic___InitializeGridItem_1883577149(NetworkConnection conn, ItemInstance instance, string gridGUID, Vector2 originCoordinate, int rotation, string GUID)
		{
		}

		// Token: 0x06002113 RID: 8467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002113")]
		[Address(RVA = "0x696400", Offset = "0x694E00", VA = "0x180696400")]
		private void RpcReader___Target_InitializeGridItem_1883577149(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06002114 RID: 8468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002114")]
		[Address(RVA = "0x696510", Offset = "0x694F10", VA = "0x180696510")]
		private void RpcWriter___Observers_InitializeGridItem_1883577149(NetworkConnection conn, ItemInstance instance, string gridGUID, Vector2 originCoordinate, int rotation, string GUID)
		{
		}

		// Token: 0x06002115 RID: 8469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002115")]
		[Address(RVA = "0x6961E0", Offset = "0x694BE0", VA = "0x1806961E0")]
		private void RpcReader___Observers_InitializeGridItem_1883577149(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06002116 RID: 8470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002116")]
		[Address(RVA = "0x694370", Offset = "0x692D70", VA = "0x180694370", Slot = "70")]
		protected virtual void Awake_UserLogic_ScheduleOne.EntityFramework.GridItem_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04001AD7 RID: 6871
		[Token(Token = "0x4001AD7")]
		[FieldOffset(Offset = "0x1D0")]
		[Header("Grid item data")]
		public List<CoordinateFootprintTilePair> CoordinateFootprintTilePairs;

		// Token: 0x04001AD8 RID: 6872
		[Token(Token = "0x4001AD8")]
		[FieldOffset(Offset = "0x1D8")]
		public GridItem.EGridType GridType;

		// Token: 0x04001ADA RID: 6874
		[Token(Token = "0x4001ADA")]
		[FieldOffset(Offset = "0x1E8")]
		public Guid OwnerGridGUID;

		// Token: 0x04001ADB RID: 6875
		[Token(Token = "0x4001ADB")]
		[FieldOffset(Offset = "0x1F8")]
		public Vector2 OriginCoordinate;

		// Token: 0x04001ADC RID: 6876
		[Token(Token = "0x4001ADC")]
		[FieldOffset(Offset = "0x200")]
		public int Rotation;

		// Token: 0x04001ADD RID: 6877
		[Token(Token = "0x4001ADD")]
		[FieldOffset(Offset = "0x208")]
		public List<CoordinatePair> CoordinatePairs;

		// Token: 0x04001ADE RID: 6878
		[Token(Token = "0x4001ADE")]
		[FieldOffset(Offset = "0x210")]
		private bool NetworkInitialize___EarlyScheduleOne.EntityFramework.GridItemAssembly-CSharp.dll_Excuted;

		// Token: 0x04001ADF RID: 6879
		[Token(Token = "0x4001ADF")]
		[FieldOffset(Offset = "0x211")]
		private bool NetworkInitialize__LateScheduleOne.EntityFramework.GridItemAssembly-CSharp.dll_Excuted;

		// Token: 0x020005A0 RID: 1440
		[Token(Token = "0x20005A0")]
		public enum EGridType
		{
			// Token: 0x04001AE1 RID: 6881
			[Token(Token = "0x4001AE1")]
			All,
			// Token: 0x04001AE2 RID: 6882
			[Token(Token = "0x4001AE2")]
			IndoorOnly,
			// Token: 0x04001AE3 RID: 6883
			[Token(Token = "0x4001AE3")]
			OutdoorOnly
		}
	}
}
