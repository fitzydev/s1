using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.ConstructableScripts;
using ScheduleOne.EntityFramework;
using ScheduleOne.Lighting;
using UnityEngine;

namespace ScheduleOne.Tiles
{
	// Token: 0x020002D0 RID: 720
	[Token(Token = "0x20002D0")]
	[Serializable]
	public class Tile : MonoBehaviour
	{
		// Token: 0x06000F71 RID: 3953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F71")]
		[Address(RVA = "0xAC9BE0", Offset = "0xAC85E0", VA = "0x180AC9BE0")]
		public void InitializePropertyTile(int _x, int _y, float _available_Offset, Grid _ownerGrid)
		{
		}

		// Token: 0x06000F72 RID: 3954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F72")]
		[Address(RVA = "0xAC97C0", Offset = "0xAC81C0", VA = "0x180AC97C0")]
		public void AddOccupant(GridItem occ, FootprintTile tile)
		{
		}

		// Token: 0x06000F73 RID: 3955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F73")]
		[Address(RVA = "0xAC9620", Offset = "0xAC8020", VA = "0x180AC9620")]
		public void AddOccupant(Constructable_GridBased occ, FootprintTile tile)
		{
		}

		// Token: 0x06000F74 RID: 3956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F74")]
		[Address(RVA = "0xAC9C00", Offset = "0xAC8600", VA = "0x180AC9C00")]
		public void RemoveOccupant(GridItem occ, FootprintTile tile)
		{
		}

		// Token: 0x06000F75 RID: 3957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F75")]
		[Address(RVA = "0xAC9CB0", Offset = "0xAC86B0", VA = "0x180AC9CB0")]
		public void RemoveOccupant(Constructable_GridBased occ, FootprintTile tile)
		{
		}

		// Token: 0x06000F76 RID: 3958 RVA: 0x00007770 File Offset: 0x00005970
		[Token(Token = "0x6000F76")]
		[Address(RVA = "0xAC9960", Offset = "0xAC8360", VA = "0x180AC9960", Slot = "4")]
		public virtual bool CanBeBuiltOn()
		{
			return default(bool);
		}

		// Token: 0x06000F77 RID: 3959 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F77")]
		[Address(RVA = "0xAC9A20", Offset = "0xAC8420", VA = "0x180AC9A20")]
		public List<Tile> GetSurroundingTiles()
		{
			return null;
		}

		// Token: 0x06000F78 RID: 3960 RVA: 0x00007788 File Offset: 0x00005988
		[Token(Token = "0x6000F78")]
		[Address(RVA = "0x4B7AD0", Offset = "0x4B64D0", VA = "0x1804B7AD0", Slot = "5")]
		public virtual bool IsIndoorTile()
		{
			return default(bool);
		}

		// Token: 0x06000F79 RID: 3961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F79")]
		[Address(RVA = "0xAC9D60", Offset = "0xAC8760", VA = "0x180AC9D60")]
		public void SetVisible(bool vis)
		{
		}

		// Token: 0x06000F7A RID: 3962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F7A")]
		[Address(RVA = "0xAC9E20", Offset = "0xAC8820", VA = "0x180AC9E20")]
		public Tile()
		{
		}

		// Token: 0x04000F70 RID: 3952
		[Token(Token = "0x4000F70")]
		[FieldOffset(Offset = "0x0")]
		public static float TileSize;

		// Token: 0x04000F71 RID: 3953
		[Token(Token = "0x4000F71")]
		[FieldOffset(Offset = "0x20")]
		public int x;

		// Token: 0x04000F72 RID: 3954
		[Token(Token = "0x4000F72")]
		[FieldOffset(Offset = "0x24")]
		public int y;

		// Token: 0x04000F73 RID: 3955
		[Token(Token = "0x4000F73")]
		[FieldOffset(Offset = "0x28")]
		[Header("Settings")]
		public float AvailableOffset;

		// Token: 0x04000F74 RID: 3956
		[Token(Token = "0x4000F74")]
		[FieldOffset(Offset = "0x30")]
		[Header("References")]
		public Grid OwnerGrid;

		// Token: 0x04000F75 RID: 3957
		[Token(Token = "0x4000F75")]
		[FieldOffset(Offset = "0x38")]
		public LightExposureNode LightExposureNode;

		// Token: 0x04000F76 RID: 3958
		[Token(Token = "0x4000F76")]
		[FieldOffset(Offset = "0x40")]
		[Header("Occupants")]
		public List<GridItem> BuildableOccupants;

		// Token: 0x04000F77 RID: 3959
		[Token(Token = "0x4000F77")]
		[FieldOffset(Offset = "0x48")]
		public List<Constructable_GridBased> ConstructableOccupants;

		// Token: 0x04000F78 RID: 3960
		[Token(Token = "0x4000F78")]
		[FieldOffset(Offset = "0x50")]
		public List<FootprintTile> OccupantTiles;

		// Token: 0x04000F79 RID: 3961
		[Token(Token = "0x4000F79")]
		[FieldOffset(Offset = "0x58")]
		public Tile.TileChange onTileChanged;

		// Token: 0x020002D1 RID: 721
		// (Invoke) Token: 0x06000F7D RID: 3965
		[Token(Token = "0x20002D1")]
		public delegate void TileChange(Tile thisTile);
	}
}
