using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.PlayerTasks
{
	// Token: 0x0200034E RID: 846
	[Token(Token = "0x200034E")]
	public class Moveable : Clickable
	{
		// Token: 0x060012A7 RID: 4775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012A7")]
		[Address(RVA = "0x599580", Offset = "0x597F80", VA = "0x180599580", Slot = "6")]
		public override void StartClick(RaycastHit hit)
		{
		}

		// Token: 0x060012A8 RID: 4776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012A8")]
		[Address(RVA = "0x5998A0", Offset = "0x5982A0", VA = "0x1805998A0", Slot = "8")]
		protected virtual void Update()
		{
		}

		// Token: 0x060012A9 RID: 4777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012A9")]
		[Address(RVA = "0x590570", Offset = "0x58EF70", VA = "0x180590570", Slot = "7")]
		public override void EndClick()
		{
		}

		// Token: 0x060012AA RID: 4778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012AA")]
		[Address(RVA = "0x599B80", Offset = "0x598580", VA = "0x180599B80")]
		public Moveable()
		{
		}

		// Token: 0x040011CB RID: 4555
		[Token(Token = "0x40011CB")]
		[FieldOffset(Offset = "0x50")]
		protected Vector3 clickOffset;

		// Token: 0x040011CC RID: 4556
		[Token(Token = "0x40011CC")]
		[FieldOffset(Offset = "0x5C")]
		protected float clickDist;

		// Token: 0x040011CD RID: 4557
		[Token(Token = "0x40011CD")]
		[FieldOffset(Offset = "0x60")]
		[Header("Bounds")]
		[SerializeField]
		protected float yMax;

		// Token: 0x040011CE RID: 4558
		[Token(Token = "0x40011CE")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		protected float yMin;
	}
}
