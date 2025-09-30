using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EasyButtons;
using Il2CppDummyDll;
using ScheduleOne.AvatarFramework.Customization;
using ScheduleOne.Clothing;
using ScheduleOne.DevUtilities;
using ScheduleOne.Property;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.Intro
{
	// Token: 0x02000575 RID: 1397
	[Token(Token = "0x2000575")]
	public class IntroManager : Singleton<IntroManager>
	{
		// Token: 0x17000567 RID: 1383
		// (get) Token: 0x06001F57 RID: 8023 RVA: 0x0000A3F8 File Offset: 0x000085F8
		// (set) Token: 0x06001F58 RID: 8024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000567")]
		public bool IsPlaying
		{
			[Token(Token = "0x6001F57")]
			[Address(RVA = "0x4B7C30", Offset = "0x4B6630", VA = "0x1804B7C30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001F58")]
			[Address(RVA = "0x4B7C40", Offset = "0x4B6640", VA = "0x1804B7C40")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06001F59 RID: 8025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F59")]
		[Address(RVA = "0x675C00", Offset = "0x674600", VA = "0x180675C00", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x06001F5A RID: 8026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F5A")]
		[Address(RVA = "0x6764D0", Offset = "0x674ED0", VA = "0x1806764D0")]
		private void Update()
		{
		}

		// Token: 0x06001F5B RID: 8027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F5B")]
		[Address(RVA = "0x675E80", Offset = "0x674880", VA = "0x180675E80")]
		[Button]
		public void Play()
		{
		}

		// Token: 0x06001F5C RID: 8028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F5C")]
		[Address(RVA = "0x675D60", Offset = "0x674760", VA = "0x180675D60")]
		private void PlayMusic()
		{
		}

		// Token: 0x06001F5D RID: 8029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F5D")]
		[Address(RVA = "0x675C70", Offset = "0x674670", VA = "0x180675C70")]
		public void CharacterCreationDone(BasicAvatarSettings avatar, List<ClothingInstance> clothes)
		{
		}

		// Token: 0x06001F5E RID: 8030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F5E")]
		[Address(RVA = "0x673170", Offset = "0x671B70", VA = "0x180673170")]
		public void PassedStep(int stepIndex)
		{
		}

		// Token: 0x06001F5F RID: 8031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F5F")]
		[Address(RVA = "0x6767B0", Offset = "0x6751B0", VA = "0x1806767B0")]
		public IntroManager()
		{
		}

		// Token: 0x06001F60 RID: 8032 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F60")]
		[Address(RVA = "0x676460", Offset = "0x674E60", VA = "0x180676460")]
		[CompilerGenerated]
		private IEnumerator <Play>g__Wait|23_0()
		{
			return null;
		}

		// Token: 0x040019A2 RID: 6562
		[Token(Token = "0x40019A2")]
		public const float SKIP_TIME = 0.5f;

		// Token: 0x040019A4 RID: 6564
		[Token(Token = "0x40019A4")]
		[FieldOffset(Offset = "0x2C")]
		public int CurrentStep;

		// Token: 0x040019A5 RID: 6565
		[Token(Token = "0x40019A5")]
		[FieldOffset(Offset = "0x30")]
		[Header("Settings")]
		public int TimeOfDayOverride;

		// Token: 0x040019A6 RID: 6566
		[Token(Token = "0x40019A6")]
		[FieldOffset(Offset = "0x38")]
		[Header("References")]
		public GameObject Container;

		// Token: 0x040019A7 RID: 6567
		[Token(Token = "0x40019A7")]
		[FieldOffset(Offset = "0x40")]
		public Transform PlayerInitialPosition;

		// Token: 0x040019A8 RID: 6568
		[Token(Token = "0x40019A8")]
		[FieldOffset(Offset = "0x48")]
		public Transform PlayerInitialPosition_AfterRVExplosion;

		// Token: 0x040019A9 RID: 6569
		[Token(Token = "0x40019A9")]
		[FieldOffset(Offset = "0x50")]
		public Transform CameraContainer;

		// Token: 0x040019AA RID: 6570
		[Token(Token = "0x40019AA")]
		[FieldOffset(Offset = "0x58")]
		public Animation Anim;

		// Token: 0x040019AB RID: 6571
		[Token(Token = "0x40019AB")]
		[FieldOffset(Offset = "0x60")]
		public GameObject SkipContainer;

		// Token: 0x040019AC RID: 6572
		[Token(Token = "0x40019AC")]
		[FieldOffset(Offset = "0x68")]
		public Image SkipDial;

		// Token: 0x040019AD RID: 6573
		[Token(Token = "0x40019AD")]
		[FieldOffset(Offset = "0x70")]
		public GameObject[] DisableDuringIntro;

		// Token: 0x040019AE RID: 6574
		[Token(Token = "0x40019AE")]
		[FieldOffset(Offset = "0x78")]
		public RV rv;

		// Token: 0x040019AF RID: 6575
		[Token(Token = "0x40019AF")]
		[FieldOffset(Offset = "0x80")]
		public UnityEvent onIntroDone;

		// Token: 0x040019B0 RID: 6576
		[Token(Token = "0x40019B0")]
		[FieldOffset(Offset = "0x88")]
		public UnityEvent onIntroDoneAsServer;

		// Token: 0x040019B1 RID: 6577
		[Token(Token = "0x40019B1")]
		[FieldOffset(Offset = "0x90")]
		public string MusicName;

		// Token: 0x040019B2 RID: 6578
		[Token(Token = "0x40019B2")]
		[FieldOffset(Offset = "0x98")]
		private float currentSkipTime;

		// Token: 0x040019B3 RID: 6579
		[Token(Token = "0x40019B3")]
		[FieldOffset(Offset = "0x9C")]
		private bool depressed;
	}
}
