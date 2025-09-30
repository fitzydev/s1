using System;
using Il2CppDummyDll;
using ScheduleOne.Doors;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Property;

namespace ScheduleOne.Building.Doors
{
	// Token: 0x02000837 RID: 2103
	[Token(Token = "0x2000837")]
	public class PropertyDoorController : DoorController
	{
		// Token: 0x060039AC RID: 14764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039AC")]
		[Address(RVA = "0x80A510", Offset = "0x808F10", VA = "0x18080A510", Slot = "19")]
		public override void Awake()
		{
		}

		// Token: 0x060039AD RID: 14765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039AD")]
		[Address(RVA = "0x80AE10", Offset = "0x809810", VA = "0x18080AE10")]
		public void Unlock()
		{
		}

		// Token: 0x060039AE RID: 14766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039AE")]
		[Address(RVA = "0x80A960", Offset = "0x809360", VA = "0x18080A960")]
		private void CheckClose()
		{
		}

		// Token: 0x060039AF RID: 14767 RVA: 0x0000F6C0 File Offset: 0x0000D8C0
		[Token(Token = "0x60039AF")]
		[Address(RVA = "0x80A660", Offset = "0x809060", VA = "0x18080A660", Slot = "26")]
		protected override bool CanPlayerAccess(EDoorSide side, out string reason)
		{
			return default(bool);
		}

		// Token: 0x060039B0 RID: 14768 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039B0")]
		[Address(RVA = "0x80AAC0", Offset = "0x8094C0", VA = "0x18080AAC0")]
		private Player GetNearestWantedPlayer()
		{
			return null;
		}

		// Token: 0x060039B1 RID: 14769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039B1")]
		[Address(RVA = "0x80AE30", Offset = "0x809830", VA = "0x18080AE30")]
		public PropertyDoorController()
		{
		}

		// Token: 0x060039B2 RID: 14770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039B2")]
		[Address(RVA = "0x80ADF0", Offset = "0x8097F0", VA = "0x18080ADF0", Slot = "31")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x060039B3 RID: 14771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039B3")]
		[Address(RVA = "0x80ADD0", Offset = "0x8097D0", VA = "0x18080ADD0", Slot = "32")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x060039B4 RID: 14772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039B4")]
		[Address(RVA = "0x5C22C0", Offset = "0x5C0CC0", VA = "0x1805C22C0", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x060039B5 RID: 14773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039B5")]
		[Address(RVA = "0x80A3F0", Offset = "0x808DF0", VA = "0x18080A3F0", Slot = "34")]
		protected virtual void Awake_UserLogic_ScheduleOne.Building.Doors.PropertyDoorController_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04002804 RID: 10244
		[Token(Token = "0x4002804")]
		public const float WANTED_PLAYER_CLOSE_DISTANCE = 20f;

		// Token: 0x04002805 RID: 10245
		[Token(Token = "0x4002805")]
		[FieldOffset(Offset = "0x190")]
		public Property Property;

		// Token: 0x04002806 RID: 10246
		[Token(Token = "0x4002806")]
		[FieldOffset(Offset = "0x198")]
		private bool IsUnlocked;

		// Token: 0x04002807 RID: 10247
		[Token(Token = "0x4002807")]
		[FieldOffset(Offset = "0x199")]
		private bool NetworkInitialize___EarlyScheduleOne.Building.Doors.PropertyDoorControllerAssembly-CSharp.dll_Excuted;

		// Token: 0x04002808 RID: 10248
		[Token(Token = "0x4002808")]
		[FieldOffset(Offset = "0x19A")]
		private bool NetworkInitialize__LateScheduleOne.Building.Doors.PropertyDoorControllerAssembly-CSharp.dll_Excuted;
	}
}
