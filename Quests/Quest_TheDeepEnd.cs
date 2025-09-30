using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Map;
using ScheduleOne.Misc;
using ScheduleOne.NPCs.CharacterClasses;
using ScheduleOne.ScriptableObjects;
using UnityEngine;

namespace ScheduleOne.Quests
{
	// Token: 0x02000304 RID: 772
	[Token(Token = "0x2000304")]
	public class Quest_TheDeepEnd : Quest
	{
		// Token: 0x06001140 RID: 4416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001140")]
		[Address(RVA = "0x59FAE0", Offset = "0x59E4E0", VA = "0x18059FAE0", Slot = "31")]
		protected override void Start()
		{
		}

		// Token: 0x06001141 RID: 4417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001141")]
		[Address(RVA = "0x59F630", Offset = "0x59E030", VA = "0x18059F630", Slot = "34")]
		public override void Begin(bool network = true)
		{
		}

		// Token: 0x06001142 RID: 4418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001142")]
		[Address(RVA = "0x59F890", Offset = "0x59E290", VA = "0x18059F890")]
		public void SetupFirstMeeting()
		{
		}

		// Token: 0x06001143 RID: 4419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001143")]
		[Address(RVA = "0x59FDF0", Offset = "0x59E7F0", VA = "0x18059FDF0")]
		private void ThomasDialogueNodeDisplayed(string nodeLabel)
		{
		}

		// Token: 0x06001144 RID: 4420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001144")]
		[Address(RVA = "0x59F650", Offset = "0x59E050", VA = "0x18059F650")]
		private void HourPass()
		{
		}

		// Token: 0x06001145 RID: 4421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001145")]
		[Address(RVA = "0x59F580", Offset = "0x59DF80", VA = "0x18059F580")]
		private void BeforeSleep()
		{
		}

		// Token: 0x06001146 RID: 4422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001146")]
		[Address(RVA = "0x59F980", Offset = "0x59E380", VA = "0x18059F980")]
		private void SleepFadeOut()
		{
		}

		// Token: 0x06001147 RID: 4423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001147")]
		[Address(RVA = "0x59F7E0", Offset = "0x59E1E0", VA = "0x18059F7E0", Slot = "42")]
		public override void SetQuestEntryState(int entryIndex, EQuestState state, bool network = true)
		{
		}

		// Token: 0x06001148 RID: 4424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001148")]
		[Address(RVA = "0x5A0020", Offset = "0x59EA20", VA = "0x1805A0020")]
		public Quest_TheDeepEnd()
		{
		}

		// Token: 0x06001149 RID: 4425 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001149")]
		[Address(RVA = "0x59FFB0", Offset = "0x59E9B0", VA = "0x18059FFB0")]
		[CompilerGenerated]
		private IEnumerator <ThomasDialogueNodeDisplayed>g__Wait|13_0()
		{
			return null;
		}

		// Token: 0x04001103 RID: 4355
		[Token(Token = "0x4001103")]
		public const float MEETING_REMINDER_TIME = 36f;

		// Token: 0x04001104 RID: 4356
		[Token(Token = "0x4001104")]
		public const float KIDNAP_TIME = 82f;

		// Token: 0x04001105 RID: 4357
		[Token(Token = "0x4001105")]
		[FieldOffset(Offset = "0x138")]
		private bool kidnapQueued;

		// Token: 0x04001106 RID: 4358
		[Token(Token = "0x4001106")]
		[FieldOffset(Offset = "0x139")]
		private bool meetingSetup;

		// Token: 0x04001107 RID: 4359
		[Token(Token = "0x4001107")]
		[FieldOffset(Offset = "0x140")]
		public Thomas Thomas;

		// Token: 0x04001108 RID: 4360
		[Token(Token = "0x4001108")]
		[FieldOffset(Offset = "0x148")]
		public ManorGate Gate;

		// Token: 0x04001109 RID: 4361
		[Token(Token = "0x4001109")]
		[FieldOffset(Offset = "0x150")]
		public ModularSwitch Switch;

		// Token: 0x0400110A RID: 4362
		[Token(Token = "0x400110A")]
		[FieldOffset(Offset = "0x158")]
		public Transform MeetingTeleportPoint;

		// Token: 0x0400110B RID: 4363
		[Token(Token = "0x400110B")]
		[FieldOffset(Offset = "0x160")]
		public PhoneCallData PostMeetingCall;

		// Token: 0x0400110C RID: 4364
		[Token(Token = "0x400110C")]
		[FieldOffset(Offset = "0x168")]
		public SystemTriggerObject PostMeetingTrigger;
	}
}
