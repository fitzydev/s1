using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.Tiles;
using UnityEngine;

namespace ScheduleOne.Storage
{
	// Token: 0x02000956 RID: 2390
	[Token(Token = "0x2000956")]
	public class StorageGrid : MonoBehaviour
	{
		// Token: 0x0600418A RID: 16778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600418A")]
		[Address(RVA = "0x88C4C0", Offset = "0x88AEC0", VA = "0x18088C4C0", Slot = "4")]
		protected virtual void Awake()
		{
		}

		// Token: 0x0600418B RID: 16779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600418B")]
		[Address(RVA = "0x88CE30", Offset = "0x88B830", VA = "0x18088CE30")]
		private void ProcessCoordinateTilePairs()
		{
		}

		// Token: 0x0600418C RID: 16780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600418C")]
		[Address(RVA = "0x88CF60", Offset = "0x88B960", VA = "0x18088CF60")]
		public void RegisterTile(StorageTile tile)
		{
		}

		// Token: 0x0600418D RID: 16781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600418D")]
		[Address(RVA = "0x88C520", Offset = "0x88AF20", VA = "0x18088C520")]
		public void DeregisterTile(StorageTile tile)
		{
		}

		// Token: 0x0600418E RID: 16782 RVA: 0x00011340 File Offset: 0x0000F540
		[Token(Token = "0x600418E")]
		[Address(RVA = "0x88CB10", Offset = "0x88B510", VA = "0x18088CB10")]
		public bool IsItemPositionValid(StorageTile primaryTile, FootprintTile primaryFootprintTile, StoredItem item)
		{
			return default(bool);
		}

		// Token: 0x0600418F RID: 16783 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600418F")]
		[Address(RVA = "0x88C750", Offset = "0x88B150", VA = "0x18088C750")]
		public Coordinate GetMatchedCoordinate(FootprintTile tileToMatch)
		{
			return null;
		}

		// Token: 0x06004190 RID: 16784 RVA: 0x00011358 File Offset: 0x0000F558
		[Token(Token = "0x6004190")]
		[Address(RVA = "0x88CA40", Offset = "0x88B440", VA = "0x18088CA40")]
		public bool IsGridPositionValid(Coordinate gridCoord, FootprintTile tile)
		{
			return default(bool);
		}

		// Token: 0x06004191 RID: 16785 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004191")]
		[Address(RVA = "0x88C8A0", Offset = "0x88B2A0", VA = "0x18088C8A0")]
		public StorageTile GetTile(Coordinate coord)
		{
			return null;
		}

		// Token: 0x06004192 RID: 16786 RVA: 0x00011370 File Offset: 0x0000F570
		[Token(Token = "0x6004192")]
		[Address(RVA = "0x88C9E0", Offset = "0x88B3E0", VA = "0x18088C9E0")]
		public int GetUserEndCapacity()
		{
			return 0;
		}

		// Token: 0x06004193 RID: 16787 RVA: 0x00011388 File Offset: 0x0000F588
		[Token(Token = "0x6004193")]
		[Address(RVA = "0x88C6A0", Offset = "0x88B0A0", VA = "0x18088C6A0")]
		public int GetActualY()
		{
			return 0;
		}

		// Token: 0x06004194 RID: 16788 RVA: 0x000113A0 File Offset: 0x0000F5A0
		[Token(Token = "0x6004194")]
		[Address(RVA = "0x88C640", Offset = "0x88B040", VA = "0x18088C640")]
		public int GetActualX()
		{
			return 0;
		}

		// Token: 0x06004195 RID: 16789 RVA: 0x000113B8 File Offset: 0x0000F5B8
		[Token(Token = "0x6004195")]
		[Address(RVA = "0x88C9A0", Offset = "0x88B3A0", VA = "0x18088C9A0")]
		public int GetTotalFootprintSize()
		{
			return 0;
		}

		// Token: 0x06004196 RID: 16790 RVA: 0x000113D0 File Offset: 0x0000F5D0
		[Token(Token = "0x6004196")]
		[Address(RVA = "0x88D130", Offset = "0x88BB30", VA = "0x18088D130")]
		public bool TryFitItem(int sizeX, int sizeY, List<Coordinate> lockedCoordinates, out Coordinate originCoordinate, out float rotation)
		{
			return default(bool);
		}

		// Token: 0x06004197 RID: 16791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004197")]
		[Address(RVA = "0x88D680", Offset = "0x88C080", VA = "0x18088D680")]
		public StorageGrid()
		{
		}

		// Token: 0x04002DF2 RID: 11762
		[Token(Token = "0x4002DF2")]
		[FieldOffset(Offset = "0x0")]
		public static float gridSize;

		// Token: 0x04002DF3 RID: 11763
		[Token(Token = "0x4002DF3")]
		[FieldOffset(Offset = "0x20")]
		public List<StorageTile> storageTiles;

		// Token: 0x04002DF4 RID: 11764
		[Token(Token = "0x4002DF4")]
		[FieldOffset(Offset = "0x28")]
		public List<StorageTile> freeTiles;

		// Token: 0x04002DF5 RID: 11765
		[Token(Token = "0x4002DF5")]
		[FieldOffset(Offset = "0x30")]
		public List<CoordinateStorageTilePair> coordinateStorageTilePairs;

		// Token: 0x04002DF6 RID: 11766
		[Token(Token = "0x4002DF6")]
		[FieldOffset(Offset = "0x38")]
		protected Dictionary<Coordinate, StorageTile> coordinateToTile;
	}
}
