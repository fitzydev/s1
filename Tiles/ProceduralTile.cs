using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.EntityFramework;
using UnityEngine;

namespace ScheduleOne.Tiles
{
	// Token: 0x020002CE RID: 718
	[Token(Token = "0x20002CE")]
	public class ProceduralTile : MonoBehaviour
	{
		// Token: 0x06000F6D RID: 3949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F6D")]
		[Address(RVA = "0x42DA80", Offset = "0x42C480", VA = "0x18042DA80", Slot = "4")]
		protected virtual void Awake()
		{
		}

		// Token: 0x06000F6E RID: 3950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F6E")]
		[Address(RVA = "0xABE840", Offset = "0xABD240", VA = "0x180ABE840")]
		public void AddOccupant(FootprintTile footprint, ProceduralGridItem item)
		{
		}

		// Token: 0x06000F6F RID: 3951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F6F")]
		[Address(RVA = "0xABE970", Offset = "0xABD370", VA = "0x180ABE970")]
		public void RemoveOccupant(FootprintTile footprint, ProceduralGridItem item)
		{
		}

		// Token: 0x06000F70 RID: 3952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F70")]
		[Address(RVA = "0xABEA50", Offset = "0xABD450", VA = "0x180ABEA50")]
		public ProceduralTile()
		{
		}

		// Token: 0x04000F69 RID: 3945
		[Token(Token = "0x4000F69")]
		[FieldOffset(Offset = "0x20")]
		[Header("Settings")]
		public ProceduralTile.EProceduralTileType TileType;

		// Token: 0x04000F6A RID: 3946
		[Token(Token = "0x4000F6A")]
		[FieldOffset(Offset = "0x28")]
		[Header("References")]
		public BuildableItem ParentBuildableItem;

		// Token: 0x04000F6B RID: 3947
		[Token(Token = "0x4000F6B")]
		[FieldOffset(Offset = "0x30")]
		public FootprintTile MatchedFootprintTile;

		// Token: 0x04000F6C RID: 3948
		[Token(Token = "0x4000F6C")]
		[FieldOffset(Offset = "0x38")]
		[Header("Occupants")]
		public List<ProceduralGridItem> Occupants;

		// Token: 0x04000F6D RID: 3949
		[Token(Token = "0x4000F6D")]
		[FieldOffset(Offset = "0x40")]
		public List<FootprintTile> OccupantTiles;

		// Token: 0x020002CF RID: 719
		[Token(Token = "0x20002CF")]
		public enum EProceduralTileType
		{
			// Token: 0x04000F6F RID: 3951
			[Token(Token = "0x4000F6F")]
			Rack
		}
	}
}
