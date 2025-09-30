using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.ItemFramework;

namespace ScheduleOne.Management
{
	// Token: 0x020004F3 RID: 1267
	[Token(Token = "0x20004F3")]
	public class ManagementUtilities : Singleton<ManagementUtilities>
	{
		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x060019CC RID: 6604 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000490")]
		public static List<string> WeedSeedAssetPaths
		{
			[Token(Token = "0x60019CC")]
			[Address(RVA = "0x6408A0", Offset = "0x63F2A0", VA = "0x1806408A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x060019CD RID: 6605 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000491")]
		public static List<string> AdditiveAssetPaths
		{
			[Token(Token = "0x60019CD")]
			[Address(RVA = "0x640820", Offset = "0x63F220", VA = "0x180640820")]
			get
			{
				return null;
			}
		}

		// Token: 0x060019CE RID: 6606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019CE")]
		[Address(RVA = "0x640720", Offset = "0x63F120", VA = "0x180640720")]
		public ManagementUtilities()
		{
		}

		// Token: 0x04001667 RID: 5735
		[Token(Token = "0x4001667")]
		[FieldOffset(Offset = "0x28")]
		public List<string> weedSeedAssetPaths;

		// Token: 0x04001668 RID: 5736
		[Token(Token = "0x4001668")]
		[FieldOffset(Offset = "0x30")]
		public List<string> additiveAssetPaths;

		// Token: 0x04001669 RID: 5737
		[Token(Token = "0x4001669")]
		[FieldOffset(Offset = "0x38")]
		public List<AdditiveDefinition> AdditiveDefinitions;
	}
}
