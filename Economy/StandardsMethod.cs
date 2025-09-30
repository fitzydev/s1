using System;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;

namespace ScheduleOne.Economy
{
	// Token: 0x020005F1 RID: 1521
	[Token(Token = "0x20005F1")]
	public static class StandardsMethod
	{
		// Token: 0x06002546 RID: 9542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002546")]
		[Address(RVA = "0x6E0450", Offset = "0x6DEE50", VA = "0x1806E0450")]
		public static string GetName(this ECustomerStandard property)
		{
			return null;
		}

		// Token: 0x06002547 RID: 9543 RVA: 0x0000B940 File Offset: 0x00009B40
		[Token(Token = "0x6002547")]
		[Address(RVA = "0x6E0410", Offset = "0x6DEE10", VA = "0x1806E0410")]
		public static EQuality GetCorrespondingQuality(this ECustomerStandard property)
		{
			return EQuality.Trash;
		}
	}
}
