using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.TV
{
	// Token: 0x020002B1 RID: 689
	[Token(Token = "0x20002B1")]
	public class SnakeTile : MonoBehaviour
	{
		// Token: 0x17000318 RID: 792
		// (get) Token: 0x06000E6C RID: 3692 RVA: 0x00007218 File Offset: 0x00005418
		// (set) Token: 0x06000E6D RID: 3693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000318")]
		public SnakeTile.TileType Type
		{
			[Token(Token = "0x6000E6C")]
			[Address(RVA = "0x47D5C0", Offset = "0x47BFC0", VA = "0x18047D5C0")]
			[CompilerGenerated]
			get
			{
				return SnakeTile.TileType.Empty;
			}
			[Token(Token = "0x6000E6D")]
			[Address(RVA = "0x47D790", Offset = "0x47C190", VA = "0x18047D790")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000E6E RID: 3694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E6E")]
		[Address(RVA = "0xAC49B0", Offset = "0xAC33B0", VA = "0x180AC49B0")]
		public void SetType(SnakeTile.TileType type, int index = 0)
		{
		}

		// Token: 0x06000E6F RID: 3695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E6F")]
		[Address(RVA = "0xAC4850", Offset = "0xAC3250", VA = "0x180AC4850")]
		public void SetPosition(Vector2 position, float tileSize)
		{
		}

		// Token: 0x06000E70 RID: 3696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E70")]
		[Address(RVA = "0xAC4B40", Offset = "0xAC3540", VA = "0x180AC4B40")]
		public SnakeTile()
		{
		}

		// Token: 0x04000EBA RID: 3770
		[Token(Token = "0x4000EBA")]
		[FieldOffset(Offset = "0x24")]
		public Vector2 Position;

		// Token: 0x04000EBB RID: 3771
		[Token(Token = "0x4000EBB")]
		[FieldOffset(Offset = "0x2C")]
		public Color SnakeColor;

		// Token: 0x04000EBC RID: 3772
		[Token(Token = "0x4000EBC")]
		[FieldOffset(Offset = "0x3C")]
		public Color FoodColor;

		// Token: 0x04000EBD RID: 3773
		[Token(Token = "0x4000EBD")]
		[FieldOffset(Offset = "0x50")]
		public RectTransform RectTransform;

		// Token: 0x04000EBE RID: 3774
		[Token(Token = "0x4000EBE")]
		[FieldOffset(Offset = "0x58")]
		public Image Image;

		// Token: 0x020002B2 RID: 690
		[Token(Token = "0x20002B2")]
		public enum TileType
		{
			// Token: 0x04000EC0 RID: 3776
			[Token(Token = "0x4000EC0")]
			Empty,
			// Token: 0x04000EC1 RID: 3777
			[Token(Token = "0x4000EC1")]
			Snake,
			// Token: 0x04000EC2 RID: 3778
			[Token(Token = "0x4000EC2")]
			Food
		}
	}
}
