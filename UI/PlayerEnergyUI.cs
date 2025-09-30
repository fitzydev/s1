using System;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x02000AEA RID: 2794
	[Token(Token = "0x2000AEA")]
	public class PlayerEnergyUI : Singleton<PlayerEnergyUI>
	{
		// Token: 0x06004BE8 RID: 19432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BE8")]
		[Address(RVA = "0x92EA40", Offset = "0x92D440", VA = "0x18092EA40", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x06004BE9 RID: 19433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BE9")]
		[Address(RVA = "0x92EDE0", Offset = "0x92D7E0", VA = "0x18092EDE0")]
		private void UpdateDisplayedEnergy()
		{
		}

		// Token: 0x06004BEA RID: 19434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BEA")]
		[Address(RVA = "0x92EB90", Offset = "0x92D590", VA = "0x18092EB90")]
		public void SetDisplayedEnergy(float energy)
		{
		}

		// Token: 0x06004BEB RID: 19435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BEB")]
		[Address(RVA = "0x92EED0", Offset = "0x92D8D0", VA = "0x18092EED0", Slot = "7")]
		protected virtual void Update()
		{
		}

		// Token: 0x06004BEC RID: 19436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BEC")]
		[Address(RVA = "0x92F230", Offset = "0x92DC30", VA = "0x18092F230")]
		public PlayerEnergyUI()
		{
		}

		// Token: 0x040036E7 RID: 14055
		[Token(Token = "0x40036E7")]
		[FieldOffset(Offset = "0x28")]
		public Slider Slider;

		// Token: 0x040036E8 RID: 14056
		[Token(Token = "0x40036E8")]
		[FieldOffset(Offset = "0x30")]
		public RectTransform SliderRect;

		// Token: 0x040036E9 RID: 14057
		[Token(Token = "0x40036E9")]
		[FieldOffset(Offset = "0x38")]
		public Image FillImage;

		// Token: 0x040036EA RID: 14058
		[Token(Token = "0x40036EA")]
		[FieldOffset(Offset = "0x40")]
		public TextMeshProUGUI Label;

		// Token: 0x040036EB RID: 14059
		[Token(Token = "0x40036EB")]
		[FieldOffset(Offset = "0x48")]
		[Header("Settings")]
		public Color SliderColor_Green;

		// Token: 0x040036EC RID: 14060
		[Token(Token = "0x40036EC")]
		[FieldOffset(Offset = "0x58")]
		public Color SliderColor_Red;

		// Token: 0x040036ED RID: 14061
		[Token(Token = "0x40036ED")]
		[FieldOffset(Offset = "0x68")]
		private float displayedValue;
	}
}
