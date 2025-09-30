using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.UI
{
	// Token: 0x02000A96 RID: 2710
	[Token(Token = "0x2000A96")]
	public class DocumentViewer : Singleton<DocumentViewer>
	{
		// Token: 0x17000A5A RID: 2650
		// (get) Token: 0x060049BA RID: 18874 RVA: 0x00013410 File Offset: 0x00011610
		// (set) Token: 0x060049BB RID: 18875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A5A")]
		public bool IsOpen
		{
			[Token(Token = "0x60049BA")]
			[Address(RVA = "0x4B7C30", Offset = "0x4B6630", VA = "0x1804B7C30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60049BB")]
			[Address(RVA = "0x4B7C40", Offset = "0x4B6640", VA = "0x1804B7C40")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x060049BC RID: 18876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049BC")]
		[Address(RVA = "0x90C340", Offset = "0x90AD40", VA = "0x18090C340", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x060049BD RID: 18877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049BD")]
		[Address(RVA = "0x90BEB0", Offset = "0x90A8B0", VA = "0x18090BEB0")]
		private void Exit(ExitAction action)
		{
		}

		// Token: 0x060049BE RID: 18878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049BE")]
		[Address(RVA = "0x90BF00", Offset = "0x90A900", VA = "0x18090BF00")]
		public void Open(string documentName)
		{
		}

		// Token: 0x060049BF RID: 18879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049BF")]
		[Address(RVA = "0x90BB70", Offset = "0x90A570", VA = "0x18090BB70")]
		public void Close()
		{
		}

		// Token: 0x060049C0 RID: 18880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049C0")]
		[Address(RVA = "0x90C410", Offset = "0x90AE10", VA = "0x18090C410")]
		public DocumentViewer()
		{
		}

		// Token: 0x04003498 RID: 13464
		[Token(Token = "0x4003498")]
		[FieldOffset(Offset = "0x30")]
		[Header("References")]
		public Canvas Canvas;

		// Token: 0x04003499 RID: 13465
		[Token(Token = "0x4003499")]
		[FieldOffset(Offset = "0x38")]
		public RectTransform[] Documents;

		// Token: 0x0400349A RID: 13466
		[Token(Token = "0x400349A")]
		[FieldOffset(Offset = "0x40")]
		public UnityEvent onOpen;
	}
}
