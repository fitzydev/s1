using System;
using System.Collections.Generic;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.NPCs;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.UI.Phone.Messages;

namespace ScheduleOne.Messaging
{
	// Token: 0x020004AE RID: 1198
	[Token(Token = "0x20004AE")]
	public class MessagingManager : NetworkSingleton<MessagingManager>
	{
		// Token: 0x06001760 RID: 5984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001760")]
		[Address(RVA = "0x5EB7D0", Offset = "0x5EA1D0", VA = "0x1805EB7D0", Slot = "20")]
		public override void Awake()
		{
		}

		// Token: 0x06001761 RID: 5985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001761")]
		[Address(RVA = "0x5EBEA0", Offset = "0x5EA8A0", VA = "0x1805EBEA0", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x06001762 RID: 5986 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001762")]
		[Address(RVA = "0x5EB970", Offset = "0x5EA370", VA = "0x1805EB970")]
		public MSGConversation GetConversation(NPC npc)
		{
			return null;
		}

		// Token: 0x06001763 RID: 5987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001763")]
		[Address(RVA = "0x5ECA00", Offset = "0x5EB400", VA = "0x1805ECA00")]
		public void Register(NPC npc, MSGConversation convs)
		{
		}

		// Token: 0x06001764 RID: 5988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001764")]
		[Address(RVA = "0x5EF0D0", Offset = "0x5EDAD0", VA = "0x1805EF0D0")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendMessage(Message m, bool notify, string npcID)
		{
		}

		// Token: 0x06001765 RID: 5989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001765")]
		[Address(RVA = "0x5EC3C0", Offset = "0x5EADC0", VA = "0x1805EC3C0")]
		[ObserversRpc(RunLocally = true)]
		private void ReceiveMessage(Message m, bool notify, string npcID)
		{
		}

		// Token: 0x06001766 RID: 5990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001766")]
		[Address(RVA = "0x5EEF30", Offset = "0x5ED930", VA = "0x1805EEF30")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendMessageChain(MessageChain m, string npcID, float initialDelay, bool notify)
		{
		}

		// Token: 0x06001767 RID: 5991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001767")]
		[Address(RVA = "0x5EC200", Offset = "0x5EAC00", VA = "0x1805EC200")]
		[ObserversRpc(RunLocally = true)]
		private void ReceiveMessageChain(MessageChain m, string npcID, float initialDelay, bool notify)
		{
		}

		// Token: 0x06001768 RID: 5992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001768")]
		[Address(RVA = "0x5EF3F0", Offset = "0x5EDDF0", VA = "0x1805EF3F0")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendResponse(int responseIndex, string npcID)
		{
		}

		// Token: 0x06001769 RID: 5993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001769")]
		[Address(RVA = "0x5EC700", Offset = "0x5EB100", VA = "0x1805EC700")]
		[ObserversRpc(RunLocally = true)]
		private void ReceiveResponse(int responseIndex, string npcID)
		{
		}

		// Token: 0x0600176A RID: 5994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600176A")]
		[Address(RVA = "0x5EF250", Offset = "0x5EDC50", VA = "0x1805EF250")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendPlayerMessage(int sendableIndex, int sentIndex, string npcID)
		{
		}

		// Token: 0x0600176B RID: 5995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600176B")]
		[Address(RVA = "0x5EC550", Offset = "0x5EAF50", VA = "0x1805EC550")]
		[ObserversRpc(RunLocally = true)]
		private void ReceivePlayerMessage(int sendableIndex, int sentIndex, string npcID)
		{
		}

		// Token: 0x0600176C RID: 5996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600176C")]
		[Address(RVA = "0x5EC0A0", Offset = "0x5EAAA0", VA = "0x1805EC0A0")]
		[TargetRpc]
		private void ReceiveMSGConversationData(NetworkConnection conn, string npcID, MSGConversationData data)
		{
		}

		// Token: 0x0600176D RID: 5997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600176D")]
		[Address(RVA = "0x5EB840", Offset = "0x5EA240", VA = "0x1805EB840")]
		[ServerRpc(RequireOwnership = false)]
		public void ClearResponses(string npcID)
		{
		}

		// Token: 0x0600176E RID: 5998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600176E")]
		[Address(RVA = "0x5EBF60", Offset = "0x5EA960", VA = "0x1805EBF60")]
		[ObserversRpc]
		private void ReceiveClearResponses(string npcID)
		{
		}

		// Token: 0x0600176F RID: 5999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600176F")]
		[Address(RVA = "0x5EF550", Offset = "0x5EDF50", VA = "0x1805EF550")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void ShowResponses(string npcID, List<Response> responses, float delay)
		{
		}

		// Token: 0x06001770 RID: 6000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001770")]
		[Address(RVA = "0x5EC870", Offset = "0x5EB270", VA = "0x1805EC870")]
		[ObserversRpc(RunLocally = true)]
		private void ReceiveShowResponses(string npcID, List<Response> responses, float delay)
		{
		}

		// Token: 0x06001771 RID: 6001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001771")]
		[Address(RVA = "0x5EF6D0", Offset = "0x5EE0D0", VA = "0x1805EF6D0")]
		public MessagingManager()
		{
		}

		// Token: 0x06001772 RID: 6002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001772")]
		[Address(RVA = "0x5EBAC0", Offset = "0x5EA4C0", VA = "0x1805EBAC0", Slot = "22")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06001773 RID: 6003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001773")]
		[Address(RVA = "0x5EBA70", Offset = "0x5EA470", VA = "0x1805EBA70", Slot = "23")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06001774 RID: 6004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001774")]
		[Address(RVA = "0x5B3020", Offset = "0x5B1A20", VA = "0x1805B3020", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06001775 RID: 6005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001775")]
		[Address(RVA = "0x5EE980", Offset = "0x5ED380", VA = "0x1805EE980")]
		private void RpcWriter___Server_SendMessage_2134336246(Message m, bool notify, string npcID)
		{
		}

		// Token: 0x06001776 RID: 6006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001776")]
		[Address(RVA = "0x5EC3C0", Offset = "0x5EADC0", VA = "0x1805EC3C0")]
		public void RpcLogic___SendMessage_2134336246(Message m, bool notify, string npcID)
		{
		}

		// Token: 0x06001777 RID: 6007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001777")]
		[Address(RVA = "0x5EDC20", Offset = "0x5EC620", VA = "0x1805EDC20")]
		private void RpcReader___Server_SendMessage_2134336246(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06001778 RID: 6008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001778")]
		[Address(RVA = "0x5EE220", Offset = "0x5ECC20", VA = "0x1805EE220")]
		private void RpcWriter___Observers_ReceiveMessage_2134336246(Message m, bool notify, string npcID)
		{
		}

		// Token: 0x06001779 RID: 6009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001779")]
		[Address(RVA = "0x5ECEF0", Offset = "0x5EB8F0", VA = "0x1805ECEF0")]
		private void RpcLogic___ReceiveMessage_2134336246(Message m, bool notify, string npcID)
		{
		}

		// Token: 0x0600177A RID: 6010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600177A")]
		[Address(RVA = "0x5ED720", Offset = "0x5EC120", VA = "0x1805ED720")]
		private void RpcReader___Observers_ReceiveMessage_2134336246(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600177B RID: 6011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600177B")]
		[Address(RVA = "0x5EE810", Offset = "0x5ED210", VA = "0x1805EE810")]
		private void RpcWriter___Server_SendMessageChain_3949292778(MessageChain m, string npcID, float initialDelay, bool notify)
		{
		}

		// Token: 0x0600177C RID: 6012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600177C")]
		[Address(RVA = "0x5EC200", Offset = "0x5EAC00", VA = "0x1805EC200")]
		public void RpcLogic___SendMessageChain_3949292778(MessageChain m, string npcID, float initialDelay, bool notify)
		{
		}

		// Token: 0x0600177D RID: 6013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600177D")]
		[Address(RVA = "0x5EDB30", Offset = "0x5EC530", VA = "0x1805EDB30")]
		private void RpcReader___Server_SendMessageChain_3949292778(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x0600177E RID: 6014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600177E")]
		[Address(RVA = "0x5EE0A0", Offset = "0x5ECAA0", VA = "0x1805EE0A0")]
		private void RpcWriter___Observers_ReceiveMessageChain_3949292778(MessageChain m, string npcID, float initialDelay, bool notify)
		{
		}

		// Token: 0x0600177F RID: 6015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600177F")]
		[Address(RVA = "0x5ECD90", Offset = "0x5EB790", VA = "0x1805ECD90")]
		private void RpcLogic___ReceiveMessageChain_3949292778(MessageChain m, string npcID, float initialDelay, bool notify)
		{
		}

		// Token: 0x06001780 RID: 6016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001780")]
		[Address(RVA = "0x5ED640", Offset = "0x5EC040", VA = "0x1805ED640")]
		private void RpcReader___Observers_ReceiveMessageChain_3949292778(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001781 RID: 6017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001781")]
		[Address(RVA = "0x5EEC60", Offset = "0x5ED660", VA = "0x1805EEC60")]
		private void RpcWriter___Server_SendResponse_2801973956(int responseIndex, string npcID)
		{
		}

		// Token: 0x06001782 RID: 6018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001782")]
		[Address(RVA = "0x5EC700", Offset = "0x5EB100", VA = "0x1805EC700")]
		public void RpcLogic___SendResponse_2801973956(int responseIndex, string npcID)
		{
		}

		// Token: 0x06001783 RID: 6019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001783")]
		[Address(RVA = "0x5EDDC0", Offset = "0x5EC7C0", VA = "0x1805EDDC0")]
		private void RpcReader___Server_SendResponse_2801973956(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06001784 RID: 6020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001784")]
		[Address(RVA = "0x5EE520", Offset = "0x5ECF20", VA = "0x1805EE520")]
		private void RpcWriter___Observers_ReceiveResponse_2801973956(int responseIndex, string npcID)
		{
		}

		// Token: 0x06001785 RID: 6021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001785")]
		[Address(RVA = "0x5ED1B0", Offset = "0x5EBBB0", VA = "0x1805ED1B0")]
		private void RpcLogic___ReceiveResponse_2801973956(int responseIndex, string npcID)
		{
		}

		// Token: 0x06001786 RID: 6022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001786")]
		[Address(RVA = "0x5ED890", Offset = "0x5EC290", VA = "0x1805ED890")]
		private void RpcReader___Observers_ReceiveResponse_2801973956(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001787 RID: 6023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001787")]
		[Address(RVA = "0x5EEAE0", Offset = "0x5ED4E0", VA = "0x1805EEAE0")]
		private void RpcWriter___Server_SendPlayerMessage_1952281135(int sendableIndex, int sentIndex, string npcID)
		{
		}

		// Token: 0x06001788 RID: 6024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001788")]
		[Address(RVA = "0x5EC550", Offset = "0x5EAF50", VA = "0x1805EC550")]
		public void RpcLogic___SendPlayerMessage_1952281135(int sendableIndex, int sentIndex, string npcID)
		{
		}

		// Token: 0x06001789 RID: 6025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001789")]
		[Address(RVA = "0x5EDCF0", Offset = "0x5EC6F0", VA = "0x1805EDCF0")]
		private void RpcReader___Server_SendPlayerMessage_1952281135(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x0600178A RID: 6026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600178A")]
		[Address(RVA = "0x5EE390", Offset = "0x5ECD90", VA = "0x1805EE390")]
		private void RpcWriter___Observers_ReceivePlayerMessage_1952281135(int sendableIndex, int sentIndex, string npcID)
		{
		}

		// Token: 0x0600178B RID: 6027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600178B")]
		[Address(RVA = "0x5ED050", Offset = "0x5EBA50", VA = "0x1805ED050")]
		private void RpcLogic___ReceivePlayerMessage_1952281135(int sendableIndex, int sentIndex, string npcID)
		{
		}

		// Token: 0x0600178C RID: 6028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600178C")]
		[Address(RVA = "0x5ED7D0", Offset = "0x5EC1D0", VA = "0x1805ED7D0")]
		private void RpcReader___Observers_ReceivePlayerMessage_1952281135(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600178D RID: 6029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600178D")]
		[Address(RVA = "0x5EC0A0", Offset = "0x5EAAA0", VA = "0x1805EC0A0")]
		private void RpcWriter___Target_ReceiveMSGConversationData_2662241369(NetworkConnection conn, string npcID, MSGConversationData data)
		{
		}

		// Token: 0x0600178E RID: 6030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600178E")]
		[Address(RVA = "0x5ECC50", Offset = "0x5EB650", VA = "0x1805ECC50")]
		private void RpcLogic___ReceiveMSGConversationData_2662241369(NetworkConnection conn, string npcID, MSGConversationData data)
		{
		}

		// Token: 0x0600178F RID: 6031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600178F")]
		[Address(RVA = "0x5EDF20", Offset = "0x5EC920", VA = "0x1805EDF20")]
		private void RpcReader___Target_ReceiveMSGConversationData_2662241369(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001790 RID: 6032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001790")]
		[Address(RVA = "0x5EB840", Offset = "0x5EA240", VA = "0x1805EB840")]
		private void RpcWriter___Server_ClearResponses_3615296227(string npcID)
		{
		}

		// Token: 0x06001791 RID: 6033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001791")]
		[Address(RVA = "0x5EBF60", Offset = "0x5EA960", VA = "0x1805EBF60")]
		public void RpcLogic___ClearResponses_3615296227(string npcID)
		{
		}

		// Token: 0x06001792 RID: 6034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001792")]
		[Address(RVA = "0x5ED9C0", Offset = "0x5EC3C0", VA = "0x1805ED9C0")]
		private void RpcReader___Server_ClearResponses_3615296227(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06001793 RID: 6035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001793")]
		[Address(RVA = "0x5EBF60", Offset = "0x5EA960", VA = "0x1805EBF60")]
		private void RpcWriter___Observers_ReceiveClearResponses_3615296227(string npcID)
		{
		}

		// Token: 0x06001794 RID: 6036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001794")]
		[Address(RVA = "0x5ECB10", Offset = "0x5EB510", VA = "0x1805ECB10")]
		private void RpcLogic___ReceiveClearResponses_3615296227(string npcID)
		{
		}

		// Token: 0x06001795 RID: 6037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001795")]
		[Address(RVA = "0x5ED4E0", Offset = "0x5EBEE0", VA = "0x1805ED4E0")]
		private void RpcReader___Observers_ReceiveClearResponses_3615296227(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001796 RID: 6038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001796")]
		[Address(RVA = "0x5EEDD0", Offset = "0x5ED7D0", VA = "0x1805EEDD0")]
		private void RpcWriter___Server_ShowResponses_995803534(string npcID, List<Response> responses, float delay)
		{
		}

		// Token: 0x06001797 RID: 6039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001797")]
		[Address(RVA = "0x5EC870", Offset = "0x5EB270", VA = "0x1805EC870")]
		public void RpcLogic___ShowResponses_995803534(string npcID, List<Response> responses, float delay)
		{
		}

		// Token: 0x06001798 RID: 6040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001798")]
		[Address(RVA = "0x5EDE60", Offset = "0x5EC860", VA = "0x1805EDE60")]
		private void RpcReader___Server_ShowResponses_995803534(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06001799 RID: 6041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001799")]
		[Address(RVA = "0x5EE6A0", Offset = "0x5ED0A0", VA = "0x1805EE6A0")]
		private void RpcWriter___Observers_ReceiveShowResponses_995803534(string npcID, List<Response> responses, float delay)
		{
		}

		// Token: 0x0600179A RID: 6042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600179A")]
		[Address(RVA = "0x5ED390", Offset = "0x5EBD90", VA = "0x1805ED390")]
		private void RpcLogic___ReceiveShowResponses_995803534(string npcID, List<Response> responses, float delay)
		{
		}

		// Token: 0x0600179B RID: 6043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600179B")]
		[Address(RVA = "0x5ED920", Offset = "0x5EC320", VA = "0x1805ED920")]
		private void RpcReader___Observers_ReceiveShowResponses_995803534(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600179C RID: 6044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600179C")]
		[Address(RVA = "0x5EB790", Offset = "0x5EA190", VA = "0x1805EB790", Slot = "25")]
		protected virtual void Awake_UserLogic_ScheduleOne.Messaging.MessagingManager_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04001559 RID: 5465
		[Token(Token = "0x4001559")]
		[FieldOffset(Offset = "0x120")]
		protected Dictionary<NPC, MSGConversation> ConversationMap;

		// Token: 0x0400155A RID: 5466
		[Token(Token = "0x400155A")]
		[FieldOffset(Offset = "0x128")]
		private bool NetworkInitialize___EarlyScheduleOne.Messaging.MessagingManagerAssembly-CSharp.dll_Excuted;

		// Token: 0x0400155B RID: 5467
		[Token(Token = "0x400155B")]
		[FieldOffset(Offset = "0x129")]
		private bool NetworkInitialize__LateScheduleOne.Messaging.MessagingManagerAssembly-CSharp.dll_Excuted;
	}
}
