using System;
using Il2CppDummyDll;
using ScheduleOne.ConstructableScripts;
using ScheduleOne.Tiles;
using UnityEngine;

namespace ScheduleOne.DevUtilities
{
	// Token: 0x02000746 RID: 1862
	[Token(Token = "0x2000746")]
	public class Autotest : MonoBehaviour
	{
		// Token: 0x06003287 RID: 12935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003287")]
		[Address(RVA = "0x42DA80", Offset = "0x42C480", VA = "0x18042DA80")]
		protected void Start()
		{
		}

		// Token: 0x06003288 RID: 12936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003288")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public Autotest()
		{
		}

		// Token: 0x040022F1 RID: 8945
		[Token(Token = "0x40022F1")]
		[FieldOffset(Offset = "0x20")]
		public Constructable_GridBased workerAccom;

		// Token: 0x040022F2 RID: 8946
		[Token(Token = "0x40022F2")]
		[FieldOffset(Offset = "0x28")]
		public Grid crescentGrid;
	}
}
