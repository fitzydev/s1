using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.AvatarFramework.Customization;
using ScheduleOne.AvatarFramework.Equipping;
using ScheduleOne.Dialogue;
using ScheduleOne.FX;
using ScheduleOne.Law;
using ScheduleOne.NPCs;
using ScheduleOne.NPCs.Behaviour;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Vehicles;
using ScheduleOne.Vision;
using ScheduleOne.VoiceOver;
using UnityEngine;

namespace ScheduleOne.Police
{
	// Token: 0x020007F6 RID: 2038
	[Token(Token = "0x20007F6")]
	public class PoliceOfficer : NPC
	{
		// Token: 0x170007F3 RID: 2035
		// (get) Token: 0x06003794 RID: 14228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007F3")]
		public NetworkObject PursuitTarget
		{
			[Token(Token = "0x6003794")]
			[Address(RVA = "0x7EBA20", Offset = "0x7EA420", VA = "0x1807EBA20")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003795 RID: 14229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003795")]
		[Address(RVA = "0x7E7270", Offset = "0x7E5C70", VA = "0x1807E7270", Slot = "64")]
		public override void Awake()
		{
		}

		// Token: 0x06003796 RID: 14230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003796")]
		[Address(RVA = "0x7EAB10", Offset = "0x7E9510", VA = "0x1807EAB10", Slot = "70")]
		protected override void Start()
		{
		}

		// Token: 0x06003797 RID: 14231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003797")]
		[Address(RVA = "0x7EB860", Offset = "0x7EA260", VA = "0x1807EB860", Slot = "73")]
		protected override void Update()
		{
		}

		// Token: 0x06003798 RID: 14232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003798")]
		[Address(RVA = "0x7E8CD0", Offset = "0x7E76D0", VA = "0x1807E8CD0", Slot = "72")]
		protected override void MinPass()
		{
		}

		// Token: 0x06003799 RID: 14233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003799")]
		[Address(RVA = "0x7EB410", Offset = "0x7E9E10", VA = "0x1807EB410")]
		private void UpdateVision()
		{
		}

		// Token: 0x0600379A RID: 14234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600379A")]
		[Address(RVA = "0x7E7CD0", Offset = "0x7E66D0", VA = "0x1807E7CD0")]
		private void CheckDeactivation()
		{
		}

		// Token: 0x0600379B RID: 14235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600379B")]
		[Address(RVA = "0x7E75B0", Offset = "0x7E5FB0", VA = "0x1807E75B0", Slot = "108")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public virtual void BeginFootPursuit_Networked(string playerCode, bool includeColleagues = true)
		{
		}

		// Token: 0x0600379C RID: 14236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600379C")]
		[Address(RVA = "0x7E7700", Offset = "0x7E6100", VA = "0x1807E7700")]
		[ObserversRpc(RunLocally = true)]
		private void BeginFootPursuit(string playerCode)
		{
		}

		// Token: 0x0600379D RID: 14237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600379D")]
		[Address(RVA = "0x7E7840", Offset = "0x7E6240", VA = "0x1807E7840", Slot = "109")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public virtual void BeginVehiclePursuit_Networked(string playerCode, NetworkObject vehicle, bool beginAsSighted)
		{
		}

		// Token: 0x0600379E RID: 14238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600379E")]
		[Address(RVA = "0x7E79C0", Offset = "0x7E63C0", VA = "0x1807E79C0")]
		[ObserversRpc(RunLocally = true)]
		private void BeginVehiclePursuit(string playerCode, NetworkObject vehicle, bool beginAsSighted)
		{
		}

		// Token: 0x0600379F RID: 14239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600379F")]
		[Address(RVA = "0x7E72C0", Offset = "0x7E5CC0", VA = "0x1807E72C0")]
		public void BeginBodySearch_LocalPlayer()
		{
		}

		// Token: 0x060037A0 RID: 14240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037A0")]
		[Address(RVA = "0x7E7340", Offset = "0x7E5D40", VA = "0x1807E7340", Slot = "110")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public virtual void BeginBodySearch_Networked(string playerCode)
		{
		}

		// Token: 0x060037A1 RID: 14241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037A1")]
		[Address(RVA = "0x7E7470", Offset = "0x7E5E70", VA = "0x1807E7470")]
		[ObserversRpc(RunLocally = true)]
		private void BeginBodySearch(string playerCode)
		{
		}

		// Token: 0x060037A2 RID: 14242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037A2")]
		[Address(RVA = "0x7E6E70", Offset = "0x7E5870", VA = "0x1807E6E70", Slot = "111")]
		[ObserversRpc(RunLocally = true)]
		public virtual void AssignToCheckpoint(CheckpointManager.ECheckpointLocation location)
		{
		}

		// Token: 0x060037A3 RID: 14243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037A3")]
		[Address(RVA = "0x7EACD0", Offset = "0x7E96D0", VA = "0x1807EACD0")]
		public void UnassignFromCheckpoint()
		{
		}

		// Token: 0x060037A4 RID: 14244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037A4")]
		[Address(RVA = "0x7EA9E0", Offset = "0x7E93E0", VA = "0x1807EA9E0")]
		public void StartFootPatrol(PatrolGroup group, bool warpToStartPoint)
		{
		}

		// Token: 0x060037A5 RID: 14245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037A5")]
		[Address(RVA = "0x7EAA90", Offset = "0x7E9490", VA = "0x1807EAA90")]
		public void StartVehiclePatrol(VehiclePatrolRoute route, LandVehicle vehicle)
		{
		}

		// Token: 0x060037A6 RID: 14246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037A6")]
		[Address(RVA = "0x7E6FA0", Offset = "0x7E59A0", VA = "0x1807E6FA0", Slot = "112")]
		public virtual void AssignToSentryLocation(SentryLocation location)
		{
		}

		// Token: 0x060037A7 RID: 14247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037A7")]
		[Address(RVA = "0x7EAD50", Offset = "0x7E9750", VA = "0x1807EAD50")]
		public void UnassignFromSentryLocation()
		{
		}

		// Token: 0x060037A8 RID: 14248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037A8")]
		[Address(RVA = "0x7E6E20", Offset = "0x7E5820", VA = "0x1807E6E20")]
		public void Activate()
		{
		}

		// Token: 0x060037A9 RID: 14249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037A9")]
		[Address(RVA = "0x7E8890", Offset = "0x7E7290", VA = "0x1807E8890")]
		public void Deactivate()
		{
		}

		// Token: 0x060037AA RID: 14250 RVA: 0x0000F0A8 File Offset: 0x0000D2A8
		[Token(Token = "0x60037AA")]
		[Address(RVA = "0x7EA810", Offset = "0x7E9210", VA = "0x1807EA810")]
		protected bool ShouldNoticeGeneralCrime(Player player)
		{
			return default(bool);
		}

		// Token: 0x060037AB RID: 14251 RVA: 0x0000F0C0 File Offset: 0x0000D2C0
		[Token(Token = "0x60037AB")]
		[Address(RVA = "0x4B7AD0", Offset = "0x4B64D0", VA = "0x1804B7AD0", Slot = "90")]
		public override bool ShouldSave()
		{
			return default(bool);
		}

		// Token: 0x060037AC RID: 14252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037AC")]
		[Address(RVA = "0x7E8A70", Offset = "0x7E7470", VA = "0x1807E8A70", Slot = "87")]
		public override string GetNameAddress()
		{
			return null;
		}

		// Token: 0x060037AD RID: 14253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037AD")]
		[Address(RVA = "0x7EADF0", Offset = "0x7E97F0", VA = "0x1807EADF0")]
		private void UpdateChatter()
		{
		}

		// Token: 0x060037AE RID: 14254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037AE")]
		[Address(RVA = "0x7E8FC0", Offset = "0x7E79C0", VA = "0x1807E8FC0")]
		private void ProcessVisionEvent(VisionEventReceipt visionEventReceipt)
		{
		}

		// Token: 0x060037AF RID: 14255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037AF")]
		[Address(RVA = "0x7E8AB0", Offset = "0x7E74B0", VA = "0x1807E8AB0")]
		public static PoliceOfficer GetNearestOfficer(Vector3 position, out float distanceToTarget, bool onlyConscious = true)
		{
			return null;
		}

		// Token: 0x060037B0 RID: 14256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037B0")]
		[Address(RVA = "0x7EADA0", Offset = "0x7E97A0", VA = "0x1807EADA0", Slot = "113")]
		public virtual void UpdateBodySearch()
		{
		}

		// Token: 0x060037B1 RID: 14257 RVA: 0x0000F0D8 File Offset: 0x0000D2D8
		[Token(Token = "0x60037B1")]
		[Address(RVA = "0x7E7C20", Offset = "0x7E6620", VA = "0x1807E7C20")]
		private bool CanInvestigate()
		{
			return default(bool);
		}

		// Token: 0x060037B2 RID: 14258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037B2")]
		[Address(RVA = "0x7EAEB0", Offset = "0x7E98B0", VA = "0x1807EAEB0")]
		private void UpdateExistingInvestigation()
		{
		}

		// Token: 0x060037B3 RID: 14259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037B3")]
		[Address(RVA = "0x7E8390", Offset = "0x7E6D90", VA = "0x1807E8390")]
		private void CheckNewInvestigation()
		{
		}

		// Token: 0x060037B4 RID: 14260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037B4")]
		[Address(RVA = "0x7EA920", Offset = "0x7E9320", VA = "0x1807EA920")]
		private void StartBodySearchInvestigation(Player player)
		{
		}

		// Token: 0x060037B5 RID: 14261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037B5")]
		[Address(RVA = "0x7EABC0", Offset = "0x7E95C0", VA = "0x1807EABC0")]
		private void StopBodySearchInvestigation()
		{
		}

		// Token: 0x060037B6 RID: 14262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037B6")]
		[Address(RVA = "0x7E87B0", Offset = "0x7E71B0", VA = "0x1807E87B0")]
		public void ConductBodySearch(Player player)
		{
		}

		// Token: 0x060037B7 RID: 14263 RVA: 0x0000F0F0 File Offset: 0x0000D2F0
		[Token(Token = "0x60037B7")]
		[Address(RVA = "0x7E7B50", Offset = "0x7E6550", VA = "0x1807E7B50")]
		private bool CanInvestigatePlayer(Player player)
		{
			return default(bool);
		}

		// Token: 0x060037B8 RID: 14264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037B8")]
		[Address(RVA = "0x7EB9E0", Offset = "0x7EA3E0", VA = "0x1807EB9E0")]
		public PoliceOfficer()
		{
		}

		// Token: 0x060037BA RID: 14266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037BA")]
		[Address(RVA = "0x7EAC60", Offset = "0x7E9660", VA = "0x1807EAC60")]
		[CompilerGenerated]
		private IEnumerator <Deactivate>g__Wait|59_0()
		{
			return null;
		}

		// Token: 0x060037BC RID: 14268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037BC")]
		[Address(RVA = "0x7E8D80", Offset = "0x7E7780", VA = "0x1807E8D80", Slot = "99")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x060037BD RID: 14269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037BD")]
		[Address(RVA = "0x7E8D60", Offset = "0x7E7760", VA = "0x1807E8D60", Slot = "100")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x060037BE RID: 14270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037BE")]
		[Address(RVA = "0x687D80", Offset = "0x686780", VA = "0x180687D80", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x060037BF RID: 14271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037BF")]
		[Address(RVA = "0x7EA550", Offset = "0x7E8F50", VA = "0x1807EA550")]
		private void RpcWriter___Server_BeginFootPursuit_Networked_310431262(string playerCode, bool includeColleagues = true)
		{
		}

		// Token: 0x060037C0 RID: 14272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037C0")]
		[Address(RVA = "0x7E9410", Offset = "0x7E7E10", VA = "0x1807E9410", Slot = "114")]
		public virtual void RpcLogic___BeginFootPursuit_Networked_310431262(string playerCode, bool includeColleagues = true)
		{
		}

		// Token: 0x060037C1 RID: 14273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037C1")]
		[Address(RVA = "0x7E9D60", Offset = "0x7E8760", VA = "0x1807E9D60")]
		private void RpcReader___Server_BeginFootPursuit_Networked_310431262(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060037C2 RID: 14274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037C2")]
		[Address(RVA = "0x7EA170", Offset = "0x7E8B70", VA = "0x1807EA170")]
		private void RpcWriter___Observers_BeginFootPursuit_3615296227(string playerCode)
		{
		}

		// Token: 0x060037C3 RID: 14275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037C3")]
		[Address(RVA = "0x7E9300", Offset = "0x7E7D00", VA = "0x1807E9300")]
		private void RpcLogic___BeginFootPursuit_3615296227(string playerCode)
		{
		}

		// Token: 0x060037C4 RID: 14276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037C4")]
		[Address(RVA = "0x7E9BD0", Offset = "0x7E85D0", VA = "0x1807E9BD0")]
		private void RpcReader___Observers_BeginFootPursuit_3615296227(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060037C5 RID: 14277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037C5")]
		[Address(RVA = "0x7EA6B0", Offset = "0x7E90B0", VA = "0x1807EA6B0")]
		private void RpcWriter___Server_BeginVehiclePursuit_Networked_1834136777(string playerCode, NetworkObject vehicle, bool beginAsSighted)
		{
		}

		// Token: 0x060037C6 RID: 14278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037C6")]
		[Address(RVA = "0x7E79C0", Offset = "0x7E63C0", VA = "0x1807E79C0", Slot = "115")]
		public virtual void RpcLogic___BeginVehiclePursuit_Networked_1834136777(string playerCode, NetworkObject vehicle, bool beginAsSighted)
		{
		}

		// Token: 0x060037C7 RID: 14279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037C7")]
		[Address(RVA = "0x7E9E10", Offset = "0x7E8810", VA = "0x1807E9E10")]
		private void RpcReader___Server_BeginVehiclePursuit_Networked_1834136777(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060037C8 RID: 14280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037C8")]
		[Address(RVA = "0x7EA2B0", Offset = "0x7E8CB0", VA = "0x1807EA2B0")]
		private void RpcWriter___Observers_BeginVehiclePursuit_1834136777(string playerCode, NetworkObject vehicle, bool beginAsSighted)
		{
		}

		// Token: 0x060037C9 RID: 14281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037C9")]
		[Address(RVA = "0x7E9970", Offset = "0x7E8370", VA = "0x1807E9970")]
		private void RpcLogic___BeginVehiclePursuit_1834136777(string playerCode, NetworkObject vehicle, bool beginAsSighted)
		{
		}

		// Token: 0x060037CA RID: 14282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037CA")]
		[Address(RVA = "0x7E9C30", Offset = "0x7E8630", VA = "0x1807E9C30")]
		private void RpcReader___Observers_BeginVehiclePursuit_1834136777(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060037CB RID: 14283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037CB")]
		[Address(RVA = "0x7EA420", Offset = "0x7E8E20", VA = "0x1807EA420")]
		private void RpcWriter___Server_BeginBodySearch_Networked_3615296227(string playerCode)
		{
		}

		// Token: 0x060037CC RID: 14284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037CC")]
		[Address(RVA = "0x7E7470", Offset = "0x7E5E70", VA = "0x1807E7470", Slot = "116")]
		public virtual void RpcLogic___BeginBodySearch_Networked_3615296227(string playerCode)
		{
		}

		// Token: 0x060037CD RID: 14285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037CD")]
		[Address(RVA = "0x7E9CF0", Offset = "0x7E86F0", VA = "0x1807E9CF0")]
		private void RpcReader___Server_BeginBodySearch_Networked_3615296227(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060037CE RID: 14286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037CE")]
		[Address(RVA = "0x7EA030", Offset = "0x7E8A30", VA = "0x1807EA030")]
		private void RpcWriter___Observers_BeginBodySearch_3615296227(string playerCode)
		{
		}

		// Token: 0x060037CF RID: 14287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037CF")]
		[Address(RVA = "0x7E91D0", Offset = "0x7E7BD0", VA = "0x1807E91D0")]
		private void RpcLogic___BeginBodySearch_3615296227(string playerCode)
		{
		}

		// Token: 0x060037D0 RID: 14288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037D0")]
		[Address(RVA = "0x7E9B70", Offset = "0x7E8570", VA = "0x1807E9B70")]
		private void RpcReader___Observers_BeginBodySearch_3615296227(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060037D1 RID: 14289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037D1")]
		[Address(RVA = "0x7E9EF0", Offset = "0x7E88F0", VA = "0x1807E9EF0")]
		private void RpcWriter___Observers_AssignToCheckpoint_4087078542(CheckpointManager.ECheckpointLocation location)
		{
		}

		// Token: 0x060037D2 RID: 14290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037D2")]
		[Address(RVA = "0x7E9060", Offset = "0x7E7A60", VA = "0x1807E9060", Slot = "117")]
		public virtual void RpcLogic___AssignToCheckpoint_4087078542(CheckpointManager.ECheckpointLocation location)
		{
		}

		// Token: 0x060037D3 RID: 14291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037D3")]
		[Address(RVA = "0x7E9B20", Offset = "0x7E8520", VA = "0x1807E9B20")]
		private void RpcReader___Observers_AssignToCheckpoint_4087078542(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060037D4 RID: 14292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037D4")]
		[Address(RVA = "0x7E6FF0", Offset = "0x7E59F0", VA = "0x1807E6FF0", Slot = "118")]
		protected virtual void Awake_UserLogic_ScheduleOne.Police.PoliceOfficer_Assembly-CSharp.dll()
		{
		}

		// Token: 0x040026B9 RID: 9913
		[Token(Token = "0x40026B9")]
		public const float DEACTIVATION_TIME = 1f;

		// Token: 0x040026BA RID: 9914
		[Token(Token = "0x40026BA")]
		public const float INVESTIGATION_COOLDOWN = 60f;

		// Token: 0x040026BB RID: 9915
		[Token(Token = "0x40026BB")]
		public const float INVESTIGATION_MAX_DISTANCE = 8f;

		// Token: 0x040026BC RID: 9916
		[Token(Token = "0x40026BC")]
		public const float INVESTIGATION_MIN_VISIBILITY = 0.2f;

		// Token: 0x040026BD RID: 9917
		[Token(Token = "0x40026BD")]
		public const float INVESTIGATION_CHECK_INTERVAL = 1f;

		// Token: 0x040026BE RID: 9918
		[Token(Token = "0x40026BE")]
		public const float BODY_SEARCH_CHANCE_DEFAULT = 0.1f;

		// Token: 0x040026BF RID: 9919
		[Token(Token = "0x40026BF")]
		public const float MIN_CHATTER_INTERVAL = 15f;

		// Token: 0x040026C0 RID: 9920
		[Token(Token = "0x40026C0")]
		public const float MAX_CHATTER_INTERVAL = 45f;

		// Token: 0x040026C1 RID: 9921
		[Token(Token = "0x40026C1")]
		[FieldOffset(Offset = "0x0")]
		public static Action<VisionEventReceipt> OnPoliceVisionEvent;

		// Token: 0x040026C2 RID: 9922
		[Token(Token = "0x40026C2")]
		[FieldOffset(Offset = "0x8")]
		public static List<PoliceOfficer> Officers;

		// Token: 0x040026C3 RID: 9923
		[Token(Token = "0x40026C3")]
		[FieldOffset(Offset = "0x2F0")]
		public LandVehicle AssignedVehicle;

		// Token: 0x040026C4 RID: 9924
		[Token(Token = "0x40026C4")]
		[FieldOffset(Offset = "0x2F8")]
		[Header("References")]
		public PursuitBehaviour PursuitBehaviour;

		// Token: 0x040026C5 RID: 9925
		[Token(Token = "0x40026C5")]
		[FieldOffset(Offset = "0x300")]
		public VehiclePursuitBehaviour VehiclePursuitBehaviour;

		// Token: 0x040026C6 RID: 9926
		[Token(Token = "0x40026C6")]
		[FieldOffset(Offset = "0x308")]
		public BodySearchBehaviour BodySearchBehaviour;

		// Token: 0x040026C7 RID: 9927
		[Token(Token = "0x40026C7")]
		[FieldOffset(Offset = "0x310")]
		public CheckpointBehaviour CheckpointBehaviour;

		// Token: 0x040026C8 RID: 9928
		[Token(Token = "0x40026C8")]
		[FieldOffset(Offset = "0x318")]
		public FootPatrolBehaviour FootPatrolBehaviour;

		// Token: 0x040026C9 RID: 9929
		[Token(Token = "0x40026C9")]
		[FieldOffset(Offset = "0x320")]
		public ProximityCircle ProxCircle;

		// Token: 0x040026CA RID: 9930
		[Token(Token = "0x40026CA")]
		[FieldOffset(Offset = "0x328")]
		public VehiclePatrolBehaviour VehiclePatrolBehaviour;

		// Token: 0x040026CB RID: 9931
		[Token(Token = "0x40026CB")]
		[FieldOffset(Offset = "0x330")]
		public SentryBehaviour SentryBehaviour;

		// Token: 0x040026CC RID: 9932
		[Token(Token = "0x40026CC")]
		[FieldOffset(Offset = "0x338")]
		public PoliceChatterVO ChatterVO;

		// Token: 0x040026CD RID: 9933
		[Token(Token = "0x40026CD")]
		[FieldOffset(Offset = "0x340")]
		public ScheduleOne.NPCs.Behaviour.Behaviour[] DeactivationBlockingBehaviours;

		// Token: 0x040026CE RID: 9934
		[Token(Token = "0x40026CE")]
		[FieldOffset(Offset = "0x348")]
		[Header("Dialogue")]
		public DialogueContainer CheckpointDialogue;

		// Token: 0x040026CF RID: 9935
		[Token(Token = "0x40026CF")]
		[FieldOffset(Offset = "0x350")]
		[Header("Tools")]
		public AvatarEquippable BatonPrefab;

		// Token: 0x040026D0 RID: 9936
		[Token(Token = "0x40026D0")]
		[FieldOffset(Offset = "0x358")]
		public AvatarEquippable TaserPrefab;

		// Token: 0x040026D1 RID: 9937
		[Token(Token = "0x40026D1")]
		[FieldOffset(Offset = "0x360")]
		public AvatarEquippable GunPrefab;

		// Token: 0x040026D2 RID: 9938
		[Token(Token = "0x40026D2")]
		[FieldOffset(Offset = "0x368")]
		[Header("Settings")]
		public bool AutoDeactivate;

		// Token: 0x040026D3 RID: 9939
		[Token(Token = "0x40026D3")]
		[FieldOffset(Offset = "0x369")]
		public bool ChatterEnabled;

		// Token: 0x040026D4 RID: 9940
		[Token(Token = "0x40026D4")]
		[FieldOffset(Offset = "0x36C")]
		[Header("Behaviour Settings")]
		[Range(0f, 1f)]
		public float Suspicion;

		// Token: 0x040026D5 RID: 9941
		[Token(Token = "0x40026D5")]
		[FieldOffset(Offset = "0x370")]
		[Range(0f, 1f)]
		public float Leniency;

		// Token: 0x040026D6 RID: 9942
		[Token(Token = "0x40026D6")]
		[FieldOffset(Offset = "0x374")]
		[Range(0f, 1f)]
		[Header("Body Search Settings")]
		public float BodySearchChance;

		// Token: 0x040026D7 RID: 9943
		[Token(Token = "0x40026D7")]
		[FieldOffset(Offset = "0x378")]
		[Range(1f, 10f)]
		public float BodySearchDuration;

		// Token: 0x040026D8 RID: 9944
		[Token(Token = "0x40026D8")]
		[FieldOffset(Offset = "0x380")]
		[HideInInspector]
		public PoliceBelt belt;

		// Token: 0x040026D9 RID: 9945
		[Token(Token = "0x40026D9")]
		[FieldOffset(Offset = "0x388")]
		private float timeSinceReadyToPool;

		// Token: 0x040026DA RID: 9946
		[Token(Token = "0x40026DA")]
		[FieldOffset(Offset = "0x38C")]
		private float timeSinceOutOfSight;

		// Token: 0x040026DB RID: 9947
		[Token(Token = "0x40026DB")]
		[FieldOffset(Offset = "0x390")]
		private float chatterCountDown;

		// Token: 0x040026DC RID: 9948
		[Token(Token = "0x40026DC")]
		[FieldOffset(Offset = "0x398")]
		private Investigation currentBodySearchInvestigation;

		// Token: 0x040026DD RID: 9949
		[Token(Token = "0x40026DD")]
		[FieldOffset(Offset = "0x3A0")]
		private bool generalCrimeResponseActive;

		// Token: 0x040026DE RID: 9950
		[Token(Token = "0x40026DE")]
		[FieldOffset(Offset = "0x3A1")]
		private bool NetworkInitialize___EarlyScheduleOne.Police.PoliceOfficerAssembly-CSharp.dll_Excuted;

		// Token: 0x040026DF RID: 9951
		[Token(Token = "0x40026DF")]
		[FieldOffset(Offset = "0x3A2")]
		private bool NetworkInitialize__LateScheduleOne.Police.PoliceOfficerAssembly-CSharp.dll_Excuted;
	}
}
