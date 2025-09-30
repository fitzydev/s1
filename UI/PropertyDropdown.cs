using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.Property;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x02000AF5 RID: 2805
	[Token(Token = "0x2000AF5")]
	public class PropertyDropdown : MonoBehaviour
	{
		// Token: 0x06004C31 RID: 19505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C31")]
		[Address(RVA = "0x92FB30", Offset = "0x92E530", VA = "0x18092FB30", Slot = "4")]
		protected virtual void Awake()
		{
		}

		// Token: 0x06004C32 RID: 19506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C32")]
		[Address(RVA = "0x92FF20", Offset = "0x92E920", VA = "0x18092FF20")]
		private void PropertyAcquired(Property p)
		{
		}

		// Token: 0x06004C33 RID: 19507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C33")]
		[Address(RVA = "0x930150", Offset = "0x92EB50", VA = "0x180930150")]
		private void ValueChanged(int newVal)
		{
		}

		// Token: 0x06004C34 RID: 19508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C34")]
		[Address(RVA = "0x9301D0", Offset = "0x92EBD0", VA = "0x1809301D0")]
		public PropertyDropdown()
		{
		}

		// Token: 0x04003729 RID: 14121
		[Token(Token = "0x4003729")]
		[FieldOffset(Offset = "0x20")]
		public Property selectedProperty;

		// Token: 0x0400372A RID: 14122
		[Token(Token = "0x400372A")]
		[FieldOffset(Offset = "0x28")]
		private TMP_Dropdown TMP_dropdown;

		// Token: 0x0400372B RID: 14123
		[Token(Token = "0x400372B")]
		[FieldOffset(Offset = "0x30")]
		private Dropdown dropdown;

		// Token: 0x0400372C RID: 14124
		[Token(Token = "0x400372C")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<int, Property> intToProperty;

		// Token: 0x0400372D RID: 14125
		[Token(Token = "0x400372D")]
		[FieldOffset(Offset = "0x40")]
		public Action onSelectionChanged;
	}
}
