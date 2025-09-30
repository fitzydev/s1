using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.AvatarFramework.Equipping;
using ScheduleOne.NPCs.Behaviour;
using ScheduleOne.Tools;
using ScheduleOne.Vision;
using UnityEngine;

namespace ScheduleOne.Combat
{
	// Token: 0x020007B3 RID: 1971
	[Token(Token = "0x20007B3")]
	public class CombatBehaviour : ScheduleOne.NPCs.Behaviour.Behaviour
	{
		// Token: 0x170007B8 RID: 1976
		// (get) Token: 0x0600351E RID: 13598 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600351F RID: 13599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007B8")]
		public ICombatTargetable Target
		{
			[Token(Token = "0x600351E")]
			[Address(RVA = "0x630180", Offset = "0x62EB80", VA = "0x180630180")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600351F")]
			[Address(RVA = "0x63DA80", Offset = "0x63C480", VA = "0x18063DA80")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170007B9 RID: 1977
		// (get) Token: 0x06003520 RID: 13600 RVA: 0x0000E7C0 File Offset: 0x0000C9C0
		// (set) Token: 0x06003521 RID: 13601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007B9")]
		public bool IsSearching
		{
			[Token(Token = "0x6003520")]
			[Address(RVA = "0x63D930", Offset = "0x63C330", VA = "0x18063D930")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003521")]
			[Address(RVA = "0x63DA50", Offset = "0x63C450", VA = "0x18063DA50")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170007BA RID: 1978
		// (get) Token: 0x06003522 RID: 13602 RVA: 0x0000E7D8 File Offset: 0x0000C9D8
		// (set) Token: 0x06003523 RID: 13603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007BA")]
		public float TimeSinceTargetReacquired
		{
			[Token(Token = "0x6003522")]
			[Address(RVA = "0x659860", Offset = "0x658260", VA = "0x180659860")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6003523")]
			[Address(RVA = "0x659B10", Offset = "0x658510", VA = "0x180659B10")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170007BB RID: 1979
		// (get) Token: 0x06003524 RID: 13604 RVA: 0x0000E7F0 File Offset: 0x0000C9F0
		// (set) Token: 0x06003525 RID: 13605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007BB")]
		public bool IsTargetRecentlyVisible
		{
			[Token(Token = "0x6003524")]
			[Address(RVA = "0x796B00", Offset = "0x795500", VA = "0x180796B00")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003525")]
			[Address(RVA = "0x796B20", Offset = "0x795520", VA = "0x180796B20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170007BC RID: 1980
		// (get) Token: 0x06003526 RID: 13606 RVA: 0x0000E808 File Offset: 0x0000CA08
		// (set) Token: 0x06003527 RID: 13607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007BC")]
		public bool IsTargetImmediatelyVisible
		{
			[Token(Token = "0x6003526")]
			[Address(RVA = "0x796AF0", Offset = "0x7954F0", VA = "0x180796AF0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003527")]
			[Address(RVA = "0x796B10", Offset = "0x795510", VA = "0x180796B10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06003528 RID: 13608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003528")]
		[Address(RVA = "0x791020", Offset = "0x78FA20", VA = "0x180791020", Slot = "19")]
		public override void Awake()
		{
		}

		// Token: 0x06003529 RID: 13609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003529")]
		[Address(RVA = "0x793920", Offset = "0x792320", VA = "0x180793920", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x0600352A RID: 13610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600352A")]
		[Address(RVA = "0x795030", Offset = "0x793A30", VA = "0x180795030")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetTargetAndEnable_Server(NetworkObject target)
		{
		}

		// Token: 0x0600352B RID: 13611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600352B")]
		[Address(RVA = "0x795170", Offset = "0x793B70", VA = "0x180795170")]
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		protected void SetTarget_Client(NetworkConnection conn, NetworkObject target)
		{
		}

		// Token: 0x0600352C RID: 13612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600352C")]
		[Address(RVA = "0x7953E0", Offset = "0x793DE0", VA = "0x1807953E0", Slot = "34")]
		protected virtual void SetTarget(NetworkObject target)
		{
		}

		// Token: 0x0600352D RID: 13613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600352D")]
		[Address(RVA = "0x7911C0", Offset = "0x78FBC0", VA = "0x1807911C0", Slot = "22")]
		protected override void Begin()
		{
		}

		// Token: 0x0600352E RID: 13614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600352E")]
		[Address(RVA = "0x793E10", Offset = "0x792810", VA = "0x180793E10", Slot = "25")]
		protected override void Resume()
		{
		}

		// Token: 0x0600352F RID: 13615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600352F")]
		[Address(RVA = "0x7939A0", Offset = "0x7923A0", VA = "0x1807939A0", Slot = "24")]
		protected override void Pause()
		{
		}

		// Token: 0x06003530 RID: 13616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003530")]
		[Address(RVA = "0x792320", Offset = "0x790D20", VA = "0x180792320", Slot = "23")]
		protected override void End()
		{
		}

		// Token: 0x06003531 RID: 13617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003531")]
		[Address(RVA = "0x792070", Offset = "0x790A70", VA = "0x180792070", Slot = "21")]
		public override void Disable()
		{
		}

		// Token: 0x06003532 RID: 13618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003532")]
		[Address(RVA = "0x796150", Offset = "0x794B50", VA = "0x180796150", Slot = "35")]
		protected virtual void StartCombat()
		{
		}

		// Token: 0x06003533 RID: 13619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003533")]
		[Address(RVA = "0x7920C0", Offset = "0x790AC0", VA = "0x1807920C0", Slot = "36")]
		protected virtual void EndCombat()
		{
		}

		// Token: 0x06003534 RID: 13620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003534")]
		[Address(RVA = "0x791280", Offset = "0x78FC80", VA = "0x180791280", Slot = "26")]
		public override void BehaviourUpdate()
		{
		}

		// Token: 0x06003535 RID: 13621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003535")]
		[Address(RVA = "0x7923F0", Offset = "0x790DF0", VA = "0x1807923F0", Slot = "37")]
		protected virtual void FixedUpdate()
		{
		}

		// Token: 0x06003536 RID: 13622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003536")]
		[Address(RVA = "0x7969C0", Offset = "0x7953C0", VA = "0x1807969C0")]
		protected void UpdateTimeout()
		{
		}

		// Token: 0x06003537 RID: 13623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003537")]
		[Address(RVA = "0x7968F0", Offset = "0x7952F0", VA = "0x1807968F0", Slot = "38")]
		protected virtual void UpdateLookAt()
		{
		}

		// Token: 0x06003538 RID: 13624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003538")]
		[Address(RVA = "0x794F70", Offset = "0x793970", VA = "0x180794F70")]
		protected void SetMovementSpeed(float speed, string label = "combat", int priority = 5)
		{
		}

		// Token: 0x06003539 RID: 13625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003539")]
		[Address(RVA = "0x792350", Offset = "0x790D50", VA = "0x180792350")]
		private void EnsureRangedWeaponRoutineIsRunning()
		{
		}

		// Token: 0x0600353A RID: 13626 RVA: 0x0000E820 File Offset: 0x0000CA20
		[Token(Token = "0x600353A")]
		[Address(RVA = "0x7929A0", Offset = "0x7913A0", VA = "0x1807929A0")]
		protected Vector3 GetPredictedFutureTargetPosition(float lead_Min = 0f, float lead_Max = 2f)
		{
			return default(Vector3);
		}

		// Token: 0x0600353B RID: 13627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600353B")]
		[Address(RVA = "0x794E80", Offset = "0x793880", VA = "0x180794E80", Slot = "29")]
		protected override void SetDestination(Vector3 position, bool teleportIfFail = true)
		{
		}

		// Token: 0x0600353C RID: 13628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600353C")]
		[Address(RVA = "0x795630", Offset = "0x794030", VA = "0x180795630", Slot = "39")]
		[ObserversRpc(RunLocally = true)]
		protected virtual void SetWeapon(string weaponPath)
		{
		}

		// Token: 0x0600353D RID: 13629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600353D")]
		[Address(RVA = "0x42DA80", Offset = "0x42C480", VA = "0x18042DA80", Slot = "40")]
		protected virtual void OnCurrentWeaponChanged(AvatarWeapon weapon)
		{
		}

		// Token: 0x0600353E RID: 13630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600353E")]
		[Address(RVA = "0x791F50", Offset = "0x790950", VA = "0x180791F50")]
		[ObserversRpc(RunLocally = true)]
		protected void ClearWeapon()
		{
		}

		// Token: 0x0600353F RID: 13631 RVA: 0x0000E838 File Offset: 0x0000CA38
		[Token(Token = "0x600353F")]
		[Address(RVA = "0x793B00", Offset = "0x792500", VA = "0x180793B00", Slot = "41")]
		protected virtual bool ReadyToAttack(bool checkTarget = true)
		{
			return default(bool);
		}

		// Token: 0x06003540 RID: 13632 RVA: 0x0000E850 File Offset: 0x0000CA50
		[Token(Token = "0x6003540")]
		[Address(RVA = "0x792EB0", Offset = "0x7918B0", VA = "0x180792EB0")]
		private bool IsCurrentWeaponMelee()
		{
			return default(bool);
		}

		// Token: 0x06003541 RID: 13633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003541")]
		[Address(RVA = "0x790D90", Offset = "0x78F790", VA = "0x180790D90", Slot = "42")]
		[ObserversRpc(RunLocally = true)]
		protected virtual void Attack()
		{
		}

		// Token: 0x06003542 RID: 13634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003542")]
		[Address(RVA = "0x796730", Offset = "0x795130", VA = "0x180796730")]
		protected void SucessfulHit()
		{
		}

		// Token: 0x06003543 RID: 13635 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003543")]
		[Address(RVA = "0x793A90", Offset = "0x792490", VA = "0x180793A90")]
		private IEnumerator RangedWeaponRoutine()
		{
			return null;
		}

		// Token: 0x06003544 RID: 13636 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003544")]
		[Address(RVA = "0x793C00", Offset = "0x792600", VA = "0x180793C00")]
		private IEnumerator RepositionToRangedWeaponRange()
		{
			return null;
		}

		// Token: 0x06003545 RID: 13637 RVA: 0x0000E868 File Offset: 0x0000CA68
		[Token(Token = "0x6003545")]
		[Address(RVA = "0x792460", Offset = "0x790E60", VA = "0x180792460", Slot = "43")]
		protected virtual float GetIdealRangedWeaponDistance()
		{
			return 0f;
		}

		// Token: 0x06003546 RID: 13638 RVA: 0x0000E880 File Offset: 0x0000CA80
		[Token(Token = "0x6003546")]
		[Address(RVA = "0x795770", Offset = "0x794170", VA = "0x180795770")]
		private bool Shoot()
		{
			return default(bool);
		}

		// Token: 0x06003547 RID: 13639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003547")]
		[Address(RVA = "0x7954D0", Offset = "0x793ED0", VA = "0x1807954D0")]
		private void SetWeaponRaised(bool raised)
		{
		}

		// Token: 0x06003548 RID: 13640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003548")]
		[Address(RVA = "0x791D50", Offset = "0x790750", VA = "0x180791D50")]
		protected void CheckTargetVisibility()
		{
		}

		// Token: 0x06003549 RID: 13641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003549")]
		[Address(RVA = "0x793510", Offset = "0x791F10", VA = "0x180793510")]
		public void MarkPlayerVisible()
		{
		}

		// Token: 0x0600354A RID: 13642 RVA: 0x0000E898 File Offset: 0x0000CA98
		[Token(Token = "0x600354A")]
		[Address(RVA = "0x772DD0", Offset = "0x7717D0", VA = "0x180772DD0")]
		protected bool IsTargetVisible()
		{
			return default(bool);
		}

		// Token: 0x0600354B RID: 13643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600354B")]
		[Address(RVA = "0x7939D0", Offset = "0x7923D0", VA = "0x1807939D0")]
		protected void ProcessVisionEvent(VisionEventReceipt visionEventReceipt)
		{
		}

		// Token: 0x0600354C RID: 13644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600354C")]
		[Address(RVA = "0x796760", Offset = "0x795160", VA = "0x180796760", Slot = "44")]
		protected virtual void TargetSpotted()
		{
		}

		// Token: 0x0600354D RID: 13645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600354D")]
		[Address(RVA = "0x793810", Offset = "0x792210", VA = "0x180793810")]
		[ServerRpc(RequireOwnership = false)]
		public void NotifyServerTargetSeen()
		{
		}

		// Token: 0x0600354E RID: 13646 RVA: 0x0000E8B0 File Offset: 0x0000CAB0
		[Token(Token = "0x600354E")]
		[Address(RVA = "0x792EA0", Offset = "0x7918A0", VA = "0x180792EA0", Slot = "45")]
		protected virtual float GetSearchTime()
		{
			return 0f;
		}

		// Token: 0x0600354F RID: 13647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600354F")]
		[Address(RVA = "0x796530", Offset = "0x794F30", VA = "0x180796530")]
		private void StartSearching()
		{
		}

		// Token: 0x06003550 RID: 13648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003550")]
		[Address(RVA = "0x796680", Offset = "0x795080", VA = "0x180796680")]
		private void StopSearching()
		{
		}

		// Token: 0x06003551 RID: 13649 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003551")]
		[Address(RVA = "0x794E10", Offset = "0x793810", VA = "0x180794E10")]
		private IEnumerator SearchRoutine()
		{
			return null;
		}

		// Token: 0x06003552 RID: 13650 RVA: 0x0000E8C8 File Offset: 0x0000CAC8
		[Token(Token = "0x6003552")]
		[Address(RVA = "0x7925C0", Offset = "0x790FC0", VA = "0x1807925C0")]
		private Vector3 GetNextSearchLocation()
		{
			return default(Vector3);
		}

		// Token: 0x06003553 RID: 13651 RVA: 0x0000E8E0 File Offset: 0x0000CAE0
		[Token(Token = "0x6003553")]
		[Address(RVA = "0x7932B0", Offset = "0x791CB0", VA = "0x1807932B0", Slot = "46")]
		protected virtual bool IsTargetValid()
		{
			return default(bool);
		}

		// Token: 0x06003554 RID: 13652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003554")]
		[Address(RVA = "0x793C70", Offset = "0x792670", VA = "0x180793C70")]
		private void RepositionToTargetMeleeRange(Vector3 origin)
		{
		}

		// Token: 0x06003555 RID: 13653 RVA: 0x0000E8F8 File Offset: 0x0000CAF8
		[Token(Token = "0x6003555")]
		[Address(RVA = "0x792B30", Offset = "0x791530", VA = "0x180792B30")]
		private Vector3 GetRandomReachablePointNear(Vector3 point, float randomRadius, float minDistance = 0f)
		{
			return default(Vector3);
		}

		// Token: 0x06003556 RID: 13654 RVA: 0x0000E910 File Offset: 0x0000CB10
		[Token(Token = "0x6003556")]
		[Address(RVA = "0x792530", Offset = "0x790F30", VA = "0x180792530")]
		protected float GetMinTargetDistance()
		{
			return 0f;
		}

		// Token: 0x06003557 RID: 13655 RVA: 0x0000E928 File Offset: 0x0000CB28
		[Token(Token = "0x6003557")]
		[Address(RVA = "0x7924A0", Offset = "0x790EA0", VA = "0x1807924A0")]
		protected float GetMaxTargetDistance()
		{
			return 0f;
		}

		// Token: 0x06003558 RID: 13656 RVA: 0x0000E940 File Offset: 0x0000CB40
		[Token(Token = "0x6003558")]
		[Address(RVA = "0x792F80", Offset = "0x791980", VA = "0x180792F80")]
		protected bool IsTargetInRange([Optional] Vector3 origin)
		{
			return default(bool);
		}

		// Token: 0x06003559 RID: 13657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003559")]
		[Address(RVA = "0x796A20", Offset = "0x795420", VA = "0x180796A20")]
		public CombatBehaviour()
		{
		}

		// Token: 0x0600355A RID: 13658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600355A")]
		[Address(RVA = "0x7935D0", Offset = "0x791FD0", VA = "0x1807935D0", Slot = "31")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x0600355B RID: 13659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600355B")]
		[Address(RVA = "0x7935B0", Offset = "0x791FB0", VA = "0x1807935B0", Slot = "32")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x0600355C RID: 13660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600355C")]
		[Address(RVA = "0x5C22C0", Offset = "0x5C0CC0", VA = "0x1805C22C0", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x0600355D RID: 13661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600355D")]
		[Address(RVA = "0x794B70", Offset = "0x793570", VA = "0x180794B70")]
		private void RpcWriter___Server_SetTargetAndEnable_Server_3323014238(NetworkObject target)
		{
		}

		// Token: 0x0600355E RID: 13662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600355E")]
		[Address(RVA = "0x7940C0", Offset = "0x792AC0", VA = "0x1807940C0")]
		public void RpcLogic___SetTargetAndEnable_Server_3323014238(NetworkObject target)
		{
		}

		// Token: 0x0600355F RID: 13663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600355F")]
		[Address(RVA = "0x794590", Offset = "0x792F90", VA = "0x180794590")]
		private void RpcReader___Server_SetTargetAndEnable_Server_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06003560 RID: 13664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003560")]
		[Address(RVA = "0x7948E0", Offset = "0x7932E0", VA = "0x1807948E0")]
		private void RpcWriter___Observers_SetTarget_Client_1824087381(NetworkConnection conn, NetworkObject target)
		{
		}

		// Token: 0x06003561 RID: 13665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003561")]
		[Address(RVA = "0x7940F0", Offset = "0x792AF0", VA = "0x1807940F0")]
		protected void RpcLogic___SetTarget_Client_1824087381(NetworkConnection conn, NetworkObject target)
		{
		}

		// Token: 0x06003562 RID: 13666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003562")]
		[Address(RVA = "0x794480", Offset = "0x792E80", VA = "0x180794480")]
		private void RpcReader___Observers_SetTarget_Client_1824087381(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003563 RID: 13667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003563")]
		[Address(RVA = "0x794CB0", Offset = "0x7936B0", VA = "0x180794CB0")]
		private void RpcWriter___Target_SetTarget_Client_1824087381(NetworkConnection conn, NetworkObject target)
		{
		}

		// Token: 0x06003564 RID: 13668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003564")]
		[Address(RVA = "0x794620", Offset = "0x793020", VA = "0x180794620")]
		private void RpcReader___Target_SetTarget_Client_1824087381(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003565 RID: 13669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003565")]
		[Address(RVA = "0x794A30", Offset = "0x793430", VA = "0x180794A30")]
		private void RpcWriter___Observers_SetWeapon_3615296227(string weaponPath)
		{
		}

		// Token: 0x06003566 RID: 13670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003566")]
		[Address(RVA = "0x794110", Offset = "0x792B10", VA = "0x180794110", Slot = "47")]
		protected virtual void RpcLogic___SetWeapon_3615296227(string weaponPath)
		{
		}

		// Token: 0x06003567 RID: 13671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003567")]
		[Address(RVA = "0x794500", Offset = "0x792F00", VA = "0x180794500")]
		private void RpcReader___Observers_SetWeapon_3615296227(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003568 RID: 13672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003568")]
		[Address(RVA = "0x7947C0", Offset = "0x7931C0", VA = "0x1807947C0")]
		private void RpcWriter___Observers_ClearWeapon_2166136261()
		{
		}

		// Token: 0x06003569 RID: 13673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003569")]
		[Address(RVA = "0x793F00", Offset = "0x792900", VA = "0x180793F00")]
		protected void RpcLogic___ClearWeapon_2166136261()
		{
		}

		// Token: 0x0600356A RID: 13674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600356A")]
		[Address(RVA = "0x794440", Offset = "0x792E40", VA = "0x180794440")]
		private void RpcReader___Observers_ClearWeapon_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600356B RID: 13675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600356B")]
		[Address(RVA = "0x7946A0", Offset = "0x7930A0", VA = "0x1807946A0")]
		private void RpcWriter___Observers_Attack_2166136261()
		{
		}

		// Token: 0x0600356C RID: 13676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600356C")]
		[Address(RVA = "0x793E40", Offset = "0x792840", VA = "0x180793E40", Slot = "48")]
		protected virtual void RpcLogic___Attack_2166136261()
		{
		}

		// Token: 0x0600356D RID: 13677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600356D")]
		[Address(RVA = "0x794400", Offset = "0x792E00", VA = "0x180794400")]
		private void RpcReader___Observers_Attack_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600356E RID: 13678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600356E")]
		[Address(RVA = "0x793810", Offset = "0x792210", VA = "0x180793810")]
		private void RpcWriter___Server_NotifyServerTargetSeen_2166136261()
		{
		}

		// Token: 0x0600356F RID: 13679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600356F")]
		[Address(RVA = "0x7940A0", Offset = "0x792AA0", VA = "0x1807940A0")]
		public void RpcLogic___NotifyServerTargetSeen_2166136261()
		{
		}

		// Token: 0x06003570 RID: 13680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003570")]
		[Address(RVA = "0x794560", Offset = "0x792F60", VA = "0x180794560")]
		private void RpcReader___Server_NotifyServerTargetSeen_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06003571 RID: 13681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003571")]
		[Address(RVA = "0x790EB0", Offset = "0x78F8B0", VA = "0x180790EB0", Slot = "49")]
		protected virtual void Awake_UserLogic_ScheduleOne.Combat.CombatBehaviour_Assembly-CSharp.dll()
		{
		}

		// Token: 0x040024FA RID: 9466
		[Token(Token = "0x40024FA")]
		public const float RECENT_VISIBILITY_THRESHOLD = 2.5f;

		// Token: 0x040024FB RID: 9467
		[Token(Token = "0x40024FB")]
		public const float REPOSITION_TIME = 4f;

		// Token: 0x040024FC RID: 9468
		[Token(Token = "0x40024FC")]
		public const float SEARCH_RADIUS_MIN = 25f;

		// Token: 0x040024FD RID: 9469
		[Token(Token = "0x40024FD")]
		public const float SEARCH_RADIUS_MAX = 60f;

		// Token: 0x040024FE RID: 9470
		[Token(Token = "0x40024FE")]
		public const float SEARCH_SPEED = 0.4f;

		// Token: 0x040024FF RID: 9471
		[Token(Token = "0x40024FF")]
		public const float CONSECUTIVE_MISS_ACCURACY_BOOST = 0.1f;

		// Token: 0x04002500 RID: 9472
		[Token(Token = "0x4002500")]
		public const float REACHED_DESTINATION_DISTANCE = 2f;

		// Token: 0x04002504 RID: 9476
		[Token(Token = "0x4002504")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		public bool DEBUG;

		// Token: 0x04002505 RID: 9477
		[Token(Token = "0x4002505")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x174")]
		[Header("General Setttings")]
		public float GiveUpRange;

		// Token: 0x04002506 RID: 9478
		[Token(Token = "0x4002506")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		public float GiveUpTime;

		// Token: 0x04002507 RID: 9479
		[Token(Token = "0x4002507")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		public int GiveUpAfterSuccessfulHits;

		// Token: 0x04002508 RID: 9480
		[Token(Token = "0x4002508")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		public bool PlayAngryVO;

		// Token: 0x04002509 RID: 9481
		[Token(Token = "0x4002509")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x184")]
		[Header("Movement settings")]
		[Range(0f, 1f)]
		public float DefaultMovementSpeed;

		// Token: 0x0400250A RID: 9482
		[Token(Token = "0x400250A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		[Header("Weapon settings")]
		public AvatarWeapon DefaultWeapon;

		// Token: 0x0400250B RID: 9483
		[Token(Token = "0x400250B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		public AvatarMeleeWeapon VirtualPunchWeapon;

		// Token: 0x0400250C RID: 9484
		[Token(Token = "0x400250C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		[Header("Search settings")]
		public float DefaultSearchTime;

		// Token: 0x0400250D RID: 9485
		[Token(Token = "0x400250D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		[Header("References")]
		public SmoothedVelocityCalculator TargetVelocityTracker;

		// Token: 0x0400250E RID: 9486
		[Token(Token = "0x400250E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		[Header("Debug settings")]
		public bool CombatOnStart;

		// Token: 0x0400250F RID: 9487
		[Token(Token = "0x400250F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		public NetworkObject DebugTarget;

		// Token: 0x04002512 RID: 9490
		[Token(Token = "0x4002512")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
		protected float timeSinceLastSighting;

		// Token: 0x04002513 RID: 9491
		[Token(Token = "0x4002513")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		protected Vector3 lastKnownTargetPosition;

		// Token: 0x04002514 RID: 9492
		[Token(Token = "0x4002514")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1CC")]
		private float timeSinceLastReposition;

		// Token: 0x04002515 RID: 9493
		[Token(Token = "0x4002515")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private float timeWithinAttackRange;

		// Token: 0x04002516 RID: 9494
		[Token(Token = "0x4002516")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1D4")]
		private bool visionEventReceived;

		// Token: 0x04002517 RID: 9495
		[Token(Token = "0x4002517")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		protected AvatarWeapon currentWeapon;

		// Token: 0x04002518 RID: 9496
		[Token(Token = "0x4002518")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		protected int successfulHits;

		// Token: 0x04002519 RID: 9497
		[Token(Token = "0x4002519")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1E4")]
		protected int consecutiveMissedShots;

		// Token: 0x0400251A RID: 9498
		[Token(Token = "0x400251A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		protected Coroutine rangedWeaponRoutine;

		// Token: 0x0400251B RID: 9499
		[Token(Token = "0x400251B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		protected Coroutine searchRoutine;

		// Token: 0x0400251C RID: 9500
		[Token(Token = "0x400251C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		protected Vector3 currentSearchDestination;

		// Token: 0x0400251D RID: 9501
		[Token(Token = "0x400251D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x204")]
		protected bool hasSearchDestination;

		// Token: 0x0400251E RID: 9502
		[Token(Token = "0x400251E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		private float nextAngryVO;

		// Token: 0x0400251F RID: 9503
		[Token(Token = "0x400251F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x20C")]
		private bool NetworkInitialize___EarlyScheduleOne.Combat.CombatBehaviourAssembly-CSharp.dll_Excuted;

		// Token: 0x04002520 RID: 9504
		[Token(Token = "0x4002520")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x20D")]
		private bool NetworkInitialize__LateScheduleOne.Combat.CombatBehaviourAssembly-CSharp.dll_Excuted;
	}
}
