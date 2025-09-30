using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.ItemFramework;
using ScheduleOne.Storage;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x02000B06 RID: 2822
	[Token(Token = "0x2000B06")]
	public class StorageMenu : Singleton<StorageMenu>
	{
		// Token: 0x17000ACC RID: 2764
		// (get) Token: 0x06004CAA RID: 19626 RVA: 0x00013CB0 File Offset: 0x00011EB0
		// (set) Token: 0x06004CAB RID: 19627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000ACC")]
		public bool IsOpen
		{
			[Token(Token = "0x6004CAA")]
			[Address(RVA = "0x4B7C30", Offset = "0x4B6630", VA = "0x1804B7C30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004CAB")]
			[Address(RVA = "0x4B7C40", Offset = "0x4B6640", VA = "0x1804B7C40")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000ACD RID: 2765
		// (get) Token: 0x06004CAC RID: 19628 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004CAD RID: 19629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000ACD")]
		public StorageEntity OpenedStorageEntity
		{
			[Token(Token = "0x6004CAC")]
			[Address(RVA = "0x4423A0", Offset = "0x440DA0", VA = "0x1804423A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004CAD")]
			[Address(RVA = "0x4423D0", Offset = "0x440DD0", VA = "0x1804423D0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06004CAE RID: 19630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CAE")]
		[Address(RVA = "0x935D90", Offset = "0x934790", VA = "0x180935D90", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x06004CAF RID: 19631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CAF")]
		[Address(RVA = "0x936420", Offset = "0x934E20", VA = "0x180936420", Slot = "7")]
		public virtual void Open(IItemSlotOwner owner, string title, string subtitle)
		{
		}

		// Token: 0x06004CB0 RID: 19632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CB0")]
		[Address(RVA = "0x936C30", Offset = "0x935630", VA = "0x180936C30", Slot = "8")]
		public virtual void Open(StorageEntity entity)
		{
		}

		// Token: 0x06004CB1 RID: 19633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CB1")]
		[Address(RVA = "0x9364B0", Offset = "0x934EB0", VA = "0x1809364B0")]
		private void Open(string title, string subtitle, IItemSlotOwner owner)
		{
		}

		// Token: 0x06004CB2 RID: 19634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CB2")]
		[Address(RVA = "0x9362C0", Offset = "0x934CC0", VA = "0x1809362C0")]
		public void Close()
		{
		}

		// Token: 0x06004CB3 RID: 19635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CB3")]
		[Address(RVA = "0x935E80", Offset = "0x934880", VA = "0x180935E80", Slot = "9")]
		public virtual void CloseMenu()
		{
		}

		// Token: 0x06004CB4 RID: 19636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CB4")]
		[Address(RVA = "0x936360", Offset = "0x934D60", VA = "0x180936360")]
		private void Exit(ExitAction action)
		{
		}

		// Token: 0x06004CB5 RID: 19637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CB5")]
		[Address(RVA = "0x936CA0", Offset = "0x9356A0", VA = "0x180936CA0")]
		public StorageMenu()
		{
		}

		// Token: 0x04003782 RID: 14210
		[Token(Token = "0x4003782")]
		[FieldOffset(Offset = "0x38")]
		[Header("References")]
		public Canvas Canvas;

		// Token: 0x04003783 RID: 14211
		[Token(Token = "0x4003783")]
		[FieldOffset(Offset = "0x40")]
		public RectTransform Container;

		// Token: 0x04003784 RID: 14212
		[Token(Token = "0x4003784")]
		[FieldOffset(Offset = "0x48")]
		public TextMeshProUGUI TitleLabel;

		// Token: 0x04003785 RID: 14213
		[Token(Token = "0x4003785")]
		[FieldOffset(Offset = "0x50")]
		public TextMeshProUGUI SubtitleLabel;

		// Token: 0x04003786 RID: 14214
		[Token(Token = "0x4003786")]
		[FieldOffset(Offset = "0x58")]
		public RectTransform SlotContainer;

		// Token: 0x04003787 RID: 14215
		[Token(Token = "0x4003787")]
		[FieldOffset(Offset = "0x60")]
		public ItemSlotUI[] SlotsUIs;

		// Token: 0x04003788 RID: 14216
		[Token(Token = "0x4003788")]
		[FieldOffset(Offset = "0x68")]
		public GridLayoutGroup SlotGridLayout;

		// Token: 0x04003789 RID: 14217
		[Token(Token = "0x4003789")]
		[FieldOffset(Offset = "0x70")]
		public RectTransform CloseButton;

		// Token: 0x0400378A RID: 14218
		[Token(Token = "0x400378A")]
		[FieldOffset(Offset = "0x78")]
		public UnityEvent onClosed;
	}
}
