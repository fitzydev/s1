using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Tools
{
	// Token: 0x02000924 RID: 2340
	[Token(Token = "0x2000924")]
	[ExecuteInEditMode]
	public class ViewmodelEquippableTransformSetter : MonoBehaviour
	{
		// Token: 0x06004023 RID: 16419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004023")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public ViewmodelEquippableTransformSetter()
		{
		}

		// Token: 0x04002CFB RID: 11515
		[Token(Token = "0x4002CFB")]
		[FieldOffset(Offset = "0x0")]
		private static Vector3 lastRecordedLocalPosition;

		// Token: 0x04002CFC RID: 11516
		[Token(Token = "0x4002CFC")]
		[FieldOffset(Offset = "0xC")]
		private static Vector3 lastRecordedLocalEulerAngles;

		// Token: 0x04002CFD RID: 11517
		[Token(Token = "0x4002CFD")]
		[FieldOffset(Offset = "0x18")]
		private static Vector3 lastRecordedLocalScale;

		// Token: 0x04002CFE RID: 11518
		[Token(Token = "0x4002CFE")]
		[FieldOffset(Offset = "0x24")]
		private static bool transformChangedApplied;
	}
}
