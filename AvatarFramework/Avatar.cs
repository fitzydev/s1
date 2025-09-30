using System;
using System.Runtime.CompilerServices;
using EasyButtons;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.AvatarFramework.Animation;
using ScheduleOne.AvatarFramework.Emotions;
using ScheduleOne.AvatarFramework.Equipping;
using ScheduleOne.AvatarFramework.Impostors;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.AvatarFramework
{
	// Token: 0x02000A09 RID: 2569
	[Token(Token = "0x2000A09")]
	public class Avatar : MonoBehaviour
	{
		// Token: 0x170009C7 RID: 2503
		// (get) Token: 0x06004635 RID: 17973 RVA: 0x00012768 File Offset: 0x00010968
		// (set) Token: 0x06004636 RID: 17974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009C7")]
		public bool Ragdolled
		{
			[Token(Token = "0x6004635")]
			[Address(RVA = "0x516D30", Offset = "0x515730", VA = "0x180516D30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004636")]
			[Address(RVA = "0x516F20", Offset = "0x515920", VA = "0x180516F20")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170009C8 RID: 2504
		// (get) Token: 0x06004637 RID: 17975 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004638 RID: 17976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009C8")]
		public AvatarEquippable CurrentEquippable
		{
			[Token(Token = "0x6004637")]
			[Address(RVA = "0x548780", Offset = "0x547180", VA = "0x180548780")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004638")]
			[Address(RVA = "0x8B13C0", Offset = "0x8AFDC0", VA = "0x1808B13C0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170009C9 RID: 2505
		// (get) Token: 0x06004639 RID: 17977 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600463A RID: 17978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009C9")]
		public AvatarSettings CurrentSettings
		{
			[Token(Token = "0x6004639")]
			[Address(RVA = "0x63D950", Offset = "0x63C350", VA = "0x18063D950")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600463A")]
			[Address(RVA = "0x71CA90", Offset = "0x71B490", VA = "0x18071CA90")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x0600463B RID: 17979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600463B")]
		[Address(RVA = "0x8AFAC0", Offset = "0x8AE4C0", VA = "0x1808AFAC0")]
		[Button]
		public void Load()
		{
		}

		// Token: 0x0600463C RID: 17980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600463C")]
		[Address(RVA = "0x8AFAA0", Offset = "0x8AE4A0", VA = "0x1808AFAA0")]
		[Button]
		public void LoadNaked()
		{
		}

		// Token: 0x170009CA RID: 2506
		// (get) Token: 0x0600463D RID: 17981 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009CA")]
		public Transform CenterPointTransform
		{
			[Token(Token = "0x600463D")]
			[Address(RVA = "0x4DBC00", Offset = "0x4DA600", VA = "0x1804DBC00")]
			get
			{
				return null;
			}
		}

		// Token: 0x170009CB RID: 2507
		// (get) Token: 0x0600463E RID: 17982 RVA: 0x00012780 File Offset: 0x00010980
		[Token(Token = "0x170009CB")]
		public Vector3 CenterPoint
		{
			[Token(Token = "0x600463E")]
			[Address(RVA = "0x8B1370", Offset = "0x8AFD70", VA = "0x1808B1370")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x0600463F RID: 17983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600463F")]
		[Address(RVA = "0x8AE8C0", Offset = "0x8AD2C0", VA = "0x1808AE8C0", Slot = "4")]
		protected virtual void Awake()
		{
		}

		// Token: 0x06004640 RID: 17984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004640")]
		[Address(RVA = "0x8B11D0", Offset = "0x8AFBD0", VA = "0x1808B11D0", Slot = "5")]
		protected virtual void Update()
		{
		}

		// Token: 0x06004641 RID: 17985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004641")]
		[Address(RVA = "0x8AEE60", Offset = "0x8AD860", VA = "0x1808AEE60", Slot = "6")]
		protected virtual void LateUpdate()
		{
		}

		// Token: 0x06004642 RID: 17986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004642")]
		[Address(RVA = "0x8B10D0", Offset = "0x8AFAD0", VA = "0x1808B10D0")]
		public void SetVisible(bool vis)
		{
		}

		// Token: 0x06004643 RID: 17987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004643")]
		[Address(RVA = "0x8AEB50", Offset = "0x8AD550", VA = "0x1808AEB50")]
		public void GetMugshot(Action<Texture2D> callback)
		{
		}

		// Token: 0x06004644 RID: 17988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004644")]
		[Address(RVA = "0x8B02C0", Offset = "0x8AECC0", VA = "0x1808B02C0")]
		public void SetEmission(Color color)
		{
		}

		// Token: 0x06004645 RID: 17989 RVA: 0x00012798 File Offset: 0x00010998
		[Token(Token = "0x6004645")]
		[Address(RVA = "0x8AED30", Offset = "0x8AD730", VA = "0x1808AED30")]
		public bool IsMale()
		{
			return default(bool);
		}

		// Token: 0x06004646 RID: 17990 RVA: 0x000127B0 File Offset: 0x000109B0
		[Token(Token = "0x6004646")]
		[Address(RVA = "0x8AEDC0", Offset = "0x8AD7C0", VA = "0x1808AEDC0")]
		public bool IsWhite()
		{
			return default(bool);
		}

		// Token: 0x06004647 RID: 17991 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004647")]
		[Address(RVA = "0x8AEAB0", Offset = "0x8AD4B0", VA = "0x1808AEAB0")]
		public string GetFormalAddress(bool capitalized = true)
		{
			return null;
		}

		// Token: 0x06004648 RID: 17992 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004648")]
		[Address(RVA = "0x8AEBF0", Offset = "0x8AD5F0", VA = "0x1808AEBF0")]
		public string GetThirdPersonAddress(bool capitalized = true)
		{
			return null;
		}

		// Token: 0x06004649 RID: 17993 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004649")]
		[Address(RVA = "0x8AEC90", Offset = "0x8AD690", VA = "0x1808AEC90")]
		public string GetThirdPersonPronoun(bool capitalized = true)
		{
			return null;
		}

		// Token: 0x0600464A RID: 17994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600464A")]
		[Address(RVA = "0x8AE4E0", Offset = "0x8ACEE0", VA = "0x1808AE4E0")]
		private void ApplyShapeKeys(float gender, float weight, bool bodyOnly = false)
		{
		}

		// Token: 0x0600464B RID: 17995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600464B")]
		[Address(RVA = "0x8B0910", Offset = "0x8AF310", VA = "0x1808B0910")]
		private void SetFeetShrunk(bool shrink, float reduction)
		{
		}

		// Token: 0x0600464C RID: 17996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600464C")]
		[Address(RVA = "0x8B1130", Offset = "0x8AFB30", VA = "0x1808B1130")]
		private void SetWearingHairBlockingAccessory(bool blocked)
		{
		}

		// Token: 0x0600464D RID: 17997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600464D")]
		[Address(RVA = "0x8AF0B0", Offset = "0x8ADAB0", VA = "0x1808AF0B0")]
		public void LoadAvatarSettings(AvatarSettings settings)
		{
		}

		// Token: 0x0600464E RID: 17998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600464E")]
		[Address(RVA = "0x8AF530", Offset = "0x8ADF30", VA = "0x1808AF530")]
		public void LoadNakedSettings(AvatarSettings settings, int maxLayerOrder = 19)
		{
		}

		// Token: 0x0600464F RID: 17999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600464F")]
		[Address(RVA = "0x8ADA00", Offset = "0x8AC400", VA = "0x1808ADA00")]
		public void ApplyBodySettings(AvatarSettings settings)
		{
		}

		// Token: 0x06004650 RID: 18000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004650")]
		[Address(RVA = "0x8AFEB0", Offset = "0x8AE8B0", VA = "0x1808AFEB0")]
		public void SetAdditionalWeight(float weight)
		{
		}

		// Token: 0x06004651 RID: 18001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004651")]
		[Address(RVA = "0x659870", Offset = "0x658270", VA = "0x180659870")]
		public void SetAdditionalGender(float gender)
		{
		}

		// Token: 0x06004652 RID: 18002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004652")]
		[Address(RVA = "0x8B0DD0", Offset = "0x8AF7D0", VA = "0x1808B0DD0")]
		public void SetSkinColor(Color color)
		{
		}

		// Token: 0x06004653 RID: 18003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004653")]
		[Address(RVA = "0x8AE2F0", Offset = "0x8ACCF0", VA = "0x1808AE2F0")]
		public void ApplyHairSettings(AvatarSettings settings)
		{
		}

		// Token: 0x06004654 RID: 18004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004654")]
		[Address(RVA = "0x8B0A20", Offset = "0x8AF420", VA = "0x1808B0A20")]
		public void SetHairVisible(bool visible)
		{
		}

		// Token: 0x06004655 RID: 18005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004655")]
		[Address(RVA = "0x8AE1F0", Offset = "0x8ACBF0", VA = "0x1808AE1F0")]
		public void ApplyHairColorSettings(AvatarSettings settings)
		{
		}

		// Token: 0x06004656 RID: 18006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004656")]
		[Address(RVA = "0x8AFAD0", Offset = "0x8AE4D0", VA = "0x1808AFAD0")]
		public void OverrideHairColor(Color color)
		{
		}

		// Token: 0x06004657 RID: 18007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004657")]
		[Address(RVA = "0x8AFD20", Offset = "0x8AE720", VA = "0x1808AFD20")]
		public void ResetHairColor()
		{
		}

		// Token: 0x06004658 RID: 18008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004658")]
		[Address(RVA = "0x8ADAD0", Offset = "0x8AC4D0", VA = "0x1808ADAD0")]
		public void ApplyEyeBallSettings(AvatarSettings settings)
		{
		}

		// Token: 0x06004659 RID: 18009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004659")]
		[Address(RVA = "0x8ADBC0", Offset = "0x8AC5C0", VA = "0x1808ADBC0")]
		public void ApplyEyeLidSettings(AvatarSettings settings)
		{
		}

		// Token: 0x0600465A RID: 18010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600465A")]
		[Address(RVA = "0x8ADB40", Offset = "0x8AC540", VA = "0x1808ADB40")]
		public void ApplyEyeLidColorSettings(AvatarSettings settings)
		{
		}

		// Token: 0x0600465B RID: 18011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600465B")]
		[Address(RVA = "0x8ADC40", Offset = "0x8AC640", VA = "0x1808ADC40")]
		public void ApplyEyebrowSettings(AvatarSettings settings)
		{
		}

		// Token: 0x0600465C RID: 18012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600465C")]
		[Address(RVA = "0x8AFEC0", Offset = "0x8AE8C0", VA = "0x1808AFEC0")]
		public void SetBlockEyeFaceLayers(bool block)
		{
		}

		// Token: 0x0600465D RID: 18013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600465D")]
		[Address(RVA = "0x8ADC60", Offset = "0x8AC660", VA = "0x1808ADC60")]
		public void ApplyFaceLayerSettings(AvatarSettings settings)
		{
		}

		// Token: 0x0600465E RID: 18014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600465E")]
		[Address(RVA = "0x8B05F0", Offset = "0x8AEFF0", VA = "0x1808B05F0")]
		private void SetFaceLayer(int index, string assetPath, Color color)
		{
		}

		// Token: 0x0600465F RID: 18015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600465F")]
		[Address(RVA = "0x8B07E0", Offset = "0x8AF1E0", VA = "0x1808B07E0")]
		public void SetFaceTexture(Texture2D tex, Color color)
		{
		}

		// Token: 0x06004660 RID: 18016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004660")]
		[Address(RVA = "0x8AD410", Offset = "0x8ABE10", VA = "0x1808AD410")]
		public void ApplyBodyLayerSettings(AvatarSettings settings, int maxOrder = -1)
		{
		}

		// Token: 0x06004661 RID: 18017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004661")]
		[Address(RVA = "0x8AFF40", Offset = "0x8AE940", VA = "0x1808AFF40")]
		private void SetBodyLayer(int index, string assetPath, Color color)
		{
		}

		// Token: 0x06004662 RID: 18018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004662")]
		[Address(RVA = "0x8ACB20", Offset = "0x8AB520", VA = "0x1808ACB20")]
		public void ApplyAccessorySettings(AvatarSettings settings)
		{
		}

		// Token: 0x06004663 RID: 18019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004663")]
		[Address(RVA = "0x8AE990", Offset = "0x8AD390", VA = "0x1808AE990")]
		private void DestroyAccessories()
		{
		}

		// Token: 0x06004664 RID: 18020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004664")]
		[Address(RVA = "0x8B0AC0", Offset = "0x8AF4C0", VA = "0x1808B0AC0", Slot = "7")]
		public virtual void SetRagdollPhysicsEnabled(bool ragdollEnabled, bool playStandUpAnim = true)
		{
		}

		// Token: 0x06004665 RID: 18021 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004665")]
		[Address(RVA = "0x8B03D0", Offset = "0x8AEDD0", VA = "0x1808B03D0", Slot = "8")]
		public virtual AvatarEquippable SetEquippable(string assetPath)
		{
			return null;
		}

		// Token: 0x06004666 RID: 18022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004666")]
		[Address(RVA = "0x8AFC30", Offset = "0x8AE630", VA = "0x1808AFC30", Slot = "9")]
		public virtual void ReceiveEquippableMessage(string message, object data)
		{
		}

		// Token: 0x06004667 RID: 18023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004667")]
		[Address(RVA = "0x8B12D0", Offset = "0x8AFCD0", VA = "0x1808B12D0")]
		public Avatar()
		{
		}

		// Token: 0x04003121 RID: 12577
		[Token(Token = "0x4003121")]
		public const int MAX_ACCESSORIES = 9;

		// Token: 0x04003122 RID: 12578
		[Token(Token = "0x4003122")]
		public const bool USE_COMBINED_LAYERS = true;

		// Token: 0x04003123 RID: 12579
		[Token(Token = "0x4003123")]
		public const float DEFAULT_SMOOTHNESS = 0.25f;

		// Token: 0x04003124 RID: 12580
		[Token(Token = "0x4003124")]
		[FieldOffset(Offset = "0x0")]
		private static float maleShoulderScale;

		// Token: 0x04003125 RID: 12581
		[Token(Token = "0x4003125")]
		[FieldOffset(Offset = "0x4")]
		private static float femaleShoulderScale;

		// Token: 0x04003126 RID: 12582
		[Token(Token = "0x4003126")]
		[FieldOffset(Offset = "0x20")]
		public bool DEBUG;

		// Token: 0x04003127 RID: 12583
		[Token(Token = "0x4003127")]
		[FieldOffset(Offset = "0x28")]
		[Header("References")]
		public AvatarAnimation Animation;

		// Token: 0x04003128 RID: 12584
		[Token(Token = "0x4003128")]
		[FieldOffset(Offset = "0x30")]
		public AvatarLookController LookController;

		// Token: 0x04003129 RID: 12585
		[Token(Token = "0x4003129")]
		[FieldOffset(Offset = "0x38")]
		public SkinnedMeshRenderer[] BodyMeshes;

		// Token: 0x0400312A RID: 12586
		[Token(Token = "0x400312A")]
		[FieldOffset(Offset = "0x40")]
		public SkinnedMeshRenderer[] ShapeKeyMeshes;

		// Token: 0x0400312B RID: 12587
		[Token(Token = "0x400312B")]
		[FieldOffset(Offset = "0x48")]
		public SkinnedMeshRenderer FaceMesh;

		// Token: 0x0400312C RID: 12588
		[Token(Token = "0x400312C")]
		[FieldOffset(Offset = "0x50")]
		public EyeController Eyes;

		// Token: 0x0400312D RID: 12589
		[Token(Token = "0x400312D")]
		[FieldOffset(Offset = "0x58")]
		public EyebrowController EyeBrows;

		// Token: 0x0400312E RID: 12590
		[Token(Token = "0x400312E")]
		[FieldOffset(Offset = "0x60")]
		public Transform BodyContainer;

		// Token: 0x0400312F RID: 12591
		[Token(Token = "0x400312F")]
		[FieldOffset(Offset = "0x68")]
		public Transform Armature;

		// Token: 0x04003130 RID: 12592
		[Token(Token = "0x4003130")]
		[FieldOffset(Offset = "0x70")]
		public Transform LeftShoulder;

		// Token: 0x04003131 RID: 12593
		[Token(Token = "0x4003131")]
		[FieldOffset(Offset = "0x78")]
		public Transform RightShoulder;

		// Token: 0x04003132 RID: 12594
		[Token(Token = "0x4003132")]
		[FieldOffset(Offset = "0x80")]
		public Transform HeadBone;

		// Token: 0x04003133 RID: 12595
		[Token(Token = "0x4003133")]
		[FieldOffset(Offset = "0x88")]
		public Transform HipBone;

		// Token: 0x04003134 RID: 12596
		[Token(Token = "0x4003134")]
		[FieldOffset(Offset = "0x90")]
		public Rigidbody[] RagdollRBs;

		// Token: 0x04003135 RID: 12597
		[Token(Token = "0x4003135")]
		[FieldOffset(Offset = "0x98")]
		public Collider[] RagdollColliders;

		// Token: 0x04003136 RID: 12598
		[Token(Token = "0x4003136")]
		[FieldOffset(Offset = "0xA0")]
		public Rigidbody MiddleSpineRB;

		// Token: 0x04003137 RID: 12599
		[Token(Token = "0x4003137")]
		[FieldOffset(Offset = "0xA8")]
		public AvatarEmotionManager EmotionManager;

		// Token: 0x04003138 RID: 12600
		[Token(Token = "0x4003138")]
		[FieldOffset(Offset = "0xB0")]
		public AvatarEffects Effects;

		// Token: 0x04003139 RID: 12601
		[Token(Token = "0x4003139")]
		[FieldOffset(Offset = "0xB8")]
		public Transform MiddleSpine;

		// Token: 0x0400313A RID: 12602
		[Token(Token = "0x400313A")]
		[FieldOffset(Offset = "0xC0")]
		public Transform LowerSpine;

		// Token: 0x0400313B RID: 12603
		[Token(Token = "0x400313B")]
		[FieldOffset(Offset = "0xC8")]
		public Transform LowestSpine;

		// Token: 0x0400313C RID: 12604
		[Token(Token = "0x400313C")]
		[FieldOffset(Offset = "0xD0")]
		public AvatarImpostor Impostor;

		// Token: 0x0400313D RID: 12605
		[Token(Token = "0x400313D")]
		[FieldOffset(Offset = "0xD8")]
		public FootstepSounds FootstepSounds;

		// Token: 0x0400313E RID: 12606
		[Token(Token = "0x400313E")]
		[FieldOffset(Offset = "0xE0")]
		public ParticleSystem BloodParticles;

		// Token: 0x0400313F RID: 12607
		[Token(Token = "0x400313F")]
		[FieldOffset(Offset = "0xE8")]
		[Header("Settings")]
		public AvatarSettings InitialAvatarSettings;

		// Token: 0x04003140 RID: 12608
		[Token(Token = "0x4003140")]
		[FieldOffset(Offset = "0xF0")]
		public Material DefaultAvatarMaterial;

		// Token: 0x04003141 RID: 12609
		[Token(Token = "0x4003141")]
		[FieldOffset(Offset = "0xF8")]
		public bool UseImpostor;

		// Token: 0x04003142 RID: 12610
		[Token(Token = "0x4003142")]
		[FieldOffset(Offset = "0x100")]
		public UnityEvent<bool, bool, bool> onRagdollChange;

		// Token: 0x04003145 RID: 12613
		[Token(Token = "0x4003145")]
		[FieldOffset(Offset = "0x118")]
		[Header("Data - readonly")]
		[SerializeField]
		protected float appliedGender;

		// Token: 0x04003146 RID: 12614
		[Token(Token = "0x4003146")]
		[FieldOffset(Offset = "0x11C")]
		[SerializeField]
		protected float appliedWeight;

		// Token: 0x04003147 RID: 12615
		[Token(Token = "0x4003147")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		protected Hair appliedHair;

		// Token: 0x04003148 RID: 12616
		[Token(Token = "0x4003148")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		protected Color appliedHairColor;

		// Token: 0x04003149 RID: 12617
		[Token(Token = "0x4003149")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		protected Accessory[] appliedAccessories;

		// Token: 0x0400314A RID: 12618
		[Token(Token = "0x400314A")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		protected bool wearingHairBlockingAccessory;

		// Token: 0x0400314B RID: 12619
		[Token(Token = "0x400314B")]
		[FieldOffset(Offset = "0x144")]
		private float additionalWeight;

		// Token: 0x0400314C RID: 12620
		[Token(Token = "0x400314C")]
		[FieldOffset(Offset = "0x148")]
		private float additionalGender;

		// Token: 0x0400314E RID: 12622
		[Token(Token = "0x400314E")]
		[FieldOffset(Offset = "0x158")]
		[Header("Runtime loading")]
		public AvatarSettings SettingsToLoad;

		// Token: 0x0400314F RID: 12623
		[Token(Token = "0x400314F")]
		[FieldOffset(Offset = "0x160")]
		public UnityEvent onSettingsLoaded;

		// Token: 0x04003150 RID: 12624
		[Token(Token = "0x4003150")]
		[FieldOffset(Offset = "0x168")]
		private Vector3 originalHipPos;

		// Token: 0x04003151 RID: 12625
		[Token(Token = "0x4003151")]
		[FieldOffset(Offset = "0x174")]
		private bool usingCombinedLayer;

		// Token: 0x04003152 RID: 12626
		[Token(Token = "0x4003152")]
		[FieldOffset(Offset = "0x175")]
		private bool blockEyeFaceLayers;
	}
}
