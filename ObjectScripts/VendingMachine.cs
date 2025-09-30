using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EasyButtons;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.Combat;
using ScheduleOne.DevUtilities;
using ScheduleOne.Interaction;
using ScheduleOne.ItemFramework;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x02000C68 RID: 3176
	[Token(Token = "0x2000C68")]
	public class VendingMachine : NetworkBehaviour, IGUIDRegisterable, IGenericSaveable
	{
		// Token: 0x17000BBC RID: 3004
		// (get) Token: 0x06005574 RID: 21876 RVA: 0x000153C0 File Offset: 0x000135C0
		// (set) Token: 0x06005575 RID: 21877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000BBC")]
		public bool IsBroken
		{
			[Token(Token = "0x6005574")]
			[Address(RVA = "0x542F10", Offset = "0x541910", VA = "0x180542F10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005575")]
			[Address(RVA = "0x6775B0", Offset = "0x675FB0", VA = "0x1806775B0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000BBD RID: 3005
		// (get) Token: 0x06005576 RID: 21878 RVA: 0x000153D8 File Offset: 0x000135D8
		// (set) Token: 0x06005577 RID: 21879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000BBD")]
		public int DaysUntilRepair
		{
			[Token(Token = "0x6005576")]
			[Address(RVA = "0x5388D0", Offset = "0x5372D0", VA = "0x1805388D0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6005577")]
			[Address(RVA = "0x9AB1C0", Offset = "0x9A9BC0", VA = "0x1809AB1C0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000BBE RID: 3006
		// (get) Token: 0x06005578 RID: 21880 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005579 RID: 21881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000BBE")]
		public ItemPickup lastDroppedItem
		{
			[Token(Token = "0x6005578")]
			[Address(RVA = "0x66EF50", Offset = "0x66D950", VA = "0x18066EF50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005579")]
			[Address(RVA = "0x66F0D0", Offset = "0x66DAD0", VA = "0x18066F0D0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000BBF RID: 3007
		// (get) Token: 0x0600557A RID: 21882 RVA: 0x000153F0 File Offset: 0x000135F0
		// (set) Token: 0x0600557B RID: 21883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000BBF")]
		public Guid GUID
		{
			[Token(Token = "0x600557A")]
			[Address(RVA = "0x8B6580", Offset = "0x8B4F80", VA = "0x1808B6580", Slot = "22")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Token(Token = "0x600557B")]
			[Address(RVA = "0x9E1C80", Offset = "0x9E0680", VA = "0x1809E1C80")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x0600557C RID: 21884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600557C")]
		[Address(RVA = "0x9E0120", Offset = "0x9DEB20", VA = "0x1809E0120")]
		[Button]
		public void RegenerateGUID()
		{
		}

		// Token: 0x0600557D RID: 21885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600557D")]
		[Address(RVA = "0x9DEBD0", Offset = "0x9DD5D0", VA = "0x1809DEBD0", Slot = "26")]
		public virtual void Awake()
		{
		}

		// Token: 0x0600557E RID: 21886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600557E")]
		[Address(RVA = "0x9E17A0", Offset = "0x9E01A0", VA = "0x1809E17A0")]
		private void Start()
		{
		}

		// Token: 0x0600557F RID: 21887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600557F")]
		[Address(RVA = "0x9DFFC0", Offset = "0x9DE9C0", VA = "0x1809DFFC0", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x06005580 RID: 21888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005580")]
		[Address(RVA = "0x9E14A0", Offset = "0x9DFEA0", VA = "0x1809E14A0", Slot = "21")]
		public void SetGUID(Guid guid)
		{
		}

		// Token: 0x06005581 RID: 21889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005581")]
		[Address(RVA = "0x9DFDA0", Offset = "0x9DE7A0", VA = "0x1809DFDA0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06005582 RID: 21890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005582")]
		[Address(RVA = "0x9DFA20", Offset = "0x9DE420", VA = "0x1809DFA20")]
		private void MinPass()
		{
		}

		// Token: 0x06005583 RID: 21891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005583")]
		[Address(RVA = "0x9DEEA0", Offset = "0x9DD8A0", VA = "0x1809DEEA0")]
		public void DayPass()
		{
		}

		// Token: 0x06005584 RID: 21892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005584")]
		[Address(RVA = "0x9DF2D0", Offset = "0x9DDCD0", VA = "0x1809DF2D0")]
		public void Hovered()
		{
		}

		// Token: 0x06005585 RID: 21893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005585")]
		[Address(RVA = "0x9DF760", Offset = "0x9DE160", VA = "0x1809DF760")]
		public void Interacted()
		{
		}

		// Token: 0x06005586 RID: 21894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005586")]
		[Address(RVA = "0x9DF890", Offset = "0x9DE290", VA = "0x1809DF890")]
		private void LocalPurchase()
		{
		}

		// Token: 0x06005587 RID: 21895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005587")]
		[Address(RVA = "0x9E1390", Offset = "0x9DFD90", VA = "0x1809E1390")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendPurchase()
		{
		}

		// Token: 0x06005588 RID: 21896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005588")]
		[Address(RVA = "0x9E0000", Offset = "0x9DEA00", VA = "0x1809E0000")]
		[ObserversRpc(RunLocally = true)]
		public void PurchaseRoutine()
		{
		}

		// Token: 0x06005589 RID: 21897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005589")]
		[Address(RVA = "0x9DF0F0", Offset = "0x9DDAF0", VA = "0x1809DF0F0")]
		[ServerRpc(RequireOwnership = false)]
		public void DropItem()
		{
		}

		// Token: 0x0600558A RID: 21898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600558A")]
		[Address(RVA = "0x9E0170", Offset = "0x9DEB70", VA = "0x1809E0170")]
		public void RemoveLastDropped()
		{
		}

		// Token: 0x0600558B RID: 21899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600558B")]
		[Address(RVA = "0x9DF3F0", Offset = "0x9DDDF0", VA = "0x1809DF3F0")]
		private void Impacted(Impact impact)
		{
		}

		// Token: 0x0600558C RID: 21900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600558C")]
		[Address(RVA = "0x9E1510", Offset = "0x9DFF10", VA = "0x1809E1510")]
		private void SetLit(bool lit)
		{
		}

		// Token: 0x0600558D RID: 21901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600558D")]
		[Address(RVA = "0x9E1270", Offset = "0x9DFC70", VA = "0x1809E1270")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		private void SendBreak()
		{
		}

		// Token: 0x0600558E RID: 21902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600558E")]
		[Address(RVA = "0x9DEC20", Offset = "0x9DD620", VA = "0x1809DEC20")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		private void Break(NetworkConnection conn)
		{
		}

		// Token: 0x0600558F RID: 21903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600558F")]
		[Address(RVA = "0x9E0240", Offset = "0x9DEC40", VA = "0x1809E0240")]
		[ObserversRpc]
		private void Repair()
		{
		}

		// Token: 0x06005590 RID: 21904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005590")]
		[Address(RVA = "0x9DEFE0", Offset = "0x9DD9E0", VA = "0x1809DEFE0")]
		[ServerRpc(RequireOwnership = false)]
		private void DropCash()
		{
		}

		// Token: 0x06005591 RID: 21905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005591")]
		[Address(RVA = "0x9DF7E0", Offset = "0x9DE1E0", VA = "0x1809DF7E0", Slot = "24")]
		public void Load(GenericSaveData data)
		{
		}

		// Token: 0x06005592 RID: 21906 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005592")]
		[Address(RVA = "0x9DF200", Offset = "0x9DDC00", VA = "0x1809DF200", Slot = "25")]
		public GenericSaveData GetSaveData()
		{
			return null;
		}

		// Token: 0x06005593 RID: 21907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005593")]
		[Address(RVA = "0x9E1C10", Offset = "0x9E0610", VA = "0x1809E1C10")]
		public VendingMachine()
		{
		}

		// Token: 0x06005595 RID: 21909 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005595")]
		[Address(RVA = "0x9E1B10", Offset = "0x9E0510", VA = "0x1809E1B10")]
		[CompilerGenerated]
		private IEnumerator <PurchaseRoutine>g__Routine|61_0()
		{
			return null;
		}

		// Token: 0x06005596 RID: 21910 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005596")]
		[Address(RVA = "0x9E1A30", Offset = "0x9E0430", VA = "0x1809E1A30")]
		[CompilerGenerated]
		private IEnumerator <Impacted>g__BreakRoutine|64_0()
		{
			return null;
		}

		// Token: 0x06005597 RID: 21911 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005597")]
		[Address(RVA = "0x9E1AA0", Offset = "0x9E04A0", VA = "0x1809E1AA0")]
		[CompilerGenerated]
		private IEnumerator <Impacted>g__Drop|64_1()
		{
			return null;
		}

		// Token: 0x06005598 RID: 21912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005598")]
		[Address(RVA = "0x9DFB30", Offset = "0x9DE530", VA = "0x1809DFB30", Slot = "27")]
		public virtual void NetworkInitialize___Early()
		{
		}

		// Token: 0x06005599 RID: 21913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005599")]
		[Address(RVA = "0x9D8800", Offset = "0x9D7200", VA = "0x1809D8800", Slot = "28")]
		public virtual void NetworkInitialize__Late()
		{
		}

		// Token: 0x0600559A RID: 21914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600559A")]
		[Address(RVA = "0x9DFAF0", Offset = "0x9DE4F0", VA = "0x1809DFAF0", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x0600559B RID: 21915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600559B")]
		[Address(RVA = "0x9E1030", Offset = "0x9DFA30", VA = "0x1809E1030")]
		private void RpcWriter___Server_SendPurchase_2166136261()
		{
		}

		// Token: 0x0600559C RID: 21916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600559C")]
		[Address(RVA = "0x9E0000", Offset = "0x9DEA00", VA = "0x1809E0000")]
		public void RpcLogic___SendPurchase_2166136261()
		{
		}

		// Token: 0x0600559D RID: 21917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600559D")]
		[Address(RVA = "0x9E0C30", Offset = "0x9DF630", VA = "0x1809E0C30")]
		private void RpcReader___Server_SendPurchase_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x0600559E RID: 21918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600559E")]
		[Address(RVA = "0x9E0E00", Offset = "0x9DF800", VA = "0x1809E0E00")]
		private void RpcWriter___Observers_PurchaseRoutine_2166136261()
		{
		}

		// Token: 0x0600559F RID: 21919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600559F")]
		[Address(RVA = "0x9E0770", Offset = "0x9DF170", VA = "0x1809E0770")]
		public void RpcLogic___PurchaseRoutine_2166136261()
		{
		}

		// Token: 0x060055A0 RID: 21920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055A0")]
		[Address(RVA = "0x9E0980", Offset = "0x9DF380", VA = "0x1809E0980")]
		private void RpcReader___Observers_PurchaseRoutine_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060055A1 RID: 21921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055A1")]
		[Address(RVA = "0x9DF0F0", Offset = "0x9DDAF0", VA = "0x1809DF0F0")]
		private void RpcWriter___Server_DropItem_2166136261()
		{
		}

		// Token: 0x060055A2 RID: 21922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055A2")]
		[Address(RVA = "0x9E0630", Offset = "0x9DF030", VA = "0x1809E0630")]
		public void RpcLogic___DropItem_2166136261()
		{
		}

		// Token: 0x060055A3 RID: 21923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055A3")]
		[Address(RVA = "0x9E0A80", Offset = "0x9DF480", VA = "0x1809E0A80")]
		private void RpcReader___Server_DropItem_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060055A4 RID: 21924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055A4")]
		[Address(RVA = "0x9E0F20", Offset = "0x9DF920", VA = "0x1809E0F20")]
		private void RpcWriter___Server_SendBreak_2166136261()
		{
		}

		// Token: 0x060055A5 RID: 21925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055A5")]
		[Address(RVA = "0x9E0900", Offset = "0x9DF300", VA = "0x1809E0900")]
		private void RpcLogic___SendBreak_2166136261()
		{
		}

		// Token: 0x060055A6 RID: 21926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055A6")]
		[Address(RVA = "0x9E0BD0", Offset = "0x9DF5D0", VA = "0x1809E0BD0")]
		private void RpcReader___Server_SendBreak_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060055A7 RID: 21927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055A7")]
		[Address(RVA = "0x9E0CE0", Offset = "0x9DF6E0", VA = "0x1809E0CE0")]
		private void RpcWriter___Observers_Break_328543758(NetworkConnection conn)
		{
		}

		// Token: 0x060055A8 RID: 21928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055A8")]
		[Address(RVA = "0x9E0360", Offset = "0x9DED60", VA = "0x1809E0360")]
		private void RpcLogic___Break_328543758(NetworkConnection conn)
		{
		}

		// Token: 0x060055A9 RID: 21929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055A9")]
		[Address(RVA = "0x9E0920", Offset = "0x9DF320", VA = "0x1809E0920")]
		private void RpcReader___Observers_Break_328543758(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060055AA RID: 21930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055AA")]
		[Address(RVA = "0x9E1140", Offset = "0x9DFB40", VA = "0x1809E1140")]
		private void RpcWriter___Target_Break_328543758(NetworkConnection conn)
		{
		}

		// Token: 0x060055AB RID: 21931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055AB")]
		[Address(RVA = "0x9E0C80", Offset = "0x9DF680", VA = "0x1809E0C80")]
		private void RpcReader___Target_Break_328543758(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060055AC RID: 21932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055AC")]
		[Address(RVA = "0x9E0240", Offset = "0x9DEC40", VA = "0x1809E0240")]
		private void RpcWriter___Observers_Repair_2166136261()
		{
		}

		// Token: 0x060055AD RID: 21933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055AD")]
		[Address(RVA = "0x9E0870", Offset = "0x9DF270", VA = "0x1809E0870")]
		private void RpcLogic___Repair_2166136261()
		{
		}

		// Token: 0x060055AE RID: 21934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055AE")]
		[Address(RVA = "0x9E09C0", Offset = "0x9DF3C0", VA = "0x1809E09C0")]
		private void RpcReader___Observers_Repair_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060055AF RID: 21935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055AF")]
		[Address(RVA = "0x9DEFE0", Offset = "0x9DD9E0", VA = "0x1809DEFE0")]
		private void RpcWriter___Server_DropCash_2166136261()
		{
		}

		// Token: 0x060055B0 RID: 21936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055B0")]
		[Address(RVA = "0x9E03B0", Offset = "0x9DEDB0", VA = "0x1809E03B0")]
		private void RpcLogic___DropCash_2166136261()
		{
		}

		// Token: 0x060055B1 RID: 21937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055B1")]
		[Address(RVA = "0x9E0A50", Offset = "0x9DF450", VA = "0x1809E0A50")]
		private void RpcReader___Server_DropCash_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060055B2 RID: 21938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055B2")]
		[Address(RVA = "0x9DE960", Offset = "0x9DD360", VA = "0x1809DE960")]
		private void Awake_UserLogic_ScheduleOne.ObjectScripts.VendingMachine_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04003F67 RID: 16231
		[Token(Token = "0x4003F67")]
		[FieldOffset(Offset = "0x0")]
		public static List<VendingMachine> AllMachines;

		// Token: 0x04003F68 RID: 16232
		[Token(Token = "0x4003F68")]
		public const float COST = 2f;

		// Token: 0x04003F69 RID: 16233
		[Token(Token = "0x4003F69")]
		public const int REPAIR_TIME_DAYS = 0;

		// Token: 0x04003F6A RID: 16234
		[Token(Token = "0x4003F6A")]
		public const float IMPACT_THRESHOLD_FREE_ITEM = 50f;

		// Token: 0x04003F6B RID: 16235
		[Token(Token = "0x4003F6B")]
		public const float IMPACT_THRESHOLD_FREE_ITEM_CHANCE = 0.33f;

		// Token: 0x04003F6C RID: 16236
		[Token(Token = "0x4003F6C")]
		public const float IMPACT_THRESHOLD_BREAK = 165f;

		// Token: 0x04003F6D RID: 16237
		[Token(Token = "0x4003F6D")]
		public const int MIN_CASH_DROP = 1;

		// Token: 0x04003F6E RID: 16238
		[Token(Token = "0x4003F6E")]
		public const int MAX_CASH_DROP = 4;

		// Token: 0x04003F71 RID: 16241
		[Token(Token = "0x4003F71")]
		[FieldOffset(Offset = "0x120")]
		[Header("Settings")]
		public int LitStartTime;

		// Token: 0x04003F72 RID: 16242
		[Token(Token = "0x4003F72")]
		[FieldOffset(Offset = "0x124")]
		public int LitOnEndTime;

		// Token: 0x04003F73 RID: 16243
		[Token(Token = "0x4003F73")]
		[FieldOffset(Offset = "0x128")]
		public ItemPickup CukePrefab;

		// Token: 0x04003F74 RID: 16244
		[Token(Token = "0x4003F74")]
		[FieldOffset(Offset = "0x130")]
		public CashPickup CashPrefab;

		// Token: 0x04003F75 RID: 16245
		[Token(Token = "0x4003F75")]
		[FieldOffset(Offset = "0x138")]
		[Header("References")]
		public MeshRenderer DoorMesh;

		// Token: 0x04003F76 RID: 16246
		[Token(Token = "0x4003F76")]
		[FieldOffset(Offset = "0x140")]
		public MeshRenderer BodyMesh;

		// Token: 0x04003F77 RID: 16247
		[Token(Token = "0x4003F77")]
		[FieldOffset(Offset = "0x148")]
		public Material DoorOffMat;

		// Token: 0x04003F78 RID: 16248
		[Token(Token = "0x4003F78")]
		[FieldOffset(Offset = "0x150")]
		public Material DoorOnMat;

		// Token: 0x04003F79 RID: 16249
		[Token(Token = "0x4003F79")]
		[FieldOffset(Offset = "0x158")]
		public Material BodyOffMat;

		// Token: 0x04003F7A RID: 16250
		[Token(Token = "0x4003F7A")]
		[FieldOffset(Offset = "0x160")]
		public Material BodyOnMat;

		// Token: 0x04003F7B RID: 16251
		[Token(Token = "0x4003F7B")]
		[FieldOffset(Offset = "0x168")]
		public OptimizedLight[] Lights;

		// Token: 0x04003F7C RID: 16252
		[Token(Token = "0x4003F7C")]
		[FieldOffset(Offset = "0x170")]
		public AudioSourceController PaySound;

		// Token: 0x04003F7D RID: 16253
		[Token(Token = "0x4003F7D")]
		[FieldOffset(Offset = "0x178")]
		public AudioSourceController DispenseSound;

		// Token: 0x04003F7E RID: 16254
		[Token(Token = "0x4003F7E")]
		[FieldOffset(Offset = "0x180")]
		public Animation Anim;

		// Token: 0x04003F7F RID: 16255
		[Token(Token = "0x4003F7F")]
		[FieldOffset(Offset = "0x188")]
		public Transform ItemSpawnPoint;

		// Token: 0x04003F80 RID: 16256
		[Token(Token = "0x4003F80")]
		[FieldOffset(Offset = "0x190")]
		public InteractableObject IntObj;

		// Token: 0x04003F81 RID: 16257
		[Token(Token = "0x4003F81")]
		[FieldOffset(Offset = "0x198")]
		public Transform AccessPoint;

		// Token: 0x04003F82 RID: 16258
		[Token(Token = "0x4003F82")]
		[FieldOffset(Offset = "0x1A0")]
		public PhysicsDamageable Damageable;

		// Token: 0x04003F83 RID: 16259
		[Token(Token = "0x4003F83")]
		[FieldOffset(Offset = "0x1A8")]
		public Transform CashSpawnPoint;

		// Token: 0x04003F84 RID: 16260
		[Token(Token = "0x4003F84")]
		[FieldOffset(Offset = "0x1B0")]
		public UnityEvent onBreak;

		// Token: 0x04003F85 RID: 16261
		[Token(Token = "0x4003F85")]
		[FieldOffset(Offset = "0x1B8")]
		public UnityEvent onRepair;

		// Token: 0x04003F87 RID: 16263
		[Token(Token = "0x4003F87")]
		[FieldOffset(Offset = "0x1C8")]
		private bool isLit;

		// Token: 0x04003F88 RID: 16264
		[Token(Token = "0x4003F88")]
		[FieldOffset(Offset = "0x1C9")]
		private bool purchaseInProgress;

		// Token: 0x04003F89 RID: 16265
		[Token(Token = "0x4003F89")]
		[FieldOffset(Offset = "0x1CC")]
		private float timeOnLastFreeItem;

		// Token: 0x04003F8B RID: 16267
		[Token(Token = "0x4003F8B")]
		[FieldOffset(Offset = "0x1E0")]
		[SerializeField]
		protected string BakedGUID;

		// Token: 0x04003F8C RID: 16268
		[Token(Token = "0x4003F8C")]
		[FieldOffset(Offset = "0x1E8")]
		private bool NetworkInitialize___EarlyScheduleOne.ObjectScripts.VendingMachineAssembly-CSharp.dll_Excuted;

		// Token: 0x04003F8D RID: 16269
		[Token(Token = "0x4003F8D")]
		[FieldOffset(Offset = "0x1E9")]
		private bool NetworkInitialize__LateScheduleOne.ObjectScripts.VendingMachineAssembly-CSharp.dll_Excuted;
	}
}
