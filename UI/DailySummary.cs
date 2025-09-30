using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.UI
{
	// Token: 0x02000A88 RID: 2696
	[Token(Token = "0x2000A88")]
	public class DailySummary : NetworkSingleton<DailySummary>
	{
		// Token: 0x17000A4A RID: 2634
		// (get) Token: 0x0600494C RID: 18764 RVA: 0x000132A8 File Offset: 0x000114A8
		// (set) Token: 0x0600494D RID: 18765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A4A")]
		public bool IsOpen
		{
			[Token(Token = "0x600494C")]
			[Address(RVA = "0x538700", Offset = "0x537100", VA = "0x180538700")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600494D")]
			[Address(RVA = "0x633830", Offset = "0x632230", VA = "0x180633830")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000A4B RID: 2635
		// (get) Token: 0x0600494E RID: 18766 RVA: 0x000132C0 File Offset: 0x000114C0
		// (set) Token: 0x0600494F RID: 18767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A4B")]
		public int xpGained
		{
			[Token(Token = "0x600494E")]
			[Address(RVA = "0x908F60", Offset = "0x907960", VA = "0x180908F60")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x600494F")]
			[Address(RVA = "0x908F70", Offset = "0x907970", VA = "0x180908F70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06004950 RID: 18768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004950")]
		[Address(RVA = "0x908D10", Offset = "0x907710", VA = "0x180908D10", Slot = "19")]
		protected override void Start()
		{
		}

		// Token: 0x06004951 RID: 18769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004951")]
		[Address(RVA = "0x908000", Offset = "0x906A00", VA = "0x180908000")]
		public void Open()
		{
		}

		// Token: 0x06004952 RID: 18770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004952")]
		[Address(RVA = "0x907D50", Offset = "0x906750", VA = "0x180907D50")]
		public void Close()
		{
		}

		// Token: 0x06004953 RID: 18771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004953")]
		[Address(RVA = "0x907CF0", Offset = "0x9066F0", VA = "0x180907CF0")]
		private void SleepEnd()
		{
		}

		// Token: 0x06004954 RID: 18772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004954")]
		[Address(RVA = "0x907B20", Offset = "0x906520", VA = "0x180907B20")]
		[ObserversRpc]
		public void AddSoldItem(string id, int amount)
		{
		}

		// Token: 0x06004955 RID: 18773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004955")]
		[Address(RVA = "0x9079D0", Offset = "0x9063D0", VA = "0x1809079D0")]
		[ObserversRpc]
		public void AddPlayerMoney(float amount)
		{
		}

		// Token: 0x06004956 RID: 18774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004956")]
		[Address(RVA = "0x907880", Offset = "0x906280", VA = "0x180907880")]
		[ObserversRpc]
		public void AddDealerMoney(float amount)
		{
		}

		// Token: 0x06004957 RID: 18775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004957")]
		[Address(RVA = "0x907B30", Offset = "0x906530", VA = "0x180907B30")]
		[ObserversRpc]
		public void AddXP(int xp)
		{
		}

		// Token: 0x06004958 RID: 18776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004958")]
		[Address(RVA = "0x907CF0", Offset = "0x9066F0", VA = "0x180907CF0")]
		private void ClearStats()
		{
		}

		// Token: 0x06004959 RID: 18777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004959")]
		[Address(RVA = "0x908ED0", Offset = "0x9078D0", VA = "0x180908ED0")]
		public DailySummary()
		{
		}

		// Token: 0x0600495A RID: 18778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600495A")]
		[Address(RVA = "0x907E90", Offset = "0x906890", VA = "0x180907E90", Slot = "22")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x0600495B RID: 18779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600495B")]
		[Address(RVA = "0x907E40", Offset = "0x906840", VA = "0x180907E40", Slot = "23")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x0600495C RID: 18780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600495C")]
		[Address(RVA = "0x5B3020", Offset = "0x5B1A20", VA = "0x1805B3020", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x0600495D RID: 18781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600495D")]
		[Address(RVA = "0x908AE0", Offset = "0x9074E0", VA = "0x180908AE0")]
		private void RpcWriter___Observers_AddSoldItem_3643459082(string id, int amount)
		{
		}

		// Token: 0x0600495E RID: 18782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600495E")]
		[Address(RVA = "0x908790", Offset = "0x907190", VA = "0x180908790")]
		public void RpcLogic___AddSoldItem_3643459082(string id, int amount)
		{
		}

		// Token: 0x0600495F RID: 18783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600495F")]
		[Address(RVA = "0x908950", Offset = "0x907350", VA = "0x180908950")]
		private void RpcReader___Observers_AddSoldItem_3643459082(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06004960 RID: 18784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004960")]
		[Address(RVA = "0x9079D0", Offset = "0x9063D0", VA = "0x1809079D0")]
		private void RpcWriter___Observers_AddPlayerMoney_431000436(float amount)
		{
		}

		// Token: 0x06004961 RID: 18785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004961")]
		[Address(RVA = "0x908770", Offset = "0x907170", VA = "0x180908770")]
		public void RpcLogic___AddPlayerMoney_431000436(float amount)
		{
		}

		// Token: 0x06004962 RID: 18786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004962")]
		[Address(RVA = "0x9088F0", Offset = "0x9072F0", VA = "0x1809088F0")]
		private void RpcReader___Observers_AddPlayerMoney_431000436(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06004963 RID: 18787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004963")]
		[Address(RVA = "0x907880", Offset = "0x906280", VA = "0x180907880")]
		private void RpcWriter___Observers_AddDealerMoney_431000436(float amount)
		{
		}

		// Token: 0x06004964 RID: 18788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004964")]
		[Address(RVA = "0x908750", Offset = "0x907150", VA = "0x180908750")]
		public void RpcLogic___AddDealerMoney_431000436(float amount)
		{
		}

		// Token: 0x06004965 RID: 18789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004965")]
		[Address(RVA = "0x908890", Offset = "0x907290", VA = "0x180908890")]
		private void RpcReader___Observers_AddDealerMoney_431000436(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06004966 RID: 18790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004966")]
		[Address(RVA = "0x907B30", Offset = "0x906530", VA = "0x180907B30")]
		private void RpcWriter___Observers_AddXP_3316948804(int xp)
		{
		}

		// Token: 0x06004967 RID: 18791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004967")]
		[Address(RVA = "0x908880", Offset = "0x907280", VA = "0x180908880")]
		public void RpcLogic___AddXP_3316948804(int xp)
		{
		}

		// Token: 0x06004968 RID: 18792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004968")]
		[Address(RVA = "0x908A80", Offset = "0x907480", VA = "0x180908A80")]
		private void RpcReader___Observers_AddXP_3316948804(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06004969 RID: 18793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004969")]
		[Address(RVA = "0x907C80", Offset = "0x906680", VA = "0x180907C80", Slot = "20")]
		public override void Awake()
		{
		}

		// Token: 0x0400342C RID: 13356
		[Token(Token = "0x400342C")]
		[FieldOffset(Offset = "0x128")]
		[Header("References")]
		public Canvas Canvas;

		// Token: 0x0400342D RID: 13357
		[Token(Token = "0x400342D")]
		[FieldOffset(Offset = "0x130")]
		public RectTransform Container;

		// Token: 0x0400342E RID: 13358
		[Token(Token = "0x400342E")]
		[FieldOffset(Offset = "0x138")]
		public Animation Anim;

		// Token: 0x0400342F RID: 13359
		[Token(Token = "0x400342F")]
		[FieldOffset(Offset = "0x140")]
		public TextMeshProUGUI TitleLabel;

		// Token: 0x04003430 RID: 13360
		[Token(Token = "0x4003430")]
		[FieldOffset(Offset = "0x148")]
		public RectTransform[] ProductEntries;

		// Token: 0x04003431 RID: 13361
		[Token(Token = "0x4003431")]
		[FieldOffset(Offset = "0x150")]
		public TextMeshProUGUI PlayerEarningsLabel;

		// Token: 0x04003432 RID: 13362
		[Token(Token = "0x4003432")]
		[FieldOffset(Offset = "0x158")]
		public TextMeshProUGUI DealerEarningsLabel;

		// Token: 0x04003433 RID: 13363
		[Token(Token = "0x4003433")]
		[FieldOffset(Offset = "0x160")]
		public TextMeshProUGUI XPGainedLabel;

		// Token: 0x04003434 RID: 13364
		[Token(Token = "0x4003434")]
		[FieldOffset(Offset = "0x168")]
		public UnityEvent onClosed;

		// Token: 0x04003435 RID: 13365
		[Token(Token = "0x4003435")]
		[FieldOffset(Offset = "0x170")]
		private Dictionary<string, int> itemsSoldByPlayer;

		// Token: 0x04003436 RID: 13366
		[Token(Token = "0x4003436")]
		[FieldOffset(Offset = "0x178")]
		private float moneyEarnedByPlayer;

		// Token: 0x04003437 RID: 13367
		[Token(Token = "0x4003437")]
		[FieldOffset(Offset = "0x17C")]
		private float moneyEarnedByDealers;

		// Token: 0x04003439 RID: 13369
		[Token(Token = "0x4003439")]
		[FieldOffset(Offset = "0x184")]
		private bool NetworkInitialize___EarlyScheduleOne.UI.DailySummaryAssembly-CSharp.dll_Excuted;

		// Token: 0x0400343A RID: 13370
		[Token(Token = "0x400343A")]
		[FieldOffset(Offset = "0x185")]
		private bool NetworkInitialize__LateScheduleOne.UI.DailySummaryAssembly-CSharp.dll_Excuted;
	}
}
