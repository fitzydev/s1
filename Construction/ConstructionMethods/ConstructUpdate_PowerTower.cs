using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.ConstructableScripts;
using ScheduleOne.DevUtilities;
using ScheduleOne.ObjectScripts;
using ScheduleOne.Property.Utilities.Power;
using UnityEngine;

namespace ScheduleOne.Construction.ConstructionMethods
{
	// Token: 0x020007A6 RID: 1958
	[Token(Token = "0x20007A6")]
	public class ConstructUpdate_PowerTower : ConstructUpdate_OutdoorGrid
	{
		// Token: 0x060034CB RID: 13515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034CB")]
		[Address(RVA = "0x79CF30", Offset = "0x79B930", VA = "0x18079CF30", Slot = "7")]
		protected override void Start()
		{
		}

		// Token: 0x060034CC RID: 13516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034CC")]
		[Address(RVA = "0x79BE10", Offset = "0x79A810", VA = "0x18079BE10", Slot = "6")]
		public override void ConstructionStop()
		{
		}

		// Token: 0x060034CD RID: 13517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034CD")]
		[Address(RVA = "0x79D4D0", Offset = "0x79BED0", VA = "0x18079D4D0", Slot = "4")]
		protected override void Update()
		{
		}

		// Token: 0x060034CE RID: 13518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034CE")]
		[Address(RVA = "0x79C3D0", Offset = "0x79ADD0", VA = "0x18079C3D0", Slot = "5")]
		protected override void LateUpdate()
		{
		}

		// Token: 0x060034CF RID: 13519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034CF")]
		[Address(RVA = "0x79BEB0", Offset = "0x79A8B0", VA = "0x18079BEB0")]
		public void Exit(ExitAction exit)
		{
		}

		// Token: 0x060034D0 RID: 13520 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034D0")]
		[Address(RVA = "0x79C0E0", Offset = "0x79AAE0", VA = "0x18079C0E0")]
		private PowerTower GetHoveredPowerTower()
		{
			return null;
		}

		// Token: 0x060034D1 RID: 13521 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034D1")]
		[Address(RVA = "0x79BF50", Offset = "0x79A950", VA = "0x18079BF50")]
		protected PowerNode GetHoveredPowerNode()
		{
			return null;
		}

		// Token: 0x060034D2 RID: 13522 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034D2")]
		[Address(RVA = "0x79CC40", Offset = "0x79B640", VA = "0x18079CC40", Slot = "9")]
		protected override Constructable_GridBased PlaceNewConstructable()
		{
			return null;
		}

		// Token: 0x060034D3 RID: 13523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034D3")]
		[Address(RVA = "0x79BB90", Offset = "0x79A590", VA = "0x18079BB90")]
		private void CompletePowerLine(PowerNode target)
		{
		}

		// Token: 0x060034D4 RID: 13524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034D4")]
		[Address(RVA = "0x79D3A0", Offset = "0x79BDA0", VA = "0x18079D3A0")]
		private void StopCreatingPowerLine()
		{
		}

		// Token: 0x060034D5 RID: 13525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034D5")]
		[Address(RVA = "0x79DB40", Offset = "0x79C540", VA = "0x18079DB40")]
		public ConstructUpdate_PowerTower()
		{
		}

		// Token: 0x040024AE RID: 9390
		[Token(Token = "0x40024AE")]
		[FieldOffset(Offset = "0x60")]
		[Header("Materials")]
		public Material specialMat;

		// Token: 0x040024AF RID: 9391
		[Token(Token = "0x40024AF")]
		[FieldOffset(Offset = "0x68")]
		public Material powerLine_GhostMat;

		// Token: 0x040024B0 RID: 9392
		[Token(Token = "0x40024B0")]
		[FieldOffset(Offset = "0x70")]
		[Header("References")]
		[SerializeField]
		protected GameObject cosmeticPowerNode;

		// Token: 0x040024B1 RID: 9393
		[Token(Token = "0x40024B1")]
		[FieldOffset(Offset = "0x78")]
		public float LengthFactor;

		// Token: 0x040024B2 RID: 9394
		[Token(Token = "0x40024B2")]
		[FieldOffset(Offset = "0x80")]
		protected Transform tempPowerLineContainer;

		// Token: 0x040024B3 RID: 9395
		[Token(Token = "0x40024B3")]
		[FieldOffset(Offset = "0x88")]
		protected List<Transform> tempSegments;

		// Token: 0x040024B4 RID: 9396
		[Token(Token = "0x40024B4")]
		[FieldOffset(Offset = "0x90")]
		private PowerNode hoveredPowerNode;

		// Token: 0x040024B5 RID: 9397
		[Token(Token = "0x40024B5")]
		[FieldOffset(Offset = "0x98")]
		protected PowerNode startNode;

		// Token: 0x040024B6 RID: 9398
		[Token(Token = "0x40024B6")]
		[FieldOffset(Offset = "0xA0")]
		protected float powerLineInitialDistance;
	}
}
