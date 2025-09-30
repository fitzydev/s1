using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Trash
{
	// Token: 0x020008CD RID: 2253
	[Token(Token = "0x20008CD")]
	[RequireComponent(typeof(TrashContainer))]
	public class TrashContainerContents : MonoBehaviour
	{
		// Token: 0x06003E5C RID: 15964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E5C")]
		[Address(RVA = "0x850720", Offset = "0x84F120", VA = "0x180850720")]
		protected void Start()
		{
		}

		// Token: 0x06003E5D RID: 15965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E5D")]
		[Address(RVA = "0x8507D0", Offset = "0x84F1D0", VA = "0x1808507D0")]
		private void UpdateVisuals()
		{
		}

		// Token: 0x06003E5E RID: 15966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E5E")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public TrashContainerContents()
		{
		}

		// Token: 0x04002BC8 RID: 11208
		[Token(Token = "0x4002BC8")]
		[FieldOffset(Offset = "0x20")]
		public TrashContainer TrashContainer;

		// Token: 0x04002BC9 RID: 11209
		[Token(Token = "0x4002BC9")]
		[FieldOffset(Offset = "0x28")]
		[Header("References")]
		public Transform ContentsTransform;

		// Token: 0x04002BCA RID: 11210
		[Token(Token = "0x4002BCA")]
		[FieldOffset(Offset = "0x30")]
		public Transform VisualsContainer;

		// Token: 0x04002BCB RID: 11211
		[Token(Token = "0x4002BCB")]
		[FieldOffset(Offset = "0x38")]
		public Transform VisualsMinTransform;

		// Token: 0x04002BCC RID: 11212
		[Token(Token = "0x4002BCC")]
		[FieldOffset(Offset = "0x40")]
		public Transform VisualsMaxTransform;

		// Token: 0x04002BCD RID: 11213
		[Token(Token = "0x4002BCD")]
		[FieldOffset(Offset = "0x48")]
		public Collider Collider;
	}
}
