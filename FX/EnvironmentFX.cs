using System;
using Funly.SkyStudio;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.Tools;
using UnityEngine;
using VolumetricFogAndMist2;

namespace ScheduleOne.FX
{
	// Token: 0x02000593 RID: 1427
	[Token(Token = "0x2000593")]
	[ExecuteInEditMode]
	public class EnvironmentFX : Singleton<EnvironmentFX>
	{
		// Token: 0x1700058E RID: 1422
		// (get) Token: 0x0600206E RID: 8302 RVA: 0x0000A818 File Offset: 0x00008A18
		[Token(Token = "0x1700058E")]
		public float normalizedEnvironmentalBrightness
		{
			[Token(Token = "0x600206E")]
			[Address(RVA = "0x670BB0", Offset = "0x66F5B0", VA = "0x180670BB0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x0600206F RID: 8303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600206F")]
		[Address(RVA = "0x670200", Offset = "0x66EC00", VA = "0x180670200", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x06002070 RID: 8304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002070")]
		[Address(RVA = "0x6709A0", Offset = "0x66F3A0", VA = "0x1806709A0")]
		private void Update()
		{
		}

		// Token: 0x06002071 RID: 8305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002071")]
		[Address(RVA = "0x670350", Offset = "0x66ED50", VA = "0x180670350")]
		private void UpdateVisuals()
		{
		}

		// Token: 0x06002072 RID: 8306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002072")]
		[Address(RVA = "0x6701C0", Offset = "0x66EBC0", VA = "0x1806701C0", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06002073 RID: 8307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002073")]
		[Address(RVA = "0x670B40", Offset = "0x66F540", VA = "0x180670B40")]
		public EnvironmentFX()
		{
		}

		// Token: 0x04001A70 RID: 6768
		[Token(Token = "0x4001A70")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Header("References")]
		protected WindZone windZone;

		// Token: 0x04001A71 RID: 6769
		[Token(Token = "0x4001A71")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected TimeOfDayController timeOfDayController;

		// Token: 0x04001A72 RID: 6770
		[Token(Token = "0x4001A72")]
		[FieldOffset(Offset = "0x38")]
		public VolumetricFog VolumetricFog;

		// Token: 0x04001A73 RID: 6771
		[Token(Token = "0x4001A73")]
		[FieldOffset(Offset = "0x40")]
		public Light SunLight;

		// Token: 0x04001A74 RID: 6772
		[Token(Token = "0x4001A74")]
		[FieldOffset(Offset = "0x48")]
		public Light MoonLight;

		// Token: 0x04001A75 RID: 6773
		[Token(Token = "0x4001A75")]
		[FieldOffset(Offset = "0x50")]
		[Header("Fog")]
		[SerializeField]
		protected Gradient fogColorGradient;

		// Token: 0x04001A76 RID: 6774
		[Token(Token = "0x4001A76")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		protected AnimationCurve fogEndDistanceCurve;

		// Token: 0x04001A77 RID: 6775
		[Token(Token = "0x4001A77")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		protected float fogEndDistanceMultiplier;

		// Token: 0x04001A78 RID: 6776
		[Token(Token = "0x4001A78")]
		[FieldOffset(Offset = "0x68")]
		[Header("Height Fog")]
		[SerializeField]
		protected Gradient HeightFogColor;

		// Token: 0x04001A79 RID: 6777
		[Token(Token = "0x4001A79")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		protected AnimationCurve HeightFogIntensityCurve;

		// Token: 0x04001A7A RID: 6778
		[Token(Token = "0x4001A7A")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		protected float HeightFogIntensityMultiplier;

		// Token: 0x04001A7B RID: 6779
		[Token(Token = "0x4001A7B")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		protected AnimationCurve HeightFogDirectionalIntensityCurve;

		// Token: 0x04001A7C RID: 6780
		[Token(Token = "0x4001A7C")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Header("Volumetric Fog")]
		protected Gradient VolumetricFogColor;

		// Token: 0x04001A7D RID: 6781
		[Token(Token = "0x4001A7D")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		protected AnimationCurve VolumetricFogIntensityCurve;

		// Token: 0x04001A7E RID: 6782
		[Token(Token = "0x4001A7E")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		protected float VolumetricFogIntensityMultiplier;

		// Token: 0x04001A7F RID: 6783
		[Token(Token = "0x4001A7F")]
		[FieldOffset(Offset = "0xA0")]
		[Header("God rays")]
		[SerializeField]
		protected AnimationCurve godRayIntensityCurve;

		// Token: 0x04001A80 RID: 6784
		[Token(Token = "0x4001A80")]
		[FieldOffset(Offset = "0xA8")]
		[Header("Contrast")]
		[SerializeField]
		protected AnimationCurve contrastCurve;

		// Token: 0x04001A81 RID: 6785
		[Token(Token = "0x4001A81")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		protected float contractMultiplier;

		// Token: 0x04001A82 RID: 6786
		[Token(Token = "0x4001A82")]
		[FieldOffset(Offset = "0xB8")]
		[Header("Saturation")]
		[SerializeField]
		protected AnimationCurve saturationCurve;

		// Token: 0x04001A83 RID: 6787
		[Token(Token = "0x4001A83")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		protected float saturationMultiplier;

		// Token: 0x04001A84 RID: 6788
		[Token(Token = "0x4001A84")]
		[FieldOffset(Offset = "0xC8")]
		[Header("Grass")]
		[SerializeField]
		protected Material grassMat;

		// Token: 0x04001A85 RID: 6789
		[Token(Token = "0x4001A85")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		protected Gradient grassColorGradient;

		// Token: 0x04001A86 RID: 6790
		[Token(Token = "0x4001A86")]
		[FieldOffset(Offset = "0xD8")]
		[Header("Trees")]
		public Material distanceTreeMat;

		// Token: 0x04001A87 RID: 6791
		[Token(Token = "0x4001A87")]
		[FieldOffset(Offset = "0xE0")]
		public AnimationCurve distanceTreeColorCurve;

		// Token: 0x04001A88 RID: 6792
		[Token(Token = "0x4001A88")]
		[FieldOffset(Offset = "0xE8")]
		[Header("Stealth settings")]
		public AnimationCurve environmentalBrightnessCurve;

		// Token: 0x04001A89 RID: 6793
		[Token(Token = "0x4001A89")]
		[FieldOffset(Offset = "0xF0")]
		[Header("Bloom")]
		public AnimationCurve bloomThreshholdCurve;

		// Token: 0x04001A8A RID: 6794
		[Token(Token = "0x4001A8A")]
		[FieldOffset(Offset = "0xF8")]
		private bool started;

		// Token: 0x04001A8B RID: 6795
		[Token(Token = "0x4001A8B")]
		[FieldOffset(Offset = "0x100")]
		public FloatSmoother FogEndDistanceController;
	}
}
