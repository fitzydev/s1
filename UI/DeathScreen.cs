using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.DevUtilities;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x02000ADF RID: 2783
	[Token(Token = "0x2000ADF")]
	public class DeathScreen : Singleton<DeathScreen>
	{
		// Token: 0x17000AA0 RID: 2720
		// (get) Token: 0x06004BA2 RID: 19362 RVA: 0x00013980 File Offset: 0x00011B80
		// (set) Token: 0x06004BA3 RID: 19363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AA0")]
		public bool isOpen
		{
			[Token(Token = "0x6004BA2")]
			[Address(RVA = "0x4B7C30", Offset = "0x4B6630", VA = "0x1804B7C30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004BA3")]
			[Address(RVA = "0x4B7C40", Offset = "0x4B6640", VA = "0x1804B7C40")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06004BA4 RID: 19364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BA4")]
		[Address(RVA = "0x92C380", Offset = "0x92AD80", VA = "0x18092C380", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x06004BA5 RID: 19365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BA5")]
		[Address(RVA = "0x92C9E0", Offset = "0x92B3E0", VA = "0x18092C9E0")]
		private void RespawnClicked()
		{
		}

		// Token: 0x06004BA6 RID: 19366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BA6")]
		[Address(RVA = "0x92C6A0", Offset = "0x92B0A0", VA = "0x18092C6A0")]
		private void LoadSaveClicked()
		{
		}

		// Token: 0x06004BA7 RID: 19367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BA7")]
		[Address(RVA = "0x92C790", Offset = "0x92B190", VA = "0x18092C790")]
		public void Open()
		{
		}

		// Token: 0x06004BA8 RID: 19368 RVA: 0x00013998 File Offset: 0x00011B98
		[Token(Token = "0x6004BA8")]
		[Address(RVA = "0x92C4F0", Offset = "0x92AEF0", VA = "0x18092C4F0")]
		private bool CanRespawn()
		{
			return default(bool);
		}

		// Token: 0x06004BA9 RID: 19369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BA9")]
		[Address(RVA = "0x92C560", Offset = "0x92AF60", VA = "0x18092C560")]
		public void Close()
		{
		}

		// Token: 0x06004BAA RID: 19370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BAA")]
		[Address(RVA = "0x92CB40", Offset = "0x92B540", VA = "0x18092CB40")]
		public DeathScreen()
		{
		}

		// Token: 0x06004BAB RID: 19371 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BAB")]
		[Address(RVA = "0x92CAD0", Offset = "0x92B4D0", VA = "0x18092CAD0")]
		[CompilerGenerated]
		private IEnumerator <RespawnClicked>g__Routine|13_0()
		{
			return null;
		}

		// Token: 0x06004BAC RID: 19372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BAC")]
		[Address(RVA = "0x92CA60", Offset = "0x92B460", VA = "0x18092CA60")]
		[CompilerGenerated]
		private IEnumerator <Open>g__Routine|15_0()
		{
			return null;
		}

		// Token: 0x040036A5 RID: 13989
		[Token(Token = "0x40036A5")]
		[FieldOffset(Offset = "0x30")]
		[Header("References")]
		public Canvas canvas;

		// Token: 0x040036A6 RID: 13990
		[Token(Token = "0x40036A6")]
		[FieldOffset(Offset = "0x38")]
		public RectTransform Container;

		// Token: 0x040036A7 RID: 13991
		[Token(Token = "0x40036A7")]
		[FieldOffset(Offset = "0x40")]
		public CanvasGroup group;

		// Token: 0x040036A8 RID: 13992
		[Token(Token = "0x40036A8")]
		[FieldOffset(Offset = "0x48")]
		public Button respawnButton;

		// Token: 0x040036A9 RID: 13993
		[Token(Token = "0x40036A9")]
		[FieldOffset(Offset = "0x50")]
		public Button loadSaveButton;

		// Token: 0x040036AA RID: 13994
		[Token(Token = "0x40036AA")]
		[FieldOffset(Offset = "0x58")]
		public Animation Anim;

		// Token: 0x040036AB RID: 13995
		[Token(Token = "0x40036AB")]
		[FieldOffset(Offset = "0x60")]
		public AudioSourceController Sound;

		// Token: 0x040036AC RID: 13996
		[Token(Token = "0x40036AC")]
		[FieldOffset(Offset = "0x68")]
		private bool arrested;
	}
}
