using System;
using System.Runtime.CompilerServices;
using EasyButtons;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.Persistence.Datas;
using UnityEngine;

namespace ScheduleOne.Property
{
	// Token: 0x020008B0 RID: 2224
	[Token(Token = "0x20008B0")]
	public class Manor : Property
	{
		// Token: 0x170008A0 RID: 2208
		// (get) Token: 0x06003CF2 RID: 15602 RVA: 0x000106E0 File Offset: 0x0000E8E0
		// (set) Token: 0x06003CF3 RID: 15603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170008A0")]
		public Manor.EManorState ManorState
		{
			[Token(Token = "0x6003CF2")]
			[Address(RVA = "0x8412D0", Offset = "0x83FCD0", VA = "0x1808412D0")]
			[CompilerGenerated]
			get
			{
				return Manor.EManorState.Original;
			}
			[Token(Token = "0x6003CF3")]
			[Address(RVA = "0x8412F0", Offset = "0x83FCF0", VA = "0x1808412F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170008A1 RID: 2209
		// (get) Token: 0x06003CF4 RID: 15604 RVA: 0x000106F8 File Offset: 0x0000E8F8
		// (set) Token: 0x06003CF5 RID: 15605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170008A1")]
		public int DaysSinceStateChange
		{
			[Token(Token = "0x6003CF4")]
			[Address(RVA = "0x8412C0", Offset = "0x83FCC0", VA = "0x1808412C0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6003CF5")]
			[Address(RVA = "0x8412E0", Offset = "0x83FCE0", VA = "0x1808412E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170008A2 RID: 2210
		// (get) Token: 0x06003CF6 RID: 15606 RVA: 0x00010710 File Offset: 0x0000E910
		// (set) Token: 0x06003CF7 RID: 15607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170008A2")]
		public bool TunnelDug
		{
			[Token(Token = "0x6003CF6")]
			[Address(RVA = "0x62FDA0", Offset = "0x62E7A0", VA = "0x18062FDA0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003CF7")]
			[Address(RVA = "0x841300", Offset = "0x83FD00", VA = "0x180841300")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06003CF8 RID: 15608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CF8")]
		[Address(RVA = "0x83F4B0", Offset = "0x83DEB0", VA = "0x18083F4B0", Slot = "42")]
		public override void Awake()
		{
		}

		// Token: 0x06003CF9 RID: 15609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CF9")]
		[Address(RVA = "0x8400C0", Offset = "0x83EAC0", VA = "0x1808400C0", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x06003CFA RID: 15610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CFA")]
		[Address(RVA = "0x841100", Offset = "0x83FB00", VA = "0x180841100", Slot = "44")]
		protected override void Start()
		{
		}

		// Token: 0x06003CFB RID: 15611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CFB")]
		[Address(RVA = "0x840180", Offset = "0x83EB80", VA = "0x180840180", Slot = "48")]
		protected override void RecieveOwned()
		{
		}

		// Token: 0x06003CFC RID: 15612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CFC")]
		[Address(RVA = "0x840BF0", Offset = "0x83F5F0", VA = "0x180840BF0")]
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		private void SetManorState(NetworkConnection conn, Manor.EManorState state, bool resetStateChangeTimer)
		{
		}

		// Token: 0x06003CFD RID: 15613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CFD")]
		[Address(RVA = "0x83F5B0", Offset = "0x83DFB0", VA = "0x18083F5B0")]
		[Button]
		public void Explode()
		{
		}

		// Token: 0x06003CFE RID: 15614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CFE")]
		[Address(RVA = "0x840130", Offset = "0x83EB30", VA = "0x180840130")]
		[Button]
		public void Rebuild()
		{
		}

		// Token: 0x06003CFF RID: 15615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CFF")]
		[Address(RVA = "0x840BC0", Offset = "0x83F5C0", VA = "0x180840BC0")]
		public void SetDestroyedIfOriginal()
		{
		}

		// Token: 0x06003D00 RID: 15616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D00")]
		[Address(RVA = "0x83F5A0", Offset = "0x83DFA0", VA = "0x18083F5A0")]
		public void DigTunnel()
		{
		}

		// Token: 0x06003D01 RID: 15617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D01")]
		[Address(RVA = "0x840E90", Offset = "0x83F890", VA = "0x180840E90")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public void SetTunnelDug(NetworkConnection conn, bool dug)
		{
		}

		// Token: 0x06003D02 RID: 15618 RVA: 0x00010728 File Offset: 0x0000E928
		[Token(Token = "0x6003D02")]
		[Address(RVA = "0x83F590", Offset = "0x83DF90", VA = "0x18083F590", Slot = "50")]
		public override bool CanBePurchased()
		{
			return default(bool);
		}

		// Token: 0x06003D03 RID: 15619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D03")]
		[Address(RVA = "0x83FFE0", Offset = "0x83E9E0", VA = "0x18083FFE0")]
		private void OnSleepEnd()
		{
		}

		// Token: 0x06003D04 RID: 15620 RVA: 0x00010740 File Offset: 0x0000E940
		[Token(Token = "0x6003D04")]
		[Address(RVA = "0x48DCC0", Offset = "0x48C6C0", VA = "0x18048DCC0", Slot = "49")]
		public override bool ShouldSave()
		{
			return default(bool);
		}

		// Token: 0x06003D05 RID: 15621 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D05")]
		[Address(RVA = "0x83F830", Offset = "0x83E230", VA = "0x18083F830", Slot = "52")]
		public override string GetSaveString()
		{
			return null;
		}

		// Token: 0x06003D06 RID: 15622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D06")]
		[Address(RVA = "0x83FBE0", Offset = "0x83E5E0", VA = "0x18083FBE0", Slot = "55")]
		public override void Load(PropertyData propertyData, string dataString)
		{
		}

		// Token: 0x06003D07 RID: 15623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D07")]
		[Address(RVA = "0x841260", Offset = "0x83FC60", VA = "0x180841260")]
		public Manor()
		{
		}

		// Token: 0x06003D08 RID: 15624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D08")]
		[Address(RVA = "0x83FE80", Offset = "0x83E880", VA = "0x18083FE80", Slot = "56")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06003D09 RID: 15625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D09")]
		[Address(RVA = "0x83FE50", Offset = "0x83E850", VA = "0x18083FE50", Slot = "57")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06003D0A RID: 15626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D0A")]
		[Address(RVA = "0x825A80", Offset = "0x824480", VA = "0x180825A80", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06003D0B RID: 15627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D0B")]
		[Address(RVA = "0x840650", Offset = "0x83F050", VA = "0x180840650")]
		private void RpcWriter___Observers_SetManorState_365422978(NetworkConnection conn, Manor.EManorState state, bool resetStateChangeTimer)
		{
		}

		// Token: 0x06003D0C RID: 15628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D0C")]
		[Address(RVA = "0x8401D0", Offset = "0x83EBD0", VA = "0x1808401D0")]
		private void RpcLogic___SetManorState_365422978(NetworkConnection conn, Manor.EManorState state, bool resetStateChangeTimer)
		{
		}

		// Token: 0x06003D0D RID: 15629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D0D")]
		[Address(RVA = "0x8403F0", Offset = "0x83EDF0", VA = "0x1808403F0")]
		private void RpcReader___Observers_SetManorState_365422978(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003D0E RID: 15630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D0E")]
		[Address(RVA = "0x840900", Offset = "0x83F300", VA = "0x180840900")]
		private void RpcWriter___Target_SetManorState_365422978(NetworkConnection conn, Manor.EManorState state, bool resetStateChangeTimer)
		{
		}

		// Token: 0x06003D0F RID: 15631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D0F")]
		[Address(RVA = "0x840520", Offset = "0x83EF20", VA = "0x180840520")]
		private void RpcReader___Target_SetManorState_365422978(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003D10 RID: 15632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D10")]
		[Address(RVA = "0x8407C0", Offset = "0x83F1C0", VA = "0x1808407C0")]
		private void RpcWriter___Observers_SetTunnelDug_214505783(NetworkConnection conn, bool dug)
		{
		}

		// Token: 0x06003D11 RID: 15633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D11")]
		[Address(RVA = "0x8403B0", Offset = "0x83EDB0", VA = "0x1808403B0")]
		public void RpcLogic___SetTunnelDug_214505783(NetworkConnection conn, bool dug)
		{
		}

		// Token: 0x06003D12 RID: 15634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D12")]
		[Address(RVA = "0x840490", Offset = "0x83EE90", VA = "0x180840490")]
		private void RpcReader___Observers_SetTunnelDug_214505783(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003D13 RID: 15635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D13")]
		[Address(RVA = "0x840A60", Offset = "0x83F460", VA = "0x180840A60")]
		private void RpcWriter___Target_SetTunnelDug_214505783(NetworkConnection conn, bool dug)
		{
		}

		// Token: 0x06003D14 RID: 15636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D14")]
		[Address(RVA = "0x8405C0", Offset = "0x83EFC0", VA = "0x1808405C0")]
		private void RpcReader___Target_SetTunnelDug_214505783(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003D15 RID: 15637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D15")]
		[Address(RVA = "0x83F3F0", Offset = "0x83DDF0", VA = "0x18083F3F0", Slot = "59")]
		protected virtual void Awake_UserLogic_ScheduleOne.Property.Manor_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04002B18 RID: 11032
		[Token(Token = "0x4002B18")]
		public const int REBUILD_AFTER_DAYS = 2;

		// Token: 0x04002B19 RID: 11033
		[Token(Token = "0x4002B19")]
		public const int REBUILD_DURATION_DAYS = 3;

		// Token: 0x04002B1D RID: 11037
		[Token(Token = "0x4002B1D")]
		[FieldOffset(Offset = "0x250")]
		[Header("References")]
		public GameObject OriginalContainer;

		// Token: 0x04002B1E RID: 11038
		[Token(Token = "0x4002B1E")]
		[FieldOffset(Offset = "0x258")]
		public GameObject DestroyedContainer;

		// Token: 0x04002B1F RID: 11039
		[Token(Token = "0x4002B1F")]
		[FieldOffset(Offset = "0x260")]
		public GameObject RebuiltContainer;

		// Token: 0x04002B20 RID: 11040
		[Token(Token = "0x4002B20")]
		[FieldOffset(Offset = "0x268")]
		public GameObject DestructionFXContainer;

		// Token: 0x04002B21 RID: 11041
		[Token(Token = "0x4002B21")]
		[FieldOffset(Offset = "0x270")]
		public GameObject TunnelBlocker;

		// Token: 0x04002B22 RID: 11042
		[Token(Token = "0x4002B22")]
		[FieldOffset(Offset = "0x278")]
		public GameObject TunnelCollapse;

		// Token: 0x04002B23 RID: 11043
		[Token(Token = "0x4002B23")]
		[FieldOffset(Offset = "0x280")]
		public GameObject ConstructionContainer;

		// Token: 0x04002B24 RID: 11044
		[Token(Token = "0x4002B24")]
		[FieldOffset(Offset = "0x288")]
		public AudioSourceController[] ExplosionSounds;

		// Token: 0x04002B25 RID: 11045
		[Token(Token = "0x4002B25")]
		[FieldOffset(Offset = "0x290")]
		public GameObject[] DisableOnRebuild;

		// Token: 0x04002B26 RID: 11046
		[Token(Token = "0x4002B26")]
		[FieldOffset(Offset = "0x298")]
		public Action onRebuildComplete;

		// Token: 0x04002B27 RID: 11047
		[Token(Token = "0x4002B27")]
		[FieldOffset(Offset = "0x2A0")]
		private bool NetworkInitialize___EarlyScheduleOne.Property.ManorAssembly-CSharp.dll_Excuted;

		// Token: 0x04002B28 RID: 11048
		[Token(Token = "0x4002B28")]
		[FieldOffset(Offset = "0x2A1")]
		private bool NetworkInitialize__LateScheduleOne.Property.ManorAssembly-CSharp.dll_Excuted;

		// Token: 0x020008B1 RID: 2225
		[Token(Token = "0x20008B1")]
		public enum EManorState
		{
			// Token: 0x04002B2A RID: 11050
			[Token(Token = "0x4002B2A")]
			Original,
			// Token: 0x04002B2B RID: 11051
			[Token(Token = "0x4002B2B")]
			Destroyed,
			// Token: 0x04002B2C RID: 11052
			[Token(Token = "0x4002B2C")]
			Rebuilt
		}
	}
}
