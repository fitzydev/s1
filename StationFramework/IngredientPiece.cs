using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.PlayerTasks;
using UnityEngine;

namespace ScheduleOne.StationFramework
{
	// Token: 0x0200096F RID: 2415
	[Token(Token = "0x200096F")]
	[RequireComponent(typeof(Draggable))]
	public class IngredientPiece : MonoBehaviour
	{
		// Token: 0x17000944 RID: 2372
		// (get) Token: 0x0600423E RID: 16958 RVA: 0x00011688 File Offset: 0x0000F888
		// (set) Token: 0x0600423F RID: 16959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000944")]
		public float CurrentDissolveAmount
		{
			[Token(Token = "0x600423E")]
			[Address(RVA = "0x486190", Offset = "0x484B90", VA = "0x180486190")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600423F")]
			[Address(RVA = "0x4A4AF0", Offset = "0x4A34F0", VA = "0x1804A4AF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06004240 RID: 16960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004240")]
		[Address(RVA = "0x87C4A0", Offset = "0x87AEA0", VA = "0x18087C4A0")]
		private void Start()
		{
		}

		// Token: 0x06004241 RID: 16961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004241")]
		[Address(RVA = "0x87C8B0", Offset = "0x87B2B0", VA = "0x18087C8B0")]
		private void Update()
		{
		}

		// Token: 0x06004242 RID: 16962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004242")]
		[Address(RVA = "0x87C490", Offset = "0x87AE90", VA = "0x18087C490")]
		private void FixedUpdate()
		{
		}

		// Token: 0x06004243 RID: 16963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004243")]
		[Address(RVA = "0x87C5A0", Offset = "0x87AFA0", VA = "0x18087C5A0")]
		private void UpdateDrag()
		{
		}

		// Token: 0x06004244 RID: 16964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004244")]
		[Address(RVA = "0x87C140", Offset = "0x87AB40", VA = "0x18087C140")]
		private void CheckLiquid()
		{
		}

		// Token: 0x06004245 RID: 16965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004245")]
		[Address(RVA = "0x87C2D0", Offset = "0x87ACD0", VA = "0x18087C2D0")]
		public void DissolveAmount(float amount, bool showParticles = true)
		{
		}

		// Token: 0x06004246 RID: 16966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004246")]
		[Address(RVA = "0x87C930", Offset = "0x87B330", VA = "0x18087C930")]
		public IngredientPiece()
		{
		}

		// Token: 0x06004247 RID: 16967 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004247")]
		[Address(RVA = "0x87C530", Offset = "0x87AF30", VA = "0x18087C530")]
		[CompilerGenerated]
		private IEnumerator <DissolveAmount>g__DissolveParticlesRoutine|19_0()
		{
			return null;
		}

		// Token: 0x04002E64 RID: 11876
		[Token(Token = "0x4002E64")]
		public const float LIQUID_FRICTION = 100f;

		// Token: 0x04002E66 RID: 11878
		[Token(Token = "0x4002E66")]
		[FieldOffset(Offset = "0x28")]
		public LiquidContainer CurrentLiquidContainer;

		// Token: 0x04002E67 RID: 11879
		[Token(Token = "0x4002E67")]
		[FieldOffset(Offset = "0x30")]
		[Header("References")]
		public Transform ModelContainer;

		// Token: 0x04002E68 RID: 11880
		[Token(Token = "0x4002E68")]
		[FieldOffset(Offset = "0x38")]
		public ParticleSystem DissolveParticles;

		// Token: 0x04002E69 RID: 11881
		[Token(Token = "0x4002E69")]
		[FieldOffset(Offset = "0x40")]
		[Header("Settings")]
		public bool DetectLiquid;

		// Token: 0x04002E6A RID: 11882
		[Token(Token = "0x4002E6A")]
		[FieldOffset(Offset = "0x41")]
		public bool DisableInteractionInLiquid;

		// Token: 0x04002E6B RID: 11883
		[Token(Token = "0x4002E6B")]
		[FieldOffset(Offset = "0x44")]
		[Range(0f, 2f)]
		public float LiquidFrictionMultiplier;

		// Token: 0x04002E6C RID: 11884
		[Token(Token = "0x4002E6C")]
		[FieldOffset(Offset = "0x48")]
		private Draggable draggable;

		// Token: 0x04002E6D RID: 11885
		[Token(Token = "0x4002E6D")]
		[FieldOffset(Offset = "0x50")]
		private float defaultDrag;

		// Token: 0x04002E6E RID: 11886
		[Token(Token = "0x4002E6E")]
		[FieldOffset(Offset = "0x58")]
		private Coroutine dissolveParticleRoutine;
	}
}
