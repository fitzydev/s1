using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.Dialogue;
using ScheduleOne.Messaging;
using ScheduleOne.NPCs;
using ScheduleOne.NPCs.Relation;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.UI.Phone;
using ScheduleOne.UI.Shop;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Economy
{
	// Token: 0x020005F3 RID: 1523
	[Token(Token = "0x20005F3")]
	public class Supplier : NPC
	{
		// Token: 0x1700062B RID: 1579
		// (get) Token: 0x06002548 RID: 9544 RVA: 0x0000B958 File Offset: 0x00009B58
		// (set) Token: 0x06002549 RID: 9545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700062B")]
		public Supplier.ESupplierStatus Status
		{
			[Token(Token = "0x6002548")]
			[Address(RVA = "0x6E65D0", Offset = "0x6E4FD0", VA = "0x1806E65D0")]
			[CompilerGenerated]
			get
			{
				return Supplier.ESupplierStatus.Idle;
			}
			[Token(Token = "0x6002549")]
			[Address(RVA = "0x6E6600", Offset = "0x6E5000", VA = "0x1806E6600")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700062C RID: 1580
		// (get) Token: 0x0600254A RID: 9546 RVA: 0x0000B970 File Offset: 0x00009B70
		// (set) Token: 0x0600254B RID: 9547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700062C")]
		public bool DeliveriesEnabled
		{
			[Token(Token = "0x600254A")]
			[Address(RVA = "0x6E65C0", Offset = "0x6E4FC0", VA = "0x1806E65C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600254B")]
			[Address(RVA = "0x6E65F0", Offset = "0x6E4FF0", VA = "0x1806E65F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700062D RID: 1581
		// (get) Token: 0x0600254C RID: 9548 RVA: 0x0000B988 File Offset: 0x00009B88
		[Token(Token = "0x1700062D")]
		public float Debt
		{
			[Token(Token = "0x600254C")]
			[Address(RVA = "0x6E65B0", Offset = "0x6E4FB0", VA = "0x1806E65B0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700062E RID: 1582
		// (get) Token: 0x0600254D RID: 9549 RVA: 0x0000B9A0 File Offset: 0x00009BA0
		// (set) Token: 0x0600254E RID: 9550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700062E")]
		public int minsUntilDeaddropReady
		{
			[Token(Token = "0x600254D")]
			[Address(RVA = "0x6E65E0", Offset = "0x6E4FE0", VA = "0x1806E65E0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x600254E")]
			[Address(RVA = "0x6E6610", Offset = "0x6E5010", VA = "0x1806E6610")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600254F RID: 9551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600254F")]
		[Address(RVA = "0x6E0560", Offset = "0x6DEF60", VA = "0x1806E0560", Slot = "64")]
		public override void Awake()
		{
		}

		// Token: 0x06002550 RID: 9552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002550")]
		[Address(RVA = "0x6E5640", Offset = "0x6E4040", VA = "0x1806E5640", Slot = "70")]
		protected override void Start()
		{
		}

		// Token: 0x06002551 RID: 9553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002551")]
		[Address(RVA = "0x6E3800", Offset = "0x6E2200", VA = "0x1806E3800", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x06002552 RID: 9554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002552")]
		[Address(RVA = "0x6E5020", Offset = "0x6E3A20", VA = "0x1806E5020")]
		[ServerRpc(RequireOwnership = false)]
		public void SendUnlocked()
		{
		}

		// Token: 0x06002553 RID: 9555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002553")]
		[Address(RVA = "0x6E44D0", Offset = "0x6E2ED0", VA = "0x1806E44D0")]
		[ObserversRpc]
		private void SetUnlocked()
		{
		}

		// Token: 0x06002554 RID: 9556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002554")]
		[Address(RVA = "0x6E31C0", Offset = "0x6E1BC0", VA = "0x1806E31C0", Slot = "72")]
		protected override void MinPass()
		{
		}

		// Token: 0x06002555 RID: 9557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002555")]
		[Address(RVA = "0x6E2600", Offset = "0x6E1000", VA = "0x1806E2600")]
		protected void HourPass()
		{
		}

		// Token: 0x06002556 RID: 9558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002556")]
		[Address(RVA = "0x6E38F0", Offset = "0x6E22F0", VA = "0x1806E38F0")]
		private void OnTimeSkip(int minsSlept)
		{
		}

		// Token: 0x06002557 RID: 9559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002557")]
		[Address(RVA = "0x6E2E80", Offset = "0x6E1880", VA = "0x1806E2E80")]
		[ObserversRpc(RunLocally = true)]
		public void MeetAtLocation(NetworkConnection conn, int locationIndex, int expireIn)
		{
		}

		// Token: 0x06002558 RID: 9560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002558")]
		[Address(RVA = "0x6E1E10", Offset = "0x6E0810", VA = "0x1806E1E10")]
		public void EndMeeting()
		{
		}

		// Token: 0x06002559 RID: 9561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002559")]
		[Address(RVA = "0x6E5F70", Offset = "0x6E4970", VA = "0x1806E5F70", Slot = "108")]
		protected virtual void SupplierUnlocked(NPCRelationData.EUnlockType type, bool notify)
		{
		}

		// Token: 0x0600255A RID: 9562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600255A")]
		[Address(RVA = "0x6E3BE0", Offset = "0x6E25E0", VA = "0x1806E3BE0", Slot = "109")]
		protected virtual void RelationshipChange(float change)
		{
		}

		// Token: 0x0600255B RID: 9563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600255B")]
		[Address(RVA = "0x6E1BC0", Offset = "0x6E05C0", VA = "0x1806E1BC0")]
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		private void EnableDeliveries(NetworkConnection conn)
		{
		}

		// Token: 0x0600255C RID: 9564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600255C")]
		[Address(RVA = "0x6E5540", Offset = "0x6E3F40", VA = "0x1806E5540")]
		public void SetUnlockMessage()
		{
		}

		// Token: 0x0600255D RID: 9565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600255D")]
		[Address(RVA = "0x6E0CF0", Offset = "0x6DF6F0", VA = "0x1806E0CF0", Slot = "67")]
		protected override void CreateMessageConversation()
		{
		}

		// Token: 0x0600255E RID: 9566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600255E")]
		[Address(RVA = "0x6E19E0", Offset = "0x6E03E0", VA = "0x1806E19E0", Slot = "110")]
		protected virtual void DeaddropRequested()
		{
		}

		// Token: 0x0600255F RID: 9567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600255F")]
		[Address(RVA = "0x6E10D0", Offset = "0x6DFAD0", VA = "0x1806E10D0", Slot = "111")]
		protected virtual void DeaddropConfirmed(List<PhoneShopInterface.CartEntry> cart, float totalPrice)
		{
		}

		// Token: 0x06002560 RID: 9568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002560")]
		[Address(RVA = "0x6E5130", Offset = "0x6E3B30", VA = "0x1806E5130")]
		[ServerRpc(RequireOwnership = false)]
		private void SetDeaddrop(StringIntPair[] items, int minsUntilReady)
		{
		}

		// Token: 0x06002561 RID: 9569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002561")]
		[Address(RVA = "0x6E05C0", Offset = "0x6DEFC0", VA = "0x1806E05C0")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		private void ChangeDebt(float amount)
		{
		}

		// Token: 0x06002562 RID: 9570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002562")]
		[Address(RVA = "0x6E60E0", Offset = "0x6E4AE0", VA = "0x1806E60E0")]
		private void TryRecoverDebt()
		{
		}

		// Token: 0x06002563 RID: 9571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002563")]
		[Address(RVA = "0x6E06F0", Offset = "0x6DF0F0", VA = "0x1806E06F0")]
		private void CompleteDeaddrop()
		{
		}

		// Token: 0x06002564 RID: 9572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002564")]
		[Address(RVA = "0x6E53D0", Offset = "0x6E3DD0", VA = "0x1806E53D0")]
		private void SendDebtReminder()
		{
		}

		// Token: 0x06002565 RID: 9573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002565")]
		[Address(RVA = "0x6E3030", Offset = "0x6E1A30", VA = "0x1806E3030", Slot = "112")]
		protected virtual void MeetupRequested()
		{
		}

		// Token: 0x06002566 RID: 9574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002566")]
		[Address(RVA = "0x6E3910", Offset = "0x6E2310", VA = "0x1806E3910", Slot = "113")]
		protected virtual void PayDebtRequested()
		{
		}

		// Token: 0x06002567 RID: 9575 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002567")]
		[Address(RVA = "0x6E1EE0", Offset = "0x6E08E0", VA = "0x1806E1EE0")]
		protected SupplierLocation GetAppropriateLocation(out int locationIndex)
		{
			return null;
		}

		// Token: 0x06002568 RID: 9576 RVA: 0x0000B9B8 File Offset: 0x00009BB8
		[Token(Token = "0x6002568")]
		[Address(RVA = "0x6E2800", Offset = "0x6E1200", VA = "0x1806E2800")]
		private bool IsDeadDropValid(SendableMessage message, out string invalidReason)
		{
			return default(bool);
		}

		// Token: 0x06002569 RID: 9577 RVA: 0x0000B9D0 File Offset: 0x00009BD0
		[Token(Token = "0x6002569")]
		[Address(RVA = "0x6E2890", Offset = "0x6E1290", VA = "0x1806E2890")]
		private bool IsMeetupValid(SendableMessage message, out string invalidReason)
		{
			return default(bool);
		}

		// Token: 0x0600256A RID: 9578 RVA: 0x0000B9E8 File Offset: 0x00009BE8
		[Token(Token = "0x600256A")]
		[Address(RVA = "0x6E24B0", Offset = "0x6E0EB0", VA = "0x1806E24B0", Slot = "114")]
		public virtual float GetDeadDropLimit()
		{
			return 0f;
		}

		// Token: 0x0600256B RID: 9579 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600256B")]
		[Address(RVA = "0x6E2520", Offset = "0x6E0F20", VA = "0x1806E2520", Slot = "94")]
		public override NPCData GetNPCData()
		{
			return null;
		}

		// Token: 0x0600256C RID: 9580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600256C")]
		[Address(RVA = "0x6E2B80", Offset = "0x6E1580", VA = "0x1806E2B80", Slot = "97")]
		public override void Load(NPCData data, string containerPath)
		{
		}

		// Token: 0x0600256D RID: 9581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600256D")]
		[Address(RVA = "0x6E2970", Offset = "0x6E1370", VA = "0x1806E2970", Slot = "98")]
		public override void Load(DynamicSaveData dynamicData, NPCData npcData)
		{
		}

		// Token: 0x0600256E RID: 9582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600256E")]
		[Address(RVA = "0x6E64F0", Offset = "0x6E4EF0", VA = "0x1806E64F0")]
		public Supplier()
		{
		}

		// Token: 0x06002570 RID: 9584 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002570")]
		[Address(RVA = "0x6E6430", Offset = "0x6E4E30", VA = "0x1806E6430")]
		[CompilerGenerated]
		private IEnumerator <SupplierUnlocked>g__WaitForPlayer|52_0()
		{
			return null;
		}

		// Token: 0x06002571 RID: 9585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002571")]
		[Address(RVA = "0x6E63C0", Offset = "0x6E4DC0", VA = "0x1806E63C0")]
		[CompilerGenerated]
		private IEnumerator <EnableDeliveries>g__Wait|54_0()
		{
			return null;
		}

		// Token: 0x06002572 RID: 9586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002572")]
		[Address(RVA = "0x6E33E0", Offset = "0x6E1DE0", VA = "0x1806E33E0", Slot = "99")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06002573 RID: 9587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002573")]
		[Address(RVA = "0x6E3370", Offset = "0x6E1D70", VA = "0x1806E3370", Slot = "100")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06002574 RID: 9588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002574")]
		[Address(RVA = "0x687D80", Offset = "0x686780", VA = "0x180687D80", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06002575 RID: 9589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002575")]
		[Address(RVA = "0x6E5020", Offset = "0x6E3A20", VA = "0x1806E5020")]
		private void RpcWriter___Server_SendUnlocked_2166136261()
		{
		}

		// Token: 0x06002576 RID: 9590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002576")]
		[Address(RVA = "0x6E44D0", Offset = "0x6E2ED0", VA = "0x1806E44D0")]
		public void RpcLogic___SendUnlocked_2166136261()
		{
		}

		// Token: 0x06002577 RID: 9591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002577")]
		[Address(RVA = "0x6E4940", Offset = "0x6E3340", VA = "0x1806E4940")]
		private void RpcReader___Server_SendUnlocked_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06002578 RID: 9592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002578")]
		[Address(RVA = "0x6E44D0", Offset = "0x6E2ED0", VA = "0x1806E44D0")]
		private void RpcWriter___Observers_SetUnlocked_2166136261()
		{
		}

		// Token: 0x06002579 RID: 9593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002579")]
		[Address(RVA = "0x6E4730", Offset = "0x6E3130", VA = "0x1806E4730")]
		private void RpcLogic___SetUnlocked_2166136261()
		{
		}

		// Token: 0x0600257A RID: 9594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600257A")]
		[Address(RVA = "0x6E4870", Offset = "0x6E3270", VA = "0x1806E4870")]
		private void RpcReader___Observers_SetUnlocked_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600257B RID: 9595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600257B")]
		[Address(RVA = "0x6E4D50", Offset = "0x6E3750", VA = "0x1806E4D50")]
		private void RpcWriter___Observers_MeetAtLocation_3470796954(NetworkConnection conn, int locationIndex, int expireIn)
		{
		}

		// Token: 0x0600257C RID: 9596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600257C")]
		[Address(RVA = "0x6E4050", Offset = "0x6E2A50", VA = "0x1806E4050")]
		public void RpcLogic___MeetAtLocation_3470796954(NetworkConnection conn, int locationIndex, int expireIn)
		{
		}

		// Token: 0x0600257D RID: 9597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600257D")]
		[Address(RVA = "0x6E47B0", Offset = "0x6E31B0", VA = "0x1806E47B0")]
		private void RpcReader___Observers_MeetAtLocation_3470796954(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600257E RID: 9598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600257E")]
		[Address(RVA = "0x6E4C30", Offset = "0x6E3630", VA = "0x1806E4C30")]
		private void RpcWriter___Observers_EnableDeliveries_328543758(NetworkConnection conn)
		{
		}

		// Token: 0x0600257F RID: 9599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600257F")]
		[Address(RVA = "0x6E3F60", Offset = "0x6E2960", VA = "0x1806E3F60")]
		private void RpcLogic___EnableDeliveries_328543758(NetworkConnection conn)
		{
		}

		// Token: 0x06002580 RID: 9600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002580")]
		[Address(RVA = "0x6E4770", Offset = "0x6E3170", VA = "0x1806E4770")]
		private void RpcReader___Observers_EnableDeliveries_328543758(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06002581 RID: 9601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002581")]
		[Address(RVA = "0x6E52A0", Offset = "0x6E3CA0", VA = "0x1806E52A0")]
		private void RpcWriter___Target_EnableDeliveries_328543758(NetworkConnection conn)
		{
		}

		// Token: 0x06002582 RID: 9602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002582")]
		[Address(RVA = "0x6E4BF0", Offset = "0x6E35F0", VA = "0x1806E4BF0")]
		private void RpcReader___Target_EnableDeliveries_328543758(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06002583 RID: 9603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002583")]
		[Address(RVA = "0x6E5130", Offset = "0x6E3B30", VA = "0x1806E5130")]
		private void RpcWriter___Server_SetDeaddrop_3971994486(StringIntPair[] items, int minsUntilReady)
		{
		}

		// Token: 0x06002584 RID: 9604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002584")]
		[Address(RVA = "0x6E45F0", Offset = "0x6E2FF0", VA = "0x1806E45F0")]
		private void RpcLogic___SetDeaddrop_3971994486(StringIntPair[] items, int minsUntilReady)
		{
		}

		// Token: 0x06002585 RID: 9605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002585")]
		[Address(RVA = "0x6E4A70", Offset = "0x6E3470", VA = "0x1806E4A70")]
		private void RpcReader___Server_SetDeaddrop_3971994486(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06002586 RID: 9606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002586")]
		[Address(RVA = "0x6E4EE0", Offset = "0x6E38E0", VA = "0x1806E4EE0")]
		private void RpcWriter___Server_ChangeDebt_431000436(float amount)
		{
		}

		// Token: 0x06002587 RID: 9607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002587")]
		[Address(RVA = "0x6E3E90", Offset = "0x6E2890", VA = "0x1806E3E90")]
		private void RpcLogic___ChangeDebt_431000436(float amount)
		{
		}

		// Token: 0x06002588 RID: 9608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002588")]
		[Address(RVA = "0x6E48C0", Offset = "0x6E32C0", VA = "0x1806E48C0")]
		private void RpcReader___Server_ChangeDebt_431000436(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x1700062F RID: 1583
		// (get) Token: 0x06002589 RID: 9609 RVA: 0x0000BA00 File Offset: 0x00009C00
		// (set) Token: 0x0600258A RID: 9610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700062F")]
		public float SyncAccessor_debt
		{
			[Token(Token = "0x6002589")]
			[Address(RVA = "0x6E65B0", Offset = "0x6E4FB0", VA = "0x1806E65B0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600258A")]
			[Address(RVA = "0x6E66F0", Offset = "0x6E50F0", VA = "0x1806E66F0")]
			set
			{
			}
		}

		// Token: 0x0600258B RID: 9611 RVA: 0x0000BA18 File Offset: 0x00009C18
		[Token(Token = "0x600258B")]
		[Address(RVA = "0x6E3A40", Offset = "0x6E2440", VA = "0x1806E3A40", Slot = "115")]
		public virtual bool ReadSyncVar___ScheduleOne.Economy.Supplier(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return default(bool);
		}

		// Token: 0x17000630 RID: 1584
		// (get) Token: 0x0600258C RID: 9612 RVA: 0x0000BA30 File Offset: 0x00009C30
		// (set) Token: 0x0600258D RID: 9613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000630")]
		public bool SyncAccessor_deadDropPreparing
		{
			[Token(Token = "0x600258C")]
			[Address(RVA = "0x6E6620", Offset = "0x6E5020", VA = "0x1806E6620")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600258D")]
			[Address(RVA = "0x6E6630", Offset = "0x6E5030", VA = "0x1806E6630")]
			set
			{
			}
		}

		// Token: 0x0600258E RID: 9614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600258E")]
		[Address(RVA = "0x6E0520", Offset = "0x6DEF20", VA = "0x1806E0520", Slot = "116")]
		protected virtual void Awake_UserLogic_ScheduleOne.Economy.Supplier_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04001CD0 RID: 7376
		[Token(Token = "0x4001CD0")]
		public const float MEETUP_RELATIONSHIP_REQUIREMENT = 4f;

		// Token: 0x04001CD1 RID: 7377
		[Token(Token = "0x4001CD1")]
		public const int MEETUP_DURATION_MINS = 360;

		// Token: 0x04001CD2 RID: 7378
		[Token(Token = "0x4001CD2")]
		public const int MEETING_COOLDOWN_MINS = 720;

		// Token: 0x04001CD3 RID: 7379
		[Token(Token = "0x4001CD3")]
		public const int DEADDROP_WAIT_PER_ITEM = 30;

		// Token: 0x04001CD4 RID: 7380
		[Token(Token = "0x4001CD4")]
		public const int DEADDROP_MAX_WAIT = 360;

		// Token: 0x04001CD5 RID: 7381
		[Token(Token = "0x4001CD5")]
		public const int DEADDROP_ITEM_LIMIT = 10;

		// Token: 0x04001CD6 RID: 7382
		[Token(Token = "0x4001CD6")]
		public const float DELIVERY_RELATIONSHIP_REQUIREMENT = 5f;

		// Token: 0x04001CD7 RID: 7383
		[Token(Token = "0x4001CD7")]
		[FieldOffset(Offset = "0x0")]
		public static Color32 SupplierLabelColor;

		// Token: 0x04001CDA RID: 7386
		[Token(Token = "0x4001CDA")]
		[FieldOffset(Offset = "0x2F8")]
		[Header("Supplier Settings")]
		public float MinOrderLimit;

		// Token: 0x04001CDB RID: 7387
		[Token(Token = "0x4001CDB")]
		[FieldOffset(Offset = "0x2FC")]
		public float MaxOrderLimit;

		// Token: 0x04001CDC RID: 7388
		[Token(Token = "0x4001CDC")]
		[FieldOffset(Offset = "0x300")]
		public PhoneShopInterface.Listing[] OnlineShopItems;

		// Token: 0x04001CDD RID: 7389
		[Token(Token = "0x4001CDD")]
		[FieldOffset(Offset = "0x308")]
		[TextArea(3, 10)]
		public string SupplierRecommendMessage;

		// Token: 0x04001CDE RID: 7390
		[Token(Token = "0x4001CDE")]
		[FieldOffset(Offset = "0x310")]
		[TextArea(3, 10)]
		public string SupplierUnlockHint;

		// Token: 0x04001CDF RID: 7391
		[Token(Token = "0x4001CDF")]
		[FieldOffset(Offset = "0x318")]
		[Header("References")]
		public ShopInterface Shop;

		// Token: 0x04001CE0 RID: 7392
		[Token(Token = "0x4001CE0")]
		[FieldOffset(Offset = "0x320")]
		public SupplierStash Stash;

		// Token: 0x04001CE1 RID: 7393
		[Token(Token = "0x4001CE1")]
		[FieldOffset(Offset = "0x328")]
		public UnityEvent onDeaddropReady;

		// Token: 0x04001CE2 RID: 7394
		[Token(Token = "0x4001CE2")]
		[FieldOffset(Offset = "0x330")]
		private int minsSinceMeetingStart;

		// Token: 0x04001CE3 RID: 7395
		[Token(Token = "0x4001CE3")]
		[FieldOffset(Offset = "0x334")]
		private int minsSinceLastMeetingEnd;

		// Token: 0x04001CE4 RID: 7396
		[Token(Token = "0x4001CE4")]
		[FieldOffset(Offset = "0x338")]
		private SupplierLocation currentLocation;

		// Token: 0x04001CE5 RID: 7397
		[Token(Token = "0x4001CE5")]
		[FieldOffset(Offset = "0x340")]
		private DialogueController dialogueController;

		// Token: 0x04001CE6 RID: 7398
		[Token(Token = "0x4001CE6")]
		[FieldOffset(Offset = "0x348")]
		private DialogueController.GreetingOverride meetingGreeting;

		// Token: 0x04001CE7 RID: 7399
		[Token(Token = "0x4001CE7")]
		[FieldOffset(Offset = "0x350")]
		private DialogueController.DialogueChoice meetingChoice;

		// Token: 0x04001CE8 RID: 7400
		[Token(Token = "0x4001CE8")]
		[FieldOffset(Offset = "0x358")]
		[SyncVar]
		public float debt;

		// Token: 0x04001CE9 RID: 7401
		[Token(Token = "0x4001CE9")]
		[FieldOffset(Offset = "0x35C")]
		[SyncVar]
		public bool deadDropPreparing;

		// Token: 0x04001CEB RID: 7403
		[Token(Token = "0x4001CEB")]
		[FieldOffset(Offset = "0x368")]
		private StringIntPair[] deaddropItems;

		// Token: 0x04001CEC RID: 7404
		[Token(Token = "0x4001CEC")]
		[FieldOffset(Offset = "0x370")]
		private int minsSinceDeaddropOrder;

		// Token: 0x04001CED RID: 7405
		[Token(Token = "0x4001CED")]
		[FieldOffset(Offset = "0x374")]
		private bool repaymentReminderSent;

		// Token: 0x04001CEE RID: 7406
		[Token(Token = "0x4001CEE")]
		[FieldOffset(Offset = "0x378")]
		public SyncVar<float> syncVar___debt;

		// Token: 0x04001CEF RID: 7407
		[Token(Token = "0x4001CEF")]
		[FieldOffset(Offset = "0x380")]
		public SyncVar<bool> syncVar___deadDropPreparing;

		// Token: 0x04001CF0 RID: 7408
		[Token(Token = "0x4001CF0")]
		[FieldOffset(Offset = "0x388")]
		private bool NetworkInitialize___EarlyScheduleOne.Economy.SupplierAssembly-CSharp.dll_Excuted;

		// Token: 0x04001CF1 RID: 7409
		[Token(Token = "0x4001CF1")]
		[FieldOffset(Offset = "0x389")]
		private bool NetworkInitialize__LateScheduleOne.Economy.SupplierAssembly-CSharp.dll_Excuted;

		// Token: 0x020005F4 RID: 1524
		[Token(Token = "0x20005F4")]
		public enum ESupplierStatus
		{
			// Token: 0x04001CF3 RID: 7411
			[Token(Token = "0x4001CF3")]
			Idle,
			// Token: 0x04001CF4 RID: 7412
			[Token(Token = "0x4001CF4")]
			PreppingDeadDrop,
			// Token: 0x04001CF5 RID: 7413
			[Token(Token = "0x4001CF5")]
			Meeting
		}
	}
}
