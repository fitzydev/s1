using System;
using Il2CppDummyDll;
using ScheduleOne.Clothing;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x02000AB8 RID: 2744
	[Token(Token = "0x2000AB8")]
	public class ClothingSlotUI : ItemSlotUI
	{
		// Token: 0x06004A80 RID: 19072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A80")]
		[Address(RVA = "0x9152D0", Offset = "0x913CD0", VA = "0x1809152D0")]
		private void Start()
		{
		}

		// Token: 0x06004A81 RID: 19073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A81")]
		[Address(RVA = "0x9152A0", Offset = "0x913CA0", VA = "0x1809152A0")]
		public ClothingSlotUI()
		{
		}

		// Token: 0x04003570 RID: 13680
		[Token(Token = "0x4003570")]
		[FieldOffset(Offset = "0x68")]
		public EClothingSlot SlotType;

		// Token: 0x04003571 RID: 13681
		[Token(Token = "0x4003571")]
		[FieldOffset(Offset = "0x70")]
		public Image SlotTypeImage;
	}
}
