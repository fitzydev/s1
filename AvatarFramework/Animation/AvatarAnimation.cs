using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Skating;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.AvatarFramework.Animation
{
	// Token: 0x02000A32 RID: 2610
	[Token(Token = "0x2000A32")]
	public class AvatarAnimation : MonoBehaviour
	{
		// Token: 0x17000A14 RID: 2580
		// (get) Token: 0x06004778 RID: 18296 RVA: 0x00012C90 File Offset: 0x00010E90
		// (set) Token: 0x06004779 RID: 18297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A14")]
		public bool IsCrouched
		{
			[Token(Token = "0x6004778")]
			[Address(RVA = "0x4B9020", Offset = "0x4B7A20", VA = "0x1804B9020")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004779")]
			[Address(RVA = "0x4B9030", Offset = "0x4B7A30", VA = "0x1804B9030")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000A15 RID: 2581
		// (get) Token: 0x0600477A RID: 18298 RVA: 0x00012CA8 File Offset: 0x00010EA8
		[Token(Token = "0x17000A15")]
		public bool IsSeated
		{
			[Token(Token = "0x600477A")]
			[Address(RVA = "0x8E87F0", Offset = "0x8E71F0", VA = "0x1808E87F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000A16 RID: 2582
		// (get) Token: 0x0600477B RID: 18299 RVA: 0x00012CC0 File Offset: 0x00010EC0
		// (set) Token: 0x0600477C RID: 18300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A16")]
		public float TimeSinceSitEnd
		{
			[Token(Token = "0x600477B")]
			[Address(RVA = "0x485C90", Offset = "0x484690", VA = "0x180485C90")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600477C")]
			[Address(RVA = "0x485CD0", Offset = "0x4846D0", VA = "0x180485CD0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000A17 RID: 2583
		// (get) Token: 0x0600477D RID: 18301 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600477E RID: 18302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A17")]
		public AvatarSeat CurrentSeat
		{
			[Token(Token = "0x600477D")]
			[Address(RVA = "0x4423C0", Offset = "0x440DC0", VA = "0x1804423C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600477E")]
			[Address(RVA = "0x4423F0", Offset = "0x440DF0", VA = "0x1804423F0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000A18 RID: 2584
		// (get) Token: 0x0600477F RID: 18303 RVA: 0x00012CD8 File Offset: 0x00010ED8
		// (set) Token: 0x06004780 RID: 18304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A18")]
		public bool StandUpAnimationPlaying
		{
			[Token(Token = "0x600477F")]
			[Address(RVA = "0x4BE260", Offset = "0x4BCC60", VA = "0x1804BE260")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004780")]
			[Address(RVA = "0x4F3A70", Offset = "0x4F2470", VA = "0x1804F3A70")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000A19 RID: 2585
		// (get) Token: 0x06004781 RID: 18305 RVA: 0x00012CF0 File Offset: 0x00010EF0
		// (set) Token: 0x06004782 RID: 18306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A19")]
		public bool IsAvatarCulled
		{
			[Token(Token = "0x6004781")]
			[Address(RVA = "0x4F28F0", Offset = "0x4F12F0", VA = "0x1804F28F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004782")]
			[Address(RVA = "0x530070", Offset = "0x52EA70", VA = "0x180530070")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06004783 RID: 18307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004783")]
		[Address(RVA = "0x8E5710", Offset = "0x8E4110", VA = "0x1808E5710", Slot = "4")]
		protected virtual void Awake()
		{
		}

		// Token: 0x06004784 RID: 18308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004784")]
		[Address(RVA = "0x8E7C10", Offset = "0x8E6610", VA = "0x1808E7C10", Slot = "5")]
		protected virtual void Start()
		{
		}

		// Token: 0x06004785 RID: 18309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004785")]
		[Address(RVA = "0x8E6230", Offset = "0x8E4C30", VA = "0x1808E6230")]
		private void OnDestroy()
		{
		}

		// Token: 0x06004786 RID: 18310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004786")]
		[Address(RVA = "0x8E6350", Offset = "0x8E4D50", VA = "0x1808E6350")]
		private void OnEnable()
		{
		}

		// Token: 0x06004787 RID: 18311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004787")]
		[Address(RVA = "0x8E8520", Offset = "0x8E6F20", VA = "0x1808E8520")]
		private void Update()
		{
		}

		// Token: 0x06004788 RID: 18312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004788")]
		[Address(RVA = "0x8E6100", Offset = "0x8E4B00", VA = "0x1808E6100")]
		private void InfrequentUpdate()
		{
		}

		// Token: 0x06004789 RID: 18313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004789")]
		[Address(RVA = "0x8E6160", Offset = "0x8E4B60", VA = "0x1808E6160")]
		private void MinPass()
		{
		}

		// Token: 0x0600478A RID: 18314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600478A")]
		[Address(RVA = "0x8E7FD0", Offset = "0x8E69D0", VA = "0x1808E7FD0")]
		private void UpdateAnimationActive()
		{
		}

		// Token: 0x0600478B RID: 18315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600478B")]
		[Address(RVA = "0x8E6C90", Offset = "0x8E5690", VA = "0x1808E6C90")]
		public void SetDirection(float dir)
		{
		}

		// Token: 0x0600478C RID: 18316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600478C")]
		[Address(RVA = "0x8E72A0", Offset = "0x8E5CA0", VA = "0x1808E72A0")]
		public void SetStrafe(float strafe)
		{
		}

		// Token: 0x0600478D RID: 18317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600478D")]
		[Address(RVA = "0x8E7300", Offset = "0x8E5D00", VA = "0x1808E7300")]
		public void SetTimeAirborne(float airbone)
		{
		}

		// Token: 0x0600478E RID: 18318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600478E")]
		[Address(RVA = "0x8E6C30", Offset = "0x8E5630", VA = "0x1808E6C30")]
		public void SetCrouched(bool crouched)
		{
		}

		// Token: 0x0600478F RID: 18319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600478F")]
		[Address(RVA = "0x8E6CF0", Offset = "0x8E56F0", VA = "0x1808E6CF0")]
		public void SetGrounded(bool grounded)
		{
		}

		// Token: 0x06004790 RID: 18320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004790")]
		[Address(RVA = "0x8E6110", Offset = "0x8E4B10", VA = "0x1808E6110")]
		public void Jump()
		{
		}

		// Token: 0x06004791 RID: 18321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004791")]
		[Address(RVA = "0x8E6AC0", Offset = "0x8E54C0", VA = "0x1808E6AC0")]
		public void SetAnimationEnabled(bool enabled)
		{
		}

		// Token: 0x06004792 RID: 18322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004792")]
		[Address(RVA = "0x8E5CA0", Offset = "0x8E46A0", VA = "0x1808E5CA0")]
		public void Flinch(Vector3 forceDirection, AvatarAnimation.EFlinchType flinchType)
		{
		}

		// Token: 0x06004793 RID: 18323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004793")]
		[Address(RVA = "0x8E6360", Offset = "0x8E4D60", VA = "0x1808E6360")]
		public void PlayStandUpAnimation()
		{
		}

		// Token: 0x06004794 RID: 18324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004794")]
		[Address(RVA = "0x8E68D0", Offset = "0x8E52D0", VA = "0x1808E68D0")]
		protected void RagdollChange(bool wasRagdolled, bool ragdoll, bool playStandUpAnim)
		{
		}

		// Token: 0x06004795 RID: 18325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004795")]
		[Address(RVA = "0x8E5210", Offset = "0x8E3C10", VA = "0x1808E5210")]
		private void AlignPositionToHips()
		{
		}

		// Token: 0x06004796 RID: 18326 RVA: 0x00012D08 File Offset: 0x00010F08
		[Token(Token = "0x6004796")]
		[Address(RVA = "0x8E7400", Offset = "0x8E5E00", VA = "0x1808E7400")]
		private bool ShouldGetUpFromBack()
		{
			return default(bool);
		}

		// Token: 0x06004797 RID: 18327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004797")]
		[Address(RVA = "0x8E67B0", Offset = "0x8E51B0", VA = "0x1808E67B0")]
		private void PopulateBoneTransforms(BoneTransform[] boneTransforms)
		{
		}

		// Token: 0x06004798 RID: 18328 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004798")]
		[Address(RVA = "0x8E5EC0", Offset = "0x8E48C0", VA = "0x1808E5EC0")]
		private List<Pose> GetBoneTransforms()
		{
			return null;
		}

		// Token: 0x06004799 RID: 18329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004799")]
		[Address(RVA = "0x8E6550", Offset = "0x8E4F50", VA = "0x1808E6550")]
		private void PopulateAnimationStartBoneTransforms(string clipName, BoneTransform[] boneTransforms)
		{
		}

		// Token: 0x0600479A RID: 18330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600479A")]
		[Address(RVA = "0x8E7360", Offset = "0x8E5D60", VA = "0x1808E7360")]
		public void SetTrigger(string trigger)
		{
		}

		// Token: 0x0600479B RID: 18331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600479B")]
		[Address(RVA = "0x8E6AA0", Offset = "0x8E54A0", VA = "0x1808E6AA0")]
		public void ResetTrigger(string trigger)
		{
		}

		// Token: 0x0600479C RID: 18332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600479C")]
		[Address(RVA = "0x8E6B90", Offset = "0x8E5590", VA = "0x1808E6B90")]
		public void SetBool(string id, bool value)
		{
		}

		// Token: 0x0600479D RID: 18333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600479D")]
		[Address(RVA = "0x8E6D50", Offset = "0x8E5750", VA = "0x1808E6D50")]
		public void SetSeat(AvatarSeat seat)
		{
		}

		// Token: 0x0600479E RID: 18334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600479E")]
		[Address(RVA = "0x8E7690", Offset = "0x8E6090", VA = "0x1808E7690")]
		public void SkateboardMounted(Skateboard board)
		{
		}

		// Token: 0x0600479F RID: 18335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600479F")]
		[Address(RVA = "0x8E74B0", Offset = "0x8E5EB0", VA = "0x1808E74B0")]
		public void SkateboardDismounted()
		{
		}

		// Token: 0x060047A0 RID: 18336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047A0")]
		[Address(RVA = "0x8E7BD0", Offset = "0x8E65D0", VA = "0x1808E7BD0")]
		private void SkateboardPush()
		{
		}

		// Token: 0x060047A1 RID: 18337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047A1")]
		[Address(RVA = "0x8E87D0", Offset = "0x8E71D0", VA = "0x1808E87D0")]
		public AvatarAnimation()
		{
		}

		// Token: 0x04003252 RID: 12882
		[Token(Token = "0x4003252")]
		public const bool GLOBAL_USE_IMPOSTOR = true;

		// Token: 0x04003253 RID: 12883
		[Token(Token = "0x4003253")]
		public const float AnimationRangeSqr = 2025f;

		// Token: 0x04003254 RID: 12884
		[Token(Token = "0x4003254")]
		public const float FrustrumCullMinDist = 225f;

		// Token: 0x04003255 RID: 12885
		[Token(Token = "0x4003255")]
		public const float RunningAnimationSpeed = 8f;

		// Token: 0x04003256 RID: 12886
		[Token(Token = "0x4003256")]
		public const float MaxBoneOffset = 0.01f;

		// Token: 0x04003257 RID: 12887
		[Token(Token = "0x4003257")]
		public const float MaxBoneOffsetSqr = 0.0001f;

		// Token: 0x04003258 RID: 12888
		[Token(Token = "0x4003258")]
		[FieldOffset(Offset = "0x0")]
		public static Vector3 SITTING_OFFSET;

		// Token: 0x04003259 RID: 12889
		[Token(Token = "0x4003259")]
		public const float SEAT_TIME = 0.5f;

		// Token: 0x0400325F RID: 12895
		[Token(Token = "0x400325F")]
		[FieldOffset(Offset = "0x32")]
		public bool DEBUG_MODE;

		// Token: 0x04003260 RID: 12896
		[Token(Token = "0x4003260")]
		[FieldOffset(Offset = "0x34")]
		private int framesActive;

		// Token: 0x04003261 RID: 12897
		[Token(Token = "0x4003261")]
		[FieldOffset(Offset = "0x38")]
		[Header("References")]
		public Animator animator;

		// Token: 0x04003262 RID: 12898
		[Token(Token = "0x4003262")]
		[FieldOffset(Offset = "0x40")]
		public Transform HipBone;

		// Token: 0x04003263 RID: 12899
		[Token(Token = "0x4003263")]
		[FieldOffset(Offset = "0x48")]
		public Transform[] Bones;

		// Token: 0x04003264 RID: 12900
		[Token(Token = "0x4003264")]
		[FieldOffset(Offset = "0x50")]
		protected Avatar avatar;

		// Token: 0x04003265 RID: 12901
		[Token(Token = "0x4003265")]
		[FieldOffset(Offset = "0x58")]
		public Transform LeftHandContainer;

		// Token: 0x04003266 RID: 12902
		[Token(Token = "0x4003266")]
		[FieldOffset(Offset = "0x60")]
		public Transform RightHandContainer;

		// Token: 0x04003267 RID: 12903
		[Token(Token = "0x4003267")]
		[FieldOffset(Offset = "0x68")]
		public Transform RightHandAlignmentPoint;

		// Token: 0x04003268 RID: 12904
		[Token(Token = "0x4003268")]
		[FieldOffset(Offset = "0x70")]
		public Transform LeftHandAlignmentPoint;

		// Token: 0x04003269 RID: 12905
		[Token(Token = "0x4003269")]
		[FieldOffset(Offset = "0x78")]
		public AvatarIKController IKController;

		// Token: 0x0400326A RID: 12906
		[Token(Token = "0x400326A")]
		[FieldOffset(Offset = "0x80")]
		[Header("Settings")]
		public LayerMask GroundingMask;

		// Token: 0x0400326B RID: 12907
		[Token(Token = "0x400326B")]
		[FieldOffset(Offset = "0x88")]
		public string StandUpFromBackClipName;

		// Token: 0x0400326C RID: 12908
		[Token(Token = "0x400326C")]
		[FieldOffset(Offset = "0x90")]
		public string StandUpFromFrontClipName;

		// Token: 0x0400326D RID: 12909
		[Token(Token = "0x400326D")]
		[FieldOffset(Offset = "0x98")]
		public bool UseImpostor;

		// Token: 0x0400326E RID: 12910
		[Token(Token = "0x400326E")]
		[FieldOffset(Offset = "0x99")]
		public bool AllowCulling;

		// Token: 0x0400326F RID: 12911
		[Token(Token = "0x400326F")]
		[FieldOffset(Offset = "0xA0")]
		public UnityEvent onStandupStart;

		// Token: 0x04003270 RID: 12912
		[Token(Token = "0x4003270")]
		[FieldOffset(Offset = "0xA8")]
		public UnityEvent onStandupDone;

		// Token: 0x04003271 RID: 12913
		[Token(Token = "0x4003271")]
		[FieldOffset(Offset = "0xB0")]
		public UnityEvent onHeavyFlinch;

		// Token: 0x04003272 RID: 12914
		[Token(Token = "0x4003272")]
		[FieldOffset(Offset = "0xB8")]
		private BoneTransform[] standingBoneTransforms;

		// Token: 0x04003273 RID: 12915
		[Token(Token = "0x4003273")]
		[FieldOffset(Offset = "0xC0")]
		private BoneTransform[] standUpFromBackBoneTransforms;

		// Token: 0x04003274 RID: 12916
		[Token(Token = "0x4003274")]
		[FieldOffset(Offset = "0xC8")]
		private BoneTransform[] standUpFromFrontBoneTransforms;

		// Token: 0x04003275 RID: 12917
		[Token(Token = "0x4003275")]
		[FieldOffset(Offset = "0xD0")]
		private BoneTransform[] ragdollBoneTransforms;

		// Token: 0x04003276 RID: 12918
		[Token(Token = "0x4003276")]
		[FieldOffset(Offset = "0xD8")]
		private Coroutine standUpRoutine;

		// Token: 0x04003277 RID: 12919
		[Token(Token = "0x4003277")]
		[FieldOffset(Offset = "0xE0")]
		private Coroutine seatRoutine;

		// Token: 0x04003278 RID: 12920
		[Token(Token = "0x4003278")]
		[FieldOffset(Offset = "0xE8")]
		private Skateboard activeSkateboard;

		// Token: 0x04003279 RID: 12921
		[Token(Token = "0x4003279")]
		[FieldOffset(Offset = "0xF0")]
		private bool animationEnabled;

		// Token: 0x0400327A RID: 12922
		[Token(Token = "0x400327A")]
		[FieldOffset(Offset = "0xF4")]
		private AnimatorCullingMode initialCullingMode;

		// Token: 0x02000A33 RID: 2611
		[Token(Token = "0x2000A33")]
		public enum EFlinchType
		{
			// Token: 0x0400327C RID: 12924
			[Token(Token = "0x400327C")]
			Light,
			// Token: 0x0400327D RID: 12925
			[Token(Token = "0x400327D")]
			Heavy
		}

		// Token: 0x02000A34 RID: 2612
		[Token(Token = "0x2000A34")]
		public enum EFlinchDirection
		{
			// Token: 0x0400327F RID: 12927
			[Token(Token = "0x400327F")]
			Forward,
			// Token: 0x04003280 RID: 12928
			[Token(Token = "0x4003280")]
			Backward,
			// Token: 0x04003281 RID: 12929
			[Token(Token = "0x4003281")]
			Left,
			// Token: 0x04003282 RID: 12930
			[Token(Token = "0x4003282")]
			Right
		}
	}
}
