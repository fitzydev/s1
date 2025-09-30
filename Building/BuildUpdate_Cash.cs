using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.Interaction;
using UnityEngine;

namespace ScheduleOne.Building
{
	// Token: 0x02000829 RID: 2089
	[Token(Token = "0x2000829")]
	public class BuildUpdate_Cash : BuildUpdate_StoredItem
	{
		// Token: 0x1700081D RID: 2077
		// (get) Token: 0x0600395F RID: 14687 RVA: 0x0000F588 File Offset: 0x0000D788
		[Token(Token = "0x1700081D")]
		private float placeAmount
		{
			[Token(Token = "0x600395F")]
			[Address(RVA = "0x7F9720", Offset = "0x7F8120", VA = "0x1807F9720")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06003960 RID: 14688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003960")]
		[Address(RVA = "0x7F8FD0", Offset = "0x7F79D0", VA = "0x1807F8FD0")]
		private void Start()
		{
		}

		// Token: 0x06003961 RID: 14689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003961")]
		[Address(RVA = "0x7F94D0", Offset = "0x7F7ED0", VA = "0x1807F94D0", Slot = "5")]
		protected override void Update()
		{
		}

		// Token: 0x06003962 RID: 14690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003962")]
		[Address(RVA = "0x7F87B0", Offset = "0x7F71B0", VA = "0x1807F87B0", Slot = "6")]
		protected override void LateUpdate()
		{
		}

		// Token: 0x06003963 RID: 14691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003963")]
		[Address(RVA = "0x7F9200", Offset = "0x7F7C00", VA = "0x1807F9200")]
		private void UpdateLabel()
		{
		}

		// Token: 0x06003964 RID: 14692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003964")]
		[Address(RVA = "0x7F8EC0", Offset = "0x7F78C0", VA = "0x1807F8EC0")]
		private void RefreshGhostModelAppearance()
		{
		}

		// Token: 0x06003965 RID: 14693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003965")]
		[Address(RVA = "0x7F8A70", Offset = "0x7F7470", VA = "0x1807F8A70", Slot = "8")]
		protected override void Place()
		{
		}

		// Token: 0x06003966 RID: 14694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003966")]
		[Address(RVA = "0x7F8DB0", Offset = "0x7F77B0", VA = "0x1807F8DB0", Slot = "9")]
		protected override void PostPlace()
		{
		}

		// Token: 0x06003967 RID: 14695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003967")]
		[Address(RVA = "0x7F91D0", Offset = "0x7F7BD0", VA = "0x1807F91D0", Slot = "4")]
		public override void Stop()
		{
		}

		// Token: 0x06003968 RID: 14696 RVA: 0x0000F5A0 File Offset: 0x0000D7A0
		[Token(Token = "0x6003968")]
		[Address(RVA = "0x7F8730", Offset = "0x7F7130", VA = "0x1807F8730")]
		public float GetRelevantCashBalane()
		{
			return 0f;
		}

		// Token: 0x06003969 RID: 14697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003969")]
		[Address(RVA = "0x7F9650", Offset = "0x7F8050", VA = "0x1807F9650")]
		public BuildUpdate_Cash()
		{
		}

		// Token: 0x040027BB RID: 10171
		[Token(Token = "0x40027BB")]
		[FieldOffset(Offset = "0x70")]
		public int amountIndex;

		// Token: 0x040027BC RID: 10172
		[Token(Token = "0x40027BC")]
		[FieldOffset(Offset = "0x78")]
		protected List<Transform> bills;

		// Token: 0x040027BD RID: 10173
		[Token(Token = "0x40027BD")]
		[FieldOffset(Offset = "0x80")]
		private WorldSpaceLabel amountLabel;
	}
}
