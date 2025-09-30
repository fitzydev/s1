using System;
using Il2CppDummyDll;
using ScheduleOne.Map;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x02000A79 RID: 2681
	[Token(Token = "0x2000A79")]
	public class CartelInfluenceChangePopup : MonoBehaviour
	{
		// Token: 0x060048EF RID: 18671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048EF")]
		[Address(RVA = "0x8FFED0", Offset = "0x8FE8D0", VA = "0x1808FFED0")]
		private void Start()
		{
		}

		// Token: 0x060048F0 RID: 18672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048F0")]
		[Address(RVA = "0x8FFD00", Offset = "0x8FE700", VA = "0x1808FFD00")]
		public void Show(EMapRegion region, float oldInfluence, float newInfluence)
		{
		}

		// Token: 0x060048F1 RID: 18673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048F1")]
		[Address(RVA = "0x8FFB80", Offset = "0x8FE580", VA = "0x1808FFB80")]
		private void SetDisplayedInfluence(float influence)
		{
		}

		// Token: 0x060048F2 RID: 18674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048F2")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public CartelInfluenceChangePopup()
		{
		}

		// Token: 0x040033E3 RID: 13283
		[Token(Token = "0x40033E3")]
		public const float SLIDER_ANIMATION_DURATION = 1.5f;

		// Token: 0x040033E4 RID: 13284
		[Token(Token = "0x40033E4")]
		[FieldOffset(Offset = "0x20")]
		public Animation Anim;

		// Token: 0x040033E5 RID: 13285
		[Token(Token = "0x40033E5")]
		[FieldOffset(Offset = "0x28")]
		public Slider Slider;

		// Token: 0x040033E6 RID: 13286
		[Token(Token = "0x40033E6")]
		[FieldOffset(Offset = "0x30")]
		public TextMeshProUGUI TitleLabel;

		// Token: 0x040033E7 RID: 13287
		[Token(Token = "0x40033E7")]
		[FieldOffset(Offset = "0x38")]
		public TextMeshProUGUI InfluenceCountLabel;
	}
}
