using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using EasyButtons;
using Il2CppDummyDll;
using ScheduleOne.ConstructableScripts;
using ScheduleOne.EntityFramework;
using UnityEngine;

namespace ScheduleOne.Tiles
{
	// Token: 0x020002CC RID: 716
	[Token(Token = "0x20002CC")]
	public class Grid : MonoBehaviour, IGUIDRegisterable
	{
		// Token: 0x1700033D RID: 829
		// (get) Token: 0x06000F5B RID: 3931 RVA: 0x00007728 File Offset: 0x00005928
		// (set) Token: 0x06000F5C RID: 3932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700033D")]
		public Guid GUID
		{
			[Token(Token = "0x6000F5B")]
			[Address(RVA = "0x51F570", Offset = "0x51DF70", VA = "0x18051F570", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Token(Token = "0x6000F5C")]
			[Address(RVA = "0xABD110", Offset = "0xABBB10", VA = "0x180ABD110")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06000F5D RID: 3933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F5D")]
		[Address(RVA = "0xABCD10", Offset = "0xABB710", VA = "0x180ABCD10", Slot = "6")]
		public void SetGUID(Guid guid)
		{
		}

		// Token: 0x06000F5E RID: 3934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F5E")]
		[Address(RVA = "0x6FCBF0", Offset = "0x6FB5F0", VA = "0x1806FCBF0")]
		[Button]
		public void RegenerateGUID()
		{
		}

		// Token: 0x06000F5F RID: 3935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F5F")]
		[Address(RVA = "0xABBFD0", Offset = "0xABA9D0", VA = "0x180ABBFD0", Slot = "7")]
		protected virtual void Awake()
		{
		}

		// Token: 0x06000F60 RID: 3936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F60")]
		[Address(RVA = "0xABC440", Offset = "0xABAE40", VA = "0x180ABC440", Slot = "8")]
		public virtual void DestroyGrid()
		{
		}

		// Token: 0x06000F61 RID: 3937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F61")]
		[Address(RVA = "0xABCA10", Offset = "0xABB410", VA = "0x180ABCA10")]
		private void ProcessCoordinateDataPairs()
		{
		}

		// Token: 0x06000F62 RID: 3938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F62")]
		[Address(RVA = "0xABCB40", Offset = "0xABB540", VA = "0x180ABCB40")]
		public void RegisterTile(Tile tile)
		{
		}

		// Token: 0x06000F63 RID: 3939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F63")]
		[Address(RVA = "0xABC290", Offset = "0xABAC90", VA = "0x180ABC290")]
		public void DeregisterTile(Tile tile)
		{
		}

		// Token: 0x06000F64 RID: 3940 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F64")]
		[Address(RVA = "0xABC4F0", Offset = "0xABAEF0", VA = "0x180ABC4F0")]
		public Coordinate GetMatchedCoordinate(FootprintTile tileToMatch)
		{
			return null;
		}

		// Token: 0x06000F65 RID: 3941 RVA: 0x00007740 File Offset: 0x00005940
		[Token(Token = "0x6000F65")]
		[Address(RVA = "0xABC6D0", Offset = "0xABB0D0", VA = "0x180ABC6D0")]
		public bool IsTileValidAtCoordinate(Coordinate gridCoord, FootprintTile tile, [Optional] GridItem tileOwner)
		{
			return default(bool);
		}

		// Token: 0x06000F66 RID: 3942 RVA: 0x00007758 File Offset: 0x00005958
		[Token(Token = "0x6000F66")]
		[Address(RVA = "0xABC860", Offset = "0xABB260", VA = "0x180ABC860")]
		public bool IsTileValidAtCoordinate(Coordinate gridCoord, FootprintTile tile, Constructable_GridBased ignoreConstructable)
		{
			return default(bool);
		}

		// Token: 0x06000F67 RID: 3943 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F67")]
		[Address(RVA = "0xABC640", Offset = "0xABB040", VA = "0x180ABC640")]
		public Tile GetTile(Coordinate coord)
		{
			return null;
		}

		// Token: 0x06000F68 RID: 3944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F68")]
		[Address(RVA = "0xABCE80", Offset = "0xABB880", VA = "0x180ABCE80")]
		[Button]
		public void SetVisible()
		{
		}

		// Token: 0x06000F69 RID: 3945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F69")]
		[Address(RVA = "0xABCD70", Offset = "0xABB770", VA = "0x180ABCD70")]
		[Button]
		public void SetInvisible()
		{
		}

		// Token: 0x06000F6A RID: 3946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F6A")]
		[Address(RVA = "0xABCFD0", Offset = "0xABB9D0", VA = "0x180ABCFD0")]
		public Grid()
		{
		}

		// Token: 0x04000F61 RID: 3937
		[Token(Token = "0x4000F61")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static float GridSideLength;

		// Token: 0x04000F62 RID: 3938
		[Token(Token = "0x4000F62")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<Tile> Tiles;

		// Token: 0x04000F63 RID: 3939
		[Token(Token = "0x4000F63")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<CoordinateTilePair> CoordinateTilePairs;

		// Token: 0x04000F64 RID: 3940
		[Token(Token = "0x4000F64")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform Container;

		// Token: 0x04000F65 RID: 3941
		[Token(Token = "0x4000F65")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool IsStatic;

		// Token: 0x04000F66 RID: 3942
		[Token(Token = "0x4000F66")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string StaticGUID;

		// Token: 0x04000F68 RID: 3944
		[Token(Token = "0x4000F68")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		protected Dictionary<Coordinate, Tile> _coordinateToTile;
	}
}
