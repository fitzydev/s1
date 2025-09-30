using System;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.DevUtilities;
using ScheduleOne.ObjectScripts;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Law
{
	// Token: 0x02000539 RID: 1337
	[Token(Token = "0x2000539")]
	public class CurfewManager : NetworkSingleton<CurfewManager>
	{
		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x06001B38 RID: 6968 RVA: 0x000096C0 File Offset: 0x000078C0
		// (set) Token: 0x06001B39 RID: 6969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004C9")]
		public bool IsEnabled
		{
			[Token(Token = "0x6001B38")]
			[Address(RVA = "0x538700", Offset = "0x537100", VA = "0x180538700")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001B39")]
			[Address(RVA = "0x633830", Offset = "0x632230", VA = "0x180633830")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x06001B3A RID: 6970 RVA: 0x000096D8 File Offset: 0x000078D8
		// (set) Token: 0x06001B3B RID: 6971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004CA")]
		public bool IsCurrentlyActive
		{
			[Token(Token = "0x6001B3A")]
			[Address(RVA = "0x633810", Offset = "0x632210", VA = "0x180633810")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001B3B")]
			[Address(RVA = "0x633820", Offset = "0x632220", VA = "0x180633820")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x06001B3C RID: 6972 RVA: 0x000096F0 File Offset: 0x000078F0
		[Token(Token = "0x170004CB")]
		public bool IsCurrentlyActiveWithTolerance
		{
			[Token(Token = "0x6001B3C")]
			[Address(RVA = "0x633770", Offset = "0x632170", VA = "0x180633770")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001B3D RID: 6973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B3D")]
		[Address(RVA = "0x633610", Offset = "0x632010", VA = "0x180633610", Slot = "19")]
		protected override void Start()
		{
		}

		// Token: 0x06001B3E RID: 6974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B3E")]
		[Address(RVA = "0x633130", Offset = "0x631B30", VA = "0x180633130", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x06001B3F RID: 6975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B3F")]
		[Address(RVA = "0x632930", Offset = "0x631330", VA = "0x180632930")]
		[TargetRpc]
		[ObserversRpc]
		public void Enable(NetworkConnection conn)
		{
		}

		// Token: 0x06001B40 RID: 6976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B40")]
		[Address(RVA = "0x632810", Offset = "0x631210", VA = "0x180632810")]
		[ObserversRpc]
		public void Disable()
		{
		}

		// Token: 0x06001B41 RID: 6977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B41")]
		[Address(RVA = "0x632B20", Offset = "0x631520", VA = "0x180632B20")]
		private void MinPass()
		{
		}

		// Token: 0x06001B42 RID: 6978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B42")]
		[Address(RVA = "0x633730", Offset = "0x632130", VA = "0x180633730")]
		public CurfewManager()
		{
		}

		// Token: 0x06001B43 RID: 6979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B43")]
		[Address(RVA = "0x633000", Offset = "0x631A00", VA = "0x180633000", Slot = "22")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06001B44 RID: 6980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B44")]
		[Address(RVA = "0x632FB0", Offset = "0x6319B0", VA = "0x180632FB0", Slot = "23")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06001B45 RID: 6981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B45")]
		[Address(RVA = "0x5B3020", Offset = "0x5B1A20", VA = "0x1805B3020", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06001B46 RID: 6982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B46")]
		[Address(RVA = "0x6333D0", Offset = "0x631DD0", VA = "0x1806333D0")]
		private void RpcWriter___Observers_Enable_328543758(NetworkConnection conn)
		{
		}

		// Token: 0x06001B47 RID: 6983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B47")]
		[Address(RVA = "0x633210", Offset = "0x631C10", VA = "0x180633210")]
		public void RpcLogic___Enable_328543758(NetworkConnection conn)
		{
		}

		// Token: 0x06001B48 RID: 6984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B48")]
		[Address(RVA = "0x633360", Offset = "0x631D60", VA = "0x180633360")]
		private void RpcReader___Observers_Enable_328543758(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001B49 RID: 6985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B49")]
		[Address(RVA = "0x6334E0", Offset = "0x631EE0", VA = "0x1806334E0")]
		private void RpcWriter___Target_Enable_328543758(NetworkConnection conn)
		{
		}

		// Token: 0x06001B4A RID: 6986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B4A")]
		[Address(RVA = "0x633390", Offset = "0x631D90", VA = "0x180633390")]
		private void RpcReader___Target_Enable_328543758(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001B4B RID: 6987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B4B")]
		[Address(RVA = "0x632810", Offset = "0x631210", VA = "0x180632810")]
		private void RpcWriter___Observers_Disable_2166136261()
		{
		}

		// Token: 0x06001B4C RID: 6988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B4C")]
		[Address(RVA = "0x633170", Offset = "0x631B70", VA = "0x180633170")]
		public void RpcLogic___Disable_2166136261()
		{
		}

		// Token: 0x06001B4D RID: 6989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B4D")]
		[Address(RVA = "0x6332B0", Offset = "0x631CB0", VA = "0x1806332B0")]
		private void RpcReader___Observers_Disable_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001B4E RID: 6990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B4E")]
		[Address(RVA = "0x6327A0", Offset = "0x6311A0", VA = "0x1806327A0", Slot = "20")]
		public override void Awake()
		{
		}

		// Token: 0x04001748 RID: 5960
		[Token(Token = "0x4001748")]
		public const int WARNING_TIME = 2030;

		// Token: 0x04001749 RID: 5961
		[Token(Token = "0x4001749")]
		public const int CURFEW_START_TIME = 2100;

		// Token: 0x0400174A RID: 5962
		[Token(Token = "0x400174A")]
		public const int CURFEW_END_TIME = 500;

		// Token: 0x0400174D RID: 5965
		[Token(Token = "0x400174D")]
		[FieldOffset(Offset = "0x128")]
		[Header("References")]
		public VMSBoard[] VMSBoards;

		// Token: 0x0400174E RID: 5966
		[Token(Token = "0x400174E")]
		[FieldOffset(Offset = "0x130")]
		public AudioSourceController CurfewWarningSound;

		// Token: 0x0400174F RID: 5967
		[Token(Token = "0x400174F")]
		[FieldOffset(Offset = "0x138")]
		public AudioSourceController CurfewAlarmSound;

		// Token: 0x04001750 RID: 5968
		[Token(Token = "0x4001750")]
		[FieldOffset(Offset = "0x140")]
		public UnityEvent onCurfewEnabled;

		// Token: 0x04001751 RID: 5969
		[Token(Token = "0x4001751")]
		[FieldOffset(Offset = "0x148")]
		public UnityEvent onCurfewDisabled;

		// Token: 0x04001752 RID: 5970
		[Token(Token = "0x4001752")]
		[FieldOffset(Offset = "0x150")]
		public UnityEvent onCurfewHint;

		// Token: 0x04001753 RID: 5971
		[Token(Token = "0x4001753")]
		[FieldOffset(Offset = "0x158")]
		public UnityEvent onCurfewWarning;

		// Token: 0x04001754 RID: 5972
		[Token(Token = "0x4001754")]
		[FieldOffset(Offset = "0x160")]
		private bool warningPlayed;

		// Token: 0x04001755 RID: 5973
		[Token(Token = "0x4001755")]
		[FieldOffset(Offset = "0x161")]
		private bool NetworkInitialize___EarlyScheduleOne.Law.CurfewManagerAssembly-CSharp.dll_Excuted;

		// Token: 0x04001756 RID: 5974
		[Token(Token = "0x4001756")]
		[FieldOffset(Offset = "0x162")]
		private bool NetworkInitialize__LateScheduleOne.Law.CurfewManagerAssembly-CSharp.dll_Excuted;
	}
}
