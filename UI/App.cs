using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x02000AD4 RID: 2772
	[Token(Token = "0x2000AD4")]
	public abstract class App<T> : PlayerSingleton<T> where T : PlayerSingleton<T>
	{
		// Token: 0x06004B46 RID: 19270 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B46")]
		public static App<T> GetApp(int index)
		{
			return null;
		}

		// Token: 0x17000A91 RID: 2705
		// (get) Token: 0x06004B47 RID: 19271 RVA: 0x00013848 File Offset: 0x00011A48
		// (set) Token: 0x06004B48 RID: 19272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A91")]
		public bool isOpen
		{
			[Token(Token = "0x6004B47")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004B48")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06004B49 RID: 19273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B49")]
		public override void OnStartClient(bool IsOwner)
		{
		}

		// Token: 0x06004B4A RID: 19274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B4A")]
		protected override void Start()
		{
		}

		// Token: 0x06004B4B RID: 19275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B4B")]
		private void Close()
		{
		}

		// Token: 0x06004B4C RID: 19276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B4C")]
		protected virtual void Update()
		{
		}

		// Token: 0x06004B4D RID: 19277 RVA: 0x00013860 File Offset: 0x00011A60
		[Token(Token = "0x6004B4D")]
		private bool IsHoveringButton()
		{
			return default(bool);
		}

		// Token: 0x06004B4E RID: 19278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B4E")]
		private void GenerateHomeScreenIcon()
		{
		}

		// Token: 0x06004B4F RID: 19279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B4F")]
		public void SetNotificationCount(int amount)
		{
		}

		// Token: 0x06004B50 RID: 19280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B50")]
		protected virtual void OnPhoneOpened()
		{
		}

		// Token: 0x06004B51 RID: 19281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B51")]
		private void ShortcutClicked()
		{
		}

		// Token: 0x06004B52 RID: 19282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B52")]
		public virtual void Exit(ExitAction exit)
		{
		}

		// Token: 0x06004B53 RID: 19283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B53")]
		public virtual void SetOpen(bool open)
		{
		}

		// Token: 0x06004B54 RID: 19284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B54")]
		protected App()
		{
		}

		// Token: 0x0400364A RID: 13898
		[Token(Token = "0x400364A")]
		[FieldOffset(Offset = "0x0")]
		public static List<App<T>> Apps;

		// Token: 0x0400364B RID: 13899
		[Token(Token = "0x400364B")]
		[FieldOffset(Offset = "0x0")]
		[Header("Settings")]
		public string AppName;

		// Token: 0x0400364C RID: 13900
		[Token(Token = "0x400364C")]
		[FieldOffset(Offset = "0x0")]
		public string IconLabel;

		// Token: 0x0400364D RID: 13901
		[Token(Token = "0x400364D")]
		[FieldOffset(Offset = "0x0")]
		public Sprite AppIcon;

		// Token: 0x0400364E RID: 13902
		[Token(Token = "0x400364E")]
		[FieldOffset(Offset = "0x0")]
		public App<T>.EOrientation Orientation;

		// Token: 0x0400364F RID: 13903
		[Token(Token = "0x400364F")]
		[FieldOffset(Offset = "0x0")]
		public bool AvailableInTutorial;

		// Token: 0x04003650 RID: 13904
		[Token(Token = "0x4003650")]
		[FieldOffset(Offset = "0x0")]
		[Header("References")]
		[SerializeField]
		protected RectTransform appContainer;

		// Token: 0x04003651 RID: 13905
		[Token(Token = "0x4003651")]
		[FieldOffset(Offset = "0x0")]
		protected RectTransform notificationContainer;

		// Token: 0x04003652 RID: 13906
		[Token(Token = "0x4003652")]
		[FieldOffset(Offset = "0x0")]
		protected Text notificationText;

		// Token: 0x04003654 RID: 13908
		[Token(Token = "0x4003654")]
		[FieldOffset(Offset = "0x0")]
		protected Button appIconButton;

		// Token: 0x02000AD5 RID: 2773
		[Token(Token = "0x2000AD5")]
		public enum EOrientation
		{
			// Token: 0x04003656 RID: 13910
			[Token(Token = "0x4003656")]
			Horizontal,
			// Token: 0x04003657 RID: 13911
			[Token(Token = "0x4003657")]
			Vertical
		}
	}
}
