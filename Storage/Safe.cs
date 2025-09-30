using System;
using Il2CppDummyDll;

namespace ScheduleOne.Storage
{
	// Token: 0x0200094F RID: 2383
	[Token(Token = "0x200094F")]
	public class Safe : StorageEntity
	{
		// Token: 0x0600412C RID: 16684 RVA: 0x00011298 File Offset: 0x0000F498
		[Token(Token = "0x600412C")]
		[Address(RVA = "0x885230", Offset = "0x883C30", VA = "0x180885230")]
		public float GetCash()
		{
			return 0f;
		}

		// Token: 0x0600412D RID: 16685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600412D")]
		[Address(RVA = "0x8853F0", Offset = "0x883DF0", VA = "0x1808853F0")]
		public void RemoveCash(float amount)
		{
		}

		// Token: 0x0600412E RID: 16686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600412E")]
		[Address(RVA = "0x85FF50", Offset = "0x85E950", VA = "0x18085FF50")]
		public Safe()
		{
		}

		// Token: 0x0600412F RID: 16687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600412F")]
		[Address(RVA = "0x85FF30", Offset = "0x85E930", VA = "0x18085FF30", Slot = "36")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06004130 RID: 16688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004130")]
		[Address(RVA = "0x8853C0", Offset = "0x883DC0", VA = "0x1808853C0", Slot = "37")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06004131 RID: 16689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004131")]
		[Address(RVA = "0x85FED0", Offset = "0x85E8D0", VA = "0x18085FED0", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06004132 RID: 16690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004132")]
		[Address(RVA = "0x85FE80", Offset = "0x85E880", VA = "0x18085FE80", Slot = "28")]
		public override void Awake()
		{
		}

		// Token: 0x04002DD8 RID: 11736
		[Token(Token = "0x4002DD8")]
		[FieldOffset(Offset = "0x170")]
		private bool NetworkInitialize___EarlyScheduleOne.Storage.SafeAssembly-CSharp.dll_Excuted;

		// Token: 0x04002DD9 RID: 11737
		[Token(Token = "0x4002DD9")]
		[FieldOffset(Offset = "0x171")]
		private bool NetworkInitialize__LateScheduleOne.Storage.SafeAssembly-CSharp.dll_Excuted;
	}
}
