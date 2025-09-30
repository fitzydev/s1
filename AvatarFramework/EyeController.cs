using System;
using System.Collections;
using System.Runtime.CompilerServices;
using EasyButtons;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.AvatarFramework
{
	// Token: 0x02000A1D RID: 2589
	[Token(Token = "0x2000A1D")]
	[ExecuteInEditMode]
	public class EyeController : MonoBehaviour
	{
		// Token: 0x17000A03 RID: 2563
		// (get) Token: 0x06004702 RID: 18178 RVA: 0x00012AC8 File Offset: 0x00010CC8
		// (set) Token: 0x06004703 RID: 18179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A03")]
		public bool EyesOpen
		{
			[Token(Token = "0x6004702")]
			[Address(RVA = "0x570DF0", Offset = "0x56F7F0", VA = "0x180570DF0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004703")]
			[Address(RVA = "0x570E40", Offset = "0x56F840", VA = "0x180570E40")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06004704 RID: 18180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004704")]
		[Address(RVA = "0x8F51B0", Offset = "0x8F3BB0", VA = "0x1808F51B0", Slot = "4")]
		protected virtual void Awake()
		{
		}

		// Token: 0x06004705 RID: 18181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004705")]
		[Address(RVA = "0x8F5C10", Offset = "0x8F4610", VA = "0x1808F5C10")]
		protected void Update()
		{
		}

		// Token: 0x06004706 RID: 18182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004706")]
		[Address(RVA = "0x8F4D90", Offset = "0x8F3790", VA = "0x1808F4D90")]
		private void OnEnable()
		{
		}

		// Token: 0x06004707 RID: 18183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004707")]
		[Address(RVA = "0x8F4DF0", Offset = "0x8F37F0", VA = "0x1808F4DF0")]
		[Button]
		public void ApplySettings()
		{
		}

		// Token: 0x06004708 RID: 18184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004708")]
		[Address(RVA = "0x8F5930", Offset = "0x8F4330", VA = "0x1808F5930")]
		public void SetEyeballTint(Color col)
		{
		}

		// Token: 0x06004709 RID: 18185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004709")]
		[Address(RVA = "0x8F5620", Offset = "0x8F4020", VA = "0x1808F5620")]
		public void OverrideEyeballTint(Color col)
		{
		}

		// Token: 0x0600470A RID: 18186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600470A")]
		[Address(RVA = "0x8F5810", Offset = "0x8F4210", VA = "0x1808F5810")]
		public void ResetEyeballTint()
		{
		}

		// Token: 0x0600470B RID: 18187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600470B")]
		[Address(RVA = "0x8F55F0", Offset = "0x8F3FF0", VA = "0x1808F55F0")]
		public void OverrideEyeLids(Eye.EyeLidConfiguration eyeLidConfiguration)
		{
		}

		// Token: 0x0600470C RID: 18188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600470C")]
		[Address(RVA = "0x8F57F0", Offset = "0x8F41F0", VA = "0x1808F57F0")]
		public void ResetEyeLids()
		{
		}

		// Token: 0x0600470D RID: 18189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600470D")]
		[Address(RVA = "0x8F56B0", Offset = "0x8F40B0", VA = "0x1808F56B0")]
		private void RagdollChange(bool oldValue, bool newValue, bool playStandUpAnim)
		{
		}

		// Token: 0x0600470E RID: 18190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600470E")]
		[Address(RVA = "0x8F59B0", Offset = "0x8F43B0", VA = "0x1808F59B0")]
		public void SetEyesOpen(bool open)
		{
		}

		// Token: 0x0600470F RID: 18191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600470F")]
		[Address(RVA = "0x8F4D20", Offset = "0x8F3720", VA = "0x1808F4D20")]
		private void ApplyDilation()
		{
		}

		// Token: 0x06004710 RID: 18192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004710")]
		[Address(RVA = "0x8F5B40", Offset = "0x8F4540", VA = "0x1808F5B40")]
		public void SetPupilDilation(float dilation, bool writeDefault = true)
		{
		}

		// Token: 0x06004711 RID: 18193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004711")]
		[Address(RVA = "0x8F58A0", Offset = "0x8F42A0", VA = "0x1808F58A0")]
		public void ResetPupilDilation()
		{
		}

		// Token: 0x06004712 RID: 18194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004712")]
		[Address(RVA = "0x8F4D90", Offset = "0x8F3790", VA = "0x1808F4D90")]
		private void ApplyRestingEyeLidState()
		{
		}

		// Token: 0x06004713 RID: 18195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004713")]
		[Address(RVA = "0x8F5490", Offset = "0x8F3E90", VA = "0x1808F5490")]
		public void ForceBlink()
		{
		}

		// Token: 0x06004714 RID: 18196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004714")]
		[Address(RVA = "0x8F5B00", Offset = "0x8F4500", VA = "0x1808F5B00")]
		public void SetLeftEyeRestingLidState(Eye.EyeLidConfiguration config)
		{
		}

		// Token: 0x06004715 RID: 18197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004715")]
		[Address(RVA = "0x8F5BC0", Offset = "0x8F45C0", VA = "0x1808F5BC0")]
		public void SetRightEyeRestingLidState(Eye.EyeLidConfiguration config)
		{
		}

		// Token: 0x06004716 RID: 18198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004716")]
		[Address(RVA = "0x8F5420", Offset = "0x8F3E20", VA = "0x1808F5420")]
		private IEnumerator BlinkRoutine()
		{
			return null;
		}

		// Token: 0x06004717 RID: 18199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004717")]
		[Address(RVA = "0x8F5790", Offset = "0x8F4190", VA = "0x1808F5790")]
		private void ResetBlinkCounter()
		{
		}

		// Token: 0x06004718 RID: 18200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004718")]
		[Address(RVA = "0x8F5560", Offset = "0x8F3F60", VA = "0x1808F5560")]
		public void LookAt(Vector3 position, bool instant = false)
		{
		}

		// Token: 0x06004719 RID: 18201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004719")]
		[Address(RVA = "0x8F5DA0", Offset = "0x8F47A0", VA = "0x1808F5DA0")]
		public EyeController()
		{
		}

		// Token: 0x040031DF RID: 12767
		[Token(Token = "0x40031DF")]
		[FieldOffset(Offset = "0x0")]
		private static float eyeHeightMultiplier;

		// Token: 0x040031E0 RID: 12768
		[Token(Token = "0x40031E0")]
		[FieldOffset(Offset = "0x20")]
		public bool DEBUG;

		// Token: 0x040031E2 RID: 12770
		[Token(Token = "0x40031E2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Header("References")]
		public Eye leftEye;

		// Token: 0x040031E3 RID: 12771
		[Token(Token = "0x40031E3")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		public Eye rightEye;

		// Token: 0x040031E4 RID: 12772
		[Token(Token = "0x40031E4")]
		[FieldOffset(Offset = "0x38")]
		[Header("Location Settings")]
		[SerializeField]
		[Range(0f, 45f)]
		protected float eyeSpacing;

		// Token: 0x040031E5 RID: 12773
		[Token(Token = "0x40031E5")]
		[FieldOffset(Offset = "0x3C")]
		[Range(-1f, 1f)]
		[SerializeField]
		protected float eyeHeight;

		// Token: 0x040031E6 RID: 12774
		[Token(Token = "0x40031E6")]
		[FieldOffset(Offset = "0x40")]
		[Range(0.5f, 1.5f)]
		[SerializeField]
		protected float eyeSize;

		// Token: 0x040031E7 RID: 12775
		[Token(Token = "0x40031E7")]
		[FieldOffset(Offset = "0x44")]
		[Header("Eyelid Settings")]
		[SerializeField]
		protected Color leftEyeLidColor;

		// Token: 0x040031E8 RID: 12776
		[Token(Token = "0x40031E8")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		protected Color rightEyeLidColor;

		// Token: 0x040031E9 RID: 12777
		[Token(Token = "0x40031E9")]
		[FieldOffset(Offset = "0x64")]
		public Eye.EyeLidConfiguration LeftRestingEyeState;

		// Token: 0x040031EA RID: 12778
		[Token(Token = "0x40031EA")]
		[FieldOffset(Offset = "0x6C")]
		public Eye.EyeLidConfiguration RightRestingEyeState;

		// Token: 0x040031EB RID: 12779
		[Token(Token = "0x40031EB")]
		[FieldOffset(Offset = "0x78")]
		[Header("Eyeball Settings")]
		[SerializeField]
		protected Material eyeBallMaterial;

		// Token: 0x040031EC RID: 12780
		[Token(Token = "0x40031EC")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		protected Color eyeBallColor;

		// Token: 0x040031ED RID: 12781
		[Token(Token = "0x40031ED")]
		[FieldOffset(Offset = "0x90")]
		[Range(0f, 1f)]
		[Header("Pupil State")]
		public float PupilDilation;

		// Token: 0x040031EE RID: 12782
		[Token(Token = "0x40031EE")]
		[FieldOffset(Offset = "0x94")]
		[Header("Blinking Settings")]
		public bool BlinkingEnabled;

		// Token: 0x040031EF RID: 12783
		[Token(Token = "0x40031EF")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Range(0f, 10f)]
		protected float blinkInterval;

		// Token: 0x040031F0 RID: 12784
		[Token(Token = "0x40031F0")]
		[FieldOffset(Offset = "0x9C")]
		[Range(0f, 2f)]
		[SerializeField]
		protected float blinkIntervalSpread;

		// Token: 0x040031F1 RID: 12785
		[Token(Token = "0x40031F1")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Range(0f, 1f)]
		protected float blinkDuration;

		// Token: 0x040031F2 RID: 12786
		[Token(Token = "0x40031F2")]
		[FieldOffset(Offset = "0xA8")]
		private Avatar avatar;

		// Token: 0x040031F3 RID: 12787
		[Token(Token = "0x40031F3")]
		[FieldOffset(Offset = "0xB0")]
		private Coroutine blinkRoutine;

		// Token: 0x040031F4 RID: 12788
		[Token(Token = "0x40031F4")]
		[FieldOffset(Offset = "0xB8")]
		private float timeUntilNextBlink;

		// Token: 0x040031F5 RID: 12789
		[Token(Token = "0x40031F5")]
		[FieldOffset(Offset = "0xBC")]
		private bool eyeBallTintOverridden;

		// Token: 0x040031F6 RID: 12790
		[Token(Token = "0x40031F6")]
		[FieldOffset(Offset = "0xBD")]
		private bool eyeLidOverridden;

		// Token: 0x040031F7 RID: 12791
		[Token(Token = "0x40031F7")]
		[FieldOffset(Offset = "0xC0")]
		private Eye.EyeLidConfiguration defaultLeftEyeRestingState;

		// Token: 0x040031F8 RID: 12792
		[Token(Token = "0x40031F8")]
		[FieldOffset(Offset = "0xC8")]
		private Eye.EyeLidConfiguration defaultRightEyeRestingState;

		// Token: 0x040031F9 RID: 12793
		[Token(Token = "0x40031F9")]
		[FieldOffset(Offset = "0xD0")]
		private float defaultDilation;
	}
}
