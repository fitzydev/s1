using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using ScheduleOne.ConstructableScripts;
using UnityEngine;

namespace ScheduleOne.Construction.ConstructionMethods
{
	// Token: 0x020007A0 RID: 1952
	[Token(Token = "0x20007A0")]
	public class ConstructStart_OutdoorGrid : ConstructStart_Base
	{
		// Token: 0x060034AB RID: 13483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034AB")]
		[Address(RVA = "0x798150", Offset = "0x796B50", VA = "0x180798150", Slot = "4")]
		public override void StartConstruction(string constructableID, [Optional] Constructable_GridBased movedConstructable)
		{
		}

		// Token: 0x060034AC RID: 13484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034AC")]
		[Address(RVA = "0x797DE0", Offset = "0x7967E0", VA = "0x180797DE0")]
		private void GenerateGhostModel(string id)
		{
		}

		// Token: 0x060034AD RID: 13485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034AD")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public ConstructStart_OutdoorGrid()
		{
		}

		// Token: 0x0400249C RID: 9372
		[Token(Token = "0x400249C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Constructable_GridBased constructable;

		// Token: 0x0400249D RID: 9373
		[Token(Token = "0x400249D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform ghostModel;
	}
}
