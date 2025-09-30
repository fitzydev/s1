using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.Property.Utilities.Power;
using UnityEngine;

namespace ScheduleOne.Construction.ConstructionMethods
{
	// Token: 0x020007A5 RID: 1957
	[Token(Token = "0x20007A5")]
	public class ConstructUpdate_PowerLine : ConstructUpdate_Base
	{
		// Token: 0x060034C2 RID: 13506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034C2")]
		[Address(RVA = "0x79B160", Offset = "0x799B60", VA = "0x18079B160", Slot = "7")]
		protected virtual void Start()
		{
		}

		// Token: 0x060034C3 RID: 13507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034C3")]
		[Address(RVA = "0x79A5E0", Offset = "0x798FE0", VA = "0x18079A5E0", Slot = "6")]
		public override void ConstructionStop()
		{
		}

		// Token: 0x060034C4 RID: 13508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034C4")]
		[Address(RVA = "0x79A6E0", Offset = "0x7990E0", VA = "0x18079A6E0")]
		public void Exit(ExitAction exit)
		{
		}

		// Token: 0x060034C5 RID: 13509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034C5")]
		[Address(RVA = "0x79B550", Offset = "0x799F50", VA = "0x18079B550", Slot = "4")]
		protected override void Update()
		{
		}

		// Token: 0x060034C6 RID: 13510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034C6")]
		[Address(RVA = "0x79A910", Offset = "0x799310", VA = "0x18079A910", Slot = "5")]
		protected override void LateUpdate()
		{
		}

		// Token: 0x060034C7 RID: 13511 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034C7")]
		[Address(RVA = "0x79A780", Offset = "0x799180", VA = "0x18079A780")]
		protected PowerNode GetHoveredPowerNode()
		{
			return null;
		}

		// Token: 0x060034C8 RID: 13512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034C8")]
		[Address(RVA = "0x79A120", Offset = "0x798B20", VA = "0x18079A120")]
		private void CompletePowerLine(PowerNode target)
		{
		}

		// Token: 0x060034C9 RID: 13513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034C9")]
		[Address(RVA = "0x79B4A0", Offset = "0x799EA0", VA = "0x18079B4A0")]
		private void StopCreatingPowerLine()
		{
		}

		// Token: 0x060034CA RID: 13514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034CA")]
		[Address(RVA = "0x79BB10", Offset = "0x79A510", VA = "0x18079BB10")]
		public ConstructUpdate_PowerLine()
		{
		}

		// Token: 0x040024A7 RID: 9383
		[Token(Token = "0x40024A7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Header("Settings")]
		protected Material ghostPowerLine_Material;

		// Token: 0x040024A8 RID: 9384
		[Token(Token = "0x40024A8")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Header("References")]
		protected GameObject cosmeticPowerNode;

		// Token: 0x040024A9 RID: 9385
		[Token(Token = "0x40024A9")]
		[FieldOffset(Offset = "0x38")]
		protected Transform tempPowerLineContainer;

		// Token: 0x040024AA RID: 9386
		[Token(Token = "0x40024AA")]
		[FieldOffset(Offset = "0x40")]
		protected PowerNode hoveredPowerNode;

		// Token: 0x040024AB RID: 9387
		[Token(Token = "0x40024AB")]
		[FieldOffset(Offset = "0x48")]
		protected List<Transform> tempSegments;

		// Token: 0x040024AC RID: 9388
		[Token(Token = "0x40024AC")]
		[FieldOffset(Offset = "0x50")]
		protected PowerNode startNode;

		// Token: 0x040024AD RID: 9389
		[Token(Token = "0x40024AD")]
		[FieldOffset(Offset = "0x58")]
		protected float powerLineInitialDistance;
	}
}
