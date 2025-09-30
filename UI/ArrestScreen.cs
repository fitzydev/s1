using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.UI
{
	// Token: 0x02000ADA RID: 2778
	[Token(Token = "0x2000ADA")]
	public class ArrestScreen : Singleton<ArrestScreen>
	{
		// Token: 0x17000A99 RID: 2713
		// (get) Token: 0x06004B82 RID: 19330 RVA: 0x00013920 File Offset: 0x00011B20
		// (set) Token: 0x06004B83 RID: 19331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A99")]
		public bool isOpen
		{
			[Token(Token = "0x6004B82")]
			[Address(RVA = "0x4B7C30", Offset = "0x4B6630", VA = "0x1804B7C30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004B83")]
			[Address(RVA = "0x4B7C40", Offset = "0x4B6640", VA = "0x1804B7C40")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06004B84 RID: 19332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B84")]
		[Address(RVA = "0x92B7B0", Offset = "0x92A1B0", VA = "0x18092B7B0", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x06004B85 RID: 19333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B85")]
		[Address(RVA = "0x92B940", Offset = "0x92A340", VA = "0x18092B940")]
		private void Continue()
		{
		}

		// Token: 0x06004B86 RID: 19334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B86")]
		[Address(RVA = "0x92B9C0", Offset = "0x92A3C0", VA = "0x18092B9C0")]
		private void LoadSaveClicked()
		{
		}

		// Token: 0x06004B87 RID: 19335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B87")]
		[Address(RVA = "0x92B9D0", Offset = "0x92A3D0", VA = "0x18092B9D0")]
		public void Open()
		{
		}

		// Token: 0x06004B88 RID: 19336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B88")]
		[Address(RVA = "0x92B830", Offset = "0x92A230", VA = "0x18092B830")]
		public void Close()
		{
		}

		// Token: 0x06004B89 RID: 19337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B89")]
		[Address(RVA = "0x92BBE0", Offset = "0x92A5E0", VA = "0x18092BBE0")]
		public ArrestScreen()
		{
		}

		// Token: 0x06004B8A RID: 19338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B8A")]
		[Address(RVA = "0x92BB00", Offset = "0x92A500", VA = "0x18092BB00")]
		[CompilerGenerated]
		private IEnumerator <Continue>g__Routine|9_0()
		{
			return null;
		}

		// Token: 0x06004B8B RID: 19339 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B8B")]
		[Address(RVA = "0x92BB70", Offset = "0x92A570", VA = "0x18092BB70")]
		[CompilerGenerated]
		private IEnumerator <Open>g__Routine|11_0()
		{
			return null;
		}

		// Token: 0x04003687 RID: 13959
		[Token(Token = "0x4003687")]
		[FieldOffset(Offset = "0x30")]
		[Header("References")]
		public Canvas canvas;

		// Token: 0x04003688 RID: 13960
		[Token(Token = "0x4003688")]
		[FieldOffset(Offset = "0x38")]
		public CanvasGroup group;

		// Token: 0x04003689 RID: 13961
		[Token(Token = "0x4003689")]
		[FieldOffset(Offset = "0x40")]
		public AudioSourceController Sound;

		// Token: 0x0400368A RID: 13962
		[Token(Token = "0x400368A")]
		[FieldOffset(Offset = "0x48")]
		public Animation Anim;
	}
}
