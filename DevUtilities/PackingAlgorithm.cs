using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;

namespace ScheduleOne.DevUtilities
{
	// Token: 0x0200075E RID: 1886
	[Token(Token = "0x200075E")]
	public class PackingAlgorithm : Singleton<PackingAlgorithm>
	{
		// Token: 0x06003330 RID: 13104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003330")]
		[Address(RVA = "0x786E30", Offset = "0x785830", VA = "0x180786E30")]
		public List<PackingAlgorithm.StoredItemData> PackItems(List<ItemInstance> datas, int gridX, int gridY)
		{
			return null;
		}

		// Token: 0x06003331 RID: 13105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003331")]
		[Address(RVA = "0x785C20", Offset = "0x784620", VA = "0x180785C20")]
		public List<PackingAlgorithm.StoredItemData> AttemptPack(List<PackingAlgorithm.StoredItemData> rects, int gridX, int gridY)
		{
			return null;
		}

		// Token: 0x06003332 RID: 13106 RVA: 0x0000E178 File Offset: 0x0000C378
		[Token(Token = "0x6003332")]
		[Address(RVA = "0x786AC0", Offset = "0x7854C0", VA = "0x180786AC0")]
		private bool DoesCoordinateHaveOccupiedAdjacent(PackingAlgorithm.Coordinate[,] grid, PackingAlgorithm.Coordinate coord, int gridX, int gridY)
		{
			return default(bool);
		}

		// Token: 0x06003333 RID: 13107 RVA: 0x0000E190 File Offset: 0x0000C390
		[Token(Token = "0x6003333")]
		[Address(RVA = "0x786DF0", Offset = "0x7857F0", VA = "0x180786DF0")]
		private bool IsCoordinateInBounds(PackingAlgorithm.Coordinate coord, int gridX, int gridY)
		{
			return default(bool);
		}

		// Token: 0x06003334 RID: 13108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003334")]
		[Address(RVA = "0x787080", Offset = "0x785A80", VA = "0x180787080")]
		private void PrintGrid(PackingAlgorithm.Coordinate[,] grid, int gridX, int gridY)
		{
		}

		// Token: 0x06003335 RID: 13109 RVA: 0x0000E1A8 File Offset: 0x0000C3A8
		[Token(Token = "0x6003335")]
		[Address(RVA = "0x786D30", Offset = "0x785730", VA = "0x180786D30")]
		private int GetRegionSize(PackingAlgorithm.Coordinate[,] grid, int gridX, int gridY)
		{
			return 0;
		}

		// Token: 0x06003336 RID: 13110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003336")]
		[Address(RVA = "0x787230", Offset = "0x785C30", VA = "0x180787230")]
		private PackingAlgorithm.Coordinate TransformCoordinatePoint(PackingAlgorithm.Coordinate[,] grid, PackingAlgorithm.Coordinate baseCoordinate, PackingAlgorithm.Coordinate offset, int gridX, int gridY)
		{
			return null;
		}

		// Token: 0x06003337 RID: 13111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003337")]
		[Address(RVA = "0x787350", Offset = "0x785D50", VA = "0x180787350")]
		public PackingAlgorithm()
		{
		}

		// Token: 0x04002381 RID: 9089
		[Token(Token = "0x4002381")]
		[FieldOffset(Offset = "0x28")]
		public List<PackingAlgorithm.Rectangle> rectsToPack;

		// Token: 0x0200075F RID: 1887
		[Token(Token = "0x200075F")]
		[Serializable]
		public class Rectangle
		{
			// Token: 0x17000770 RID: 1904
			// (get) Token: 0x06003338 RID: 13112 RVA: 0x0000E1C0 File Offset: 0x0000C3C0
			[Token(Token = "0x17000770")]
			public int actualSizeX
			{
				[Token(Token = "0x6003338")]
				[Address(RVA = "0x789BF0", Offset = "0x7885F0", VA = "0x180789BF0")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000771 RID: 1905
			// (get) Token: 0x06003339 RID: 13113 RVA: 0x0000E1D8 File Offset: 0x0000C3D8
			[Token(Token = "0x17000771")]
			public int actualSizeY
			{
				[Token(Token = "0x6003339")]
				[Address(RVA = "0x789C00", Offset = "0x788600", VA = "0x180789C00")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0600333A RID: 13114 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600333A")]
			[Address(RVA = "0x789B90", Offset = "0x788590", VA = "0x180789B90")]
			public Rectangle(string _name, int x, int y)
			{
			}

			// Token: 0x04002382 RID: 9090
			[Token(Token = "0x4002382")]
			[FieldOffset(Offset = "0x10")]
			public string name;

			// Token: 0x04002383 RID: 9091
			[Token(Token = "0x4002383")]
			[FieldOffset(Offset = "0x18")]
			public int sizeX;

			// Token: 0x04002384 RID: 9092
			[Token(Token = "0x4002384")]
			[FieldOffset(Offset = "0x1C")]
			public int sizeY;

			// Token: 0x04002385 RID: 9093
			[Token(Token = "0x4002385")]
			[FieldOffset(Offset = "0x20")]
			public bool flipped;
		}

		// Token: 0x02000760 RID: 1888
		[Token(Token = "0x2000760")]
		public class StoredItemData : PackingAlgorithm.Rectangle
		{
			// Token: 0x17000772 RID: 1906
			// (get) Token: 0x0600333B RID: 13115 RVA: 0x0000E1F0 File Offset: 0x0000C3F0
			[Token(Token = "0x17000772")]
			public float rotation
			{
				[Token(Token = "0x600333B")]
				[Address(RVA = "0x78BEB0", Offset = "0x78A8B0", VA = "0x18078BEB0")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x0600333C RID: 13116 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600333C")]
			[Address(RVA = "0x78BE40", Offset = "0x78A840", VA = "0x18078BE40")]
			public StoredItemData(string _name, int x, int y, ItemInstance _item)
			{
			}

			// Token: 0x04002386 RID: 9094
			[Token(Token = "0x4002386")]
			[FieldOffset(Offset = "0x28")]
			public ItemInstance item;

			// Token: 0x04002387 RID: 9095
			[Token(Token = "0x4002387")]
			[FieldOffset(Offset = "0x30")]
			public int xPos;

			// Token: 0x04002388 RID: 9096
			[Token(Token = "0x4002388")]
			[FieldOffset(Offset = "0x34")]
			public int yPos;
		}

		// Token: 0x02000761 RID: 1889
		[Token(Token = "0x2000761")]
		public class Coordinate
		{
			// Token: 0x0600333D RID: 13117 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600333D")]
			[Address(RVA = "0x776EB0", Offset = "0x7758B0", VA = "0x180776EB0")]
			public Coordinate(int _x, int _y)
			{
			}

			// Token: 0x04002389 RID: 9097
			[Token(Token = "0x4002389")]
			[FieldOffset(Offset = "0x10")]
			public int x;

			// Token: 0x0400238A RID: 9098
			[Token(Token = "0x400238A")]
			[FieldOffset(Offset = "0x14")]
			public int y;

			// Token: 0x0400238B RID: 9099
			[Token(Token = "0x400238B")]
			[FieldOffset(Offset = "0x18")]
			public PackingAlgorithm.Rectangle occupant;
		}
	}
}
