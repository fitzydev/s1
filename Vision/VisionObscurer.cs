using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Vision
{
	// Token: 0x02000385 RID: 901
	[Token(Token = "0x2000385")]
	public class VisionObscurer : MonoBehaviour
	{
		// Token: 0x06001423 RID: 5155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001423")]
		[Address(RVA = "0x58A700", Offset = "0x589100", VA = "0x18058A700")]
		public VisionObscurer()
		{
		}

		// Token: 0x04001301 RID: 4865
		[Token(Token = "0x4001301")]
		[FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		public float ObscuranceAmount;
	}
}
