using System;
using System.Collections.Generic;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Map;
using UnityEngine;

namespace ScheduleOne.Cartel
{
	// Token: 0x02000811 RID: 2065
	[Token(Token = "0x2000811")]
	public class CartelInfluence : NetworkBehaviour
	{
		// Token: 0x060038DC RID: 14556 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038DC")]
		[Address(RVA = "0x805AF0", Offset = "0x8044F0", VA = "0x180805AF0")]
		public CartelInfluence.RegionInfluenceData[] GetAllRegionInfluence()
		{
			return null;
		}

		// Token: 0x060038DD RID: 14557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038DD")]
		[Address(RVA = "0x805650", Offset = "0x804050", VA = "0x180805650", Slot = "19")]
		public virtual void Awake()
		{
		}

		// Token: 0x060038DE RID: 14558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038DE")]
		[Address(RVA = "0x806EB0", Offset = "0x8058B0", VA = "0x180806EB0")]
		private void Start()
		{
		}

		// Token: 0x060038DF RID: 14559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038DF")]
		[Address(RVA = "0x805DD0", Offset = "0x8047D0", VA = "0x180805DD0", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x060038E0 RID: 14560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038E0")]
		[Address(RVA = "0x805F30", Offset = "0x804930", VA = "0x180805F30", Slot = "16")]
		protected override void OnValidate()
		{
		}

		// Token: 0x060038E1 RID: 14561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038E1")]
		[Address(RVA = "0x805910", Offset = "0x804310", VA = "0x180805910")]
		public void ChangeInfluence(EMapRegion region, float amount)
		{
		}

		// Token: 0x060038E2 RID: 14562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038E2")]
		[Address(RVA = "0x806C10", Offset = "0x805610", VA = "0x180806C10")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public void SetInfluence(NetworkConnection conn, EMapRegion region, float influence)
		{
		}

		// Token: 0x060038E3 RID: 14563 RVA: 0x0000F4C8 File Offset: 0x0000D6C8
		[Token(Token = "0x60038E3")]
		[Address(RVA = "0x805B40", Offset = "0x804540", VA = "0x180805B40")]
		public float GetInfluence(EMapRegion region)
		{
			return 0f;
		}

		// Token: 0x060038E4 RID: 14564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038E4")]
		[Address(RVA = "0x805D50", Offset = "0x804750", VA = "0x180805D50")]
		private void OnSleepEnd()
		{
		}

		// Token: 0x060038E5 RID: 14565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038E5")]
		[Address(RVA = "0x805770", Offset = "0x804170", VA = "0x180805770")]
		[ObserversRpc(RunLocally = true)]
		private void ChangeInfluence(EMapRegion region, float oldInfluence, float newInfluence)
		{
		}

		// Token: 0x060038E6 RID: 14566 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038E6")]
		[Address(RVA = "0x805B70", Offset = "0x804570", VA = "0x180805B70")]
		private CartelInfluence.RegionInfluenceData GetRegionData(EMapRegion region)
		{
			return null;
		}

		// Token: 0x060038E7 RID: 14567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038E7")]
		[Address(RVA = "0x807000", Offset = "0x805A00", VA = "0x180807000")]
		public CartelInfluence()
		{
		}

		// Token: 0x060038E8 RID: 14568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038E8")]
		[Address(RVA = "0x805C40", Offset = "0x804640", VA = "0x180805C40", Slot = "20")]
		public virtual void NetworkInitialize___Early()
		{
		}

		// Token: 0x060038E9 RID: 14569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038E9")]
		[Address(RVA = "0x701280", Offset = "0x6FFC80", VA = "0x180701280", Slot = "21")]
		public virtual void NetworkInitialize__Late()
		{
		}

		// Token: 0x060038EA RID: 14570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038EA")]
		[Address(RVA = "0x6783D0", Offset = "0x676DD0", VA = "0x1806783D0", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x060038EB RID: 14571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038EB")]
		[Address(RVA = "0x806940", Offset = "0x805340", VA = "0x180806940")]
		private void RpcWriter___Observers_SetInfluence_2071772313(NetworkConnection conn, EMapRegion region, float influence)
		{
		}

		// Token: 0x060038EC RID: 14572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038EC")]
		[Address(RVA = "0x806520", Offset = "0x804F20", VA = "0x180806520")]
		public void RpcLogic___SetInfluence_2071772313(NetworkConnection conn, EMapRegion region, float influence)
		{
		}

		// Token: 0x060038ED RID: 14573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038ED")]
		[Address(RVA = "0x8066B0", Offset = "0x8050B0", VA = "0x1808066B0")]
		private void RpcReader___Observers_SetInfluence_2071772313(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060038EE RID: 14574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038EE")]
		[Address(RVA = "0x806AB0", Offset = "0x8054B0", VA = "0x180806AB0")]
		private void RpcWriter___Target_SetInfluence_2071772313(NetworkConnection conn, EMapRegion region, float influence)
		{
		}

		// Token: 0x060038EF RID: 14575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038EF")]
		[Address(RVA = "0x806740", Offset = "0x805140", VA = "0x180806740")]
		private void RpcReader___Target_SetInfluence_2071772313(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060038F0 RID: 14576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038F0")]
		[Address(RVA = "0x8067C0", Offset = "0x8051C0", VA = "0x1808067C0")]
		private void RpcWriter___Observers_ChangeInfluence_1267088319(EMapRegion region, float oldInfluence, float newInfluence)
		{
		}

		// Token: 0x060038F1 RID: 14577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038F1")]
		[Address(RVA = "0x806310", Offset = "0x804D10", VA = "0x180806310")]
		private void RpcLogic___ChangeInfluence_1267088319(EMapRegion region, float oldInfluence, float newInfluence)
		{
		}

		// Token: 0x060038F2 RID: 14578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038F2")]
		[Address(RVA = "0x806610", Offset = "0x805010", VA = "0x180806610")]
		private void RpcReader___Observers_ChangeInfluence_1267088319(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060038F3 RID: 14579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038F3")]
		[Address(RVA = "0x805560", Offset = "0x803F60", VA = "0x180805560")]
		private void Awake_UserLogic_ScheduleOne.Cartel.CartelInfluence_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04002777 RID: 10103
		[Token(Token = "0x4002777")]
		public const float INFLUENCE_TO_UNLOCK_NEXT_REGION = 0.3f;

		// Token: 0x04002778 RID: 10104
		[Token(Token = "0x4002778")]
		public const float PASSIVE_INFLUENCE_GAIN_PER_DAY = 0.02f;

		// Token: 0x04002779 RID: 10105
		[Token(Token = "0x4002779")]
		[FieldOffset(Offset = "0x118")]
		[Header("Settings")]
		public CartelInfluence.RegionInfluenceData[] DefaultRegionInfluence;

		// Token: 0x0400277A RID: 10106
		[Token(Token = "0x400277A")]
		[FieldOffset(Offset = "0x120")]
		private List<CartelInfluence.RegionInfluenceData> regionInfluence;

		// Token: 0x0400277B RID: 10107
		[Token(Token = "0x400277B")]
		[FieldOffset(Offset = "0x128")]
		public Action<EMapRegion, float, float> OnInfluenceChanged;

		// Token: 0x0400277C RID: 10108
		[Token(Token = "0x400277C")]
		[FieldOffset(Offset = "0x130")]
		private bool NetworkInitialize___EarlyScheduleOne.Cartel.CartelInfluenceAssembly-CSharp.dll_Excuted;

		// Token: 0x0400277D RID: 10109
		[Token(Token = "0x400277D")]
		[FieldOffset(Offset = "0x131")]
		private bool NetworkInitialize__LateScheduleOne.Cartel.CartelInfluenceAssembly-CSharp.dll_Excuted;

		// Token: 0x02000812 RID: 2066
		[Token(Token = "0x2000812")]
		[Serializable]
		public class RegionInfluenceData
		{
			// Token: 0x060038F4 RID: 14580 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60038F4")]
			[Address(RVA = "0x80AE40", Offset = "0x809840", VA = "0x18080AE40")]
			public RegionInfluenceData(EMapRegion region, float influence = 0f)
			{
			}

			// Token: 0x0400277E RID: 10110
			[Token(Token = "0x400277E")]
			[FieldOffset(Offset = "0x10")]
			private string name;

			// Token: 0x0400277F RID: 10111
			[Token(Token = "0x400277F")]
			[FieldOffset(Offset = "0x18")]
			public EMapRegion Region;

			// Token: 0x04002780 RID: 10112
			[Token(Token = "0x4002780")]
			[FieldOffset(Offset = "0x1C")]
			[Range(0f, 1f)]
			public float Influence;
		}
	}
}
