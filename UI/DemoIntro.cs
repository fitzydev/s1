using System;
using System.Collections;
using System.Runtime.CompilerServices;
using EasyButtons;
using Il2CppDummyDll;
using ScheduleOne.AvatarFramework.Customization;
using ScheduleOne.DevUtilities;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x02000A90 RID: 2704
	[Token(Token = "0x2000A90")]
	public class DemoIntro : Singleton<DemoIntro>
	{
		// Token: 0x17000A52 RID: 2642
		// (get) Token: 0x0600498C RID: 18828 RVA: 0x00013350 File Offset: 0x00011550
		// (set) Token: 0x0600498D RID: 18829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A52")]
		public bool IsPlaying
		{
			[Token(Token = "0x600498C")]
			[Address(RVA = "0x4B7C30", Offset = "0x4B6630", VA = "0x1804B7C30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600498D")]
			[Address(RVA = "0x4B7C40", Offset = "0x4B6640", VA = "0x1804B7C40")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x0600498E RID: 18830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600498E")]
		[Address(RVA = "0x90A030", Offset = "0x908A30", VA = "0x18090A030")]
		private void Update()
		{
		}

		// Token: 0x0600498F RID: 18831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600498F")]
		[Address(RVA = "0x909C30", Offset = "0x908630", VA = "0x180909C30")]
		[Button]
		public void Play()
		{
		}

		// Token: 0x06004990 RID: 18832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004990")]
		[Address(RVA = "0x909B10", Offset = "0x908510", VA = "0x180909B10")]
		private void PlayMusic()
		{
		}

		// Token: 0x06004991 RID: 18833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004991")]
		[Address(RVA = "0x909EC0", Offset = "0x9088C0", VA = "0x180909EC0")]
		public void ShowAvatar()
		{
		}

		// Token: 0x06004992 RID: 18834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004992")]
		[Address(RVA = "0x9099A0", Offset = "0x9083A0", VA = "0x1809099A0")]
		public void CutsceneDone()
		{
		}

		// Token: 0x06004993 RID: 18835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004993")]
		[Address(RVA = "0x4FAD10", Offset = "0x4F9710", VA = "0x1804FAD10")]
		public void PassedStep(int stepIndex)
		{
		}

		// Token: 0x06004994 RID: 18836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004994")]
		[Address(RVA = "0x909920", Offset = "0x908320", VA = "0x180909920")]
		public void CharacterCreationDone(BasicAvatarSettings avatar)
		{
		}

		// Token: 0x06004995 RID: 18837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004995")]
		[Address(RVA = "0x90A4A0", Offset = "0x908EA0", VA = "0x18090A4A0")]
		public DemoIntro()
		{
		}

		// Token: 0x06004997 RID: 18839 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004997")]
		[Address(RVA = "0x909F90", Offset = "0x908990", VA = "0x180909F90")]
		[CompilerGenerated]
		private IEnumerator <CharacterCreationDone>g__Wait|26_0()
		{
			return null;
		}

		// Token: 0x0400345F RID: 13407
		[Token(Token = "0x400345F")]
		public const float SKIP_TIME = 0.5f;

		// Token: 0x04003461 RID: 13409
		[Token(Token = "0x4003461")]
		[FieldOffset(Offset = "0x30")]
		public Animation Anim;

		// Token: 0x04003462 RID: 13410
		[Token(Token = "0x4003462")]
		[FieldOffset(Offset = "0x38")]
		public Transform PlayerInitialPosition;

		// Token: 0x04003463 RID: 13411
		[Token(Token = "0x4003463")]
		[FieldOffset(Offset = "0x40")]
		public GameObject SkipContainer;

		// Token: 0x04003464 RID: 13412
		[Token(Token = "0x4003464")]
		[FieldOffset(Offset = "0x48")]
		public Image SkipDial;

		// Token: 0x04003465 RID: 13413
		[Token(Token = "0x4003465")]
		[FieldOffset(Offset = "0x50")]
		public int SkipEvents;

		// Token: 0x04003466 RID: 13414
		[Token(Token = "0x4003466")]
		[FieldOffset(Offset = "0x58")]
		public UnityEvent onStart;

		// Token: 0x04003467 RID: 13415
		[Token(Token = "0x4003467")]
		[FieldOffset(Offset = "0x60")]
		public UnityEvent onStartAsServer;

		// Token: 0x04003468 RID: 13416
		[Token(Token = "0x4003468")]
		[FieldOffset(Offset = "0x68")]
		public UnityEvent onCutsceneDone;

		// Token: 0x04003469 RID: 13417
		[Token(Token = "0x4003469")]
		[FieldOffset(Offset = "0x70")]
		public UnityEvent onIntroDone;

		// Token: 0x0400346A RID: 13418
		[Token(Token = "0x400346A")]
		[FieldOffset(Offset = "0x78")]
		public UnityEvent onIntroDoneAsServer;

		// Token: 0x0400346B RID: 13419
		[Token(Token = "0x400346B")]
		[FieldOffset(Offset = "0x80")]
		private int CurrentStep;

		// Token: 0x0400346C RID: 13420
		[Token(Token = "0x400346C")]
		[FieldOffset(Offset = "0x88")]
		public string MusicName;

		// Token: 0x0400346D RID: 13421
		[Token(Token = "0x400346D")]
		[FieldOffset(Offset = "0x90")]
		private float currentSkipTime;

		// Token: 0x0400346E RID: 13422
		[Token(Token = "0x400346E")]
		[FieldOffset(Offset = "0x94")]
		private bool depressed;

		// Token: 0x0400346F RID: 13423
		[Token(Token = "0x400346F")]
		[FieldOffset(Offset = "0x95")]
		private bool waitingForCutsceneEnd;
	}
}
