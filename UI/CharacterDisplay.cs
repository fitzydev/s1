using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.AvatarFramework;
using ScheduleOne.Clothing;
using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.UI
{
	// Token: 0x02000A80 RID: 2688
	[Token(Token = "0x2000A80")]
	public class CharacterDisplay : Singleton<CharacterDisplay>
	{
		// Token: 0x17000A40 RID: 2624
		// (get) Token: 0x0600490E RID: 18702 RVA: 0x000131A0 File Offset: 0x000113A0
		// (set) Token: 0x0600490F RID: 18703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A40")]
		public bool IsOpen
		{
			[Token(Token = "0x600490E")]
			[Address(RVA = "0x4B7C30", Offset = "0x4B6630", VA = "0x1804B7C30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600490F")]
			[Address(RVA = "0x4B7C40", Offset = "0x4B6640", VA = "0x1804B7C40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06004910 RID: 18704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004910")]
		[Address(RVA = "0x901720", Offset = "0x900120", VA = "0x180901720", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x06004911 RID: 18705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004911")]
		[Address(RVA = "0x901A90", Offset = "0x900490", VA = "0x180901A90")]
		public void SetOpen(bool open)
		{
		}

		// Token: 0x06004912 RID: 18706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004912")]
		[Address(RVA = "0x901C90", Offset = "0x900690", VA = "0x180901C90")]
		private void Update()
		{
		}

		// Token: 0x06004913 RID: 18707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004913")]
		[Address(RVA = "0x9018B0", Offset = "0x9002B0", VA = "0x1809018B0")]
		public void SetAppearance(AvatarSettings settings)
		{
		}

		// Token: 0x06004914 RID: 18708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004914")]
		[Address(RVA = "0x901E10", Offset = "0x900810", VA = "0x180901E10")]
		public CharacterDisplay()
		{
		}

		// Token: 0x04003401 RID: 13313
		[Token(Token = "0x4003401")]
		[FieldOffset(Offset = "0x30")]
		public CharacterDisplay.SlotAlignmentPoint[] AlignmentPoints;

		// Token: 0x04003402 RID: 13314
		[Token(Token = "0x4003402")]
		[FieldOffset(Offset = "0x38")]
		[Header("References")]
		public Transform Container;

		// Token: 0x04003403 RID: 13315
		[Token(Token = "0x4003403")]
		[FieldOffset(Offset = "0x40")]
		public ScheduleOne.AvatarFramework.Avatar ParentAvatar;

		// Token: 0x04003404 RID: 13316
		[Token(Token = "0x4003404")]
		[FieldOffset(Offset = "0x48")]
		public ScheduleOne.AvatarFramework.Avatar Avatar;

		// Token: 0x04003405 RID: 13317
		[Token(Token = "0x4003405")]
		[FieldOffset(Offset = "0x50")]
		public Transform AvatarContainer;

		// Token: 0x04003406 RID: 13318
		[Token(Token = "0x4003406")]
		[FieldOffset(Offset = "0x58")]
		private float targetRotation;

		// Token: 0x02000A81 RID: 2689
		[Token(Token = "0x2000A81")]
		[Serializable]
		public class SlotAlignmentPoint
		{
			// Token: 0x06004916 RID: 18710 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004916")]
			[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
			public SlotAlignmentPoint()
			{
			}

			// Token: 0x04003407 RID: 13319
			[Token(Token = "0x4003407")]
			[FieldOffset(Offset = "0x10")]
			public EClothingSlot SlotType;

			// Token: 0x04003408 RID: 13320
			[Token(Token = "0x4003408")]
			[FieldOffset(Offset = "0x18")]
			public Transform Point;
		}
	}
}
