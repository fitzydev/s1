using System;
using Il2CppDummyDll;
using ScheduleOne.Interaction;
using ScheduleOne.Property;
using ScheduleOne.UI;
using UnityEngine;

namespace ScheduleOne.Market
{
	// Token: 0x020004C3 RID: 1219
	[Token(Token = "0x20004C3")]
	public class BuilderMerchant : MonoBehaviour
	{
		// Token: 0x06001816 RID: 6166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001816")]
		[Address(RVA = "0x5FD890", Offset = "0x5FC290", VA = "0x1805FD890")]
		public void Hovered()
		{
		}

		// Token: 0x06001817 RID: 6167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001817")]
		[Address(RVA = "0x5FDA00", Offset = "0x5FC400", VA = "0x1805FDA00")]
		public void Interacted()
		{
		}

		// Token: 0x06001818 RID: 6168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001818")]
		[Address(RVA = "0x5FDA90", Offset = "0x5FC490", VA = "0x1805FDA90")]
		private void PropertySelected(Property p)
		{
		}

		// Token: 0x06001819 RID: 6169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001819")]
		[Address(RVA = "0x5FDB20", Offset = "0x5FC520", VA = "0x1805FDB20")]
		public BuilderMerchant()
		{
		}

		// Token: 0x040015BC RID: 5564
		[Token(Token = "0x40015BC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Header("Settings")]
		protected int openTime;

		// Token: 0x040015BD RID: 5565
		[Token(Token = "0x40015BD")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		protected int closeTime;

		// Token: 0x040015BE RID: 5566
		[Token(Token = "0x40015BE")]
		[FieldOffset(Offset = "0x28")]
		[Header("References")]
		[SerializeField]
		protected InteractableObject intObj;

		// Token: 0x040015BF RID: 5567
		[Token(Token = "0x40015BF")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private PropertySelector selector;
	}
}
