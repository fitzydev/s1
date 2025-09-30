using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using UnityEngine;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x02000C62 RID: 3170
	[Token(Token = "0x2000C62")]
	public class CashCounter : MonoBehaviour
	{
		// Token: 0x06005534 RID: 21812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005534")]
		[Address(RVA = "0x9C4560", Offset = "0x9C2F60", VA = "0x1809C4560", Slot = "4")]
		public virtual void LateUpdate()
		{
		}

		// Token: 0x06005535 RID: 21813 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005535")]
		[Address(RVA = "0x9C4770", Offset = "0x9C3170", VA = "0x1809C4770")]
		private IEnumerator LerpNote(Transform note)
		{
			return null;
		}

		// Token: 0x06005536 RID: 21814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005536")]
		[Address(RVA = "0x9C4800", Offset = "0x9C3200", VA = "0x1809C4800")]
		public CashCounter()
		{
		}

		// Token: 0x04003F30 RID: 16176
		[Token(Token = "0x4003F30")]
		public const float NoteLerpTime = 0.18f;

		// Token: 0x04003F31 RID: 16177
		[Token(Token = "0x4003F31")]
		[FieldOffset(Offset = "0x20")]
		public bool IsOn;

		// Token: 0x04003F32 RID: 16178
		[Token(Token = "0x4003F32")]
		[FieldOffset(Offset = "0x28")]
		[Header("References")]
		public GameObject UpperNotes;

		// Token: 0x04003F33 RID: 16179
		[Token(Token = "0x4003F33")]
		[FieldOffset(Offset = "0x30")]
		public GameObject LowerNotes;

		// Token: 0x04003F34 RID: 16180
		[Token(Token = "0x4003F34")]
		[FieldOffset(Offset = "0x38")]
		public Transform NoteStartPoint;

		// Token: 0x04003F35 RID: 16181
		[Token(Token = "0x4003F35")]
		[FieldOffset(Offset = "0x40")]
		public Transform NoteEndPoint;

		// Token: 0x04003F36 RID: 16182
		[Token(Token = "0x4003F36")]
		[FieldOffset(Offset = "0x48")]
		public List<Transform> MovingNotes;

		// Token: 0x04003F37 RID: 16183
		[Token(Token = "0x4003F37")]
		[FieldOffset(Offset = "0x50")]
		public AudioSourceController Audio;

		// Token: 0x04003F38 RID: 16184
		[Token(Token = "0x4003F38")]
		[FieldOffset(Offset = "0x58")]
		private bool lerping;
	}
}
