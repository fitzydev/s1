using System;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.Levelling;
using ScheduleOne.NPCs.CharacterClasses;

namespace ScheduleOne.Map
{
	// Token: 0x02000CEA RID: 3306
	[Token(Token = "0x2000CEA")]
	public class DarkMarket : NetworkSingleton<DarkMarket>
	{
		// Token: 0x17000D0D RID: 3341
		// (get) Token: 0x06005D98 RID: 23960 RVA: 0x00016818 File Offset: 0x00014A18
		// (set) Token: 0x06005D99 RID: 23961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000D0D")]
		public bool IsOpen
		{
			[Token(Token = "0x6005D98")]
			[Address(RVA = "0x538700", Offset = "0x537100", VA = "0x180538700")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005D99")]
			[Address(RVA = "0x633830", Offset = "0x632230", VA = "0x180633830")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000D0E RID: 3342
		// (get) Token: 0x06005D9A RID: 23962 RVA: 0x00016830 File Offset: 0x00014A30
		// (set) Token: 0x06005D9B RID: 23963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000D0E")]
		public bool Unlocked
		{
			[Token(Token = "0x6005D9A")]
			[Address(RVA = "0x633810", Offset = "0x632210", VA = "0x180633810")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005D9B")]
			[Address(RVA = "0x633820", Offset = "0x632220", VA = "0x180633820")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06005D9C RID: 23964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D9C")]
		[Address(RVA = "0xA58350", Offset = "0xA56D50", VA = "0x180A58350", Slot = "19")]
		protected override void Start()
		{
		}

		// Token: 0x06005D9D RID: 23965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D9D")]
		[Address(RVA = "0xA57810", Offset = "0xA56210", VA = "0x180A57810", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x06005D9E RID: 23966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D9E")]
		[Address(RVA = "0xA58450", Offset = "0xA56E50", VA = "0x180A58450")]
		private void Update()
		{
		}

		// Token: 0x06005D9F RID: 23967 RVA: 0x00016848 File Offset: 0x00014A48
		[Token(Token = "0x6005D9F")]
		[Address(RVA = "0xA581E0", Offset = "0xA56BE0", VA = "0x180A581E0")]
		private bool ShouldBeOpen()
		{
			return default(bool);
		}

		// Token: 0x06005DA0 RID: 23968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DA0")]
		[Address(RVA = "0xA57650", Offset = "0xA56050", VA = "0x180A57650")]
		private void OnLoad()
		{
		}

		// Token: 0x06005DA1 RID: 23969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DA1")]
		[Address(RVA = "0xA57E80", Offset = "0xA56880", VA = "0x180A57E80")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendUnlocked()
		{
		}

		// Token: 0x06005DA2 RID: 23970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DA2")]
		[Address(RVA = "0xA57F90", Offset = "0xA56990", VA = "0x180A57F90")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		private void SetUnlocked(NetworkConnection conn)
		{
		}

		// Token: 0x06005DA3 RID: 23971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DA3")]
		[Address(RVA = "0xA585E0", Offset = "0xA56FE0", VA = "0x180A585E0")]
		public DarkMarket()
		{
		}

		// Token: 0x06005DA4 RID: 23972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DA4")]
		[Address(RVA = "0xA57510", Offset = "0xA55F10", VA = "0x180A57510", Slot = "22")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06005DA5 RID: 23973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DA5")]
		[Address(RVA = "0xA574C0", Offset = "0xA55EC0", VA = "0x180A574C0", Slot = "23")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06005DA6 RID: 23974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DA6")]
		[Address(RVA = "0x5B3020", Offset = "0x5B1A20", VA = "0x1805B3020", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06005DA7 RID: 23975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DA7")]
		[Address(RVA = "0xA57C40", Offset = "0xA56640", VA = "0x180A57C40")]
		private void RpcWriter___Server_SendUnlocked_2166136261()
		{
		}

		// Token: 0x06005DA8 RID: 23976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DA8")]
		[Address(RVA = "0xA57850", Offset = "0xA56250", VA = "0x180A57850")]
		public void RpcLogic___SendUnlocked_2166136261()
		{
		}

		// Token: 0x06005DA9 RID: 23977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DA9")]
		[Address(RVA = "0xA57A90", Offset = "0xA56490", VA = "0x180A57A90")]
		private void RpcReader___Server_SendUnlocked_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06005DAA RID: 23978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DAA")]
		[Address(RVA = "0xA57B20", Offset = "0xA56520", VA = "0x180A57B20")]
		private void RpcWriter___Observers_SetUnlocked_328543758(NetworkConnection conn)
		{
		}

		// Token: 0x06005DAB RID: 23979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DAB")]
		[Address(RVA = "0xA57860", Offset = "0xA56260", VA = "0x180A57860")]
		private void RpcLogic___SetUnlocked_328543758(NetworkConnection conn)
		{
		}

		// Token: 0x06005DAC RID: 23980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DAC")]
		[Address(RVA = "0xA57A50", Offset = "0xA56450", VA = "0x180A57A50")]
		private void RpcReader___Observers_SetUnlocked_328543758(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06005DAD RID: 23981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DAD")]
		[Address(RVA = "0xA57D50", Offset = "0xA56750", VA = "0x180A57D50")]
		private void RpcWriter___Target_SetUnlocked_328543758(NetworkConnection conn)
		{
		}

		// Token: 0x06005DAE RID: 23982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DAE")]
		[Address(RVA = "0xA57AE0", Offset = "0xA564E0", VA = "0x180A57AE0")]
		private void RpcReader___Target_SetUnlocked_328543758(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06005DAF RID: 23983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DAF")]
		[Address(RVA = "0xA57450", Offset = "0xA55E50", VA = "0x180A57450", Slot = "20")]
		public override void Awake()
		{
		}

		// Token: 0x04004402 RID: 17410
		[Token(Token = "0x4004402")]
		[FieldOffset(Offset = "0x128")]
		public DarkMarketAccessZone AccessZone;

		// Token: 0x04004403 RID: 17411
		[Token(Token = "0x4004403")]
		[FieldOffset(Offset = "0x130")]
		public DarkMarketMainDoor MainDoor;

		// Token: 0x04004404 RID: 17412
		[Token(Token = "0x4004404")]
		[FieldOffset(Offset = "0x138")]
		public Oscar Oscar;

		// Token: 0x04004405 RID: 17413
		[Token(Token = "0x4004405")]
		[FieldOffset(Offset = "0x140")]
		public FullRank UnlockRank;

		// Token: 0x04004406 RID: 17414
		[Token(Token = "0x4004406")]
		[FieldOffset(Offset = "0x148")]
		private bool NetworkInitialize___EarlyScheduleOne.Map.DarkMarketAssembly-CSharp.dll_Excuted;

		// Token: 0x04004407 RID: 17415
		[Token(Token = "0x4004407")]
		[FieldOffset(Offset = "0x149")]
		private bool NetworkInitialize__LateScheduleOne.Map.DarkMarketAssembly-CSharp.dll_Excuted;
	}
}
