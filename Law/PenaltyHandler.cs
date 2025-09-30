using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace ScheduleOne.Law
{
	// Token: 0x0200053F RID: 1343
	[Token(Token = "0x200053F")]
	public static class PenaltyHandler
	{
		// Token: 0x06001B85 RID: 7045 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B85")]
		[Address(RVA = "0x642B70", Offset = "0x641570", VA = "0x180642B70")]
		public static List<string> ProcessCrimeList(Dictionary<Crime, int> crimes)
		{
			return null;
		}

		// Token: 0x0400177A RID: 6010
		[Token(Token = "0x400177A")]
		public const float CONTROLLED_SUBSTANCE_FINE = 5f;

		// Token: 0x0400177B RID: 6011
		[Token(Token = "0x400177B")]
		public const float LOW_SEVERITY_DRUG_FINE = 10f;

		// Token: 0x0400177C RID: 6012
		[Token(Token = "0x400177C")]
		public const float MED_SEVERITY_DRUG_FINE = 20f;

		// Token: 0x0400177D RID: 6013
		[Token(Token = "0x400177D")]
		public const float HIGH_SEVERITY_DRUG_FINE = 30f;

		// Token: 0x0400177E RID: 6014
		[Token(Token = "0x400177E")]
		public const float FAILURE_TO_COMPLY_FINE = 50f;

		// Token: 0x0400177F RID: 6015
		[Token(Token = "0x400177F")]
		public const float EVADING_ARREST_FINE = 50f;

		// Token: 0x04001780 RID: 6016
		[Token(Token = "0x4001780")]
		public const float VIOLATING_CURFEW_TIME = 100f;

		// Token: 0x04001781 RID: 6017
		[Token(Token = "0x4001781")]
		public const float ATTEMPT_TO_SELL_FINE = 150f;

		// Token: 0x04001782 RID: 6018
		[Token(Token = "0x4001782")]
		public const float ASSAULT_FINE = 75f;

		// Token: 0x04001783 RID: 6019
		[Token(Token = "0x4001783")]
		public const float DEADLY_ASSAULT_FINE = 150f;

		// Token: 0x04001784 RID: 6020
		[Token(Token = "0x4001784")]
		public const float VANDALISM_FINE = 50f;

		// Token: 0x04001785 RID: 6021
		[Token(Token = "0x4001785")]
		public const float THEFT_FINE = 50f;

		// Token: 0x04001786 RID: 6022
		[Token(Token = "0x4001786")]
		public const float BRANDISHING_FINE = 50f;

		// Token: 0x04001787 RID: 6023
		[Token(Token = "0x4001787")]
		public const float DISCHARGE_FIREARM_FINE = 50f;
	}
}
