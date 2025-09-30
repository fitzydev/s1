using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Building;
using UnityEngine;

namespace ScheduleOne.Tiles
{
	// Token: 0x020002CB RID: 715
	[Token(Token = "0x20002CB")]
	public class FootprintTile : MonoBehaviour
	{
		// Token: 0x1700033C RID: 828
		// (get) Token: 0x06000F55 RID: 3925 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000F56 RID: 3926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700033C")]
		public Tile MatchedStandardTile
		{
			[Token(Token = "0x6000F55")]
			[Address(RVA = "0x47D5A0", Offset = "0x47BFA0", VA = "0x18047D5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000F56")]
			[Address(RVA = "0x5CDA00", Offset = "0x5CC400", VA = "0x1805CDA00")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06000F57 RID: 3927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F57")]
		[Address(RVA = "0xABBBD0", Offset = "0xABA5D0", VA = "0x180ABBBD0", Slot = "4")]
		protected virtual void Awake()
		{
		}

		// Token: 0x06000F58 RID: 3928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F58")]
		[Address(RVA = "0x5CDA00", Offset = "0x5CC400", VA = "0x1805CDA00", Slot = "5")]
		public virtual void Initialize(Tile matchedTile)
		{
		}

		// Token: 0x06000F59 RID: 3929 RVA: 0x00007710 File Offset: 0x00005910
		[Token(Token = "0x6000F59")]
		[Address(RVA = "0xABB760", Offset = "0xABA160", VA = "0x180ABB760")]
		public bool AreCornerObstaclesBlocked(Tile proposedTile)
		{
			return default(bool);
		}

		// Token: 0x06000F5A RID: 3930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F5A")]
		[Address(RVA = "0xABBC00", Offset = "0xABA600", VA = "0x180ABBC00")]
		public FootprintTile()
		{
		}

		// Token: 0x04000F5A RID: 3930
		[Token(Token = "0x4000F5A")]
		[FieldOffset(Offset = "0x20")]
		public TileAppearance tileAppearance;

		// Token: 0x04000F5B RID: 3931
		[Token(Token = "0x4000F5B")]
		[FieldOffset(Offset = "0x28")]
		public TileDetector tileDetector;

		// Token: 0x04000F5C RID: 3932
		[Token(Token = "0x4000F5C")]
		[FieldOffset(Offset = "0x30")]
		public int X;

		// Token: 0x04000F5D RID: 3933
		[Token(Token = "0x4000F5D")]
		[FieldOffset(Offset = "0x34")]
		public int Y;

		// Token: 0x04000F5E RID: 3934
		[Token(Token = "0x4000F5E")]
		[FieldOffset(Offset = "0x38")]
		public float RequiredOffset;

		// Token: 0x04000F5F RID: 3935
		[Token(Token = "0x4000F5F")]
		[FieldOffset(Offset = "0x40")]
		public List<CornerObstacle> Corners;
	}
}
