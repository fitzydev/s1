using System;
using Il2CppDummyDll;
using ScheduleOne.ConstructableScripts;
using UnityEngine;

namespace ScheduleOne.Construction.ConstructionMethods
{
	// Token: 0x020007A3 RID: 1955
	[Token(Token = "0x20007A3")]
	public class ConstructUpdate_Base : MonoBehaviour
	{
		// Token: 0x170007A7 RID: 1959
		// (get) Token: 0x060034B1 RID: 13489 RVA: 0x0000E670 File Offset: 0x0000C870
		[Token(Token = "0x170007A7")]
		public bool isMoving
		{
			[Token(Token = "0x60034B1")]
			[Address(RVA = "0x7984C0", Offset = "0x796EC0", VA = "0x1807984C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060034B2 RID: 13490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034B2")]
		[Address(RVA = "0x42DA80", Offset = "0x42C480", VA = "0x18042DA80", Slot = "4")]
		protected virtual void Update()
		{
		}

		// Token: 0x060034B3 RID: 13491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034B3")]
		[Address(RVA = "0x42DA80", Offset = "0x42C480", VA = "0x18042DA80", Slot = "5")]
		protected virtual void LateUpdate()
		{
		}

		// Token: 0x060034B4 RID: 13492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034B4")]
		[Address(RVA = "0x798440", Offset = "0x796E40", VA = "0x180798440", Slot = "6")]
		public virtual void ConstructionStop()
		{
		}

		// Token: 0x060034B5 RID: 13493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034B5")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public ConstructUpdate_Base()
		{
		}

		// Token: 0x0400249E RID: 9374
		[Token(Token = "0x400249E")]
		[FieldOffset(Offset = "0x20")]
		public Constructable_GridBased MovedConstructable;
	}
}
