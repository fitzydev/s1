using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.DevUtilities;
using ScheduleOne.Economy;
using TMPro;
using UnityEngine;

namespace ScheduleOne.UI
{
	// Token: 0x02000AC5 RID: 2757
	[Token(Token = "0x2000AC5")]
	public class NewCustomerPopup : Singleton<NewCustomerPopup>
	{
		// Token: 0x17000A84 RID: 2692
		// (get) Token: 0x06004AD9 RID: 19161 RVA: 0x00013698 File Offset: 0x00011898
		// (set) Token: 0x06004ADA RID: 19162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A84")]
		public bool IsPlaying
		{
			[Token(Token = "0x6004AD9")]
			[Address(RVA = "0x4B7C30", Offset = "0x4B6630", VA = "0x1804B7C30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004ADA")]
			[Address(RVA = "0x4B7C40", Offset = "0x4B6640", VA = "0x1804B7C40")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06004ADB RID: 19163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004ADB")]
		[Address(RVA = "0x920340", Offset = "0x91ED40", VA = "0x180920340", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x06004ADC RID: 19164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004ADC")]
		[Address(RVA = "0x920450", Offset = "0x91EE50", VA = "0x180920450")]
		public void PlayPopup(Customer customer)
		{
		}

		// Token: 0x06004ADD RID: 19165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004ADD")]
		[Address(RVA = "0x9203C0", Offset = "0x91EDC0", VA = "0x1809203C0")]
		private void DisableEntries()
		{
		}

		// Token: 0x06004ADE RID: 19166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004ADE")]
		[Address(RVA = "0x920870", Offset = "0x91F270", VA = "0x180920870")]
		public NewCustomerPopup()
		{
		}

		// Token: 0x06004ADF RID: 19167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004ADF")]
		[Address(RVA = "0x920800", Offset = "0x91F200", VA = "0x180920800")]
		[CompilerGenerated]
		private IEnumerator <PlayPopup>g__Routine|13_0()
		{
			return null;
		}

		// Token: 0x040035CC RID: 13772
		[Token(Token = "0x40035CC")]
		[FieldOffset(Offset = "0x30")]
		[Header("References")]
		public Canvas Canvas;

		// Token: 0x040035CD RID: 13773
		[Token(Token = "0x40035CD")]
		[FieldOffset(Offset = "0x38")]
		public RectTransform Container;

		// Token: 0x040035CE RID: 13774
		[Token(Token = "0x40035CE")]
		[FieldOffset(Offset = "0x40")]
		public CanvasGroup Group;

		// Token: 0x040035CF RID: 13775
		[Token(Token = "0x40035CF")]
		[FieldOffset(Offset = "0x48")]
		public Animation Anim;

		// Token: 0x040035D0 RID: 13776
		[Token(Token = "0x40035D0")]
		[FieldOffset(Offset = "0x50")]
		public TextMeshProUGUI Title;

		// Token: 0x040035D1 RID: 13777
		[Token(Token = "0x40035D1")]
		[FieldOffset(Offset = "0x58")]
		public RectTransform[] Entries;

		// Token: 0x040035D2 RID: 13778
		[Token(Token = "0x40035D2")]
		[FieldOffset(Offset = "0x60")]
		public AudioSourceController SoundEffect;

		// Token: 0x040035D3 RID: 13779
		[Token(Token = "0x40035D3")]
		[FieldOffset(Offset = "0x68")]
		private Coroutine routine;
	}
}
