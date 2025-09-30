using System;
using System.Collections.Generic;
using EasyButtons;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.Combat
{
	// Token: 0x020007A7 RID: 1959
	[Token(Token = "0x20007A7")]
	public class CombatManager : NetworkSingleton<CombatManager>
	{
		// Token: 0x060034D6 RID: 13526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034D6")]
		[Address(RVA = "0x796E30", Offset = "0x795830", VA = "0x180796E30")]
		[Button]
		public void CreateTestExplosion()
		{
		}

		// Token: 0x060034D7 RID: 13527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034D7")]
		[Address(RVA = "0x796BA0", Offset = "0x7955A0", VA = "0x180796BA0")]
		public void CreateExplosion(Vector3 origin, ExplosionData data)
		{
		}

		// Token: 0x060034D8 RID: 13528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034D8")]
		[Address(RVA = "0x796C20", Offset = "0x795620", VA = "0x180796C20")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		private void CreateExplosion(Vector3 origin, ExplosionData data, int id)
		{
		}

		// Token: 0x060034D9 RID: 13529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034D9")]
		[Address(RVA = "0x797130", Offset = "0x795B30", VA = "0x180797130")]
		[ObserversRpc(RunLocally = true)]
		private void Explosion(Vector3 origin, ExplosionData data, int id)
		{
		}

		// Token: 0x060034DA RID: 13530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034DA")]
		[Address(RVA = "0x797C90", Offset = "0x796690", VA = "0x180797C90")]
		public CombatManager()
		{
		}

		// Token: 0x060034DB RID: 13531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034DB")]
		[Address(RVA = "0x7973B0", Offset = "0x795DB0", VA = "0x1807973B0", Slot = "22")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x060034DC RID: 13532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034DC")]
		[Address(RVA = "0x797360", Offset = "0x795D60", VA = "0x180797360", Slot = "23")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x060034DD RID: 13533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034DD")]
		[Address(RVA = "0x5B3020", Offset = "0x5B1A20", VA = "0x1805B3020", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x060034DE RID: 13534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034DE")]
		[Address(RVA = "0x797AD0", Offset = "0x7964D0", VA = "0x180797AD0")]
		private void RpcWriter___Server_CreateExplosion_2907189355(Vector3 origin, ExplosionData data, int id)
		{
		}

		// Token: 0x060034DF RID: 13535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034DF")]
		[Address(RVA = "0x7974B0", Offset = "0x795EB0", VA = "0x1807974B0")]
		private void RpcLogic___CreateExplosion_2907189355(Vector3 origin, ExplosionData data, int id)
		{
		}

		// Token: 0x060034E0 RID: 13536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034E0")]
		[Address(RVA = "0x7977D0", Offset = "0x7961D0", VA = "0x1807977D0")]
		private void RpcReader___Server_CreateExplosion_2907189355(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060034E1 RID: 13537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034E1")]
		[Address(RVA = "0x7978F0", Offset = "0x7962F0", VA = "0x1807978F0")]
		private void RpcWriter___Observers_Explosion_2907189355(Vector3 origin, ExplosionData data, int id)
		{
		}

		// Token: 0x060034E2 RID: 13538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034E2")]
		[Address(RVA = "0x797500", Offset = "0x795F00", VA = "0x180797500")]
		private void RpcLogic___Explosion_2907189355(Vector3 origin, ExplosionData data, int id)
		{
		}

		// Token: 0x060034E3 RID: 13539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034E3")]
		[Address(RVA = "0x797690", Offset = "0x796090", VA = "0x180797690")]
		private void RpcReader___Observers_Explosion_2907189355(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060034E4 RID: 13540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034E4")]
		[Address(RVA = "0x796B30", Offset = "0x795530", VA = "0x180796B30", Slot = "20")]
		public override void Awake()
		{
		}

		// Token: 0x040024B7 RID: 9399
		[Token(Token = "0x40024B7")]
		[FieldOffset(Offset = "0x120")]
		public LayerMask MeleeLayerMask;

		// Token: 0x040024B8 RID: 9400
		[Token(Token = "0x40024B8")]
		[FieldOffset(Offset = "0x124")]
		public LayerMask ExplosionLayerMask;

		// Token: 0x040024B9 RID: 9401
		[Token(Token = "0x40024B9")]
		[FieldOffset(Offset = "0x128")]
		public LayerMask RangedWeaponLayerMask;

		// Token: 0x040024BA RID: 9402
		[Token(Token = "0x40024BA")]
		[FieldOffset(Offset = "0x130")]
		public Explosion ExplosionPrefab;

		// Token: 0x040024BB RID: 9403
		[Token(Token = "0x40024BB")]
		[FieldOffset(Offset = "0x138")]
		private List<int> explosionIDs;

		// Token: 0x040024BC RID: 9404
		[Token(Token = "0x40024BC")]
		[FieldOffset(Offset = "0x140")]
		private bool NetworkInitialize___EarlyScheduleOne.Combat.CombatManagerAssembly-CSharp.dll_Excuted;

		// Token: 0x040024BD RID: 9405
		[Token(Token = "0x40024BD")]
		[FieldOffset(Offset = "0x141")]
		private bool NetworkInitialize__LateScheduleOne.Combat.CombatManagerAssembly-CSharp.dll_Excuted;
	}
}
