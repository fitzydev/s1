using System;
using Il2CppDummyDll;
using ScheduleOne.EntityFramework;
using ScheduleOne.Storage;
using UnityEngine;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x02000C78 RID: 3192
	[Token(Token = "0x2000C78")]
	public class BedItem : PlaceableStorageEntity
	{
		// Token: 0x06005661 RID: 22113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005661")]
		[Address(RVA = "0x9C35A0", Offset = "0x9C1FA0", VA = "0x1809C35A0", Slot = "48")]
		protected override void Start()
		{
		}

		// Token: 0x06005662 RID: 22114 RVA: 0x00015678 File Offset: 0x00013878
		[Token(Token = "0x6005662")]
		[Address(RVA = "0x9C31D0", Offset = "0x9C1BD0", VA = "0x1809C31D0")]
		public static bool IsBedValid(BuildableItem obj, out string reason)
		{
			return default(bool);
		}

		// Token: 0x06005663 RID: 22115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005663")]
		[Address(RVA = "0x9C3660", Offset = "0x9C2060", VA = "0x1809C3660")]
		private void UpdateBriefcase()
		{
		}

		// Token: 0x06005664 RID: 22116 RVA: 0x00015690 File Offset: 0x00013890
		[Token(Token = "0x6005664")]
		[Address(RVA = "0x9C3000", Offset = "0x9C1A00", VA = "0x1809C3000")]
		public float GetCashSum()
		{
			return 0f;
		}

		// Token: 0x06005665 RID: 22117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005665")]
		[Address(RVA = "0x9C3380", Offset = "0x9C1D80", VA = "0x1809C3380")]
		public void RemoveCash(float amount)
		{
		}

		// Token: 0x06005666 RID: 22118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005666")]
		[Address(RVA = "0x9C3A60", Offset = "0x9C2460", VA = "0x1809C3A60")]
		public BedItem()
		{
		}

		// Token: 0x06005667 RID: 22119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005667")]
		[Address(RVA = "0x9C3360", Offset = "0x9C1D60", VA = "0x1809C3360", Slot = "62")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06005668 RID: 22120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005668")]
		[Address(RVA = "0x9C3340", Offset = "0x9C1D40", VA = "0x1809C3340", Slot = "63")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06005669 RID: 22121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005669")]
		[Address(RVA = "0x669880", Offset = "0x668280", VA = "0x180669880", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x0600566A RID: 22122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600566A")]
		[Address(RVA = "0x9C2FB0", Offset = "0x9C19B0", VA = "0x1809C2FB0", Slot = "47")]
		public override void Awake()
		{
		}

		// Token: 0x04004007 RID: 16391
		[Token(Token = "0x4004007")]
		[FieldOffset(Offset = "0x288")]
		public Bed Bed;

		// Token: 0x04004008 RID: 16392
		[Token(Token = "0x4004008")]
		[FieldOffset(Offset = "0x290")]
		public StorageEntity Storage;

		// Token: 0x04004009 RID: 16393
		[Token(Token = "0x4004009")]
		[FieldOffset(Offset = "0x298")]
		public GameObject Briefcase;

		// Token: 0x0400400A RID: 16394
		[Token(Token = "0x400400A")]
		[FieldOffset(Offset = "0x2A0")]
		private bool NetworkInitialize___EarlyScheduleOne.ObjectScripts.BedItemAssembly-CSharp.dll_Excuted;

		// Token: 0x0400400B RID: 16395
		[Token(Token = "0x400400B")]
		[FieldOffset(Offset = "0x2A1")]
		private bool NetworkInitialize__LateScheduleOne.ObjectScripts.BedItemAssembly-CSharp.dll_Excuted;
	}
}
