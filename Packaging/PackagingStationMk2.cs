using System;
using Il2CppDummyDll;
using ScheduleOne.ObjectScripts;

namespace ScheduleOne.Packaging
{
	// Token: 0x02000939 RID: 2361
	[Token(Token = "0x2000939")]
	public class PackagingStationMk2 : PackagingStation
	{
		// Token: 0x0600407A RID: 16506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600407A")]
		[Address(RVA = "0x8688E0", Offset = "0x8672E0", VA = "0x1808688E0", Slot = "131")]
		public override void StartTask()
		{
		}

		// Token: 0x0600407B RID: 16507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600407B")]
		[Address(RVA = "0x868AB0", Offset = "0x8674B0", VA = "0x180868AB0")]
		public PackagingStationMk2()
		{
		}

		// Token: 0x0600407C RID: 16508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600407C")]
		[Address(RVA = "0x8688C0", Offset = "0x8672C0", VA = "0x1808688C0", Slot = "62")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x0600407D RID: 16509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600407D")]
		[Address(RVA = "0x8688A0", Offset = "0x8672A0", VA = "0x1808688A0", Slot = "63")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x0600407E RID: 16510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600407E")]
		[Address(RVA = "0x669880", Offset = "0x668280", VA = "0x180669880", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x0600407F RID: 16511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600407F")]
		[Address(RVA = "0x868850", Offset = "0x867250", VA = "0x180868850", Slot = "47")]
		public override void Awake()
		{
		}

		// Token: 0x04002D53 RID: 11603
		[Token(Token = "0x4002D53")]
		[FieldOffset(Offset = "0x3B0")]
		public PackagingTool PackagingTool;

		// Token: 0x04002D54 RID: 11604
		[Token(Token = "0x4002D54")]
		[FieldOffset(Offset = "0x3B8")]
		private bool NetworkInitialize___EarlyScheduleOne.Packaging.PackagingStationMk2Assembly-CSharp.dll_Excuted;

		// Token: 0x04002D55 RID: 11605
		[Token(Token = "0x4002D55")]
		[FieldOffset(Offset = "0x3B9")]
		private bool NetworkInitialize__LateScheduleOne.Packaging.PackagingStationMk2Assembly-CSharp.dll_Excuted;
	}
}
