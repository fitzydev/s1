using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.DevUtilities
{
	// Token: 0x02000769 RID: 1897
	[Token(Token = "0x2000769")]
	public class SetTransform : MonoBehaviour
	{
		// Token: 0x06003359 RID: 13145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003359")]
		[Address(RVA = "0x789C10", Offset = "0x788610", VA = "0x180789C10")]
		private void Awake()
		{
		}

		// Token: 0x0600335A RID: 13146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600335A")]
		[Address(RVA = "0x789DB0", Offset = "0x7887B0", VA = "0x180789DB0")]
		private void Update()
		{
		}

		// Token: 0x0600335B RID: 13147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600335B")]
		[Address(RVA = "0x789C20", Offset = "0x788620", VA = "0x180789C20")]
		private void LateUpdate()
		{
		}

		// Token: 0x0600335C RID: 13148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600335C")]
		[Address(RVA = "0x789C30", Offset = "0x788630", VA = "0x180789C30")]
		private void Set()
		{
		}

		// Token: 0x0600335D RID: 13149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600335D")]
		[Address(RVA = "0x789DC0", Offset = "0x7887C0", VA = "0x180789DC0")]
		public SetTransform()
		{
		}

		// Token: 0x0400239E RID: 9118
		[Token(Token = "0x400239E")]
		[FieldOffset(Offset = "0x20")]
		[Header("Frequency Settings")]
		public bool SetOnAwake;

		// Token: 0x0400239F RID: 9119
		[Token(Token = "0x400239F")]
		[FieldOffset(Offset = "0x21")]
		public bool SetOnUpdate;

		// Token: 0x040023A0 RID: 9120
		[Token(Token = "0x40023A0")]
		[FieldOffset(Offset = "0x22")]
		public bool SetOnLateUpdate;

		// Token: 0x040023A1 RID: 9121
		[Token(Token = "0x40023A1")]
		[FieldOffset(Offset = "0x23")]
		[Header("Transform Settings")]
		public bool SetPosition;

		// Token: 0x040023A2 RID: 9122
		[Token(Token = "0x40023A2")]
		[FieldOffset(Offset = "0x24")]
		public Vector3 LocalPosition;

		// Token: 0x040023A3 RID: 9123
		[Token(Token = "0x40023A3")]
		[FieldOffset(Offset = "0x30")]
		public bool SetRotation;

		// Token: 0x040023A4 RID: 9124
		[Token(Token = "0x40023A4")]
		[FieldOffset(Offset = "0x34")]
		public Vector3 LocalRotation;

		// Token: 0x040023A5 RID: 9125
		[Token(Token = "0x40023A5")]
		[FieldOffset(Offset = "0x40")]
		public bool SetScale;

		// Token: 0x040023A6 RID: 9126
		[Token(Token = "0x40023A6")]
		[FieldOffset(Offset = "0x44")]
		public Vector3 LocalScale;
	}
}
