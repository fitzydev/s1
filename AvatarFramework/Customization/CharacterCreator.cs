using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Clothing;
using ScheduleOne.DevUtilities;
using ScheduleOne.UI.CharacterCreator;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.AvatarFramework.Customization
{
	// Token: 0x02000A5B RID: 2651
	[Token(Token = "0x2000A5B")]
	public class CharacterCreator : Singleton<CharacterCreator>
	{
		// Token: 0x17000A2B RID: 2603
		// (get) Token: 0x0600484F RID: 18511 RVA: 0x00012F90 File Offset: 0x00011190
		// (set) Token: 0x06004850 RID: 18512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A2B")]
		public bool IsOpen
		{
			[Token(Token = "0x600484F")]
			[Address(RVA = "0x4B7C30", Offset = "0x4B6630", VA = "0x1804B7C30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004850")]
			[Address(RVA = "0x4B7C40", Offset = "0x4B6640", VA = "0x1804B7C40")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000A2C RID: 2604
		// (get) Token: 0x06004851 RID: 18513 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004852 RID: 18514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A2C")]
		public BasicAvatarSettings ActiveSettings
		{
			[Token(Token = "0x6004851")]
			[Address(RVA = "0x4423B0", Offset = "0x440DB0", VA = "0x1804423B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004852")]
			[Address(RVA = "0x4423E0", Offset = "0x440DE0", VA = "0x1804423E0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06004853 RID: 18515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004853")]
		[Address(RVA = "0x900500", Offset = "0x8FEF00", VA = "0x180900500", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x06004854 RID: 18516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004854")]
		[Address(RVA = "0x901480", Offset = "0x8FFE80", VA = "0x180901480", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x06004855 RID: 18517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004855")]
		[Address(RVA = "0x901560", Offset = "0x8FFF60", VA = "0x180901560")]
		private void Update()
		{
		}

		// Token: 0x06004856 RID: 18518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004856")]
		[Address(RVA = "0x900A30", Offset = "0x8FF430", VA = "0x180900A30")]
		public void Open(BasicAvatarSettings initialSettings, bool showUI = true)
		{
		}

		// Token: 0x06004857 RID: 18519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004857")]
		[Address(RVA = "0x901330", Offset = "0x8FFD30", VA = "0x180901330")]
		public void ShowUI()
		{
		}

		// Token: 0x06004858 RID: 18520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004858")]
		[Address(RVA = "0x9005C0", Offset = "0x8FEFC0", VA = "0x1809005C0")]
		public void Close()
		{
		}

		// Token: 0x06004859 RID: 18521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004859")]
		[Address(RVA = "0x900640", Offset = "0x8FF040", VA = "0x180900640")]
		public void DisableStuff()
		{
		}

		// Token: 0x0600485A RID: 18522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600485A")]
		[Address(RVA = "0x900670", Offset = "0x8FF070", VA = "0x180900670")]
		public void Done()
		{
		}

		// Token: 0x0600485B RID: 18523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600485B")]
		[Address(RVA = "0x901460", Offset = "0x8FFE60", VA = "0x180901460")]
		public void SliderChanged(float newVal)
		{
		}

		// Token: 0x0600485C RID: 18524 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600485C")]
		public T SetValue<T>(string fieldName, T value, ClothingDefinition definition)
		{
			return null;
		}

		// Token: 0x0600485D RID: 18525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600485D")]
		[Address(RVA = "0x9010D0", Offset = "0x8FFAD0", VA = "0x1809010D0")]
		public void SelectPreset(string presetName)
		{
		}

		// Token: 0x0600485E RID: 18526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600485E")]
		[Address(RVA = "0x900F20", Offset = "0x8FF920", VA = "0x180900F20")]
		public void RefreshCategory(CharacterCreator.ECategory category)
		{
		}

		// Token: 0x0600485F RID: 18527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600485F")]
		[Address(RVA = "0x901640", Offset = "0x900040", VA = "0x180901640")]
		public CharacterCreator()
		{
		}

		// Token: 0x06004860 RID: 18528 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004860")]
		[Address(RVA = "0x9014F0", Offset = "0x8FFEF0", VA = "0x1809014F0")]
		[CompilerGenerated]
		private IEnumerator <Close>g__Close|28_0()
		{
			return null;
		}

		// Token: 0x0400335E RID: 13150
		[Token(Token = "0x400335E")]
		[FieldOffset(Offset = "0x30")]
		public List<BaseCharacterCreatorField> Fields;

		// Token: 0x04003360 RID: 13152
		[Token(Token = "0x4003360")]
		[FieldOffset(Offset = "0x40")]
		[Header("References")]
		public Transform Container;

		// Token: 0x04003361 RID: 13153
		[Token(Token = "0x4003361")]
		[FieldOffset(Offset = "0x48")]
		public Transform CameraPosition;

		// Token: 0x04003362 RID: 13154
		[Token(Token = "0x4003362")]
		[FieldOffset(Offset = "0x50")]
		public Transform RigContainer;

		// Token: 0x04003363 RID: 13155
		[Token(Token = "0x4003363")]
		[FieldOffset(Offset = "0x58")]
		public Avatar Rig;

		// Token: 0x04003364 RID: 13156
		[Token(Token = "0x4003364")]
		[FieldOffset(Offset = "0x60")]
		public Canvas Canvas;

		// Token: 0x04003365 RID: 13157
		[Token(Token = "0x4003365")]
		[FieldOffset(Offset = "0x68")]
		public Animation CanvasAnimation;

		// Token: 0x04003366 RID: 13158
		[Token(Token = "0x4003366")]
		[FieldOffset(Offset = "0x70")]
		[Header("Settings")]
		public bool DemoCreator;

		// Token: 0x04003367 RID: 13159
		[Token(Token = "0x4003367")]
		[FieldOffset(Offset = "0x78")]
		public BasicAvatarSettings DefaultSettings;

		// Token: 0x04003368 RID: 13160
		[Token(Token = "0x4003368")]
		[FieldOffset(Offset = "0x80")]
		public List<BasicAvatarSettings> Presets;

		// Token: 0x04003369 RID: 13161
		[Token(Token = "0x4003369")]
		[FieldOffset(Offset = "0x88")]
		public UnityEvent<BasicAvatarSettings> onComplete;

		// Token: 0x0400336A RID: 13162
		[Token(Token = "0x400336A")]
		[FieldOffset(Offset = "0x90")]
		public UnityEvent<BasicAvatarSettings, List<ClothingInstance>> onCompleteWithClothing;

		// Token: 0x0400336B RID: 13163
		[Token(Token = "0x400336B")]
		[FieldOffset(Offset = "0x98")]
		private Dictionary<string, ClothingDefinition> lastSelectedClothingDefinitions;

		// Token: 0x0400336C RID: 13164
		[Token(Token = "0x400336C")]
		[FieldOffset(Offset = "0xA0")]
		private float rigTargetY;

		// Token: 0x02000A5C RID: 2652
		[Token(Token = "0x2000A5C")]
		public enum ECategory
		{
			// Token: 0x0400336E RID: 13166
			[Token(Token = "0x400336E")]
			Body,
			// Token: 0x0400336F RID: 13167
			[Token(Token = "0x400336F")]
			Hair,
			// Token: 0x04003370 RID: 13168
			[Token(Token = "0x4003370")]
			Face,
			// Token: 0x04003371 RID: 13169
			[Token(Token = "0x4003371")]
			Eyes,
			// Token: 0x04003372 RID: 13170
			[Token(Token = "0x4003372")]
			Eyebrows,
			// Token: 0x04003373 RID: 13171
			[Token(Token = "0x4003373")]
			Clothing,
			// Token: 0x04003374 RID: 13172
			[Token(Token = "0x4003374")]
			Accessories
		}
	}
}
