using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.Storage;
using UnityEngine;

namespace ScheduleOne.Tiles
{
	// Token: 0x020002D5 RID: 725
	[Token(Token = "0x20002D5")]
	public class TileDetector : MonoBehaviour
	{
		// Token: 0x06000F84 RID: 3972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F84")]
		[Address(RVA = "0xAC8830", Offset = "0xAC7230", VA = "0x180AC8830", Slot = "4")]
		public virtual void CheckIntersections(bool sort = true)
		{
		}

		// Token: 0x06000F85 RID: 3973 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F85")]
		public List<T> OrderList<T>(List<T> list) where T : MonoBehaviour
		{
			return null;
		}

		// Token: 0x06000F86 RID: 3974 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F86")]
		[Address(RVA = "0xAC91D0", Offset = "0xAC7BD0", VA = "0x180AC91D0")]
		public Tile GetClosestTile()
		{
			return null;
		}

		// Token: 0x06000F87 RID: 3975 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F87")]
		[Address(RVA = "0xAC8EF0", Offset = "0xAC78F0", VA = "0x180AC8EF0")]
		public ProceduralTile GetClosestProceduralTile()
		{
			return null;
		}

		// Token: 0x06000F88 RID: 3976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F88")]
		[Address(RVA = "0xAC94B0", Offset = "0xAC7EB0", VA = "0x180AC94B0")]
		public TileDetector()
		{
		}

		// Token: 0x04000F88 RID: 3976
		[Token(Token = "0x4000F88")]
		[FieldOffset(Offset = "0x20")]
		public float detectionRadius;

		// Token: 0x04000F89 RID: 3977
		[Token(Token = "0x4000F89")]
		[FieldOffset(Offset = "0x24")]
		public ETileDetectionMode tileDetectionMode;

		// Token: 0x04000F8A RID: 3978
		[Token(Token = "0x4000F8A")]
		[FieldOffset(Offset = "0x28")]
		public List<Tile> intersectedTiles;

		// Token: 0x04000F8B RID: 3979
		[Token(Token = "0x4000F8B")]
		[FieldOffset(Offset = "0x30")]
		public List<Tile> intersectedOutdoorTiles;

		// Token: 0x04000F8C RID: 3980
		[Token(Token = "0x4000F8C")]
		[FieldOffset(Offset = "0x38")]
		public List<Tile> intersectedIndoorTiles;

		// Token: 0x04000F8D RID: 3981
		[Token(Token = "0x4000F8D")]
		[FieldOffset(Offset = "0x40")]
		public List<StorageTile> intersectedStorageTiles;

		// Token: 0x04000F8E RID: 3982
		[Token(Token = "0x4000F8E")]
		[FieldOffset(Offset = "0x48")]
		public List<ProceduralTile> intersectedProceduralTiles;
	}
}
