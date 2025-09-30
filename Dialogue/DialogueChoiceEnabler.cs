using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Dialogue
{
	// Token: 0x02000621 RID: 1569
	[Token(Token = "0x2000621")]
	public class DialogueChoiceEnabler : MonoBehaviour
	{
		// Token: 0x060026AA RID: 9898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026AA")]
		[Address(RVA = "0x6E8A50", Offset = "0x6E7450", VA = "0x1806E8A50")]
		private void Awake()
		{
		}

		// Token: 0x060026AB RID: 9899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026AB")]
		[Address(RVA = "0x6E8B80", Offset = "0x6E7580", VA = "0x1806E8B80")]
		private void OnValidate()
		{
		}

		// Token: 0x060026AC RID: 9900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026AC")]
		[Address(RVA = "0x6E8B60", Offset = "0x6E7560", VA = "0x1806E8B60")]
		public void EnableChoice()
		{
		}

		// Token: 0x060026AD RID: 9901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026AD")]
		[Address(RVA = "0x6E8B40", Offset = "0x6E7540", VA = "0x1806E8B40")]
		public void DisableChoice()
		{
		}

		// Token: 0x060026AE RID: 9902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026AE")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public DialogueChoiceEnabler()
		{
		}

		// Token: 0x04001DC1 RID: 7617
		[Token(Token = "0x4001DC1")]
		[FieldOffset(Offset = "0x20")]
		public DialogueController DialogueController;

		// Token: 0x04001DC2 RID: 7618
		[Token(Token = "0x4001DC2")]
		[FieldOffset(Offset = "0x28")]
		public int ChoiceIndex;

		// Token: 0x04001DC3 RID: 7619
		[Token(Token = "0x4001DC3")]
		[FieldOffset(Offset = "0x30")]
		private DialogueController.DialogueChoice choice;
	}
}
