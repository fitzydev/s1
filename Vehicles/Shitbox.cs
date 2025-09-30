using System;
using Il2CppDummyDll;
using ScheduleOne.Persistence.Datas;

namespace ScheduleOne.Vehicles
{
	// Token: 0x0200086D RID: 2157
	[Token(Token = "0x200086D")]
	public class Shitbox : LandVehicle
	{
		// Token: 0x06003B86 RID: 15238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B86")]
		[Address(RVA = "0x81FCA0", Offset = "0x81E6A0", VA = "0x18081FCA0")]
		public Shitbox()
		{
		}

		// Token: 0x06003B87 RID: 15239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B87")]
		[Address(RVA = "0x81FC80", Offset = "0x81E680", VA = "0x18081FC80", Slot = "66")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06003B88 RID: 15240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B88")]
		[Address(RVA = "0x81FC60", Offset = "0x81E660", VA = "0x18081FC60", Slot = "67")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06003B89 RID: 15241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B89")]
		[Address(RVA = "0x80E9E0", Offset = "0x80D3E0", VA = "0x18080E9E0", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06003B8A RID: 15242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B8A")]
		[Address(RVA = "0x81FBF0", Offset = "0x81E5F0", VA = "0x18081FBF0", Slot = "45")]
		public override void Awake()
		{
		}

		// Token: 0x0400296A RID: 10602
		[Token(Token = "0x400296A")]
		[FieldOffset(Offset = "0x350")]
		public LoanSharkCarVisuals LoanSharkVisuals;

		// Token: 0x0400296B RID: 10603
		[Token(Token = "0x400296B")]
		[FieldOffset(Offset = "0x358")]
		private bool NetworkInitialize___EarlyScheduleOne.Vehicles.ShitboxAssembly-CSharp.dll_Excuted;

		// Token: 0x0400296C RID: 10604
		[Token(Token = "0x400296C")]
		[FieldOffset(Offset = "0x359")]
		private bool NetworkInitialize__LateScheduleOne.Vehicles.ShitboxAssembly-CSharp.dll_Excuted;

		// Token: 0x0200086E RID: 2158
		[Token(Token = "0x200086E")]
		[Serializable]
		public class LoanSharkVisualsData : SaveData
		{
			// Token: 0x06003B8B RID: 15243 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003B8B")]
			[Address(RVA = "0x5E24A0", Offset = "0x5E0EA0", VA = "0x1805E24A0")]
			public LoanSharkVisualsData()
			{
			}

			// Token: 0x0400296D RID: 10605
			[Token(Token = "0x400296D")]
			[FieldOffset(Offset = "0x28")]
			public bool Enabled;

			// Token: 0x0400296E RID: 10606
			[Token(Token = "0x400296E")]
			[FieldOffset(Offset = "0x29")]
			public bool NoteVisible;
		}
	}
}
