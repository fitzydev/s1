using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.ScriptableObjects
{
	// Token: 0x0200081C RID: 2076
	[Token(Token = "0x200081C")]
	[CreateAssetMenu(fileName = "StringDatabase", menuName = "ScriptableObjects/StringDatabase", order = 1)]
	[Serializable]
	public class StringDatabase : ScriptableObject
	{
		// Token: 0x0600392F RID: 14639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600392F")]
		[Address(RVA = "0x599570", Offset = "0x597F70", VA = "0x180599570")]
		public StringDatabase()
		{
		}

		// Token: 0x040027AE RID: 10158
		[Token(Token = "0x40027AE")]
		[FieldOffset(Offset = "0x18")]
		[TextArea(2, 10)]
		public string[] Strings;
	}
}
