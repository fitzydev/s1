using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using EasyButtons;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.DevUtilities;
using ScheduleOne.Economy;
using ScheduleOne.GameTime;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Persistence.Loaders;
using ScheduleOne.Product;
using UnityEngine;

namespace ScheduleOne.Quests
{
	// Token: 0x020002EC RID: 748
	[Token(Token = "0x20002EC")]
	public class QuestManager : NetworkSingleton<QuestManager>, IBaseSaveable, ISaveable
	{
		// Token: 0x17000369 RID: 873
		// (get) Token: 0x0600109D RID: 4253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000369")]
		public string SaveFolderName
		{
			[Token(Token = "0x600109D")]
			[Address(RVA = "0xADC380", Offset = "0xADAD80", VA = "0x180ADC380", Slot = "26")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700036A RID: 874
		// (get) Token: 0x0600109E RID: 4254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700036A")]
		public string SaveFileName
		{
			[Token(Token = "0x600109E")]
			[Address(RVA = "0xADC350", Offset = "0xADAD50", VA = "0x180ADC350", Slot = "27")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700036B RID: 875
		// (get) Token: 0x0600109F RID: 4255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700036B")]
		public Loader Loader
		{
			[Token(Token = "0x600109F")]
			[Address(RVA = "0x63D960", Offset = "0x63C360", VA = "0x18063D960", Slot = "28")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700036C RID: 876
		// (get) Token: 0x060010A0 RID: 4256 RVA: 0x00007C68 File Offset: 0x00005E68
		[Token(Token = "0x1700036C")]
		public bool ShouldSaveUnderFolder
		{
			[Token(Token = "0x60010A0")]
			[Address(RVA = "0x4B7AD0", Offset = "0x4B64D0", VA = "0x1804B7AD0", Slot = "29")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x060010A1 RID: 4257 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060010A2 RID: 4258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700036D")]
		public List<string> LocalExtraFiles
		{
			[Token(Token = "0x60010A1")]
			[Address(RVA = "0x630180", Offset = "0x62EB80", VA = "0x180630180", Slot = "30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60010A2")]
			[Address(RVA = "0x63DA80", Offset = "0x63C480", VA = "0x18063DA80", Slot = "31")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x060010A3 RID: 4259 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060010A4 RID: 4260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700036E")]
		public List<string> LocalExtraFolders
		{
			[Token(Token = "0x60010A3")]
			[Address(RVA = "0x708B20", Offset = "0x707520", VA = "0x180708B20", Slot = "32")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60010A4")]
			[Address(RVA = "0x708B30", Offset = "0x707530", VA = "0x180708B30", Slot = "33")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700036F RID: 879
		// (get) Token: 0x060010A5 RID: 4261 RVA: 0x00007C80 File Offset: 0x00005E80
		// (set) Token: 0x060010A6 RID: 4262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700036F")]
		public bool HasChanged
		{
			[Token(Token = "0x60010A5")]
			[Address(RVA = "0x659820", Offset = "0x658220", VA = "0x180659820", Slot = "34")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60010A6")]
			[Address(RVA = "0x659A20", Offset = "0x658420", VA = "0x180659A20", Slot = "35")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x060010A7 RID: 4263 RVA: 0x00007C98 File Offset: 0x00005E98
		[Token(Token = "0x17000370")]
		public int LoadOrder
		{
			[Token(Token = "0x60010A7")]
			[Address(RVA = "0x752390", Offset = "0x750D90", VA = "0x180752390", Slot = "25")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		// Token: 0x060010A8 RID: 4264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010A8")]
		[Address(RVA = "0xAD6340", Offset = "0xAD4D40", VA = "0x180AD6340", Slot = "20")]
		public override void Awake()
		{
		}

		// Token: 0x060010A9 RID: 4265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010A9")]
		[Address(RVA = "0xAD81C0", Offset = "0xAD6BC0", VA = "0x180AD81C0", Slot = "49")]
		public virtual void InitializeSaveable()
		{
		}

		// Token: 0x060010AA RID: 4266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010AA")]
		[Address(RVA = "0xADC0C0", Offset = "0xADAAC0", VA = "0x180ADC0C0", Slot = "19")]
		protected override void Start()
		{
		}

		// Token: 0x060010AB RID: 4267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010AB")]
		[Address(RVA = "0xAD86C0", Offset = "0xAD70C0", VA = "0x180AD86C0", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x060010AC RID: 4268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010AC")]
		[Address(RVA = "0xADC130", Offset = "0xADAB30", VA = "0x180ADC130")]
		private void UpdateVariables()
		{
		}

		// Token: 0x060010AD RID: 4269 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010AD")]
		[Address(RVA = "0xAD6500", Offset = "0xAD4F00", VA = "0x180AD6500")]
		public Contract ContractAccepted(Customer customer, ContractInfo contractData, bool track, string guid, Dealer dealer)
		{
			return null;
		}

		// Token: 0x060010AE RID: 4270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010AE")]
		[Address(RVA = "0xAD7000", Offset = "0xAD5A00", VA = "0x180AD7000")]
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		public void CreateContract_Networked(NetworkConnection conn, string title, string description, string guid, bool tracked, NetworkObject customer, ContractInfo contractData, GameDateTime expiry, GameDateTime acceptTime, [Optional] NetworkObject dealerObj)
		{
		}

		// Token: 0x060010AF RID: 4271 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010AF")]
		[Address(RVA = "0xAD6CB0", Offset = "0xAD56B0", VA = "0x180AD6CB0")]
		public Contract CreateContract_Local(string title, string description, QuestEntryData[] entries, string guid, bool tracked, Customer customer, float payment, ProductList products, string deliveryLocationGUID, QuestWindowConfig deliveryWindow, bool expires, GameDateTime expiry, int pickupScheduleIndex, GameDateTime acceptTime, [Optional] Dealer dealer)
		{
			return null;
		}

		// Token: 0x060010B0 RID: 4272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010B0")]
		[Address(RVA = "0xADBC70", Offset = "0xADA670", VA = "0x180ADBC70")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendQuestAction(string guid, QuestManager.EQuestAction action)
		{
		}

		// Token: 0x060010B1 RID: 4273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010B1")]
		[Address(RVA = "0xAD8A20", Offset = "0xAD7420", VA = "0x180AD8A20")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		private void ReceiveQuestAction(NetworkConnection conn, string guid, QuestManager.EQuestAction action)
		{
		}

		// Token: 0x060010B2 RID: 4274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010B2")]
		[Address(RVA = "0xADBF60", Offset = "0xADA960", VA = "0x180ADBF60")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendQuestState(string guid, EQuestState state)
		{
		}

		// Token: 0x060010B3 RID: 4275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010B3")]
		[Address(RVA = "0xAD8FA0", Offset = "0xAD79A0", VA = "0x180AD8FA0")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		private void ReceiveQuestState(NetworkConnection conn, string guid, EQuestState state)
		{
		}

		// Token: 0x060010B4 RID: 4276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010B4")]
		[Address(RVA = "0xADBB10", Offset = "0xADA510", VA = "0x180ADBB10")]
		[TargetRpc]
		private void SetQuestTracked(NetworkConnection conn, string guid, bool tracked)
		{
		}

		// Token: 0x060010B5 RID: 4277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010B5")]
		[Address(RVA = "0xADBDD0", Offset = "0xADA7D0", VA = "0x180ADBDD0")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendQuestEntryState(string guid, int entryIndex, EQuestState state)
		{
		}

		// Token: 0x060010B6 RID: 4278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010B6")]
		[Address(RVA = "0xAD8CC0", Offset = "0xAD76C0", VA = "0x180AD8CC0")]
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		private void ReceiveQuestEntryState(NetworkConnection conn, string guid, int entryIndex, EQuestState state)
		{
		}

		// Token: 0x060010B7 RID: 4279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010B7")]
		[Address(RVA = "0xAD8860", Offset = "0xAD7260", VA = "0x180AD8860")]
		[Button]
		public void PrintQuestStates()
		{
		}

		// Token: 0x060010B8 RID: 4280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010B8")]
		[Address(RVA = "0xAD78A0", Offset = "0xAD62A0", VA = "0x180AD78A0")]
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		public void CreateDeaddropCollectionQuest(NetworkConnection conn, string dropGUID, string guidString = "")
		{
		}

		// Token: 0x060010B9 RID: 4281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010B9")]
		[Address(RVA = "0xAD7400", Offset = "0xAD5E00", VA = "0x180AD7400")]
		public DeaddropQuest CreateDeaddropCollectionQuest(string dropGUID, string guidString = "")
		{
			return null;
		}

		// Token: 0x060010BA RID: 4282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010BA")]
		[Address(RVA = "0xAD8800", Offset = "0xAD7200", VA = "0x180AD8800")]
		public void PlayCompleteQuestSound()
		{
		}

		// Token: 0x060010BB RID: 4283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010BB")]
		[Address(RVA = "0xAD87D0", Offset = "0xAD71D0", VA = "0x180AD87D0")]
		public void PlayCompleteQuestEntrySound()
		{
		}

		// Token: 0x060010BC RID: 4284 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010BC")]
		[Address(RVA = "0xAD7B30", Offset = "0xAD6530", VA = "0x180AD7B30", Slot = "50")]
		public virtual string GetSaveString()
		{
			return null;
		}

		// Token: 0x060010BD RID: 4285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010BD")]
		[Address(RVA = "0xADC240", Offset = "0xADAC40", VA = "0x180ADC240")]
		public QuestManager()
		{
		}

		// Token: 0x060010BE RID: 4286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010BE")]
		[Address(RVA = "0xAD82A0", Offset = "0xAD6CA0", VA = "0x180AD82A0", Slot = "22")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x060010BF RID: 4287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010BF")]
		[Address(RVA = "0xAD8250", Offset = "0xAD6C50", VA = "0x180AD8250", Slot = "23")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x060010C0 RID: 4288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010C0")]
		[Address(RVA = "0x5B3020", Offset = "0x5B1A20", VA = "0x1805B3020", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x060010C1 RID: 4289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010C1")]
		[Address(RVA = "0xADA790", Offset = "0xAD9190", VA = "0x180ADA790")]
		private void RpcWriter___Observers_CreateContract_Networked_2526053753(NetworkConnection conn, string title, string description, string guid, bool tracked, NetworkObject customer, ContractInfo contractData, GameDateTime expiry, GameDateTime acceptTime, [Optional] NetworkObject dealerObj)
		{
		}

		// Token: 0x060010C2 RID: 4290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010C2")]
		[Address(RVA = "0xAD9240", Offset = "0xAD7C40", VA = "0x180AD9240")]
		public void RpcLogic___CreateContract_Networked_2526053753(NetworkConnection conn, string title, string description, string guid, bool tracked, NetworkObject customer, ContractInfo contractData, GameDateTime expiry, GameDateTime acceptTime, [Optional] NetworkObject dealerObj)
		{
		}

		// Token: 0x060010C3 RID: 4291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010C3")]
		[Address(RVA = "0xAD9C80", Offset = "0xAD8680", VA = "0x180AD9C80")]
		private void RpcReader___Observers_CreateContract_Networked_2526053753(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060010C4 RID: 4292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010C4")]
		[Address(RVA = "0xADB390", Offset = "0xAD9D90", VA = "0x180ADB390")]
		private void RpcWriter___Target_CreateContract_Networked_2526053753(NetworkConnection conn, string title, string description, string guid, bool tracked, NetworkObject customer, ContractInfo contractData, GameDateTime expiry, GameDateTime acceptTime, [Optional] NetworkObject dealerObj)
		{
		}

		// Token: 0x060010C5 RID: 4293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010C5")]
		[Address(RVA = "0xADA220", Offset = "0xAD8C20", VA = "0x180ADA220")]
		private void RpcReader___Target_CreateContract_Networked_2526053753(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060010C6 RID: 4294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010C6")]
		[Address(RVA = "0xADAF60", Offset = "0xAD9960", VA = "0x180ADAF60")]
		private void RpcWriter___Server_SendQuestAction_2848227116(string guid, QuestManager.EQuestAction action)
		{
		}

		// Token: 0x060010C7 RID: 4295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010C7")]
		[Address(RVA = "0xAD9AC0", Offset = "0xAD84C0", VA = "0x180AD9AC0")]
		public void RpcLogic___SendQuestAction_2848227116(string guid, QuestManager.EQuestAction action)
		{
		}

		// Token: 0x060010C8 RID: 4296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010C8")]
		[Address(RVA = "0xADA040", Offset = "0xAD8A40", VA = "0x180ADA040")]
		private void RpcReader___Server_SendQuestAction_2848227116(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060010C9 RID: 4297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010C9")]
		[Address(RVA = "0xADAAF0", Offset = "0xAD94F0", VA = "0x180ADAAF0")]
		private void RpcWriter___Observers_ReceiveQuestAction_920727549(NetworkConnection conn, string guid, QuestManager.EQuestAction action)
		{
		}

		// Token: 0x060010CA RID: 4298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010CA")]
		[Address(RVA = "0xAD95D0", Offset = "0xAD7FD0", VA = "0x180AD95D0")]
		private void RpcLogic___ReceiveQuestAction_920727549(NetworkConnection conn, string guid, QuestManager.EQuestAction action)
		{
		}

		// Token: 0x060010CB RID: 4299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010CB")]
		[Address(RVA = "0xAD9E90", Offset = "0xAD8890", VA = "0x180AD9E90")]
		private void RpcReader___Observers_ReceiveQuestAction_920727549(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060010CC RID: 4300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010CC")]
		[Address(RVA = "0xADB6D0", Offset = "0xADA0D0", VA = "0x180ADB6D0")]
		private void RpcWriter___Target_ReceiveQuestAction_920727549(NetworkConnection conn, string guid, QuestManager.EQuestAction action)
		{
		}

		// Token: 0x060010CD RID: 4301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010CD")]
		[Address(RVA = "0xADA430", Offset = "0xAD8E30", VA = "0x180ADA430")]
		private void RpcReader___Target_ReceiveQuestAction_920727549(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060010CE RID: 4302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010CE")]
		[Address(RVA = "0xADB230", Offset = "0xAD9C30", VA = "0x180ADB230")]
		private void RpcWriter___Server_SendQuestState_4117703421(string guid, EQuestState state)
		{
		}

		// Token: 0x060010CF RID: 4303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010CF")]
		[Address(RVA = "0xAD9B10", Offset = "0xAD8510", VA = "0x180AD9B10")]
		public void RpcLogic___SendQuestState_4117703421(string guid, EQuestState state)
		{
		}

		// Token: 0x060010D0 RID: 4304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010D0")]
		[Address(RVA = "0xADA190", Offset = "0xAD8B90", VA = "0x180ADA190")]
		private void RpcReader___Server_SendQuestState_4117703421(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060010D1 RID: 4305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010D1")]
		[Address(RVA = "0xADADF0", Offset = "0xAD97F0", VA = "0x180ADADF0")]
		private void RpcWriter___Observers_ReceiveQuestState_3887376304(NetworkConnection conn, string guid, EQuestState state)
		{
		}

		// Token: 0x060010D2 RID: 4306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010D2")]
		[Address(RVA = "0xAD9970", Offset = "0xAD8370", VA = "0x180AD9970")]
		private void RpcLogic___ReceiveQuestState_3887376304(NetworkConnection conn, string guid, EQuestState state)
		{
		}

		// Token: 0x060010D3 RID: 4307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010D3")]
		[Address(RVA = "0xAD9FC0", Offset = "0xAD89C0", VA = "0x180AD9FC0")]
		private void RpcReader___Observers_ReceiveQuestState_3887376304(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060010D4 RID: 4308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010D4")]
		[Address(RVA = "0xADB9B0", Offset = "0xADA3B0", VA = "0x180ADB9B0")]
		private void RpcWriter___Target_ReceiveQuestState_3887376304(NetworkConnection conn, string guid, EQuestState state)
		{
		}

		// Token: 0x060010D5 RID: 4309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010D5")]
		[Address(RVA = "0xADA560", Offset = "0xAD8F60", VA = "0x180ADA560")]
		private void RpcReader___Target_ReceiveQuestState_3887376304(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060010D6 RID: 4310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010D6")]
		[Address(RVA = "0xADBB10", Offset = "0xADA510", VA = "0x180ADBB10")]
		private void RpcWriter___Target_SetQuestTracked_619441887(NetworkConnection conn, string guid, bool tracked)
		{
		}

		// Token: 0x060010D7 RID: 4311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010D7")]
		[Address(RVA = "0xAD9B30", Offset = "0xAD8530", VA = "0x180AD9B30")]
		private void RpcLogic___SetQuestTracked_619441887(NetworkConnection conn, string guid, bool tracked)
		{
		}

		// Token: 0x060010D8 RID: 4312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010D8")]
		[Address(RVA = "0xADA5E0", Offset = "0xAD8FE0", VA = "0x180ADA5E0")]
		private void RpcReader___Target_SetQuestTracked_619441887(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060010D9 RID: 4313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010D9")]
		[Address(RVA = "0xADB0C0", Offset = "0xAD9AC0", VA = "0x180ADB0C0")]
		private void RpcWriter___Server_SendQuestEntryState_375159588(string guid, int entryIndex, EQuestState state)
		{
		}

		// Token: 0x060010DA RID: 4314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010DA")]
		[Address(RVA = "0xAD9AE0", Offset = "0xAD84E0", VA = "0x180AD9AE0")]
		public void RpcLogic___SendQuestEntryState_375159588(string guid, int entryIndex, EQuestState state)
		{
		}

		// Token: 0x060010DB RID: 4315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010DB")]
		[Address(RVA = "0xADA0D0", Offset = "0xAD8AD0", VA = "0x180ADA0D0")]
		private void RpcReader___Server_SendQuestEntryState_375159588(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060010DC RID: 4316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010DC")]
		[Address(RVA = "0xADAC60", Offset = "0xAD9660", VA = "0x180ADAC60")]
		private void RpcWriter___Observers_ReceiveQuestEntryState_311789429(NetworkConnection conn, string guid, int entryIndex, EQuestState state)
		{
		}

		// Token: 0x060010DD RID: 4317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010DD")]
		[Address(RVA = "0xAD9810", Offset = "0xAD8210", VA = "0x180AD9810")]
		private void RpcLogic___ReceiveQuestEntryState_311789429(NetworkConnection conn, string guid, int entryIndex, EQuestState state)
		{
		}

		// Token: 0x060010DE RID: 4318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010DE")]
		[Address(RVA = "0xAD9F10", Offset = "0xAD8910", VA = "0x180AD9F10")]
		private void RpcReader___Observers_ReceiveQuestEntryState_311789429(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060010DF RID: 4319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010DF")]
		[Address(RVA = "0xADB830", Offset = "0xADA230", VA = "0x180ADB830")]
		private void RpcWriter___Target_ReceiveQuestEntryState_311789429(NetworkConnection conn, string guid, int entryIndex, EQuestState state)
		{
		}

		// Token: 0x060010E0 RID: 4320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010E0")]
		[Address(RVA = "0xADA4B0", Offset = "0xAD8EB0", VA = "0x180ADA4B0")]
		private void RpcReader___Target_ReceiveQuestEntryState_311789429(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060010E1 RID: 4321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010E1")]
		[Address(RVA = "0xADA980", Offset = "0xAD9380", VA = "0x180ADA980")]
		private void RpcWriter___Observers_CreateDeaddropCollectionQuest_3895153758(NetworkConnection conn, string dropGUID, string guidString = "")
		{
		}

		// Token: 0x060010E2 RID: 4322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010E2")]
		[Address(RVA = "0xAD95B0", Offset = "0xAD7FB0", VA = "0x180AD95B0")]
		public void RpcLogic___CreateDeaddropCollectionQuest_3895153758(NetworkConnection conn, string dropGUID, string guidString = "")
		{
		}

		// Token: 0x060010E3 RID: 4323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010E3")]
		[Address(RVA = "0xAD9E10", Offset = "0xAD8810", VA = "0x180AD9E10")]
		private void RpcReader___Observers_CreateDeaddropCollectionQuest_3895153758(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060010E4 RID: 4324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010E4")]
		[Address(RVA = "0xADB570", Offset = "0xAD9F70", VA = "0x180ADB570")]
		private void RpcWriter___Target_CreateDeaddropCollectionQuest_3895153758(NetworkConnection conn, string dropGUID, string guidString = "")
		{
		}

		// Token: 0x060010E5 RID: 4325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010E5")]
		[Address(RVA = "0xADA3B0", Offset = "0xAD8DB0", VA = "0x180ADA3B0")]
		private void RpcReader___Target_CreateDeaddropCollectionQuest_3895153758(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060010E6 RID: 4326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010E6")]
		[Address(RVA = "0xAD61B0", Offset = "0xAD4BB0", VA = "0x180AD61B0", Slot = "51")]
		protected virtual void Awake_UserLogic_ScheduleOne.Quests.QuestManager_Assembly-CSharp.dll()
		{
		}

		// Token: 0x040010B9 RID: 4281
		[Token(Token = "0x40010B9")]
		public const EQuestState DEFAULT_QUEST_STATE = EQuestState.Inactive;

		// Token: 0x040010BA RID: 4282
		[Token(Token = "0x40010BA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public Quest[] DefaultQuests;

		// Token: 0x040010BB RID: 4283
		[Token(Token = "0x40010BB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		[Header("References")]
		public Transform QuestContainer;

		// Token: 0x040010BC RID: 4284
		[Token(Token = "0x40010BC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		public Transform ContractContainer;

		// Token: 0x040010BD RID: 4285
		[Token(Token = "0x40010BD")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		public AudioSourceController QuestCompleteSound;

		// Token: 0x040010BE RID: 4286
		[Token(Token = "0x40010BE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		public AudioSourceController QuestEntryCompleteSound;

		// Token: 0x040010BF RID: 4287
		[Token(Token = "0x40010BF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		[Header("Prefabs")]
		public Contract ContractPrefab;

		// Token: 0x040010C0 RID: 4288
		[Token(Token = "0x40010C0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		public DeaddropQuest DeaddropCollectionPrefab;

		// Token: 0x040010C1 RID: 4289
		[Token(Token = "0x40010C1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private QuestsLoader loader;

		// Token: 0x040010C6 RID: 4294
		[Token(Token = "0x40010C6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private bool NetworkInitialize___EarlyScheduleOne.Quests.QuestManagerAssembly-CSharp.dll_Excuted;

		// Token: 0x040010C7 RID: 4295
		[Token(Token = "0x40010C7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x179")]
		private bool NetworkInitialize__LateScheduleOne.Quests.QuestManagerAssembly-CSharp.dll_Excuted;

		// Token: 0x020002ED RID: 749
		[Token(Token = "0x20002ED")]
		public enum EQuestAction
		{
			// Token: 0x040010C9 RID: 4297
			[Token(Token = "0x40010C9")]
			Begin,
			// Token: 0x040010CA RID: 4298
			[Token(Token = "0x40010CA")]
			Success,
			// Token: 0x040010CB RID: 4299
			[Token(Token = "0x40010CB")]
			Fail,
			// Token: 0x040010CC RID: 4300
			[Token(Token = "0x40010CC")]
			Expire,
			// Token: 0x040010CD RID: 4301
			[Token(Token = "0x40010CD")]
			Cancel
		}
	}
}
