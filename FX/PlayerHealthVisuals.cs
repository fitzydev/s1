using System;
using Beautify.Universal;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

namespace ScheduleOne.FX
{
	// Token: 0x02000598 RID: 1432
	[Token(Token = "0x2000598")]
	public class PlayerHealthVisuals : MonoBehaviour
	{
		// Token: 0x06002089 RID: 8329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002089")]
		[Address(RVA = "0x6776A0", Offset = "0x6760A0", VA = "0x1806776A0")]
		private void Awake()
		{
		}

		// Token: 0x0600208A RID: 8330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600208A")]
		[Address(RVA = "0x677B20", Offset = "0x676520", VA = "0x180677B20")]
		private void Spawned()
		{
		}

		// Token: 0x0600208B RID: 8331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600208B")]
		[Address(RVA = "0x677A40", Offset = "0x676440", VA = "0x180677A40")]
		private void MinPass()
		{
		}

		// Token: 0x0600208C RID: 8332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600208C")]
		[Address(RVA = "0x677CA0", Offset = "0x6766A0", VA = "0x180677CA0")]
		private void UpdateEffects(float newHealth)
		{
		}

		// Token: 0x0600208D RID: 8333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600208D")]
		[Address(RVA = "0x677F70", Offset = "0x676970", VA = "0x180677F70")]
		public PlayerHealthVisuals()
		{
		}

		// Token: 0x04001A99 RID: 6809
		[Token(Token = "0x4001A99")]
		[FieldOffset(Offset = "0x20")]
		[Header("References")]
		public Volume GlobalVolume;

		// Token: 0x04001A9A RID: 6810
		[Token(Token = "0x4001A9A")]
		[FieldOffset(Offset = "0x28")]
		[Header("Vignette")]
		public float VignetteAlpha_MaxHealth;

		// Token: 0x04001A9B RID: 6811
		[Token(Token = "0x4001A9B")]
		[FieldOffset(Offset = "0x2C")]
		public float VignetteAlpha_MinHealth;

		// Token: 0x04001A9C RID: 6812
		[Token(Token = "0x4001A9C")]
		[FieldOffset(Offset = "0x30")]
		public AnimationCurve OuterRingCurve;

		// Token: 0x04001A9D RID: 6813
		[Token(Token = "0x4001A9D")]
		[FieldOffset(Offset = "0x38")]
		[Header("Saturation")]
		public float Saturation_MaxHealth;

		// Token: 0x04001A9E RID: 6814
		[Token(Token = "0x4001A9E")]
		[FieldOffset(Offset = "0x3C")]
		public float Saturation_MinHealth;

		// Token: 0x04001A9F RID: 6815
		[Token(Token = "0x4001A9F")]
		[FieldOffset(Offset = "0x40")]
		[Header("Chromatic Abberation")]
		public float ChromAb_MaxHealth;

		// Token: 0x04001AA0 RID: 6816
		[Token(Token = "0x4001AA0")]
		[FieldOffset(Offset = "0x44")]
		public float ChromAb_MinHealth;

		// Token: 0x04001AA1 RID: 6817
		[Token(Token = "0x4001AA1")]
		[FieldOffset(Offset = "0x48")]
		[Header("Lens Dirt")]
		public float LensDirt_MaxHealth;

		// Token: 0x04001AA2 RID: 6818
		[Token(Token = "0x4001AA2")]
		[FieldOffset(Offset = "0x4C")]
		public float LensDirt_MinHealth;

		// Token: 0x04001AA3 RID: 6819
		[Token(Token = "0x4001AA3")]
		[FieldOffset(Offset = "0x50")]
		private Beautify _beautifySettings;
	}
}
