using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.Vehicles;
using UnityEngine;

namespace ScheduleOne.ConstructableScripts
{
	// Token: 0x020009D9 RID: 2521
	[Token(Token = "0x20009D9")]
	public class LoadingDock : Constructable_GridBased
	{
		// Token: 0x17000992 RID: 2450
		// (get) Token: 0x060044D6 RID: 17622 RVA: 0x00012108 File Offset: 0x00010308
		[Token(Token = "0x17000992")]
		public bool isOccupied
		{
			[Token(Token = "0x60044D6")]
			[Address(RVA = "0x8C87B0", Offset = "0x8C71B0", VA = "0x1808C87B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000993 RID: 2451
		// (get) Token: 0x060044D7 RID: 17623 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060044D8 RID: 17624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000993")]
		public LandVehicle reservant
		{
			[Token(Token = "0x60044D7")]
			[Address(RVA = "0x8C8800", Offset = "0x8C7200", VA = "0x1808C8800")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60044D8")]
			[Address(RVA = "0x8C8810", Offset = "0x8C7210", VA = "0x1808C8810")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x060044D9 RID: 17625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044D9")]
		[Address(RVA = "0x8C85A0", Offset = "0x8C6FA0", VA = "0x1808C85A0")]
		private void Start()
		{
		}

		// Token: 0x060044DA RID: 17626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044DA")]
		[Address(RVA = "0x8C85E0", Offset = "0x8C6FE0", VA = "0x1808C85E0", Slot = "40")]
		protected virtual void Update()
		{
		}

		// Token: 0x060044DB RID: 17627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044DB")]
		[Address(RVA = "0x8C7E30", Offset = "0x8C6830", VA = "0x1808C7E30", Slot = "41")]
		protected virtual void LateUpdate()
		{
		}

		// Token: 0x060044DC RID: 17628 RVA: 0x00012120 File Offset: 0x00010320
		[Token(Token = "0x60044DC")]
		[Address(RVA = "0x8C7C50", Offset = "0x8C6650", VA = "0x1808C7C50", Slot = "20")]
		public override bool CanBeDestroyed(out string reason)
		{
			return default(bool);
		}

		// Token: 0x060044DD RID: 17629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044DD")]
		[Address(RVA = "0x8C7D40", Offset = "0x8C6740", VA = "0x1808C7D40", Slot = "22")]
		public override void DestroyConstructable(bool callOnServer = true)
		{
		}

		// Token: 0x060044DE RID: 17630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044DE")]
		[Address(RVA = "0x8C82F0", Offset = "0x8C6CF0", VA = "0x1808C82F0")]
		public void SetReservant(LandVehicle _res)
		{
		}

		// Token: 0x060044DF RID: 17631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044DF")]
		[Address(RVA = "0x8B7920", Offset = "0x8B6320", VA = "0x1808B7920")]
		public LoadingDock()
		{
		}

		// Token: 0x060044E0 RID: 17632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044E0")]
		[Address(RVA = "0x8C82D0", Offset = "0x8C6CD0", VA = "0x1808C82D0", Slot = "30")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x060044E1 RID: 17633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044E1")]
		[Address(RVA = "0x8C82B0", Offset = "0x8C6CB0", VA = "0x1808C82B0", Slot = "31")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x060044E2 RID: 17634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044E2")]
		[Address(RVA = "0x8434B0", Offset = "0x841EB0", VA = "0x1808434B0", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x060044E3 RID: 17635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044E3")]
		[Address(RVA = "0x8B7870", Offset = "0x8B6270", VA = "0x1808B7870", Slot = "19")]
		public override void Awake()
		{
		}

		// Token: 0x04003051 RID: 12369
		[Token(Token = "0x4003051")]
		[FieldOffset(Offset = "0x228")]
		[Header("References")]
		[SerializeField]
		protected VehicleDetector vehicleDetector;

		// Token: 0x04003052 RID: 12370
		[Token(Token = "0x4003052")]
		[FieldOffset(Offset = "0x230")]
		[SerializeField]
		protected MeshRenderer[] redLightMeshes;

		// Token: 0x04003053 RID: 12371
		[Token(Token = "0x4003053")]
		[FieldOffset(Offset = "0x238")]
		[SerializeField]
		protected MeshRenderer[] greenLightMeshes;

		// Token: 0x04003054 RID: 12372
		[Token(Token = "0x4003054")]
		[FieldOffset(Offset = "0x240")]
		[SerializeField]
		protected Transform[] sideWalls;

		// Token: 0x04003055 RID: 12373
		[Token(Token = "0x4003055")]
		[FieldOffset(Offset = "0x248")]
		[SerializeField]
		protected Animation gateAnim;

		// Token: 0x04003056 RID: 12374
		[Token(Token = "0x4003056")]
		[FieldOffset(Offset = "0x250")]
		[SerializeField]
		protected Collider reservationBlocker;

		// Token: 0x04003057 RID: 12375
		[Token(Token = "0x4003057")]
		[FieldOffset(Offset = "0x258")]
		public Transform vehiclePosition;

		// Token: 0x04003058 RID: 12376
		[Token(Token = "0x4003058")]
		[FieldOffset(Offset = "0x260")]
		[Header("Materials")]
		[SerializeField]
		protected Material redLightMat_On;

		// Token: 0x04003059 RID: 12377
		[Token(Token = "0x4003059")]
		[FieldOffset(Offset = "0x268")]
		[SerializeField]
		protected Material redLightMat_Off;

		// Token: 0x0400305A RID: 12378
		[Token(Token = "0x400305A")]
		[FieldOffset(Offset = "0x270")]
		[SerializeField]
		protected Material greenLightMat_On;

		// Token: 0x0400305B RID: 12379
		[Token(Token = "0x400305B")]
		[FieldOffset(Offset = "0x278")]
		[SerializeField]
		protected Material greenLightMat_Off;

		// Token: 0x0400305C RID: 12380
		[Token(Token = "0x400305C")]
		[FieldOffset(Offset = "0x280")]
		private bool wallsOpen;

		// Token: 0x0400305D RID: 12381
		[Token(Token = "0x400305D")]
		[FieldOffset(Offset = "0x288")]
		private LandVehicle currentOccupant;

		// Token: 0x0400305F RID: 12383
		[Token(Token = "0x400305F")]
		[FieldOffset(Offset = "0x298")]
		private bool NetworkInitialize___EarlyScheduleOne.ConstructableScripts.LoadingDockAssembly-CSharp.dll_Excuted;

		// Token: 0x04003060 RID: 12384
		[Token(Token = "0x4003060")]
		[FieldOffset(Offset = "0x299")]
		private bool NetworkInitialize__LateScheduleOne.ConstructableScripts.LoadingDockAssembly-CSharp.dll_Excuted;
	}
}
