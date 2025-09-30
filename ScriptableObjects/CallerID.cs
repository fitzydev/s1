using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.ScriptableObjects
{
	// Token: 0x02000819 RID: 2073
	[Token(Token = "0x2000819")]
	[CreateAssetMenu(fileName = "CallerID", menuName = "ScriptableObjects/CallerID", order = 1)]
	[Serializable]
	public class CallerID : ScriptableObject
	{
		// Token: 0x06003929 RID: 14633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003929")]
		[Address(RVA = "0x599570", Offset = "0x597F70", VA = "0x180599570")]
		public CallerID()
		{
		}

		// Token: 0x040027A6 RID: 10150
		[Token(Token = "0x40027A6")]
		[FieldOffset(Offset = "0x18")]
		public string Name;

		// Token: 0x040027A7 RID: 10151
		[Token(Token = "0x40027A7")]
		[FieldOffset(Offset = "0x20")]
		public Sprite ProfilePicture;
	}
}
