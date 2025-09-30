using System;
using System.Runtime.CompilerServices;
using EasyButtons;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Economy;
using ScheduleOne.ItemFramework;
using ScheduleOne.NPCs;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Product;
using ScheduleOne.Quests;
using ScheduleOne.Storage;
using UnityEngine;

namespace ScheduleOne.Cartel
{
	// Token: 0x0200080C RID: 2060
	[Token(Token = "0x200080C")]
	public class CartelDealManager : NetworkBehaviour
	{
		// Token: 0x1700080E RID: 2062
		// (get) Token: 0x0600388F RID: 14479 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003890 RID: 14480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700080E")]
		public CartelDealInfo ActiveDeal
		{
			[Token(Token = "0x600388F")]
			[Address(RVA = "0x66EF30", Offset = "0x66D930", VA = "0x18066EF30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003890")]
			[Address(RVA = "0x66F090", Offset = "0x66DA90", VA = "0x18066F090")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700080F RID: 2063
		// (get) Token: 0x06003891 RID: 14481 RVA: 0x0000F468 File Offset: 0x0000D668
		// (set) Token: 0x06003892 RID: 14482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700080F")]
		public int HoursUntilNextDealRequest
		{
			[Token(Token = "0x6003891")]
			[Address(RVA = "0x548860", Offset = "0x547260", VA = "0x180548860")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6003892")]
			[Address(RVA = "0x63DAA0", Offset = "0x63C4A0", VA = "0x18063DAA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06003893 RID: 14483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003893")]
		[Address(RVA = "0x7DF080", Offset = "0x7DDA80", VA = "0x1807DF080", Slot = "19")]
		public virtual void Awake()
		{
		}

		// Token: 0x06003894 RID: 14484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003894")]
		[Address(RVA = "0x7E0FB0", Offset = "0x7DF9B0", VA = "0x1807E0FB0")]
		private void Start()
		{
		}

		// Token: 0x06003895 RID: 14485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003895")]
		[Address(RVA = "0x7DFFF0", Offset = "0x7DE9F0", VA = "0x1807DFFF0", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x06003896 RID: 14486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003896")]
		[Address(RVA = "0x7DFE30", Offset = "0x7DE830", VA = "0x1807DFE30")]
		private void MinPass()
		{
		}

		// Token: 0x06003897 RID: 14487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003897")]
		[Address(RVA = "0x7E0050", Offset = "0x7DEA50", VA = "0x1807E0050")]
		private void OnTimeSkip(int mins)
		{
		}

		// Token: 0x06003898 RID: 14488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003898")]
		[Address(RVA = "0x7DF960", Offset = "0x7DE360", VA = "0x1807DF960")]
		private void HourPass()
		{
		}

		// Token: 0x06003899 RID: 14489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003899")]
		[Address(RVA = "0x63DAA0", Offset = "0x63C4A0", VA = "0x18063DAA0")]
		public void SetHoursUntilDealRequest(int hours)
		{
		}

		// Token: 0x0600389A RID: 14490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600389A")]
		[Address(RVA = "0x7E08B0", Offset = "0x7DF2B0", VA = "0x1807E08B0")]
		private void SleepEnd()
		{
		}

		// Token: 0x0600389B RID: 14491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600389B")]
		[Address(RVA = "0x7DFD60", Offset = "0x7DE760", VA = "0x1807DFD60")]
		private void MarkDealOverdue()
		{
		}

		// Token: 0x0600389C RID: 14492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600389C")]
		[Address(RVA = "0x7DF7E0", Offset = "0x7DE1E0", VA = "0x1807DF7E0")]
		private void ExpireDeal()
		{
		}

		// Token: 0x0600389D RID: 14493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600389D")]
		[Address(RVA = "0x7DF140", Offset = "0x7DDB40", VA = "0x1807DF140")]
		private void CheckDealCompletion()
		{
		}

		// Token: 0x0600389E RID: 14494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600389E")]
		[Address(RVA = "0x7DF380", Offset = "0x7DDD80", VA = "0x1807DF380")]
		private void CompleteDeal()
		{
		}

		// Token: 0x0600389F RID: 14495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600389F")]
		[Address(RVA = "0x7DF740", Offset = "0x7DE140", VA = "0x1807DF740")]
		private void DepositCash(float amount)
		{
		}

		// Token: 0x060038A0 RID: 14496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038A0")]
		[Address(RVA = "0x7E0A80", Offset = "0x7DF480", VA = "0x1807E0A80")]
		[Button]
		private void StartDeal()
		{
		}

		// Token: 0x060038A1 RID: 14497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038A1")]
		[Address(RVA = "0x7DFC90", Offset = "0x7DE690", VA = "0x1807DFC90")]
		public void LoadDeal(CartelDealInfo dealInfo)
		{
		}

		// Token: 0x060038A2 RID: 14498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038A2")]
		[Address(RVA = "0x7DFA10", Offset = "0x7DE410", VA = "0x1807DFA10")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		private void InitializeDealQuest(NetworkConnection conn, CartelDealInfo dealInfo)
		{
		}

		// Token: 0x060038A3 RID: 14499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038A3")]
		[Address(RVA = "0x7E0640", Offset = "0x7DF040", VA = "0x1807E0640")]
		private void SendRequestMessage(CartelDealInfo dealInfo)
		{
		}

		// Token: 0x060038A4 RID: 14500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038A4")]
		[Address(RVA = "0x7E0590", Offset = "0x7DEF90", VA = "0x1807E0590")]
		private void SendOverdueMessage()
		{
		}

		// Token: 0x060038A5 RID: 14501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038A5")]
		[Address(RVA = "0x7E04E0", Offset = "0x7DEEE0", VA = "0x1807E04E0")]
		private void SendExpiryMessage()
		{
		}

		// Token: 0x060038A6 RID: 14502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038A6")]
		[Address(RVA = "0x7DFCA0", Offset = "0x7DE6A0", VA = "0x1807DFCA0")]
		public void Load(CartelData data)
		{
		}

		// Token: 0x060038A7 RID: 14503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038A7")]
		[Address(RVA = "0x7DF0D0", Offset = "0x7DDAD0", VA = "0x1807DF0D0")]
		private void CartelStatusChange(ECartelStatus oldStatus, ECartelStatus newStatus)
		{
		}

		// Token: 0x060038A8 RID: 14504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038A8")]
		[Address(RVA = "0x7E14E0", Offset = "0x7DFEE0", VA = "0x1807E14E0")]
		public CartelDealManager()
		{
		}

		// Token: 0x060038A9 RID: 14505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038A9")]
		[Address(RVA = "0x7DFF20", Offset = "0x7DE920", VA = "0x1807DFF20", Slot = "20")]
		public virtual void NetworkInitialize___Early()
		{
		}

		// Token: 0x060038AA RID: 14506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038AA")]
		[Address(RVA = "0x7DFF00", Offset = "0x7DE900", VA = "0x1807DFF00", Slot = "21")]
		public virtual void NetworkInitialize__Late()
		{
		}

		// Token: 0x060038AB RID: 14507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038AB")]
		[Address(RVA = "0x6783D0", Offset = "0x676DD0", VA = "0x1806783D0", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x060038AC RID: 14508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038AC")]
		[Address(RVA = "0x7E0240", Offset = "0x7DEC40", VA = "0x1807E0240")]
		private void RpcWriter___Observers_InitializeDealQuest_2137933519(NetworkConnection conn, CartelDealInfo dealInfo)
		{
		}

		// Token: 0x060038AD RID: 14509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038AD")]
		[Address(RVA = "0x7E00E0", Offset = "0x7DEAE0", VA = "0x1807E00E0")]
		private void RpcLogic___InitializeDealQuest_2137933519(NetworkConnection conn, CartelDealInfo dealInfo)
		{
		}

		// Token: 0x060038AE RID: 14510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038AE")]
		[Address(RVA = "0x7E0140", Offset = "0x7DEB40", VA = "0x1807E0140")]
		private void RpcReader___Observers_InitializeDealQuest_2137933519(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060038AF RID: 14511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038AF")]
		[Address(RVA = "0x7E0380", Offset = "0x7DED80", VA = "0x1807E0380")]
		private void RpcWriter___Target_InitializeDealQuest_2137933519(NetworkConnection conn, CartelDealInfo dealInfo)
		{
		}

		// Token: 0x060038B0 RID: 14512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038B0")]
		[Address(RVA = "0x7E01C0", Offset = "0x7DEBC0", VA = "0x1807E01C0")]
		private void RpcReader___Target_InitializeDealQuest_2137933519(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060038B1 RID: 14513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038B1")]
		[Address(RVA = "0x7DF070", Offset = "0x7DDA70", VA = "0x1807DF070")]
		private void Awake_UserLogic_ScheduleOne.Cartel.CartelDealManager_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04002753 RID: 10067
		[Token(Token = "0x4002753")]
		public const int DEAL_DUE_TIME_DAYS = 3;

		// Token: 0x04002754 RID: 10068
		[Token(Token = "0x4002754")]
		public const float PAYMENT_MULTIPLIER = 0.65f;

		// Token: 0x04002755 RID: 10069
		[Token(Token = "0x4002755")]
		public const int DEAL_COOLDOWN_HOURS = 24;

		// Token: 0x04002758 RID: 10072
		[Token(Token = "0x4002758")]
		[FieldOffset(Offset = "0x128")]
		[Header("References")]
		public NPC RequestingNPC;

		// Token: 0x04002759 RID: 10073
		[Token(Token = "0x4002759")]
		[FieldOffset(Offset = "0x130")]
		public Quest_DealForCartel DealQuest;

		// Token: 0x0400275A RID: 10074
		[Token(Token = "0x400275A")]
		[FieldOffset(Offset = "0x138")]
		public WorldStorageEntity DeliveryEntity;

		// Token: 0x0400275B RID: 10075
		[Token(Token = "0x400275B")]
		[FieldOffset(Offset = "0x140")]
		public Transform CashSpawnPoint;

		// Token: 0x0400275C RID: 10076
		[Token(Token = "0x400275C")]
		[FieldOffset(Offset = "0x148")]
		public Quest MethRequestPrereqQuest;

		// Token: 0x0400275D RID: 10077
		[Token(Token = "0x400275D")]
		[FieldOffset(Offset = "0x150")]
		public Supplier CokeRequestPrereqSupplier;

		// Token: 0x0400275E RID: 10078
		[Token(Token = "0x400275E")]
		[FieldOffset(Offset = "0x158")]
		[Header("Settings")]
		public CashPickup CashPrefab;

		// Token: 0x0400275F RID: 10079
		[Token(Token = "0x400275F")]
		[FieldOffset(Offset = "0x160")]
		public ProductDefinition[] RequestableWeed;

		// Token: 0x04002760 RID: 10080
		[Token(Token = "0x4002760")]
		[FieldOffset(Offset = "0x168")]
		public ProductDefinition MethDefinition;

		// Token: 0x04002761 RID: 10081
		[Token(Token = "0x4002761")]
		[FieldOffset(Offset = "0x170")]
		public ProductDefinition CocaineDefinition;

		// Token: 0x04002762 RID: 10082
		[Token(Token = "0x4002762")]
		[FieldOffset(Offset = "0x178")]
		public int ProductQuantityMin;

		// Token: 0x04002763 RID: 10083
		[Token(Token = "0x4002763")]
		[FieldOffset(Offset = "0x17C")]
		public int ProductQuantityMax;

		// Token: 0x04002764 RID: 10084
		[Token(Token = "0x4002764")]
		[FieldOffset(Offset = "0x180")]
		private bool NetworkInitialize___EarlyScheduleOne.Cartel.CartelDealManagerAssembly-CSharp.dll_Excuted;

		// Token: 0x04002765 RID: 10085
		[Token(Token = "0x4002765")]
		[FieldOffset(Offset = "0x181")]
		private bool NetworkInitialize__LateScheduleOne.Cartel.CartelDealManagerAssembly-CSharp.dll_Excuted;
	}
}
