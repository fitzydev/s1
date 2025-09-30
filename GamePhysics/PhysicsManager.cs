using System;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;

namespace ScheduleOne.GamePhysics
{
	// Token: 0x02000386 RID: 902
	[Token(Token = "0x2000386")]
	public class PhysicsManager : NetworkSingleton<PhysicsManager>
	{
		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x06001424 RID: 5156 RVA: 0x00008370 File Offset: 0x00006570
		// (set) Token: 0x06001425 RID: 5157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003C7")]
		public float GravityMultiplier
		{
			[Token(Token = "0x6001424")]
			[Address(RVA = "0x5B3930", Offset = "0x5B2330", VA = "0x1805B3930")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6001425")]
			[Address(RVA = "0x5B3940", Offset = "0x5B2340", VA = "0x1805B3940")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06001426 RID: 5158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001426")]
		[Address(RVA = "0x5B2F00", Offset = "0x5B1900", VA = "0x1805B2F00", Slot = "20")]
		public override void Awake()
		{
		}

		// Token: 0x06001427 RID: 5159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001427")]
		[Address(RVA = "0x5B31A0", Offset = "0x5B1BA0", VA = "0x1805B31A0", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x06001428 RID: 5160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001428")]
		[Address(RVA = "0x5B3670", Offset = "0x5B2070", VA = "0x1805B3670")]
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		public void SetGravityMultiplier(NetworkConnection conn, float gravity)
		{
		}

		// Token: 0x06001429 RID: 5161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001429")]
		[Address(RVA = "0x5B38E0", Offset = "0x5B22E0", VA = "0x1805B38E0")]
		public PhysicsManager()
		{
		}

		// Token: 0x0600142A RID: 5162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600142A")]
		[Address(RVA = "0x5B30B0", Offset = "0x5B1AB0", VA = "0x1805B30B0", Slot = "22")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x0600142B RID: 5163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600142B")]
		[Address(RVA = "0x5B3060", Offset = "0x5B1A60", VA = "0x1805B3060", Slot = "23")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x0600142C RID: 5164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600142C")]
		[Address(RVA = "0x5B3020", Offset = "0x5B1A20", VA = "0x1805B3020", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x0600142D RID: 5165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600142D")]
		[Address(RVA = "0x5B33D0", Offset = "0x5B1DD0", VA = "0x1805B33D0")]
		private void RpcWriter___Observers_SetGravityMultiplier_530160725(NetworkConnection conn, float gravity)
		{
		}

		// Token: 0x0600142E RID: 5166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600142E")]
		[Address(RVA = "0x5B3200", Offset = "0x5B1C00", VA = "0x1805B3200")]
		public void RpcLogic___SetGravityMultiplier_530160725(NetworkConnection conn, float gravity)
		{
		}

		// Token: 0x0600142F RID: 5167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600142F")]
		[Address(RVA = "0x5B3300", Offset = "0x5B1D00", VA = "0x1805B3300")]
		private void RpcReader___Observers_SetGravityMultiplier_530160725(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001430 RID: 5168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001430")]
		[Address(RVA = "0x5B3510", Offset = "0x5B1F10", VA = "0x1805B3510")]
		private void RpcWriter___Target_SetGravityMultiplier_530160725(NetworkConnection conn, float gravity)
		{
		}

		// Token: 0x06001431 RID: 5169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001431")]
		[Address(RVA = "0x5B3370", Offset = "0x5B1D70", VA = "0x1805B3370")]
		private void RpcReader___Target_SetGravityMultiplier_530160725(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001432 RID: 5170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001432")]
		[Address(RVA = "0x5B2E10", Offset = "0x5B1810", VA = "0x1805B2E10", Slot = "25")]
		protected virtual void Awake_UserLogic_ScheduleOne.GamePhysics.PhysicsManager_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04001302 RID: 4866
		[Token(Token = "0x4001302")]
		public const bool AUTO_SYNC_TRANSFORMS = true;

		// Token: 0x04001304 RID: 4868
		[Token(Token = "0x4001304")]
		[FieldOffset(Offset = "0x124")]
		private bool NetworkInitialize___EarlyScheduleOne.GamePhysics.PhysicsManagerAssembly-CSharp.dll_Excuted;

		// Token: 0x04001305 RID: 4869
		[Token(Token = "0x4001305")]
		[FieldOffset(Offset = "0x125")]
		private bool NetworkInitialize__LateScheduleOne.GamePhysics.PhysicsManagerAssembly-CSharp.dll_Excuted;
	}
}
