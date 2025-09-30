using System;
using Il2CppDummyDll;
using ScheduleOne.Interaction;

namespace ScheduleOne.Storage
{
	// Token: 0x02000953 RID: 2387
	[Token(Token = "0x2000953")]
	public class StorageEntityInteractable : InteractableObject
	{
		// Token: 0x06004184 RID: 16772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004184")]
		[Address(RVA = "0x886930", Offset = "0x885330", VA = "0x180886930")]
		private void Awake()
		{
		}

		// Token: 0x06004185 RID: 16773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004185")]
		[Address(RVA = "0x8869A0", Offset = "0x8853A0", VA = "0x1808869A0", Slot = "4")]
		public override void Hovered()
		{
		}

		// Token: 0x06004186 RID: 16774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004186")]
		[Address(RVA = "0x8869F0", Offset = "0x8853F0", VA = "0x1808869F0", Slot = "5")]
		public override void StartInteract()
		{
		}

		// Token: 0x06004187 RID: 16775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004187")]
		[Address(RVA = "0x886B40", Offset = "0x885540", VA = "0x180886B40")]
		public StorageEntityInteractable()
		{
		}

		// Token: 0x04002DEE RID: 11758
		[Token(Token = "0x4002DEE")]
		[FieldOffset(Offset = "0x70")]
		private StorageEntity StorageEntity;
	}
}
