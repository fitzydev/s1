using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.UI;
using UnityEngine;

namespace ScheduleOne.TV
{
	// Token: 0x020002B3 RID: 691
	[Token(Token = "0x20002B3")]
	public class TVApp : MonoBehaviour
	{
		// Token: 0x17000319 RID: 793
		// (get) Token: 0x06000E71 RID: 3697 RVA: 0x00007230 File Offset: 0x00005430
		// (set) Token: 0x06000E72 RID: 3698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000319")]
		public bool IsOpen
		{
			[Token(Token = "0x6000E71")]
			[Address(RVA = "0x4B9020", Offset = "0x4B7A20", VA = "0x1804B9020")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000E72")]
			[Address(RVA = "0x4B9030", Offset = "0x4B7A30", VA = "0x1804B9030")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x06000E73 RID: 3699 RVA: 0x00007248 File Offset: 0x00005448
		[Token(Token = "0x1700031A")]
		public bool IsPaused
		{
			[Token(Token = "0x6000E73")]
			[Address(RVA = "0xAC6C90", Offset = "0xAC5690", VA = "0x180AC6C90")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000E74 RID: 3700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E74")]
		[Address(RVA = "0xAC6450", Offset = "0xAC4E50", VA = "0x180AC6450", Slot = "4")]
		protected virtual void Awake()
		{
		}

		// Token: 0x06000E75 RID: 3701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E75")]
		[Address(RVA = "0xAC6960", Offset = "0xAC5360", VA = "0x180AC6960")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000E76 RID: 3702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E76")]
		[Address(RVA = "0xAC69F0", Offset = "0xAC53F0", VA = "0x180AC69F0", Slot = "5")]
		public virtual void Open()
		{
		}

		// Token: 0x06000E77 RID: 3703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E77")]
		[Address(RVA = "0xAC6500", Offset = "0xAC4F00", VA = "0x180AC6500", Slot = "6")]
		public virtual void Close()
		{
		}

		// Token: 0x06000E78 RID: 3704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E78")]
		[Address(RVA = "0x42DA80", Offset = "0x42C480", VA = "0x18042DA80", Slot = "7")]
		public virtual void Resume()
		{
		}

		// Token: 0x06000E79 RID: 3705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E79")]
		[Address(RVA = "0xAC67E0", Offset = "0xAC51E0", VA = "0x180AC67E0")]
		private void Lerp(float endScale, float endAlpha)
		{
		}

		// Token: 0x06000E7A RID: 3706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E7A")]
		[Address(RVA = "0x42DA80", Offset = "0x42C480", VA = "0x18042DA80", Slot = "8")]
		protected virtual void ActiveMinPass()
		{
		}

		// Token: 0x06000E7B RID: 3707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E7B")]
		[Address(RVA = "0xAC66D0", Offset = "0xAC50D0", VA = "0x180AC66D0")]
		private void Exit(ExitAction action)
		{
		}

		// Token: 0x06000E7C RID: 3708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E7C")]
		[Address(RVA = "0xAC6BD0", Offset = "0xAC55D0", VA = "0x180AC6BD0", Slot = "9")]
		protected virtual void TryPause()
		{
		}

		// Token: 0x06000E7D RID: 3709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E7D")]
		[Address(RVA = "0xAC6C80", Offset = "0xAC5680", VA = "0x180AC6C80")]
		public TVApp()
		{
		}

		// Token: 0x06000E7E RID: 3710 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E7E")]
		[Address(RVA = "0xAC6BF0", Offset = "0xAC55F0", VA = "0x180AC6BF0")]
		[CompilerGenerated]
		private IEnumerator <Lerp>g__Lerp|23_0(float endScale, float endAlpha)
		{
			return null;
		}

		// Token: 0x04000EC3 RID: 3779
		[Token(Token = "0x4000EC3")]
		public const float SCALE_MIN = 0.67f;

		// Token: 0x04000EC4 RID: 3780
		[Token(Token = "0x4000EC4")]
		public const float SCALE_MAX = 1.5f;

		// Token: 0x04000EC5 RID: 3781
		[Token(Token = "0x4000EC5")]
		public const float LERP_TIME = 0.12f;

		// Token: 0x04000EC7 RID: 3783
		[Token(Token = "0x4000EC7")]
		[FieldOffset(Offset = "0x21")]
		[Header("Settings")]
		public bool CanClose;

		// Token: 0x04000EC8 RID: 3784
		[Token(Token = "0x4000EC8")]
		[FieldOffset(Offset = "0x28")]
		public string AppName;

		// Token: 0x04000EC9 RID: 3785
		[Token(Token = "0x4000EC9")]
		[FieldOffset(Offset = "0x30")]
		public Sprite Icon;

		// Token: 0x04000ECA RID: 3786
		[Token(Token = "0x4000ECA")]
		[FieldOffset(Offset = "0x38")]
		public bool Pauseable;

		// Token: 0x04000ECB RID: 3787
		[Token(Token = "0x4000ECB")]
		[FieldOffset(Offset = "0x40")]
		[Header("References")]
		public Canvas Canvas;

		// Token: 0x04000ECC RID: 3788
		[Token(Token = "0x4000ECC")]
		[FieldOffset(Offset = "0x48")]
		[HideInInspector]
		public TVApp PreviousScreen;

		// Token: 0x04000ECD RID: 3789
		[Token(Token = "0x4000ECD")]
		[FieldOffset(Offset = "0x50")]
		public CanvasGroup CanvasGroup;

		// Token: 0x04000ECE RID: 3790
		[Token(Token = "0x4000ECE")]
		[FieldOffset(Offset = "0x58")]
		public TVPauseScreen PauseScreen;

		// Token: 0x04000ECF RID: 3791
		[Token(Token = "0x4000ECF")]
		[FieldOffset(Offset = "0x60")]
		private Coroutine lerpCoroutine;
	}
}
