using System;
using Il2CppDummyDll;
using ScheduleOne.EntityFramework;
using ScheduleOne.ItemFramework;
using UnityEngine;

namespace ScheduleOne.Building
{
	// Token: 0x02000830 RID: 2096
	[Token(Token = "0x2000830")]
	public class BuildUpdate_Surface : BuildUpdate_Base
	{
		// Token: 0x1700081E RID: 2078
		// (get) Token: 0x0600398E RID: 14734 RVA: 0x0000F600 File Offset: 0x0000D800
		[Token(Token = "0x1700081E")]
		private float detectionRange
		{
			[Token(Token = "0x600398E")]
			[Address(RVA = "0x803170", Offset = "0x801B70", VA = "0x180803170")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x0600398F RID: 14735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600398F")]
		[Address(RVA = "0x4B7C10", Offset = "0x4B6610", VA = "0x1804B7C10", Slot = "5")]
		protected virtual void Start()
		{
		}

		// Token: 0x06003990 RID: 14736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003990")]
		[Address(RVA = "0x802FE0", Offset = "0x8019E0", VA = "0x180802FE0", Slot = "6")]
		protected virtual void Update()
		{
		}

		// Token: 0x06003991 RID: 14737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003991")]
		[Address(RVA = "0x8017B0", Offset = "0x8001B0", VA = "0x1808017B0", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		// Token: 0x06003992 RID: 14738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003992")]
		[Address(RVA = "0x802610", Offset = "0x801010", VA = "0x180802610")]
		protected void PositionObjectInFrontOfPlayer(float dist, bool sanitizeForward)
		{
		}

		// Token: 0x06003993 RID: 14739 RVA: 0x0000F618 File Offset: 0x0000D818
		[Token(Token = "0x6003993")]
		[Address(RVA = "0x801680", Offset = "0x800080", VA = "0x180801680")]
		private bool IsSurfaceValidForItem(Surface surface, Collider hitCollider, Vector3 hitPoint)
		{
			return default(bool);
		}

		// Token: 0x06003994 RID: 14740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003994")]
		[Address(RVA = "0x801540", Offset = "0x7FFF40", VA = "0x180801540")]
		protected void CheckRotation()
		{
		}

		// Token: 0x06003995 RID: 14741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003995")]
		[Address(RVA = "0x802E50", Offset = "0x801850", VA = "0x180802E50")]
		protected void UpdateMaterials()
		{
		}

		// Token: 0x06003996 RID: 14742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003996")]
		[Address(RVA = "0x802280", Offset = "0x800C80", VA = "0x180802280", Slot = "8")]
		protected virtual void Place()
		{
		}

		// Token: 0x06003997 RID: 14743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003997")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public BuildUpdate_Surface()
		{
		}

		// Token: 0x040027E7 RID: 10215
		[Token(Token = "0x40027E7")]
		[FieldOffset(Offset = "0x20")]
		public GameObject GhostModel;

		// Token: 0x040027E8 RID: 10216
		[Token(Token = "0x40027E8")]
		[FieldOffset(Offset = "0x28")]
		public SurfaceItem BuildableItemClass;

		// Token: 0x040027E9 RID: 10217
		[Token(Token = "0x40027E9")]
		[FieldOffset(Offset = "0x30")]
		public ItemInstance ItemInstance;

		// Token: 0x040027EA RID: 10218
		[Token(Token = "0x40027EA")]
		[FieldOffset(Offset = "0x38")]
		public float CurrentRotation;

		// Token: 0x040027EB RID: 10219
		[Token(Token = "0x40027EB")]
		[FieldOffset(Offset = "0x3C")]
		[Header("Settings")]
		public LayerMask DetectionMask;

		// Token: 0x040027EC RID: 10220
		[Token(Token = "0x40027EC")]
		[FieldOffset(Offset = "0x40")]
		protected bool validPosition;

		// Token: 0x040027ED RID: 10221
		[Token(Token = "0x40027ED")]
		[FieldOffset(Offset = "0x48")]
		protected Material currentGhostMaterial;

		// Token: 0x040027EE RID: 10222
		[Token(Token = "0x40027EE")]
		[FieldOffset(Offset = "0x50")]
		protected Surface hoveredValidSurface;
	}
}
