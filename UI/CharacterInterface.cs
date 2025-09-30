using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x02000A82 RID: 2690
	[Token(Token = "0x2000A82")]
	public class CharacterInterface : MonoBehaviour
	{
		// Token: 0x17000A41 RID: 2625
		// (get) Token: 0x06004917 RID: 18711 RVA: 0x000131B8 File Offset: 0x000113B8
		// (set) Token: 0x06004918 RID: 18712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A41")]
		public bool IsOpen
		{
			[Token(Token = "0x6004917")]
			[Address(RVA = "0x4B9020", Offset = "0x4B7A20", VA = "0x1804B9020")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004918")]
			[Address(RVA = "0x4B9030", Offset = "0x4B7A30", VA = "0x1804B9030")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06004919 RID: 18713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004919")]
		[Address(RVA = "0x901E50", Offset = "0x900850", VA = "0x180901E50")]
		private void Awake()
		{
		}

		// Token: 0x0600491A RID: 18714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600491A")]
		[Address(RVA = "0x901E90", Offset = "0x900890", VA = "0x180901E90")]
		private void LateUpdate()
		{
		}

		// Token: 0x0600491B RID: 18715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600491B")]
		[Address(RVA = "0x9020C0", Offset = "0x900AC0", VA = "0x1809020C0")]
		public void Open()
		{
		}

		// Token: 0x0600491C RID: 18716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600491C")]
		[Address(RVA = "0x901E50", Offset = "0x900850", VA = "0x180901E50")]
		public void Close()
		{
		}

		// Token: 0x0600491D RID: 18717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600491D")]
		[Address(RVA = "0x902430", Offset = "0x900E30", VA = "0x180902430")]
		public CharacterInterface()
		{
		}

		// Token: 0x0400340A RID: 13322
		[Token(Token = "0x400340A")]
		[FieldOffset(Offset = "0x28")]
		public ClothingSlotUI[] ClothingSlots;

		// Token: 0x0400340B RID: 13323
		[Token(Token = "0x400340B")]
		[FieldOffset(Offset = "0x30")]
		public RectTransform Container;

		// Token: 0x0400340C RID: 13324
		[Token(Token = "0x400340C")]
		[FieldOffset(Offset = "0x38")]
		public Slider RotationSlider;

		// Token: 0x0400340D RID: 13325
		[Token(Token = "0x400340D")]
		[FieldOffset(Offset = "0x40")]
		private Dictionary<ClothingSlotUI, Transform> SlotAlignmentPoints;
	}
}
