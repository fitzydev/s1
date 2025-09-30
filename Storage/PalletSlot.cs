using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Storage
{
	// Token: 0x0200094C RID: 2380
	[Token(Token = "0x200094C")]
	public class PalletSlot : MonoBehaviour, IGUIDRegisterable
	{
		// Token: 0x17000917 RID: 2327
		// (get) Token: 0x0600411C RID: 16668 RVA: 0x00011250 File Offset: 0x0000F450
		// (set) Token: 0x0600411D RID: 16669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000917")]
		public Guid GUID
		{
			[Token(Token = "0x600411C")]
			[Address(RVA = "0x4A3B70", Offset = "0x4A2570", VA = "0x1804A3B70", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Token(Token = "0x600411D")]
			[Address(RVA = "0x4A3B80", Offset = "0x4A2580", VA = "0x1804A3B80")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x0600411E RID: 16670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600411E")]
		[Address(RVA = "0x880720", Offset = "0x87F120", VA = "0x180880720", Slot = "6")]
		public void SetGUID(Guid guid)
		{
		}

		// Token: 0x17000918 RID: 2328
		// (get) Token: 0x0600411F RID: 16671 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004120 RID: 16672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000918")]
		public Pallet occupant
		{
			[Token(Token = "0x600411F")]
			[Address(RVA = "0x4423A0", Offset = "0x440DA0", VA = "0x1804423A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004120")]
			[Address(RVA = "0x4423D0", Offset = "0x440DD0", VA = "0x1804423D0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06004121 RID: 16673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004121")]
		[Address(RVA = "0x880780", Offset = "0x87F180", VA = "0x180880780")]
		public void SetOccupant(Pallet _occupant)
		{
		}

		// Token: 0x06004122 RID: 16674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004122")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public PalletSlot()
		{
		}

		// Token: 0x04002DD2 RID: 11730
		[Token(Token = "0x4002DD2")]
		[FieldOffset(Offset = "0x38")]
		public Action onPalletAdded;

		// Token: 0x04002DD3 RID: 11731
		[Token(Token = "0x4002DD3")]
		[FieldOffset(Offset = "0x40")]
		public Action onPalletRemoved;
	}
}
