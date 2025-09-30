using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Tools
{
	// Token: 0x02000916 RID: 2326
	[Token(Token = "0x2000916")]
	public class RandomIntervalEvent : MonoBehaviour
	{
		// Token: 0x06003FF3 RID: 16371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FF3")]
		[Address(RVA = "0x873830", Offset = "0x872230", VA = "0x180873830")]
		private void OnEnable()
		{
		}

		// Token: 0x06003FF4 RID: 16372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FF4")]
		[Address(RVA = "0x8738B0", Offset = "0x8722B0", VA = "0x1808738B0")]
		private void Update()
		{
		}

		// Token: 0x06003FF5 RID: 16373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FF5")]
		[Address(RVA = "0x8737E0", Offset = "0x8721E0", VA = "0x1808737E0")]
		private void Execute()
		{
		}

		// Token: 0x06003FF6 RID: 16374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FF6")]
		[Address(RVA = "0x873910", Offset = "0x872310", VA = "0x180873910")]
		public RandomIntervalEvent()
		{
		}

		// Token: 0x04002CCB RID: 11467
		[Token(Token = "0x4002CCB")]
		[FieldOffset(Offset = "0x20")]
		public float MinInterval;

		// Token: 0x04002CCC RID: 11468
		[Token(Token = "0x4002CCC")]
		[FieldOffset(Offset = "0x24")]
		public float MaxInterval;

		// Token: 0x04002CCD RID: 11469
		[Token(Token = "0x4002CCD")]
		[FieldOffset(Offset = "0x28")]
		public bool ExecuteOnEnable;

		// Token: 0x04002CCE RID: 11470
		[Token(Token = "0x4002CCE")]
		[FieldOffset(Offset = "0x30")]
		public UnityEvent OnInterval;

		// Token: 0x04002CCF RID: 11471
		[Token(Token = "0x4002CCF")]
		[FieldOffset(Offset = "0x38")]
		private float nextInterval;
	}
}
