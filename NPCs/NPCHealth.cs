using System;
using System.Runtime.CompilerServices;
using FishNet.Object;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using Il2CppDummyDll;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.PlayerScripts;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.NPCs
{
	// Token: 0x02000662 RID: 1634
	[Token(Token = "0x2000662")]
	[DisallowMultipleComponent]
	[RequireComponent(typeof(NPCHealth))]
	public class NPCHealth : NetworkBehaviour
	{
		// Token: 0x1700067C RID: 1660
		// (get) Token: 0x060028CC RID: 10444 RVA: 0x0000C660 File Offset: 0x0000A860
		// (set) Token: 0x060028CD RID: 10445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700067C")]
		public float Health
		{
			[Token(Token = "0x60028CC")]
			[Address(RVA = "0x5ADF00", Offset = "0x5AC900", VA = "0x1805ADF00")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60028CD")]
			[Address(RVA = "0x703470", Offset = "0x701E70", VA = "0x180703470")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700067D RID: 1661
		// (get) Token: 0x060028CE RID: 10446 RVA: 0x0000C678 File Offset: 0x0000A878
		// (set) Token: 0x060028CF RID: 10447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700067D")]
		public bool IsDead
		{
			[Token(Token = "0x60028CE")]
			[Address(RVA = "0x548850", Offset = "0x547250", VA = "0x180548850")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60028CF")]
			[Address(RVA = "0x703510", Offset = "0x701F10", VA = "0x180703510")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700067E RID: 1662
		// (get) Token: 0x060028D0 RID: 10448 RVA: 0x0000C690 File Offset: 0x0000A890
		// (set) Token: 0x060028D1 RID: 10449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700067E")]
		public bool IsKnockedOut
		{
			[Token(Token = "0x60028D0")]
			[Address(RVA = "0x548910", Offset = "0x547310", VA = "0x180548910")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60028D1")]
			[Address(RVA = "0x703520", Offset = "0x701F20", VA = "0x180703520")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700067F RID: 1663
		// (get) Token: 0x060028D2 RID: 10450 RVA: 0x0000C6A8 File Offset: 0x0000A8A8
		// (set) Token: 0x060028D3 RID: 10451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700067F")]
		public int DaysPassedSinceDeath
		{
			[Token(Token = "0x60028D2")]
			[Address(RVA = "0x548860", Offset = "0x547260", VA = "0x180548860")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60028D3")]
			[Address(RVA = "0x63DAA0", Offset = "0x63C4A0", VA = "0x18063DAA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000680 RID: 1664
		// (get) Token: 0x060028D4 RID: 10452 RVA: 0x0000C6C0 File Offset: 0x0000A8C0
		// (set) Token: 0x060028D5 RID: 10453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000680")]
		public int HoursSinceAttackedByPlayer
		{
			[Token(Token = "0x60028D4")]
			[Address(RVA = "0x703460", Offset = "0x701E60", VA = "0x180703460")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60028D5")]
			[Address(RVA = "0x703500", Offset = "0x701F00", VA = "0x180703500")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060028D6 RID: 10454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028D6")]
		[Address(RVA = "0x7024E0", Offset = "0x700EE0", VA = "0x1807024E0", Slot = "19")]
		public virtual void Awake()
		{
		}

		// Token: 0x060028D7 RID: 10455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028D7")]
		[Address(RVA = "0x7030B0", Offset = "0x701AB0", VA = "0x1807030B0")]
		private void Start()
		{
		}

		// Token: 0x060028D8 RID: 10456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028D8")]
		[Address(RVA = "0x702A90", Offset = "0x701490", VA = "0x180702A90")]
		private void OnDestroy()
		{
		}

		// Token: 0x060028D9 RID: 10457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028D9")]
		[Address(RVA = "0x702C10", Offset = "0x701610", VA = "0x180702C10", Slot = "6")]
		public override void OnStartServer()
		{
		}

		// Token: 0x060028DA RID: 10458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028DA")]
		[Address(RVA = "0x7027E0", Offset = "0x7011E0", VA = "0x1807027E0")]
		public void Load(NPCHealthData healthData)
		{
		}

		// Token: 0x060028DB RID: 10459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028DB")]
		[Address(RVA = "0x7033F0", Offset = "0x701DF0", VA = "0x1807033F0")]
		private void Update()
		{
		}

		// Token: 0x060028DC RID: 10460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028DC")]
		[Address(RVA = "0x702C00", Offset = "0x701600", VA = "0x180702C00", Slot = "20")]
		protected virtual void OnHourPass()
		{
		}

		// Token: 0x060028DD RID: 10461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028DD")]
		[Address(RVA = "0x702EE0", Offset = "0x7018E0", VA = "0x180702EE0")]
		public void SetAfflictedWithLethalEffect(bool value)
		{
		}

		// Token: 0x060028DE RID: 10462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028DE")]
		[Address(RVA = "0x702EF0", Offset = "0x7018F0", VA = "0x180702EF0")]
		public void SleepStart()
		{
		}

		// Token: 0x060028DF RID: 10463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028DF")]
		[Address(RVA = "0x702A80", Offset = "0x701480", VA = "0x180702A80", Slot = "21")]
		public virtual void NotifyAttackedByPlayer(Player player)
		{
		}

		// Token: 0x060028E0 RID: 10464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028E0")]
		[Address(RVA = "0x703300", Offset = "0x701D00", VA = "0x180703300")]
		public void TakeDamage(float damage, bool isLethal = true)
		{
		}

		// Token: 0x060028E1 RID: 10465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028E1")]
		[Address(RVA = "0x702530", Offset = "0x700F30", VA = "0x180702530", Slot = "22")]
		public virtual void Die()
		{
		}

		// Token: 0x060028E2 RID: 10466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028E2")]
		[Address(RVA = "0x702690", Offset = "0x701090", VA = "0x180702690", Slot = "23")]
		public virtual void KnockOut()
		{
		}

		// Token: 0x060028E3 RID: 10467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028E3")]
		[Address(RVA = "0x702D80", Offset = "0x701780", VA = "0x180702D80", Slot = "24")]
		public virtual void Revive()
		{
		}

		// Token: 0x060028E4 RID: 10468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028E4")]
		[Address(RVA = "0x703440", Offset = "0x701E40", VA = "0x180703440")]
		public NPCHealth()
		{
		}

		// Token: 0x060028E5 RID: 10469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028E5")]
		[Address(RVA = "0x702920", Offset = "0x701320", VA = "0x180702920", Slot = "25")]
		public virtual void NetworkInitialize___Early()
		{
		}

		// Token: 0x060028E6 RID: 10470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028E6")]
		[Address(RVA = "0x7028D0", Offset = "0x7012D0", VA = "0x1807028D0", Slot = "26")]
		public virtual void NetworkInitialize__Late()
		{
		}

		// Token: 0x060028E7 RID: 10471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028E7")]
		[Address(RVA = "0x702890", Offset = "0x701290", VA = "0x180702890", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x17000681 RID: 1665
		// (get) Token: 0x060028E8 RID: 10472 RVA: 0x0000C6D8 File Offset: 0x0000A8D8
		// (set) Token: 0x060028E9 RID: 10473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000681")]
		public float SyncAccessor_<Health>k__BackingField
		{
			[Token(Token = "0x60028E8")]
			[Address(RVA = "0x5ADF00", Offset = "0x5AC900", VA = "0x1805ADF00")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60028E9")]
			[Address(RVA = "0x703530", Offset = "0x701F30", VA = "0x180703530")]
			set
			{
			}
		}

		// Token: 0x060028EA RID: 10474 RVA: 0x0000C6F0 File Offset: 0x0000A8F0
		[Token(Token = "0x60028EA")]
		[Address(RVA = "0x702C40", Offset = "0x701640", VA = "0x180702C40", Slot = "27")]
		public virtual bool ReadSyncVar___ScheduleOne.NPCs.NPCHealth(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return default(bool);
		}

		// Token: 0x060028EB RID: 10475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028EB")]
		[Address(RVA = "0x702170", Offset = "0x700B70", VA = "0x180702170", Slot = "28")]
		protected virtual void Awake_UserLogic_ScheduleOne.NPCs.NPCHealth_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04001EC1 RID: 7873
		[Token(Token = "0x4001EC1")]
		public const int REVIVE_DAYS = 3;

		// Token: 0x04001EC7 RID: 7879
		[Token(Token = "0x4001EC7")]
		[FieldOffset(Offset = "0x128")]
		[Header("Settings")]
		public bool Invincible;

		// Token: 0x04001EC8 RID: 7880
		[Token(Token = "0x4001EC8")]
		[FieldOffset(Offset = "0x12C")]
		public float MaxHealth;

		// Token: 0x04001EC9 RID: 7881
		[Token(Token = "0x4001EC9")]
		[FieldOffset(Offset = "0x130")]
		private NPC npc;

		// Token: 0x04001ECA RID: 7882
		[Token(Token = "0x4001ECA")]
		[FieldOffset(Offset = "0x138")]
		public UnityEvent onDie;

		// Token: 0x04001ECB RID: 7883
		[Token(Token = "0x4001ECB")]
		[FieldOffset(Offset = "0x140")]
		public UnityEvent onKnockedOut;

		// Token: 0x04001ECC RID: 7884
		[Token(Token = "0x4001ECC")]
		[FieldOffset(Offset = "0x148")]
		public UnityEvent onDieOrKnockedOut;

		// Token: 0x04001ECD RID: 7885
		[Token(Token = "0x4001ECD")]
		[FieldOffset(Offset = "0x150")]
		public UnityEvent onRevive;

		// Token: 0x04001ECE RID: 7886
		[Token(Token = "0x4001ECE")]
		[FieldOffset(Offset = "0x158")]
		private bool AfflictedWithLethalEffect;

		// Token: 0x04001ECF RID: 7887
		[Token(Token = "0x4001ECF")]
		[FieldOffset(Offset = "0x160")]
		public SyncVar<float> syncVar___<Health>k__BackingField;

		// Token: 0x04001ED0 RID: 7888
		[Token(Token = "0x4001ED0")]
		[FieldOffset(Offset = "0x168")]
		private bool NetworkInitialize___EarlyScheduleOne.NPCs.NPCHealthAssembly-CSharp.dll_Excuted;

		// Token: 0x04001ED1 RID: 7889
		[Token(Token = "0x4001ED1")]
		[FieldOffset(Offset = "0x169")]
		private bool NetworkInitialize__LateScheduleOne.NPCs.NPCHealthAssembly-CSharp.dll_Excuted;
	}
}
