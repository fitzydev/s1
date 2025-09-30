using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.Vehicles;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.PlayerScripts
{
	// Token: 0x0200056D RID: 1389
	[Token(Token = "0x200056D")]
	public class PlayerMovement : PlayerSingleton<PlayerMovement>
	{
		// Token: 0x17000552 RID: 1362
		// (get) Token: 0x06001ECA RID: 7882 RVA: 0x0000A200 File Offset: 0x00008400
		// (set) Token: 0x06001ECB RID: 7883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000552")]
		public static float GravityMultiplier
		{
			[Token(Token = "0x6001ECA")]
			[Address(RVA = "0x664450", Offset = "0x662E50", VA = "0x180664450")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6001ECB")]
			[Address(RVA = "0x664590", Offset = "0x662F90", VA = "0x180664590")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000553 RID: 1363
		// (get) Token: 0x06001ECC RID: 7884 RVA: 0x0000A218 File Offset: 0x00008418
		// (set) Token: 0x06001ECD RID: 7885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000553")]
		public float playerHeight
		{
			[Token(Token = "0x6001ECC")]
			[Address(RVA = "0x664500", Offset = "0x662F00", VA = "0x180664500")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6001ECD")]
			[Address(RVA = "0x664630", Offset = "0x663030", VA = "0x180664630")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000554 RID: 1364
		// (get) Token: 0x06001ECE RID: 7886 RVA: 0x0000A230 File Offset: 0x00008430
		[Token(Token = "0x17000554")]
		public Vector3 Movement
		{
			[Token(Token = "0x6001ECE")]
			[Address(RVA = "0x6644B0", Offset = "0x662EB0", VA = "0x1806644B0")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000555 RID: 1365
		// (get) Token: 0x06001ECF RID: 7887 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001ED0 RID: 7888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000555")]
		public LandVehicle currentVehicle
		{
			[Token(Token = "0x6001ECF")]
			[Address(RVA = "0x4ACC40", Offset = "0x4AB640", VA = "0x1804ACC40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001ED0")]
			[Address(RVA = "0x639E50", Offset = "0x638850", VA = "0x180639E50")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000556 RID: 1366
		// (get) Token: 0x06001ED1 RID: 7889 RVA: 0x0000A248 File Offset: 0x00008448
		// (set) Token: 0x06001ED2 RID: 7890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000556")]
		public float airTime
		{
			[Token(Token = "0x6001ED1")]
			[Address(RVA = "0x6644D0", Offset = "0x662ED0", VA = "0x1806644D0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6001ED2")]
			[Address(RVA = "0x664600", Offset = "0x663000", VA = "0x180664600")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000557 RID: 1367
		// (get) Token: 0x06001ED3 RID: 7891 RVA: 0x0000A260 File Offset: 0x00008460
		// (set) Token: 0x06001ED4 RID: 7892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000557")]
		public bool isCrouched
		{
			[Token(Token = "0x6001ED3")]
			[Address(RVA = "0x4FABC0", Offset = "0x4F95C0", VA = "0x1804FABC0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001ED4")]
			[Address(RVA = "0x4FAE30", Offset = "0x4F9830", VA = "0x1804FAE30")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000558 RID: 1368
		// (get) Token: 0x06001ED5 RID: 7893 RVA: 0x0000A278 File Offset: 0x00008478
		// (set) Token: 0x06001ED6 RID: 7894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000558")]
		public float standingScale
		{
			[Token(Token = "0x6001ED5")]
			[Address(RVA = "0x664510", Offset = "0x662F10", VA = "0x180664510")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6001ED6")]
			[Address(RVA = "0x664640", Offset = "0x663040", VA = "0x180664640")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000559 RID: 1369
		// (get) Token: 0x06001ED7 RID: 7895 RVA: 0x0000A290 File Offset: 0x00008490
		// (set) Token: 0x06001ED8 RID: 7896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000559")]
		public bool isRagdolled
		{
			[Token(Token = "0x6001ED7")]
			[Address(RVA = "0x6644E0", Offset = "0x662EE0", VA = "0x1806644E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001ED8")]
			[Address(RVA = "0x664610", Offset = "0x663010", VA = "0x180664610")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700055A RID: 1370
		// (get) Token: 0x06001ED9 RID: 7897 RVA: 0x0000A2A8 File Offset: 0x000084A8
		// (set) Token: 0x06001EDA RID: 7898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700055A")]
		public bool isSprinting
		{
			[Token(Token = "0x6001ED9")]
			[Address(RVA = "0x6644F0", Offset = "0x662EF0", VA = "0x1806644F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001EDA")]
			[Address(RVA = "0x664620", Offset = "0x663020", VA = "0x180664620")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700055B RID: 1371
		// (get) Token: 0x06001EDB RID: 7899 RVA: 0x0000A2C0 File Offset: 0x000084C0
		// (set) Token: 0x06001EDC RID: 7900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700055B")]
		public float CurrentSprintMultiplier
		{
			[Token(Token = "0x6001EDB")]
			[Address(RVA = "0x664440", Offset = "0x662E40", VA = "0x180664440")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6001EDC")]
			[Address(RVA = "0x664580", Offset = "0x662F80", VA = "0x180664580")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700055C RID: 1372
		// (get) Token: 0x06001EDD RID: 7901 RVA: 0x0000A2D8 File Offset: 0x000084D8
		// (set) Token: 0x06001EDE RID: 7902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700055C")]
		public bool IsGrounded
		{
			[Token(Token = "0x6001EDD")]
			[Address(RVA = "0x6644A0", Offset = "0x662EA0", VA = "0x1806644A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001EDE")]
			[Address(RVA = "0x6645F0", Offset = "0x662FF0", VA = "0x1806645F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06001EDF RID: 7903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EDF")]
		[Address(RVA = "0x660490", Offset = "0x65EE90", VA = "0x180660490", Slot = "4")]
		protected override void Awake()
		{
		}

		// Token: 0x06001EE0 RID: 7904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EE0")]
		[Address(RVA = "0x662830", Offset = "0x661230", VA = "0x180662830", Slot = "5")]
		protected override void Start()
		{
		}

		// Token: 0x06001EE1 RID: 7905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EE1")]
		[Address(RVA = "0x663A50", Offset = "0x662450", VA = "0x180663A50", Slot = "8")]
		protected virtual void Update()
		{
		}

		// Token: 0x06001EE2 RID: 7906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EE2")]
		[Address(RVA = "0x660D80", Offset = "0x65F780", VA = "0x180660D80")]
		private void FixedUpdate()
		{
		}

		// Token: 0x06001EE3 RID: 7907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EE3")]
		[Address(RVA = "0x661050", Offset = "0x65FA50", VA = "0x180661050")]
		private void LateUpdate()
		{
		}

		// Token: 0x06001EE4 RID: 7908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EE4")]
		[Address(RVA = "0x661240", Offset = "0x65FC40", VA = "0x180661240", Slot = "9")]
		protected virtual void Move()
		{
		}

		// Token: 0x06001EE5 RID: 7909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EE5")]
		[Address(RVA = "0x660960", Offset = "0x65F360", VA = "0x180660960")]
		private void ClampMovement()
		{
		}

		// Token: 0x06001EE6 RID: 7910 RVA: 0x0000A2F0 File Offset: 0x000084F0
		[Token(Token = "0x6001EE6")]
		[Address(RVA = "0x660DF0", Offset = "0x65F7F0", VA = "0x180660DF0")]
		protected float GetSurfaceAngle()
		{
			return 0f;
		}

		// Token: 0x06001EE7 RID: 7911 RVA: 0x0000A308 File Offset: 0x00008508
		[Token(Token = "0x6001EE7")]
		[Address(RVA = "0x664520", Offset = "0x662F20", VA = "0x180664520")]
		private bool isGrounded()
		{
			return default(bool);
		}

		// Token: 0x06001EE8 RID: 7912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EE8")]
		[Address(RVA = "0x663040", Offset = "0x661A40", VA = "0x180663040")]
		protected void UpdateHorizontalAxis()
		{
		}

		// Token: 0x06001EE9 RID: 7913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EE9")]
		[Address(RVA = "0x663850", Offset = "0x662250", VA = "0x180663850")]
		protected void UpdateVerticalAxis()
		{
		}

		// Token: 0x06001EEA RID: 7914 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EEA")]
		[Address(RVA = "0x660FE0", Offset = "0x65F9E0", VA = "0x180660FE0")]
		private IEnumerator Jump()
		{
			return null;
		}

		// Token: 0x06001EEB RID: 7915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EEB")]
		[Address(RVA = "0x662D20", Offset = "0x661720", VA = "0x180662D20")]
		private void TryToggleCrouch()
		{
		}

		// Token: 0x06001EEC RID: 7916 RVA: 0x0000A320 File Offset: 0x00008520
		[Token(Token = "0x6001EEC")]
		[Address(RVA = "0x6605E0", Offset = "0x65EFE0", VA = "0x1806605E0")]
		public bool CanStand()
		{
			return default(bool);
		}

		// Token: 0x06001EED RID: 7917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EED")]
		[Address(RVA = "0x6625A0", Offset = "0x660FA0", VA = "0x1806625A0")]
		public void SetCrouched(bool c)
		{
		}

		// Token: 0x06001EEE RID: 7918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EEE")]
		[Address(RVA = "0x662E50", Offset = "0x661850", VA = "0x180662E50")]
		private void UpdateCrouchVignetteEffect()
		{
		}

		// Token: 0x06001EEF RID: 7919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EEF")]
		[Address(RVA = "0x663560", Offset = "0x661F60", VA = "0x180663560")]
		private void UpdatePlayerHeight()
		{
		}

		// Token: 0x06001EF0 RID: 7920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EF0")]
		[Address(RVA = "0x661170", Offset = "0x65FB70", VA = "0x180661170")]
		public void LerpPlayerRotation(Quaternion rotation, float lerpTime)
		{
		}

		// Token: 0x06001EF1 RID: 7921 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EF1")]
		[Address(RVA = "0x6610E0", Offset = "0x65FAE0", VA = "0x1806610E0")]
		private IEnumerator LerpPlayerRotation_Process(Quaternion endRotation, float lerpTime)
		{
			return null;
		}

		// Token: 0x06001EF2 RID: 7922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EF2")]
		[Address(RVA = "0x660C50", Offset = "0x65F650", VA = "0x180660C50")]
		private void EnterVehicle(LandVehicle vehicle)
		{
		}

		// Token: 0x06001EF3 RID: 7923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EF3")]
		[Address(RVA = "0x660D30", Offset = "0x65F730", VA = "0x180660D30")]
		private void ExitVehicle(LandVehicle veh, Transform exitPoint)
		{
		}

		// Token: 0x06001EF4 RID: 7924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EF4")]
		[Address(RVA = "0x662AF0", Offset = "0x6614F0", VA = "0x180662AF0")]
		public void Teleport(Vector3 position)
		{
		}

		// Token: 0x06001EF5 RID: 7925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EF5")]
		[Address(RVA = "0x6626E0", Offset = "0x6610E0", VA = "0x1806626E0")]
		public void SetResidualVelocity(Vector3 dir, float force, float time)
		{
		}

		// Token: 0x06001EF6 RID: 7926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EF6")]
		[Address(RVA = "0x663CA0", Offset = "0x6626A0", VA = "0x180663CA0")]
		public void WarpToNavMesh()
		{
		}

		// Token: 0x06001EF7 RID: 7927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EF7")]
		[Address(RVA = "0x6622B0", Offset = "0x660CB0", VA = "0x1806622B0")]
		public void RegisterMovementEvent(int threshold, Action action)
		{
		}

		// Token: 0x06001EF8 RID: 7928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EF8")]
		[Address(RVA = "0x660A60", Offset = "0x65F460", VA = "0x180660A60")]
		public void DeregisterMovementEvent(Action action)
		{
		}

		// Token: 0x06001EF9 RID: 7929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EF9")]
		[Address(RVA = "0x663240", Offset = "0x661C40", VA = "0x180663240")]
		private void UpdateMovementEvents()
		{
		}

		// Token: 0x06001EFA RID: 7930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EFA")]
		[Address(RVA = "0x660930", Offset = "0x65F330", VA = "0x180660930")]
		public void ChangeStamina(float change, bool notify = true)
		{
		}

		// Token: 0x06001EFB RID: 7931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EFB")]
		[Address(RVA = "0x662750", Offset = "0x661150", VA = "0x180662750")]
		public void SetStamina(float value, bool notify = true)
		{
		}

		// Token: 0x06001EFC RID: 7932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EFC")]
		[Address(RVA = "0x660400", Offset = "0x65EE00", VA = "0x180660400")]
		public void AddSprintBlocker(string tag)
		{
		}

		// Token: 0x06001EFD RID: 7933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EFD")]
		[Address(RVA = "0x662510", Offset = "0x660F10", VA = "0x180662510")]
		public void RemoveSprintBlocker(string tag)
		{
		}

		// Token: 0x06001EFE RID: 7934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EFE")]
		[Address(RVA = "0x6640E0", Offset = "0x662AE0", VA = "0x1806640E0")]
		public PlayerMovement()
		{
		}

		// Token: 0x0400190D RID: 6413
		[Token(Token = "0x400190D")]
		public const float DEV_SPRINT_MULTIPLIER = 1f;

		// Token: 0x0400190E RID: 6414
		[Token(Token = "0x400190E")]
		public const float GROUNDED_THRESHOLD = 0.05f;

		// Token: 0x0400190F RID: 6415
		[Token(Token = "0x400190F")]
		public const float SLOPE_THRESHOLD = 5f;

		// Token: 0x04001910 RID: 6416
		[Token(Token = "0x4001910")]
		[FieldOffset(Offset = "0x0")]
		public static float WalkSpeed;

		// Token: 0x04001911 RID: 6417
		[Token(Token = "0x4001911")]
		[FieldOffset(Offset = "0x4")]
		public static float SprintMultiplier;

		// Token: 0x04001912 RID: 6418
		[Token(Token = "0x4001912")]
		[FieldOffset(Offset = "0x8")]
		public static float StaticMoveSpeedMultiplier;

		// Token: 0x04001913 RID: 6419
		[Token(Token = "0x4001913")]
		public const float StaminaRestoreDelay = 1f;

		// Token: 0x04001914 RID: 6420
		[Token(Token = "0x4001914")]
		[FieldOffset(Offset = "0xC")]
		public static float JumpMultiplier;

		// Token: 0x04001915 RID: 6421
		[Token(Token = "0x4001915")]
		[FieldOffset(Offset = "0x10")]
		public static float ControllerRadius;

		// Token: 0x04001916 RID: 6422
		[Token(Token = "0x4001916")]
		[FieldOffset(Offset = "0x14")]
		public static float StandingControllerHeight;

		// Token: 0x04001917 RID: 6423
		[Token(Token = "0x4001917")]
		[FieldOffset(Offset = "0x18")]
		public static float CrouchHeightMultiplier;

		// Token: 0x04001918 RID: 6424
		[Token(Token = "0x4001918")]
		[FieldOffset(Offset = "0x1C")]
		public static float CrouchTime;

		// Token: 0x0400191A RID: 6426
		[Token(Token = "0x400191A")]
		public const float StaminaDrainRate = 12.5f;

		// Token: 0x0400191B RID: 6427
		[Token(Token = "0x400191B")]
		public const float StaminaRestoreRate = 25f;

		// Token: 0x0400191C RID: 6428
		[Token(Token = "0x400191C")]
		[FieldOffset(Offset = "0x24")]
		public static float StaminaReserveMax;

		// Token: 0x0400191D RID: 6429
		[Token(Token = "0x400191D")]
		public const float SprintChangeRate = 4f;

		// Token: 0x0400191E RID: 6430
		[Token(Token = "0x400191E")]
		[FieldOffset(Offset = "0x20")]
		[Header("References")]
		public Player Player;

		// Token: 0x0400191F RID: 6431
		[Token(Token = "0x400191F")]
		[FieldOffset(Offset = "0x28")]
		public CharacterController Controller;

		// Token: 0x04001920 RID: 6432
		[Token(Token = "0x4001920")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Header("Move settings")]
		protected float sensitivity;

		// Token: 0x04001921 RID: 6433
		[Token(Token = "0x4001921")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		protected float dead;

		// Token: 0x04001922 RID: 6434
		[Token(Token = "0x4001922")]
		[FieldOffset(Offset = "0x38")]
		public bool canMove;

		// Token: 0x04001923 RID: 6435
		[Token(Token = "0x4001923")]
		[FieldOffset(Offset = "0x39")]
		public bool canJump;

		// Token: 0x04001924 RID: 6436
		[Token(Token = "0x4001924")]
		[FieldOffset(Offset = "0x3A")]
		public bool SprintingRequiresStamina;

		// Token: 0x04001925 RID: 6437
		[Token(Token = "0x4001925")]
		[FieldOffset(Offset = "0x3C")]
		public float MoveSpeedMultiplier;

		// Token: 0x04001926 RID: 6438
		[Token(Token = "0x4001926")]
		[FieldOffset(Offset = "0x40")]
		public float SlipperyMovementMultiplier;

		// Token: 0x04001927 RID: 6439
		[Token(Token = "0x4001927")]
		[FieldOffset(Offset = "0x44")]
		public bool ForceSprint;

		// Token: 0x04001928 RID: 6440
		[Token(Token = "0x4001928")]
		[FieldOffset(Offset = "0x48")]
		[Header("Jump/fall settings")]
		[SerializeField]
		protected float jumpForce;

		// Token: 0x04001929 RID: 6441
		[Token(Token = "0x4001929")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		protected float gravityMultiplier;

		// Token: 0x0400192A RID: 6442
		[Token(Token = "0x400192A")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		protected LayerMask groundDetectionMask;

		// Token: 0x0400192B RID: 6443
		[Token(Token = "0x400192B")]
		[FieldOffset(Offset = "0x54")]
		[Header("Slope Settings")]
		[SerializeField]
		protected float slopeForce;

		// Token: 0x0400192C RID: 6444
		[Token(Token = "0x400192C")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		protected float slopeForceRayLength;

		// Token: 0x0400192D RID: 6445
		[Token(Token = "0x400192D")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		[Header("Crouch Settings")]
		protected float crouchSpeedMultipler;

		// Token: 0x0400192E RID: 6446
		[Token(Token = "0x400192E")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		protected float Crouched_VigIntensity;

		// Token: 0x0400192F RID: 6447
		[Token(Token = "0x400192F")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		protected float Crouched_VigSmoothness;

		// Token: 0x04001930 RID: 6448
		[Token(Token = "0x4001930")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Header("Visibility Points")]
		protected List<Transform> visibilityPointsToScale;

		// Token: 0x04001931 RID: 6449
		[Token(Token = "0x4001931")]
		[FieldOffset(Offset = "0x70")]
		private Dictionary<Transform, float> originalVisibilityPointOffsets;

		// Token: 0x04001933 RID: 6451
		[Token(Token = "0x4001933")]
		[FieldOffset(Offset = "0x7C")]
		protected Vector3 movement;

		// Token: 0x04001934 RID: 6452
		[Token(Token = "0x4001934")]
		[FieldOffset(Offset = "0x88")]
		protected float movementY;

		// Token: 0x04001936 RID: 6454
		[Token(Token = "0x4001936")]
		[FieldOffset(Offset = "0x98")]
		public List<LandVehicle> recentlyDrivenVehicles;

		// Token: 0x04001937 RID: 6455
		[Token(Token = "0x4001937")]
		[FieldOffset(Offset = "0xA0")]
		private bool isJumping;

		// Token: 0x0400193E RID: 6462
		[Token(Token = "0x400193E")]
		[FieldOffset(Offset = "0xB8")]
		public float CurrentStaminaReserve;

		// Token: 0x04001940 RID: 6464
		[Token(Token = "0x4001940")]
		[FieldOffset(Offset = "0xC0")]
		public Action<float> onStaminaReserveChanged;

		// Token: 0x04001941 RID: 6465
		[Token(Token = "0x4001941")]
		[FieldOffset(Offset = "0xC8")]
		public Action onJump;

		// Token: 0x04001942 RID: 6466
		[Token(Token = "0x4001942")]
		[FieldOffset(Offset = "0xD0")]
		public Action onLand;

		// Token: 0x04001943 RID: 6467
		[Token(Token = "0x4001943")]
		[FieldOffset(Offset = "0xD8")]
		public UnityEvent onCrouch;

		// Token: 0x04001944 RID: 6468
		[Token(Token = "0x4001944")]
		[FieldOffset(Offset = "0xE0")]
		public UnityEvent onUncrouch;

		// Token: 0x04001945 RID: 6469
		[Token(Token = "0x4001945")]
		[FieldOffset(Offset = "0xE8")]
		protected float horizontalAxis;

		// Token: 0x04001946 RID: 6470
		[Token(Token = "0x4001946")]
		[FieldOffset(Offset = "0xEC")]
		protected float verticalAxis;

		// Token: 0x04001947 RID: 6471
		[Token(Token = "0x4001947")]
		[FieldOffset(Offset = "0xF0")]
		protected float timeGrounded;

		// Token: 0x04001948 RID: 6472
		[Token(Token = "0x4001948")]
		[FieldOffset(Offset = "0xF8")]
		private Dictionary<int, PlayerMovement.MovementEvent> movementEvents;

		// Token: 0x04001949 RID: 6473
		[Token(Token = "0x4001949")]
		[FieldOffset(Offset = "0x100")]
		private float timeSinceStaminaDrain;

		// Token: 0x0400194A RID: 6474
		[Token(Token = "0x400194A")]
		[FieldOffset(Offset = "0x104")]
		private bool sprintActive;

		// Token: 0x0400194B RID: 6475
		[Token(Token = "0x400194B")]
		[FieldOffset(Offset = "0x105")]
		private bool sprintReleased;

		// Token: 0x0400194C RID: 6476
		[Token(Token = "0x400194C")]
		[FieldOffset(Offset = "0x108")]
		private Vector3 residualVelocityDirection;

		// Token: 0x0400194D RID: 6477
		[Token(Token = "0x400194D")]
		[FieldOffset(Offset = "0x114")]
		private float residualVelocityForce;

		// Token: 0x0400194E RID: 6478
		[Token(Token = "0x400194E")]
		[FieldOffset(Offset = "0x118")]
		private float residualVelocityDuration;

		// Token: 0x0400194F RID: 6479
		[Token(Token = "0x400194F")]
		[FieldOffset(Offset = "0x11C")]
		private float residualVelocityTimeRemaining;

		// Token: 0x04001950 RID: 6480
		[Token(Token = "0x4001950")]
		[FieldOffset(Offset = "0x120")]
		private bool teleport;

		// Token: 0x04001951 RID: 6481
		[Token(Token = "0x4001951")]
		[FieldOffset(Offset = "0x124")]
		private Vector3 teleportPosition;

		// Token: 0x04001952 RID: 6482
		[Token(Token = "0x4001952")]
		[FieldOffset(Offset = "0x130")]
		private List<string> sprintBlockers;

		// Token: 0x04001953 RID: 6483
		[Token(Token = "0x4001953")]
		[FieldOffset(Offset = "0x138")]
		private Vector3 lastFrameMovement;

		// Token: 0x04001954 RID: 6484
		[Token(Token = "0x4001954")]
		[FieldOffset(Offset = "0x148")]
		private Coroutine playerRotCoroutine;

		// Token: 0x0200056E RID: 1390
		[Token(Token = "0x200056E")]
		public class MovementEvent
		{
			// Token: 0x06001F01 RID: 7937 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001F01")]
			[Address(RVA = "0x6510A0", Offset = "0x64FAA0", VA = "0x1806510A0")]
			public void Update(Vector3 newPosition)
			{
			}

			// Token: 0x06001F02 RID: 7938 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001F02")]
			[Address(RVA = "0x6511D0", Offset = "0x64FBD0", VA = "0x1806511D0")]
			public MovementEvent()
			{
			}

			// Token: 0x04001955 RID: 6485
			[Token(Token = "0x4001955")]
			[FieldOffset(Offset = "0x10")]
			public List<Action> actions;

			// Token: 0x04001956 RID: 6486
			[Token(Token = "0x4001956")]
			[FieldOffset(Offset = "0x18")]
			public Vector3 LastUpdatedDistance;
		}
	}
}
