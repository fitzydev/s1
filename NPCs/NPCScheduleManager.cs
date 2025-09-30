using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EasyButtons;
using Il2CppDummyDll;
using ScheduleOne.GameTime;
using ScheduleOne.NPCs.Schedules;
using UnityEngine;

namespace ScheduleOne.NPCs
{
	// Token: 0x02000676 RID: 1654
	[Token(Token = "0x2000676")]
	public class NPCScheduleManager : MonoBehaviour
	{
		// Token: 0x17000699 RID: 1689
		// (get) Token: 0x060029D3 RID: 10707 RVA: 0x0000CA80 File Offset: 0x0000AC80
		// (set) Token: 0x060029D4 RID: 10708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000699")]
		public bool ScheduleEnabled
		{
			[Token(Token = "0x60029D3")]
			[Address(RVA = "0x4B9020", Offset = "0x4B7A20", VA = "0x1804B9020")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60029D4")]
			[Address(RVA = "0x4B9030", Offset = "0x4B7A30", VA = "0x1804B9030")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700069A RID: 1690
		// (get) Token: 0x060029D5 RID: 10709 RVA: 0x0000CA98 File Offset: 0x0000AC98
		// (set) Token: 0x060029D6 RID: 10710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700069A")]
		public bool CurfewModeEnabled
		{
			[Token(Token = "0x60029D5")]
			[Address(RVA = "0x570DF0", Offset = "0x56F7F0", VA = "0x180570DF0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60029D6")]
			[Address(RVA = "0x570E40", Offset = "0x56F840", VA = "0x180570E40")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700069B RID: 1691
		// (get) Token: 0x060029D7 RID: 10711 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060029D8 RID: 10712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700069B")]
		public NPCAction ActiveAction
		{
			[Token(Token = "0x60029D7")]
			[Address(RVA = "0x4423C0", Offset = "0x440DC0", VA = "0x1804423C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60029D8")]
			[Address(RVA = "0x4423F0", Offset = "0x440DF0", VA = "0x1804423F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700069C RID: 1692
		// (get) Token: 0x060029D9 RID: 10713 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060029DA RID: 10714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700069C")]
		public List<NPCAction> PendingActions
		{
			[Token(Token = "0x60029D9")]
			[Address(RVA = "0x4423A0", Offset = "0x440DA0", VA = "0x1804423A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60029DA")]
			[Address(RVA = "0x4423D0", Offset = "0x440DD0", VA = "0x1804423D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700069D RID: 1693
		// (get) Token: 0x060029DB RID: 10715 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060029DC RID: 10716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700069D")]
		public NPC Npc
		{
			[Token(Token = "0x60029DB")]
			[Address(RVA = "0x4423B0", Offset = "0x440DB0", VA = "0x1804423B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60029DC")]
			[Address(RVA = "0x4423E0", Offset = "0x440DE0", VA = "0x1804423E0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700069E RID: 1694
		// (get) Token: 0x060029DD RID: 10717 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060029DE RID: 10718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700069E")]
		protected List<NPCAction> ActionsAwaitingStart
		{
			[Token(Token = "0x60029DD")]
			[Address(RVA = "0x486240", Offset = "0x484C40", VA = "0x180486240")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60029DE")]
			[Address(RVA = "0x4BEDE0", Offset = "0x4BD7E0", VA = "0x1804BEDE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700069F RID: 1695
		// (get) Token: 0x060029DF RID: 10719 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700069F")]
		protected TimeManager Time
		{
			[Token(Token = "0x60029DF")]
			[Address(RVA = "0x72A230", Offset = "0x728C30", VA = "0x18072A230")]
			get
			{
				return null;
			}
		}

		// Token: 0x060029E0 RID: 10720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029E0")]
		[Address(RVA = "0x727900", Offset = "0x726300", VA = "0x180727900", Slot = "4")]
		protected virtual void Awake()
		{
		}

		// Token: 0x060029E1 RID: 10721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029E1")]
		[Address(RVA = "0x729A70", Offset = "0x728470", VA = "0x180729A70", Slot = "5")]
		protected virtual void Start()
		{
		}

		// Token: 0x060029E2 RID: 10722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029E2")]
		[Address(RVA = "0x728C90", Offset = "0x727690", VA = "0x180728C90")]
		private void LocalPlayerSpawned()
		{
		}

		// Token: 0x060029E3 RID: 10723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029E3")]
		[Address(RVA = "0x729680", Offset = "0x728080", VA = "0x180729680")]
		private void OnValidate()
		{
		}

		// Token: 0x060029E4 RID: 10724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029E4")]
		[Address(RVA = "0x72A050", Offset = "0x728A50", VA = "0x18072A050", Slot = "6")]
		protected virtual void Update()
		{
		}

		// Token: 0x060029E5 RID: 10725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029E5")]
		[Address(RVA = "0x727B60", Offset = "0x726560", VA = "0x180727B60")]
		public void EnableSchedule()
		{
		}

		// Token: 0x060029E6 RID: 10726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029E6")]
		[Address(RVA = "0x727980", Offset = "0x726380", VA = "0x180727980")]
		public void DisableSchedule()
		{
		}

		// Token: 0x060029E7 RID: 10727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029E7")]
		[Address(RVA = "0x728910", Offset = "0x727310", VA = "0x180728910")]
		[Button]
		public void InitializeActions()
		{
		}

		// Token: 0x060029E8 RID: 10728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029E8")]
		[Address(RVA = "0x728CC0", Offset = "0x7276C0", VA = "0x180728CC0", Slot = "7")]
		protected virtual void MinPass()
		{
		}

		// Token: 0x060029E9 RID: 10729 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029E9")]
		[Address(RVA = "0x7283F0", Offset = "0x726DF0", VA = "0x1807283F0")]
		private List<NPCAction> GetActionsOccurringAt(int time)
		{
			return null;
		}

		// Token: 0x060029EA RID: 10730 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029EA")]
		[Address(RVA = "0x728680", Offset = "0x727080", VA = "0x180728680")]
		private List<NPCAction> GetActionsTotallyOccurringWithinRange(int min, int max, bool checkShouldStart)
		{
			return null;
		}

		// Token: 0x060029EB RID: 10731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029EB")]
		[Address(RVA = "0x7298A0", Offset = "0x7282A0", VA = "0x1807298A0")]
		private void StartAction(NPCAction action)
		{
		}

		// Token: 0x060029EC RID: 10732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029EC")]
		[Address(RVA = "0x727B80", Offset = "0x726580", VA = "0x180727B80")]
		private void EnforceState()
		{
		}

		// Token: 0x060029ED RID: 10733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029ED")]
		[Address(RVA = "0x727C10", Offset = "0x726610", VA = "0x180727C10")]
		public void EnforceState(bool initial = false)
		{
		}

		// Token: 0x060029EE RID: 10734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029EE")]
		[Address(RVA = "0x727970", Offset = "0x726370", VA = "0x180727970", Slot = "8")]
		protected virtual void CurfewEnabled()
		{
		}

		// Token: 0x060029EF RID: 10735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029EF")]
		[Address(RVA = "0x727960", Offset = "0x726360", VA = "0x180727960", Slot = "9")]
		protected virtual void CurfewDisabled()
		{
		}

		// Token: 0x060029F0 RID: 10736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029F0")]
		[Address(RVA = "0x7296C0", Offset = "0x7280C0", VA = "0x1807296C0")]
		public void SetCurfewModeEnabled(bool enabled)
		{
		}

		// Token: 0x060029F1 RID: 10737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029F1")]
		[Address(RVA = "0x72A150", Offset = "0x728B50", VA = "0x18072A150")]
		public NPCScheduleManager()
		{
		}

		// Token: 0x04001F5D RID: 8029
		[Token(Token = "0x4001F5D")]
		[FieldOffset(Offset = "0x0")]
		private static readonly NPCActionOrderByDescending orderByDescending;

		// Token: 0x04001F60 RID: 8032
		[Token(Token = "0x4001F60")]
		[FieldOffset(Offset = "0x22")]
		public bool DEBUG_MODE;

		// Token: 0x04001F64 RID: 8036
		[Token(Token = "0x4001F64")]
		[FieldOffset(Offset = "0x40")]
		[Header("References")]
		public GameObject[] EnabledDuringCurfew;

		// Token: 0x04001F65 RID: 8037
		[Token(Token = "0x4001F65")]
		[FieldOffset(Offset = "0x48")]
		public GameObject[] EnabledDuringNoCurfew;

		// Token: 0x04001F66 RID: 8038
		[Token(Token = "0x4001F66")]
		[FieldOffset(Offset = "0x50")]
		public List<NPCAction> ActionList;

		// Token: 0x04001F68 RID: 8040
		[Token(Token = "0x4001F68")]
		[FieldOffset(Offset = "0x60")]
		protected int lastProcessedTime;
	}
}
