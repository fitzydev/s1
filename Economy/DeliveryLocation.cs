using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Map;
using ScheduleOne.Quests;
using UnityEngine;

namespace ScheduleOne.Economy
{
	// Token: 0x020005ED RID: 1517
	[Token(Token = "0x20005ED")]
	public class DeliveryLocation : MonoBehaviour, IGUIDRegisterable
	{
		// Token: 0x1700062A RID: 1578
		// (get) Token: 0x0600253D RID: 9533 RVA: 0x0000B910 File Offset: 0x00009B10
		// (set) Token: 0x0600253E RID: 9534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700062A")]
		public Guid GUID
		{
			[Token(Token = "0x600253D")]
			[Address(RVA = "0x51F4A0", Offset = "0x51DEA0", VA = "0x18051F4A0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Token(Token = "0x600253E")]
			[Address(RVA = "0x6D1F40", Offset = "0x6D0940", VA = "0x1806D1F40")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x0600253F RID: 9535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600253F")]
		[Address(RVA = "0x6E02D0", Offset = "0x6DECD0", VA = "0x1806E02D0", Slot = "6")]
		public void SetGUID(Guid guid)
		{
		}

		// Token: 0x06002540 RID: 9536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002540")]
		[Address(RVA = "0x6E0120", Offset = "0x6DEB20", VA = "0x1806E0120")]
		private void Awake()
		{
		}

		// Token: 0x06002541 RID: 9537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002541")]
		[Address(RVA = "0x6D19E0", Offset = "0x6D03E0", VA = "0x1806D19E0")]
		private void OnValidate()
		{
		}

		// Token: 0x06002542 RID: 9538 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002542")]
		[Address(RVA = "0x4423C0", Offset = "0x440DC0", VA = "0x1804423C0", Slot = "7")]
		public virtual string GetDescription()
		{
			return null;
		}

		// Token: 0x06002543 RID: 9539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002543")]
		[Address(RVA = "0x6E0330", Offset = "0x6DED30", VA = "0x1806E0330")]
		public DeliveryLocation()
		{
		}

		// Token: 0x04001CBB RID: 7355
		[Token(Token = "0x4001CBB")]
		[FieldOffset(Offset = "0x20")]
		public string LocationName;

		// Token: 0x04001CBC RID: 7356
		[Token(Token = "0x4001CBC")]
		[FieldOffset(Offset = "0x28")]
		public string LocationDescription;

		// Token: 0x04001CBD RID: 7357
		[Token(Token = "0x4001CBD")]
		[FieldOffset(Offset = "0x30")]
		public Transform CustomerStandPoint;

		// Token: 0x04001CBE RID: 7358
		[Token(Token = "0x4001CBE")]
		[FieldOffset(Offset = "0x38")]
		public Transform TeleportPoint;

		// Token: 0x04001CBF RID: 7359
		[Token(Token = "0x4001CBF")]
		[FieldOffset(Offset = "0x40")]
		public POI PoI;

		// Token: 0x04001CC0 RID: 7360
		[Token(Token = "0x4001CC0")]
		[FieldOffset(Offset = "0x48")]
		public string StaticGUID;

		// Token: 0x04001CC1 RID: 7361
		[Token(Token = "0x4001CC1")]
		[FieldOffset(Offset = "0x50")]
		public List<Contract> ScheduledContracts;
	}
}
