using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Lighting
{
	// Token: 0x02000514 RID: 1300
	[Token(Token = "0x2000514")]
	[RequireComponent(typeof(Light))]
	public class FlickeringLight : MonoBehaviour
	{
		// Token: 0x06001A71 RID: 6769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A71")]
		[Address(RVA = "0x6343B0", Offset = "0x632DB0", VA = "0x1806343B0")]
		private void Start()
		{
		}

		// Token: 0x06001A72 RID: 6770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A72")]
		[Address(RVA = "0x634500", Offset = "0x632F00", VA = "0x180634500")]
		private void Update()
		{
		}

		// Token: 0x06001A73 RID: 6771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A73")]
		[Address(RVA = "0x634410", Offset = "0x632E10", VA = "0x180634410")]
		private void UpdateTargetValues()
		{
		}

		// Token: 0x06001A74 RID: 6772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A74")]
		[Address(RVA = "0x6346F0", Offset = "0x6330F0", VA = "0x1806346F0")]
		public FlickeringLight()
		{
		}

		// Token: 0x040016C3 RID: 5827
		[Token(Token = "0x40016C3")]
		[FieldOffset(Offset = "0x20")]
		[Header("Intensity Settings")]
		[Tooltip("The minimum light intensity.")]
		public float minIntensity;

		// Token: 0x040016C4 RID: 5828
		[Token(Token = "0x40016C4")]
		[FieldOffset(Offset = "0x24")]
		[Tooltip("The maximum light intensity.")]
		public float maxIntensity;

		// Token: 0x040016C5 RID: 5829
		[Token(Token = "0x40016C5")]
		[FieldOffset(Offset = "0x28")]
		[Header("Color Settings")]
		[Tooltip("Enable slight color shifts to simulate a warm flame.")]
		public bool enableColorShift;

		// Token: 0x040016C6 RID: 5830
		[Token(Token = "0x40016C6")]
		[FieldOffset(Offset = "0x2C")]
		public Color minColor;

		// Token: 0x040016C7 RID: 5831
		[Token(Token = "0x40016C7")]
		[FieldOffset(Offset = "0x3C")]
		public Color maxColor;

		// Token: 0x040016C8 RID: 5832
		[Token(Token = "0x40016C8")]
		[FieldOffset(Offset = "0x4C")]
		[Tooltip("How quickly the light flickers (lower is faster).")]
		[Header("Flicker Speed")]
		public float flickerSpeed;

		// Token: 0x040016C9 RID: 5833
		[Token(Token = "0x40016C9")]
		[FieldOffset(Offset = "0x50")]
		private Light lightSource;

		// Token: 0x040016CA RID: 5834
		[Token(Token = "0x40016CA")]
		[FieldOffset(Offset = "0x58")]
		private float targetIntensity;

		// Token: 0x040016CB RID: 5835
		[Token(Token = "0x40016CB")]
		[FieldOffset(Offset = "0x5C")]
		private Color targetColor;
	}
}
