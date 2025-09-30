using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using Steamworks;

namespace ScheduleOne.Networking
{
	// Token: 0x020004A3 RID: 1187
	[Token(Token = "0x20004A3")]
	public class Lobby : PersistentSingleton<Lobby>
	{
		// Token: 0x17000430 RID: 1072
		// (get) Token: 0x06001731 RID: 5937 RVA: 0x00008AC0 File Offset: 0x00006CC0
		[Token(Token = "0x17000430")]
		public bool IsHost
		{
			[Token(Token = "0x6001731")]
			[Address(RVA = "0x5EB170", Offset = "0x5E9B70", VA = "0x1805EB170")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x06001732 RID: 5938 RVA: 0x00008AD8 File Offset: 0x00006CD8
		// (set) Token: 0x06001733 RID: 5939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000431")]
		public ulong LobbyID
		{
			[Token(Token = "0x6001732")]
			[Address(RVA = "0x4423C0", Offset = "0x440DC0", VA = "0x1804423C0")]
			[CompilerGenerated]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6001733")]
			[Address(RVA = "0x5EB350", Offset = "0x5E9D50", VA = "0x1805EB350")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x06001734 RID: 5940 RVA: 0x00008AF0 File Offset: 0x00006CF0
		[Token(Token = "0x17000432")]
		public CSteamID LobbySteamID
		{
			[Token(Token = "0x6001734")]
			[Address(RVA = "0x4423C0", Offset = "0x440DC0", VA = "0x1804423C0")]
			get
			{
				return default(CSteamID);
			}
		}

		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x06001735 RID: 5941 RVA: 0x00008B08 File Offset: 0x00006D08
		[Token(Token = "0x17000433")]
		public bool IsInLobby
		{
			[Token(Token = "0x6001735")]
			[Address(RVA = "0x5EB210", Offset = "0x5E9C10", VA = "0x1805EB210")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x06001736 RID: 5942 RVA: 0x00008B20 File Offset: 0x00006D20
		[Token(Token = "0x17000434")]
		public int PlayerCount
		{
			[Token(Token = "0x6001736")]
			[Address(RVA = "0x5EB220", Offset = "0x5E9C20", VA = "0x1805EB220")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x06001737 RID: 5943 RVA: 0x00008B38 File Offset: 0x00006D38
		// (set) Token: 0x06001738 RID: 5944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000435")]
		public CSteamID LocalPlayerID
		{
			[Token(Token = "0x6001737")]
			[Address(RVA = "0x4423A0", Offset = "0x440DA0", VA = "0x1804423A0")]
			[CompilerGenerated]
			get
			{
				return default(CSteamID);
			}
			[Token(Token = "0x6001738")]
			[Address(RVA = "0x5EB360", Offset = "0x5E9D60", VA = "0x1805EB360")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06001739 RID: 5945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001739")]
		[Address(RVA = "0x5E98E0", Offset = "0x5E82E0", VA = "0x1805E98E0", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x0600173A RID: 5946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600173A")]
		[Address(RVA = "0x5EABC0", Offset = "0x5E95C0", VA = "0x1805EABC0", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x0600173B RID: 5947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600173B")]
		[Address(RVA = "0x5E9B20", Offset = "0x5E8520", VA = "0x1805E9B20")]
		private void InitializeCallbacks()
		{
		}

		// Token: 0x0600173C RID: 5948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600173C")]
		[Address(RVA = "0x5EAED0", Offset = "0x5E98D0", VA = "0x1805EAED0")]
		public void TryOpenInviteInterface()
		{
		}

		// Token: 0x0600173D RID: 5949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600173D")]
		[Address(RVA = "0x5E9DE0", Offset = "0x5E87E0", VA = "0x1805E9DE0")]
		public void LeaveLobby()
		{
		}

		// Token: 0x0600173E RID: 5950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600173E")]
		[Address(RVA = "0x5E9A10", Offset = "0x5E8410", VA = "0x1805E9A10")]
		private void CreateLobby()
		{
		}

		// Token: 0x0600173F RID: 5951 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600173F")]
		[Address(RVA = "0x5E9A30", Offset = "0x5E8430", VA = "0x1805E9A30")]
		private string GetLaunchLobby()
		{
			return null;
		}

		// Token: 0x06001740 RID: 5952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001740")]
		[Address(RVA = "0x5EAFA0", Offset = "0x5E99A0", VA = "0x1805EAFA0")]
		private void UpdateLobbyMembers()
		{
		}

		// Token: 0x06001741 RID: 5953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001741")]
		[Address(RVA = "0x5E9D50", Offset = "0x5E8750", VA = "0x1805E9D50")]
		public void JoinAsClient(string steamId64)
		{
		}

		// Token: 0x06001742 RID: 5954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001742")]
		[Address(RVA = "0x5EAA60", Offset = "0x5E9460", VA = "0x1805EAA60")]
		public void SendLobbyMessage(string message)
		{
		}

		// Token: 0x06001743 RID: 5955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001743")]
		[Address(RVA = "0x5EAB20", Offset = "0x5E9520", VA = "0x1805EAB20")]
		public void SetLobbyData(string key, string value)
		{
		}

		// Token: 0x06001744 RID: 5956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001744")]
		[Address(RVA = "0x5EA280", Offset = "0x5E8C80", VA = "0x1805EA280")]
		private void OnLobbyCreated(LobbyCreated_t result)
		{
		}

		// Token: 0x06001745 RID: 5957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001745")]
		[Address(RVA = "0x5EA4F0", Offset = "0x5E8EF0", VA = "0x1805EA4F0")]
		private void OnLobbyEntered(LobbyEnter_t result)
		{
		}

		// Token: 0x06001746 RID: 5958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001746")]
		[Address(RVA = "0x5EA950", Offset = "0x5E9350", VA = "0x1805EA950")]
		private void PlayerEnterOrLeave(LobbyChatUpdate_t result)
		{
		}

		// Token: 0x06001747 RID: 5959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001747")]
		[Address(RVA = "0x5E9EC0", Offset = "0x5E88C0", VA = "0x1805E9EC0")]
		private void LobbyJoinRequested(GameLobbyJoinRequested_t result)
		{
		}

		// Token: 0x06001748 RID: 5960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001748")]
		[Address(RVA = "0x5E9FA0", Offset = "0x5E89A0", VA = "0x1805E9FA0")]
		private void OnLobbyChatMessage(LobbyChatMsg_t result)
		{
		}

		// Token: 0x06001749 RID: 5961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001749")]
		[Address(RVA = "0x5EB0D0", Offset = "0x5E9AD0", VA = "0x1805EB0D0")]
		public Lobby()
		{
		}

		// Token: 0x0400153A RID: 5434
		[Token(Token = "0x400153A")]
		public const bool ENABLED = true;

		// Token: 0x0400153B RID: 5435
		[Token(Token = "0x400153B")]
		public const int PLAYER_LIMIT = 4;

		// Token: 0x0400153C RID: 5436
		[Token(Token = "0x400153C")]
		public const string JOIN_READY = "ready";

		// Token: 0x0400153D RID: 5437
		[Token(Token = "0x400153D")]
		public const string LOAD_TUTORIAL = "load_tutorial";

		// Token: 0x0400153E RID: 5438
		[Token(Token = "0x400153E")]
		public const string HOST_LOADING = "host_loading";

		// Token: 0x04001541 RID: 5441
		[Token(Token = "0x4001541")]
		[FieldOffset(Offset = "0x38")]
		public CSteamID[] Players;

		// Token: 0x04001542 RID: 5442
		[Token(Token = "0x4001542")]
		[FieldOffset(Offset = "0x40")]
		public Action onLobbyChange;

		// Token: 0x04001543 RID: 5443
		[Token(Token = "0x4001543")]
		[FieldOffset(Offset = "0x48")]
		private Callback<LobbyCreated_t> LobbyCreatedCallback;

		// Token: 0x04001544 RID: 5444
		[Token(Token = "0x4001544")]
		[FieldOffset(Offset = "0x50")]
		private Callback<LobbyEnter_t> LobbyEnteredCallback;

		// Token: 0x04001545 RID: 5445
		[Token(Token = "0x4001545")]
		[FieldOffset(Offset = "0x58")]
		private Callback<LobbyChatUpdate_t> ChatUpdateCallback;

		// Token: 0x04001546 RID: 5446
		[Token(Token = "0x4001546")]
		[FieldOffset(Offset = "0x60")]
		private Callback<GameLobbyJoinRequested_t> GameLobbyJoinRequestedCallback;

		// Token: 0x04001547 RID: 5447
		[Token(Token = "0x4001547")]
		[FieldOffset(Offset = "0x68")]
		private Callback<LobbyChatMsg_t> LobbyChatMessageCallback;
	}
}
