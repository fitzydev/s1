using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Skating
{
	// Token: 0x020002DA RID: 730
	[Token(Token = "0x20002DA")]
	public class SkateboardAnimation : MonoBehaviour
	{
		// Token: 0x1700034B RID: 843
		// (get) Token: 0x06000FCC RID: 4044 RVA: 0x00007920 File Offset: 0x00005B20
		[Token(Token = "0x1700034B")]
		public float CurrentCrouchShift
		{
			[Token(Token = "0x6000FCC")]
			[Address(RVA = "0xAE42B0", Offset = "0xAE2CB0", VA = "0x180AE42B0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06000FCD RID: 4045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FCD")]
		[Address(RVA = "0xAE28F0", Offset = "0xAE12F0", VA = "0x180AE28F0")]
		private void Awake()
		{
		}

		// Token: 0x06000FCE RID: 4046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FCE")]
		[Address(RVA = "0xAE41D0", Offset = "0xAE2BD0", VA = "0x180AE41D0")]
		private void Update()
		{
		}

		// Token: 0x06000FCF RID: 4047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FCF")]
		[Address(RVA = "0xAE30A0", Offset = "0xAE1AA0", VA = "0x180AE30A0")]
		private void LateUpdate()
		{
		}

		// Token: 0x06000FD0 RID: 4048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FD0")]
		[Address(RVA = "0x42DA80", Offset = "0x42C480", VA = "0x18042DA80")]
		private void FixedUpdate()
		{
		}

		// Token: 0x06000FD1 RID: 4049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FD1")]
		[Address(RVA = "0xAE3B00", Offset = "0xAE2500", VA = "0x180AE3B00")]
		private void UpdateIKBlend()
		{
		}

		// Token: 0x06000FD2 RID: 4050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FD2")]
		[Address(RVA = "0xAE36F0", Offset = "0xAE20F0", VA = "0x180AE36F0")]
		private void UpdateBodyAlignment()
		{
		}

		// Token: 0x06000FD3 RID: 4051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FD3")]
		[Address(RVA = "0xAE3180", Offset = "0xAE1B80", VA = "0x180AE3180")]
		private void UpdateArmLift()
		{
		}

		// Token: 0x06000FD4 RID: 4052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FD4")]
		[Address(RVA = "0xAE3EC0", Offset = "0xAE28C0", VA = "0x180AE3EC0")]
		private void UpdatePelvisRotation()
		{
		}

		// Token: 0x06000FD5 RID: 4053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FD5")]
		[Address(RVA = "0xAE3170", Offset = "0xAE1B70", VA = "0x180AE3170")]
		public void SetArmLift(float lift)
		{
		}

		// Token: 0x06000FD6 RID: 4054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FD6")]
		[Address(RVA = "0xAE30D0", Offset = "0xAE1AD0", VA = "0x180AE30D0")]
		private void OnPushStart()
		{
		}

		// Token: 0x06000FD7 RID: 4055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FD7")]
		[Address(RVA = "0xAE41E0", Offset = "0xAE2BE0", VA = "0x180AE41E0")]
		public SkateboardAnimation()
		{
		}

		// Token: 0x04000FEB RID: 4075
		[Token(Token = "0x4000FEB")]
		[FieldOffset(Offset = "0x20")]
		[Header("Settings")]
		public float JumpCrouchAmount;

		// Token: 0x04000FEC RID: 4076
		[Token(Token = "0x4000FEC")]
		[FieldOffset(Offset = "0x24")]
		public float CrouchSpeed;

		// Token: 0x04000FED RID: 4077
		[Token(Token = "0x4000FED")]
		[FieldOffset(Offset = "0x28")]
		public float ArmLiftRate;

		// Token: 0x04000FEE RID: 4078
		[Token(Token = "0x4000FEE")]
		[FieldOffset(Offset = "0x2C")]
		public float PelvisMaxRotation;

		// Token: 0x04000FEF RID: 4079
		[Token(Token = "0x4000FEF")]
		[FieldOffset(Offset = "0x30")]
		public float HandsMaxRotation;

		// Token: 0x04000FF0 RID: 4080
		[Token(Token = "0x4000FF0")]
		[FieldOffset(Offset = "0x34")]
		public float PelvisOffsetBlend;

		// Token: 0x04000FF1 RID: 4081
		[Token(Token = "0x4000FF1")]
		[FieldOffset(Offset = "0x38")]
		public float VerticalMomentumMultiplier;

		// Token: 0x04000FF2 RID: 4082
		[Token(Token = "0x4000FF2")]
		[FieldOffset(Offset = "0x3C")]
		public float VerticalMomentumOffsetClamp;

		// Token: 0x04000FF3 RID: 4083
		[Token(Token = "0x4000FF3")]
		[FieldOffset(Offset = "0x40")]
		public float MomentumMoveSpeed;

		// Token: 0x04000FF4 RID: 4084
		[Token(Token = "0x4000FF4")]
		[FieldOffset(Offset = "0x44")]
		public float IKBlendChangeRate;

		// Token: 0x04000FF5 RID: 4085
		[Token(Token = "0x4000FF5")]
		[FieldOffset(Offset = "0x48")]
		public float PushAnimationDuration;

		// Token: 0x04000FF6 RID: 4086
		[Token(Token = "0x4000FF6")]
		[FieldOffset(Offset = "0x4C")]
		public float PushAnimationSpeed;

		// Token: 0x04000FF7 RID: 4087
		[Token(Token = "0x4000FF7")]
		[FieldOffset(Offset = "0x50")]
		public AnimationClip PushAnim;

		// Token: 0x04000FF8 RID: 4088
		[Token(Token = "0x4000FF8")]
		[FieldOffset(Offset = "0x58")]
		[Header("References")]
		public SkateboardAnimation.AlignmentSet PelvisContainerAlignment;

		// Token: 0x04000FF9 RID: 4089
		[Token(Token = "0x4000FF9")]
		[FieldOffset(Offset = "0x60")]
		public SkateboardAnimation.AlignmentSet PelvisAlignment;

		// Token: 0x04000FFA RID: 4090
		[Token(Token = "0x4000FFA")]
		[FieldOffset(Offset = "0x68")]
		public SkateboardAnimation.AlignmentSet SpineContainerAlignment;

		// Token: 0x04000FFB RID: 4091
		[Token(Token = "0x4000FFB")]
		[FieldOffset(Offset = "0x70")]
		public SkateboardAnimation.AlignmentSet SpineAlignment;

		// Token: 0x04000FFC RID: 4092
		[Token(Token = "0x4000FFC")]
		[FieldOffset(Offset = "0x78")]
		public Transform SpineAlignment_Hunched;

		// Token: 0x04000FFD RID: 4093
		[Token(Token = "0x4000FFD")]
		[FieldOffset(Offset = "0x80")]
		public SkateboardAnimation.AlignmentSet LeftFootAlignment;

		// Token: 0x04000FFE RID: 4094
		[Token(Token = "0x4000FFE")]
		[FieldOffset(Offset = "0x88")]
		public SkateboardAnimation.AlignmentSet RightFootAlignment;

		// Token: 0x04000FFF RID: 4095
		[Token(Token = "0x4000FFF")]
		[FieldOffset(Offset = "0x90")]
		public SkateboardAnimation.AlignmentSet LeftLegBendTarget;

		// Token: 0x04001000 RID: 4096
		[Token(Token = "0x4001000")]
		[FieldOffset(Offset = "0x98")]
		public SkateboardAnimation.AlignmentSet RightLegBendTarget;

		// Token: 0x04001001 RID: 4097
		[Token(Token = "0x4001001")]
		[FieldOffset(Offset = "0xA0")]
		public SkateboardAnimation.AlignmentSet LeftHandAlignment;

		// Token: 0x04001002 RID: 4098
		[Token(Token = "0x4001002")]
		[FieldOffset(Offset = "0xA8")]
		public SkateboardAnimation.AlignmentSet RightHandAlignment;

		// Token: 0x04001003 RID: 4099
		[Token(Token = "0x4001003")]
		[FieldOffset(Offset = "0xB0")]
		public Transform AvatarFaceTarget;

		// Token: 0x04001004 RID: 4100
		[Token(Token = "0x4001004")]
		[FieldOffset(Offset = "0xB8")]
		public Transform HandContainer;

		// Token: 0x04001005 RID: 4101
		[Token(Token = "0x4001005")]
		[FieldOffset(Offset = "0xC0")]
		public Animation IKAnimation;

		// Token: 0x04001006 RID: 4102
		[Token(Token = "0x4001006")]
		[FieldOffset(Offset = "0xC8")]
		[Header("Arm Lift")]
		public SkateboardAnimation.AlignmentSet LeftHandLoweredAlignment;

		// Token: 0x04001007 RID: 4103
		[Token(Token = "0x4001007")]
		[FieldOffset(Offset = "0xD0")]
		public SkateboardAnimation.AlignmentSet LeftHandRaisedAlignment;

		// Token: 0x04001008 RID: 4104
		[Token(Token = "0x4001008")]
		[FieldOffset(Offset = "0xD8")]
		public SkateboardAnimation.AlignmentSet RightHandLoweredAlignment;

		// Token: 0x04001009 RID: 4105
		[Token(Token = "0x4001009")]
		[FieldOffset(Offset = "0xE0")]
		public SkateboardAnimation.AlignmentSet RightHandRaisedAlignment;

		// Token: 0x0400100A RID: 4106
		[Token(Token = "0x400100A")]
		[FieldOffset(Offset = "0xE8")]
		private Skateboard board;

		// Token: 0x0400100B RID: 4107
		[Token(Token = "0x400100B")]
		[FieldOffset(Offset = "0xF0")]
		private float currentCrouchShift;

		// Token: 0x0400100C RID: 4108
		[Token(Token = "0x400100C")]
		[FieldOffset(Offset = "0xF4")]
		private float targetArmLift;

		// Token: 0x0400100D RID: 4109
		[Token(Token = "0x400100D")]
		[FieldOffset(Offset = "0xF8")]
		private float currentArmLift;

		// Token: 0x0400100E RID: 4110
		[Token(Token = "0x400100E")]
		[FieldOffset(Offset = "0xFC")]
		private Quaternion pelvisDefaultRotation;

		// Token: 0x0400100F RID: 4111
		[Token(Token = "0x400100F")]
		[FieldOffset(Offset = "0x10C")]
		private Vector3 pelvisDefaultPosition;

		// Token: 0x04001010 RID: 4112
		[Token(Token = "0x4001010")]
		[FieldOffset(Offset = "0x118")]
		private Vector3 spineDefaultPosition;

		// Token: 0x04001011 RID: 4113
		[Token(Token = "0x4001011")]
		[FieldOffset(Offset = "0x124")]
		private float currentMomentumOffset;

		// Token: 0x04001012 RID: 4114
		[Token(Token = "0x4001012")]
		[FieldOffset(Offset = "0x128")]
		private float ikBlend;

		// Token: 0x04001013 RID: 4115
		[Token(Token = "0x4001013")]
		[FieldOffset(Offset = "0x130")]
		private List<SkateboardAnimation.AlignmentSet> alignmentSets;

		// Token: 0x020002DB RID: 731
		[Token(Token = "0x20002DB")]
		[Serializable]
		public class AlignmentSet
		{
			// Token: 0x06000FD8 RID: 4056 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000FD8")]
			[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
			public AlignmentSet()
			{
			}

			// Token: 0x04001014 RID: 4116
			[Token(Token = "0x4001014")]
			[FieldOffset(Offset = "0x10")]
			public Transform Transform;

			// Token: 0x04001015 RID: 4117
			[Token(Token = "0x4001015")]
			[FieldOffset(Offset = "0x18")]
			public Transform Default;

			// Token: 0x04001016 RID: 4118
			[Token(Token = "0x4001016")]
			[FieldOffset(Offset = "0x20")]
			public Transform Animated;
		}
	}
}
