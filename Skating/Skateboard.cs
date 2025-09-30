using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Tools;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Skating
{
	// Token: 0x020002D6 RID: 726
	[Token(Token = "0x20002D6")]
	public class Skateboard : NetworkBehaviour
	{
		// Token: 0x1700033E RID: 830
		// (get) Token: 0x06000F8A RID: 3978 RVA: 0x000077B8 File Offset: 0x000059B8
		// (set) Token: 0x06000F8B RID: 3979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700033E")]
		public float CurrentSteerInput
		{
			[Token(Token = "0x6000F8A")]
			[Address(RVA = "0x5ADF10", Offset = "0x5AC910", VA = "0x1805ADF10")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000F8B")]
			[Address(RVA = "0x5ADF30", Offset = "0x5AC930", VA = "0x1805ADF30")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x06000F8C RID: 3980 RVA: 0x000077D0 File Offset: 0x000059D0
		[Token(Token = "0x1700033F")]
		public bool IsPushing
		{
			[Token(Token = "0x6000F8C")]
			[Address(RVA = "0xAC4730", Offset = "0xAC3130", VA = "0x180AC4730")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000340 RID: 832
		// (get) Token: 0x06000F8D RID: 3981 RVA: 0x000077E8 File Offset: 0x000059E8
		[Token(Token = "0x17000340")]
		public float TimeSincePushStart
		{
			[Token(Token = "0x6000F8D")]
			[Address(RVA = "0xAC4740", Offset = "0xAC3140", VA = "0x180AC4740")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x06000F8E RID: 3982 RVA: 0x00007800 File Offset: 0x00005A00
		[Token(Token = "0x17000341")]
		public bool isGrounded
		{
			[Token(Token = "0x6000F8E")]
			[Address(RVA = "0xAC4770", Offset = "0xAC3170", VA = "0x180AC4770")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x06000F8F RID: 3983 RVA: 0x00007818 File Offset: 0x00005A18
		[Token(Token = "0x17000342")]
		public float AirTime
		{
			[Token(Token = "0x6000F8F")]
			[Address(RVA = "0xAC4720", Offset = "0xAC3120", VA = "0x180AC4720")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x06000F90 RID: 3984 RVA: 0x00007830 File Offset: 0x00005A30
		// (set) Token: 0x06000F91 RID: 3985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000343")]
		public float JumpBuildAmount
		{
			[Token(Token = "0x6000F90")]
			[Address(RVA = "0x5B3930", Offset = "0x5B2330", VA = "0x1805B3930")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000F91")]
			[Address(RVA = "0xAC3A50", Offset = "0xAC2450", VA = "0x180AC3A50")]
			[CompilerGenerated]
			[ServerRpc]
			set
			{
			}
		}

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x06000F92 RID: 3986 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000F93 RID: 3987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000344")]
		public Player Rider
		{
			[Token(Token = "0x6000F92")]
			[Address(RVA = "0x548950", Offset = "0x547350", VA = "0x180548950")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000F93")]
			[Address(RVA = "0x5ADF40", Offset = "0x5AC940", VA = "0x1805ADF40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x06000F94 RID: 3988 RVA: 0x00007848 File Offset: 0x00005A48
		[Token(Token = "0x17000345")]
		public float TopSpeed_Ms
		{
			[Token(Token = "0x6000F94")]
			[Address(RVA = "0xAC4750", Offset = "0xAC3150", VA = "0x180AC4750")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06000F95 RID: 3989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F95")]
		[Address(RVA = "0xAC1290", Offset = "0xABFC90", VA = "0x180AC1290", Slot = "19")]
		public virtual void Awake()
		{
		}

		// Token: 0x06000F96 RID: 3990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F96")]
		[Address(RVA = "0xAC3050", Offset = "0xAC1A50", VA = "0x180AC3050", Slot = "11")]
		public override void OnStartClient()
		{
		}

		// Token: 0x06000F97 RID: 3991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F97")]
		[Address(RVA = "0xAC4520", Offset = "0xAC2F20", VA = "0x180AC4520")]
		public void Update()
		{
		}

		// Token: 0x06000F98 RID: 3992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F98")]
		[Address(RVA = "0xAC21B0", Offset = "0xAC0BB0", VA = "0x180AC21B0")]
		private void GetInput()
		{
		}

		// Token: 0x06000F99 RID: 3993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F99")]
		[Address(RVA = "0xAC1FB0", Offset = "0xAC09B0", VA = "0x180AC1FB0")]
		private void FixedUpdate()
		{
		}

		// Token: 0x06000F9A RID: 3994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F9A")]
		[Address(RVA = "0xAC2DA0", Offset = "0xAC17A0", VA = "0x180AC2DA0")]
		private void LateUpdate()
		{
		}

		// Token: 0x06000F9B RID: 3995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F9B")]
		[Address(RVA = "0xAC0170", Offset = "0xABEB70", VA = "0x180AC0170")]
		private void ApplyInput()
		{
		}

		// Token: 0x06000F9C RID: 3996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F9C")]
		[Address(RVA = "0xAC09A0", Offset = "0xABF3A0", VA = "0x180AC09A0")]
		private void ApplyLateralFriction()
		{
		}

		// Token: 0x06000F9D RID: 3997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F9D")]
		[Address(RVA = "0xAC3E80", Offset = "0xAC2880", VA = "0x180AC3E80")]
		private void UpdateHover()
		{
		}

		// Token: 0x06000F9E RID: 3998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F9E")]
		[Address(RVA = "0xAC0000", Offset = "0xABEA00", VA = "0x180AC0000")]
		private void ApplyGravity()
		{
		}

		// Token: 0x06000F9F RID: 3999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F9F")]
		[Address(RVA = "0xAC12E0", Offset = "0xABFCE0", VA = "0x180AC12E0")]
		private void CheckGrounded()
		{
		}

		// Token: 0x06000FA0 RID: 4000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FA0")]
		[Address(RVA = "0xAC13B0", Offset = "0xABFDB0", VA = "0x180AC13B0")]
		private void CheckJump()
		{
		}

		// Token: 0x06000FA1 RID: 4001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FA1")]
		[Address(RVA = "0xAC3C00", Offset = "0xAC2600", VA = "0x180AC3C00")]
		[ServerRpc(RunLocally = true)]
		private void SendJump(float jumpHeldTime)
		{
		}

		// Token: 0x06000FA2 RID: 4002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FA2")]
		[Address(RVA = "0xAC3300", Offset = "0xAC1D00", VA = "0x180AC3300")]
		[ObserversRpc(RunLocally = true)]
		private void ReceiveJump(float _jumpHeldTime)
		{
		}

		// Token: 0x06000FA3 RID: 4003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FA3")]
		[Address(RVA = "0xAC2C60", Offset = "0xAC1660", VA = "0x180AC2C60")]
		private void Jump()
		{
		}

		// Token: 0x06000FA4 RID: 4004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FA4")]
		[Address(RVA = "0xAC3120", Offset = "0xAC1B20", VA = "0x180AC3120")]
		private void Push()
		{
		}

		// Token: 0x06000FA5 RID: 4005 RVA: 0x00007860 File Offset: 0x00005A60
		[Token(Token = "0x6000FA5")]
		[Address(RVA = "0xAC27D0", Offset = "0xAC11D0", VA = "0x180AC27D0")]
		public bool IsGrounded()
		{
			return default(bool);
		}

		// Token: 0x06000FA6 RID: 4006 RVA: 0x00007878 File Offset: 0x00005A78
		[Token(Token = "0x6000FA6")]
		[Address(RVA = "0xAC2800", Offset = "0xAC1200", VA = "0x180AC2800")]
		public bool IsGrounded(out RaycastHit hit)
		{
			return default(bool);
		}

		// Token: 0x06000FA7 RID: 4007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FA7")]
		[Address(RVA = "0xAC3DA0", Offset = "0xAC27A0", VA = "0x180AC3DA0")]
		public void SetVelocity(Vector3 velocity)
		{
		}

		// Token: 0x06000FA8 RID: 4008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FA8")]
		[Address(RVA = "0xAC18D0", Offset = "0xAC02D0", VA = "0x180AC18D0")]
		private void ClampRotation()
		{
		}

		// Token: 0x06000FA9 RID: 4009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FA9")]
		[Address(RVA = "0xAC0EF0", Offset = "0xABF8F0", VA = "0x180AC0EF0")]
		public void ApplyPlayerScale()
		{
		}

		// Token: 0x06000FAA RID: 4010 RVA: 0x00007890 File Offset: 0x00005A90
		[Token(Token = "0x6000FAA")]
		[Address(RVA = "0xAC2710", Offset = "0xAC1110", VA = "0x180AC2710")]
		public float GetSurfaceSmoothness()
		{
			return 0f;
		}

		// Token: 0x06000FAB RID: 4011 RVA: 0x000078A8 File Offset: 0x00005AA8
		[Token(Token = "0x6000FAB")]
		[Address(RVA = "0xAC2BB0", Offset = "0xAC15B0", VA = "0x180AC2BB0")]
		public bool IsOnTerrain()
		{
			return default(bool);
		}

		// Token: 0x06000FAC RID: 4012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FAC")]
		[Address(RVA = "0xAC4570", Offset = "0xAC2F70", VA = "0x180AC4570")]
		public Skateboard()
		{
		}

		// Token: 0x06000FAD RID: 4013 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FAD")]
		[Address(RVA = "0xAC3E10", Offset = "0xAC2810", VA = "0x180AC3E10")]
		[CompilerGenerated]
		private IEnumerator <Push>g__Push|113_0()
		{
			return null;
		}

		// Token: 0x06000FAE RID: 4014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FAE")]
		[Address(RVA = "0xAC2E20", Offset = "0xAC1820", VA = "0x180AC2E20", Slot = "20")]
		public virtual void NetworkInitialize___Early()
		{
		}

		// Token: 0x06000FAF RID: 4015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FAF")]
		[Address(RVA = "0xAC2DD0", Offset = "0xAC17D0", VA = "0x180AC2DD0", Slot = "21")]
		public virtual void NetworkInitialize__Late()
		{
		}

		// Token: 0x06000FB0 RID: 4016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FB0")]
		[Address(RVA = "0x6783D0", Offset = "0x676DD0", VA = "0x1806783D0", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06000FB1 RID: 4017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FB1")]
		[Address(RVA = "0xAC3A50", Offset = "0xAC2450", VA = "0x180AC3A50")]
		private void RpcWriter___Server_set_JumpBuildAmount_431000436(float value)
		{
		}

		// Token: 0x06000FB2 RID: 4018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FB2")]
		[Address(RVA = "0xAC34E0", Offset = "0xAC1EE0", VA = "0x180AC34E0")]
		public void RpcLogic___set_JumpBuildAmount_431000436(float value)
		{
		}

		// Token: 0x06000FB3 RID: 4019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FB3")]
		[Address(RVA = "0xAC3670", Offset = "0xAC2070", VA = "0x180AC3670")]
		private void RpcReader___Server_set_JumpBuildAmount_431000436(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06000FB4 RID: 4020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FB4")]
		[Address(RVA = "0xAC38A0", Offset = "0xAC22A0", VA = "0x180AC38A0")]
		private void RpcWriter___Server_SendJump_431000436(float jumpHeldTime)
		{
		}

		// Token: 0x06000FB5 RID: 4021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FB5")]
		[Address(RVA = "0xAC3300", Offset = "0xAC1D00", VA = "0x180AC3300")]
		private void RpcLogic___SendJump_431000436(float jumpHeldTime)
		{
		}

		// Token: 0x06000FB6 RID: 4022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FB6")]
		[Address(RVA = "0xAC35E0", Offset = "0xAC1FE0", VA = "0x180AC35E0")]
		private void RpcReader___Server_SendJump_431000436(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06000FB7 RID: 4023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FB7")]
		[Address(RVA = "0xAC3750", Offset = "0xAC2150", VA = "0x180AC3750")]
		private void RpcWriter___Observers_ReceiveJump_431000436(float _jumpHeldTime)
		{
		}

		// Token: 0x06000FB8 RID: 4024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FB8")]
		[Address(RVA = "0xAC3440", Offset = "0xAC1E40", VA = "0x180AC3440")]
		private void RpcLogic___ReceiveJump_431000436(float _jumpHeldTime)
		{
		}

		// Token: 0x06000FB9 RID: 4025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FB9")]
		[Address(RVA = "0xAC3570", Offset = "0xAC1F70", VA = "0x180AC3570")]
		private void RpcReader___Observers_ReceiveJump_431000436(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x06000FBA RID: 4026 RVA: 0x000078C0 File Offset: 0x00005AC0
		// (set) Token: 0x06000FBB RID: 4027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000346")]
		public float SyncAccessor_<JumpBuildAmount>k__BackingField
		{
			[Token(Token = "0x6000FBA")]
			[Address(RVA = "0x5B3930", Offset = "0x5B2330", VA = "0x1805B3930")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000FBB")]
			[Address(RVA = "0xAC4790", Offset = "0xAC3190", VA = "0x180AC4790")]
			set
			{
			}
		}

		// Token: 0x06000FBC RID: 4028 RVA: 0x000078D8 File Offset: 0x00005AD8
		[Token(Token = "0x6000FBC")]
		[Address(RVA = "0xAC31C0", Offset = "0xAC1BC0", VA = "0x180AC31C0", Slot = "22")]
		public virtual bool ReadSyncVar___ScheduleOne.Skating.Skateboard(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return default(bool);
		}

		// Token: 0x06000FBD RID: 4029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FBD")]
		[Address(RVA = "0xAC0FF0", Offset = "0xABF9F0", VA = "0x180AC0FF0")]
		private void Awake_UserLogic_ScheduleOne.Skating.Skateboard_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04000F8F RID: 3983
		[Token(Token = "0x4000F8F")]
		public const float JumpCooldown = 0.3f;

		// Token: 0x04000F90 RID: 3984
		[Token(Token = "0x4000F90")]
		public const float JumpForceMin = 0.5f;

		// Token: 0x04000F91 RID: 3985
		[Token(Token = "0x4000F91")]
		public const float JumpForceBuildTime = 0.5f;

		// Token: 0x04000F92 RID: 3986
		[Token(Token = "0x4000F92")]
		public const float PushCooldown = 1f;

		// Token: 0x04000F93 RID: 3987
		[Token(Token = "0x4000F93")]
		public const float PushStaminaConsumption = 12.5f;

		// Token: 0x04000F94 RID: 3988
		[Token(Token = "0x4000F94")]
		public const float PitchLimit = 60f;

		// Token: 0x04000F95 RID: 3989
		[Token(Token = "0x4000F95")]
		public const float RollLimit = 20f;

		// Token: 0x04000F96 RID: 3990
		[Token(Token = "0x4000F96")]
		[FieldOffset(Offset = "0x118")]
		[Header("Info - Readonly")]
		public float CurrentSpeed_Kmh;

		// Token: 0x04000F9A RID: 3994
		[Token(Token = "0x4000F9A")]
		[FieldOffset(Offset = "0x130")]
		[Header("References")]
		public Rigidbody Rb;

		// Token: 0x04000F9B RID: 3995
		[Token(Token = "0x4000F9B")]
		[FieldOffset(Offset = "0x138")]
		public Transform CoM;

		// Token: 0x04000F9C RID: 3996
		[Token(Token = "0x4000F9C")]
		[FieldOffset(Offset = "0x140")]
		public Transform[] HoverPoints;

		// Token: 0x04000F9D RID: 3997
		[Token(Token = "0x4000F9D")]
		[FieldOffset(Offset = "0x148")]
		public Transform FrontAxlePosition;

		// Token: 0x04000F9E RID: 3998
		[Token(Token = "0x4000F9E")]
		[FieldOffset(Offset = "0x150")]
		public Transform RearAxlePosition;

		// Token: 0x04000F9F RID: 3999
		[Token(Token = "0x4000F9F")]
		[FieldOffset(Offset = "0x158")]
		public Transform PlayerContainer;

		// Token: 0x04000FA0 RID: 4000
		[Token(Token = "0x4000FA0")]
		[FieldOffset(Offset = "0x160")]
		public SkateboardAnimation Animation;

		// Token: 0x04000FA1 RID: 4001
		[Token(Token = "0x4000FA1")]
		[FieldOffset(Offset = "0x168")]
		public SmoothedVelocityCalculator VelocityCalculator;

		// Token: 0x04000FA2 RID: 4002
		[Token(Token = "0x4000FA2")]
		[FieldOffset(Offset = "0x170")]
		public AverageAcceleration Accelerometer;

		// Token: 0x04000FA3 RID: 4003
		[Token(Token = "0x4000FA3")]
		[FieldOffset(Offset = "0x178")]
		[HideInInspector]
		public Skateboard_Equippable Equippable;

		// Token: 0x04000FA4 RID: 4004
		[Token(Token = "0x4000FA4")]
		[FieldOffset(Offset = "0x180")]
		public Transform IKAlignmentsContainer;

		// Token: 0x04000FA5 RID: 4005
		[Token(Token = "0x4000FA5")]
		[FieldOffset(Offset = "0x188")]
		[Header("Turn Settings")]
		public float TurnForce;

		// Token: 0x04000FA6 RID: 4006
		[Token(Token = "0x4000FA6")]
		[FieldOffset(Offset = "0x18C")]
		public float TurnChangeRate;

		// Token: 0x04000FA7 RID: 4007
		[Token(Token = "0x4000FA7")]
		[FieldOffset(Offset = "0x190")]
		public float TurnReturnToRestRate;

		// Token: 0x04000FA8 RID: 4008
		[Token(Token = "0x4000FA8")]
		[FieldOffset(Offset = "0x194")]
		public float TurnSpeedBoost;

		// Token: 0x04000FA9 RID: 4009
		[Token(Token = "0x4000FA9")]
		[FieldOffset(Offset = "0x198")]
		public AnimationCurve TurnForceMap;

		// Token: 0x04000FAA RID: 4010
		[Token(Token = "0x4000FAA")]
		[FieldOffset(Offset = "0x1A0")]
		[Header("Settings")]
		public float Gravity;

		// Token: 0x04000FAB RID: 4011
		[Token(Token = "0x4000FAB")]
		[FieldOffset(Offset = "0x1A4")]
		public float BrakeForce;

		// Token: 0x04000FAC RID: 4012
		[Token(Token = "0x4000FAC")]
		[FieldOffset(Offset = "0x1A8")]
		public float ReverseTopSpeed_Kmh;

		// Token: 0x04000FAD RID: 4013
		[Token(Token = "0x4000FAD")]
		[FieldOffset(Offset = "0x1AC")]
		public LayerMask GroundDetectionMask;

		// Token: 0x04000FAE RID: 4014
		[Token(Token = "0x4000FAE")]
		[FieldOffset(Offset = "0x1B0")]
		public Collider[] MainColliders;

		// Token: 0x04000FAF RID: 4015
		[Token(Token = "0x4000FAF")]
		[FieldOffset(Offset = "0x1B8")]
		public float RotationClampForce;

		// Token: 0x04000FB0 RID: 4016
		[Token(Token = "0x4000FB0")]
		[FieldOffset(Offset = "0x1BC")]
		public bool SlowOnTerrain;

		// Token: 0x04000FB1 RID: 4017
		[Token(Token = "0x4000FB1")]
		[FieldOffset(Offset = "0x1BD")]
		[Header("Friction Settings")]
		public bool FrictionEnabled;

		// Token: 0x04000FB2 RID: 4018
		[Token(Token = "0x4000FB2")]
		[FieldOffset(Offset = "0x1C0")]
		public AnimationCurve LongitudinalFrictionCurve;

		// Token: 0x04000FB3 RID: 4019
		[Token(Token = "0x4000FB3")]
		[FieldOffset(Offset = "0x1C8")]
		public float LongitudinalFrictionMultiplier;

		// Token: 0x04000FB4 RID: 4020
		[Token(Token = "0x4000FB4")]
		[FieldOffset(Offset = "0x1CC")]
		public float LateralFrictionForceMultiplier;

		// Token: 0x04000FB5 RID: 4021
		[Token(Token = "0x4000FB5")]
		[FieldOffset(Offset = "0x1D0")]
		[Header("Jump Settings")]
		public float JumpForce;

		// Token: 0x04000FB6 RID: 4022
		[Token(Token = "0x4000FB6")]
		[FieldOffset(Offset = "0x1D4")]
		public float JumpDuration_Min;

		// Token: 0x04000FB7 RID: 4023
		[Token(Token = "0x4000FB7")]
		[FieldOffset(Offset = "0x1D8")]
		public float JumpDuration_Max;

		// Token: 0x04000FB8 RID: 4024
		[Token(Token = "0x4000FB8")]
		[FieldOffset(Offset = "0x1E0")]
		public AnimationCurve FrontAxleJumpCurve;

		// Token: 0x04000FB9 RID: 4025
		[Token(Token = "0x4000FB9")]
		[FieldOffset(Offset = "0x1E8")]
		public AnimationCurve RearAxleJumpCurve;

		// Token: 0x04000FBA RID: 4026
		[Token(Token = "0x4000FBA")]
		[FieldOffset(Offset = "0x1F0")]
		public AnimationCurve JumpForwardForceCurve;

		// Token: 0x04000FBB RID: 4027
		[Token(Token = "0x4000FBB")]
		[FieldOffset(Offset = "0x1F8")]
		public float JumpForwardBoost;

		// Token: 0x04000FBC RID: 4028
		[Token(Token = "0x4000FBC")]
		[FieldOffset(Offset = "0x1FC")]
		[Header("Hover Settings")]
		public float HoverForce;

		// Token: 0x04000FBD RID: 4029
		[Token(Token = "0x4000FBD")]
		[FieldOffset(Offset = "0x200")]
		public float HoverRayLength;

		// Token: 0x04000FBE RID: 4030
		[Token(Token = "0x4000FBE")]
		[FieldOffset(Offset = "0x204")]
		public float HoverHeight;

		// Token: 0x04000FBF RID: 4031
		[Token(Token = "0x4000FBF")]
		[FieldOffset(Offset = "0x208")]
		public float Hover_P;

		// Token: 0x04000FC0 RID: 4032
		[Token(Token = "0x4000FC0")]
		[FieldOffset(Offset = "0x20C")]
		public float Hover_I;

		// Token: 0x04000FC1 RID: 4033
		[Token(Token = "0x4000FC1")]
		[FieldOffset(Offset = "0x210")]
		public float Hover_D;

		// Token: 0x04000FC2 RID: 4034
		[Token(Token = "0x4000FC2")]
		[FieldOffset(Offset = "0x214")]
		[Tooltip("Top speed in m/s")]
		[Header("Pushing Setings")]
		public float TopSpeed_Kmh;

		// Token: 0x04000FC3 RID: 4035
		[Token(Token = "0x4000FC3")]
		[FieldOffset(Offset = "0x218")]
		public float PushForceMultiplier;

		// Token: 0x04000FC4 RID: 4036
		[Token(Token = "0x4000FC4")]
		[FieldOffset(Offset = "0x220")]
		public AnimationCurve PushForceMultiplierMap;

		// Token: 0x04000FC5 RID: 4037
		[Token(Token = "0x4000FC5")]
		[FieldOffset(Offset = "0x228")]
		public float PushForceDuration;

		// Token: 0x04000FC6 RID: 4038
		[Token(Token = "0x4000FC6")]
		[FieldOffset(Offset = "0x22C")]
		public float PushDelay;

		// Token: 0x04000FC7 RID: 4039
		[Token(Token = "0x4000FC7")]
		[FieldOffset(Offset = "0x230")]
		public AnimationCurve PushForceCurve;

		// Token: 0x04000FC8 RID: 4040
		[Token(Token = "0x4000FC8")]
		[FieldOffset(Offset = "0x238")]
		[Header("Air Movement")]
		public bool AirMovementEnabled;

		// Token: 0x04000FC9 RID: 4041
		[Token(Token = "0x4000FC9")]
		[FieldOffset(Offset = "0x23C")]
		public float AirMovementForce;

		// Token: 0x04000FCA RID: 4042
		[Token(Token = "0x4000FCA")]
		[FieldOffset(Offset = "0x240")]
		public float AirMovementJumpReductionDuration;

		// Token: 0x04000FCB RID: 4043
		[Token(Token = "0x4000FCB")]
		[FieldOffset(Offset = "0x248")]
		public AnimationCurve AirMovementJumpReductionCurve;

		// Token: 0x04000FCC RID: 4044
		[Token(Token = "0x4000FCC")]
		[FieldOffset(Offset = "0x250")]
		[Header("Events")]
		public UnityEvent OnPushStart;

		// Token: 0x04000FCD RID: 4045
		[Token(Token = "0x4000FCD")]
		[FieldOffset(Offset = "0x258")]
		public UnityEvent<float> OnJump;

		// Token: 0x04000FCE RID: 4046
		[Token(Token = "0x4000FCE")]
		[FieldOffset(Offset = "0x260")]
		public UnityEvent OnLand;

		// Token: 0x04000FCF RID: 4047
		[Token(Token = "0x4000FCF")]
		[FieldOffset(Offset = "0x268")]
		private int horizontalInput;

		// Token: 0x04000FD0 RID: 4048
		[Token(Token = "0x4000FD0")]
		[FieldOffset(Offset = "0x26C")]
		private bool jumpReleased;

		// Token: 0x04000FD1 RID: 4049
		[Token(Token = "0x4000FD1")]
		[FieldOffset(Offset = "0x270")]
		private float timeSinceLastJump;

		// Token: 0x04000FD2 RID: 4050
		[Token(Token = "0x4000FD2")]
		[FieldOffset(Offset = "0x274")]
		private float timeGrounded;

		// Token: 0x04000FD3 RID: 4051
		[Token(Token = "0x4000FD3")]
		[FieldOffset(Offset = "0x278")]
		private float timeAirborne;

		// Token: 0x04000FD4 RID: 4052
		[Token(Token = "0x4000FD4")]
		[FieldOffset(Offset = "0x27C")]
		private float jumpHeldTime;

		// Token: 0x04000FD5 RID: 4053
		[Token(Token = "0x4000FD5")]
		[FieldOffset(Offset = "0x280")]
		private float frontAxleForce;

		// Token: 0x04000FD6 RID: 4054
		[Token(Token = "0x4000FD6")]
		[FieldOffset(Offset = "0x284")]
		private float rearAxleForce;

		// Token: 0x04000FD7 RID: 4055
		[Token(Token = "0x4000FD7")]
		[FieldOffset(Offset = "0x288")]
		private float jumpForwardForce;

		// Token: 0x04000FD8 RID: 4056
		[Token(Token = "0x4000FD8")]
		[FieldOffset(Offset = "0x290")]
		private List<PID> hoverPIDs;

		// Token: 0x04000FD9 RID: 4057
		[Token(Token = "0x4000FD9")]
		[FieldOffset(Offset = "0x298")]
		private bool pushQueued;

		// Token: 0x04000FDA RID: 4058
		[Token(Token = "0x4000FDA")]
		[FieldOffset(Offset = "0x299")]
		private bool isPushing;

		// Token: 0x04000FDB RID: 4059
		[Token(Token = "0x4000FDB")]
		[FieldOffset(Offset = "0x29C")]
		private float thisFramePushForce;

		// Token: 0x04000FDC RID: 4060
		[Token(Token = "0x4000FDC")]
		[FieldOffset(Offset = "0x2A0")]
		private float timeSincePushStart;

		// Token: 0x04000FDD RID: 4061
		[Token(Token = "0x4000FDD")]
		[FieldOffset(Offset = "0x2A4")]
		private bool braking;

		// Token: 0x04000FDE RID: 4062
		[Token(Token = "0x4000FDE")]
		[FieldOffset(Offset = "0x2A8")]
		public SyncVar<float> syncVar___<JumpBuildAmount>k__BackingField;

		// Token: 0x04000FDF RID: 4063
		[Token(Token = "0x4000FDF")]
		[FieldOffset(Offset = "0x2B0")]
		private bool NetworkInitialize___EarlyScheduleOne.Skating.SkateboardAssembly-CSharp.dll_Excuted;

		// Token: 0x04000FE0 RID: 4064
		[Token(Token = "0x4000FE0")]
		[FieldOffset(Offset = "0x2B1")]
		private bool NetworkInitialize__LateScheduleOne.Skating.SkateboardAssembly-CSharp.dll_Excuted;
	}
}
