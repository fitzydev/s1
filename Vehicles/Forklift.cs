using System;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Vehicles
{
	// Token: 0x0200085E RID: 2142
	[Token(Token = "0x200085E")]
	public class Forklift : LandVehicle
	{
		// Token: 0x1700083F RID: 2111
		// (get) Token: 0x06003A84 RID: 14980 RVA: 0x0000FB70 File Offset: 0x0000DD70
		// (set) Token: 0x06003A85 RID: 14981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700083F")]
		public float targetForkHeight
		{
			[Token(Token = "0x6003A84")]
			[Address(RVA = "0x80F550", Offset = "0x80DF50", VA = "0x18080F550")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6003A85")]
			[Address(RVA = "0x80F700", Offset = "0x80E100", VA = "0x18080F700")]
			[ServerRpc(RunLocally = true)]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000840 RID: 2112
		// (get) Token: 0x06003A86 RID: 14982 RVA: 0x0000FB88 File Offset: 0x0000DD88
		// (set) Token: 0x06003A87 RID: 14983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000840")]
		public float actualForkHeight
		{
			[Token(Token = "0x6003A86")]
			[Address(RVA = "0x80F540", Offset = "0x80DF40", VA = "0x18080F540")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6003A87")]
			[Address(RVA = "0x80F560", Offset = "0x80DF60", VA = "0x18080F560")]
			[ServerRpc(RunLocally = true)]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06003A88 RID: 14984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A88")]
		[Address(RVA = "0x80E3D0", Offset = "0x80CDD0", VA = "0x18080E3D0", Slot = "45")]
		public override void Awake()
		{
		}

		// Token: 0x06003A89 RID: 14985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A89")]
		[Address(RVA = "0x80F440", Offset = "0x80DE40", VA = "0x18080F440", Slot = "49")]
		protected override void Update()
		{
		}

		// Token: 0x06003A8A RID: 14986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A8A")]
		[Address(RVA = "0x80E560", Offset = "0x80CF60", VA = "0x18080E560", Slot = "50")]
		protected override void FixedUpdate()
		{
		}

		// Token: 0x06003A8B RID: 14987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A8B")]
		[Address(RVA = "0x80E7D0", Offset = "0x80D1D0", VA = "0x18080E7D0", Slot = "73")]
		protected new virtual void LateUpdate()
		{
		}

		// Token: 0x06003A8C RID: 14988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A8C")]
		[Address(RVA = "0x80F520", Offset = "0x80DF20", VA = "0x18080F520")]
		public Forklift()
		{
		}

		// Token: 0x06003A8D RID: 14989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A8D")]
		[Address(RVA = "0x80EA90", Offset = "0x80D490", VA = "0x18080EA90", Slot = "66")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06003A8E RID: 14990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A8E")]
		[Address(RVA = "0x80EA20", Offset = "0x80D420", VA = "0x18080EA20", Slot = "67")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06003A8F RID: 14991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A8F")]
		[Address(RVA = "0x80E9E0", Offset = "0x80D3E0", VA = "0x18080E9E0", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06003A90 RID: 14992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A90")]
		[Address(RVA = "0x80F290", Offset = "0x80DC90", VA = "0x18080F290")]
		private void RpcWriter___Server_set_targetForkHeight_431000436(float value)
		{
		}

		// Token: 0x06003A91 RID: 14993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A91")]
		[Address(RVA = "0x80EF30", Offset = "0x80D930", VA = "0x18080EF30")]
		protected void RpcLogic___set_targetForkHeight_431000436(float value)
		{
		}

		// Token: 0x06003A92 RID: 14994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A92")]
		[Address(RVA = "0x80F050", Offset = "0x80DA50", VA = "0x18080F050")]
		private void RpcReader___Server_set_targetForkHeight_431000436(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06003A93 RID: 14995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A93")]
		[Address(RVA = "0x80F0E0", Offset = "0x80DAE0", VA = "0x18080F0E0")]
		private void RpcWriter___Server_set_actualForkHeight_431000436(float value)
		{
		}

		// Token: 0x06003A94 RID: 14996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A94")]
		[Address(RVA = "0x80EEA0", Offset = "0x80D8A0", VA = "0x18080EEA0")]
		protected void RpcLogic___set_actualForkHeight_431000436(float value)
		{
		}

		// Token: 0x06003A95 RID: 14997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A95")]
		[Address(RVA = "0x80EFC0", Offset = "0x80D9C0", VA = "0x18080EFC0")]
		private void RpcReader___Server_set_actualForkHeight_431000436(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x17000841 RID: 2113
		// (get) Token: 0x06003A96 RID: 14998 RVA: 0x0000FBA0 File Offset: 0x0000DDA0
		// (set) Token: 0x06003A97 RID: 14999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000841")]
		public float SyncAccessor_<targetForkHeight>k__BackingField
		{
			[Token(Token = "0x6003A96")]
			[Address(RVA = "0x80F550", Offset = "0x80DF50", VA = "0x18080F550")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6003A97")]
			[Address(RVA = "0x80F960", Offset = "0x80E360", VA = "0x18080F960")]
			set
			{
			}
		}

		// Token: 0x06003A98 RID: 15000 RVA: 0x0000FBB8 File Offset: 0x0000DDB8
		[Token(Token = "0x6003A98")]
		[Address(RVA = "0x80ED20", Offset = "0x80D720", VA = "0x18080ED20", Slot = "74")]
		public virtual bool ReadSyncVar___ScheduleOne.Vehicles.Forklift(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return default(bool);
		}

		// Token: 0x17000842 RID: 2114
		// (get) Token: 0x06003A99 RID: 15001 RVA: 0x0000FBD0 File Offset: 0x0000DDD0
		// (set) Token: 0x06003A9A RID: 15002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000842")]
		public float SyncAccessor_<actualForkHeight>k__BackingField
		{
			[Token(Token = "0x6003A99")]
			[Address(RVA = "0x80F540", Offset = "0x80DF40", VA = "0x18080F540")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6003A9A")]
			[Address(RVA = "0x80F8A0", Offset = "0x80E2A0", VA = "0x18080F8A0")]
			set
			{
			}
		}

		// Token: 0x06003A9B RID: 15003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A9B")]
		[Address(RVA = "0x80E270", Offset = "0x80CC70", VA = "0x18080E270", Slot = "75")]
		protected virtual void Awake_UserLogic_ScheduleOne.Vehicles.Forklift_Assembly-CSharp.dll()
		{
		}

		// Token: 0x040028D3 RID: 10451
		[Token(Token = "0x40028D3")]
		[FieldOffset(Offset = "0x350")]
		[SerializeField]
		[Header("Forklift References")]
		protected Transform steeringWheel;

		// Token: 0x040028D4 RID: 10452
		[Token(Token = "0x40028D4")]
		[FieldOffset(Offset = "0x358")]
		[SerializeField]
		protected Rigidbody forkRb;

		// Token: 0x040028D5 RID: 10453
		[Token(Token = "0x40028D5")]
		[FieldOffset(Offset = "0x360")]
		[SerializeField]
		protected ConfigurableJoint joint;

		// Token: 0x040028D6 RID: 10454
		[Token(Token = "0x40028D6")]
		[FieldOffset(Offset = "0x368")]
		[SerializeField]
		[Header("Forklift settings")]
		protected float steeringWheelAngleMultiplier;

		// Token: 0x040028D7 RID: 10455
		[Token(Token = "0x40028D7")]
		[FieldOffset(Offset = "0x36C")]
		[SerializeField]
		protected float lift_MinY;

		// Token: 0x040028D8 RID: 10456
		[Token(Token = "0x40028D8")]
		[FieldOffset(Offset = "0x370")]
		[SerializeField]
		protected float lift_MaxY;

		// Token: 0x040028D9 RID: 10457
		[Token(Token = "0x40028D9")]
		[FieldOffset(Offset = "0x374")]
		[SerializeField]
		protected float liftMoveRate;

		// Token: 0x040028DB RID: 10459
		[Token(Token = "0x40028DB")]
		[FieldOffset(Offset = "0x37C")]
		private float lastFrameTargetForkHeight;

		// Token: 0x040028DD RID: 10461
		[Token(Token = "0x40028DD")]
		[FieldOffset(Offset = "0x388")]
		public SyncVar<float> syncVar___<targetForkHeight>k__BackingField;

		// Token: 0x040028DE RID: 10462
		[Token(Token = "0x40028DE")]
		[FieldOffset(Offset = "0x390")]
		public SyncVar<float> syncVar___<actualForkHeight>k__BackingField;

		// Token: 0x040028DF RID: 10463
		[Token(Token = "0x40028DF")]
		[FieldOffset(Offset = "0x398")]
		private bool NetworkInitialize___EarlyScheduleOne.Vehicles.ForkliftAssembly-CSharp.dll_Excuted;

		// Token: 0x040028E0 RID: 10464
		[Token(Token = "0x40028E0")]
		[FieldOffset(Offset = "0x399")]
		private bool NetworkInitialize__LateScheduleOne.Vehicles.ForkliftAssembly-CSharp.dll_Excuted;
	}
}
