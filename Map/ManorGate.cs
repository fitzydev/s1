using System;
using EasyButtons;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.Interaction;
using ScheduleOne.Tools;
using UnityEngine;

namespace ScheduleOne.Map
{
	// Token: 0x02000CF5 RID: 3317
	[Token(Token = "0x2000CF5")]
	public class ManorGate : Gate
	{
		// Token: 0x06005DE2 RID: 24034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DE2")]
		[Address(RVA = "0xA5DC10", Offset = "0xA5C610", VA = "0x180A5DC10", Slot = "22")]
		protected virtual void Start()
		{
		}

		// Token: 0x06005DE3 RID: 24035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DE3")]
		[Address(RVA = "0xA5DD20", Offset = "0xA5C720", VA = "0x180A5DD20")]
		private void UpdateDetection()
		{
		}

		// Token: 0x06005DE4 RID: 24036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DE4")]
		[Address(RVA = "0xA5D9B0", Offset = "0xA5C3B0", VA = "0x180A5D9B0")]
		public void IntercomBuzzed()
		{
		}

		// Token: 0x06005DE5 RID: 24037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DE5")]
		[Address(RVA = "0xA5DB10", Offset = "0xA5C510", VA = "0x180A5DB10")]
		public void SetEnterable(bool enterable)
		{
		}

		// Token: 0x06005DE6 RID: 24038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DE6")]
		[Address(RVA = "0xA5D8F0", Offset = "0xA5C2F0", VA = "0x180A5D8F0")]
		[Button]
		public void ActivateIntercom()
		{
		}

		// Token: 0x06005DE7 RID: 24039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DE7")]
		[Address(RVA = "0xA5DBC0", Offset = "0xA5C5C0", VA = "0x180A5DBC0")]
		public void SetIntercomActive(bool active)
		{
		}

		// Token: 0x06005DE8 RID: 24040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DE8")]
		[Address(RVA = "0xA5E050", Offset = "0xA5CA50", VA = "0x180A5E050")]
		private void UpdateIntercom()
		{
		}

		// Token: 0x06005DE9 RID: 24041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DE9")]
		[Address(RVA = "0xA5C9B0", Offset = "0xA5B3B0", VA = "0x180A5C9B0")]
		public ManorGate()
		{
		}

		// Token: 0x06005DEA RID: 24042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DEA")]
		[Address(RVA = "0xA5DA30", Offset = "0xA5C430", VA = "0x180A5DA30", Slot = "19")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06005DEB RID: 24043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DEB")]
		[Address(RVA = "0xA5DA00", Offset = "0xA5C400", VA = "0x180A5DA00", Slot = "20")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06005DEC RID: 24044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DEC")]
		[Address(RVA = "0x601B00", Offset = "0x600500", VA = "0x180601B00", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06005DED RID: 24045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DED")]
		[Address(RVA = "0xA5D940", Offset = "0xA5C340", VA = "0x180A5D940", Slot = "21")]
		public override void Awake()
		{
		}

		// Token: 0x0400443F RID: 17471
		[Token(Token = "0x400443F")]
		[FieldOffset(Offset = "0x190")]
		[Header("References")]
		public InteractableObject IntercomInt;

		// Token: 0x04004440 RID: 17472
		[Token(Token = "0x4004440")]
		[FieldOffset(Offset = "0x198")]
		public Light IntercomLight;

		// Token: 0x04004441 RID: 17473
		[Token(Token = "0x4004441")]
		[FieldOffset(Offset = "0x1A0")]
		public VehicleDetector ExteriorVehicleDetector;

		// Token: 0x04004442 RID: 17474
		[Token(Token = "0x4004442")]
		[FieldOffset(Offset = "0x1A8")]
		public PlayerDetector ExteriorPlayerDetector;

		// Token: 0x04004443 RID: 17475
		[Token(Token = "0x4004443")]
		[FieldOffset(Offset = "0x1B0")]
		public VehicleDetector InteriorVehicleDetector;

		// Token: 0x04004444 RID: 17476
		[Token(Token = "0x4004444")]
		[FieldOffset(Offset = "0x1B8")]
		public PlayerDetector InteriorPlayerDetector;

		// Token: 0x04004445 RID: 17477
		[Token(Token = "0x4004445")]
		[FieldOffset(Offset = "0x1C0")]
		private bool intercomActive;

		// Token: 0x04004446 RID: 17478
		[Token(Token = "0x4004446")]
		[FieldOffset(Offset = "0x1C1")]
		private bool NetworkInitialize___EarlyScheduleOne.Map.ManorGateAssembly-CSharp.dll_Excuted;

		// Token: 0x04004447 RID: 17479
		[Token(Token = "0x4004447")]
		[FieldOffset(Offset = "0x1C2")]
		private bool NetworkInitialize__LateScheduleOne.Map.ManorGateAssembly-CSharp.dll_Excuted;
	}
}
