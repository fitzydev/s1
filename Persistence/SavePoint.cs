using System;
using Il2CppDummyDll;
using ScheduleOne.Interaction;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Persistence
{
	// Token: 0x020003A9 RID: 937
	[Token(Token = "0x20003A9")]
	public class SavePoint : MonoBehaviour
	{
		// Token: 0x06001516 RID: 5398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001516")]
		[Address(RVA = "0x5D4B00", Offset = "0x5D3500", VA = "0x1805D4B00")]
		public void Awake()
		{
		}

		// Token: 0x06001517 RID: 5399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001517")]
		[Address(RVA = "0x5D5020", Offset = "0x5D3A20", VA = "0x1805D5020")]
		public void Hovered()
		{
		}

		// Token: 0x06001518 RID: 5400 RVA: 0x00008790 File Offset: 0x00006990
		[Token(Token = "0x6001518")]
		[Address(RVA = "0x5D4E40", Offset = "0x5D3840", VA = "0x1805D4E40")]
		private bool CanSave(out string reason)
		{
			return default(bool);
		}

		// Token: 0x06001519 RID: 5401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001519")]
		[Address(RVA = "0x5D51E0", Offset = "0x5D3BE0", VA = "0x1805D51E0")]
		public void Interacted()
		{
		}

		// Token: 0x0600151A RID: 5402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600151A")]
		[Address(RVA = "0x5D52C0", Offset = "0x5D3CC0", VA = "0x1805D52C0")]
		private void Save()
		{
		}

		// Token: 0x0600151B RID: 5403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600151B")]
		[Address(RVA = "0x5D52A0", Offset = "0x5D3CA0", VA = "0x1805D52A0")]
		public void OnSaveStart()
		{
		}

		// Token: 0x0600151C RID: 5404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600151C")]
		[Address(RVA = "0x5D5280", Offset = "0x5D3C80", VA = "0x1805D5280")]
		public void OnSaveComplete()
		{
		}

		// Token: 0x0600151D RID: 5405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600151D")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public SavePoint()
		{
		}

		// Token: 0x04001394 RID: 5012
		[Token(Token = "0x4001394")]
		public const float SAVE_COOLDOWN = 60f;

		// Token: 0x04001395 RID: 5013
		[Token(Token = "0x4001395")]
		[FieldOffset(Offset = "0x20")]
		public InteractableObject IntObj;

		// Token: 0x04001396 RID: 5014
		[Token(Token = "0x4001396")]
		[FieldOffset(Offset = "0x28")]
		public UnityEvent onSaveStart;

		// Token: 0x04001397 RID: 5015
		[Token(Token = "0x4001397")]
		[FieldOffset(Offset = "0x30")]
		public UnityEvent onSaveComplete;
	}
}
