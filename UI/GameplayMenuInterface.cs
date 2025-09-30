using System;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x02000AA2 RID: 2722
	[Token(Token = "0x2000AA2")]
	public class GameplayMenuInterface : Singleton<GameplayMenuInterface>
	{
		// Token: 0x06004A02 RID: 18946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A02")]
		[Address(RVA = "0x915590", Offset = "0x913F90", VA = "0x180915590", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x06004A03 RID: 18947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A03")]
		[Address(RVA = "0x915760", Offset = "0x914160", VA = "0x180915760")]
		public void Open()
		{
		}

		// Token: 0x06004A04 RID: 18948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A04")]
		[Address(RVA = "0x915730", Offset = "0x914130", VA = "0x180915730")]
		public void Close()
		{
		}

		// Token: 0x06004A05 RID: 18949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A05")]
		[Address(RVA = "0x915790", Offset = "0x914190", VA = "0x180915790")]
		public void PhoneClicked()
		{
		}

		// Token: 0x06004A06 RID: 18950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A06")]
		[Address(RVA = "0x9156B0", Offset = "0x9140B0", VA = "0x1809156B0")]
		public void CharacterClicked()
		{
		}

		// Token: 0x06004A07 RID: 18951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A07")]
		[Address(RVA = "0x915810", Offset = "0x914210", VA = "0x180915810")]
		public void SetSelected(GameplayMenu.EGameplayScreen screen)
		{
		}

		// Token: 0x06004A08 RID: 18952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A08")]
		[Address(RVA = "0x915A40", Offset = "0x914440", VA = "0x180915A40")]
		public GameplayMenuInterface()
		{
		}

		// Token: 0x040034D2 RID: 13522
		[Token(Token = "0x40034D2")]
		[FieldOffset(Offset = "0x28")]
		public Canvas Canvas;

		// Token: 0x040034D3 RID: 13523
		[Token(Token = "0x40034D3")]
		[FieldOffset(Offset = "0x30")]
		public Button PhoneButton;

		// Token: 0x040034D4 RID: 13524
		[Token(Token = "0x40034D4")]
		[FieldOffset(Offset = "0x38")]
		public Button CharacterButton;

		// Token: 0x040034D5 RID: 13525
		[Token(Token = "0x40034D5")]
		[FieldOffset(Offset = "0x40")]
		public RectTransform SelectionIndicator;

		// Token: 0x040034D6 RID: 13526
		[Token(Token = "0x40034D6")]
		[FieldOffset(Offset = "0x48")]
		public CharacterInterface CharacterInterface;

		// Token: 0x040034D7 RID: 13527
		[Token(Token = "0x40034D7")]
		[FieldOffset(Offset = "0x50")]
		private Coroutine selectionLerp;
	}
}
