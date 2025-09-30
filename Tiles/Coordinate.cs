using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Tiles
{
	// Token: 0x020002C6 RID: 710
	[Token(Token = "0x20002C6")]
	[Serializable]
	public class Coordinate
	{
		// Token: 0x06000F45 RID: 3909 RVA: 0x00007680 File Offset: 0x00005880
		[Token(Token = "0x6000F45")]
		[Address(RVA = "0xABB690", Offset = "0xABA090", VA = "0x180ABB690")]
		public static implicit operator Vector2(Coordinate c)
		{
			return default(Vector2);
		}

		// Token: 0x06000F46 RID: 3910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F46")]
		[Address(RVA = "0xABB5A0", Offset = "0xAB9FA0", VA = "0x180ABB5A0")]
		public Coordinate()
		{
		}

		// Token: 0x06000F47 RID: 3911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F47")]
		[Address(RVA = "0x776EB0", Offset = "0x7758B0", VA = "0x180776EB0")]
		public Coordinate(int _x, int _y)
		{
		}

		// Token: 0x06000F48 RID: 3912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F48")]
		[Address(RVA = "0xABB5C0", Offset = "0xAB9FC0", VA = "0x180ABB5C0")]
		public Coordinate(Vector2 vector)
		{
		}

		// Token: 0x06000F49 RID: 3913 RVA: 0x00007698 File Offset: 0x00005898
		[Token(Token = "0x6000F49")]
		[Address(RVA = "0xABB120", Offset = "0xAB9B20", VA = "0x180ABB120", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000F4A RID: 3914 RVA: 0x000076B0 File Offset: 0x000058B0
		[Token(Token = "0x6000F4A")]
		[Address(RVA = "0xABB090", Offset = "0xAB9A90", VA = "0x180ABB090", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000F4B RID: 3915 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F4B")]
		[Address(RVA = "0xABB5F0", Offset = "0xAB9FF0", VA = "0x180ABB5F0")]
		public static Coordinate operator +(Coordinate a, Coordinate b)
		{
			return null;
		}

		// Token: 0x06000F4C RID: 3916 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F4C")]
		[Address(RVA = "0xABB6C0", Offset = "0xABA0C0", VA = "0x180ABB6C0")]
		public static Coordinate operator -(Coordinate a, Coordinate b)
		{
			return null;
		}

		// Token: 0x06000F4D RID: 3917 RVA: 0x000076C8 File Offset: 0x000058C8
		[Token(Token = "0x6000F4D")]
		[Address(RVA = "0xABB050", Offset = "0xAB9A50", VA = "0x180ABB050")]
		private int CantorPair(int x, int y)
		{
			return 0;
		}

		// Token: 0x06000F4E RID: 3918 RVA: 0x000076E0 File Offset: 0x000058E0
		[Token(Token = "0x6000F4E")]
		[Address(RVA = "0xABB3E0", Offset = "0xAB9DE0", VA = "0x180ABB3E0")]
		private int SignedCantorPair(int x, int y)
		{
			return 0;
		}

		// Token: 0x06000F4F RID: 3919 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F4F")]
		[Address(RVA = "0xABB480", Offset = "0xAB9E80", VA = "0x180ABB480", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000F50 RID: 3920 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F50")]
		[Address(RVA = "0xABAD40", Offset = "0xAB9740", VA = "0x180ABAD40")]
		public static List<CoordinatePair> BuildCoordinateMatches(Coordinate originCoord, int sizeX, int sizeY, float rot)
		{
			return null;
		}

		// Token: 0x06000F51 RID: 3921 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F51")]
		[Address(RVA = "0xABB230", Offset = "0xAB9C30", VA = "0x180ABB230")]
		public static Coordinate RotateCoordinates(Coordinate coord, float angle)
		{
			return null;
		}

		// Token: 0x06000F52 RID: 3922 RVA: 0x000076F8 File Offset: 0x000058F8
		[Token(Token = "0x6000F52")]
		[Address(RVA = "0xABB1D0", Offset = "0xAB9BD0", VA = "0x180ABB1D0")]
		private static int MathMod(int a, int b)
		{
			return 0;
		}

		// Token: 0x04000F4F RID: 3919
		[Token(Token = "0x4000F4F")]
		[FieldOffset(Offset = "0x10")]
		public int x;

		// Token: 0x04000F50 RID: 3920
		[Token(Token = "0x4000F50")]
		[FieldOffset(Offset = "0x14")]
		public int y;
	}
}
