using System;
using Il2CppDummyDll;
using ScheduleOne.ConstructableScripts;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x02000CC8 RID: 3272
	[Token(Token = "0x2000CC8")]
	public class PowerTower : Constructable_GridBased
	{
		// Token: 0x06005CB0 RID: 23728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CB0")]
		[Address(RVA = "0x8B7920", Offset = "0x8B6320", VA = "0x1808B7920")]
		public PowerTower()
		{
		}

		// Token: 0x06005CB1 RID: 23729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CB1")]
		[Address(RVA = "0x8B7900", Offset = "0x8B6300", VA = "0x1808B7900", Slot = "30")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06005CB2 RID: 23730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CB2")]
		[Address(RVA = "0x8B78E0", Offset = "0x8B62E0", VA = "0x1808B78E0", Slot = "31")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06005CB3 RID: 23731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CB3")]
		[Address(RVA = "0x8434B0", Offset = "0x841EB0", VA = "0x1808434B0", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06005CB4 RID: 23732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CB4")]
		[Address(RVA = "0xA4E9D0", Offset = "0xA4D3D0", VA = "0x180A4E9D0", Slot = "19")]
		public override void Awake()
		{
		}

		// Token: 0x04004352 RID: 17234
		[Token(Token = "0x4004352")]
		[FieldOffset(Offset = "0x228")]
		private bool NetworkInitialize___EarlyScheduleOne.ObjectScripts.PowerTowerAssembly-CSharp.dll_Excuted;

		// Token: 0x04004353 RID: 17235
		[Token(Token = "0x4004353")]
		[FieldOffset(Offset = "0x229")]
		private bool NetworkInitialize__LateScheduleOne.ObjectScripts.PowerTowerAssembly-CSharp.dll_Excuted;
	}
}
