using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.DevUtilities;
using ScheduleOne.EntityFramework;
using ScheduleOne.Interaction;
using ScheduleOne.ItemFramework;
using ScheduleOne.Management;
using ScheduleOne.Misc;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.StationFramework;
using ScheduleOne.Storage;
using ScheduleOne.Tiles;
using ScheduleOne.UI.Management;
using TMPro;
using UnityEngine;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x02000CAB RID: 3243
	[Token(Token = "0x2000CAB")]
	public class LabOven : GridItem, IUsable, IItemSlotOwner, ITransitEntity, IConfigurable
	{
		// Token: 0x17000C83 RID: 3203
		// (get) Token: 0x060059EF RID: 23023 RVA: 0x00016068 File Offset: 0x00014268
		[Token(Token = "0x17000C83")]
		public bool isOpen
		{
			[Token(Token = "0x60059EF")]
			[Address(RVA = "0xA32790", Offset = "0xA31190", VA = "0x180A32790")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000C84 RID: 3204
		// (get) Token: 0x060059F0 RID: 23024 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060059F1 RID: 23025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C84")]
		public OvenCookOperation CurrentOperation
		{
			[Token(Token = "0x60059F0")]
			[Address(RVA = "0x62FCB0", Offset = "0x62E6B0", VA = "0x18062FCB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60059F1")]
			[Address(RVA = "0x6302A0", Offset = "0x62ECA0", VA = "0x1806302A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000C85 RID: 3205
		// (get) Token: 0x060059F2 RID: 23026 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060059F3 RID: 23027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C85")]
		public List<ItemSlot> ItemSlots
		{
			[Token(Token = "0x60059F2")]
			[Address(RVA = "0x8A6B40", Offset = "0x8A5540", VA = "0x1808A6B40", Slot = "78")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60059F3")]
			[Address(RVA = "0x8A6D70", Offset = "0x8A5770", VA = "0x1808A6D70", Slot = "79")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000C86 RID: 3206
		// (get) Token: 0x060059F4 RID: 23028 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060059F5 RID: 23029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C86")]
		public NetworkObject NPCUserObject
		{
			[Token(Token = "0x60059F4")]
			[Address(RVA = "0x68D390", Offset = "0x68BD90", VA = "0x18068D390", Slot = "72")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60059F5")]
			[Address(RVA = "0xA2D540", Offset = "0xA2BF40", VA = "0x180A2D540", Slot = "73")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000C87 RID: 3207
		// (get) Token: 0x060059F6 RID: 23030 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060059F7 RID: 23031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C87")]
		public NetworkObject PlayerUserObject
		{
			[Token(Token = "0x60059F6")]
			[Address(RVA = "0xA32770", Offset = "0xA31170", VA = "0x180A32770", Slot = "74")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60059F7")]
			[Address(RVA = "0xA2D5E0", Offset = "0xA2BFE0", VA = "0x180A2D5E0", Slot = "75")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000C88 RID: 3208
		// (get) Token: 0x060059F8 RID: 23032 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C88")]
		public string Name
		{
			[Token(Token = "0x60059F8")]
			[Address(RVA = "0x9D7380", Offset = "0x9D5D80", VA = "0x1809D7380", Slot = "87")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C89 RID: 3209
		// (get) Token: 0x060059F9 RID: 23033 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060059FA RID: 23034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C89")]
		public List<ItemSlot> InputSlots
		{
			[Token(Token = "0x60059F9")]
			[Address(RVA = "0x689F00", Offset = "0x688900", VA = "0x180689F00", Slot = "88")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60059FA")]
			[Address(RVA = "0xA328A0", Offset = "0xA312A0", VA = "0x180A328A0", Slot = "89")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000C8A RID: 3210
		// (get) Token: 0x060059FB RID: 23035 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060059FC RID: 23036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C8A")]
		public List<ItemSlot> OutputSlots
		{
			[Token(Token = "0x60059FB")]
			[Address(RVA = "0x689EC0", Offset = "0x6888C0", VA = "0x180689EC0", Slot = "90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60059FC")]
			[Address(RVA = "0xA328D0", Offset = "0xA312D0", VA = "0x180A328D0", Slot = "91")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000C8B RID: 3211
		// (get) Token: 0x060059FD RID: 23037 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C8B")]
		public Transform LinkOrigin
		{
			[Token(Token = "0x60059FD")]
			[Address(RVA = "0x6DFED0", Offset = "0x6DE8D0", VA = "0x1806DFED0", Slot = "92")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C8C RID: 3212
		// (get) Token: 0x060059FE RID: 23038 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C8C")]
		public Transform[] AccessPoints
		{
			[Token(Token = "0x60059FE")]
			[Address(RVA = "0x6DFEC0", Offset = "0x6DE8C0", VA = "0x1806DFEC0", Slot = "93")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C8D RID: 3213
		// (get) Token: 0x060059FF RID: 23039 RVA: 0x00016080 File Offset: 0x00014280
		[Token(Token = "0x17000C8D")]
		public bool Selectable
		{
			[Token(Token = "0x60059FF")]
			[Address(RVA = "0xA32780", Offset = "0xA31180", VA = "0x180A32780", Slot = "94")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000C8E RID: 3214
		// (get) Token: 0x06005A00 RID: 23040 RVA: 0x00016098 File Offset: 0x00014298
		// (set) Token: 0x06005A01 RID: 23041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C8E")]
		public bool IsAcceptingItems
		{
			[Token(Token = "0x6005A00")]
			[Address(RVA = "0xA32760", Offset = "0xA31160", VA = "0x180A32760", Slot = "95")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005A01")]
			[Address(RVA = "0xA328C0", Offset = "0xA312C0", VA = "0x180A328C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000C8F RID: 3215
		// (get) Token: 0x06005A02 RID: 23042 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C8F")]
		public EntityConfiguration Configuration
		{
			[Token(Token = "0x6005A02")]
			[Address(RVA = "0x68D3D0", Offset = "0x68BDD0", VA = "0x18068D3D0", Slot = "109")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C90 RID: 3216
		// (get) Token: 0x06005A03 RID: 23043 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005A04 RID: 23044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C90")]
		protected LabOvenConfiguration ovenConfiguration
		{
			[Token(Token = "0x6005A03")]
			[Address(RVA = "0x68D3D0", Offset = "0x68BDD0", VA = "0x18068D3D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005A04")]
			[Address(RVA = "0x6D0290", Offset = "0x6CEC90", VA = "0x1806D0290")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000C91 RID: 3217
		// (get) Token: 0x06005A05 RID: 23045 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C91")]
		public ConfigurationReplicator ConfigReplicator
		{
			[Token(Token = "0x6005A05")]
			[Address(RVA = "0x9EBA20", Offset = "0x9EA420", VA = "0x1809EBA20", Slot = "110")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C92 RID: 3218
		// (get) Token: 0x06005A06 RID: 23046 RVA: 0x000160B0 File Offset: 0x000142B0
		[Token(Token = "0x17000C92")]
		public EConfigurableType ConfigurableType
		{
			[Token(Token = "0x6005A06")]
			[Address(RVA = "0x6A98D0", Offset = "0x6A82D0", VA = "0x1806A98D0", Slot = "111")]
			get
			{
				return EConfigurableType.Pot;
			}
		}

		// Token: 0x17000C93 RID: 3219
		// (get) Token: 0x06005A07 RID: 23047 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005A08 RID: 23048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C93")]
		public WorldspaceUIElement WorldspaceUI
		{
			[Token(Token = "0x6005A07")]
			[Address(RVA = "0x68D3B0", Offset = "0x68BDB0", VA = "0x18068D3B0", Slot = "112")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005A08")]
			[Address(RVA = "0x68D410", Offset = "0x68BE10", VA = "0x18068D410", Slot = "113")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000C94 RID: 3220
		// (get) Token: 0x06005A09 RID: 23049 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005A0A RID: 23050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C94")]
		public NetworkObject CurrentPlayerConfigurer
		{
			[Token(Token = "0x6005A09")]
			[Address(RVA = "0x68D3E0", Offset = "0x68BDE0", VA = "0x18068D3E0", Slot = "114")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005A0A")]
			[Address(RVA = "0xA2D230", Offset = "0xA2BC30", VA = "0x180A2D230", Slot = "115")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06005A0B RID: 23051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A0B")]
		[Address(RVA = "0xA300C0", Offset = "0xA2EAC0", VA = "0x180A300C0", Slot = "129")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetConfigurer(NetworkObject player)
		{
		}

		// Token: 0x17000C95 RID: 3221
		// (get) Token: 0x06005A0C RID: 23052 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C95")]
		public Sprite TypeIcon
		{
			[Token(Token = "0x6005A0C")]
			[Address(RVA = "0xA14760", Offset = "0xA13160", VA = "0x180A14760", Slot = "117")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C96 RID: 3222
		// (get) Token: 0x06005A0D RID: 23053 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C96")]
		public Transform Transform
		{
			[Token(Token = "0x6005A0D")]
			[Address(RVA = "0x506E30", Offset = "0x505830", VA = "0x180506E30", Slot = "118")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C97 RID: 3223
		// (get) Token: 0x06005A0E RID: 23054 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C97")]
		public Transform UIPoint
		{
			[Token(Token = "0x6005A0E")]
			[Address(RVA = "0x6DFED0", Offset = "0x6DE8D0", VA = "0x1806DFED0", Slot = "119")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C98 RID: 3224
		// (get) Token: 0x06005A0F RID: 23055 RVA: 0x000160C8 File Offset: 0x000142C8
		[Token(Token = "0x17000C98")]
		public bool CanBeSelected
		{
			[Token(Token = "0x6005A0F")]
			[Address(RVA = "0x48DCC0", Offset = "0x48C6C0", VA = "0x18048DCC0", Slot = "121")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06005A10 RID: 23056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A10")]
		[Address(RVA = "0xA29D30", Offset = "0xA28730", VA = "0x180A29D30", Slot = "47")]
		public override void Awake()
		{
		}

		// Token: 0x06005A11 RID: 23057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A11")]
		[Address(RVA = "0xA2BAD0", Offset = "0xA2A4D0", VA = "0x180A2BAD0", Slot = "66")]
		public override void InitializeGridItem(ItemInstance instance, Grid grid, Vector2 originCoordinate, int rotation, string GUID)
		{
		}

		// Token: 0x06005A12 RID: 23058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A12")]
		[Address(RVA = "0xA2C990", Offset = "0xA2B390", VA = "0x180A2C990", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x06005A13 RID: 23059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A13")]
		[Address(RVA = "0xA2FE20", Offset = "0xA2E820", VA = "0x180A2FE20", Slot = "130")]
		public void SendConfigurationToClient(NetworkConnection conn)
		{
		}

		// Token: 0x06005A14 RID: 23060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A14")]
		[Address(RVA = "0xA32410", Offset = "0xA30E10", VA = "0x180A32410")]
		private void Update()
		{
		}

		// Token: 0x06005A15 RID: 23061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A15")]
		[Address(RVA = "0xA2C100", Offset = "0xA2AB00", VA = "0x180A2C100")]
		private void MinPass()
		{
		}

		// Token: 0x06005A16 RID: 23062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A16")]
		[Address(RVA = "0xA31DB0", Offset = "0xA307B0", VA = "0x180A31DB0")]
		private void TimeSkipped(int minsSkippped)
		{
		}

		// Token: 0x06005A17 RID: 23063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A17")]
		[Address(RVA = "0xA31FB0", Offset = "0xA309B0", VA = "0x180A31FB0")]
		private void UpdateOvenAppearance()
		{
		}

		// Token: 0x06005A18 RID: 23064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A18")]
		[Address(RVA = "0xA2B470", Offset = "0xA29E70", VA = "0x180A2B470")]
		private void Exit(ExitAction action)
		{
		}

		// Token: 0x06005A19 RID: 23065 RVA: 0x000160E0 File Offset: 0x000142E0
		[Token(Token = "0x6005A19")]
		[Address(RVA = "0xA29D80", Offset = "0xA28780", VA = "0x180A29D80", Slot = "53")]
		public override bool CanBeDestroyed(out string reason)
		{
			return default(bool);
		}

		// Token: 0x06005A1A RID: 23066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A1A")]
		[Address(RVA = "0xA2B0A0", Offset = "0xA29AA0", VA = "0x180A2B0A0", Slot = "55")]
		public override void DestroyItem(bool callOnServer = true)
		{
		}

		// Token: 0x06005A1B RID: 23067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A1B")]
		[Address(RVA = "0xA30930", Offset = "0xA2F330", VA = "0x180A30930")]
		public void SetOvenLit(bool lit)
		{
		}

		// Token: 0x06005A1C RID: 23068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A1C")]
		[Address(RVA = "0xA30970", Offset = "0xA2F370", VA = "0x180A30970", Slot = "76")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetPlayerUser(NetworkObject playerObject)
		{
		}

		// Token: 0x06005A1D RID: 23069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A1D")]
		[Address(RVA = "0xA30800", Offset = "0xA2F200", VA = "0x180A30800", Slot = "77")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetNPCUser(NetworkObject npcObject)
		{
		}

		// Token: 0x06005A1E RID: 23070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A1E")]
		[Address(RVA = "0xA2B990", Offset = "0xA2A390", VA = "0x180A2B990")]
		public void Hovered()
		{
		}

		// Token: 0x06005A1F RID: 23071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A1F")]
		[Address(RVA = "0xA2BDD0", Offset = "0xA2A7D0", VA = "0x180A2BDD0")]
		public void Interacted()
		{
		}

		// Token: 0x06005A20 RID: 23072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A20")]
		[Address(RVA = "0xA2CB50", Offset = "0xA2B550", VA = "0x180A2CB50")]
		public void Open()
		{
		}

		// Token: 0x06005A21 RID: 23073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A21")]
		[Address(RVA = "0xA2A1D0", Offset = "0xA28BD0", VA = "0x180A2A1D0")]
		public void Close()
		{
		}

		// Token: 0x06005A22 RID: 23074 RVA: 0x000160F8 File Offset: 0x000142F8
		[Token(Token = "0x6005A22")]
		[Address(RVA = "0xA2BE80", Offset = "0xA2A880", VA = "0x180A2BE80")]
		public bool IsIngredientCookable()
		{
			return default(bool);
		}

		// Token: 0x06005A23 RID: 23075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A23")]
		[Address(RVA = "0xA2FF80", Offset = "0xA2E980", VA = "0x180A2FF80")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendCookOperation(OvenCookOperation operation)
		{
		}

		// Token: 0x06005A24 RID: 23076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A24")]
		[Address(RVA = "0xA301F0", Offset = "0xA2EBF0", VA = "0x180A301F0")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public void SetCookOperation(NetworkConnection conn, OvenCookOperation operation, bool playButtonPress)
		{
		}

		// Token: 0x06005A25 RID: 23077 RVA: 0x00016110 File Offset: 0x00014310
		[Token(Token = "0x6005A25")]
		[Address(RVA = "0xA2BFC0", Offset = "0xA2A9C0", VA = "0x180A2BFC0")]
		public bool IsReadyToStart()
		{
			return default(bool);
		}

		// Token: 0x06005A26 RID: 23078 RVA: 0x00016128 File Offset: 0x00014328
		[Token(Token = "0x6005A26")]
		[Address(RVA = "0xA2BF80", Offset = "0xA2A980", VA = "0x180A2BF80")]
		public bool IsReadyForHarvest()
		{
			return default(bool);
		}

		// Token: 0x06005A27 RID: 23079 RVA: 0x00016140 File Offset: 0x00014340
		[Token(Token = "0x6005A27")]
		[Address(RVA = "0xA29E80", Offset = "0xA28880", VA = "0x180A29E80")]
		public bool CanOutputSpaceFitCurrentOperation()
		{
			return default(bool);
		}

		// Token: 0x06005A28 RID: 23080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A28")]
		[Address(RVA = "0xA307B0", Offset = "0xA2F1B0", VA = "0x180A307B0")]
		public void SetLiquidColor(Color col)
		{
		}

		// Token: 0x06005A29 RID: 23081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A29")]
		[Address(RVA = "0xA31ED0", Offset = "0xA308D0", VA = "0x180A31ED0")]
		private void UpdateLiquid()
		{
		}

		// Token: 0x06005A2A RID: 23082 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A2A")]
		[Address(RVA = "0xA2A9B0", Offset = "0xA293B0", VA = "0x180A2A9B0")]
		public StationItem[] CreateStationItems(int quantity = 1)
		{
			return null;
		}

		// Token: 0x06005A2B RID: 23083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A2B")]
		[Address(RVA = "0xA2D0F0", Offset = "0xA2BAF0", VA = "0x180A2D0F0")]
		public void ResetPourableContainer()
		{
		}

		// Token: 0x06005A2C RID: 23084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A2C")]
		[Address(RVA = "0xA2D160", Offset = "0xA2BB60", VA = "0x180A2D160")]
		public void ResetSquareTray()
		{
		}

		// Token: 0x06005A2D RID: 23085 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A2D")]
		[Address(RVA = "0xA2A520", Offset = "0xA28F20", VA = "0x180A2A520")]
		public LabOvenHammer CreateHammer()
		{
			return null;
		}

		// Token: 0x06005A2E RID: 23086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A2E")]
		[Address(RVA = "0xA2A6B0", Offset = "0xA290B0", VA = "0x180A2A6B0")]
		public void CreateImpactEffects(Vector3 point, bool playSound = true)
		{
		}

		// Token: 0x06005A2F RID: 23087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A2F")]
		[Address(RVA = "0xA31880", Offset = "0xA30280", VA = "0x180A31880")]
		public void Shatter(int shardQuantity, GameObject shardPrefab)
		{
		}

		// Token: 0x06005A30 RID: 23088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A30")]
		[Address(RVA = "0xA2A0B0", Offset = "0xA28AB0", VA = "0x180A2A0B0")]
		public void ClearShards()
		{
		}

		// Token: 0x06005A31 RID: 23089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A31")]
		[Address(RVA = "0xA29FB0", Offset = "0xA289B0", VA = "0x180A29FB0")]
		public void ClearDecals()
		{
		}

		// Token: 0x06005A32 RID: 23090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A32")]
		[Address(RVA = "0xA316E0", Offset = "0xA300E0", VA = "0x180A316E0", Slot = "80")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetStoredInstance(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x06005A33 RID: 23091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A33")]
		[Address(RVA = "0xA31420", Offset = "0xA2FE20", VA = "0x180A31420")]
		[TargetRpc(RunLocally = true)]
		[ObserversRpc(RunLocally = true)]
		private void SetStoredInstance_Internal(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x06005A34 RID: 23092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A34")]
		[Address(RVA = "0xA30640", Offset = "0xA2F040", VA = "0x180A30640", Slot = "81")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetItemSlotQuantity(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x06005A35 RID: 23093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A35")]
		[Address(RVA = "0xA30490", Offset = "0xA2EE90", VA = "0x180A30490")]
		[ObserversRpc(RunLocally = true)]
		private void SetItemSlotQuantity_Internal(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x06005A36 RID: 23094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A36")]
		[Address(RVA = "0xA31230", Offset = "0xA2FC30", VA = "0x180A31230", Slot = "82")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetSlotLocked(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x06005A37 RID: 23095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A37")]
		[Address(RVA = "0xA30F00", Offset = "0xA2F900", VA = "0x180A30F00")]
		[TargetRpc(RunLocally = true)]
		[ObserversRpc(RunLocally = true)]
		private void SetSlotLocked_Internal(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x06005A38 RID: 23096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A38")]
		[Address(RVA = "0xA30D60", Offset = "0xA2F760", VA = "0x180A30D60", Slot = "83")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetSlotFilter(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x06005A39 RID: 23097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A39")]
		[Address(RVA = "0xA30AA0", Offset = "0xA2F4A0", VA = "0x180A30AA0")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc(RunLocally = true)]
		private void SetSlotFilter_Internal(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x06005A3A RID: 23098 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A3A")]
		[Address(RVA = "0xA2AE70", Offset = "0xA29870", VA = "0x180A2AE70", Slot = "123")]
		public WorldspaceUIElement CreateWorldspaceUI()
		{
			return null;
		}

		// Token: 0x06005A3B RID: 23099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A3B")]
		[Address(RVA = "0xA2B3E0", Offset = "0xA29DE0", VA = "0x180A2B3E0", Slot = "124")]
		public void DestroyWorldspaceUI()
		{
		}

		// Token: 0x06005A3C RID: 23100 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A3C")]
		[Address(RVA = "0xA2B5C0", Offset = "0xA29FC0", VA = "0x180A2B5C0", Slot = "60")]
		public override BuildableItemData GetBaseData()
		{
			return null;
		}

		// Token: 0x06005A3D RID: 23101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A3D")]
		[Address(RVA = "0xA2B8E0", Offset = "0xA2A2E0", VA = "0x180A2B8E0", Slot = "59")]
		public override DynamicSaveData GetSaveData()
		{
			return null;
		}

		// Token: 0x06005A3E RID: 23102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A3E")]
		[Address(RVA = "0xA325F0", Offset = "0xA30FF0", VA = "0x180A325F0")]
		public LabOven()
		{
		}

		// Token: 0x06005A3F RID: 23103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A3F")]
		[Address(RVA = "0xA2C270", Offset = "0xA2AC70", VA = "0x180A2C270", Slot = "62")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06005A40 RID: 23104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A40")]
		[Address(RVA = "0xA2C1E0", Offset = "0xA2ABE0", VA = "0x180A2C1E0", Slot = "63")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06005A41 RID: 23105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A41")]
		[Address(RVA = "0x669880", Offset = "0x668280", VA = "0x180669880", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06005A42 RID: 23106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A42")]
		[Address(RVA = "0xA2EED0", Offset = "0xA2D8D0", VA = "0x180A2EED0")]
		private void RpcWriter___Server_SetConfigurer_3323014238(NetworkObject player)
		{
		}

		// Token: 0x06005A43 RID: 23107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A43")]
		[Address(RVA = "0xA2D230", Offset = "0xA2BC30", VA = "0x180A2D230", Slot = "131")]
		public void RpcLogic___SetConfigurer_3323014238(NetworkObject player)
		{
		}

		// Token: 0x06005A44 RID: 23108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A44")]
		[Address(RVA = "0xA2DDD0", Offset = "0xA2C7D0", VA = "0x180A2DDD0")]
		private void RpcReader___Server_SetConfigurer_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06005A45 RID: 23109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A45")]
		[Address(RVA = "0xA2F2B0", Offset = "0xA2DCB0", VA = "0x180A2F2B0")]
		private void RpcWriter___Server_SetPlayerUser_3323014238(NetworkObject playerObject)
		{
		}

		// Token: 0x06005A46 RID: 23110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A46")]
		[Address(RVA = "0xA2D5E0", Offset = "0xA2BFE0", VA = "0x180A2D5E0", Slot = "132")]
		public void RpcLogic___SetPlayerUser_3323014238(NetworkObject playerObject)
		{
		}

		// Token: 0x06005A47 RID: 23111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A47")]
		[Address(RVA = "0xA2DF80", Offset = "0xA2C980", VA = "0x180A2DF80")]
		private void RpcReader___Server_SetPlayerUser_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06005A48 RID: 23112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A48")]
		[Address(RVA = "0xA2F180", Offset = "0xA2DB80", VA = "0x180A2F180")]
		private void RpcWriter___Server_SetNPCUser_3323014238(NetworkObject npcObject)
		{
		}

		// Token: 0x06005A49 RID: 23113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A49")]
		[Address(RVA = "0xA2D540", Offset = "0xA2BF40", VA = "0x180A2D540", Slot = "133")]
		public void RpcLogic___SetNPCUser_3323014238(NetworkObject npcObject)
		{
		}

		// Token: 0x06005A4A RID: 23114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A4A")]
		[Address(RVA = "0xA2DF00", Offset = "0xA2C900", VA = "0x180A2DF00")]
		private void RpcReader___Server_SetNPCUser_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06005A4B RID: 23115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A4B")]
		[Address(RVA = "0xA2EDA0", Offset = "0xA2D7A0", VA = "0x180A2EDA0")]
		private void RpcWriter___Server_SendCookOperation_3708012700(OvenCookOperation operation)
		{
		}

		// Token: 0x06005A4C RID: 23116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A4C")]
		[Address(RVA = "0xA2D210", Offset = "0xA2BC10", VA = "0x180A2D210")]
		public void RpcLogic___SendCookOperation_3708012700(OvenCookOperation operation)
		{
		}

		// Token: 0x06005A4D RID: 23117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A4D")]
		[Address(RVA = "0xA2DD50", Offset = "0xA2C750", VA = "0x180A2DD50")]
		private void RpcReader___Server_SendCookOperation_3708012700(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06005A4E RID: 23118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A4E")]
		[Address(RVA = "0xA2E610", Offset = "0xA2D010", VA = "0x180A2E610")]
		private void RpcWriter___Observers_SetCookOperation_2611294368(NetworkConnection conn, OvenCookOperation operation, bool playButtonPress)
		{
		}

		// Token: 0x06005A4F RID: 23119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A4F")]
		[Address(RVA = "0xA2D2D0", Offset = "0xA2BCD0", VA = "0x180A2D2D0")]
		public void RpcLogic___SetCookOperation_2611294368(NetworkConnection conn, OvenCookOperation operation, bool playButtonPress)
		{
		}

		// Token: 0x06005A50 RID: 23120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A50")]
		[Address(RVA = "0xA2D9F0", Offset = "0xA2C3F0", VA = "0x180A2D9F0")]
		private void RpcReader___Observers_SetCookOperation_2611294368(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06005A51 RID: 23121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A51")]
		[Address(RVA = "0xA2F850", Offset = "0xA2E250", VA = "0x180A2F850")]
		private void RpcWriter___Target_SetCookOperation_2611294368(NetworkConnection conn, OvenCookOperation operation, bool playButtonPress)
		{
		}

		// Token: 0x06005A52 RID: 23122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A52")]
		[Address(RVA = "0xA2E330", Offset = "0xA2CD30", VA = "0x180A2E330")]
		private void RpcReader___Target_SetCookOperation_2611294368(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06005A53 RID: 23123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A53")]
		[Address(RVA = "0xA2F6E0", Offset = "0xA2E0E0", VA = "0x180A2F6E0")]
		private void RpcWriter___Server_SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x06005A54 RID: 23124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A54")]
		[Address(RVA = "0xA2D8B0", Offset = "0xA2C2B0", VA = "0x180A2D8B0", Slot = "134")]
		public void RpcLogic___SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x06005A55 RID: 23125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A55")]
		[Address(RVA = "0xA2E240", Offset = "0xA2CC40", VA = "0x180A2E240")]
		private void RpcReader___Server_SetStoredInstance_2652194801(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06005A56 RID: 23126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A56")]
		[Address(RVA = "0xA2EC20", Offset = "0xA2D620", VA = "0x180A2EC20")]
		private void RpcWriter___Observers_SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x06005A57 RID: 23127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A57")]
		[Address(RVA = "0xA2D930", Offset = "0xA2C330", VA = "0x180A2D930")]
		private void RpcLogic___SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x06005A58 RID: 23128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A58")]
		[Address(RVA = "0xA2DCC0", Offset = "0xA2C6C0", VA = "0x180A2DCC0")]
		private void RpcReader___Observers_SetStoredInstance_Internal_2652194801(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06005A59 RID: 23129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A59")]
		[Address(RVA = "0xA2FCB0", Offset = "0xA2E6B0", VA = "0x180A2FCB0")]
		private void RpcWriter___Target_SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x06005A5A RID: 23130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A5A")]
		[Address(RVA = "0xA2E570", Offset = "0xA2CF70", VA = "0x180A2E570")]
		private void RpcReader___Target_SetStoredInstance_Internal_2652194801(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06005A5B RID: 23131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A5B")]
		[Address(RVA = "0xA2F000", Offset = "0xA2DA00", VA = "0x180A2F000")]
		private void RpcWriter___Server_SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x06005A5C RID: 23132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A5C")]
		[Address(RVA = "0xA2D4B0", Offset = "0xA2BEB0", VA = "0x180A2D4B0", Slot = "135")]
		public void RpcLogic___SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x06005A5D RID: 23133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A5D")]
		[Address(RVA = "0xA2DE50", Offset = "0xA2C850", VA = "0x180A2DE50")]
		private void RpcReader___Server_SetItemSlotQuantity_1692629761(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06005A5E RID: 23134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A5E")]
		[Address(RVA = "0xA2E780", Offset = "0xA2D180", VA = "0x180A2E780")]
		private void RpcWriter___Observers_SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x06005A5F RID: 23135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A5F")]
		[Address(RVA = "0xA2D4C0", Offset = "0xA2BEC0", VA = "0x180A2D4C0")]
		private void RpcLogic___SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x06005A60 RID: 23136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A60")]
		[Address(RVA = "0xA2DAA0", Offset = "0xA2C4A0", VA = "0x180A2DAA0")]
		private void RpcReader___Observers_SetItemSlotQuantity_Internal_1692629761(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06005A61 RID: 23137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A61")]
		[Address(RVA = "0xA2F550", Offset = "0xA2DF50", VA = "0x180A2F550")]
		private void RpcWriter___Server_SetSlotLocked_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x06005A62 RID: 23138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A62")]
		[Address(RVA = "0xA2D780", Offset = "0xA2C180", VA = "0x180A2D780", Slot = "136")]
		public void RpcLogic___SetSlotLocked_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x06005A63 RID: 23139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A63")]
		[Address(RVA = "0xA2E0F0", Offset = "0xA2CAF0", VA = "0x180A2E0F0")]
		private void RpcReader___Server_SetSlotLocked_3170825843(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06005A64 RID: 23140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A64")]
		[Address(RVA = "0xA2FB20", Offset = "0xA2E520", VA = "0x180A2FB20")]
		private void RpcWriter___Target_SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x06005A65 RID: 23141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A65")]
		[Address(RVA = "0xA2D800", Offset = "0xA2C200", VA = "0x180A2D800")]
		private void RpcLogic___SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x06005A66 RID: 23142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A66")]
		[Address(RVA = "0xA2E470", Offset = "0xA2CE70", VA = "0x180A2E470")]
		private void RpcReader___Target_SetSlotLocked_Internal_3170825843(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06005A67 RID: 23143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A67")]
		[Address(RVA = "0xA2EA80", Offset = "0xA2D480", VA = "0x180A2EA80")]
		private void RpcWriter___Observers_SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x06005A68 RID: 23144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A68")]
		[Address(RVA = "0xA2DBD0", Offset = "0xA2C5D0", VA = "0x180A2DBD0")]
		private void RpcReader___Observers_SetSlotLocked_Internal_3170825843(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06005A69 RID: 23145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A69")]
		[Address(RVA = "0xA2F3E0", Offset = "0xA2DDE0", VA = "0x180A2F3E0")]
		private void RpcWriter___Server_SetSlotFilter_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x06005A6A RID: 23146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A6A")]
		[Address(RVA = "0xA2D680", Offset = "0xA2C080", VA = "0x180A2D680", Slot = "137")]
		public void RpcLogic___SetSlotFilter_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x06005A6B RID: 23147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A6B")]
		[Address(RVA = "0xA2E000", Offset = "0xA2CA00", VA = "0x180A2E000")]
		private void RpcReader___Server_SetSlotFilter_527532783(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06005A6C RID: 23148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A6C")]
		[Address(RVA = "0xA2E900", Offset = "0xA2D300", VA = "0x180A2E900")]
		private void RpcWriter___Observers_SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x06005A6D RID: 23149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A6D")]
		[Address(RVA = "0xA2D700", Offset = "0xA2C100", VA = "0x180A2D700")]
		private void RpcLogic___SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x06005A6E RID: 23150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A6E")]
		[Address(RVA = "0xA2DB40", Offset = "0xA2C540", VA = "0x180A2DB40")]
		private void RpcReader___Observers_SetSlotFilter_Internal_527532783(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06005A6F RID: 23151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A6F")]
		[Address(RVA = "0xA2F9B0", Offset = "0xA2E3B0", VA = "0x180A2F9B0")]
		private void RpcWriter___Target_SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x06005A70 RID: 23152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A70")]
		[Address(RVA = "0xA2E3D0", Offset = "0xA2CDD0", VA = "0x180A2E3D0")]
		private void RpcReader___Target_SetSlotFilter_Internal_527532783(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x17000C99 RID: 3225
		// (get) Token: 0x06005A71 RID: 23153 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005A72 RID: 23154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C99")]
		public NetworkObject SyncAccessor_<NPCUserObject>k__BackingField
		{
			[Token(Token = "0x6005A71")]
			[Address(RVA = "0x68D390", Offset = "0x68BD90", VA = "0x18068D390")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005A72")]
			[Address(RVA = "0xA329B0", Offset = "0xA313B0", VA = "0x180A329B0")]
			set
			{
			}
		}

		// Token: 0x06005A73 RID: 23155 RVA: 0x00016158 File Offset: 0x00014358
		[Token(Token = "0x6005A73")]
		[Address(RVA = "0xA2CF50", Offset = "0xA2B950", VA = "0x180A2CF50", Slot = "138")]
		public virtual bool ReadSyncVar___ScheduleOne.ObjectScripts.LabOven(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return default(bool);
		}

		// Token: 0x17000C9A RID: 3226
		// (get) Token: 0x06005A74 RID: 23156 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005A75 RID: 23157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C9A")]
		public NetworkObject SyncAccessor_<PlayerUserObject>k__BackingField
		{
			[Token(Token = "0x6005A74")]
			[Address(RVA = "0xA32770", Offset = "0xA31170", VA = "0x180A32770")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005A75")]
			[Address(RVA = "0xA32A70", Offset = "0xA31470", VA = "0x180A32A70")]
			set
			{
			}
		}

		// Token: 0x17000C9B RID: 3227
		// (get) Token: 0x06005A76 RID: 23158 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005A77 RID: 23159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C9B")]
		public NetworkObject SyncAccessor_<CurrentPlayerConfigurer>k__BackingField
		{
			[Token(Token = "0x6005A76")]
			[Address(RVA = "0x68D3E0", Offset = "0x68BDE0", VA = "0x18068D3E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005A77")]
			[Address(RVA = "0xA328F0", Offset = "0xA312F0", VA = "0x180A328F0")]
			set
			{
			}
		}

		// Token: 0x06005A78 RID: 23160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A78")]
		[Address(RVA = "0xA29AD0", Offset = "0xA284D0", VA = "0x180A29AD0", Slot = "139")]
		protected virtual void Awake_UserLogic_ScheduleOne.ObjectScripts.LabOven_Assembly-CSharp.dll()
		{
		}

		// Token: 0x040041DF RID: 16863
		[Token(Token = "0x40041DF")]
		public const int SOLID_INGREDIENT_COOK_LIMIT = 10;

		// Token: 0x040041E0 RID: 16864
		[Token(Token = "0x40041E0")]
		public const float FOV_OVERRIDE = 70f;

		// Token: 0x040041E3 RID: 16867
		[Token(Token = "0x40041E3")]
		[FieldOffset(Offset = "0x228")]
		public LabOven.ELightMode LightMode;

		// Token: 0x040041E4 RID: 16868
		[Token(Token = "0x40041E4")]
		[FieldOffset(Offset = "0x230")]
		[Header("References")]
		public Transform CameraPosition_Default;

		// Token: 0x040041E5 RID: 16869
		[Token(Token = "0x40041E5")]
		[FieldOffset(Offset = "0x238")]
		public Transform CameraPosition_Pour;

		// Token: 0x040041E6 RID: 16870
		[Token(Token = "0x40041E6")]
		[FieldOffset(Offset = "0x240")]
		public Transform CameraPosition_PlaceItems;

		// Token: 0x040041E7 RID: 16871
		[Token(Token = "0x40041E7")]
		[FieldOffset(Offset = "0x248")]
		public Transform CameraPosition_Breaking;

		// Token: 0x040041E8 RID: 16872
		[Token(Token = "0x40041E8")]
		[FieldOffset(Offset = "0x250")]
		public InteractableObject IntObj;

		// Token: 0x040041E9 RID: 16873
		[Token(Token = "0x40041E9")]
		[FieldOffset(Offset = "0x258")]
		public LabOvenDoor Door;

		// Token: 0x040041EA RID: 16874
		[Token(Token = "0x40041EA")]
		[FieldOffset(Offset = "0x260")]
		public LabOvenWireTray WireTray;

		// Token: 0x040041EB RID: 16875
		[Token(Token = "0x40041EB")]
		[FieldOffset(Offset = "0x268")]
		public ToggleableLight OvenLight;

		// Token: 0x040041EC RID: 16876
		[Token(Token = "0x40041EC")]
		[FieldOffset(Offset = "0x270")]
		public LabOvenButton Button;

		// Token: 0x040041ED RID: 16877
		[Token(Token = "0x40041ED")]
		[FieldOffset(Offset = "0x278")]
		public TextMeshPro TimerLabel;

		// Token: 0x040041EE RID: 16878
		[Token(Token = "0x40041EE")]
		[FieldOffset(Offset = "0x280")]
		public ToggleableLight Light;

		// Token: 0x040041EF RID: 16879
		[Token(Token = "0x40041EF")]
		[FieldOffset(Offset = "0x288")]
		public Transform PourableContainer;

		// Token: 0x040041F0 RID: 16880
		[Token(Token = "0x40041F0")]
		[FieldOffset(Offset = "0x290")]
		public Transform ItemContainer;

		// Token: 0x040041F1 RID: 16881
		[Token(Token = "0x40041F1")]
		[FieldOffset(Offset = "0x298")]
		public Animation PourAnimation;

		// Token: 0x040041F2 RID: 16882
		[Token(Token = "0x40041F2")]
		[FieldOffset(Offset = "0x2A0")]
		public SkinnedMeshRenderer LiquidMesh;

		// Token: 0x040041F3 RID: 16883
		[Token(Token = "0x40041F3")]
		[FieldOffset(Offset = "0x2A8")]
		public StorageVisualizer InputVisuals;

		// Token: 0x040041F4 RID: 16884
		[Token(Token = "0x40041F4")]
		[FieldOffset(Offset = "0x2B0")]
		public StorageVisualizer OutputVisuals;

		// Token: 0x040041F5 RID: 16885
		[Token(Token = "0x40041F5")]
		[FieldOffset(Offset = "0x2B8")]
		public MeshRenderer CookedLiquidMesh;

		// Token: 0x040041F6 RID: 16886
		[Token(Token = "0x40041F6")]
		[FieldOffset(Offset = "0x2C0")]
		public Animation RemoveTrayAnimation;

		// Token: 0x040041F7 RID: 16887
		[Token(Token = "0x40041F7")]
		[FieldOffset(Offset = "0x2C8")]
		public Transform SquareTray;

		// Token: 0x040041F8 RID: 16888
		[Token(Token = "0x40041F8")]
		[FieldOffset(Offset = "0x2D0")]
		public Transform HammerSpawnPoint;

		// Token: 0x040041F9 RID: 16889
		[Token(Token = "0x40041F9")]
		[FieldOffset(Offset = "0x2D8")]
		public Transform HammerContainer;

		// Token: 0x040041FA RID: 16890
		[Token(Token = "0x40041FA")]
		[FieldOffset(Offset = "0x2E0")]
		public Transform OafBastard;

		// Token: 0x040041FB RID: 16891
		[Token(Token = "0x40041FB")]
		[FieldOffset(Offset = "0x2E8")]
		public Transform DecalContainer;

		// Token: 0x040041FC RID: 16892
		[Token(Token = "0x40041FC")]
		[FieldOffset(Offset = "0x2F0")]
		public Transform DecalMaxBounds;

		// Token: 0x040041FD RID: 16893
		[Token(Token = "0x40041FD")]
		[FieldOffset(Offset = "0x2F8")]
		public Transform DecalMinBounds;

		// Token: 0x040041FE RID: 16894
		[Token(Token = "0x40041FE")]
		[FieldOffset(Offset = "0x300")]
		public BoxCollider CookedLiquidCollider;

		// Token: 0x040041FF RID: 16895
		[Token(Token = "0x40041FF")]
		[FieldOffset(Offset = "0x308")]
		public Transform[] ShardSpawnPoints;

		// Token: 0x04004200 RID: 16896
		[Token(Token = "0x4004200")]
		[FieldOffset(Offset = "0x310")]
		public ParticleSystem ShatterParticles;

		// Token: 0x04004201 RID: 16897
		[Token(Token = "0x4004201")]
		[FieldOffset(Offset = "0x318")]
		public Transform uiPoint;

		// Token: 0x04004202 RID: 16898
		[Token(Token = "0x4004202")]
		[FieldOffset(Offset = "0x320")]
		public Transform[] accessPoints;

		// Token: 0x04004203 RID: 16899
		[Token(Token = "0x4004203")]
		[FieldOffset(Offset = "0x328")]
		public ConfigurationReplicator configReplicator;

		// Token: 0x04004204 RID: 16900
		[Token(Token = "0x4004204")]
		[FieldOffset(Offset = "0x330")]
		public Transform[] SolidIngredientSpawnPoints;

		// Token: 0x04004205 RID: 16901
		[Token(Token = "0x4004205")]
		[FieldOffset(Offset = "0x338")]
		public BoxCollider TrayDetectionArea;

		// Token: 0x04004206 RID: 16902
		[Token(Token = "0x4004206")]
		[FieldOffset(Offset = "0x340")]
		[Header("Sounds")]
		public AudioSourceController ButtonSound;

		// Token: 0x04004207 RID: 16903
		[Token(Token = "0x4004207")]
		[FieldOffset(Offset = "0x348")]
		public AudioSourceController DingSound;

		// Token: 0x04004208 RID: 16904
		[Token(Token = "0x4004208")]
		[FieldOffset(Offset = "0x350")]
		public AudioSourceController RunLoopSound;

		// Token: 0x04004209 RID: 16905
		[Token(Token = "0x4004209")]
		[FieldOffset(Offset = "0x358")]
		public AudioSourceController ImpactSound;

		// Token: 0x0400420A RID: 16906
		[Token(Token = "0x400420A")]
		[FieldOffset(Offset = "0x360")]
		public AudioSourceController ShatterSound;

		// Token: 0x0400420B RID: 16907
		[Token(Token = "0x400420B")]
		[FieldOffset(Offset = "0x368")]
		[Header("UI")]
		public LabOvenUIElement WorldspaceUIPrefab;

		// Token: 0x0400420C RID: 16908
		[Token(Token = "0x400420C")]
		[FieldOffset(Offset = "0x370")]
		public Sprite typeIcon;

		// Token: 0x0400420D RID: 16909
		[Token(Token = "0x400420D")]
		[FieldOffset(Offset = "0x378")]
		[Header("Prefabs")]
		public LabOvenHammer HammerPrefab;

		// Token: 0x0400420E RID: 16910
		[Token(Token = "0x400420E")]
		[FieldOffset(Offset = "0x380")]
		public GameObject SmashDecalPrefab;

		// Token: 0x04004211 RID: 16913
		[Token(Token = "0x4004211")]
		[FieldOffset(Offset = "0x398")]
		public ItemSlot IngredientSlot;

		// Token: 0x04004212 RID: 16914
		[Token(Token = "0x4004212")]
		[FieldOffset(Offset = "0x3A0")]
		public ItemSlot OutputSlot;

		// Token: 0x0400421A RID: 16922
		[Token(Token = "0x400421A")]
		[FieldOffset(Offset = "0x3D8")]
		private Vector3 pourableContainerDefaultPos;

		// Token: 0x0400421B RID: 16923
		[Token(Token = "0x400421B")]
		[FieldOffset(Offset = "0x3E4")]
		private Quaternion pourableContainerDefaultRot;

		// Token: 0x0400421C RID: 16924
		[Token(Token = "0x400421C")]
		[FieldOffset(Offset = "0x3F4")]
		private Vector3 squareTrayDefaultPos;

		// Token: 0x0400421D RID: 16925
		[Token(Token = "0x400421D")]
		[FieldOffset(Offset = "0x400")]
		private Quaternion squareTrayDefaultRot;

		// Token: 0x0400421E RID: 16926
		[Token(Token = "0x400421E")]
		[FieldOffset(Offset = "0x410")]
		private List<GameObject> decals;

		// Token: 0x0400421F RID: 16927
		[Token(Token = "0x400421F")]
		[FieldOffset(Offset = "0x418")]
		private List<GameObject> shards;

		// Token: 0x04004220 RID: 16928
		[Token(Token = "0x4004220")]
		[FieldOffset(Offset = "0x420")]
		public SyncVar<NetworkObject> syncVar___<NPCUserObject>k__BackingField;

		// Token: 0x04004221 RID: 16929
		[Token(Token = "0x4004221")]
		[FieldOffset(Offset = "0x428")]
		public SyncVar<NetworkObject> syncVar___<PlayerUserObject>k__BackingField;

		// Token: 0x04004222 RID: 16930
		[Token(Token = "0x4004222")]
		[FieldOffset(Offset = "0x430")]
		public SyncVar<NetworkObject> syncVar___<CurrentPlayerConfigurer>k__BackingField;

		// Token: 0x04004223 RID: 16931
		[Token(Token = "0x4004223")]
		[FieldOffset(Offset = "0x438")]
		private bool NetworkInitialize___EarlyScheduleOne.ObjectScripts.LabOvenAssembly-CSharp.dll_Excuted;

		// Token: 0x04004224 RID: 16932
		[Token(Token = "0x4004224")]
		[FieldOffset(Offset = "0x439")]
		private bool NetworkInitialize__LateScheduleOne.ObjectScripts.LabOvenAssembly-CSharp.dll_Excuted;

		// Token: 0x02000CAC RID: 3244
		[Token(Token = "0x2000CAC")]
		public enum ELightMode
		{
			// Token: 0x04004226 RID: 16934
			[Token(Token = "0x4004226")]
			Off,
			// Token: 0x04004227 RID: 16935
			[Token(Token = "0x4004227")]
			On,
			// Token: 0x04004228 RID: 16936
			[Token(Token = "0x4004228")]
			Flash
		}

		// Token: 0x02000CAD RID: 3245
		[Token(Token = "0x2000CAD")]
		public enum EState
		{
			// Token: 0x0400422A RID: 16938
			[Token(Token = "0x400422A")]
			CanBegin,
			// Token: 0x0400422B RID: 16939
			[Token(Token = "0x400422B")]
			MissingItems,
			// Token: 0x0400422C RID: 16940
			[Token(Token = "0x400422C")]
			InsufficentProduct,
			// Token: 0x0400422D RID: 16941
			[Token(Token = "0x400422D")]
			OutputSlotFull,
			// Token: 0x0400422E RID: 16942
			[Token(Token = "0x400422E")]
			Mismatch
		}
	}
}
