using System;
using System.Collections;
using System.Runtime.CompilerServices;
using EasyButtons;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Combat;
using ScheduleOne.Interaction;
using ScheduleOne.ItemFramework;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.UI.ATM;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Money
{
	// Token: 0x02000C5A RID: 3162
	[Token(Token = "0x2000C5A")]
	public class ATM : NetworkBehaviour, IGUIDRegisterable, IGenericSaveable
	{
		// Token: 0x17000B9C RID: 2972
		// (get) Token: 0x060054AE RID: 21678 RVA: 0x00015180 File Offset: 0x00013380
		// (set) Token: 0x060054AF RID: 21679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B9C")]
		public bool IsBroken
		{
			[Token(Token = "0x60054AE")]
			[Address(RVA = "0x542F10", Offset = "0x541910", VA = "0x180542F10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60054AF")]
			[Address(RVA = "0x6775B0", Offset = "0x675FB0", VA = "0x1806775B0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000B9D RID: 2973
		// (get) Token: 0x060054B0 RID: 21680 RVA: 0x00015198 File Offset: 0x00013398
		// (set) Token: 0x060054B1 RID: 21681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B9D")]
		public int DaysUntilRepair
		{
			[Token(Token = "0x60054B0")]
			[Address(RVA = "0x5388D0", Offset = "0x5372D0", VA = "0x1805388D0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60054B1")]
			[Address(RVA = "0x9AB1C0", Offset = "0x9A9BC0", VA = "0x1809AB1C0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000B9E RID: 2974
		// (get) Token: 0x060054B2 RID: 21682 RVA: 0x000151B0 File Offset: 0x000133B0
		// (set) Token: 0x060054B3 RID: 21683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B9E")]
		public bool isInUse
		{
			[Token(Token = "0x60054B2")]
			[Address(RVA = "0x9AB1B0", Offset = "0x9A9BB0", VA = "0x1809AB1B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60054B3")]
			[Address(RVA = "0x702EE0", Offset = "0x7018E0", VA = "0x180702EE0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000B9F RID: 2975
		// (get) Token: 0x060054B4 RID: 21684 RVA: 0x000151C8 File Offset: 0x000133C8
		// (set) Token: 0x060054B5 RID: 21685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B9F")]
		public Guid GUID
		{
			[Token(Token = "0x60054B4")]
			[Address(RVA = "0x9AB1A0", Offset = "0x9A9BA0", VA = "0x1809AB1A0", Slot = "22")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Token(Token = "0x60054B5")]
			[Address(RVA = "0x9AB1D0", Offset = "0x9A9BD0", VA = "0x1809AB1D0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x060054B6 RID: 21686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054B6")]
		[Address(RVA = "0x9AA2E0", Offset = "0x9A8CE0", VA = "0x1809AA2E0")]
		[Button]
		public void RegenerateGUID()
		{
		}

		// Token: 0x060054B7 RID: 21687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054B7")]
		[Address(RVA = "0x9A8FD0", Offset = "0x9A79D0", VA = "0x1809A8FD0", Slot = "26")]
		public virtual void Awake()
		{
		}

		// Token: 0x060054B8 RID: 21688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054B8")]
		[Address(RVA = "0x9AADA0", Offset = "0x9A97A0", VA = "0x1809AADA0", Slot = "27")]
		protected virtual void Start()
		{
		}

		// Token: 0x060054B9 RID: 21689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054B9")]
		[Address(RVA = "0x9AA2A0", Offset = "0x9A8CA0", VA = "0x1809AA2A0", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x060054BA RID: 21690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054BA")]
		[Address(RVA = "0x9AAD30", Offset = "0x9A9730", VA = "0x1809AAD30", Slot = "21")]
		public void SetGUID(Guid guid)
		{
		}

		// Token: 0x060054BB RID: 21691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054BB")]
		[Address(RVA = "0x9A93D0", Offset = "0x9A7DD0", VA = "0x1809A93D0")]
		public void DayPass()
		{
		}

		// Token: 0x060054BC RID: 21692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054BC")]
		[Address(RVA = "0x9AB090", Offset = "0x9A9A90", VA = "0x1809AB090")]
		public void WeekPass()
		{
		}

		// Token: 0x060054BD RID: 21693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054BD")]
		[Address(RVA = "0x9A9C60", Offset = "0x9A8660", VA = "0x1809A9C60")]
		public void Hovered()
		{
		}

		// Token: 0x060054BE RID: 21694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054BE")]
		[Address(RVA = "0x9A9FE0", Offset = "0x9A89E0", VA = "0x1809A9FE0")]
		public void Interacted()
		{
		}

		// Token: 0x060054BF RID: 21695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054BF")]
		[Address(RVA = "0x9A9630", Offset = "0x9A8030", VA = "0x1809A9630")]
		public void Enter()
		{
		}

		// Token: 0x060054C0 RID: 21696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054C0")]
		[Address(RVA = "0x9A9940", Offset = "0x9A8340", VA = "0x1809A9940")]
		public void Exit()
		{
		}

		// Token: 0x060054C1 RID: 21697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054C1")]
		[Address(RVA = "0x9A9CF0", Offset = "0x9A86F0", VA = "0x1809A9CF0")]
		private void Impacted(Impact impact)
		{
		}

		// Token: 0x060054C2 RID: 21698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054C2")]
		[Address(RVA = "0x9AAC10", Offset = "0x9A9610", VA = "0x1809AAC10")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		private void SendBreak()
		{
		}

		// Token: 0x060054C3 RID: 21699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054C3")]
		[Address(RVA = "0x9A9160", Offset = "0x9A7B60", VA = "0x1809A9160")]
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		private void Break(NetworkConnection conn)
		{
		}

		// Token: 0x060054C4 RID: 21700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054C4")]
		[Address(RVA = "0x9AA330", Offset = "0x9A8D30", VA = "0x1809AA330")]
		[ObserversRpc]
		private void Repair()
		{
		}

		// Token: 0x060054C5 RID: 21701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054C5")]
		[Address(RVA = "0x9A9520", Offset = "0x9A7F20", VA = "0x1809A9520")]
		[ServerRpc(RequireOwnership = false)]
		private void DropCash()
		{
		}

		// Token: 0x060054C6 RID: 21702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054C6")]
		[Address(RVA = "0x9AA000", Offset = "0x9A8A00", VA = "0x1809AA000", Slot = "24")]
		public void Load(GenericSaveData data)
		{
		}

		// Token: 0x060054C7 RID: 21703 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054C7")]
		[Address(RVA = "0x9A9B90", Offset = "0x9A8590", VA = "0x1809A9B90", Slot = "25")]
		public GenericSaveData GetSaveData()
		{
			return null;
		}

		// Token: 0x060054C8 RID: 21704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054C8")]
		[Address(RVA = "0x9AB140", Offset = "0x9A9B40", VA = "0x1809AB140")]
		public ATM()
		{
		}

		// Token: 0x060054CA RID: 21706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054CA")]
		[Address(RVA = "0x9AB020", Offset = "0x9A9A20", VA = "0x1809AB020")]
		[CompilerGenerated]
		private IEnumerator <Impacted>g__BreakRoutine|45_0()
		{
			return null;
		}

		// Token: 0x060054CB RID: 21707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054CB")]
		[Address(RVA = "0x9AA0F0", Offset = "0x9A8AF0", VA = "0x1809AA0F0", Slot = "28")]
		public virtual void NetworkInitialize___Early()
		{
		}

		// Token: 0x060054CC RID: 21708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054CC")]
		[Address(RVA = "0x6806E0", Offset = "0x67F0E0", VA = "0x1806806E0", Slot = "29")]
		public virtual void NetworkInitialize__Late()
		{
		}

		// Token: 0x060054CD RID: 21709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054CD")]
		[Address(RVA = "0x9AA0B0", Offset = "0x9A8AB0", VA = "0x1809AA0B0", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x060054CE RID: 21710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054CE")]
		[Address(RVA = "0x9AA9D0", Offset = "0x9A93D0", VA = "0x1809AA9D0")]
		private void RpcWriter___Server_SendBreak_2166136261()
		{
		}

		// Token: 0x060054CF RID: 21711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054CF")]
		[Address(RVA = "0x9AA710", Offset = "0x9A9110", VA = "0x1809AA710")]
		private void RpcLogic___SendBreak_2166136261()
		{
		}

		// Token: 0x060054D0 RID: 21712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054D0")]
		[Address(RVA = "0x9AA800", Offset = "0x9A9200", VA = "0x1809AA800")]
		private void RpcReader___Server_SendBreak_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060054D1 RID: 21713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054D1")]
		[Address(RVA = "0x9AA8B0", Offset = "0x9A92B0", VA = "0x1809AA8B0")]
		private void RpcWriter___Observers_Break_328543758(NetworkConnection conn)
		{
		}

		// Token: 0x060054D2 RID: 21714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054D2")]
		[Address(RVA = "0x9AA450", Offset = "0x9A8E50", VA = "0x1809AA450")]
		private void RpcLogic___Break_328543758(NetworkConnection conn)
		{
		}

		// Token: 0x060054D3 RID: 21715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054D3")]
		[Address(RVA = "0x9AA730", Offset = "0x9A9130", VA = "0x1809AA730")]
		private void RpcReader___Observers_Break_328543758(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060054D4 RID: 21716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054D4")]
		[Address(RVA = "0x9AAAE0", Offset = "0x9A94E0", VA = "0x1809AAAE0")]
		private void RpcWriter___Target_Break_328543758(NetworkConnection conn)
		{
		}

		// Token: 0x060054D5 RID: 21717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054D5")]
		[Address(RVA = "0x9AA860", Offset = "0x9A9260", VA = "0x1809AA860")]
		private void RpcReader___Target_Break_328543758(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060054D6 RID: 21718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054D6")]
		[Address(RVA = "0x9AA330", Offset = "0x9A8D30", VA = "0x1809AA330")]
		private void RpcWriter___Observers_Repair_2166136261()
		{
		}

		// Token: 0x060054D7 RID: 21719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054D7")]
		[Address(RVA = "0x9AA6E0", Offset = "0x9A90E0", VA = "0x1809AA6E0")]
		private void RpcLogic___Repair_2166136261()
		{
		}

		// Token: 0x060054D8 RID: 21720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054D8")]
		[Address(RVA = "0x9AA780", Offset = "0x9A9180", VA = "0x1809AA780")]
		private void RpcReader___Observers_Repair_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060054D9 RID: 21721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054D9")]
		[Address(RVA = "0x9A9520", Offset = "0x9A7F20", VA = "0x1809A9520")]
		private void RpcWriter___Server_DropCash_2166136261()
		{
		}

		// Token: 0x060054DA RID: 21722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054DA")]
		[Address(RVA = "0x9AA480", Offset = "0x9A8E80", VA = "0x1809AA480")]
		private void RpcLogic___DropCash_2166136261()
		{
		}

		// Token: 0x060054DB RID: 21723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054DB")]
		[Address(RVA = "0x9AA7D0", Offset = "0x9A91D0", VA = "0x1809AA7D0")]
		private void RpcReader___Server_DropCash_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060054DC RID: 21724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054DC")]
		[Address(RVA = "0x9A8E70", Offset = "0x9A7870", VA = "0x1809A8E70")]
		private void Awake_UserLogic_ScheduleOne.Money.ATM_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04003EE8 RID: 16104
		[Token(Token = "0x4003EE8")]
		public const bool DepositLimitEnabled = true;

		// Token: 0x04003EE9 RID: 16105
		[Token(Token = "0x4003EE9")]
		public const float WEEKLY_DEPOSIT_LIMIT = 10000f;

		// Token: 0x04003EEA RID: 16106
		[Token(Token = "0x4003EEA")]
		public const float IMPACT_THRESHOLD_BREAK = 165f;

		// Token: 0x04003EEB RID: 16107
		[Token(Token = "0x4003EEB")]
		public const int REPAIR_TIME_DAYS = 0;

		// Token: 0x04003EEC RID: 16108
		[Token(Token = "0x4003EEC")]
		public const int MIN_CASH_DROP = 2;

		// Token: 0x04003EED RID: 16109
		[Token(Token = "0x4003EED")]
		public const int MAX_CASH_DROP = 8;

		// Token: 0x04003EEE RID: 16110
		[Token(Token = "0x4003EEE")]
		[FieldOffset(Offset = "0x0")]
		public static float WeeklyDepositSum;

		// Token: 0x04003EF1 RID: 16113
		[Token(Token = "0x4003EF1")]
		[FieldOffset(Offset = "0x120")]
		public CashPickup CashPrefab;

		// Token: 0x04003EF2 RID: 16114
		[Token(Token = "0x4003EF2")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		[Header("References")]
		protected InteractableObject intObj;

		// Token: 0x04003EF3 RID: 16115
		[Token(Token = "0x4003EF3")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		protected Transform camPos;

		// Token: 0x04003EF4 RID: 16116
		[Token(Token = "0x4003EF4")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		protected ATMInterface interfaceATM;

		// Token: 0x04003EF5 RID: 16117
		[Token(Token = "0x4003EF5")]
		[FieldOffset(Offset = "0x140")]
		public Transform AccessPoint;

		// Token: 0x04003EF6 RID: 16118
		[Token(Token = "0x4003EF6")]
		[FieldOffset(Offset = "0x148")]
		public Transform CashSpawnPoint;

		// Token: 0x04003EF7 RID: 16119
		[Token(Token = "0x4003EF7")]
		[FieldOffset(Offset = "0x150")]
		public PhysicsDamageable Damageable;

		// Token: 0x04003EF8 RID: 16120
		[Token(Token = "0x4003EF8")]
		[FieldOffset(Offset = "0x4")]
		[Header("Settings")]
		public static float viewLerpTime;

		// Token: 0x04003EFB RID: 16123
		[Token(Token = "0x4003EFB")]
		[FieldOffset(Offset = "0x170")]
		[SerializeField]
		protected string BakedGUID;

		// Token: 0x04003EFC RID: 16124
		[Token(Token = "0x4003EFC")]
		[FieldOffset(Offset = "0x178")]
		public UnityEvent onBreak;

		// Token: 0x04003EFD RID: 16125
		[Token(Token = "0x4003EFD")]
		[FieldOffset(Offset = "0x180")]
		public UnityEvent onRepair;

		// Token: 0x04003EFE RID: 16126
		[Token(Token = "0x4003EFE")]
		[FieldOffset(Offset = "0x188")]
		private bool NetworkInitialize___EarlyScheduleOne.Money.ATMAssembly-CSharp.dll_Excuted;

		// Token: 0x04003EFF RID: 16127
		[Token(Token = "0x4003EFF")]
		[FieldOffset(Offset = "0x189")]
		private bool NetworkInitialize__LateScheduleOne.Money.ATMAssembly-CSharp.dll_Excuted;
	}
}
