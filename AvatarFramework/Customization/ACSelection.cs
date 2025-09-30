using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.AvatarFramework.Customization
{
	// Token: 0x02000A57 RID: 2647
	[Token(Token = "0x2000A57")]
	public abstract class ACSelection<T> : MonoBehaviour where T : global::UnityEngine.Object
	{
		// Token: 0x0600483D RID: 18493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600483D")]
		protected virtual void Awake()
		{
		}

		// Token: 0x0600483E RID: 18494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600483E")]
		public void SelectOption(int index, bool notify = true)
		{
		}

		// Token: 0x0600483F RID: 18495
		[Token(Token = "0x600483F")]
		public abstract void CallValueChange();

		// Token: 0x06004840 RID: 18496
		[Token(Token = "0x6004840")]
		public abstract string GetOptionLabel(int index);

		// Token: 0x06004841 RID: 18497
		[Token(Token = "0x6004841")]
		public abstract int GetAssetPathIndex(string path);

		// Token: 0x06004842 RID: 18498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004842")]
		private void SetButtonHighlighted(int buttonIndex, bool h)
		{
		}

		// Token: 0x06004843 RID: 18499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004843")]
		protected ACSelection()
		{
		}

		// Token: 0x0400332F RID: 13103
		[Token(Token = "0x400332F")]
		[FieldOffset(Offset = "0x0")]
		[Header("References")]
		public GameObject ButtonPrefab;

		// Token: 0x04003330 RID: 13104
		[Token(Token = "0x4003330")]
		[FieldOffset(Offset = "0x0")]
		[Header("Settings")]
		public int PropertyIndex;

		// Token: 0x04003331 RID: 13105
		[Token(Token = "0x4003331")]
		[FieldOffset(Offset = "0x0")]
		public List<T> Options;

		// Token: 0x04003332 RID: 13106
		[Token(Token = "0x4003332")]
		[FieldOffset(Offset = "0x0")]
		public bool Nullable;

		// Token: 0x04003333 RID: 13107
		[Token(Token = "0x4003333")]
		[FieldOffset(Offset = "0x0")]
		public int DefaultOptionIndex;

		// Token: 0x04003334 RID: 13108
		[Token(Token = "0x4003334")]
		[FieldOffset(Offset = "0x0")]
		protected List<GameObject> buttons;

		// Token: 0x04003335 RID: 13109
		[Token(Token = "0x4003335")]
		[FieldOffset(Offset = "0x0")]
		protected int SelectedOptionIndex;

		// Token: 0x04003336 RID: 13110
		[Token(Token = "0x4003336")]
		[FieldOffset(Offset = "0x0")]
		public UnityEvent<T> onValueChange;

		// Token: 0x04003337 RID: 13111
		[Token(Token = "0x4003337")]
		[FieldOffset(Offset = "0x0")]
		public UnityEvent<T, int> onValueChangeWithIndex;
	}
}
