using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.ObjectScripts;
using ScheduleOne.Packaging;

namespace ScheduleOne.PlayerTasks
{
	// Token: 0x0200035F RID: 863
	[Token(Token = "0x200035F")]
	public class PackageProductTask : Task
	{
		// Token: 0x1700039F RID: 927
		// (get) Token: 0x0600131D RID: 4893 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600131E RID: 4894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700039F")]
		public override string TaskName
		{
			[Token(Token = "0x600131D")]
			[Address(RVA = "0x5904C0", Offset = "0x58EEC0", VA = "0x1805904C0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600131E")]
			[Address(RVA = "0x5904E0", Offset = "0x58EEE0", VA = "0x1805904E0", Slot = "5")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x0600131F RID: 4895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600131F")]
		[Address(RVA = "0x5B22B0", Offset = "0x5B0CB0", VA = "0x1805B22B0")]
		public PackageProductTask(PackagingStation _station)
		{
		}

		// Token: 0x06001320 RID: 4896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001320")]
		[Address(RVA = "0x5B1E80", Offset = "0x5B0880", VA = "0x1805B1E80", Slot = "6")]
		public override void StopTask()
		{
		}

		// Token: 0x06001321 RID: 4897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001321")]
		[Address(RVA = "0x5B2270", Offset = "0x5B0C70", VA = "0x1805B2270", Slot = "7")]
		public override void Success()
		{
		}

		// Token: 0x06001322 RID: 4898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001322")]
		[Address(RVA = "0x5B1DF0", Offset = "0x5B07F0", VA = "0x1805B1DF0")]
		private void FullyPacked()
		{
		}

		// Token: 0x06001323 RID: 4899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001323")]
		[Address(RVA = "0x5B1E20", Offset = "0x5B0820", VA = "0x1805B1E20")]
		private void Sealed()
		{
		}

		// Token: 0x06001324 RID: 4900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001324")]
		[Address(RVA = "0x4B7C10", Offset = "0x4B6610", VA = "0x1804B7C10")]
		private void ReachedOutput()
		{
		}

		// Token: 0x04001237 RID: 4663
		[Token(Token = "0x4001237")]
		[FieldOffset(Offset = "0xA0")]
		protected PackagingStation station;

		// Token: 0x04001238 RID: 4664
		[Token(Token = "0x4001238")]
		[FieldOffset(Offset = "0xA8")]
		protected FunctionalPackaging Packaging;

		// Token: 0x04001239 RID: 4665
		[Token(Token = "0x4001239")]
		[FieldOffset(Offset = "0xB0")]
		protected List<FunctionalProduct> Products;
	}
}
