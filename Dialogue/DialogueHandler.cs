using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.NPCs;
using ScheduleOne.UI;
using ScheduleOne.VoiceOver;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Dialogue
{
	// Token: 0x02000633 RID: 1587
	[Token(Token = "0x2000633")]
	public class DialogueHandler : MonoBehaviour
	{
		// Token: 0x17000651 RID: 1617
		// (get) Token: 0x060026FE RID: 9982 RVA: 0x0000C090 File Offset: 0x0000A290
		// (set) Token: 0x060026FF RID: 9983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000651")]
		public bool IsDialogueInProgress
		{
			[Token(Token = "0x60026FE")]
			[Address(RVA = "0x4B9020", Offset = "0x4B7A20", VA = "0x1804B9020")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60026FF")]
			[Address(RVA = "0x4B9030", Offset = "0x4B7A30", VA = "0x1804B9030")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000652 RID: 1618
		// (get) Token: 0x06002700 RID: 9984 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002701 RID: 9985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000652")]
		public List<DialogueModule> runtimeModules
		{
			[Token(Token = "0x6002700")]
			[Address(RVA = "0x4423A0", Offset = "0x440DA0", VA = "0x1804423A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002701")]
			[Address(RVA = "0x4423D0", Offset = "0x440DD0", VA = "0x1804423D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000653 RID: 1619
		// (get) Token: 0x06002702 RID: 9986 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002703 RID: 9987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000653")]
		public NPC NPC
		{
			[Token(Token = "0x6002702")]
			[Address(RVA = "0x47D5A0", Offset = "0x47BFA0", VA = "0x18047D5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002703")]
			[Address(RVA = "0x5CDA00", Offset = "0x5CC400", VA = "0x1805CDA00")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000654 RID: 1620
		// (get) Token: 0x06002704 RID: 9988 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000654")]
		protected DialogueCanvas canvas
		{
			[Token(Token = "0x6002704")]
			[Address(RVA = "0x6F5470", Offset = "0x6F3E70", VA = "0x1806F5470")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002705 RID: 9989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002705")]
		[Address(RVA = "0x6F1140", Offset = "0x6EFB40", VA = "0x1806F1140", Slot = "4")]
		protected virtual void Awake()
		{
		}

		// Token: 0x06002706 RID: 9990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002706")]
		[Address(RVA = "0x6F4710", Offset = "0x6F3110", VA = "0x1806F4710", Slot = "5")]
		protected virtual void Start()
		{
		}

		// Token: 0x06002707 RID: 9991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002707")]
		[Address(RVA = "0x6F3190", Offset = "0x6F1B90", VA = "0x1806F3190")]
		public void InitializeDialogue(DialogueContainer container)
		{
		}

		// Token: 0x06002708 RID: 9992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002708")]
		[Address(RVA = "0x6F31F0", Offset = "0x6F1BF0", VA = "0x1806F31F0")]
		public void InitializeDialogue(DialogueContainer dialogueContainer, bool enableDialogueBehaviour = true, string entryNodeLabel = "ENTRY")
		{
		}

		// Token: 0x06002709 RID: 9993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002709")]
		[Address(RVA = "0x6F3540", Offset = "0x6F1F40", VA = "0x1806F3540")]
		public void InitializeDialogue(string dialogueContainerName, bool enableDialogueBehaviour = true, string entryNodeLabel = "ENTRY")
		{
		}

		// Token: 0x0600270A RID: 9994 RVA: 0x0000C0A8 File Offset: 0x0000A2A8
		[Token(Token = "0x600270A")]
		[Address(RVA = "0x6F12F0", Offset = "0x6EFCF0", VA = "0x1806F12F0", Slot = "6")]
		public virtual bool CanBeginConversation()
		{
			return default(bool);
		}

		// Token: 0x0600270B RID: 9995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600270B")]
		[Address(RVA = "0x6F36F0", Offset = "0x6F20F0", VA = "0x1806F36F0")]
		public void OverrideShownDialogue(string _overrideText)
		{
		}

		// Token: 0x0600270C RID: 9996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600270C")]
		[Address(RVA = "0x6F4920", Offset = "0x6F3320", VA = "0x1806F4920")]
		public void StopOverride()
		{
		}

		// Token: 0x0600270D RID: 9997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600270D")]
		[Address(RVA = "0x6F1C10", Offset = "0x6F0610", VA = "0x1806F1C10", Slot = "7")]
		public virtual void EndDialogue()
		{
		}

		// Token: 0x0600270E RID: 9998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600270E")]
		[Address(RVA = "0x6F4700", Offset = "0x6F3100", VA = "0x1806F4700")]
		public void SkipNextDialogueBehaviourEnd()
		{
		}

		// Token: 0x0600270F RID: 9999 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600270F")]
		[Address(RVA = "0x4BEA70", Offset = "0x4BD470", VA = "0x1804BEA70", Slot = "8")]
		protected virtual DialogueNodeData FinalizeDialogueNode(DialogueNodeData data)
		{
			return null;
		}

		// Token: 0x06002710 RID: 10000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002710")]
		[Address(RVA = "0x6F40A0", Offset = "0x6F2AA0", VA = "0x1806F40A0")]
		public void ShowNode(DialogueNodeData node)
		{
		}

		// Token: 0x06002711 RID: 10001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002711")]
		[Address(RVA = "0x6F2D80", Offset = "0x6F1780", VA = "0x1806F2D80")]
		private void EvaluateBranch(BranchNodeData node)
		{
		}

		// Token: 0x06002712 RID: 10002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002712")]
		[Address(RVA = "0x6F15A0", Offset = "0x6EFFA0", VA = "0x1806F15A0")]
		public void ChoiceSelected(int choiceIndex)
		{
		}

		// Token: 0x06002713 RID: 10003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002713")]
		[Address(RVA = "0x6F17E0", Offset = "0x6F01E0", VA = "0x1806F17E0")]
		public void ContinueSubmitted()
		{
		}

		// Token: 0x06002714 RID: 10004 RVA: 0x0000C0C0 File Offset: 0x0000A2C0
		[Token(Token = "0x6002714")]
		[Address(RVA = "0x6F1490", Offset = "0x6EFE90", VA = "0x1806F1490", Slot = "9")]
		public virtual bool CheckChoice(string choiceLabel, out string invalidReason)
		{
			return default(bool);
		}

		// Token: 0x06002715 RID: 10005 RVA: 0x0000C0D8 File Offset: 0x0000A2D8
		[Token(Token = "0x6002715")]
		[Address(RVA = "0x48DCC0", Offset = "0x48C6C0", VA = "0x18048DCC0", Slot = "10")]
		public virtual bool ShouldChoiceBeShown(string choiceLabel)
		{
			return default(bool);
		}

		// Token: 0x06002716 RID: 10006 RVA: 0x0000C0F0 File Offset: 0x0000A2F0
		[Token(Token = "0x6002716")]
		[Address(RVA = "0x6F1360", Offset = "0x6EFD60", VA = "0x1806F1360", Slot = "11")]
		protected virtual int CheckBranch(string branchLabel)
		{
			return 0;
		}

		// Token: 0x06002717 RID: 10007 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002717")]
		[Address(RVA = "0x6EEDA0", Offset = "0x6ED7A0", VA = "0x1806EEDA0", Slot = "12")]
		protected virtual string ModifyDialogueText(string dialogueLabel, string dialogueText)
		{
			return null;
		}

		// Token: 0x06002718 RID: 10008 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002718")]
		[Address(RVA = "0x6EEDA0", Offset = "0x6ED7A0", VA = "0x1806EEDA0", Slot = "13")]
		protected virtual string ModifyChoiceText(string choiceLabel, string choiceText)
		{
			return null;
		}

		// Token: 0x06002719 RID: 10009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002719")]
		[Address(RVA = "0x6F1540", Offset = "0x6EFF40", VA = "0x1806F1540", Slot = "14")]
		protected virtual void ChoiceCallback(string choiceLabel)
		{
		}

		// Token: 0x0600271A RID: 10010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600271A")]
		[Address(RVA = "0x6F1A90", Offset = "0x6F0490", VA = "0x1806F1A90", Slot = "15")]
		protected virtual void DialogueCallback(string dialogueLabel)
		{
		}

		// Token: 0x0600271B RID: 10011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600271B")]
		[Address(RVA = "0x42DA80", Offset = "0x42C480", VA = "0x18042DA80", Slot = "16")]
		protected virtual void ModifyChoiceList(string dialogueLabel, ref List<DialogueChoiceData> existingChoices)
		{
		}

		// Token: 0x0600271C RID: 10012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600271C")]
		[Address(RVA = "0x6F1960", Offset = "0x6F0360", VA = "0x1806F1960")]
		protected void CreateTempLink(string baseNodeGUID, string baseOptionGUID, string targetNodeGUID)
		{
		}

		// Token: 0x0600271D RID: 10013 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600271D")]
		[Address(RVA = "0x6F2F90", Offset = "0x6F1990", VA = "0x1806F2F90")]
		private NodeLinkData GetLink(string baseChoiceOrOptionGUID)
		{
			return null;
		}

		// Token: 0x0600271E RID: 10014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600271E")]
		[Address(RVA = "0x42DA80", Offset = "0x42C480", VA = "0x18042DA80", Slot = "17")]
		public virtual void Hovered()
		{
		}

		// Token: 0x0600271F RID: 10015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600271F")]
		[Address(RVA = "0x42DA80", Offset = "0x42C480", VA = "0x18042DA80", Slot = "18")]
		public virtual void Interacted()
		{
		}

		// Token: 0x06002720 RID: 10016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002720")]
		[Address(RVA = "0x6F3740", Offset = "0x6F2140", VA = "0x1806F3740", Slot = "19")]
		public virtual void PlayReaction_Local(string key)
		{
		}

		// Token: 0x06002721 RID: 10017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002721")]
		[Address(RVA = "0x6F3770", Offset = "0x6F2170", VA = "0x1806F3770", Slot = "20")]
		public virtual void PlayReaction_Networked(string key)
		{
		}

		// Token: 0x06002722 RID: 10018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002722")]
		[Address(RVA = "0x6F37A0", Offset = "0x6F21A0", VA = "0x1806F37A0", Slot = "21")]
		public virtual void PlayReaction(string key, float duration, bool network)
		{
		}

		// Token: 0x06002723 RID: 10019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002723")]
		[Address(RVA = "0x6F3170", Offset = "0x6F1B70", VA = "0x1806F3170", Slot = "22")]
		public virtual void HideWorldspaceDialogue()
		{
		}

		// Token: 0x06002724 RID: 10020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002724")]
		[Address(RVA = "0x6F46A0", Offset = "0x6F30A0", VA = "0x1806F46A0", Slot = "23")]
		public virtual void ShowWorldspaceDialogue(string text, float duration)
		{
		}

		// Token: 0x06002725 RID: 10021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002725")]
		[Address(RVA = "0x6F4680", Offset = "0x6F3080", VA = "0x1806F4680", Slot = "24")]
		public virtual void ShowWorldspaceDialogue_5s(string text)
		{
		}

		// Token: 0x06002726 RID: 10022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002726")]
		[Address(RVA = "0x6F52B0", Offset = "0x6F3CB0", VA = "0x1806F52B0")]
		public DialogueHandler()
		{
		}

		// Token: 0x04001DF1 RID: 7665
		[Token(Token = "0x4001DF1")]
		public const float TimePerChar = 0.2f;

		// Token: 0x04001DF2 RID: 7666
		[Token(Token = "0x4001DF2")]
		public const float WorldspaceDialogueMinDuration = 1.5f;

		// Token: 0x04001DF3 RID: 7667
		[Token(Token = "0x4001DF3")]
		public const float WorldspaceDialogueMaxDuration = 5f;

		// Token: 0x04001DF4 RID: 7668
		[Token(Token = "0x4001DF4")]
		[FieldOffset(Offset = "0x0")]
		public static DialogueContainer activeDialogue;

		// Token: 0x04001DF5 RID: 7669
		[Token(Token = "0x4001DF5")]
		[FieldOffset(Offset = "0x8")]
		public static DialogueNodeData activeDialogueNode;

		// Token: 0x04001DF7 RID: 7671
		[Token(Token = "0x4001DF7")]
		[FieldOffset(Offset = "0x28")]
		public DialogueDatabase Database;

		// Token: 0x04001DF9 RID: 7673
		[Token(Token = "0x4001DF9")]
		[FieldOffset(Offset = "0x38")]
		[Header("References")]
		public Transform LookPosition;

		// Token: 0x04001DFA RID: 7674
		[Token(Token = "0x4001DFA")]
		[FieldOffset(Offset = "0x40")]
		public WorldspaceDialogueRenderer WorldspaceRend;

		// Token: 0x04001DFC RID: 7676
		[Token(Token = "0x4001DFC")]
		[FieldOffset(Offset = "0x50")]
		public VOEmitter VOEmitter;

		// Token: 0x04001DFD RID: 7677
		[Token(Token = "0x4001DFD")]
		[FieldOffset(Offset = "0x58")]
		[HideInInspector]
		public List<DialogueChoiceData> CurrentChoices;

		// Token: 0x04001DFE RID: 7678
		[Token(Token = "0x4001DFE")]
		[FieldOffset(Offset = "0x60")]
		[Header("Events")]
		public DialogueEvent[] DialogueEvents;

		// Token: 0x04001DFF RID: 7679
		[Token(Token = "0x4001DFF")]
		[FieldOffset(Offset = "0x68")]
		public UnityEvent onConversationStart;

		// Token: 0x04001E00 RID: 7680
		[Token(Token = "0x4001E00")]
		[FieldOffset(Offset = "0x70")]
		public UnityEvent<string> onDialogueNodeDisplayed;

		// Token: 0x04001E01 RID: 7681
		[Token(Token = "0x4001E01")]
		[FieldOffset(Offset = "0x78")]
		public UnityEvent<string> onDialogueChoiceChosen;

		// Token: 0x04001E02 RID: 7682
		[Token(Token = "0x4001E02")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		protected List<DialogueContainer> dialogueContainers;

		// Token: 0x04001E03 RID: 7683
		[Token(Token = "0x4001E03")]
		[FieldOffset(Offset = "0x88")]
		protected string overrideText;

		// Token: 0x04001E04 RID: 7684
		[Token(Token = "0x4001E04")]
		[FieldOffset(Offset = "0x90")]
		protected List<NodeLinkData> tempLinks;

		// Token: 0x04001E05 RID: 7685
		[Token(Token = "0x4001E05")]
		[FieldOffset(Offset = "0x98")]
		protected bool skipNextDialogueBehaviourEnd;

		// Token: 0x04001E06 RID: 7686
		[Token(Token = "0x4001E06")]
		[FieldOffset(Offset = "0xA0")]
		protected List<DialogueChoiceData> finalChoices;

		// Token: 0x04001E07 RID: 7687
		[Token(Token = "0x4001E07")]
		[FieldOffset(Offset = "0xA8")]
		private bool passChecked;
	}
}
