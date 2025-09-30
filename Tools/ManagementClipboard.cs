using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.Management;
using ScheduleOne.UI.Management;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Tools
{
	// Token: 0x020008DD RID: 2269
	[Token(Token = "0x20008DD")]
	public class ManagementClipboard : Singleton<ManagementClipboard>
	{
		// Token: 0x170008E7 RID: 2279
		// (get) Token: 0x06003F0B RID: 16139 RVA: 0x00010D88 File Offset: 0x0000EF88
		// (set) Token: 0x06003F0C RID: 16140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170008E7")]
		public bool IsOpen
		{
			[Token(Token = "0x6003F0B")]
			[Address(RVA = "0x5CD9E0", Offset = "0x5CC3E0", VA = "0x1805CD9E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003F0C")]
			[Address(RVA = "0x5CD9F0", Offset = "0x5CC3F0", VA = "0x1805CD9F0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170008E8 RID: 2280
		// (get) Token: 0x06003F0D RID: 16141 RVA: 0x00010DA0 File Offset: 0x0000EFA0
		// (set) Token: 0x06003F0E RID: 16142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170008E8")]
		public bool StatePreserved
		{
			[Token(Token = "0x6003F0D")]
			[Address(RVA = "0x8679C0", Offset = "0x8663C0", VA = "0x1808679C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003F0E")]
			[Address(RVA = "0x8679D0", Offset = "0x8663D0", VA = "0x1808679D0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06003F0F RID: 16143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F0F")]
		[Address(RVA = "0x865BB0", Offset = "0x8645B0", VA = "0x180865BB0", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x06003F10 RID: 16144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F10")]
		[Address(RVA = "0x8677C0", Offset = "0x8661C0", VA = "0x1808677C0")]
		private void Update()
		{
		}

		// Token: 0x06003F11 RID: 16145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F11")]
		[Address(RVA = "0x867010", Offset = "0x865A10", VA = "0x180867010")]
		private void Exit(ExitAction exitAction)
		{
		}

		// Token: 0x06003F12 RID: 16146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F12")]
		[Address(RVA = "0x867210", Offset = "0x865C10", VA = "0x180867210")]
		public void Open(List<IConfigurable> selection, ManagementClipboard_Equippable equippable)
		{
		}

		// Token: 0x06003F13 RID: 16147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F13")]
		[Address(RVA = "0x865D10", Offset = "0x864710", VA = "0x180865D10")]
		public void Close(bool preserveState = false)
		{
		}

		// Token: 0x06003F14 RID: 16148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F14")]
		[Address(RVA = "0x867060", Offset = "0x865A60", VA = "0x180867060")]
		private void LerpToVerticalPosition(bool open, Action callback)
		{
		}

		// Token: 0x06003F15 RID: 16149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F15")]
		[Address(RVA = "0x867920", Offset = "0x866320", VA = "0x180867920")]
		public ManagementClipboard()
		{
		}

		// Token: 0x06003F17 RID: 16151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F17")]
		[Address(RVA = "0x867700", Offset = "0x866100", VA = "0x180867700")]
		[CompilerGenerated]
		private void <Close>g__Done|25_1()
		{
		}

		// Token: 0x04002C12 RID: 11282
		[Token(Token = "0x4002C12")]
		[FieldOffset(Offset = "0x28")]
		public bool IsEquipped;

		// Token: 0x04002C15 RID: 11285
		[Token(Token = "0x4002C15")]
		public const float OpenTime = 0.06f;

		// Token: 0x04002C16 RID: 11286
		[Token(Token = "0x4002C16")]
		[FieldOffset(Offset = "0x30")]
		[Header("References")]
		public Transform ClipboardTransform;

		// Token: 0x04002C17 RID: 11287
		[Token(Token = "0x4002C17")]
		[FieldOffset(Offset = "0x38")]
		public Camera OverlayCamera;

		// Token: 0x04002C18 RID: 11288
		[Token(Token = "0x4002C18")]
		[FieldOffset(Offset = "0x40")]
		public Light OverlayLight;

		// Token: 0x04002C19 RID: 11289
		[Token(Token = "0x4002C19")]
		[FieldOffset(Offset = "0x48")]
		public SelectionInfoUI SelectionInfo;

		// Token: 0x04002C1A RID: 11290
		[Token(Token = "0x4002C1A")]
		[FieldOffset(Offset = "0x50")]
		[Header("Settings")]
		public float ClosedOffset;

		// Token: 0x04002C1B RID: 11291
		[Token(Token = "0x4002C1B")]
		[FieldOffset(Offset = "0x58")]
		public UnityEvent onClipboardEquipped;

		// Token: 0x04002C1C RID: 11292
		[Token(Token = "0x4002C1C")]
		[FieldOffset(Offset = "0x60")]
		public UnityEvent onClipboardUnequipped;

		// Token: 0x04002C1D RID: 11293
		[Token(Token = "0x4002C1D")]
		[FieldOffset(Offset = "0x68")]
		public UnityEvent onOpened;

		// Token: 0x04002C1E RID: 11294
		[Token(Token = "0x4002C1E")]
		[FieldOffset(Offset = "0x70")]
		public UnityEvent onClosed;

		// Token: 0x04002C1F RID: 11295
		[Token(Token = "0x4002C1F")]
		[FieldOffset(Offset = "0x78")]
		private Coroutine lerpRoutine;

		// Token: 0x04002C20 RID: 11296
		[Token(Token = "0x4002C20")]
		[FieldOffset(Offset = "0x80")]
		private List<IConfigurable> CurrentConfigurables;
	}
}
