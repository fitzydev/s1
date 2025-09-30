using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.Interaction;
using ScheduleOne.NPCs;
using ScheduleOne.VoiceOver;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Dialogue
{
	// Token: 0x02000622 RID: 1570
	[Token(Token = "0x2000622")]
	public class DialogueController : MonoBehaviour
	{
		// Token: 0x060026AF RID: 9903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026AF")]
		[Address(RVA = "0x6F01B0", Offset = "0x6EEBB0", VA = "0x1806F01B0", Slot = "4")]
		protected virtual void Start()
		{
		}

		// Token: 0x060026B0 RID: 9904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026B0")]
		[Address(RVA = "0x6F06C0", Offset = "0x6EF0C0", VA = "0x1806F06C0")]
		private void Update()
		{
		}

		// Token: 0x060026B1 RID: 9905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026B1")]
		[Address(RVA = "0x6EDDF0", Offset = "0x6EC7F0", VA = "0x1806EDDF0")]
		private void Hovered()
		{
		}

		// Token: 0x060026B2 RID: 9906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026B2")]
		[Address(RVA = "0x6F0170", Offset = "0x6EEB70", VA = "0x1806F0170")]
		public void StartGenericDialogue(bool allowExit = true)
		{
		}

		// Token: 0x060026B3 RID: 9907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026B3")]
		[Address(RVA = "0x6EDF70", Offset = "0x6EC970", VA = "0x1806EDF70")]
		private void Interacted()
		{
		}

		// Token: 0x060026B4 RID: 9908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026B4")]
		[Address(RVA = "0x6F06B0", Offset = "0x6EF0B0", VA = "0x1806F06B0")]
		private void Unqueue()
		{
		}

		// Token: 0x060026B5 RID: 9909 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026B5")]
		[Address(RVA = "0x6EDA90", Offset = "0x6EC490", VA = "0x1806EDA90")]
		private string GetActiveGreeting(out bool playVO, out EVOLineType voLineType)
		{
			return null;
		}

		// Token: 0x060026B6 RID: 9910 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026B6")]
		[Address(RVA = "0x6ED800", Offset = "0x6EC200", VA = "0x1806ED800")]
		private List<DialogueController.DialogueChoice> GetActiveChoices()
		{
			return null;
		}

		// Token: 0x060026B7 RID: 9911 RVA: 0x0000BF28 File Offset: 0x0000A128
		[Token(Token = "0x60026B7")]
		[Address(RVA = "0x6EDC80", Offset = "0x6EC680", VA = "0x1806EDC80", Slot = "5")]
		protected virtual bool GetCustomGreeting(out string greeting, out bool playVO, out EVOLineType voLineType)
		{
			return default(bool);
		}

		// Token: 0x060026B8 RID: 9912 RVA: 0x0000BF40 File Offset: 0x0000A140
		[Token(Token = "0x60026B8")]
		[Address(RVA = "0x6E9480", Offset = "0x6E7E80", VA = "0x1806E9480", Slot = "6")]
		public virtual int AddDialogueChoice(DialogueController.DialogueChoice data, int priority = 0)
		{
			return 0;
		}

		// Token: 0x060026B9 RID: 9913 RVA: 0x0000BF58 File Offset: 0x0000A158
		[Token(Token = "0x60026B9")]
		[Address(RVA = "0x6E9560", Offset = "0x6E7F60", VA = "0x1806E9560", Slot = "7")]
		public virtual int AddGreetingOverride(DialogueController.GreetingOverride data)
		{
			return 0;
		}

		// Token: 0x060026BA RID: 9914 RVA: 0x0000BF70 File Offset: 0x0000A170
		[Token(Token = "0x60026BA")]
		[Address(RVA = "0x6EABD0", Offset = "0x6E95D0", VA = "0x1806EABD0", Slot = "8")]
		public virtual bool CanStartDialogue()
		{
			return default(bool);
		}

		// Token: 0x060026BB RID: 9915 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026BB")]
		[Address(RVA = "0x6EEDB0", Offset = "0x6ED7B0", VA = "0x1806EEDB0", Slot = "9")]
		public virtual string ModifyDialogueText(string dialogueLabel, string dialogueText)
		{
			return null;
		}

		// Token: 0x060026BC RID: 9916 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026BC")]
		[Address(RVA = "0x6EEDA0", Offset = "0x6ED7A0", VA = "0x1806EEDA0", Slot = "10")]
		public virtual string ModifyChoiceText(string choiceLabel, string choiceText)
		{
			return null;
		}

		// Token: 0x060026BD RID: 9917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026BD")]
		[Address(RVA = "0x6EEB50", Offset = "0x6ED550", VA = "0x1806EEB50", Slot = "11")]
		public virtual void ModifyChoiceList(string dialogueLabel, ref List<DialogueChoiceData> existingChoices)
		{
		}

		// Token: 0x060026BE RID: 9918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026BE")]
		[Address(RVA = "0x6EB010", Offset = "0x6E9A10", VA = "0x1806EB010", Slot = "12")]
		public virtual void ChoiceCallback(string choiceLabel)
		{
		}

		// Token: 0x060026BF RID: 9919 RVA: 0x0000BF88 File Offset: 0x0000A188
		[Token(Token = "0x60026BF")]
		[Address(RVA = "0x6EAE60", Offset = "0x6E9860", VA = "0x1806EAE60", Slot = "13")]
		public virtual bool CheckChoice(string choiceLabel, out string invalidReason)
		{
			return default(bool);
		}

		// Token: 0x060026C0 RID: 9920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026C0")]
		[Address(RVA = "0x5CDA00", Offset = "0x5CC400", VA = "0x1805CDA00")]
		public void SetOverrideContainer(DialogueContainer container)
		{
		}

		// Token: 0x060026C1 RID: 9921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026C1")]
		[Address(RVA = "0x6EB1E0", Offset = "0x6E9BE0", VA = "0x1806EB1E0")]
		public void ClearOverrideContainer()
		{
		}

		// Token: 0x060026C2 RID: 9922 RVA: 0x0000BFA0 File Offset: 0x0000A1A0
		[Token(Token = "0x60026C2")]
		[Address(RVA = "0x6EBB20", Offset = "0x6EA520", VA = "0x1806EBB20", Slot = "14")]
		public virtual bool DecideBranch(string branchLabel, out int index)
		{
			return default(bool);
		}

		// Token: 0x060026C3 RID: 9923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026C3")]
		[Address(RVA = "0x4F3A70", Offset = "0x4F2470", VA = "0x1804F3A70")]
		public void SetDialogueEnabled(bool enabled)
		{
		}

		// Token: 0x060026C4 RID: 9924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026C4")]
		[Address(RVA = "0x6F0730", Offset = "0x6EF130", VA = "0x1806F0730")]
		public DialogueController()
		{
		}

		// Token: 0x04001DC4 RID: 7620
		[Token(Token = "0x4001DC4")]
		[FieldOffset(Offset = "0x0")]
		public static float GREETING_COOLDOWN;

		// Token: 0x04001DC5 RID: 7621
		[Token(Token = "0x4001DC5")]
		[FieldOffset(Offset = "0x20")]
		[Header("References")]
		public InteractableObject IntObj;

		// Token: 0x04001DC6 RID: 7622
		[Token(Token = "0x4001DC6")]
		[FieldOffset(Offset = "0x28")]
		public DialogueContainer GenericDialogue;

		// Token: 0x04001DC7 RID: 7623
		[Token(Token = "0x4001DC7")]
		[FieldOffset(Offset = "0x30")]
		[Header("Settings")]
		public bool DialogueEnabled;

		// Token: 0x04001DC8 RID: 7624
		[Token(Token = "0x4001DC8")]
		[FieldOffset(Offset = "0x31")]
		public bool UseDialogueBehaviour;

		// Token: 0x04001DC9 RID: 7625
		[Token(Token = "0x4001DC9")]
		[FieldOffset(Offset = "0x38")]
		public List<DialogueController.DialogueChoice> Choices;

		// Token: 0x04001DCA RID: 7626
		[Token(Token = "0x4001DCA")]
		[FieldOffset(Offset = "0x40")]
		public List<DialogueController.GreetingOverride> GreetingOverrides;

		// Token: 0x04001DCB RID: 7627
		[Token(Token = "0x4001DCB")]
		[FieldOffset(Offset = "0x48")]
		public DialogueContainer OverrideContainer;

		// Token: 0x04001DCC RID: 7628
		[Token(Token = "0x4001DCC")]
		[FieldOffset(Offset = "0x50")]
		protected NPC npc;

		// Token: 0x04001DCD RID: 7629
		[Token(Token = "0x4001DCD")]
		[FieldOffset(Offset = "0x58")]
		protected DialogueHandler handler;

		// Token: 0x04001DCE RID: 7630
		[Token(Token = "0x4001DCE")]
		[FieldOffset(Offset = "0x60")]
		private float lastGreetingTime;

		// Token: 0x04001DCF RID: 7631
		[Token(Token = "0x4001DCF")]
		[FieldOffset(Offset = "0x68")]
		private List<DialogueController.DialogueChoice> shownChoices;

		// Token: 0x04001DD0 RID: 7632
		[Token(Token = "0x4001DD0")]
		[FieldOffset(Offset = "0x70")]
		private bool dialogueQueued;

		// Token: 0x04001DD1 RID: 7633
		[Token(Token = "0x4001DD1")]
		[FieldOffset(Offset = "0x78")]
		private string cachedGreeting;

		// Token: 0x02000623 RID: 1571
		[Token(Token = "0x2000623")]
		[Serializable]
		public class DialogueChoice
		{
			// Token: 0x060026C6 RID: 9926 RVA: 0x0000BFB8 File Offset: 0x0000A1B8
			[Token(Token = "0x60026C6")]
			[Address(RVA = "0x6E8DC0", Offset = "0x6E77C0", VA = "0x1806E8DC0")]
			public bool ShouldShow()
			{
				return default(bool);
			}

			// Token: 0x060026C7 RID: 9927 RVA: 0x0000BFD0 File Offset: 0x0000A1D0
			[Token(Token = "0x60026C7")]
			[Address(RVA = "0x6E8D30", Offset = "0x6E7730", VA = "0x1806E8D30")]
			public bool IsValid(out string invalidReason)
			{
				return default(bool);
			}

			// Token: 0x060026C8 RID: 9928 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60026C8")]
			[Address(RVA = "0x6E8DF0", Offset = "0x6E77F0", VA = "0x1806E8DF0")]
			public DialogueChoice()
			{
			}

			// Token: 0x04001DD2 RID: 7634
			[Token(Token = "0x4001DD2")]
			[FieldOffset(Offset = "0x10")]
			public bool Enabled;

			// Token: 0x04001DD3 RID: 7635
			[Token(Token = "0x4001DD3")]
			[FieldOffset(Offset = "0x18")]
			public string ChoiceText;

			// Token: 0x04001DD4 RID: 7636
			[Token(Token = "0x4001DD4")]
			[FieldOffset(Offset = "0x20")]
			public bool ShowWorldspaceDialogue;

			// Token: 0x04001DD5 RID: 7637
			[Token(Token = "0x4001DD5")]
			[FieldOffset(Offset = "0x28")]
			public DialogueContainer Conversation;

			// Token: 0x04001DD6 RID: 7638
			[Token(Token = "0x4001DD6")]
			[FieldOffset(Offset = "0x30")]
			public UnityEvent onChoosen;

			// Token: 0x04001DD7 RID: 7639
			[Token(Token = "0x4001DD7")]
			[FieldOffset(Offset = "0x38")]
			public DialogueController.DialogueChoice.ShouldShowCheck shouldShowCheck;

			// Token: 0x04001DD8 RID: 7640
			[Token(Token = "0x4001DD8")]
			[FieldOffset(Offset = "0x40")]
			public DialogueController.DialogueChoice.IsChoiceValid isValidCheck;

			// Token: 0x04001DD9 RID: 7641
			[Token(Token = "0x4001DD9")]
			[FieldOffset(Offset = "0x48")]
			public int Priority;

			// Token: 0x02000624 RID: 1572
			// (Invoke) Token: 0x060026CA RID: 9930
			[Token(Token = "0x2000624")]
			public delegate bool ShouldShowCheck(bool enabled);

			// Token: 0x02000625 RID: 1573
			// (Invoke) Token: 0x060026CE RID: 9934
			[Token(Token = "0x2000625")]
			public delegate bool IsChoiceValid(out string invalidReason);
		}

		// Token: 0x02000626 RID: 1574
		[Token(Token = "0x2000626")]
		[Serializable]
		public class GreetingOverride
		{
			// Token: 0x060026D1 RID: 9937 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60026D1")]
			[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
			public GreetingOverride()
			{
			}

			// Token: 0x04001DDA RID: 7642
			[Token(Token = "0x4001DDA")]
			[FieldOffset(Offset = "0x10")]
			public string Greeting;

			// Token: 0x04001DDB RID: 7643
			[Token(Token = "0x4001DDB")]
			[FieldOffset(Offset = "0x18")]
			public bool ShouldShow;

			// Token: 0x04001DDC RID: 7644
			[Token(Token = "0x4001DDC")]
			[FieldOffset(Offset = "0x19")]
			public bool PlayVO;

			// Token: 0x04001DDD RID: 7645
			[Token(Token = "0x4001DDD")]
			[FieldOffset(Offset = "0x1C")]
			public EVOLineType VOType;
		}
	}
}
