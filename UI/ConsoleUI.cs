using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using TMPro;
using UnityEngine;

namespace ScheduleOne.UI
{
	// Token: 0x02000A84 RID: 2692
	[Token(Token = "0x2000A84")]
	public class ConsoleUI : MonoBehaviour
	{
		// Token: 0x17000A42 RID: 2626
		// (get) Token: 0x06004920 RID: 18720 RVA: 0x000131E8 File Offset: 0x000113E8
		[Token(Token = "0x17000A42")]
		public bool IS_CONSOLE_ENABLED
		{
			[Token(Token = "0x6004920")]
			[Address(RVA = "0x902C60", Offset = "0x901660", VA = "0x180902C60")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06004921 RID: 18721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004921")]
		[Address(RVA = "0x9024B0", Offset = "0x900EB0", VA = "0x1809024B0")]
		private void Awake()
		{
		}

		// Token: 0x06004922 RID: 18722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004922")]
		[Address(RVA = "0x902A70", Offset = "0x901470", VA = "0x180902A70")]
		private void Update()
		{
		}

		// Token: 0x06004923 RID: 18723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004923")]
		[Address(RVA = "0x9025F0", Offset = "0x900FF0", VA = "0x1809025F0")]
		private void Exit(ExitAction exitAction)
		{
		}

		// Token: 0x06004924 RID: 18724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004924")]
		[Address(RVA = "0x9026A0", Offset = "0x9010A0", VA = "0x1809026A0")]
		public void SetIsOpen(bool open)
		{
		}

		// Token: 0x06004925 RID: 18725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004925")]
		[Address(RVA = "0x902980", Offset = "0x901380", VA = "0x180902980")]
		public void Submit(string val)
		{
		}

		// Token: 0x06004926 RID: 18726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004926")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public ConsoleUI()
		{
		}

		// Token: 0x06004927 RID: 18727 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004927")]
		[Address(RVA = "0x902A00", Offset = "0x901400", VA = "0x180902A00")]
		[CompilerGenerated]
		private IEnumerator <SetIsOpen>g__Routine|8_0()
		{
			return null;
		}

		// Token: 0x0400340F RID: 13327
		[Token(Token = "0x400340F")]
		[FieldOffset(Offset = "0x20")]
		[Header("References")]
		public Canvas canvas;

		// Token: 0x04003410 RID: 13328
		[Token(Token = "0x4003410")]
		[FieldOffset(Offset = "0x28")]
		public TMP_InputField InputField;

		// Token: 0x04003411 RID: 13329
		[Token(Token = "0x4003411")]
		[FieldOffset(Offset = "0x30")]
		public GameObject Container;
	}
}
