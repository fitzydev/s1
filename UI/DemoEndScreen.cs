using System;
using System.Runtime.CompilerServices;
using EasyButtons;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.UI
{
	// Token: 0x02000A8F RID: 2703
	[Token(Token = "0x2000A8F")]
	public class DemoEndScreen : MonoBehaviour
	{
		// Token: 0x17000A51 RID: 2641
		// (get) Token: 0x06004982 RID: 18818 RVA: 0x00013338 File Offset: 0x00011538
		// (set) Token: 0x06004983 RID: 18819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A51")]
		public bool IsOpen
		{
			[Token(Token = "0x6004982")]
			[Address(RVA = "0x4B9020", Offset = "0x4B7A20", VA = "0x1804B9020")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004983")]
			[Address(RVA = "0x4B9030", Offset = "0x4B7A30", VA = "0x1804B9030")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06004984 RID: 18820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004984")]
		[Address(RVA = "0x909350", Offset = "0x907D50", VA = "0x180909350")]
		public void Awake()
		{
		}

		// Token: 0x06004985 RID: 18821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004985")]
		[Address(RVA = "0x909800", Offset = "0x908200", VA = "0x180909800")]
		private void OnDestroy()
		{
		}

		// Token: 0x06004986 RID: 18822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004986")]
		[Address(RVA = "0x42DA80", Offset = "0x42C480", VA = "0x18042DA80")]
		[Button]
		public void Open()
		{
		}

		// Token: 0x06004987 RID: 18823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004987")]
		[Address(RVA = "0x909890", Offset = "0x908290", VA = "0x180909890")]
		private void Update()
		{
		}

		// Token: 0x06004988 RID: 18824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004988")]
		[Address(RVA = "0x909420", Offset = "0x907E20", VA = "0x180909420")]
		public void Close()
		{
		}

		// Token: 0x06004989 RID: 18825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004989")]
		[Address(RVA = "0x909780", Offset = "0x908180", VA = "0x180909780")]
		private void Exit(ExitAction action)
		{
		}

		// Token: 0x0600498A RID: 18826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600498A")]
		[Address(RVA = "0x9097D0", Offset = "0x9081D0", VA = "0x1809097D0")]
		public void LinkClicked()
		{
		}

		// Token: 0x0600498B RID: 18827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600498B")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public DemoEndScreen()
		{
		}

		// Token: 0x0400345D RID: 13405
		[Token(Token = "0x400345D")]
		[FieldOffset(Offset = "0x28")]
		[Header("References")]
		public Canvas Canvas;

		// Token: 0x0400345E RID: 13406
		[Token(Token = "0x400345E")]
		[FieldOffset(Offset = "0x30")]
		public RectTransform Container;
	}
}
