using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using RootMotion.FinalIK;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.AvatarFramework.Animation
{
	// Token: 0x02000A3B RID: 2619
	[Token(Token = "0x2000A3B")]
	public class AvatarLookController : MonoBehaviour
	{
		// Token: 0x17000A1E RID: 2590
		// (get) Token: 0x060047BD RID: 18365 RVA: 0x00012D68 File Offset: 0x00010F68
		// (set) Token: 0x060047BE RID: 18366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A1E")]
		public float BodyRotationSpeedMultiplier
		{
			[Token(Token = "0x60047BD")]
			[Address(RVA = "0x485C90", Offset = "0x484690", VA = "0x180485C90")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60047BE")]
			[Address(RVA = "0x485CD0", Offset = "0x4846D0", VA = "0x180485CD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060047BF RID: 18367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047BF")]
		[Address(RVA = "0x8EF4B0", Offset = "0x8EDEB0", VA = "0x1808EF4B0")]
		private void Awake()
		{
		}

		// Token: 0x060047C0 RID: 18368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047C0")]
		[Address(RVA = "0x8F0AE0", Offset = "0x8EF4E0", VA = "0x1808F0AE0")]
		private void UpdateLook()
		{
		}

		// Token: 0x060047C1 RID: 18369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047C1")]
		[Address(RVA = "0x8F1640", Offset = "0x8F0040", VA = "0x1808F1640")]
		private void UpdateNearestPlayer()
		{
		}

		// Token: 0x060047C2 RID: 18370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047C2")]
		[Address(RVA = "0x8EFB10", Offset = "0x8EE510", VA = "0x1808EFB10")]
		private void LateUpdate()
		{
		}

		// Token: 0x060047C3 RID: 18371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047C3")]
		[Address(RVA = "0x8F0740", Offset = "0x8EF140", VA = "0x1808F0740")]
		public void OverrideLookTarget(Vector3 targetPosition, int priority, bool rotateBody = false)
		{
		}

		// Token: 0x060047C4 RID: 18372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047C4")]
		[Address(RVA = "0x8F05C0", Offset = "0x8EEFC0", VA = "0x1808F05C0")]
		private void LookForward()
		{
		}

		// Token: 0x060047C5 RID: 18373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047C5")]
		[Address(RVA = "0x8F0240", Offset = "0x8EEC40", VA = "0x1808F0240")]
		private void LerpTargetTransform()
		{
		}

		// Token: 0x060047C6 RID: 18374 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047C6")]
		[Address(RVA = "0x8EFA00", Offset = "0x8EE400", VA = "0x1808EFA00")]
		private Player GetNearestPlayer()
		{
			return null;
		}

		// Token: 0x060047C7 RID: 18375 RVA: 0x00012D80 File Offset: 0x00010F80
		[Token(Token = "0x60047C7")]
		[Address(RVA = "0x8EF7B0", Offset = "0x8EE1B0", VA = "0x1808EF7B0")]
		private bool CanLookAt(Vector3 position)
		{
			return default(bool);
		}

		// Token: 0x060047C8 RID: 18376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047C8")]
		[Address(RVA = "0x42DA80", Offset = "0x42C480", VA = "0x18042DA80")]
		protected void RagdollChange(bool oldValue, bool ragdoll, bool playStandUpAnim)
		{
		}

		// Token: 0x060047C9 RID: 18377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047C9")]
		[Address(RVA = "0x8F0710", Offset = "0x8EF110", VA = "0x1808F0710")]
		public void OverrideIKWeight(float weight)
		{
		}

		// Token: 0x060047CA RID: 18378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047CA")]
		[Address(RVA = "0x8F0960", Offset = "0x8EF360", VA = "0x1808F0960")]
		public void ResetIKWeight()
		{
		}

		// Token: 0x060047CB RID: 18379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047CB")]
		[Address(RVA = "0x8F1AA0", Offset = "0x8F04A0", VA = "0x1808F1AA0")]
		public AvatarLookController()
		{
		}

		// Token: 0x040032A3 RID: 12963
		[Token(Token = "0x40032A3")]
		public const float LookAtPlayerRange = 4f;

		// Token: 0x040032A4 RID: 12964
		[Token(Token = "0x40032A4")]
		public const float EyeContractRange = 10f;

		// Token: 0x040032A5 RID: 12965
		[Token(Token = "0x40032A5")]
		public const float AimIKRange = 20f;

		// Token: 0x040032A6 RID: 12966
		[Token(Token = "0x40032A6")]
		[FieldOffset(Offset = "0x20")]
		public bool DEBUG;

		// Token: 0x040032A8 RID: 12968
		[Token(Token = "0x40032A8")]
		[FieldOffset(Offset = "0x28")]
		[Header("References")]
		public AimIK Aim;

		// Token: 0x040032A9 RID: 12969
		[Token(Token = "0x40032A9")]
		[FieldOffset(Offset = "0x30")]
		public Transform HeadBone;

		// Token: 0x040032AA RID: 12970
		[Token(Token = "0x40032AA")]
		[FieldOffset(Offset = "0x38")]
		public Transform LookForwardTarget;

		// Token: 0x040032AB RID: 12971
		[Token(Token = "0x40032AB")]
		[FieldOffset(Offset = "0x40")]
		public Transform LookOrigin;

		// Token: 0x040032AC RID: 12972
		[Token(Token = "0x40032AC")]
		[FieldOffset(Offset = "0x48")]
		public EyeController Eyes;

		// Token: 0x040032AD RID: 12973
		[Token(Token = "0x40032AD")]
		[FieldOffset(Offset = "0x50")]
		[Header("Optional NPC reference")]
		public NPC NPC;

		// Token: 0x040032AE RID: 12974
		[Token(Token = "0x40032AE")]
		[FieldOffset(Offset = "0x58")]
		[Header("Settings")]
		public bool AutoLookAtPlayer;

		// Token: 0x040032AF RID: 12975
		[Token(Token = "0x40032AF")]
		[FieldOffset(Offset = "0x5C")]
		public float LookLerpSpeed;

		// Token: 0x040032B0 RID: 12976
		[Token(Token = "0x40032B0")]
		[FieldOffset(Offset = "0x60")]
		public float AimIKWeight;

		// Token: 0x040032B1 RID: 12977
		[Token(Token = "0x40032B1")]
		[FieldOffset(Offset = "0x64")]
		public float BodyRotationSpeed;

		// Token: 0x040032B2 RID: 12978
		[Token(Token = "0x40032B2")]
		[FieldOffset(Offset = "0x68")]
		private Avatar avatar;

		// Token: 0x040032B3 RID: 12979
		[Token(Token = "0x40032B3")]
		[FieldOffset(Offset = "0x70")]
		private Vector3 lookAtPos;

		// Token: 0x040032B4 RID: 12980
		[Token(Token = "0x40032B4")]
		[FieldOffset(Offset = "0x80")]
		private Transform lookAtTarget;

		// Token: 0x040032B5 RID: 12981
		[Token(Token = "0x40032B5")]
		[FieldOffset(Offset = "0x88")]
		private Vector3 lastFrameOffset;

		// Token: 0x040032B6 RID: 12982
		[Token(Token = "0x40032B6")]
		[FieldOffset(Offset = "0x94")]
		private bool overrideLookAt;

		// Token: 0x040032B7 RID: 12983
		[Token(Token = "0x40032B7")]
		[FieldOffset(Offset = "0x98")]
		private Vector3 overriddenLookTarget;

		// Token: 0x040032B8 RID: 12984
		[Token(Token = "0x40032B8")]
		[FieldOffset(Offset = "0xA4")]
		private int overrideLookPriority;

		// Token: 0x040032B9 RID: 12985
		[Token(Token = "0x40032B9")]
		[FieldOffset(Offset = "0xA8")]
		private bool overrideRotateBody;

		// Token: 0x040032BA RID: 12986
		[Token(Token = "0x40032BA")]
		[FieldOffset(Offset = "0xAC")]
		private Vector3 lastFrameLookOriginPos;

		// Token: 0x040032BB RID: 12987
		[Token(Token = "0x40032BB")]
		[FieldOffset(Offset = "0xB8")]
		private Vector3 lastFrameLookOriginForward;

		// Token: 0x040032BC RID: 12988
		[Token(Token = "0x40032BC")]
		[FieldOffset(Offset = "0xC8")]
		public Transform ForceLookTarget;

		// Token: 0x040032BD RID: 12989
		[Token(Token = "0x40032BD")]
		[FieldOffset(Offset = "0xD0")]
		public bool ForceLookRotateBody;

		// Token: 0x040032BE RID: 12990
		[Token(Token = "0x40032BE")]
		[FieldOffset(Offset = "0xD4")]
		private float defaultIKWeight;

		// Token: 0x040032BF RID: 12991
		[Token(Token = "0x40032BF")]
		[FieldOffset(Offset = "0xD8")]
		private Player nearestPlayer;

		// Token: 0x040032C0 RID: 12992
		[Token(Token = "0x40032C0")]
		[FieldOffset(Offset = "0xE0")]
		private float nearestPlayerDist;

		// Token: 0x040032C1 RID: 12993
		[Token(Token = "0x40032C1")]
		[FieldOffset(Offset = "0xE4")]
		private float localPlayerDist;

		// Token: 0x040032C2 RID: 12994
		[Token(Token = "0x40032C2")]
		[FieldOffset(Offset = "0xE8")]
		private float cullRange;
	}
}
