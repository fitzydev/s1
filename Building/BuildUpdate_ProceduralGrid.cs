using System;
using Il2CppDummyDll;
using ScheduleOne.EntityFramework;
using ScheduleOne.ItemFramework;
using ScheduleOne.Tiles;
using UnityEngine;

namespace ScheduleOne.Building
{
	// Token: 0x0200082C RID: 2092
	[Token(Token = "0x200082C")]
	public class BuildUpdate_ProceduralGrid : BuildUpdate_Base
	{
		// Token: 0x06003978 RID: 14712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003978")]
		[Address(RVA = "0x7FF220", Offset = "0x7FDC20", VA = "0x1807FF220", Slot = "5")]
		protected virtual void Update()
		{
		}

		// Token: 0x06003979 RID: 14713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003979")]
		[Address(RVA = "0x7FE3A0", Offset = "0x7FCDA0", VA = "0x1807FE3A0", Slot = "6")]
		protected virtual void LateUpdate()
		{
		}

		// Token: 0x0600397A RID: 14714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600397A")]
		[Address(RVA = "0x7FDF30", Offset = "0x7FC930", VA = "0x1807FDF30")]
		protected void CheckRotation()
		{
		}

		// Token: 0x0600397B RID: 14715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600397B")]
		[Address(RVA = "0x7FD220", Offset = "0x7FBC20", VA = "0x1807FD220")]
		protected void ApplyRotation()
		{
		}

		// Token: 0x0600397C RID: 14716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600397C")]
		[Address(RVA = "0x7FD690", Offset = "0x7FC090", VA = "0x1807FD690", Slot = "7")]
		protected virtual void CheckGridIntersections()
		{
		}

		// Token: 0x0600397D RID: 14717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600397D")]
		[Address(RVA = "0x7FF090", Offset = "0x7FDA90", VA = "0x1807FF090")]
		protected void UpdateMaterials()
		{
		}

		// Token: 0x0600397E RID: 14718 RVA: 0x0000F5D0 File Offset: 0x0000D7D0
		[Token(Token = "0x600397E")]
		[Address(RVA = "0x7FE180", Offset = "0x7FCB80", VA = "0x1807FE180")]
		private bool IsMatchValid(FootprintTile footprintTile, ProceduralTile matchedTile)
		{
			return default(bool);
		}

		// Token: 0x0600397F RID: 14719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600397F")]
		[Address(RVA = "0x7FE8E0", Offset = "0x7FD2E0", VA = "0x1807FE8E0")]
		protected void Place()
		{
		}

		// Token: 0x06003980 RID: 14720 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003980")]
		[Address(RVA = "0x7FE020", Offset = "0x7FCA20", VA = "0x1807FE020")]
		private ProceduralTile GetNearbyProcTile()
		{
			return null;
		}

		// Token: 0x06003981 RID: 14721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003981")]
		[Address(RVA = "0x7FF360", Offset = "0x7FDD60", VA = "0x1807FF360")]
		public BuildUpdate_ProceduralGrid()
		{
		}

		// Token: 0x040027CC RID: 10188
		[Token(Token = "0x40027CC")]
		[FieldOffset(Offset = "0x20")]
		public GameObject GhostModel;

		// Token: 0x040027CD RID: 10189
		[Token(Token = "0x40027CD")]
		[FieldOffset(Offset = "0x28")]
		public ProceduralGridItem ItemClass;

		// Token: 0x040027CE RID: 10190
		[Token(Token = "0x40027CE")]
		[FieldOffset(Offset = "0x30")]
		public ItemInstance ItemInstance;

		// Token: 0x040027CF RID: 10191
		[Token(Token = "0x40027CF")]
		[FieldOffset(Offset = "0x38")]
		[Header("Settings")]
		public float detectionRange;

		// Token: 0x040027D0 RID: 10192
		[Token(Token = "0x40027D0")]
		[FieldOffset(Offset = "0x3C")]
		public LayerMask detectionMask;

		// Token: 0x040027D1 RID: 10193
		[Token(Token = "0x40027D1")]
		[FieldOffset(Offset = "0x40")]
		public float rotation_Smoothing;

		// Token: 0x040027D2 RID: 10194
		[Token(Token = "0x40027D2")]
		[FieldOffset(Offset = "0x44")]
		protected float currentRotation;

		// Token: 0x040027D3 RID: 10195
		[Token(Token = "0x40027D3")]
		[FieldOffset(Offset = "0x48")]
		protected bool validPosition;

		// Token: 0x040027D4 RID: 10196
		[Token(Token = "0x40027D4")]
		[FieldOffset(Offset = "0x50")]
		protected Material currentGhostMaterial;

		// Token: 0x040027D5 RID: 10197
		[Token(Token = "0x40027D5")]
		[FieldOffset(Offset = "0x58")]
		protected BuildUpdate_ProceduralGrid.Intersection bestIntersection;

		// Token: 0x0200082D RID: 2093
		[Token(Token = "0x200082D")]
		public class Intersection
		{
			// Token: 0x06003982 RID: 14722 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003982")]
			[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
			public Intersection()
			{
			}

			// Token: 0x040027D6 RID: 10198
			[Token(Token = "0x40027D6")]
			[FieldOffset(Offset = "0x10")]
			public FootprintTile footprintTile;

			// Token: 0x040027D7 RID: 10199
			[Token(Token = "0x40027D7")]
			[FieldOffset(Offset = "0x18")]
			public ProceduralTile procTile;
		}
	}
}
