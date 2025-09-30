using System;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.PlayerScripts
{
	// Token: 0x02000573 RID: 1395
	[Token(Token = "0x2000573")]
	public class ViewmodelSway : PlayerSingleton<ViewmodelSway>
	{
		// Token: 0x17000562 RID: 1378
		// (get) Token: 0x06001F1D RID: 7965 RVA: 0x0000A380 File Offset: 0x00008580
		[Token(Token = "0x17000562")]
		protected float calculatedJumpJoltHeight
		{
			[Token(Token = "0x6001F1D")]
			[Address(RVA = "0x669610", Offset = "0x668010", VA = "0x180669610")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06001F1E RID: 7966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F1E")]
		[Address(RVA = "0x6681E0", Offset = "0x666BE0", VA = "0x1806681E0", Slot = "5")]
		protected override void Start()
		{
		}

		// Token: 0x06001F1F RID: 7967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F1F")]
		[Address(RVA = "0x6677B0", Offset = "0x6661B0", VA = "0x1806677B0", Slot = "4")]
		protected override void Awake()
		{
		}

		// Token: 0x06001F20 RID: 7968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F20")]
		[Address(RVA = "0x667930", Offset = "0x666330", VA = "0x180667930", Slot = "6")]
		public override void OnStartClient(bool IsOwner)
		{
		}

		// Token: 0x06001F21 RID: 7969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F21")]
		[Address(RVA = "0x668BC0", Offset = "0x6675C0", VA = "0x180668BC0")]
		protected void Update()
		{
		}

		// Token: 0x06001F22 RID: 7970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F22")]
		[Address(RVA = "0x667880", Offset = "0x666280", VA = "0x180667880")]
		private void InventoryStateChanged(bool active)
		{
		}

		// Token: 0x06001F23 RID: 7971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F23")]
		[Address(RVA = "0x667CE0", Offset = "0x6666E0", VA = "0x180667CE0")]
		public void RefreshViewmodel()
		{
		}

		// Token: 0x06001F24 RID: 7972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F24")]
		[Address(RVA = "0x667820", Offset = "0x666220", VA = "0x180667820")]
		protected void BreatheBob()
		{
		}

		// Token: 0x06001F25 RID: 7973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F25")]
		[Address(RVA = "0x668220", Offset = "0x666C20", VA = "0x180668220")]
		protected void Sway()
		{
		}

		// Token: 0x06001F26 RID: 7974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F26")]
		[Address(RVA = "0x668F20", Offset = "0x667920", VA = "0x180668F20")]
		protected void WalkBob()
		{
		}

		// Token: 0x06001F27 RID: 7975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F27")]
		[Address(RVA = "0x6681D0", Offset = "0x666BD0", VA = "0x1806681D0")]
		protected void StartJump()
		{
		}

		// Token: 0x06001F28 RID: 7976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F28")]
		[Address(RVA = "0x668660", Offset = "0x667060", VA = "0x180668660")]
		protected void UpdateJump()
		{
		}

		// Token: 0x06001F29 RID: 7977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F29")]
		[Address(RVA = "0x667890", Offset = "0x666290", VA = "0x180667890")]
		protected void Land()
		{
		}

		// Token: 0x06001F2A RID: 7978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F2A")]
		[Address(RVA = "0x6693E0", Offset = "0x667DE0", VA = "0x1806693E0")]
		public ViewmodelSway()
		{
		}

		// Token: 0x04001967 RID: 6503
		[Token(Token = "0x4001967")]
		[FieldOffset(Offset = "0x20")]
		public bool DEBUG;

		// Token: 0x04001968 RID: 6504
		[Token(Token = "0x4001968")]
		[FieldOffset(Offset = "0x21")]
		[Header("Settings - Breathing")]
		public bool breatheBobbingEnabled;

		// Token: 0x04001969 RID: 6505
		[Token(Token = "0x4001969")]
		[FieldOffset(Offset = "0x24")]
		[Range(0f, 0.0004f)]
		[SerializeField]
		protected float breathingHeightMultiplier;

		// Token: 0x0400196A RID: 6506
		[Token(Token = "0x400196A")]
		[FieldOffset(Offset = "0x28")]
		[Range(0f, 10f)]
		[SerializeField]
		protected float breathingSpeedMultiplier;

		// Token: 0x0400196B RID: 6507
		[Token(Token = "0x400196B")]
		[FieldOffset(Offset = "0x2C")]
		private float lastHeight;

		// Token: 0x0400196C RID: 6508
		[Token(Token = "0x400196C")]
		[FieldOffset(Offset = "0x30")]
		private Vector3 breatheBobPos;

		// Token: 0x0400196D RID: 6509
		[Token(Token = "0x400196D")]
		[FieldOffset(Offset = "0x3C")]
		[Header("Settings - Sway - Movement")]
		public bool swayingEnabled;

		// Token: 0x0400196E RID: 6510
		[Token(Token = "0x400196E")]
		[FieldOffset(Offset = "0x40")]
		[Range(0f, 0.1f)]
		[SerializeField]
		protected float horizontalSwayMultiplier;

		// Token: 0x0400196F RID: 6511
		[Token(Token = "0x400196F")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		[Range(0f, 0.1f)]
		protected float verticalSwayMultiplier;

		// Token: 0x04001970 RID: 6512
		[Token(Token = "0x4001970")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Range(0f, 0.5f)]
		protected float maxHorizontal;

		// Token: 0x04001971 RID: 6513
		[Token(Token = "0x4001971")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		[Range(0f, 0.5f)]
		protected float maxVertical;

		// Token: 0x04001972 RID: 6514
		[Token(Token = "0x4001972")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		protected float swaySmooth;

		// Token: 0x04001973 RID: 6515
		[Token(Token = "0x4001973")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		protected float returnMultiplier;

		// Token: 0x04001974 RID: 6516
		[Token(Token = "0x4001974")]
		[FieldOffset(Offset = "0x58")]
		private Vector3 initialPos;

		// Token: 0x04001975 RID: 6517
		[Token(Token = "0x4001975")]
		[FieldOffset(Offset = "0x64")]
		private Vector3 swayPos;

		// Token: 0x04001976 RID: 6518
		[Token(Token = "0x4001976")]
		[FieldOffset(Offset = "0x70")]
		[Header("Settings - Walk Bob")]
		public bool walkBobbingEnabled;

		// Token: 0x04001977 RID: 6519
		[Token(Token = "0x4001977")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		protected AnimationCurve verticalMovement;

		// Token: 0x04001978 RID: 6520
		[Token(Token = "0x4001978")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		protected AnimationCurve horizontalMovement;

		// Token: 0x04001979 RID: 6521
		[Token(Token = "0x4001979")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Range(0f, 0.1f)]
		protected float verticalBobHeight;

		// Token: 0x0400197A RID: 6522
		[Token(Token = "0x400197A")]
		[FieldOffset(Offset = "0x8C")]
		[SerializeField]
		[Range(0f, 5f)]
		protected float verticalBobSpeed;

		// Token: 0x0400197B RID: 6523
		[Token(Token = "0x400197B")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Range(0f, 0.1f)]
		protected float horizontalBobWidth;

		// Token: 0x0400197C RID: 6524
		[Token(Token = "0x400197C")]
		[FieldOffset(Offset = "0x94")]
		[Range(0f, 5f)]
		[SerializeField]
		protected float horizontalBobSpeed;

		// Token: 0x0400197D RID: 6525
		[Token(Token = "0x400197D")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		protected float walkBobSmooth;

		// Token: 0x0400197E RID: 6526
		[Token(Token = "0x400197E")]
		[FieldOffset(Offset = "0x9C")]
		[SerializeField]
		protected float sprintSpeedMultiplier;

		// Token: 0x0400197F RID: 6527
		[Token(Token = "0x400197F")]
		[FieldOffset(Offset = "0xA0")]
		[HideInInspector]
		public float walkBobMultiplier;

		// Token: 0x04001980 RID: 6528
		[Token(Token = "0x4001980")]
		[FieldOffset(Offset = "0xA4")]
		private Vector3 walkBobPos;

		// Token: 0x04001981 RID: 6529
		[Token(Token = "0x4001981")]
		[FieldOffset(Offset = "0xB0")]
		private float timeSinceWalkStart_vert;

		// Token: 0x04001982 RID: 6530
		[Token(Token = "0x4001982")]
		[FieldOffset(Offset = "0xB4")]
		private float timeSinceWalkStart_horiz;

		// Token: 0x04001983 RID: 6531
		[Token(Token = "0x4001983")]
		[FieldOffset(Offset = "0xB8")]
		[Header("Settings - Jump Jolt")]
		public bool jumpJoltEnabled;

		// Token: 0x04001984 RID: 6532
		[Token(Token = "0x4001984")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		protected AnimationCurve jumpCurve;

		// Token: 0x04001985 RID: 6533
		[Token(Token = "0x4001985")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		protected float jumpJoltTime;

		// Token: 0x04001986 RID: 6534
		[Token(Token = "0x4001986")]
		[FieldOffset(Offset = "0xCC")]
		[SerializeField]
		protected float jumpJoltHeight;

		// Token: 0x04001987 RID: 6535
		[Token(Token = "0x4001987")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		protected float jumpJoltSmooth;

		// Token: 0x04001988 RID: 6536
		[Token(Token = "0x4001988")]
		[FieldOffset(Offset = "0xD4")]
		[Header("Settings - Equip Bop")]
		[SerializeField]
		protected float equipBopVerticalOffset;

		// Token: 0x04001989 RID: 6537
		[Token(Token = "0x4001989")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		protected float equipBopTime;

		// Token: 0x0400198A RID: 6538
		[Token(Token = "0x400198A")]
		[FieldOffset(Offset = "0xDC")]
		private Vector3 equipBopPos;

		// Token: 0x0400198B RID: 6539
		[Token(Token = "0x400198B")]
		[FieldOffset(Offset = "0xE8")]
		private float timeSinceJumpStart;

		// Token: 0x0400198C RID: 6540
		[Token(Token = "0x400198C")]
		[FieldOffset(Offset = "0xEC")]
		private Vector3 jumpPos;

		// Token: 0x0400198D RID: 6541
		[Token(Token = "0x400198D")]
		[FieldOffset(Offset = "0xF8")]
		[Range(0f, 1f)]
		[Header("Settings - Falling")]
		[SerializeField]
		protected float fallOffsetRate;

		// Token: 0x0400198E RID: 6542
		[Token(Token = "0x400198E")]
		[FieldOffset(Offset = "0xFC")]
		[Range(0f, 2f)]
		[SerializeField]
		protected float maxFallOffsetAmount;

		// Token: 0x0400198F RID: 6543
		[Token(Token = "0x400198F")]
		[FieldOffset(Offset = "0x100")]
		private Vector3 fallOffsetPos;

		// Token: 0x04001990 RID: 6544
		[Token(Token = "0x4001990")]
		[FieldOffset(Offset = "0x110")]
		[Header("Settings - Land Jolt")]
		[SerializeField]
		protected AnimationCurve landCurve;

		// Token: 0x04001991 RID: 6545
		[Token(Token = "0x4001991")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		protected float landJoltTime;

		// Token: 0x04001992 RID: 6546
		[Token(Token = "0x4001992")]
		[FieldOffset(Offset = "0x11C")]
		[SerializeField]
		protected float landJoltSmooth;

		// Token: 0x04001993 RID: 6547
		[Token(Token = "0x4001993")]
		[FieldOffset(Offset = "0x120")]
		private Vector3 landPos;

		// Token: 0x04001994 RID: 6548
		[Token(Token = "0x4001994")]
		[FieldOffset(Offset = "0x12C")]
		private float timeSinceLanded;

		// Token: 0x04001995 RID: 6549
		[Token(Token = "0x4001995")]
		[FieldOffset(Offset = "0x130")]
		private float landJoltMultiplier;
	}
}
