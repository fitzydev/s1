using System;
using Beautify.Universal;
using CorgiGodRays;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.Tools;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace ScheduleOne.FX
{
	// Token: 0x02000599 RID: 1433
	[Token(Token = "0x2000599")]
	public class PostProcessingManager : Singleton<PostProcessingManager>
	{
		// Token: 0x0600208E RID: 8334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600208E")]
		[Address(RVA = "0x67A4A0", Offset = "0x678EA0", VA = "0x18067A4A0", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x0600208F RID: 8335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600208F")]
		[Address(RVA = "0x67AC10", Offset = "0x679610", VA = "0x18067AC10")]
		public void Update()
		{
		}

		// Token: 0x06002090 RID: 8336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002090")]
		[Address(RVA = "0x67A9F0", Offset = "0x6793F0", VA = "0x18067A9F0")]
		private void UpdateEffects()
		{
		}

		// Token: 0x06002091 RID: 8337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002091")]
		[Address(RVA = "0x67A7B0", Offset = "0x6791B0", VA = "0x18067A7B0")]
		public void OverrideVignette(float intensity, float smoothness)
		{
		}

		// Token: 0x06002092 RID: 8338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002092")]
		[Address(RVA = "0x67A820", Offset = "0x679220", VA = "0x18067A820")]
		public void ResetVignette()
		{
		}

		// Token: 0x06002093 RID: 8339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002093")]
		[Address(RVA = "0x67A990", Offset = "0x679390", VA = "0x18067A990")]
		public void SetGodRayIntensity(float intensity)
		{
		}

		// Token: 0x06002094 RID: 8340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002094")]
		[Address(RVA = "0x67A950", Offset = "0x679350", VA = "0x18067A950")]
		public void SetContrast(float value)
		{
		}

		// Token: 0x06002095 RID: 8341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002095")]
		[Address(RVA = "0x67A9D0", Offset = "0x6793D0", VA = "0x18067A9D0")]
		public void SetSaturation(float value)
		{
		}

		// Token: 0x06002096 RID: 8342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002096")]
		[Address(RVA = "0x67A890", Offset = "0x679290", VA = "0x18067A890")]
		public void SetBloomThreshold(float threshold)
		{
		}

		// Token: 0x06002097 RID: 8343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002097")]
		[Address(RVA = "0x67A8D0", Offset = "0x6792D0", VA = "0x18067A8D0")]
		public void SetBlur(float blurLevel)
		{
		}

		// Token: 0x06002098 RID: 8344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002098")]
		[Address(RVA = "0x67AC20", Offset = "0x679620", VA = "0x18067AC20")]
		public PostProcessingManager()
		{
		}

		// Token: 0x04001AA4 RID: 6820
		[Token(Token = "0x4001AA4")]
		[FieldOffset(Offset = "0x28")]
		[Header("References")]
		public Volume GlobalVolume;

		// Token: 0x04001AA5 RID: 6821
		[Token(Token = "0x4001AA5")]
		[FieldOffset(Offset = "0x30")]
		[Header("Vignette")]
		public float Vig_DefaultIntensity;

		// Token: 0x04001AA6 RID: 6822
		[Token(Token = "0x4001AA6")]
		[FieldOffset(Offset = "0x34")]
		public float Vig_DefaultSmoothness;

		// Token: 0x04001AA7 RID: 6823
		[Token(Token = "0x4001AA7")]
		[FieldOffset(Offset = "0x38")]
		[Header("Blur")]
		public float MinBlur;

		// Token: 0x04001AA8 RID: 6824
		[Token(Token = "0x4001AA8")]
		[FieldOffset(Offset = "0x3C")]
		public float MaxBlur;

		// Token: 0x04001AA9 RID: 6825
		[Token(Token = "0x4001AA9")]
		[FieldOffset(Offset = "0x40")]
		[Header("Smoothers")]
		public FloatSmoother ChromaticAberrationController;

		// Token: 0x04001AAA RID: 6826
		[Token(Token = "0x4001AAA")]
		[FieldOffset(Offset = "0x48")]
		public FloatSmoother SaturationController;

		// Token: 0x04001AAB RID: 6827
		[Token(Token = "0x4001AAB")]
		[FieldOffset(Offset = "0x50")]
		public FloatSmoother BloomController;

		// Token: 0x04001AAC RID: 6828
		[Token(Token = "0x4001AAC")]
		[FieldOffset(Offset = "0x58")]
		public HDRColorSmoother ColorFilterController;

		// Token: 0x04001AAD RID: 6829
		[Token(Token = "0x4001AAD")]
		[FieldOffset(Offset = "0x60")]
		private Vignette vig;

		// Token: 0x04001AAE RID: 6830
		[Token(Token = "0x4001AAE")]
		[FieldOffset(Offset = "0x68")]
		private DepthOfField DoF;

		// Token: 0x04001AAF RID: 6831
		[Token(Token = "0x4001AAF")]
		[FieldOffset(Offset = "0x70")]
		private GodRaysVolume GodRays;

		// Token: 0x04001AB0 RID: 6832
		[Token(Token = "0x4001AB0")]
		[FieldOffset(Offset = "0x78")]
		private ColorAdjustments ColorAdjustments;

		// Token: 0x04001AB1 RID: 6833
		[Token(Token = "0x4001AB1")]
		[FieldOffset(Offset = "0x80")]
		private Beautify beautifySettings;

		// Token: 0x04001AB2 RID: 6834
		[Token(Token = "0x4001AB2")]
		[FieldOffset(Offset = "0x88")]
		private Bloom bloom;

		// Token: 0x04001AB3 RID: 6835
		[Token(Token = "0x4001AB3")]
		[FieldOffset(Offset = "0x90")]
		private ChromaticAberration chromaticAberration;

		// Token: 0x04001AB4 RID: 6836
		[Token(Token = "0x4001AB4")]
		[FieldOffset(Offset = "0x98")]
		private ColorAdjustments colorAdjustments;
	}
}
