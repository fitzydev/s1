using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace ScheduleOne.UI
{
	// Token: 0x02000A7D RID: 2685
	[Token(Token = "0x2000A7D")]
	public class CartelStatusChangePopup : MonoBehaviour
	{
		// Token: 0x06004900 RID: 18688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004900")]
		[Address(RVA = "0x900330", Offset = "0x8FED30", VA = "0x180900330")]
		private void Start()
		{
		}

		// Token: 0x06004901 RID: 18689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004901")]
		[Address(RVA = "0x900090", Offset = "0x8FEA90", VA = "0x180900090")]
		public void Show(ECartelStatus oldStatus, ECartelStatus newStatus)
		{
		}

		// Token: 0x06004902 RID: 18690 RVA: 0x00013158 File Offset: 0x00011358
		[Token(Token = "0x6004902")]
		[Address(RVA = "0x900040", Offset = "0x8FEA40", VA = "0x180900040")]
		private Color GetColor(ECartelStatus status)
		{
			return default(Color);
		}

		// Token: 0x06004903 RID: 18691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004903")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public CartelStatusChangePopup()
		{
		}

		// Token: 0x06004904 RID: 18692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004904")]
		[Address(RVA = "0x900490", Offset = "0x8FEE90", VA = "0x180900490")]
		[CompilerGenerated]
		private IEnumerator <Show>g__Routine|8_0()
		{
			return null;
		}

		// Token: 0x040033F4 RID: 13300
		[Token(Token = "0x40033F4")]
		[FieldOffset(Offset = "0x20")]
		public Animation Anim;

		// Token: 0x040033F5 RID: 13301
		[Token(Token = "0x40033F5")]
		[FieldOffset(Offset = "0x28")]
		public TextMeshProUGUI OldStatusLabel;

		// Token: 0x040033F6 RID: 13302
		[Token(Token = "0x40033F6")]
		[FieldOffset(Offset = "0x30")]
		public TextMeshProUGUI NewStatusLabel;

		// Token: 0x040033F7 RID: 13303
		[Token(Token = "0x40033F7")]
		[FieldOffset(Offset = "0x38")]
		public Color UnknownColor;

		// Token: 0x040033F8 RID: 13304
		[Token(Token = "0x40033F8")]
		[FieldOffset(Offset = "0x48")]
		public Color TrucedColor;

		// Token: 0x040033F9 RID: 13305
		[Token(Token = "0x40033F9")]
		[FieldOffset(Offset = "0x58")]
		public Color HostileColor;

		// Token: 0x040033FA RID: 13306
		[Token(Token = "0x40033FA")]
		[FieldOffset(Offset = "0x68")]
		public Color DefeatedColor;
	}
}
