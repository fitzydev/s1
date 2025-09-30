using System;
using Il2CppDummyDll;
using ScheduleOne.Storage;
using ScheduleOne.Tiles;
using UnityEngine;

namespace ScheduleOne.Building
{
	// Token: 0x0200082E RID: 2094
	[Token(Token = "0x200082E")]
	public class BuildUpdate_StoredItem : BuildUpdate_Base
	{
		// Token: 0x06003983 RID: 14723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003983")]
		[Address(RVA = "0x8013A0", Offset = "0x7FFDA0", VA = "0x1808013A0", Slot = "5")]
		protected virtual void Update()
		{
		}

		// Token: 0x06003984 RID: 14724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003984")]
		[Address(RVA = "0x8005A0", Offset = "0x7FEFA0", VA = "0x1808005A0", Slot = "6")]
		protected virtual void LateUpdate()
		{
		}

		// Token: 0x06003985 RID: 14725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003985")]
		[Address(RVA = "0x8003F0", Offset = "0x7FEDF0", VA = "0x1808003F0")]
		protected void CheckRotation()
		{
		}

		// Token: 0x06003986 RID: 14726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003986")]
		[Address(RVA = "0x7FF380", Offset = "0x7FDD80", VA = "0x1807FF380")]
		protected void ApplyRotation()
		{
		}

		// Token: 0x06003987 RID: 14727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003987")]
		[Address(RVA = "0x7FF610", Offset = "0x7FE010", VA = "0x1807FF610", Slot = "7")]
		protected virtual void CheckGridIntersections()
		{
		}

		// Token: 0x06003988 RID: 14728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003988")]
		[Address(RVA = "0x801210", Offset = "0x7FFC10", VA = "0x180801210")]
		protected void UpdateMaterials()
		{
		}

		// Token: 0x06003989 RID: 14729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003989")]
		[Address(RVA = "0x800E30", Offset = "0x7FF830", VA = "0x180800E30", Slot = "8")]
		protected virtual void Place()
		{
		}

		// Token: 0x0600398A RID: 14730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600398A")]
		[Address(RVA = "0x801180", Offset = "0x7FFB80", VA = "0x180801180", Slot = "9")]
		protected virtual void PostPlace()
		{
		}

		// Token: 0x0600398B RID: 14731 RVA: 0x0000F5E8 File Offset: 0x0000D7E8
		[Token(Token = "0x600398B")]
		[Address(RVA = "0x800490", Offset = "0x7FEE90", VA = "0x180800490")]
		protected Vector2 GetOriginCoordinate()
		{
			return default(Vector2);
		}

		// Token: 0x0600398C RID: 14732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600398C")]
		[Address(RVA = "0x8014D0", Offset = "0x7FFED0", VA = "0x1808014D0")]
		public BuildUpdate_StoredItem()
		{
		}

		// Token: 0x040027D8 RID: 10200
		[Token(Token = "0x40027D8")]
		[FieldOffset(Offset = "0x20")]
		public StorableItemInstance itemInstance;

		// Token: 0x040027D9 RID: 10201
		[Token(Token = "0x40027D9")]
		[FieldOffset(Offset = "0x28")]
		public GameObject ghostModel;

		// Token: 0x040027DA RID: 10202
		[Token(Token = "0x40027DA")]
		[FieldOffset(Offset = "0x30")]
		public StoredItem storedItemClass;

		// Token: 0x040027DB RID: 10203
		[Token(Token = "0x40027DB")]
		[FieldOffset(Offset = "0x38")]
		protected BuildUpdate_StoredItem.StorageTileIntersection bestIntersection;

		// Token: 0x040027DC RID: 10204
		[Token(Token = "0x40027DC")]
		[FieldOffset(Offset = "0x40")]
		[Header("Settings")]
		public float detectionRange;

		// Token: 0x040027DD RID: 10205
		[Token(Token = "0x40027DD")]
		[FieldOffset(Offset = "0x44")]
		public LayerMask detectionMask;

		// Token: 0x040027DE RID: 10206
		[Token(Token = "0x40027DE")]
		[FieldOffset(Offset = "0x48")]
		public float storedItemHoldDistance;

		// Token: 0x040027DF RID: 10207
		[Token(Token = "0x40027DF")]
		[FieldOffset(Offset = "0x4C")]
		public float currentRotation;

		// Token: 0x040027E0 RID: 10208
		[Token(Token = "0x40027E0")]
		[FieldOffset(Offset = "0x50")]
		protected bool validPosition;

		// Token: 0x040027E1 RID: 10209
		[Token(Token = "0x40027E1")]
		[FieldOffset(Offset = "0x58")]
		protected Material currentGhostMaterial;

		// Token: 0x040027E2 RID: 10210
		[Token(Token = "0x40027E2")]
		[FieldOffset(Offset = "0x60")]
		protected bool mouseUpSinceStart;

		// Token: 0x040027E3 RID: 10211
		[Token(Token = "0x40027E3")]
		[FieldOffset(Offset = "0x61")]
		protected bool mouseUpSincePlace;

		// Token: 0x040027E4 RID: 10212
		[Token(Token = "0x40027E4")]
		[FieldOffset(Offset = "0x64")]
		private Vector3 positionDuringLastValidPosition;

		// Token: 0x0200082F RID: 2095
		[Token(Token = "0x200082F")]
		public class StorageTileIntersection
		{
			// Token: 0x0600398D RID: 14733 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600398D")]
			[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
			public StorageTileIntersection()
			{
			}

			// Token: 0x040027E5 RID: 10213
			[Token(Token = "0x40027E5")]
			[FieldOffset(Offset = "0x10")]
			public FootprintTile footprintTile;

			// Token: 0x040027E6 RID: 10214
			[Token(Token = "0x40027E6")]
			[FieldOffset(Offset = "0x18")]
			public StorageTile storageTile;
		}
	}
}
