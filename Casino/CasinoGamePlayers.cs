using System;
using System.Collections.Generic;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.PlayerScripts;
using UnityEngine.Events;

namespace ScheduleOne.Casino
{
	// Token: 0x020007D5 RID: 2005
	[Token(Token = "0x20007D5")]
	public class CasinoGamePlayers : NetworkBehaviour
	{
		// Token: 0x170007D4 RID: 2004
		// (get) Token: 0x06003640 RID: 13888 RVA: 0x0000EC88 File Offset: 0x0000CE88
		[Token(Token = "0x170007D4")]
		public int CurrentPlayerCount
		{
			[Token(Token = "0x6003640")]
			[Address(RVA = "0x7CC310", Offset = "0x7CAD10", VA = "0x1807CC310")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06003641 RID: 13889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003641")]
		[Address(RVA = "0x7C7CA0", Offset = "0x7C66A0", VA = "0x1807C7CA0", Slot = "19")]
		public virtual void Awake()
		{
		}

		// Token: 0x06003642 RID: 13890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003642")]
		[Address(RVA = "0x7C85E0", Offset = "0x7C6FE0", VA = "0x1807C85E0", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x06003643 RID: 13891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003643")]
		[Address(RVA = "0x7C7B00", Offset = "0x7C6500", VA = "0x1807C7B00")]
		public void AddPlayer(Player player)
		{
		}

		// Token: 0x06003644 RID: 13892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003644")]
		[Address(RVA = "0x7C8E20", Offset = "0x7C7820", VA = "0x1807C8E20")]
		public void RemovePlayer(Player player)
		{
		}

		// Token: 0x06003645 RID: 13893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003645")]
		[Address(RVA = "0x7CC0D0", Offset = "0x7CAAD0", VA = "0x1807CC0D0")]
		public void SetPlayerScore(Player player, int score)
		{
		}

		// Token: 0x06003646 RID: 13894 RVA: 0x0000ECA0 File Offset: 0x0000CEA0
		[Token(Token = "0x6003646")]
		[Address(RVA = "0x7C80F0", Offset = "0x7C6AF0", VA = "0x1807C80F0")]
		public int GetPlayerScore(Player player)
		{
			return 0;
		}

		// Token: 0x06003647 RID: 13895 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003647")]
		[Address(RVA = "0x7C81C0", Offset = "0x7C6BC0", VA = "0x1807C81C0")]
		public Player GetPlayer(int index)
		{
			return null;
		}

		// Token: 0x06003648 RID: 13896 RVA: 0x0000ECB8 File Offset: 0x0000CEB8
		[Token(Token = "0x6003648")]
		[Address(RVA = "0x7C7F40", Offset = "0x7C6940", VA = "0x1807C7F40")]
		public int GetPlayerIndex(Player player)
		{
			return 0;
		}

		// Token: 0x06003649 RID: 13897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003649")]
		[Address(RVA = "0x7C8F70", Offset = "0x7C7970", VA = "0x1807C8F70")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		private void RequestAddPlayer(NetworkObject playerObject)
		{
		}

		// Token: 0x0600364A RID: 13898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600364A")]
		[Address(RVA = "0x7C79E0", Offset = "0x7C63E0", VA = "0x1807C79E0")]
		private void AddPlayerToArray(Player player)
		{
		}

		// Token: 0x0600364B RID: 13899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600364B")]
		[Address(RVA = "0x7C90A0", Offset = "0x7C7AA0", VA = "0x1807C90A0")]
		[ServerRpc(RequireOwnership = false)]
		private void RequestRemovePlayer(NetworkObject playerObject)
		{
		}

		// Token: 0x0600364C RID: 13900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600364C")]
		[Address(RVA = "0x7C8D20", Offset = "0x7C7720", VA = "0x1807C8D20")]
		private void RemovePlayerFromArray(Player player)
		{
		}

		// Token: 0x0600364D RID: 13901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600364D")]
		[Address(RVA = "0x7C91D0", Offset = "0x7C7BD0", VA = "0x1807C91D0")]
		[ServerRpc(RequireOwnership = false)]
		private void RequestSetScore(NetworkObject playerObject, int score)
		{
		}

		// Token: 0x0600364E RID: 13902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600364E")]
		[Address(RVA = "0x7CBE10", Offset = "0x7CA810", VA = "0x1807CBE10")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		private void SetPlayerScore(NetworkConnection conn, NetworkObject playerObject, int score)
		{
		}

		// Token: 0x0600364F RID: 13903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600364F")]
		[Address(RVA = "0x7CBBB0", Offset = "0x7CA5B0", VA = "0x1807CBBB0")]
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		private void SetPlayerList(NetworkConnection conn, NetworkObject[] playerObjects)
		{
		}

		// Token: 0x06003650 RID: 13904 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003650")]
		[Address(RVA = "0x7C7EE0", Offset = "0x7C68E0", VA = "0x1807C7EE0")]
		public CasinoGamePlayerData GetPlayerData()
		{
			return null;
		}

		// Token: 0x06003651 RID: 13905 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003651")]
		[Address(RVA = "0x7C7D20", Offset = "0x7C6720", VA = "0x1807C7D20")]
		public CasinoGamePlayerData GetPlayerData(Player player)
		{
			return null;
		}

		// Token: 0x06003652 RID: 13906 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003652")]
		[Address(RVA = "0x7C7E20", Offset = "0x7C6820", VA = "0x1807C7E20")]
		public CasinoGamePlayerData GetPlayerData(int index)
		{
			return null;
		}

		// Token: 0x06003653 RID: 13907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003653")]
		[Address(RVA = "0x7CB8A0", Offset = "0x7CA2A0", VA = "0x1807CB8A0")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendPlayerBool(NetworkObject playerObject, string key, bool value)
		{
		}

		// Token: 0x06003654 RID: 13908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003654")]
		[Address(RVA = "0x7C8770", Offset = "0x7C7170", VA = "0x1807C8770")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		private void ReceivePlayerBool(NetworkConnection conn, NetworkObject playerObject, string key, bool value)
		{
		}

		// Token: 0x06003655 RID: 13909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003655")]
		[Address(RVA = "0x7CBA20", Offset = "0x7CA420", VA = "0x1807CBA20")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendPlayerFloat(NetworkObject playerObject, string key, float value)
		{
		}

		// Token: 0x06003656 RID: 13910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003656")]
		[Address(RVA = "0x7C8A40", Offset = "0x7C7440", VA = "0x1807C8A40")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		private void ReceivePlayerFloat(NetworkConnection conn, NetworkObject playerObject, string key, float value)
		{
		}

		// Token: 0x06003657 RID: 13911 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003657")]
		[Address(RVA = "0x7C7F90", Offset = "0x7C6990", VA = "0x1807C7F90")]
		private NetworkObject[] GetPlayerObjects()
		{
			return null;
		}

		// Token: 0x06003658 RID: 13912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003658")]
		[Address(RVA = "0x7CC230", Offset = "0x7CAC30", VA = "0x1807CC230")]
		public CasinoGamePlayers()
		{
		}

		// Token: 0x06003659 RID: 13913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003659")]
		[Address(RVA = "0x7C8220", Offset = "0x7C6C20", VA = "0x1807C8220", Slot = "20")]
		public virtual void NetworkInitialize___Early()
		{
		}

		// Token: 0x0600365A RID: 13914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600365A")]
		[Address(RVA = "0x7C8200", Offset = "0x7C6C00", VA = "0x1807C8200", Slot = "21")]
		public virtual void NetworkInitialize__Late()
		{
		}

		// Token: 0x0600365B RID: 13915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600365B")]
		[Address(RVA = "0x6783D0", Offset = "0x676DD0", VA = "0x1806783D0", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x0600365C RID: 13916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600365C")]
		[Address(RVA = "0x7CAF00", Offset = "0x7C9900", VA = "0x1807CAF00")]
		private void RpcWriter___Server_RequestAddPlayer_3323014238(NetworkObject playerObject)
		{
		}

		// Token: 0x0600365D RID: 13917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600365D")]
		[Address(RVA = "0x7C9680", Offset = "0x7C8080", VA = "0x1807C9680")]
		private void RpcLogic___RequestAddPlayer_3323014238(NetworkObject playerObject)
		{
		}

		// Token: 0x0600365E RID: 13918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600365E")]
		[Address(RVA = "0x7CA240", Offset = "0x7C8C40", VA = "0x1807CA240")]
		private void RpcReader___Server_RequestAddPlayer_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x0600365F RID: 13919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600365F")]
		[Address(RVA = "0x7C90A0", Offset = "0x7C7AA0", VA = "0x1807C90A0")]
		private void RpcWriter___Server_RequestRemovePlayer_3323014238(NetworkObject playerObject)
		{
		}

		// Token: 0x06003660 RID: 13920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003660")]
		[Address(RVA = "0x7C9940", Offset = "0x7C8340", VA = "0x1807C9940")]
		private void RpcLogic___RequestRemovePlayer_3323014238(NetworkObject playerObject)
		{
		}

		// Token: 0x06003661 RID: 13921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003661")]
		[Address(RVA = "0x7CA2C0", Offset = "0x7C8CC0", VA = "0x1807CA2C0")]
		private void RpcReader___Server_RequestRemovePlayer_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06003662 RID: 13922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003662")]
		[Address(RVA = "0x7C91D0", Offset = "0x7C7BD0", VA = "0x1807C91D0")]
		private void RpcWriter___Server_RequestSetScore_4172557123(NetworkObject playerObject, int score)
		{
		}

		// Token: 0x06003663 RID: 13923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003663")]
		[Address(RVA = "0x7C9AF0", Offset = "0x7C84F0", VA = "0x1807C9AF0")]
		private void RpcLogic___RequestSetScore_4172557123(NetworkObject playerObject, int score)
		{
		}

		// Token: 0x06003664 RID: 13924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003664")]
		[Address(RVA = "0x7CA490", Offset = "0x7C8E90", VA = "0x1807CA490")]
		private void RpcReader___Server_RequestSetScore_4172557123(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06003665 RID: 13925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003665")]
		[Address(RVA = "0x7CAD80", Offset = "0x7C9780", VA = "0x1807CAD80")]
		private void RpcWriter___Observers_SetPlayerScore_1865307316(NetworkConnection conn, NetworkObject playerObject, int score)
		{
		}

		// Token: 0x06003666 RID: 13926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003666")]
		[Address(RVA = "0x7C9E80", Offset = "0x7C8880", VA = "0x1807C9E80")]
		private void RpcLogic___SetPlayerScore_1865307316(NetworkConnection conn, NetworkObject playerObject, int score)
		{
		}

		// Token: 0x06003667 RID: 13927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003667")]
		[Address(RVA = "0x7CA190", Offset = "0x7C8B90", VA = "0x1807CA190")]
		private void RpcReader___Observers_SetPlayerScore_1865307316(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003668 RID: 13928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003668")]
		[Address(RVA = "0x7CB730", Offset = "0x7CA130", VA = "0x1807CB730")]
		private void RpcWriter___Target_SetPlayerScore_1865307316(NetworkConnection conn, NetworkObject playerObject, int score)
		{
		}

		// Token: 0x06003669 RID: 13929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003669")]
		[Address(RVA = "0x7CA8A0", Offset = "0x7C92A0", VA = "0x1807CA8A0")]
		private void RpcReader___Target_SetPlayerScore_1865307316(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600366A RID: 13930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600366A")]
		[Address(RVA = "0x7CAC40", Offset = "0x7C9640", VA = "0x1807CAC40")]
		private void RpcWriter___Observers_SetPlayerList_204172449(NetworkConnection conn, NetworkObject[] playerObjects)
		{
		}

		// Token: 0x0600366B RID: 13931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600366B")]
		[Address(RVA = "0x7C9B70", Offset = "0x7C8570", VA = "0x1807C9B70")]
		private void RpcLogic___SetPlayerList_204172449(NetworkConnection conn, NetworkObject[] playerObjects)
		{
		}

		// Token: 0x0600366C RID: 13932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600366C")]
		[Address(RVA = "0x7CA130", Offset = "0x7C8B30", VA = "0x1807CA130")]
		private void RpcReader___Observers_SetPlayerList_204172449(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600366D RID: 13933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600366D")]
		[Address(RVA = "0x7CB5D0", Offset = "0x7C9FD0", VA = "0x1807CB5D0")]
		private void RpcWriter___Target_SetPlayerList_204172449(NetworkConnection conn, NetworkObject[] playerObjects)
		{
		}

		// Token: 0x0600366E RID: 13934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600366E")]
		[Address(RVA = "0x7CA840", Offset = "0x7C9240", VA = "0x1807CA840")]
		private void RpcReader___Target_SetPlayerList_204172449(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600366F RID: 13935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600366F")]
		[Address(RVA = "0x7CB030", Offset = "0x7C9A30", VA = "0x1807CB030")]
		private void RpcWriter___Server_SendPlayerBool_77262511(NetworkObject playerObject, string key, bool value)
		{
		}

		// Token: 0x06003670 RID: 13936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003670")]
		[Address(RVA = "0x7C9B10", Offset = "0x7C8510", VA = "0x1807C9B10")]
		public void RpcLogic___SendPlayerBool_77262511(NetworkObject playerObject, string key, bool value)
		{
		}

		// Token: 0x06003671 RID: 13937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003671")]
		[Address(RVA = "0x7CA520", Offset = "0x7C8F20", VA = "0x1807CA520")]
		private void RpcReader___Server_SendPlayerBool_77262511(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06003672 RID: 13938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003672")]
		[Address(RVA = "0x7CA940", Offset = "0x7C9340", VA = "0x1807CA940")]
		private void RpcWriter___Observers_ReceivePlayerBool_1748594478(NetworkConnection conn, NetworkObject playerObject, string key, bool value)
		{
		}

		// Token: 0x06003673 RID: 13939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003673")]
		[Address(RVA = "0x7C9340", Offset = "0x7C7D40", VA = "0x1807C9340")]
		private void RpcLogic___ReceivePlayerBool_1748594478(NetworkConnection conn, NetworkObject playerObject, string key, bool value)
		{
		}

		// Token: 0x06003674 RID: 13940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003674")]
		[Address(RVA = "0x7C9FA0", Offset = "0x7C89A0", VA = "0x1807C9FA0")]
		private void RpcReader___Observers_ReceivePlayerBool_1748594478(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003675 RID: 13941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003675")]
		[Address(RVA = "0x7CB2F0", Offset = "0x7C9CF0", VA = "0x1807CB2F0")]
		private void RpcWriter___Target_ReceivePlayerBool_1748594478(NetworkConnection conn, NetworkObject playerObject, string key, bool value)
		{
		}

		// Token: 0x06003676 RID: 13942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003676")]
		[Address(RVA = "0x7CA6C0", Offset = "0x7C90C0", VA = "0x1807CA6C0")]
		private void RpcReader___Target_ReceivePlayerBool_1748594478(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003677 RID: 13943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003677")]
		[Address(RVA = "0x7CB190", Offset = "0x7C9B90", VA = "0x1807CB190")]
		private void RpcWriter___Server_SendPlayerFloat_2931762093(NetworkObject playerObject, string key, float value)
		{
		}

		// Token: 0x06003678 RID: 13944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003678")]
		[Address(RVA = "0x7C9B40", Offset = "0x7C8540", VA = "0x1807C9B40")]
		public void RpcLogic___SendPlayerFloat_2931762093(NetworkObject playerObject, string key, float value)
		{
		}

		// Token: 0x06003679 RID: 13945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003679")]
		[Address(RVA = "0x7CA600", Offset = "0x7C9000", VA = "0x1807CA600")]
		private void RpcReader___Server_SendPlayerFloat_2931762093(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x0600367A RID: 13946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600367A")]
		[Address(RVA = "0x7CAAC0", Offset = "0x7C94C0", VA = "0x1807CAAC0")]
		private void RpcWriter___Observers_ReceivePlayerFloat_2317689966(NetworkConnection conn, NetworkObject playerObject, string key, float value)
		{
		}

		// Token: 0x0600367B RID: 13947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600367B")]
		[Address(RVA = "0x7C94E0", Offset = "0x7C7EE0", VA = "0x1807C94E0")]
		private void RpcLogic___ReceivePlayerFloat_2317689966(NetworkConnection conn, NetworkObject playerObject, string key, float value)
		{
		}

		// Token: 0x0600367C RID: 13948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600367C")]
		[Address(RVA = "0x7CA070", Offset = "0x7C8A70", VA = "0x1807CA070")]
		private void RpcReader___Observers_ReceivePlayerFloat_2317689966(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600367D RID: 13949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600367D")]
		[Address(RVA = "0x7CB460", Offset = "0x7C9E60", VA = "0x1807CB460")]
		private void RpcWriter___Target_ReceivePlayerFloat_2317689966(NetworkConnection conn, NetworkObject playerObject, string key, float value)
		{
		}

		// Token: 0x0600367E RID: 13950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600367E")]
		[Address(RVA = "0x7CA790", Offset = "0x7C9190", VA = "0x1807CA790")]
		private void RpcReader___Target_ReceivePlayerFloat_2317689966(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600367F RID: 13951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600367F")]
		[Address(RVA = "0x7C7C40", Offset = "0x7C6640", VA = "0x1807C7C40")]
		private void Awake_UserLogic_ScheduleOne.Casino.CasinoGamePlayers_Assembly-CSharp.dll()
		{
		}

		// Token: 0x040025CF RID: 9679
		[Token(Token = "0x40025CF")]
		[FieldOffset(Offset = "0x118")]
		public int PlayerLimit;

		// Token: 0x040025D0 RID: 9680
		[Token(Token = "0x40025D0")]
		[FieldOffset(Offset = "0x120")]
		private Player[] Players;

		// Token: 0x040025D1 RID: 9681
		[Token(Token = "0x40025D1")]
		[FieldOffset(Offset = "0x128")]
		public UnityEvent onPlayerListChanged;

		// Token: 0x040025D2 RID: 9682
		[Token(Token = "0x40025D2")]
		[FieldOffset(Offset = "0x130")]
		public UnityEvent onPlayerScoresChanged;

		// Token: 0x040025D3 RID: 9683
		[Token(Token = "0x40025D3")]
		[FieldOffset(Offset = "0x138")]
		private Dictionary<Player, int> playerScores;

		// Token: 0x040025D4 RID: 9684
		[Token(Token = "0x40025D4")]
		[FieldOffset(Offset = "0x140")]
		private Dictionary<Player, CasinoGamePlayerData> playerDatas;

		// Token: 0x040025D5 RID: 9685
		[Token(Token = "0x40025D5")]
		[FieldOffset(Offset = "0x148")]
		private bool NetworkInitialize___EarlyScheduleOne.Casino.CasinoGamePlayersAssembly-CSharp.dll_Excuted;

		// Token: 0x040025D6 RID: 9686
		[Token(Token = "0x40025D6")]
		[FieldOffset(Offset = "0x149")]
		private bool NetworkInitialize__LateScheduleOne.Casino.CasinoGamePlayersAssembly-CSharp.dll_Excuted;
	}
}
