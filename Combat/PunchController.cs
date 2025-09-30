using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Combat
{
	// Token: 0x020007B0 RID: 1968
	[Token(Token = "0x20007B0")]
	public class PunchController : MonoBehaviour
	{
		// Token: 0x170007B3 RID: 1971
		// (get) Token: 0x06003502 RID: 13570 RVA: 0x0000E730 File Offset: 0x0000C930
		// (set) Token: 0x06003503 RID: 13571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007B3")]
		public bool PunchingEnabled
		{
			[Token(Token = "0x6003502")]
			[Address(RVA = "0x4B9020", Offset = "0x4B7A20", VA = "0x1804B9020")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003503")]
			[Address(RVA = "0x4B9030", Offset = "0x4B7A30", VA = "0x1804B9030")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170007B4 RID: 1972
		// (get) Token: 0x06003504 RID: 13572 RVA: 0x0000E748 File Offset: 0x0000C948
		[Token(Token = "0x170007B4")]
		public bool IsLoading
		{
			[Token(Token = "0x6003504")]
			[Address(RVA = "0x7A73F0", Offset = "0x7A5DF0", VA = "0x1807A73F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170007B5 RID: 1973
		// (get) Token: 0x06003505 RID: 13573 RVA: 0x0000E760 File Offset: 0x0000C960
		// (set) Token: 0x06003506 RID: 13574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007B5")]
		public bool IsPunching
		{
			[Token(Token = "0x6003505")]
			[Address(RVA = "0x570DF0", Offset = "0x56F7F0", VA = "0x180570DF0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003506")]
			[Address(RVA = "0x570E40", Offset = "0x56F840", VA = "0x180570E40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06003507 RID: 13575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003507")]
		[Address(RVA = "0x7A5B50", Offset = "0x7A4550", VA = "0x1807A5B50")]
		private void Awake()
		{
		}

		// Token: 0x06003508 RID: 13576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003508")]
		[Address(RVA = "0x7A6EA0", Offset = "0x7A58A0", VA = "0x1807A6EA0")]
		private void Start()
		{
		}

		// Token: 0x06003509 RID: 13577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003509")]
		[Address(RVA = "0x7A72B0", Offset = "0x7A5CB0", VA = "0x1807A72B0")]
		private void Update()
		{
		}

		// Token: 0x0600350A RID: 13578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600350A")]
		[Address(RVA = "0x7A62A0", Offset = "0x7A4CA0", VA = "0x1807A62A0")]
		private void LateUpdate()
		{
		}

		// Token: 0x0600350B RID: 13579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600350B")]
		[Address(RVA = "0x7A6FA0", Offset = "0x7A59A0", VA = "0x1807A6FA0")]
		private void UpdateCooldown()
		{
		}

		// Token: 0x0600350C RID: 13580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600350C")]
		[Address(RVA = "0x7A7010", Offset = "0x7A5A10", VA = "0x1807A7010")]
		private void UpdateInput()
		{
		}

		// Token: 0x0600350D RID: 13581 RVA: 0x0000E778 File Offset: 0x0000C978
		[Token(Token = "0x600350D")]
		[Address(RVA = "0x7A5BA0", Offset = "0x7A45A0", VA = "0x1807A5BA0")]
		private bool CanStartLoading()
		{
			return default(bool);
		}

		// Token: 0x0600350E RID: 13582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600350E")]
		[Address(RVA = "0x7A6C00", Offset = "0x7A5600", VA = "0x1807A6C00")]
		private void StartLoad()
		{
		}

		// Token: 0x0600350F RID: 13583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600350F")]
		[Address(RVA = "0x7A64A0", Offset = "0x7A4EA0", VA = "0x1807A64A0")]
		private void Release()
		{
		}

		// Token: 0x06003510 RID: 13584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003510")]
		[Address(RVA = "0x7A62F0", Offset = "0x7A4CF0", VA = "0x1807A62F0")]
		private void Punch(float power)
		{
		}

		// Token: 0x06003511 RID: 13585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003511")]
		[Address(RVA = "0x7A5C20", Offset = "0x7A4620", VA = "0x1807A5C20")]
		private void ExecuteHit(float power)
		{
		}

		// Token: 0x06003512 RID: 13586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003512")]
		[Address(RVA = "0x7A67F0", Offset = "0x7A51F0", VA = "0x1807A67F0")]
		private void SetPunchingEnabled(bool enabled)
		{
		}

		// Token: 0x06003513 RID: 13587 RVA: 0x0000E790 File Offset: 0x0000C990
		[Token(Token = "0x6003513")]
		[Address(RVA = "0x7A6920", Offset = "0x7A5320", VA = "0x1807A6920")]
		private bool ShouldBeEnabled()
		{
			return default(bool);
		}

		// Token: 0x06003514 RID: 13588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003514")]
		[Address(RVA = "0x7A73A0", Offset = "0x7A5DA0", VA = "0x1807A73A0")]
		public PunchController()
		{
		}

		// Token: 0x040024DF RID: 9439
		[Token(Token = "0x40024DF")]
		public const float MAX_PUNCH_LOAD = 1f;

		// Token: 0x040024E0 RID: 9440
		[Token(Token = "0x40024E0")]
		public const float MIN_COOLDOWN = 0.1f;

		// Token: 0x040024E1 RID: 9441
		[Token(Token = "0x40024E1")]
		public const float MAX_COOLDOWN = 0.2f;

		// Token: 0x040024E2 RID: 9442
		[Token(Token = "0x40024E2")]
		public const float PUNCH_RANGE = 1.25f;

		// Token: 0x040024E3 RID: 9443
		[Token(Token = "0x40024E3")]
		public const float PUNCH_DEBOUNCE = 0.1f;

		// Token: 0x040024E6 RID: 9446
		[Token(Token = "0x40024E6")]
		[FieldOffset(Offset = "0x24")]
		[Header("Settings")]
		public Vector3 ViewmodelAvatarOffset;

		// Token: 0x040024E7 RID: 9447
		[Token(Token = "0x40024E7")]
		[FieldOffset(Offset = "0x30")]
		public float MinPunchDamage;

		// Token: 0x040024E8 RID: 9448
		[Token(Token = "0x40024E8")]
		[FieldOffset(Offset = "0x34")]
		public float MaxPunchDamage;

		// Token: 0x040024E9 RID: 9449
		[Token(Token = "0x40024E9")]
		[FieldOffset(Offset = "0x38")]
		public float MinPunchForce;

		// Token: 0x040024EA RID: 9450
		[Token(Token = "0x40024EA")]
		[FieldOffset(Offset = "0x3C")]
		public float MaxPunchForce;

		// Token: 0x040024EB RID: 9451
		[Token(Token = "0x40024EB")]
		[FieldOffset(Offset = "0x40")]
		[Header("Stamina Settings")]
		public float MinStaminaCost;

		// Token: 0x040024EC RID: 9452
		[Token(Token = "0x40024EC")]
		[FieldOffset(Offset = "0x44")]
		public float MaxStaminaCost;

		// Token: 0x040024ED RID: 9453
		[Token(Token = "0x40024ED")]
		[FieldOffset(Offset = "0x48")]
		[Header("References")]
		public AudioSourceController PunchSound;

		// Token: 0x040024EE RID: 9454
		[Token(Token = "0x40024EE")]
		[FieldOffset(Offset = "0x50")]
		public RuntimeAnimatorController PunchAnimator;

		// Token: 0x040024EF RID: 9455
		[Token(Token = "0x40024EF")]
		[FieldOffset(Offset = "0x58")]
		private float punchLoad;

		// Token: 0x040024F0 RID: 9456
		[Token(Token = "0x40024F0")]
		[FieldOffset(Offset = "0x5C")]
		private float remainingCooldown;

		// Token: 0x040024F1 RID: 9457
		[Token(Token = "0x40024F1")]
		[FieldOffset(Offset = "0x60")]
		private Player player;

		// Token: 0x040024F2 RID: 9458
		[Token(Token = "0x40024F2")]
		[FieldOffset(Offset = "0x68")]
		private Coroutine punchRoutine;

		// Token: 0x040024F3 RID: 9459
		[Token(Token = "0x40024F3")]
		[FieldOffset(Offset = "0x70")]
		private bool itemEquippedLastFrame;

		// Token: 0x040024F4 RID: 9460
		[Token(Token = "0x40024F4")]
		[FieldOffset(Offset = "0x74")]
		private float timeSincePunchingEnabled;
	}
}
