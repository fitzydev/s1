using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Interaction;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Tools
{
	// Token: 0x020008E8 RID: 2280
	[Token(Token = "0x20008E8")]
	public class BombPlantLocation : MonoBehaviour
	{
		// Token: 0x170008EB RID: 2283
		// (get) Token: 0x06003F39 RID: 16185 RVA: 0x00010DD0 File Offset: 0x0000EFD0
		// (set) Token: 0x06003F3A RID: 16186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170008EB")]
		public bool BombPlanted
		{
			[Token(Token = "0x6003F39")]
			[Address(RVA = "0x4B9020", Offset = "0x4B7A20", VA = "0x1804B9020")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003F3A")]
			[Address(RVA = "0x4B9030", Offset = "0x4B7A30", VA = "0x1804B9030")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06003F3B RID: 16187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F3B")]
		[Address(RVA = "0x85DA20", Offset = "0x85C420", VA = "0x18085DA20")]
		private void Awake()
		{
		}

		// Token: 0x06003F3C RID: 16188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F3C")]
		[Address(RVA = "0x85DBE0", Offset = "0x85C5E0", VA = "0x18085DBE0")]
		private void Hovered()
		{
		}

		// Token: 0x06003F3D RID: 16189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F3D")]
		[Address(RVA = "0x85DC60", Offset = "0x85C660", VA = "0x18085DC60")]
		private void Interacted()
		{
		}

		// Token: 0x06003F3E RID: 16190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F3E")]
		[Address(RVA = "0x85DC90", Offset = "0x85C690", VA = "0x18085DC90")]
		public void PlantBomb()
		{
		}

		// Token: 0x06003F3F RID: 16191 RVA: 0x00010DE8 File Offset: 0x0000EFE8
		[Token(Token = "0x6003F3F")]
		[Address(RVA = "0x85DB30", Offset = "0x85C530", VA = "0x18085DB30")]
		private bool CanPlantBomb()
		{
			return default(bool);
		}

		// Token: 0x06003F40 RID: 16192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F40")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public BombPlantLocation()
		{
		}

		// Token: 0x06003F41 RID: 16193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F41")]
		[Address(RVA = "0x85DE30", Offset = "0x85C830", VA = "0x18085DE30")]
		[CompilerGenerated]
		private IEnumerator <PlantBomb>g__Detonate|15_0()
		{
			return null;
		}

		// Token: 0x04002C47 RID: 11335
		[Token(Token = "0x4002C47")]
		public const float COUNTDOWN_TIME = 45f;

		// Token: 0x04002C48 RID: 11336
		[Token(Token = "0x4002C48")]
		public const float BEEP_INTERVAL_MAX = 1f;

		// Token: 0x04002C49 RID: 11337
		[Token(Token = "0x4002C49")]
		public const float BEEP_INTERVAL_MIN = 0.125f;

		// Token: 0x04002C4B RID: 11339
		[Token(Token = "0x4002C4B")]
		[FieldOffset(Offset = "0x28")]
		[Header("References")]
		public InteractableObject IntObj;

		// Token: 0x04002C4C RID: 11340
		[Token(Token = "0x4002C4C")]
		[FieldOffset(Offset = "0x30")]
		public GameObject BombModel;

		// Token: 0x04002C4D RID: 11341
		[Token(Token = "0x4002C4D")]
		[FieldOffset(Offset = "0x38")]
		public UnityEvent onPlantBomb;

		// Token: 0x04002C4E RID: 11342
		[Token(Token = "0x4002C4E")]
		[FieldOffset(Offset = "0x40")]
		public UnityEvent onBeep;

		// Token: 0x04002C4F RID: 11343
		[Token(Token = "0x4002C4F")]
		[FieldOffset(Offset = "0x48")]
		public UnityEvent onDetonate;
	}
}
