using System;
using Il2CppDummyDll;
using ScheduleOne.ConstructableScripts;
using UnityEngine;

namespace ScheduleOne.Construction.ConstructionMethods
{
	// Token: 0x020007A4 RID: 1956
	[Token(Token = "0x20007A4")]
	public class ConstructUpdate_OutdoorGrid : ConstructUpdate_Base
	{
		// Token: 0x060034B6 RID: 13494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034B6")]
		[Address(RVA = "0x799CB0", Offset = "0x7986B0", VA = "0x180799CB0", Slot = "7")]
		protected virtual void Start()
		{
		}

		// Token: 0x060034B7 RID: 13495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034B7")]
		[Address(RVA = "0x799FC0", Offset = "0x7989C0", VA = "0x180799FC0", Slot = "4")]
		protected override void Update()
		{
		}

		// Token: 0x060034B8 RID: 13496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034B8")]
		[Address(RVA = "0x799640", Offset = "0x798040", VA = "0x180799640", Slot = "5")]
		protected override void LateUpdate()
		{
		}

		// Token: 0x060034B9 RID: 13497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034B9")]
		[Address(RVA = "0x7988A0", Offset = "0x7972A0", VA = "0x1807988A0")]
		protected void CheckRotation()
		{
		}

		// Token: 0x060034BA RID: 13498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034BA")]
		[Address(RVA = "0x798510", Offset = "0x796F10", VA = "0x180798510")]
		protected void ApplyRotation()
		{
		}

		// Token: 0x060034BB RID: 13499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034BB")]
		[Address(RVA = "0x798940", Offset = "0x797340", VA = "0x180798940", Slot = "8")]
		protected virtual void CheckTileIntersections()
		{
		}

		// Token: 0x060034BC RID: 13500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034BC")]
		[Address(RVA = "0x799E00", Offset = "0x798800", VA = "0x180799E00")]
		protected void UpdateMaterials()
		{
		}

		// Token: 0x060034BD RID: 13501 RVA: 0x0000E688 File Offset: 0x0000C888
		[Token(Token = "0x60034BD")]
		[Address(RVA = "0x7987B0", Offset = "0x7971B0", VA = "0x1807987B0")]
		private bool AreMetaReqsMet()
		{
			return default(bool);
		}

		// Token: 0x060034BE RID: 13502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034BE")]
		[Address(RVA = "0x799900", Offset = "0x798300", VA = "0x180799900", Slot = "9")]
		protected virtual Constructable_GridBased PlaceNewConstructable()
		{
			return null;
		}

		// Token: 0x060034BF RID: 13503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034BF")]
		[Address(RVA = "0x799310", Offset = "0x797D10", VA = "0x180799310", Slot = "10")]
		protected virtual void FinalizeMoveConstructable()
		{
		}

		// Token: 0x060034C0 RID: 13504 RVA: 0x0000E6A0 File Offset: 0x0000C8A0
		[Token(Token = "0x60034C0")]
		[Address(RVA = "0x799530", Offset = "0x797F30", VA = "0x180799530")]
		private Vector2 GetOriginCoordinate()
		{
			return default(Vector2);
		}

		// Token: 0x060034C1 RID: 13505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034C1")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public ConstructUpdate_OutdoorGrid()
		{
		}

		// Token: 0x0400249F RID: 9375
		[Token(Token = "0x400249F")]
		[FieldOffset(Offset = "0x28")]
		[Header("Settings")]
		public LayerMask detectionMask;

		// Token: 0x040024A0 RID: 9376
		[Token(Token = "0x40024A0")]
		[FieldOffset(Offset = "0x30")]
		public Constructable_GridBased ConstructableClass;

		// Token: 0x040024A1 RID: 9377
		[Token(Token = "0x40024A1")]
		[FieldOffset(Offset = "0x38")]
		public Transform GhostModel;

		// Token: 0x040024A2 RID: 9378
		[Token(Token = "0x40024A2")]
		[FieldOffset(Offset = "0x40")]
		protected bool validPosition;

		// Token: 0x040024A3 RID: 9379
		[Token(Token = "0x40024A3")]
		[FieldOffset(Offset = "0x44")]
		public float currentRotation;

		// Token: 0x040024A4 RID: 9380
		[Token(Token = "0x40024A4")]
		[FieldOffset(Offset = "0x48")]
		protected Material currentGhostMaterial;

		// Token: 0x040024A5 RID: 9381
		[Token(Token = "0x40024A5")]
		[FieldOffset(Offset = "0x50")]
		protected ConstructionManager.WorldIntersection closestIntersection;

		// Token: 0x040024A6 RID: 9382
		[Token(Token = "0x40024A6")]
		[FieldOffset(Offset = "0x58")]
		private float listingPrice;
	}
}
