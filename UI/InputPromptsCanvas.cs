using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.UI
{
	// Token: 0x02000AB2 RID: 2738
	[Token(Token = "0x2000AB2")]
	public class InputPromptsCanvas : Singleton<InputPromptsCanvas>
	{
		// Token: 0x17000A72 RID: 2674
		// (get) Token: 0x06004A68 RID: 19048 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004A69 RID: 19049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A72")]
		public string currentModuleLabel
		{
			[Token(Token = "0x6004A68")]
			[Address(RVA = "0x4423B0", Offset = "0x440DB0", VA = "0x1804423B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004A69")]
			[Address(RVA = "0x4423E0", Offset = "0x440DE0", VA = "0x1804423E0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000A73 RID: 2675
		// (get) Token: 0x06004A6A RID: 19050 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004A6B RID: 19051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A73")]
		public RectTransform currentModule
		{
			[Token(Token = "0x6004A6A")]
			[Address(RVA = "0x47D770", Offset = "0x47C170", VA = "0x18047D770")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004A6B")]
			[Address(RVA = "0x4F8890", Offset = "0x4F7290", VA = "0x1804F8890")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06004A6C RID: 19052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A6C")]
		[Address(RVA = "0x919BC0", Offset = "0x9185C0", VA = "0x180919BC0")]
		public void LoadModule(string key)
		{
		}

		// Token: 0x06004A6D RID: 19053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A6D")]
		[Address(RVA = "0x919E00", Offset = "0x918800", VA = "0x180919E00")]
		public void UnloadModule()
		{
		}

		// Token: 0x06004A6E RID: 19054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A6E")]
		[Address(RVA = "0x919EC0", Offset = "0x9188C0", VA = "0x180919EC0")]
		public InputPromptsCanvas()
		{
		}

		// Token: 0x0400354C RID: 13644
		[Token(Token = "0x400354C")]
		[FieldOffset(Offset = "0x28")]
		public RectTransform InputPromptsContainer;

		// Token: 0x0400354D RID: 13645
		[Token(Token = "0x400354D")]
		[FieldOffset(Offset = "0x30")]
		[Header("Input prompt modules")]
		public List<InputPromptsCanvas.Module> Modules;

		// Token: 0x02000AB3 RID: 2739
		[Token(Token = "0x2000AB3")]
		[Serializable]
		public class Module
		{
			// Token: 0x06004A6F RID: 19055 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004A6F")]
			[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
			public Module()
			{
			}

			// Token: 0x04003550 RID: 13648
			[Token(Token = "0x4003550")]
			[FieldOffset(Offset = "0x10")]
			public string key;

			// Token: 0x04003551 RID: 13649
			[Token(Token = "0x4003551")]
			[FieldOffset(Offset = "0x18")]
			public GameObject module;
		}
	}
}
