using System;
using Il2CppDummyDll;

namespace ScheduleOne.DevUtilities
{
	// Token: 0x02000752 RID: 1874
	[Token(Token = "0x2000752")]
	public static class JsonHelper
	{
		// Token: 0x060032D6 RID: 13014 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032D6")]
		public static T[] FromJson<T>(string json)
		{
			return null;
		}

		// Token: 0x060032D7 RID: 13015 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032D7")]
		public static string ToJson<T>(T[] array)
		{
			return null;
		}

		// Token: 0x060032D8 RID: 13016 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032D8")]
		public static string ToJson<T>(T[] array, bool prettyPrint)
		{
			return null;
		}

		// Token: 0x02000753 RID: 1875
		[Token(Token = "0x2000753")]
		[Serializable]
		private class Wrapper<T>
		{
			// Token: 0x060032D9 RID: 13017 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60032D9")]
			public Wrapper()
			{
			}

			// Token: 0x04002345 RID: 9029
			[Token(Token = "0x4002345")]
			[FieldOffset(Offset = "0x0")]
			public T[] Items;
		}
	}
}
