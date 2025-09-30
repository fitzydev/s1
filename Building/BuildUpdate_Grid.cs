using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.EntityFramework;
using ScheduleOne.ItemFramework;
using ScheduleOne.Tiles;
using UnityEngine;

namespace ScheduleOne.Building
{
	// Token: 0x0200082B RID: 2091
	[Token(Token = "0x200082B")]
	public class BuildUpdate_Grid : BuildUpdate_Base
	{
		// Token: 0x0600396B RID: 14699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600396B")]
		[Address(RVA = "0x7FCA80", Offset = "0x7FB480", VA = "0x1807FCA80", Slot = "5")]
		protected virtual void Start()
		{
		}

		// Token: 0x0600396C RID: 14700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600396C")]
		[Address(RVA = "0x7FD0A0", Offset = "0x7FBAA0", VA = "0x1807FD0A0", Slot = "6")]
		protected virtual void Update()
		{
		}

		// Token: 0x0600396D RID: 14701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600396D")]
		[Address(RVA = "0x7FAFB0", Offset = "0x7F99B0", VA = "0x1807FAFB0", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		// Token: 0x0600396E RID: 14702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600396E")]
		[Address(RVA = "0x7FC440", Offset = "0x7FAE40", VA = "0x1807FC440")]
		protected void PositionObjectInFrontOfPlayer(float dist, bool sanitizeForward, bool buildPointAsOrigin)
		{
		}

		// Token: 0x0600396F RID: 14703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600396F")]
		[Address(RVA = "0x7FAA20", Offset = "0x7F9420", VA = "0x1807FAA20")]
		protected void CheckRotation()
		{
		}

		// Token: 0x06003970 RID: 14704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003970")]
		[Address(RVA = "0x7F97A0", Offset = "0x7F81A0", VA = "0x1807F97A0")]
		protected void ApplyRotation()
		{
		}

		// Token: 0x06003971 RID: 14705 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003971")]
		[Address(RVA = "0x7FAD60", Offset = "0x7F9760", VA = "0x1807FAD60")]
		private List<TileIntersection> GetRelevantIntersections(FootprintTile tile)
		{
			return null;
		}

		// Token: 0x06003972 RID: 14706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003972")]
		[Address(RVA = "0x7F9C30", Offset = "0x7F8630", VA = "0x1807F9C30", Slot = "8")]
		protected virtual void CheckIntersections()
		{
		}

		// Token: 0x06003973 RID: 14707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003973")]
		[Address(RVA = "0x7FCF10", Offset = "0x7FB910", VA = "0x1807FCF10")]
		protected void UpdateMaterials()
		{
		}

		// Token: 0x06003974 RID: 14708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003974")]
		[Address(RVA = "0x7FBEA0", Offset = "0x7FA8A0", VA = "0x1807FBEA0", Slot = "9")]
		protected virtual void Place()
		{
		}

		// Token: 0x06003975 RID: 14709 RVA: 0x0000F5B8 File Offset: 0x0000D7B8
		[Token(Token = "0x6003975")]
		[Address(RVA = "0x7FAC90", Offset = "0x7F9690", VA = "0x1807FAC90")]
		private Vector2 GetOriginCoordinate()
		{
			return default(Vector2);
		}

		// Token: 0x06003976 RID: 14710 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003976")]
		[Address(RVA = "0x7FAB30", Offset = "0x7F9530", VA = "0x1807FAB30")]
		private Grid GetHoveredGrid()
		{
			return null;
		}

		// Token: 0x06003977 RID: 14711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003977")]
		[Address(RVA = "0x7FD200", Offset = "0x7FBC00", VA = "0x1807FD200")]
		public BuildUpdate_Grid()
		{
		}

		// Token: 0x040027C0 RID: 10176
		[Token(Token = "0x40027C0")]
		[FieldOffset(Offset = "0x20")]
		public GameObject GhostModel;

		// Token: 0x040027C1 RID: 10177
		[Token(Token = "0x40027C1")]
		[FieldOffset(Offset = "0x28")]
		public GridItem BuildableItemClass;

		// Token: 0x040027C2 RID: 10178
		[Token(Token = "0x40027C2")]
		[FieldOffset(Offset = "0x30")]
		public ItemInstance ItemInstance;

		// Token: 0x040027C3 RID: 10179
		[Token(Token = "0x40027C3")]
		[FieldOffset(Offset = "0x38")]
		public float CurrentRotation;

		// Token: 0x040027C4 RID: 10180
		[Token(Token = "0x40027C4")]
		[FieldOffset(Offset = "0x3C")]
		[Header("Settings")]
		public float detectionRange;

		// Token: 0x040027C5 RID: 10181
		[Token(Token = "0x40027C5")]
		[FieldOffset(Offset = "0x40")]
		public LayerMask detectionMask;

		// Token: 0x040027C6 RID: 10182
		[Token(Token = "0x40027C6")]
		[FieldOffset(Offset = "0x44")]
		public float rotation_Smoothing;

		// Token: 0x040027C7 RID: 10183
		[Token(Token = "0x40027C7")]
		[FieldOffset(Offset = "0x48")]
		public bool AllowRotation;

		// Token: 0x040027C8 RID: 10184
		[Token(Token = "0x40027C8")]
		[FieldOffset(Offset = "0x49")]
		protected bool validPosition;

		// Token: 0x040027C9 RID: 10185
		[Token(Token = "0x40027C9")]
		[FieldOffset(Offset = "0x50")]
		protected Material currentGhostMaterial;

		// Token: 0x040027CA RID: 10186
		[Token(Token = "0x40027CA")]
		[FieldOffset(Offset = "0x58")]
		protected TileIntersection closestIntersection;

		// Token: 0x040027CB RID: 10187
		[Token(Token = "0x40027CB")]
		[FieldOffset(Offset = "0x60")]
		private float verticalOffset;
	}
}
