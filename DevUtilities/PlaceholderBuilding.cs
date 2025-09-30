using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace ScheduleOne.DevUtilities
{
	// Token: 0x02000765 RID: 1893
	[Token(Token = "0x2000765")]
	[ExecuteInEditMode]
	public class PlaceholderBuilding : MonoBehaviour
	{
		// Token: 0x06003345 RID: 13125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003345")]
		[Address(RVA = "0x7873E0", Offset = "0x785DE0", VA = "0x1807873E0")]
		private void Awake()
		{
		}

		// Token: 0x06003346 RID: 13126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003346")]
		[Address(RVA = "0x787470", Offset = "0x785E70", VA = "0x180787470", Slot = "4")]
		protected virtual void LateUpdate()
		{
		}

		// Token: 0x06003347 RID: 13127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003347")]
		[Address(RVA = "0x7879C0", Offset = "0x7863C0", VA = "0x1807879C0")]
		public PlaceholderBuilding()
		{
		}

		// Token: 0x04002393 RID: 9107
		[Token(Token = "0x4002393")]
		[FieldOffset(Offset = "0x20")]
		[Header("Settings")]
		public string Name;

		// Token: 0x04002394 RID: 9108
		[Token(Token = "0x4002394")]
		[FieldOffset(Offset = "0x28")]
		public Vector3 Dimensions;

		// Token: 0x04002395 RID: 9109
		[Token(Token = "0x4002395")]
		[FieldOffset(Offset = "0x34")]
		public bool AutoGround;

		// Token: 0x04002396 RID: 9110
		[Token(Token = "0x4002396")]
		[FieldOffset(Offset = "0x38")]
		[Header("References")]
		public Transform Model;

		// Token: 0x04002397 RID: 9111
		[Token(Token = "0x4002397")]
		[FieldOffset(Offset = "0x40")]
		public TextMeshPro Label;

		// Token: 0x04002398 RID: 9112
		[Token(Token = "0x4002398")]
		[FieldOffset(Offset = "0x48")]
		private Vector3 lastFramePosition;
	}
}
