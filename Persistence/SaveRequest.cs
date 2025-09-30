using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace ScheduleOne.Persistence
{
	// Token: 0x020003AA RID: 938
	[Token(Token = "0x20003AA")]
	public class SaveRequest
	{
		// Token: 0x170003FA RID: 1018
		// (get) Token: 0x0600151E RID: 5406 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600151F RID: 5407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003FA")]
		public string SaveString
		{
			[Token(Token = "0x600151E")]
			[Address(RVA = "0x42FFC0", Offset = "0x42E9C0", VA = "0x18042FFC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600151F")]
			[Address(RVA = "0x42FFF0", Offset = "0x42E9F0", VA = "0x18042FFF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06001520 RID: 5408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001520")]
		[Address(RVA = "0x5D54A0", Offset = "0x5D3EA0", VA = "0x1805D54A0")]
		public SaveRequest(ISaveable saveable, string parentFolderPath)
		{
		}

		// Token: 0x06001521 RID: 5409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001521")]
		[Address(RVA = "0x5D5340", Offset = "0x5D3D40", VA = "0x1805D5340")]
		public void Complete()
		{
		}

		// Token: 0x04001398 RID: 5016
		[Token(Token = "0x4001398")]
		[FieldOffset(Offset = "0x10")]
		public ISaveable Saveable;

		// Token: 0x04001399 RID: 5017
		[Token(Token = "0x4001399")]
		[FieldOffset(Offset = "0x18")]
		public string ParentFolderPath;
	}
}
