using System;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.Tools;
using UnityEngine;

namespace ScheduleOne.UI
{
	// Token: 0x02000AE2 RID: 2786
	[Token(Token = "0x2000AE2")]
	public class EyelidOverlay : Singleton<EyelidOverlay>
	{
		// Token: 0x06004BB9 RID: 19385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BB9")]
		[Address(RVA = "0x92CCA0", Offset = "0x92B6A0", VA = "0x18092CCA0", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x06004BBA RID: 19386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BBA")]
		[Address(RVA = "0x92CE10", Offset = "0x92B810", VA = "0x18092CE10")]
		private void Update()
		{
		}

		// Token: 0x06004BBB RID: 19387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BBB")]
		[Address(RVA = "0x92CD10", Offset = "0x92B710", VA = "0x18092CD10")]
		public void SetOpen(float openness)
		{
		}

		// Token: 0x06004BBC RID: 19388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BBC")]
		[Address(RVA = "0x92CFA0", Offset = "0x92B9A0", VA = "0x18092CFA0")]
		public EyelidOverlay()
		{
		}

		// Token: 0x040036B5 RID: 14005
		[Token(Token = "0x40036B5")]
		public const float MaxTiredOpenAmount = 0.625f;

		// Token: 0x040036B6 RID: 14006
		[Token(Token = "0x40036B6")]
		[FieldOffset(Offset = "0x28")]
		public bool AutoUpdate;

		// Token: 0x040036B7 RID: 14007
		[Token(Token = "0x40036B7")]
		[FieldOffset(Offset = "0x2C")]
		[Header("Settings")]
		public float Open;

		// Token: 0x040036B8 RID: 14008
		[Token(Token = "0x40036B8")]
		[FieldOffset(Offset = "0x30")]
		public float Closed;

		// Token: 0x040036B9 RID: 14009
		[Token(Token = "0x40036B9")]
		[FieldOffset(Offset = "0x38")]
		[Header("References")]
		public RectTransform Upper;

		// Token: 0x040036BA RID: 14010
		[Token(Token = "0x40036BA")]
		[FieldOffset(Offset = "0x40")]
		public RectTransform Lower;

		// Token: 0x040036BB RID: 14011
		[Token(Token = "0x40036BB")]
		[FieldOffset(Offset = "0x48")]
		public Canvas Canvas;

		// Token: 0x040036BC RID: 14012
		[Token(Token = "0x40036BC")]
		[FieldOffset(Offset = "0x50")]
		[Range(0f, 1f)]
		public float CurrentOpen;

		// Token: 0x040036BD RID: 14013
		[Token(Token = "0x40036BD")]
		[FieldOffset(Offset = "0x58")]
		public FloatSmoother OpenMultiplier;
	}
}
