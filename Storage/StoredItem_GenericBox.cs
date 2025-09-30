using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Storage
{
	// Token: 0x02000960 RID: 2400
	[Token(Token = "0x2000960")]
	public class StoredItem_GenericBox : StoredItem
	{
		// Token: 0x060041EA RID: 16874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60041EA")]
		[Address(RVA = "0x88FFB0", Offset = "0x88E9B0", VA = "0x18088FFB0", Slot = "6")]
		public override void InitializeStoredItem(StorableItemInstance _item, StorageGrid grid, Vector2 _originCoordinate, float _rotation)
		{
		}

		// Token: 0x060041EB RID: 16875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60041EB")]
		[Address(RVA = "0x8901E0", Offset = "0x88EBE0", VA = "0x1808901E0")]
		public StoredItem_GenericBox()
		{
		}

		// Token: 0x04002E21 RID: 11809
		[Token(Token = "0x4002E21")]
		private const float ReferenceIconWidth = 1024f;

		// Token: 0x04002E22 RID: 11810
		[Token(Token = "0x4002E22")]
		[FieldOffset(Offset = "0x80")]
		[Header("References")]
		[SerializeField]
		protected SpriteRenderer icon1;

		// Token: 0x04002E23 RID: 11811
		[Token(Token = "0x4002E23")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		protected SpriteRenderer icon2;

		// Token: 0x04002E24 RID: 11812
		[Token(Token = "0x4002E24")]
		[FieldOffset(Offset = "0x90")]
		[Header("Settings")]
		public float IconScale;
	}
}
