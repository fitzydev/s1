using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Persistence.Loaders;

namespace ScheduleOne.Persistence
{
	// Token: 0x020003A2 RID: 930
	[Token(Token = "0x20003A2")]
	public class LoadRequest
	{
		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x060014E1 RID: 5345 RVA: 0x000086E8 File Offset: 0x000068E8
		// (set) Token: 0x060014E2 RID: 5346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003F0")]
		public bool IsDone
		{
			[Token(Token = "0x60014E1")]
			[Address(RVA = "0x4B9020", Offset = "0x4B7A20", VA = "0x1804B9020")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60014E2")]
			[Address(RVA = "0x4B9030", Offset = "0x4B7A30", VA = "0x1804B9030")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060014E3 RID: 5347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014E3")]
		[Address(RVA = "0x5CDB00", Offset = "0x5CC500", VA = "0x1805CDB00")]
		public LoadRequest(string filePath, Loader loader)
		{
		}

		// Token: 0x060014E4 RID: 5348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014E4")]
		[Address(RVA = "0x5CDA20", Offset = "0x5CC420", VA = "0x1805CDA20")]
		public void Complete()
		{
		}

		// Token: 0x04001366 RID: 4966
		[Token(Token = "0x4001366")]
		[FieldOffset(Offset = "0x10")]
		public string Path;

		// Token: 0x04001367 RID: 4967
		[Token(Token = "0x4001367")]
		[FieldOffset(Offset = "0x18")]
		public Loader Loader;
	}
}
