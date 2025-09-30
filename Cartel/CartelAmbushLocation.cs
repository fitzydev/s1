using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Cartel
{
	// Token: 0x02000807 RID: 2055
	[Token(Token = "0x2000807")]
	public class CartelAmbushLocation : MonoBehaviour
	{
		// Token: 0x0600386F RID: 14447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600386F")]
		[Address(RVA = "0x7DE5D0", Offset = "0x7DCFD0", VA = "0x1807DE5D0")]
		private void Awake()
		{
		}

		// Token: 0x06003870 RID: 14448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003870")]
		[Address(RVA = "0x7DE8E0", Offset = "0x7DD2E0", VA = "0x1807DE8E0")]
		private void OnDrawGizmos()
		{
		}

		// Token: 0x06003871 RID: 14449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003871")]
		[Address(RVA = "0x7DEA80", Offset = "0x7DD480", VA = "0x1807DEA80")]
		public CartelAmbushLocation()
		{
		}

		// Token: 0x04002739 RID: 10041
		[Token(Token = "0x4002739")]
		public const int REQUIRED_AMBUSH_POINTS = 4;

		// Token: 0x0400273A RID: 10042
		[Token(Token = "0x400273A")]
		[FieldOffset(Offset = "0x20")]
		[Header("Settings")]
		[Range(2f, 20f)]
		public float DetectionRadius;

		// Token: 0x0400273B RID: 10043
		[Token(Token = "0x400273B")]
		[FieldOffset(Offset = "0x28")]
		public Transform[] AmbushPoints;
	}
}
