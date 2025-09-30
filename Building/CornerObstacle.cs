using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.Tiles;
using UnityEngine;

namespace ScheduleOne.Building
{
	// Token: 0x02000831 RID: 2097
	[Token(Token = "0x2000831")]
	public class CornerObstacle : MonoBehaviour
	{
		// Token: 0x06003998 RID: 14744 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003998")]
		[Address(RVA = "0x808CE0", Offset = "0x8076E0", VA = "0x180808CE0")]
		public List<Tile> GetNeighbourTiles(Tile pairedTile)
		{
			return null;
		}

		// Token: 0x06003999 RID: 14745 RVA: 0x0000F630 File Offset: 0x0000D830
		[Token(Token = "0x6003999")]
		[Address(RVA = "0x808CC0", Offset = "0x8076C0", VA = "0x180808CC0")]
		private bool ApproxEquals(float a, float b, float precision)
		{
			return default(bool);
		}

		// Token: 0x0600399A RID: 14746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600399A")]
		[Address(RVA = "0x808FC0", Offset = "0x8079C0", VA = "0x180808FC0")]
		public CornerObstacle()
		{
		}

		// Token: 0x040027EF RID: 10223
		[Token(Token = "0x40027EF")]
		[FieldOffset(Offset = "0x20")]
		public bool obstacleEnabled;

		// Token: 0x040027F0 RID: 10224
		[Token(Token = "0x40027F0")]
		[FieldOffset(Offset = "0x28")]
		public FootprintTile parentFootprint;

		// Token: 0x040027F1 RID: 10225
		[Token(Token = "0x40027F1")]
		[FieldOffset(Offset = "0x30")]
		public Vector2 coordinates;
	}
}
