using System;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.Vehicles.AI;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Vehicles
{
	// Token: 0x02000876 RID: 2166
	[Token(Token = "0x2000876")]
	public class VehicleLights : NetworkBehaviour
	{
		// Token: 0x17000873 RID: 2163
		// (get) Token: 0x06003BB3 RID: 15283 RVA: 0x00010008 File Offset: 0x0000E208
		// (set) Token: 0x06003BB4 RID: 15284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000873")]
		public bool headLightsOn
		{
			[Token(Token = "0x6003BB3")]
			[Address(RVA = "0x8397C0", Offset = "0x8381C0", VA = "0x1808397C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003BB4")]
			[Address(RVA = "0x8397D0", Offset = "0x8381D0", VA = "0x1808397D0")]
			[CompilerGenerated]
			[ServerRpc(RunLocally = true, RequireOwnership = false)]
			set
			{
			}
		}

		// Token: 0x06003BB5 RID: 15285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BB5")]
		[Address(RVA = "0x8387E0", Offset = "0x8371E0", VA = "0x1808387E0", Slot = "19")]
		public virtual void Awake()
		{
		}

		// Token: 0x06003BB6 RID: 15286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BB6")]
		[Address(RVA = "0x839550", Offset = "0x837F50", VA = "0x180839550", Slot = "20")]
		protected virtual void Update()
		{
		}

		// Token: 0x06003BB7 RID: 15287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BB7")]
		[Address(RVA = "0x838860", Offset = "0x837260", VA = "0x180838860", Slot = "21")]
		protected virtual void FixedUpdate()
		{
		}

		// Token: 0x06003BB8 RID: 15288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BB8")]
		[Address(RVA = "0x8389F0", Offset = "0x8373F0", VA = "0x1808389F0", Slot = "22")]
		protected virtual void LateUpdate()
		{
		}

		// Token: 0x06003BB9 RID: 15289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BB9")]
		[Address(RVA = "0x839730", Offset = "0x838130", VA = "0x180839730")]
		public VehicleLights()
		{
		}

		// Token: 0x06003BBA RID: 15290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BBA")]
		[Address(RVA = "0x839020", Offset = "0x837A20", VA = "0x180839020", Slot = "23")]
		public virtual void NetworkInitialize___Early()
		{
		}

		// Token: 0x06003BBB RID: 15291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BBB")]
		[Address(RVA = "0x838FD0", Offset = "0x8379D0", VA = "0x180838FD0", Slot = "24")]
		public virtual void NetworkInitialize__Late()
		{
		}

		// Token: 0x06003BBC RID: 15292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BBC")]
		[Address(RVA = "0x6806A0", Offset = "0x67F0A0", VA = "0x1806806A0", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06003BBD RID: 15293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BBD")]
		[Address(RVA = "0x839420", Offset = "0x837E20", VA = "0x180839420")]
		private void RpcWriter___Server_set_headLightsOn_1140765316(bool value)
		{
		}

		// Token: 0x06003BBE RID: 15294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BBE")]
		[Address(RVA = "0x839300", Offset = "0x837D00", VA = "0x180839300")]
		public void RpcLogic___set_headLightsOn_1140765316(bool value)
		{
		}

		// Token: 0x06003BBF RID: 15295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BBF")]
		[Address(RVA = "0x839390", Offset = "0x837D90", VA = "0x180839390")]
		private void RpcReader___Server_set_headLightsOn_1140765316(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x17000874 RID: 2164
		// (get) Token: 0x06003BC0 RID: 15296 RVA: 0x00010020 File Offset: 0x0000E220
		// (set) Token: 0x06003BC1 RID: 15297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000874")]
		public bool SyncAccessor_<headLightsOn>k__BackingField
		{
			[Token(Token = "0x6003BC0")]
			[Address(RVA = "0x8397C0", Offset = "0x8381C0", VA = "0x1808397C0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003BC1")]
			[Address(RVA = "0x839900", Offset = "0x838300", VA = "0x180839900")]
			set
			{
			}
		}

		// Token: 0x06003BC2 RID: 15298 RVA: 0x00010038 File Offset: 0x0000E238
		[Token(Token = "0x6003BC2")]
		[Address(RVA = "0x8391C0", Offset = "0x837BC0", VA = "0x1808391C0", Slot = "25")]
		public virtual bool ReadSyncVar___ScheduleOne.Vehicles.VehicleLights(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return default(bool);
		}

		// Token: 0x06003BC3 RID: 15299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BC3")]
		[Address(RVA = "0x838790", Offset = "0x837190", VA = "0x180838790", Slot = "26")]
		protected virtual void Awake_UserLogic_ScheduleOne.Vehicles.VehicleLights_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04002994 RID: 10644
		[Token(Token = "0x4002994")]
		private const int brakeHistoryMaxCount = 60;

		// Token: 0x04002995 RID: 10645
		[Token(Token = "0x4002995")]
		[FieldOffset(Offset = "0x118")]
		public LandVehicle vehicle;

		// Token: 0x04002996 RID: 10646
		[Token(Token = "0x4002996")]
		[FieldOffset(Offset = "0x120")]
		[Header("Headlights")]
		public bool hasHeadLights;

		// Token: 0x04002997 RID: 10647
		[Token(Token = "0x4002997")]
		[FieldOffset(Offset = "0x128")]
		public MeshRenderer[] headLightMeshes;

		// Token: 0x04002998 RID: 10648
		[Token(Token = "0x4002998")]
		[FieldOffset(Offset = "0x130")]
		public OptimizedLight[] headLightSources;

		// Token: 0x04002999 RID: 10649
		[Token(Token = "0x4002999")]
		[FieldOffset(Offset = "0x138")]
		public Material headlightMat_On;

		// Token: 0x0400299A RID: 10650
		[Token(Token = "0x400299A")]
		[FieldOffset(Offset = "0x140")]
		public Material headLightMat_Off;

		// Token: 0x0400299C RID: 10652
		[Token(Token = "0x400299C")]
		[FieldOffset(Offset = "0x149")]
		protected bool headLightsApplied;

		// Token: 0x0400299D RID: 10653
		[Token(Token = "0x400299D")]
		[FieldOffset(Offset = "0x14A")]
		[Header("Brake lights")]
		public bool hasBrakeLights;

		// Token: 0x0400299E RID: 10654
		[Token(Token = "0x400299E")]
		[FieldOffset(Offset = "0x150")]
		public MeshRenderer[] brakeLightMeshes;

		// Token: 0x0400299F RID: 10655
		[Token(Token = "0x400299F")]
		[FieldOffset(Offset = "0x158")]
		public Light[] brakeLightSources;

		// Token: 0x040029A0 RID: 10656
		[Token(Token = "0x40029A0")]
		[FieldOffset(Offset = "0x160")]
		public Material brakeLightMat_On;

		// Token: 0x040029A1 RID: 10657
		[Token(Token = "0x40029A1")]
		[FieldOffset(Offset = "0x168")]
		public Material brakeLightMat_Off;

		// Token: 0x040029A2 RID: 10658
		[Token(Token = "0x40029A2")]
		[FieldOffset(Offset = "0x170")]
		public Material brakeLightMat_Ambient;

		// Token: 0x040029A3 RID: 10659
		[Token(Token = "0x40029A3")]
		[FieldOffset(Offset = "0x178")]
		protected bool brakeLightsOn;

		// Token: 0x040029A4 RID: 10660
		[Token(Token = "0x40029A4")]
		[FieldOffset(Offset = "0x179")]
		protected bool brakeLightsApplied;

		// Token: 0x040029A5 RID: 10661
		[Token(Token = "0x40029A5")]
		[FieldOffset(Offset = "0x17A")]
		[Header("Reverse lights")]
		public bool hasReverseLights;

		// Token: 0x040029A6 RID: 10662
		[Token(Token = "0x40029A6")]
		[FieldOffset(Offset = "0x180")]
		public MeshRenderer[] reverseLightMeshes;

		// Token: 0x040029A7 RID: 10663
		[Token(Token = "0x40029A7")]
		[FieldOffset(Offset = "0x188")]
		public Light[] reverseLightSources;

		// Token: 0x040029A8 RID: 10664
		[Token(Token = "0x40029A8")]
		[FieldOffset(Offset = "0x190")]
		public Material reverseLightMat_On;

		// Token: 0x040029A9 RID: 10665
		[Token(Token = "0x40029A9")]
		[FieldOffset(Offset = "0x198")]
		public Material reverseLightMat_Off;

		// Token: 0x040029AA RID: 10666
		[Token(Token = "0x40029AA")]
		[FieldOffset(Offset = "0x1A0")]
		protected bool reverseLightsOn;

		// Token: 0x040029AB RID: 10667
		[Token(Token = "0x40029AB")]
		[FieldOffset(Offset = "0x1A1")]
		protected bool reverseLightsApplied;

		// Token: 0x040029AC RID: 10668
		[Token(Token = "0x40029AC")]
		[FieldOffset(Offset = "0x1A8")]
		public UnityEvent onHeadlightsOn;

		// Token: 0x040029AD RID: 10669
		[Token(Token = "0x40029AD")]
		[FieldOffset(Offset = "0x1B0")]
		public UnityEvent onHeadlightsOff;

		// Token: 0x040029AE RID: 10670
		[Token(Token = "0x40029AE")]
		[FieldOffset(Offset = "0x1B8")]
		private CircularQueue<bool> brakesAppliedHistory;

		// Token: 0x040029AF RID: 10671
		[Token(Token = "0x40029AF")]
		[FieldOffset(Offset = "0x1C0")]
		private VehicleAgent agent;

		// Token: 0x040029B0 RID: 10672
		[Token(Token = "0x40029B0")]
		[FieldOffset(Offset = "0x1C8")]
		public SyncVar<bool> syncVar___<headLightsOn>k__BackingField;

		// Token: 0x040029B1 RID: 10673
		[Token(Token = "0x40029B1")]
		[FieldOffset(Offset = "0x1D0")]
		private bool NetworkInitialize___EarlyScheduleOne.Vehicles.VehicleLightsAssembly-CSharp.dll_Excuted;

		// Token: 0x040029B2 RID: 10674
		[Token(Token = "0x40029B2")]
		[FieldOffset(Offset = "0x1D1")]
		private bool NetworkInitialize__LateScheduleOne.Vehicles.VehicleLightsAssembly-CSharp.dll_Excuted;
	}
}
