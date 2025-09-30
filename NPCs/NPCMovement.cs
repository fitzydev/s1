using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using EasyButtons;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.AvatarFramework.Animation;
using ScheduleOne.Dragging;
using ScheduleOne.Management;
using ScheduleOne.Tools;
using ScheduleOne.Vehicles;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;

namespace ScheduleOne.NPCs
{
	// Token: 0x02000668 RID: 1640
	[Token(Token = "0x2000668")]
	public class NPCMovement : NetworkBehaviour
	{
		// Token: 0x1700068B RID: 1675
		// (get) Token: 0x06002955 RID: 10581 RVA: 0x0000C828 File Offset: 0x0000AA28
		// (set) Token: 0x06002956 RID: 10582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700068B")]
		public bool HasDestination
		{
			[Token(Token = "0x6002955")]
			[Address(RVA = "0x724850", Offset = "0x723250", VA = "0x180724850")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002956")]
			[Address(RVA = "0x724940", Offset = "0x723340", VA = "0x180724940")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700068C RID: 1676
		// (get) Token: 0x06002957 RID: 10583 RVA: 0x0000C840 File Offset: 0x0000AA40
		[Token(Token = "0x1700068C")]
		public bool IsMoving
		{
			[Token(Token = "0x6002957")]
			[Address(RVA = "0x724860", Offset = "0x723260", VA = "0x180724860")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700068D RID: 1677
		// (get) Token: 0x06002958 RID: 10584 RVA: 0x0000C858 File Offset: 0x0000AA58
		// (set) Token: 0x06002959 RID: 10585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700068D")]
		public bool IsPaused
		{
			[Token(Token = "0x6002958")]
			[Address(RVA = "0x7248D0", Offset = "0x7232D0", VA = "0x1807248D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002959")]
			[Address(RVA = "0x724950", Offset = "0x723350", VA = "0x180724950")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700068E RID: 1678
		// (get) Token: 0x0600295A RID: 10586 RVA: 0x0000C870 File Offset: 0x0000AA70
		[Token(Token = "0x1700068E")]
		public Vector3 FootPosition
		{
			[Token(Token = "0x600295A")]
			[Address(RVA = "0x7247F0", Offset = "0x7231F0", VA = "0x1807247F0")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x1700068F RID: 1679
		// (get) Token: 0x0600295B RID: 10587 RVA: 0x0000C888 File Offset: 0x0000AA88
		// (set) Token: 0x0600295C RID: 10588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700068F")]
		public float GravityMultiplier
		{
			[Token(Token = "0x600295B")]
			[Address(RVA = "0x724840", Offset = "0x723240", VA = "0x180724840")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600295C")]
			[Address(RVA = "0x724930", Offset = "0x723330", VA = "0x180724930")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000690 RID: 1680
		// (get) Token: 0x0600295D RID: 10589 RVA: 0x0000C8A0 File Offset: 0x0000AAA0
		// (set) Token: 0x0600295E RID: 10590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000690")]
		public NPCMovement.EStance Stance
		{
			[Token(Token = "0x600295D")]
			[Address(RVA = "0x7248E0", Offset = "0x7232E0", VA = "0x1807248E0")]
			[CompilerGenerated]
			get
			{
				return NPCMovement.EStance.None;
			}
			[Token(Token = "0x600295E")]
			[Address(RVA = "0x722B40", Offset = "0x721540", VA = "0x180722B40")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000691 RID: 1681
		// (get) Token: 0x0600295F RID: 10591 RVA: 0x0000C8B8 File Offset: 0x0000AAB8
		// (set) Token: 0x06002960 RID: 10592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000691")]
		public float TimeSinceHitByCar
		{
			[Token(Token = "0x600295F")]
			[Address(RVA = "0x7248F0", Offset = "0x7232F0", VA = "0x1807248F0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6002960")]
			[Address(RVA = "0x724960", Offset = "0x723360", VA = "0x180724960")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000692 RID: 1682
		// (get) Token: 0x06002961 RID: 10593 RVA: 0x0000C8D0 File Offset: 0x0000AAD0
		[Token(Token = "0x17000692")]
		public bool FaceDirectionInProgress
		{
			[Token(Token = "0x6002961")]
			[Address(RVA = "0x7247E0", Offset = "0x7231E0", VA = "0x1807247E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000693 RID: 1683
		// (get) Token: 0x06002962 RID: 10594 RVA: 0x0000C8E8 File Offset: 0x0000AAE8
		// (set) Token: 0x06002963 RID: 10595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000693")]
		public Vector3 CurrentDestination
		{
			[Token(Token = "0x6002962")]
			[Address(RVA = "0x7247B0", Offset = "0x7231B0", VA = "0x1807247B0")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6002963")]
			[Address(RVA = "0x724900", Offset = "0x723300", VA = "0x180724900")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000694 RID: 1684
		// (get) Token: 0x06002964 RID: 10596 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002965 RID: 10597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000694")]
		public NPCPathCache PathCache
		{
			[Token(Token = "0x6002964")]
			[Address(RVA = "0x66EF40", Offset = "0x66D940", VA = "0x18066EF40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002965")]
			[Address(RVA = "0x66F0B0", Offset = "0x66DAB0", VA = "0x18066F0B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000695 RID: 1685
		// (get) Token: 0x06002966 RID: 10598 RVA: 0x0000C900 File Offset: 0x0000AB00
		// (set) Token: 0x06002967 RID: 10599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000695")]
		public bool Disoriented
		{
			[Token(Token = "0x6002966")]
			[Address(RVA = "0x7247D0", Offset = "0x7231D0", VA = "0x1807247D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002967")]
			[Address(RVA = "0x724920", Offset = "0x723320", VA = "0x180724920")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06002968 RID: 10600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002968")]
		[Address(RVA = "0x71D120", Offset = "0x71BB20", VA = "0x18071D120", Slot = "19")]
		public virtual void Awake()
		{
		}

		// Token: 0x06002969 RID: 10601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002969")]
		[Address(RVA = "0x722D30", Offset = "0x721730", VA = "0x180722D30")]
		private void Start()
		{
		}

		// Token: 0x0600296A RID: 10602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600296A")]
		[Address(RVA = "0x71FCB0", Offset = "0x71E6B0", VA = "0x18071FCB0", Slot = "11")]
		public override void OnStartClient()
		{
		}

		// Token: 0x0600296B RID: 10603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600296B")]
		[Address(RVA = "0x71FCA0", Offset = "0x71E6A0", VA = "0x18071FCA0", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x0600296C RID: 10604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600296C")]
		[Address(RVA = "0x42DA80", Offset = "0x42C480", VA = "0x18042DA80", Slot = "20")]
		protected virtual void Update()
		{
		}

		// Token: 0x0600296D RID: 10605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600296D")]
		[Address(RVA = "0x71F9E0", Offset = "0x71E3E0", VA = "0x18071F9E0", Slot = "21")]
		protected virtual void LateUpdate()
		{
		}

		// Token: 0x0600296E RID: 10606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600296E")]
		[Address(RVA = "0x7237C0", Offset = "0x7221C0", VA = "0x1807237C0")]
		private void UpdateRagdoll()
		{
		}

		// Token: 0x0600296F RID: 10607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600296F")]
		[Address(RVA = "0x722F90", Offset = "0x721990", VA = "0x180722F90")]
		[Button]
		private void Stumble()
		{
		}

		// Token: 0x06002970 RID: 10608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002970")]
		[Address(RVA = "0x723410", Offset = "0x721E10", VA = "0x180723410")]
		private void UpdateDestination()
		{
		}

		// Token: 0x06002971 RID: 10609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002971")]
		[Address(RVA = "0x71E900", Offset = "0x71D300", VA = "0x18071E900", Slot = "22")]
		protected virtual void FixedUpdate()
		{
		}

		// Token: 0x06002972 RID: 10610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002972")]
		[Address(RVA = "0x723D00", Offset = "0x722700", VA = "0x180723D00")]
		private void UpdateStumble()
		{
		}

		// Token: 0x06002973 RID: 10611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002973")]
		[Address(RVA = "0x723C70", Offset = "0x722670", VA = "0x180723C70")]
		private void UpdateSpeed()
		{
		}

		// Token: 0x06002974 RID: 10612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002974")]
		[Address(RVA = "0x71FFB0", Offset = "0x71E9B0", VA = "0x18071FFB0")]
		private void RecordVelocity()
		{
		}

		// Token: 0x06002975 RID: 10613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002975")]
		[Address(RVA = "0x723940", Offset = "0x722340", VA = "0x180723940")]
		private void UpdateSlippery()
		{
		}

		// Token: 0x06002976 RID: 10614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002976")]
		[Address(RVA = "0x723240", Offset = "0x721C40", VA = "0x180723240")]
		private void UpdateCache()
		{
		}

		// Token: 0x06002977 RID: 10615 RVA: 0x0000C918 File Offset: 0x0000AB18
		[Token(Token = "0x6002977")]
		[Address(RVA = "0x71D850", Offset = "0x71C250", VA = "0x18071D850")]
		public bool CanRecoverFromRagdoll()
		{
			return default(bool);
		}

		// Token: 0x06002978 RID: 10616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002978")]
		[Address(RVA = "0x723140", Offset = "0x721B40", VA = "0x180723140")]
		private void UpdateAvoidance()
		{
		}

		// Token: 0x06002979 RID: 10617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002979")]
		[Address(RVA = "0x71FD00", Offset = "0x71E700", VA = "0x18071FD00")]
		public void OnTriggerEnter(Collider other)
		{
		}

		// Token: 0x0600297A RID: 10618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600297A")]
		[Address(RVA = "0x71FBC0", Offset = "0x71E5C0", VA = "0x18071FBC0")]
		public void OnCollisionEnter(Collision collision)
		{
		}

		// Token: 0x0600297B RID: 10619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600297B")]
		[Address(RVA = "0x71D890", Offset = "0x71C290", VA = "0x18071D890")]
		private void CheckHit(Collider other, Collider thisCollider, bool isCollision, Vector3 hitPoint)
		{
		}

		// Token: 0x0600297C RID: 10620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600297C")]
		[Address(RVA = "0x724000", Offset = "0x722A00", VA = "0x180724000")]
		public void Warp(Transform target)
		{
		}

		// Token: 0x0600297D RID: 10621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600297D")]
		[Address(RVA = "0x724090", Offset = "0x722A90", VA = "0x180724090")]
		public void Warp(Vector3 position)
		{
		}

		// Token: 0x0600297E RID: 10622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600297E")]
		[Address(RVA = "0x71FE20", Offset = "0x71E820", VA = "0x18071FE20")]
		[ObserversRpc(ExcludeServer = true)]
		private void ReceiveWarp(Vector3 position)
		{
		}

		// Token: 0x0600297F RID: 10623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600297F")]
		[Address(RVA = "0x723FC0", Offset = "0x7229C0", VA = "0x180723FC0")]
		public void VisibilityChange(bool visible)
		{
		}

		// Token: 0x06002980 RID: 10624 RVA: 0x0000C930 File Offset: 0x0000AB30
		[Token(Token = "0x6002980")]
		[Address(RVA = "0x71D7E0", Offset = "0x71C1E0", VA = "0x18071D7E0")]
		public bool CanMove()
		{
			return default(bool);
		}

		// Token: 0x06002981 RID: 10625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002981")]
		[Address(RVA = "0x721910", Offset = "0x720310", VA = "0x180721910")]
		public void SetAgentType(NPCMovement.EAgentType type)
		{
		}

		// Token: 0x06002982 RID: 10626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002982")]
		[Address(RVA = "0x722A80", Offset = "0x721480", VA = "0x180722A80")]
		public void SetSeat(AvatarSeat seat)
		{
		}

		// Token: 0x06002983 RID: 10627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002983")]
		[Address(RVA = "0x722B40", Offset = "0x721540", VA = "0x180722B40")]
		public void SetStance(NPCMovement.EStance stance)
		{
		}

		// Token: 0x06002984 RID: 10628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002984")]
		[Address(RVA = "0x722790", Offset = "0x721190", VA = "0x180722790")]
		public void SetGravityMultiplier(float multiplier)
		{
		}

		// Token: 0x06002985 RID: 10629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002985")]
		[Address(RVA = "0x7229A0", Offset = "0x7213A0", VA = "0x1807229A0")]
		public void SetRagdollDraggable(bool draggable)
		{
		}

		// Token: 0x06002986 RID: 10630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002986")]
		[Address(RVA = "0x71CAB0", Offset = "0x71B4B0", VA = "0x18071CAB0")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void ActivateRagdoll_Server()
		{
		}

		// Token: 0x06002987 RID: 10631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002987")]
		[Address(RVA = "0x71CBC0", Offset = "0x71B5C0", VA = "0x18071CBC0")]
		[ObserversRpc(RunLocally = true)]
		public void ActivateRagdoll(Vector3 forcePoint, Vector3 forceDir, float forceMagnitude)
		{
		}

		// Token: 0x06002988 RID: 10632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002988")]
		[Address(RVA = "0x71CC80", Offset = "0x71B680", VA = "0x18071CC80")]
		[ObserversRpc(RunLocally = true)]
		public void ApplyRagdollForce(Vector3 forcePoint, Vector3 forceDir, float forceMagnitude)
		{
		}

		// Token: 0x06002989 RID: 10633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002989")]
		[Address(RVA = "0x71E160", Offset = "0x71CB60", VA = "0x18071E160")]
		[ObserversRpc(RunLocally = true)]
		public void DeactivateRagdoll()
		{
		}

		// Token: 0x0600298A RID: 10634 RVA: 0x0000C948 File Offset: 0x0000AB48
		[Token(Token = "0x600298A")]
		[Address(RVA = "0x722B50", Offset = "0x721550", VA = "0x180722B50")]
		private bool SmartSampleNavMesh(Vector3 position, out NavMeshHit hit, float minRadius = 1f, float maxRadius = 10f, int steps = 3)
		{
			return default(bool);
		}

		// Token: 0x0600298B RID: 10635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600298B")]
		[Address(RVA = "0x721A00", Offset = "0x720400", VA = "0x180721A00")]
		public void SetDestination(Vector3 pos)
		{
		}

		// Token: 0x0600298C RID: 10636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600298C")]
		[Address(RVA = "0x7226C0", Offset = "0x7210C0", VA = "0x1807226C0")]
		public void SetDestination(ITransitEntity entity)
		{
		}

		// Token: 0x0600298D RID: 10637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600298D")]
		[Address(RVA = "0x722670", Offset = "0x721070", VA = "0x180722670")]
		public void SetDestination(Vector3 pos, [Optional] Action<NPCMovement.WalkResult> callback, float maximumDistanceForSuccess = 1f, float cacheMaxDistSqr = 1f)
		{
		}

		// Token: 0x0600298E RID: 10638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600298E")]
		[Address(RVA = "0x721A50", Offset = "0x720450", VA = "0x180721A50")]
		private void SetDestination(Vector3 pos, [Optional] Action<NPCMovement.WalkResult> callback, bool interruptExistingCallback = true, float successThreshold = 1f, float cacheMaxDistSqr = 1f)
		{
		}

		// Token: 0x0600298F RID: 10639 RVA: 0x0000C960 File Offset: 0x0000AB60
		[Token(Token = "0x600298F")]
		[Address(RVA = "0x71F960", Offset = "0x71E360", VA = "0x18071F960")]
		private bool IsNPCPositionValid(Vector3 position)
		{
			return default(bool);
		}

		// Token: 0x06002990 RID: 10640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002990")]
		[Address(RVA = "0x71E280", Offset = "0x71CC80", VA = "0x18071E280")]
		private void EndSetDestination(NPCMovement.WalkResult result)
		{
		}

		// Token: 0x06002991 RID: 10641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002991")]
		[Address(RVA = "0x722E60", Offset = "0x721860", VA = "0x180722E60")]
		public void Stop()
		{
		}

		// Token: 0x06002992 RID: 10642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002992")]
		[Address(RVA = "0x42DA80", Offset = "0x42C480", VA = "0x18042DA80")]
		public void WarpToNavMesh()
		{
		}

		// Token: 0x06002993 RID: 10643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002993")]
		[Address(RVA = "0x71E6F0", Offset = "0x71D0F0", VA = "0x18071E6F0")]
		public void FacePoint(Vector3 point, float lerpTime = 0.5f)
		{
		}

		// Token: 0x06002994 RID: 10644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002994")]
		[Address(RVA = "0x71E4D0", Offset = "0x71CED0", VA = "0x18071E4D0")]
		public void FaceDirection(Vector3 forward, float lerpTime = 0.5f)
		{
		}

		// Token: 0x06002995 RID: 10645 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002995")]
		[Address(RVA = "0x71E430", Offset = "0x71CE30", VA = "0x18071E430")]
		protected IEnumerator FaceDirection_Process(Vector3 forward, float lerpTime)
		{
			return null;
		}

		// Token: 0x06002996 RID: 10646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002996")]
		[Address(RVA = "0x71FD90", Offset = "0x71E790", VA = "0x18071FD90")]
		public void PauseMovement()
		{
		}

		// Token: 0x06002997 RID: 10647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002997")]
		[Address(RVA = "0x720110", Offset = "0x71EB10", VA = "0x180720110")]
		public void ResumeMovement()
		{
		}

		// Token: 0x06002998 RID: 10648 RVA: 0x0000C978 File Offset: 0x0000AB78
		[Token(Token = "0x6002998")]
		[Address(RVA = "0x71F7A0", Offset = "0x71E1A0", VA = "0x18071F7A0")]
		public bool IsAsCloseAsPossible(Vector3 location, float distanceThreshold = 0.5f)
		{
			return default(bool);
		}

		// Token: 0x06002999 RID: 10649 RVA: 0x0000C990 File Offset: 0x0000AB90
		[Token(Token = "0x6002999")]
		[Address(RVA = "0x71EF50", Offset = "0x71D950", VA = "0x18071EF50")]
		public bool GetClosestReachablePoint(Vector3 targetPosition, out Vector3 closestPoint)
		{
			return default(bool);
		}

		// Token: 0x0600299A RID: 10650 RVA: 0x0000C9A8 File Offset: 0x0000ABA8
		[Token(Token = "0x600299A")]
		[Address(RVA = "0x71D5C0", Offset = "0x71BFC0", VA = "0x18071D5C0")]
		public bool CanGetTo(Vector3 position, float proximityReq = 1f)
		{
			return default(bool);
		}

		// Token: 0x0600299B RID: 10651 RVA: 0x0000C9C0 File Offset: 0x0000ABC0
		[Token(Token = "0x600299B")]
		[Address(RVA = "0x71D600", Offset = "0x71C000", VA = "0x18071D600")]
		public bool CanGetTo(ITransitEntity entity, float proximityReq = 1f)
		{
			return default(bool);
		}

		// Token: 0x0600299C RID: 10652 RVA: 0x0000C9D8 File Offset: 0x0000ABD8
		[Token(Token = "0x600299C")]
		[Address(RVA = "0x71D170", Offset = "0x71BB70", VA = "0x18071D170")]
		public bool CanGetTo(Vector3 position, float proximityReq, out NavMeshPath path)
		{
			return default(bool);
		}

		// Token: 0x0600299D RID: 10653 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600299D")]
		[Address(RVA = "0x71F3E0", Offset = "0x71DDE0", VA = "0x18071F3E0")]
		private NavMeshPath GetPathTo(Vector3 position, float proximityReq = 1f)
		{
			return null;
		}

		// Token: 0x0600299E RID: 10654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600299E")]
		[Address(RVA = "0x724520", Offset = "0x722F20", VA = "0x180724520")]
		public NPCMovement()
		{
		}

		// Token: 0x060029A0 RID: 10656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029A0")]
		[Address(RVA = "0x71FA10", Offset = "0x71E410", VA = "0x18071FA10", Slot = "23")]
		public virtual void NetworkInitialize___Early()
		{
		}

		// Token: 0x060029A1 RID: 10657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029A1")]
		[Address(RVA = "0x71F9F0", Offset = "0x71E3F0", VA = "0x18071F9F0", Slot = "24")]
		public virtual void NetworkInitialize__Late()
		{
		}

		// Token: 0x060029A2 RID: 10658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029A2")]
		[Address(RVA = "0x6806A0", Offset = "0x67F0A0", VA = "0x1806806A0", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x060029A3 RID: 10659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029A3")]
		[Address(RVA = "0x71FE20", Offset = "0x71E820", VA = "0x18071FE20")]
		private void RpcWriter___Observers_ReceiveWarp_4276783012(Vector3 position)
		{
		}

		// Token: 0x060029A4 RID: 10660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029A4")]
		[Address(RVA = "0x720CC0", Offset = "0x71F6C0", VA = "0x180720CC0")]
		private void RpcLogic___ReceiveWarp_4276783012(Vector3 position)
		{
		}

		// Token: 0x060029A5 RID: 10661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029A5")]
		[Address(RVA = "0x721200", Offset = "0x71FC00", VA = "0x180721200")]
		private void RpcReader___Observers_ReceiveWarp_4276783012(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060029A6 RID: 10662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029A6")]
		[Address(RVA = "0x721800", Offset = "0x720200", VA = "0x180721800")]
		private void RpcWriter___Server_ActivateRagdoll_Server_2166136261()
		{
		}

		// Token: 0x060029A7 RID: 10663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029A7")]
		[Address(RVA = "0x7204F0", Offset = "0x71EEF0", VA = "0x1807204F0")]
		public void RpcLogic___ActivateRagdoll_Server_2166136261()
		{
		}

		// Token: 0x060029A8 RID: 10664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029A8")]
		[Address(RVA = "0x7212B0", Offset = "0x71FCB0", VA = "0x1807212B0")]
		private void RpcReader___Server_ActivateRagdoll_Server_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060029A9 RID: 10665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029A9")]
		[Address(RVA = "0x721300", Offset = "0x71FD00", VA = "0x180721300")]
		private void RpcWriter___Observers_ActivateRagdoll_2690242654(Vector3 forcePoint, Vector3 forceDir, float forceMagnitude)
		{
		}

		// Token: 0x060029AA RID: 10666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029AA")]
		[Address(RVA = "0x720160", Offset = "0x71EB60", VA = "0x180720160")]
		public void RpcLogic___ActivateRagdoll_2690242654(Vector3 forcePoint, Vector3 forceDir, float forceMagnitude)
		{
		}

		// Token: 0x060029AB RID: 10667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029AB")]
		[Address(RVA = "0x720F00", Offset = "0x71F900", VA = "0x180720F00")]
		private void RpcReader___Observers_ActivateRagdoll_2690242654(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060029AC RID: 10668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029AC")]
		[Address(RVA = "0x7214F0", Offset = "0x71FEF0", VA = "0x1807214F0")]
		private void RpcWriter___Observers_ApplyRagdollForce_2690242654(Vector3 forcePoint, Vector3 forceDir, float forceMagnitude)
		{
		}

		// Token: 0x060029AD RID: 10669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029AD")]
		[Address(RVA = "0x7205F0", Offset = "0x71EFF0", VA = "0x1807205F0")]
		public void RpcLogic___ApplyRagdollForce_2690242654(Vector3 forcePoint, Vector3 forceDir, float forceMagnitude)
		{
		}

		// Token: 0x060029AE RID: 10670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029AE")]
		[Address(RVA = "0x721060", Offset = "0x71FA60", VA = "0x180721060")]
		private void RpcReader___Observers_ApplyRagdollForce_2690242654(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060029AF RID: 10671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029AF")]
		[Address(RVA = "0x7216E0", Offset = "0x7200E0", VA = "0x1807216E0")]
		private void RpcWriter___Observers_DeactivateRagdoll_2166136261()
		{
		}

		// Token: 0x060029B0 RID: 10672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029B0")]
		[Address(RVA = "0x7208B0", Offset = "0x71F2B0", VA = "0x1807208B0")]
		public void RpcLogic___DeactivateRagdoll_2166136261()
		{
		}

		// Token: 0x060029B1 RID: 10673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029B1")]
		[Address(RVA = "0x7211C0", Offset = "0x71FBC0", VA = "0x1807211C0")]
		private void RpcReader___Observers_DeactivateRagdoll_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060029B2 RID: 10674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029B2")]
		[Address(RVA = "0x71CD40", Offset = "0x71B740", VA = "0x18071CD40", Slot = "25")]
		protected virtual void Awake_UserLogic_ScheduleOne.NPCs.NPCMovement_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04001EF7 RID: 7927
		[Token(Token = "0x4001EF7")]
		public const float VEHICLE_RUNOVER_THRESHOLD = 10f;

		// Token: 0x04001EF8 RID: 7928
		[Token(Token = "0x4001EF8")]
		public const float SKATEBOARD_RUNOVER_THRESHOLD = 10f;

		// Token: 0x04001EF9 RID: 7929
		[Token(Token = "0x4001EF9")]
		public const float LIGHT_FLINCH_THRESHOLD = 50f;

		// Token: 0x04001EFA RID: 7930
		[Token(Token = "0x4001EFA")]
		public const float HEAVY_FLINCH_THRESHOLD = 100f;

		// Token: 0x04001EFB RID: 7931
		[Token(Token = "0x4001EFB")]
		public const float RAGDOLL_THRESHOLD = 150f;

		// Token: 0x04001EFC RID: 7932
		[Token(Token = "0x4001EFC")]
		public const float MOMENTUM_ANNOYED_THRESHOLD = 10f;

		// Token: 0x04001EFD RID: 7933
		[Token(Token = "0x4001EFD")]
		public const float MOMENTUM_LIGHT_FLINCH_THRESHOLD = 20f;

		// Token: 0x04001EFE RID: 7934
		[Token(Token = "0x4001EFE")]
		public const float MOMENTUM_HEAVY_FLINCH_THRESHOLD = 40f;

		// Token: 0x04001EFF RID: 7935
		[Token(Token = "0x4001EFF")]
		public const float MOMENTUM_RAGDOLL_THRESHOLD = 60f;

		// Token: 0x04001F00 RID: 7936
		[Token(Token = "0x4001F00")]
		public const bool USE_PATH_CACHE = true;

		// Token: 0x04001F01 RID: 7937
		[Token(Token = "0x4001F01")]
		public const float STUMBLE_DURATION = 0.66f;

		// Token: 0x04001F02 RID: 7938
		[Token(Token = "0x4001F02")]
		public const float STUMBLE_FORCE = 7f;

		// Token: 0x04001F03 RID: 7939
		[Token(Token = "0x4001F03")]
		public const float OBSTACLE_AVOIDANCE_RANGE = 25f;

		// Token: 0x04001F04 RID: 7940
		[Token(Token = "0x4001F04")]
		public const float PLAYER_DIST_IMPACT_THRESHOLD = 30f;

		// Token: 0x04001F05 RID: 7941
		[Token(Token = "0x4001F05")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Dictionary<Vector3, Vector3> cachedClosestReachablePoints;

		// Token: 0x04001F06 RID: 7942
		[Token(Token = "0x4001F06")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static List<Vector3> cachedClosestPointKeys;

		// Token: 0x04001F07 RID: 7943
		[Token(Token = "0x4001F07")]
		public const float CLOSEST_REACHABLE_POINT_CACHE_MAX_SQR_OFFSET = 1f;

		// Token: 0x04001F08 RID: 7944
		[Token(Token = "0x4001F08")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public bool DEBUG;

		// Token: 0x04001F09 RID: 7945
		[Token(Token = "0x4001F09")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		[Header("Settings")]
		public float WalkSpeed;

		// Token: 0x04001F0A RID: 7946
		[Token(Token = "0x4001F0A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public float RunSpeed;

		// Token: 0x04001F0B RID: 7947
		[Token(Token = "0x4001F0B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		public float MoveSpeedMultiplier;

		// Token: 0x04001F0C RID: 7948
		[Token(Token = "0x4001F0C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		[Header("Obstacle Avoidance")]
		public bool ObstacleAvoidanceEnabled;

		// Token: 0x04001F0D RID: 7949
		[Token(Token = "0x4001F0D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		public ObstacleAvoidanceType DefaultObstacleAvoidanceType;

		// Token: 0x04001F0E RID: 7950
		[Token(Token = "0x4001F0E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		[Header("Slippery Mode")]
		public bool SlipperyMode;

		// Token: 0x04001F0F RID: 7951
		[Token(Token = "0x4001F0F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		public float SlipperyModeMultiplier;

		// Token: 0x04001F10 RID: 7952
		[Token(Token = "0x4001F10")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		[Header("References")]
		public NavMeshAgent Agent;

		// Token: 0x04001F11 RID: 7953
		[Token(Token = "0x4001F11")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		public NPCSpeedController SpeedController;

		// Token: 0x04001F12 RID: 7954
		[Token(Token = "0x4001F12")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		public CapsuleCollider CapsuleCollider;

		// Token: 0x04001F13 RID: 7955
		[Token(Token = "0x4001F13")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		public NPCAnimation Animation;

		// Token: 0x04001F14 RID: 7956
		[Token(Token = "0x4001F14")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		public SmoothedVelocityCalculator VelocityCalculator;

		// Token: 0x04001F15 RID: 7957
		[Token(Token = "0x4001F15")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		public Draggable RagdollDraggable;

		// Token: 0x04001F16 RID: 7958
		[Token(Token = "0x4001F16")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		public Collider RagdollDraggableCollider;

		// Token: 0x04001F17 RID: 7959
		[Token(Token = "0x4001F17")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		protected NPC npc;

		// Token: 0x04001F18 RID: 7960
		[Token(Token = "0x4001F18")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		public float MovementSpeedScale;

		// Token: 0x04001F1E RID: 7966
		[Token(Token = "0x4001F1E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
		private float ragdollStaticTime;

		// Token: 0x04001F1F RID: 7967
		[Token(Token = "0x4001F1F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		public UnityEvent<LandVehicle> onHitByCar;

		// Token: 0x04001F20 RID: 7968
		[Token(Token = "0x4001F20")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		public UnityEvent onRagdollStart;

		// Token: 0x04001F21 RID: 7969
		[Token(Token = "0x4001F21")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		public UnityEvent onRagdollEnd;

		// Token: 0x04001F24 RID: 7972
		[Token(Token = "0x4001F24")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private bool cacheNextPath;

		// Token: 0x04001F25 RID: 7973
		[Token(Token = "0x4001F25")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
		private Vector3 currentDestination_Reachable;

		// Token: 0x04001F26 RID: 7974
		[Token(Token = "0x4001F26")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private Action<NPCMovement.WalkResult> walkResultCallback;

		// Token: 0x04001F27 RID: 7975
		[Token(Token = "0x4001F27")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private float currentMaxDistanceForSuccess;

		// Token: 0x04001F28 RID: 7976
		[Token(Token = "0x4001F28")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1DC")]
		private bool forceIsMoving;

		// Token: 0x04001F29 RID: 7977
		[Token(Token = "0x4001F29")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private Coroutine faceDirectionRoutine;

		// Token: 0x04001F2A RID: 7978
		[Token(Token = "0x4001F2A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private List<ConstantForce> ragdollForceComponents;

		// Token: 0x04001F2C RID: 7980
		[Token(Token = "0x4001F2C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1F4")]
		private float timeUntilNextStumble;

		// Token: 0x04001F2D RID: 7981
		[Token(Token = "0x4001F2D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private float timeSinceStumble;

		// Token: 0x04001F2E RID: 7982
		[Token(Token = "0x4001F2E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1FC")]
		private Vector3 stumbleDirection;

		// Token: 0x04001F2F RID: 7983
		[Token(Token = "0x4001F2F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		private List<Vector3> desiredVelocityHistory;

		// Token: 0x04001F30 RID: 7984
		[Token(Token = "0x4001F30")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		private int desiredVelocityHistoryLength;

		// Token: 0x04001F31 RID: 7985
		[Token(Token = "0x4001F31")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x214")]
		private float velocityHistorySpacing;

		// Token: 0x04001F32 RID: 7986
		[Token(Token = "0x4001F32")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		private float timeSinceLastVelocityHistoryRecord;

		// Token: 0x04001F33 RID: 7987
		[Token(Token = "0x4001F33")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		private NavMeshPath agentCurrentPath;

		// Token: 0x04001F34 RID: 7988
		[Token(Token = "0x4001F34")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		private Vector3[] agentCurrentPathCorners;

		// Token: 0x04001F35 RID: 7989
		[Token(Token = "0x4001F35")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x230")]
		private bool NetworkInitialize___EarlyScheduleOne.NPCs.NPCMovementAssembly-CSharp.dll_Excuted;

		// Token: 0x04001F36 RID: 7990
		[Token(Token = "0x4001F36")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x231")]
		private bool NetworkInitialize__LateScheduleOne.NPCs.NPCMovementAssembly-CSharp.dll_Excuted;

		// Token: 0x02000669 RID: 1641
		[Token(Token = "0x2000669")]
		public enum EAgentType
		{
			// Token: 0x04001F38 RID: 7992
			[Token(Token = "0x4001F38")]
			Humanoid,
			// Token: 0x04001F39 RID: 7993
			[Token(Token = "0x4001F39")]
			BigHumanoid,
			// Token: 0x04001F3A RID: 7994
			[Token(Token = "0x4001F3A")]
			IgnoreCosts
		}

		// Token: 0x0200066A RID: 1642
		[Token(Token = "0x200066A")]
		public enum EStance
		{
			// Token: 0x04001F3C RID: 7996
			[Token(Token = "0x4001F3C")]
			None,
			// Token: 0x04001F3D RID: 7997
			[Token(Token = "0x4001F3D")]
			Stanced
		}

		// Token: 0x0200066B RID: 1643
		[Token(Token = "0x200066B")]
		public enum WalkResult
		{
			// Token: 0x04001F3F RID: 7999
			[Token(Token = "0x4001F3F")]
			Failed,
			// Token: 0x04001F40 RID: 8000
			[Token(Token = "0x4001F40")]
			Interrupted,
			// Token: 0x04001F41 RID: 8001
			[Token(Token = "0x4001F41")]
			Stopped,
			// Token: 0x04001F42 RID: 8002
			[Token(Token = "0x4001F42")]
			Partial,
			// Token: 0x04001F43 RID: 8003
			[Token(Token = "0x4001F43")]
			Success
		}
	}
}
