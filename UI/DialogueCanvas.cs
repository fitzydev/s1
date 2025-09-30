using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.Dialogue;
using TMPro;
using UnityEngine;

namespace ScheduleOne.UI
{
	// Token: 0x02000A93 RID: 2707
	[Token(Token = "0x2000A93")]
	public class DialogueCanvas : Singleton<DialogueCanvas>
	{
		// Token: 0x17000A55 RID: 2645
		// (get) Token: 0x0600499F RID: 18847 RVA: 0x00013398 File Offset: 0x00011598
		[Token(Token = "0x17000A55")]
		public bool isActive
		{
			[Token(Token = "0x600499F")]
			[Address(RVA = "0x90BB20", Offset = "0x90A520", VA = "0x18090BB20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060049A0 RID: 18848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049A0")]
		[Address(RVA = "0x90A4F0", Offset = "0x908EF0", VA = "0x18090A4F0", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x060049A1 RID: 18849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049A1")]
		[Address(RVA = "0x90A8F0", Offset = "0x9092F0", VA = "0x18090A8F0")]
		public void DisplayDialogueNode(DialogueHandler diag, DialogueNodeData node, string dialogueText, List<DialogueChoiceData> choices)
		{
		}

		// Token: 0x060049A2 RID: 18850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049A2")]
		[Address(RVA = "0x90B070", Offset = "0x909A70", VA = "0x18090B070")]
		public void OverrideText(string text)
		{
		}

		// Token: 0x060049A3 RID: 18851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049A3")]
		[Address(RVA = "0x90B950", Offset = "0x90A350", VA = "0x18090B950")]
		public void StopTextOverride()
		{
		}

		// Token: 0x060049A4 RID: 18852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049A4")]
		[Address(RVA = "0x90B9B0", Offset = "0x90A3B0", VA = "0x18090B9B0")]
		private void Update()
		{
		}

		// Token: 0x060049A5 RID: 18853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049A5")]
		[Address(RVA = "0x90AE90", Offset = "0x909890", VA = "0x18090AE90")]
		private void Exit(ExitAction action)
		{
		}

		// Token: 0x060049A6 RID: 18854 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049A6")]
		[Address(RVA = "0x90B100", Offset = "0x909B00", VA = "0x18090B100")]
		protected IEnumerator RolloutDialogue(string text, List<DialogueChoiceData> choices)
		{
			return null;
		}

		// Token: 0x060049A7 RID: 18855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049A7")]
		[Address(RVA = "0x90A850", Offset = "0x909250", VA = "0x18090A850")]
		private IEnumerator ChoiceSelectionResidual(DialogueChoiceEntry choice, float fadeTime)
		{
			return null;
		}

		// Token: 0x060049A8 RID: 18856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049A8")]
		[Address(RVA = "0x90B1B0", Offset = "0x909BB0", VA = "0x18090B1B0")]
		private void StartDialogue(DialogueHandler handler)
		{
		}

		// Token: 0x060049A9 RID: 18857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049A9")]
		[Address(RVA = "0x90AA40", Offset = "0x909440", VA = "0x18090AA40")]
		public void EndDialogue()
		{
		}

		// Token: 0x060049AA RID: 18858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049AA")]
		[Address(RVA = "0x90A5E0", Offset = "0x908FE0", VA = "0x18090A5E0")]
		public void ChoiceSelected(int choiceIndex)
		{
		}

		// Token: 0x060049AB RID: 18859 RVA: 0x000133B0 File Offset: 0x000115B0
		[Token(Token = "0x60049AB")]
		[Address(RVA = "0x90AF80", Offset = "0x909980", VA = "0x18090AF80")]
		private bool IsChoiceValid(int choiceIndex, out string reason)
		{
			return default(bool);
		}

		// Token: 0x060049AC RID: 18860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049AC")]
		[Address(RVA = "0x90BA60", Offset = "0x90A460", VA = "0x18090BA60")]
		public DialogueCanvas()
		{
		}

		// Token: 0x04003479 RID: 13433
		[Token(Token = "0x4003479")]
		public const float TIME_PER_CHAR = 0.015f;

		// Token: 0x0400347A RID: 13434
		[Token(Token = "0x400347A")]
		[FieldOffset(Offset = "0x28")]
		public bool SkipNextRollout;

		// Token: 0x0400347B RID: 13435
		[Token(Token = "0x400347B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Header("References")]
		protected Canvas canvas;

		// Token: 0x0400347C RID: 13436
		[Token(Token = "0x400347C")]
		[FieldOffset(Offset = "0x38")]
		public RectTransform Container;

		// Token: 0x0400347D RID: 13437
		[Token(Token = "0x400347D")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		protected TextMeshProUGUI dialogueText;

		// Token: 0x0400347E RID: 13438
		[Token(Token = "0x400347E")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		protected GameObject continuePopup;

		// Token: 0x0400347F RID: 13439
		[Token(Token = "0x400347F")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		protected List<DialogueChoiceEntry> dialogueChoices;

		// Token: 0x04003480 RID: 13440
		[Token(Token = "0x4003480")]
		[FieldOffset(Offset = "0x58")]
		private DialogueHandler currentHandler;

		// Token: 0x04003481 RID: 13441
		[Token(Token = "0x4003481")]
		[FieldOffset(Offset = "0x60")]
		private DialogueNodeData currentNode;

		// Token: 0x04003482 RID: 13442
		[Token(Token = "0x4003482")]
		[FieldOffset(Offset = "0x68")]
		private bool spaceDownThisFrame;

		// Token: 0x04003483 RID: 13443
		[Token(Token = "0x4003483")]
		[FieldOffset(Offset = "0x69")]
		private bool leftClickThisFrame;

		// Token: 0x04003484 RID: 13444
		[Token(Token = "0x4003484")]
		[FieldOffset(Offset = "0x70")]
		private string overrideText;

		// Token: 0x04003485 RID: 13445
		[Token(Token = "0x4003485")]
		[FieldOffset(Offset = "0x78")]
		private Coroutine dialogueRollout;

		// Token: 0x04003486 RID: 13446
		[Token(Token = "0x4003486")]
		[FieldOffset(Offset = "0x80")]
		private Coroutine choiceSelectionResidualCoroutine;

		// Token: 0x04003487 RID: 13447
		[Token(Token = "0x4003487")]
		[FieldOffset(Offset = "0x88")]
		private bool hasChoiceBeenSelected;
	}
}
