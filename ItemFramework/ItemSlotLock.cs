using System;
using System.Runtime.CompilerServices;
using FishNet.Object;
using Il2CppDummyDll;

namespace ScheduleOne.ItemFramework
{
	// Token: 0x02000A01 RID: 2561
	[Token(Token = "0x2000A01")]
	public class ItemSlotLock
	{
		// Token: 0x170009C3 RID: 2499
		// (get) Token: 0x06004617 RID: 17943 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004618 RID: 17944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009C3")]
		public ItemSlot Slot
		{
			[Token(Token = "0x6004617")]
			[Address(RVA = "0x42FFD0", Offset = "0x42E9D0", VA = "0x18042FFD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004618")]
			[Address(RVA = "0x4A4990", Offset = "0x4A3390", VA = "0x1804A4990")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170009C4 RID: 2500
		// (get) Token: 0x06004619 RID: 17945 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600461A RID: 17946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009C4")]
		public NetworkObject LockOwner
		{
			[Token(Token = "0x6004619")]
			[Address(RVA = "0x42FFB0", Offset = "0x42E9B0", VA = "0x18042FFB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600461A")]
			[Address(RVA = "0x42FFE0", Offset = "0x42E9E0", VA = "0x18042FFE0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170009C5 RID: 2501
		// (get) Token: 0x0600461B RID: 17947 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600461C RID: 17948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009C5")]
		public string LockReason
		{
			[Token(Token = "0x600461B")]
			[Address(RVA = "0x42FFC0", Offset = "0x42E9C0", VA = "0x18042FFC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600461C")]
			[Address(RVA = "0x42FFF0", Offset = "0x42E9F0", VA = "0x18042FFF0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x0600461D RID: 17949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600461D")]
		[Address(RVA = "0x8C58C0", Offset = "0x8C42C0", VA = "0x1808C58C0")]
		public ItemSlotLock(ItemSlot slot, NetworkObject lockOwner, string lockReason)
		{
		}
	}
}
