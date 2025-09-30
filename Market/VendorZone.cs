using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Market
{
	// Token: 0x020004C7 RID: 1223
	[Token(Token = "0x20004C7")]
	public class VendorZone : MonoBehaviour
	{
		// Token: 0x1700044D RID: 1101
		// (get) Token: 0x06001820 RID: 6176 RVA: 0x00008D60 File Offset: 0x00006F60
		[Token(Token = "0x1700044D")]
		public bool isOpen
		{
			[Token(Token = "0x6001820")]
			[Address(RVA = "0x613A90", Offset = "0x612490", VA = "0x180613A90")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001821 RID: 6177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001821")]
		[Address(RVA = "0x613900", Offset = "0x612300", VA = "0x180613900", Slot = "4")]
		protected virtual void Start()
		{
		}

		// Token: 0x06001822 RID: 6178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001822")]
		[Address(RVA = "0x6136B0", Offset = "0x6120B0", VA = "0x1806136B0")]
		private void MinPassed()
		{
		}

		// Token: 0x06001823 RID: 6179 RVA: 0x00008D78 File Offset: 0x00006F78
		[Token(Token = "0x6001823")]
		[Address(RVA = "0x6135B0", Offset = "0x611FB0", VA = "0x1806135B0")]
		private bool IsPlayerWithinVendorZone()
		{
			return default(bool);
		}

		// Token: 0x06001824 RID: 6180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001824")]
		[Address(RVA = "0x613850", Offset = "0x612250", VA = "0x180613850")]
		private void SetDoorsActive(bool a)
		{
		}

		// Token: 0x06001825 RID: 6181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001825")]
		[Address(RVA = "0x613A00", Offset = "0x612400", VA = "0x180613A00")]
		public VendorZone()
		{
		}

		// Token: 0x040015C4 RID: 5572
		[Token(Token = "0x40015C4")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Header("References")]
		protected BoxCollider zoneCollider;

		// Token: 0x040015C5 RID: 5573
		[Token(Token = "0x40015C5")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		protected List<GameObject> doors;

		// Token: 0x040015C6 RID: 5574
		[Token(Token = "0x40015C6")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Header("Settings")]
		protected int openTime;

		// Token: 0x040015C7 RID: 5575
		[Token(Token = "0x40015C7")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		protected int closeTime;
	}
}
