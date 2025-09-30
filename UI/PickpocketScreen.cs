using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.NPCs;
using ScheduleOne.UI.Input;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x02000AD6 RID: 2774
	[Token(Token = "0x2000AD6")]
	public class PickpocketScreen : Singleton<PickpocketScreen>
	{
		// Token: 0x17000A92 RID: 2706
		// (get) Token: 0x06004B56 RID: 19286 RVA: 0x00013878 File Offset: 0x00011A78
		// (set) Token: 0x06004B57 RID: 19287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A92")]
		public bool IsOpen
		{
			[Token(Token = "0x6004B56")]
			[Address(RVA = "0x4B7C30", Offset = "0x4B6630", VA = "0x1804B7C30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004B57")]
			[Address(RVA = "0x4B7C40", Offset = "0x4B6640", VA = "0x1804B7C40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000A93 RID: 2707
		// (get) Token: 0x06004B58 RID: 19288 RVA: 0x00013890 File Offset: 0x00011A90
		// (set) Token: 0x06004B59 RID: 19289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A93")]
		public bool TutorialOpen
		{
			[Token(Token = "0x6004B58")]
			[Address(RVA = "0x5CD9E0", Offset = "0x5CC3E0", VA = "0x1805CD9E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004B59")]
			[Address(RVA = "0x5CD9F0", Offset = "0x5CC3F0", VA = "0x1805CD9F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06004B5A RID: 19290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B5A")]
		[Address(RVA = "0x926080", Offset = "0x924A80", VA = "0x180926080", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x06004B5B RID: 19291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B5B")]
		[Address(RVA = "0x926A70", Offset = "0x925470", VA = "0x180926A70")]
		public void Open(NPC _npc)
		{
		}

		// Token: 0x06004B5C RID: 19292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B5C")]
		[Address(RVA = "0x9266C0", Offset = "0x9250C0", VA = "0x1809266C0")]
		private void Exit(ExitAction action)
		{
		}

		// Token: 0x06004B5D RID: 19293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B5D")]
		[Address(RVA = "0x927AE0", Offset = "0x9264E0", VA = "0x180927AE0")]
		private void Update()
		{
		}

		// Token: 0x06004B5E RID: 19294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B5E")]
		[Address(RVA = "0x927740", Offset = "0x926140", VA = "0x180927740")]
		private void StopArrow()
		{
		}

		// Token: 0x06004B5F RID: 19295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B5F")]
		[Address(RVA = "0x927520", Offset = "0x925F20", VA = "0x180927520")]
		public void SetSlotLocked(int index, bool locked)
		{
		}

		// Token: 0x06004B60 RID: 19296 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B60")]
		[Address(RVA = "0x926880", Offset = "0x925280", VA = "0x180926880")]
		private ItemSlotUI GetHoveredSlot()
		{
			return null;
		}

		// Token: 0x06004B61 RID: 19297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B61")]
		[Address(RVA = "0x926710", Offset = "0x925110", VA = "0x180926710")]
		private void Fail()
		{
		}

		// Token: 0x06004B62 RID: 19298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B62")]
		[Address(RVA = "0x9261B0", Offset = "0x924BB0", VA = "0x1809261B0")]
		public void Close()
		{
		}

		// Token: 0x06004B63 RID: 19299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B63")]
		[Address(RVA = "0x926A20", Offset = "0x925420", VA = "0x180926A20")]
		private void OpenTutorial()
		{
		}

		// Token: 0x06004B64 RID: 19300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B64")]
		[Address(RVA = "0x926170", Offset = "0x924B70", VA = "0x180926170")]
		public void CloseTutorial()
		{
		}

		// Token: 0x06004B65 RID: 19301 RVA: 0x000138A8 File Offset: 0x00011AA8
		[Token(Token = "0x6004B65")]
		[Address(RVA = "0x9267A0", Offset = "0x9251A0", VA = "0x1809267A0")]
		private float GetGreenAreaNormalizedPosition(int index)
		{
			return 0f;
		}

		// Token: 0x06004B66 RID: 19302 RVA: 0x000138C0 File Offset: 0x00011AC0
		[Token(Token = "0x6004B66")]
		[Address(RVA = "0x926810", Offset = "0x925210", VA = "0x180926810")]
		private float GetGreenAreaNormalizedWidth(int index)
		{
			return 0f;
		}

		// Token: 0x06004B67 RID: 19303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B67")]
		[Address(RVA = "0x927DE0", Offset = "0x9267E0", VA = "0x180927DE0")]
		public PickpocketScreen()
		{
		}

		// Token: 0x06004B68 RID: 19304 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B68")]
		[Address(RVA = "0x927A70", Offset = "0x926470", VA = "0x180927A70")]
		[CompilerGenerated]
		private IEnumerator <Fail>g__FailCoroutine|41_0()
		{
			return null;
		}

		// Token: 0x04003658 RID: 13912
		[Token(Token = "0x4003658")]
		public const int PICKPOCKET_XP = 2;

		// Token: 0x0400365B RID: 13915
		[Token(Token = "0x400365B")]
		[FieldOffset(Offset = "0x2C")]
		[Header("Settings")]
		public float GreenAreaMaxWidth;

		// Token: 0x0400365C RID: 13916
		[Token(Token = "0x400365C")]
		[FieldOffset(Offset = "0x30")]
		public float GreenAreaMinWidth;

		// Token: 0x0400365D RID: 13917
		[Token(Token = "0x400365D")]
		[FieldOffset(Offset = "0x34")]
		public float SlideTime;

		// Token: 0x0400365E RID: 13918
		[Token(Token = "0x400365E")]
		[FieldOffset(Offset = "0x38")]
		public float SlideTimeMaxMultiplier;

		// Token: 0x0400365F RID: 13919
		[Token(Token = "0x400365F")]
		[FieldOffset(Offset = "0x3C")]
		public float ValueDivisor;

		// Token: 0x04003660 RID: 13920
		[Token(Token = "0x4003660")]
		[FieldOffset(Offset = "0x40")]
		public float Tolerance;

		// Token: 0x04003661 RID: 13921
		[Token(Token = "0x4003661")]
		[FieldOffset(Offset = "0x48")]
		[Header("References")]
		public Canvas Canvas;

		// Token: 0x04003662 RID: 13922
		[Token(Token = "0x4003662")]
		[FieldOffset(Offset = "0x50")]
		public RectTransform Container;

		// Token: 0x04003663 RID: 13923
		[Token(Token = "0x4003663")]
		[FieldOffset(Offset = "0x58")]
		public ItemSlotUI[] Slots;

		// Token: 0x04003664 RID: 13924
		[Token(Token = "0x4003664")]
		[FieldOffset(Offset = "0x60")]
		public RectTransform[] GreenAreas;

		// Token: 0x04003665 RID: 13925
		[Token(Token = "0x4003665")]
		[FieldOffset(Offset = "0x68")]
		public Animation TutorialAnimation;

		// Token: 0x04003666 RID: 13926
		[Token(Token = "0x4003666")]
		[FieldOffset(Offset = "0x70")]
		public RectTransform TutorialContainer;

		// Token: 0x04003667 RID: 13927
		[Token(Token = "0x4003667")]
		[FieldOffset(Offset = "0x78")]
		public RectTransform SliderContainer;

		// Token: 0x04003668 RID: 13928
		[Token(Token = "0x4003668")]
		[FieldOffset(Offset = "0x80")]
		public Slider Slider;

		// Token: 0x04003669 RID: 13929
		[Token(Token = "0x4003669")]
		[FieldOffset(Offset = "0x88")]
		public InputPrompt InputPrompt;

		// Token: 0x0400366A RID: 13930
		[Token(Token = "0x400366A")]
		[FieldOffset(Offset = "0x90")]
		public RectTransform ActionsContainer;

		// Token: 0x0400366B RID: 13931
		[Token(Token = "0x400366B")]
		[FieldOffset(Offset = "0x98")]
		public UnityEvent onFail;

		// Token: 0x0400366C RID: 13932
		[Token(Token = "0x400366C")]
		[FieldOffset(Offset = "0xA0")]
		public UnityEvent onStop;

		// Token: 0x0400366D RID: 13933
		[Token(Token = "0x400366D")]
		[FieldOffset(Offset = "0xA8")]
		public UnityEvent onHitGreen;

		// Token: 0x0400366E RID: 13934
		[Token(Token = "0x400366E")]
		[FieldOffset(Offset = "0xB0")]
		private NPC npc;

		// Token: 0x0400366F RID: 13935
		[Token(Token = "0x400366F")]
		[FieldOffset(Offset = "0xB8")]
		private bool isSliding;

		// Token: 0x04003670 RID: 13936
		[Token(Token = "0x4003670")]
		[FieldOffset(Offset = "0xBC")]
		private int slideDirection;

		// Token: 0x04003671 RID: 13937
		[Token(Token = "0x4003671")]
		[FieldOffset(Offset = "0xC0")]
		private float sliderPosition;

		// Token: 0x04003672 RID: 13938
		[Token(Token = "0x4003672")]
		[FieldOffset(Offset = "0xC4")]
		private float slideTimeMultiplier;

		// Token: 0x04003673 RID: 13939
		[Token(Token = "0x4003673")]
		[FieldOffset(Offset = "0xC8")]
		private bool isFail;
	}
}
