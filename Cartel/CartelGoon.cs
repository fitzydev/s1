using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Combat;
using ScheduleOne.NPCs;
using UnityEngine;

namespace ScheduleOne.Cartel
{
	// Token: 0x0200080F RID: 2063
	[Token(Token = "0x200080F")]
	public class CartelGoon : NPC
	{
		// Token: 0x17000812 RID: 2066
		// (get) Token: 0x060038BA RID: 14522 RVA: 0x0000F498 File Offset: 0x0000D698
		// (set) Token: 0x060038BB RID: 14523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000812")]
		public bool IsGoonSpawned
		{
			[Token(Token = "0x60038BA")]
			[Address(RVA = "0x6DFF10", Offset = "0x6DE910", VA = "0x1806DFF10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60038BB")]
			[Address(RVA = "0x6E0030", Offset = "0x6DEA30", VA = "0x1806E0030")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000813 RID: 2067
		// (get) Token: 0x060038BC RID: 14524 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000813")]
		public GoonPool GoonPool
		{
			[Token(Token = "0x60038BC")]
			[Address(RVA = "0x8054E0", Offset = "0x803EE0", VA = "0x1808054E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060038BD RID: 14525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038BD")]
		[Address(RVA = "0x8053B0", Offset = "0x803DB0", VA = "0x1808053B0", Slot = "70")]
		protected override void Start()
		{
		}

		// Token: 0x060038BE RID: 14526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038BE")]
		[Address(RVA = "0x804270", Offset = "0x802C70", VA = "0x180804270", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x060038BF RID: 14527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038BF")]
		[Address(RVA = "0x8051D0", Offset = "0x803BD0", VA = "0x1808051D0")]
		public void Spawn(GoonPool pool, Vector3 spawnPoint)
		{
		}

		// Token: 0x060038C0 RID: 14528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038C0")]
		[Address(RVA = "0x804F80", Offset = "0x803980", VA = "0x180804F80")]
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		private void Spawn_Client(NetworkConnection conn)
		{
		}

		// Token: 0x060038C1 RID: 14529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038C1")]
		[Address(RVA = "0x803A70", Offset = "0x802470", VA = "0x180803A70")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		private void ConfigureGoonSettings(NetworkConnection conn, CartelGoonAppearance appearance, float moveSpeed)
		{
		}

		// Token: 0x060038C2 RID: 14530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038C2")]
		[Address(RVA = "0x803E40", Offset = "0x802840", VA = "0x180803E40")]
		public void Despawn()
		{
		}

		// Token: 0x060038C3 RID: 14531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038C3")]
		[Address(RVA = "0x803D20", Offset = "0x802720", VA = "0x180803D20")]
		[ObserversRpc(RunLocally = true)]
		private void Despawn_Client()
		{
		}

		// Token: 0x060038C4 RID: 14532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038C4")]
		[Address(RVA = "0x803820", Offset = "0x802220", VA = "0x180803820")]
		public void AttackEntity(ICombatTargetable target, bool includeGoonMates = true)
		{
		}

		// Token: 0x060038C5 RID: 14533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038C5")]
		[Address(RVA = "0x803710", Offset = "0x802110", VA = "0x180803710")]
		public void AddGoonMate(CartelGoon goonMate)
		{
		}

		// Token: 0x060038C6 RID: 14534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038C6")]
		[Address(RVA = "0x804300", Offset = "0x802D00", VA = "0x180804300")]
		public void RemoveGoonMate(CartelGoon goonMate)
		{
		}

		// Token: 0x060038C7 RID: 14535 RVA: 0x0000F4B0 File Offset: 0x0000D6B0
		[Token(Token = "0x60038C7")]
		[Address(RVA = "0x804060", Offset = "0x802A60", VA = "0x180804060")]
		public bool IsMatesWith(CartelGoon otherGoon)
		{
			return default(bool);
		}

		// Token: 0x060038C8 RID: 14536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038C8")]
		[Address(RVA = "0x805460", Offset = "0x803E60", VA = "0x180805460")]
		public CartelGoon()
		{
		}

		// Token: 0x060038C9 RID: 14537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038C9")]
		[Address(RVA = "0x8040C0", Offset = "0x802AC0", VA = "0x1808040C0", Slot = "99")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x060038CA RID: 14538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038CA")]
		[Address(RVA = "0x7199A0", Offset = "0x7183A0", VA = "0x1807199A0", Slot = "100")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x060038CB RID: 14539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038CB")]
		[Address(RVA = "0x687D80", Offset = "0x686780", VA = "0x180687D80", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x060038CC RID: 14540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038CC")]
		[Address(RVA = "0x804BD0", Offset = "0x8035D0", VA = "0x180804BD0")]
		private void RpcWriter___Observers_Spawn_Client_328543758(NetworkConnection conn)
		{
		}

		// Token: 0x060038CD RID: 14541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038CD")]
		[Address(RVA = "0x8046E0", Offset = "0x8030E0", VA = "0x1808046E0")]
		private void RpcLogic___Spawn_Client_328543758(NetworkConnection conn)
		{
		}

		// Token: 0x060038CE RID: 14542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038CE")]
		[Address(RVA = "0x804840", Offset = "0x803240", VA = "0x180804840")]
		private void RpcReader___Observers_Spawn_Client_328543758(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060038CF RID: 14543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038CF")]
		[Address(RVA = "0x804E50", Offset = "0x803850", VA = "0x180804E50")]
		private void RpcWriter___Target_Spawn_Client_328543758(NetworkConnection conn)
		{
		}

		// Token: 0x060038D0 RID: 14544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038D0")]
		[Address(RVA = "0x804900", Offset = "0x803300", VA = "0x180804900")]
		private void RpcReader___Target_Spawn_Client_328543758(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060038D1 RID: 14545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038D1")]
		[Address(RVA = "0x804940", Offset = "0x803340", VA = "0x180804940")]
		private void RpcWriter___Observers_ConfigureGoonSettings_3427656873(NetworkConnection conn, CartelGoonAppearance appearance, float moveSpeed)
		{
		}

		// Token: 0x060038D2 RID: 14546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038D2")]
		[Address(RVA = "0x804410", Offset = "0x802E10", VA = "0x180804410")]
		private void RpcLogic___ConfigureGoonSettings_3427656873(NetworkConnection conn, CartelGoonAppearance appearance, float moveSpeed)
		{
		}

		// Token: 0x060038D3 RID: 14547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038D3")]
		[Address(RVA = "0x804770", Offset = "0x803170", VA = "0x180804770")]
		private void RpcReader___Observers_ConfigureGoonSettings_3427656873(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060038D4 RID: 14548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038D4")]
		[Address(RVA = "0x804CF0", Offset = "0x8036F0", VA = "0x180804CF0")]
		private void RpcWriter___Target_ConfigureGoonSettings_3427656873(NetworkConnection conn, CartelGoonAppearance appearance, float moveSpeed)
		{
		}

		// Token: 0x060038D5 RID: 14549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038D5")]
		[Address(RVA = "0x804880", Offset = "0x803280", VA = "0x180804880")]
		private void RpcReader___Target_ConfigureGoonSettings_3427656873(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060038D6 RID: 14550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038D6")]
		[Address(RVA = "0x804AB0", Offset = "0x8034B0", VA = "0x180804AB0")]
		private void RpcWriter___Observers_Despawn_Client_2166136261()
		{
		}

		// Token: 0x060038D7 RID: 14551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038D7")]
		[Address(RVA = "0x804650", Offset = "0x803050", VA = "0x180804650")]
		private void RpcLogic___Despawn_Client_2166136261()
		{
		}

		// Token: 0x060038D8 RID: 14552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038D8")]
		[Address(RVA = "0x804800", Offset = "0x803200", VA = "0x180804800")]
		private void RpcReader___Observers_Despawn_Client_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060038D9 RID: 14553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038D9")]
		[Address(RVA = "0x68F8C0", Offset = "0x68E2C0", VA = "0x18068F8C0", Slot = "64")]
		public override void Awake()
		{
		}

		// Token: 0x0400276C RID: 10092
		[Token(Token = "0x400276C")]
		[FieldOffset(Offset = "0x2F8")]
		private List<CartelGoon> goonMates;

		// Token: 0x0400276D RID: 10093
		[Token(Token = "0x400276D")]
		[FieldOffset(Offset = "0x300")]
		private CartelGoonAppearance appearance;

		// Token: 0x0400276E RID: 10094
		[Token(Token = "0x400276E")]
		[FieldOffset(Offset = "0x308")]
		public Action onDespawn;

		// Token: 0x0400276F RID: 10095
		[Token(Token = "0x400276F")]
		[FieldOffset(Offset = "0x310")]
		private bool NetworkInitialize___EarlyScheduleOne.Cartel.CartelGoonAssembly-CSharp.dll_Excuted;

		// Token: 0x04002770 RID: 10096
		[Token(Token = "0x4002770")]
		[FieldOffset(Offset = "0x311")]
		private bool NetworkInitialize__LateScheduleOne.Cartel.CartelGoonAssembly-CSharp.dll_Excuted;
	}
}
