using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using ScheduleOne.Persistence.Datas;

namespace ScheduleOne.Management
{
	// Token: 0x020004C9 RID: 1225
	[Token(Token = "0x20004C9")]
	public class ConfigurationReplicator : NetworkBehaviour
	{
		// Token: 0x0600182C RID: 6188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600182C")]
		[Address(RVA = "0x602BE0", Offset = "0x6015E0", VA = "0x180602BE0")]
		public void ReplicateField(ConfigField field, [Optional] NetworkConnection conn)
		{
		}

		// Token: 0x0600182D RID: 6189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600182D")]
		[Address(RVA = "0x605C90", Offset = "0x604690", VA = "0x180605C90")]
		[ServerRpc(RequireOwnership = false)]
		private void SendItemField(int fieldIndex, string value)
		{
		}

		// Token: 0x0600182E RID: 6190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600182E")]
		[Address(RVA = "0x601FF0", Offset = "0x6009F0", VA = "0x180601FF0")]
		[ObserversRpc]
		private void ReceiveItemField(int fieldIndex, string value)
		{
		}

		// Token: 0x0600182F RID: 6191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600182F")]
		[Address(RVA = "0x605E00", Offset = "0x604800", VA = "0x180605E00")]
		[ServerRpc(RequireOwnership = false)]
		private void SendNPCField(int fieldIndex, NetworkObject npcObject)
		{
		}

		// Token: 0x06001830 RID: 6192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001830")]
		[Address(RVA = "0x602170", Offset = "0x600B70", VA = "0x180602170")]
		[ObserversRpc]
		private void ReceiveNPCField(int fieldIndex, NetworkObject npcObject)
		{
		}

		// Token: 0x06001831 RID: 6193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001831")]
		[Address(RVA = "0x6060E0", Offset = "0x604AE0", VA = "0x1806060E0")]
		[ServerRpc(RequireOwnership = false)]
		private void SendObjectField(int fieldIndex, NetworkObject obj)
		{
		}

		// Token: 0x06001832 RID: 6194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001832")]
		[Address(RVA = "0x602470", Offset = "0x600E70", VA = "0x180602470")]
		[ObserversRpc]
		private void ReceiveObjectField(int fieldIndex, NetworkObject obj)
		{
		}

		// Token: 0x06001833 RID: 6195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001833")]
		[Address(RVA = "0x606250", Offset = "0x604C50", VA = "0x180606250")]
		[ServerRpc(RequireOwnership = false)]
		private void SendObjectListField(int fieldIndex, List<NetworkObject> objects)
		{
		}

		// Token: 0x06001834 RID: 6196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001834")]
		[Address(RVA = "0x6025F0", Offset = "0x600FF0", VA = "0x1806025F0")]
		[ObserversRpc]
		private void ReceiveObjectListField(int fieldIndex, List<NetworkObject> objects)
		{
		}

		// Token: 0x06001835 RID: 6197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001835")]
		[Address(RVA = "0x606530", Offset = "0x604F30", VA = "0x180606530")]
		[ServerRpc(RequireOwnership = false)]
		private void SendRecipeField(int fieldIndex, int recipeIndex)
		{
		}

		// Token: 0x06001836 RID: 6198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001836")]
		[Address(RVA = "0x6028E0", Offset = "0x6012E0", VA = "0x1806028E0")]
		[ObserversRpc]
		private void ReceiveRecipeField(int fieldIndex, int recipeIndex)
		{
		}

		// Token: 0x06001837 RID: 6199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001837")]
		[Address(RVA = "0x605F70", Offset = "0x604970", VA = "0x180605F70")]
		[ServerRpc(RequireOwnership = false)]
		private void SendNumberField(int fieldIndex, float value)
		{
		}

		// Token: 0x06001838 RID: 6200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001838")]
		[Address(RVA = "0x6022F0", Offset = "0x600CF0", VA = "0x1806022F0")]
		[ObserversRpc]
		private void ReceiveNumberField(int fieldIndex, float value)
		{
		}

		// Token: 0x06001839 RID: 6201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001839")]
		[Address(RVA = "0x6066B0", Offset = "0x6050B0", VA = "0x1806066B0")]
		[ServerRpc(RequireOwnership = false)]
		private void SendRouteListField(int fieldIndex, AdvancedTransitRouteData[] value)
		{
		}

		// Token: 0x0600183A RID: 6202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600183A")]
		[Address(RVA = "0x602A60", Offset = "0x601460", VA = "0x180602A60")]
		[ObserversRpc]
		private void ReceiveRouteListField(int fieldIndex, AdvancedTransitRouteData[] value)
		{
		}

		// Token: 0x0600183B RID: 6203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600183B")]
		[Address(RVA = "0x6063C0", Offset = "0x604DC0", VA = "0x1806063C0")]
		[ServerRpc(RequireOwnership = false)]
		private void SendQualityField(int fieldIndex, EQuality quality)
		{
		}

		// Token: 0x0600183C RID: 6204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600183C")]
		[Address(RVA = "0x602770", Offset = "0x601170", VA = "0x180602770")]
		[ObserversRpc]
		private void ReceiveQualityField(int fieldIndex, EQuality value)
		{
		}

		// Token: 0x0600183D RID: 6205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600183D")]
		[Address(RVA = "0x606820", Offset = "0x605220", VA = "0x180606820")]
		public ConfigurationReplicator()
		{
		}

		// Token: 0x0600183E RID: 6206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600183E")]
		[Address(RVA = "0x601B60", Offset = "0x600560", VA = "0x180601B60", Slot = "19")]
		public virtual void NetworkInitialize___Early()
		{
		}

		// Token: 0x0600183F RID: 6207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600183F")]
		[Address(RVA = "0x601B40", Offset = "0x600540", VA = "0x180601B40", Slot = "20")]
		public virtual void NetworkInitialize__Late()
		{
		}

		// Token: 0x06001840 RID: 6208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001840")]
		[Address(RVA = "0x601B00", Offset = "0x600500", VA = "0x180601B00", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06001841 RID: 6209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001841")]
		[Address(RVA = "0x605C90", Offset = "0x604690", VA = "0x180605C90")]
		private void RpcWriter___Server_SendItemField_2801973956(int fieldIndex, string value)
		{
		}

		// Token: 0x06001842 RID: 6210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001842")]
		[Address(RVA = "0x601FF0", Offset = "0x6009F0", VA = "0x180601FF0")]
		private void RpcLogic___SendItemField_2801973956(int fieldIndex, string value)
		{
		}

		// Token: 0x06001843 RID: 6211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001843")]
		[Address(RVA = "0x604F30", Offset = "0x603930", VA = "0x180604F30")]
		private void RpcReader___Server_SendItemField_2801973956(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06001844 RID: 6212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001844")]
		[Address(RVA = "0x601FF0", Offset = "0x6009F0", VA = "0x180601FF0")]
		private void RpcWriter___Observers_ReceiveItemField_2801973956(int fieldIndex, string value)
		{
		}

		// Token: 0x06001845 RID: 6213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001845")]
		[Address(RVA = "0x603DB0", Offset = "0x6027B0", VA = "0x180603DB0")]
		private void RpcLogic___ReceiveItemField_2801973956(int fieldIndex, string value)
		{
		}

		// Token: 0x06001846 RID: 6214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001846")]
		[Address(RVA = "0x604B00", Offset = "0x603500", VA = "0x180604B00")]
		private void RpcReader___Observers_ReceiveItemField_2801973956(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001847 RID: 6215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001847")]
		[Address(RVA = "0x605E00", Offset = "0x604800", VA = "0x180605E00")]
		private void RpcWriter___Server_SendNPCField_1687693739(int fieldIndex, NetworkObject npcObject)
		{
		}

		// Token: 0x06001848 RID: 6216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001848")]
		[Address(RVA = "0x602170", Offset = "0x600B70", VA = "0x180602170")]
		private void RpcLogic___SendNPCField_1687693739(int fieldIndex, NetworkObject npcObject)
		{
		}

		// Token: 0x06001849 RID: 6217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001849")]
		[Address(RVA = "0x6050D0", Offset = "0x603AD0", VA = "0x1806050D0")]
		private void RpcReader___Server_SendNPCField_1687693739(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x0600184A RID: 6218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600184A")]
		[Address(RVA = "0x602170", Offset = "0x600B70", VA = "0x180602170")]
		private void RpcWriter___Observers_ReceiveNPCField_1687693739(int fieldIndex, NetworkObject npcObject)
		{
		}

		// Token: 0x0600184B RID: 6219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600184B")]
		[Address(RVA = "0x603F60", Offset = "0x602960", VA = "0x180603F60")]
		private void RpcLogic___ReceiveNPCField_1687693739(int fieldIndex, NetworkObject npcObject)
		{
		}

		// Token: 0x0600184C RID: 6220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600184C")]
		[Address(RVA = "0x604B80", Offset = "0x603580", VA = "0x180604B80")]
		private void RpcReader___Observers_ReceiveNPCField_1687693739(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600184D RID: 6221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600184D")]
		[Address(RVA = "0x6060E0", Offset = "0x604AE0", VA = "0x1806060E0")]
		private void RpcWriter___Server_SendObjectField_1687693739(int fieldIndex, NetworkObject obj)
		{
		}

		// Token: 0x0600184E RID: 6222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600184E")]
		[Address(RVA = "0x602470", Offset = "0x600E70", VA = "0x180602470")]
		private void RpcLogic___SendObjectField_1687693739(int fieldIndex, NetworkObject obj)
		{
		}

		// Token: 0x0600184F RID: 6223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600184F")]
		[Address(RVA = "0x605430", Offset = "0x603E30", VA = "0x180605430")]
		private void RpcReader___Server_SendObjectField_1687693739(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06001850 RID: 6224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001850")]
		[Address(RVA = "0x602470", Offset = "0x600E70", VA = "0x180602470")]
		private void RpcWriter___Observers_ReceiveObjectField_1687693739(int fieldIndex, NetworkObject obj)
		{
		}

		// Token: 0x06001851 RID: 6225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001851")]
		[Address(RVA = "0x6042B0", Offset = "0x602CB0", VA = "0x1806042B0")]
		private void RpcLogic___ReceiveObjectField_1687693739(int fieldIndex, NetworkObject obj)
		{
		}

		// Token: 0x06001852 RID: 6226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001852")]
		[Address(RVA = "0x604C90", Offset = "0x603690", VA = "0x180604C90")]
		private void RpcReader___Observers_ReceiveObjectField_1687693739(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001853 RID: 6227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001853")]
		[Address(RVA = "0x606250", Offset = "0x604C50", VA = "0x180606250")]
		private void RpcWriter___Server_SendObjectListField_690244341(int fieldIndex, List<NetworkObject> objects)
		{
		}

		// Token: 0x06001854 RID: 6228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001854")]
		[Address(RVA = "0x6025F0", Offset = "0x600FF0", VA = "0x1806025F0")]
		private void RpcLogic___SendObjectListField_690244341(int fieldIndex, List<NetworkObject> objects)
		{
		}

		// Token: 0x06001855 RID: 6229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001855")]
		[Address(RVA = "0x6055F0", Offset = "0x603FF0", VA = "0x1806055F0")]
		private void RpcReader___Server_SendObjectListField_690244341(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06001856 RID: 6230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001856")]
		[Address(RVA = "0x6025F0", Offset = "0x600FF0", VA = "0x1806025F0")]
		private void RpcWriter___Observers_ReceiveObjectListField_690244341(int fieldIndex, List<NetworkObject> objects)
		{
		}

		// Token: 0x06001857 RID: 6231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001857")]
		[Address(RVA = "0x604460", Offset = "0x602E60", VA = "0x180604460")]
		private void RpcLogic___ReceiveObjectListField_690244341(int fieldIndex, List<NetworkObject> objects)
		{
		}

		// Token: 0x06001858 RID: 6232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001858")]
		[Address(RVA = "0x604D20", Offset = "0x603720", VA = "0x180604D20")]
		private void RpcReader___Observers_ReceiveObjectListField_690244341(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001859 RID: 6233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001859")]
		[Address(RVA = "0x606530", Offset = "0x604F30", VA = "0x180606530")]
		private void RpcWriter___Server_SendRecipeField_1692629761(int fieldIndex, int recipeIndex)
		{
		}

		// Token: 0x0600185A RID: 6234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600185A")]
		[Address(RVA = "0x6028E0", Offset = "0x6012E0", VA = "0x1806028E0")]
		private void RpcLogic___SendRecipeField_1692629761(int fieldIndex, int recipeIndex)
		{
		}

		// Token: 0x0600185B RID: 6235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600185B")]
		[Address(RVA = "0x605930", Offset = "0x604330", VA = "0x180605930")]
		private void RpcReader___Server_SendRecipeField_1692629761(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x0600185C RID: 6236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600185C")]
		[Address(RVA = "0x6028E0", Offset = "0x6012E0", VA = "0x1806028E0")]
		private void RpcWriter___Observers_ReceiveRecipeField_1692629761(int fieldIndex, int recipeIndex)
		{
		}

		// Token: 0x0600185D RID: 6237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600185D")]
		[Address(RVA = "0x6047B0", Offset = "0x6031B0", VA = "0x1806047B0")]
		private void RpcLogic___ReceiveRecipeField_1692629761(int fieldIndex, int recipeIndex)
		{
		}

		// Token: 0x0600185E RID: 6238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600185E")]
		[Address(RVA = "0x604E20", Offset = "0x603820", VA = "0x180604E20")]
		private void RpcReader___Observers_ReceiveRecipeField_1692629761(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600185F RID: 6239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600185F")]
		[Address(RVA = "0x605F70", Offset = "0x604970", VA = "0x180605F70")]
		private void RpcWriter___Server_SendNumberField_1293284375(int fieldIndex, float value)
		{
		}

		// Token: 0x06001860 RID: 6240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001860")]
		[Address(RVA = "0x6022F0", Offset = "0x600CF0", VA = "0x1806022F0")]
		private void RpcLogic___SendNumberField_1293284375(int fieldIndex, float value)
		{
		}

		// Token: 0x06001861 RID: 6241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001861")]
		[Address(RVA = "0x605290", Offset = "0x603C90", VA = "0x180605290")]
		private void RpcReader___Server_SendNumberField_1293284375(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06001862 RID: 6242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001862")]
		[Address(RVA = "0x6022F0", Offset = "0x600CF0", VA = "0x1806022F0")]
		private void RpcWriter___Observers_ReceiveNumberField_1293284375(int fieldIndex, float value)
		{
		}

		// Token: 0x06001863 RID: 6243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001863")]
		[Address(RVA = "0x604110", Offset = "0x602B10", VA = "0x180604110")]
		private void RpcLogic___ReceiveNumberField_1293284375(int fieldIndex, float value)
		{
		}

		// Token: 0x06001864 RID: 6244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001864")]
		[Address(RVA = "0x604C10", Offset = "0x603610", VA = "0x180604C10")]
		private void RpcReader___Observers_ReceiveNumberField_1293284375(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001865 RID: 6245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001865")]
		[Address(RVA = "0x6066B0", Offset = "0x6050B0", VA = "0x1806066B0")]
		private void RpcWriter___Server_SendRouteListField_3226448297(int fieldIndex, AdvancedTransitRouteData[] value)
		{
		}

		// Token: 0x06001866 RID: 6246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001866")]
		[Address(RVA = "0x602A60", Offset = "0x601460", VA = "0x180602A60")]
		private void RpcLogic___SendRouteListField_3226448297(int fieldIndex, AdvancedTransitRouteData[] value)
		{
		}

		// Token: 0x06001867 RID: 6247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001867")]
		[Address(RVA = "0x605AF0", Offset = "0x6044F0", VA = "0x180605AF0")]
		private void RpcReader___Server_SendRouteListField_3226448297(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06001868 RID: 6248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001868")]
		[Address(RVA = "0x602A60", Offset = "0x601460", VA = "0x180602A60")]
		private void RpcWriter___Observers_ReceiveRouteListField_3226448297(int fieldIndex, AdvancedTransitRouteData[] value)
		{
		}

		// Token: 0x06001869 RID: 6249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001869")]
		[Address(RVA = "0x604950", Offset = "0x603350", VA = "0x180604950")]
		private void RpcLogic___ReceiveRouteListField_3226448297(int fieldIndex, AdvancedTransitRouteData[] value)
		{
		}

		// Token: 0x0600186A RID: 6250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600186A")]
		[Address(RVA = "0x604EB0", Offset = "0x6038B0", VA = "0x180604EB0")]
		private void RpcReader___Observers_ReceiveRouteListField_3226448297(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600186B RID: 6251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600186B")]
		[Address(RVA = "0x6063C0", Offset = "0x604DC0", VA = "0x1806063C0")]
		private void RpcWriter___Server_SendQualityField_3536682170(int fieldIndex, EQuality quality)
		{
		}

		// Token: 0x0600186C RID: 6252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600186C")]
		[Address(RVA = "0x602770", Offset = "0x601170", VA = "0x180602770")]
		private void RpcLogic___SendQualityField_3536682170(int fieldIndex, EQuality quality)
		{
		}

		// Token: 0x0600186D RID: 6253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600186D")]
		[Address(RVA = "0x605790", Offset = "0x604190", VA = "0x180605790")]
		private void RpcReader___Server_SendQualityField_3536682170(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x0600186E RID: 6254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600186E")]
		[Address(RVA = "0x602770", Offset = "0x601170", VA = "0x180602770")]
		private void RpcWriter___Observers_ReceiveQualityField_3536682170(int fieldIndex, EQuality value)
		{
		}

		// Token: 0x0600186F RID: 6255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600186F")]
		[Address(RVA = "0x604610", Offset = "0x603010", VA = "0x180604610")]
		private void RpcLogic___ReceiveQualityField_3536682170(int fieldIndex, EQuality value)
		{
		}

		// Token: 0x06001870 RID: 6256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001870")]
		[Address(RVA = "0x604DA0", Offset = "0x6037A0", VA = "0x180604DA0")]
		private void RpcReader___Observers_ReceiveQualityField_3536682170(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001871 RID: 6257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001871")]
		[Address(RVA = "0x601B00", Offset = "0x600500", VA = "0x180601B00", Slot = "21")]
		public virtual void Awake()
		{
		}

		// Token: 0x040015C9 RID: 5577
		[Token(Token = "0x40015C9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public EntityConfiguration Configuration;

		// Token: 0x040015CA RID: 5578
		[Token(Token = "0x40015CA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private bool NetworkInitialize___EarlyScheduleOne.Management.ConfigurationReplicatorAssembly-CSharp.dll_Excuted;

		// Token: 0x040015CB RID: 5579
		[Token(Token = "0x40015CB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x121")]
		private bool NetworkInitialize__LateScheduleOne.Management.ConfigurationReplicatorAssembly-CSharp.dll_Excuted;
	}
}
