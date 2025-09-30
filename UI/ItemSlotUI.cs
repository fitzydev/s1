using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using ScheduleOne.UI.Items;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x02000AB9 RID: 2745
	[Token(Token = "0x2000AB9")]
	public class ItemSlotUI : MonoBehaviour
	{
		// Token: 0x17000A77 RID: 2679
		// (get) Token: 0x06004A82 RID: 19074 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004A83 RID: 19075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A77")]
		public ItemSlot assignedSlot
		{
			[Token(Token = "0x6004A82")]
			[Address(RVA = "0x4423C0", Offset = "0x440DC0", VA = "0x1804423C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004A83")]
			[Address(RVA = "0x4423F0", Offset = "0x440DF0", VA = "0x1804423F0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000A78 RID: 2680
		// (get) Token: 0x06004A84 RID: 19076 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004A85 RID: 19077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A78")]
		public ItemUI ItemUI
		{
			[Token(Token = "0x6004A84")]
			[Address(RVA = "0x4E9B20", Offset = "0x4E8520", VA = "0x1804E9B20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004A85")]
			[Address(RVA = "0x5FD1D0", Offset = "0x5FBBD0", VA = "0x1805FD1D0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06004A86 RID: 19078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A86")]
		[Address(RVA = "0x91A800", Offset = "0x919200", VA = "0x18091A800", Slot = "4")]
		public virtual void AssignSlot(ItemSlot s)
		{
		}

		// Token: 0x06004A87 RID: 19079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A87")]
		[Address(RVA = "0x91AD60", Offset = "0x919760", VA = "0x18091AD60", Slot = "5")]
		public virtual void ClearSlot()
		{
		}

		// Token: 0x06004A88 RID: 19080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A88")]
		[Address(RVA = "0x91B300", Offset = "0x919D00", VA = "0x18091B300")]
		public void OnDestroy()
		{
		}

		// Token: 0x06004A89 RID: 19081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A89")]
		[Address(RVA = "0x91B860", Offset = "0x91A260", VA = "0x18091B860", Slot = "6")]
		public virtual void UpdateUI()
		{
		}

		// Token: 0x06004A8A RID: 19082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A8A")]
		[Address(RVA = "0x91B550", Offset = "0x919F50", VA = "0x18091B550")]
		public void SetHighlighted(bool h)
		{
		}

		// Token: 0x06004A8B RID: 19083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A8B")]
		[Address(RVA = "0x91B640", Offset = "0x91A040", VA = "0x18091B640")]
		public void SetNormalColor(Color color)
		{
		}

		// Token: 0x06004A8C RID: 19084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A8C")]
		[Address(RVA = "0x91B480", Offset = "0x919E80", VA = "0x18091B480")]
		public void SetHighlightColor(Color color)
		{
		}

		// Token: 0x06004A8D RID: 19085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A8D")]
		[Address(RVA = "0x91B250", Offset = "0x919C50", VA = "0x18091B250")]
		private void Lock()
		{
		}

		// Token: 0x06004A8E RID: 19086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A8E")]
		[Address(RVA = "0x91B7B0", Offset = "0x91A1B0", VA = "0x18091B7B0")]
		private void Unlock()
		{
		}

		// Token: 0x06004A8F RID: 19087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A8F")]
		[Address(RVA = "0x91B600", Offset = "0x91A000", VA = "0x18091B600")]
		public void SetLockVisible(bool vis)
		{
		}

		// Token: 0x06004A90 RID: 19088 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A90")]
		[Address(RVA = "0x91B1A0", Offset = "0x919BA0", VA = "0x18091B1A0")]
		public RectTransform DuplicateIcon(Transform parent, int overriddenQuantity = -1)
		{
			return null;
		}

		// Token: 0x06004A91 RID: 19089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A91")]
		[Address(RVA = "0x91B710", Offset = "0x91A110", VA = "0x18091B710")]
		public void SetVisible(bool shown)
		{
		}

		// Token: 0x06004A92 RID: 19090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A92")]
		[Address(RVA = "0x91B3F0", Offset = "0x919DF0", VA = "0x18091B3F0")]
		public void OverrideDisplayedQuantity(int quantity)
		{
		}

		// Token: 0x06004A93 RID: 19091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A93")]
		[Address(RVA = "0x9152A0", Offset = "0x913CA0", VA = "0x1809152A0")]
		public ItemSlotUI()
		{
		}

		// Token: 0x04003572 RID: 13682
		[Token(Token = "0x4003572")]
		[FieldOffset(Offset = "0x20")]
		public Color32 normalColor;

		// Token: 0x04003573 RID: 13683
		[Token(Token = "0x4003573")]
		[FieldOffset(Offset = "0x24")]
		public Color32 highlightColor;

		// Token: 0x04003575 RID: 13685
		[Token(Token = "0x4003575")]
		[FieldOffset(Offset = "0x30")]
		[HideInInspector]
		public bool IsBeingDragged;

		// Token: 0x04003576 RID: 13686
		[Token(Token = "0x4003576")]
		[FieldOffset(Offset = "0x38")]
		[Header("References")]
		public RectTransform Rect;

		// Token: 0x04003577 RID: 13687
		[Token(Token = "0x4003577")]
		[FieldOffset(Offset = "0x40")]
		public Image Background;

		// Token: 0x04003578 RID: 13688
		[Token(Token = "0x4003578")]
		[FieldOffset(Offset = "0x48")]
		public GameObject LockContainer;

		// Token: 0x04003579 RID: 13689
		[Token(Token = "0x4003579")]
		[FieldOffset(Offset = "0x50")]
		public RectTransform ItemContainer;

		// Token: 0x0400357A RID: 13690
		[Token(Token = "0x400357A")]
		[FieldOffset(Offset = "0x58")]
		public ItemSlotFilterButton FilterButton;
	}
}
