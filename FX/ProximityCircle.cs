using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering.Universal;

namespace ScheduleOne.FX
{
	// Token: 0x0200059A RID: 1434
	[Token(Token = "0x200059A")]
	public class ProximityCircle : MonoBehaviour
	{
		// Token: 0x06002099 RID: 8345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002099")]
		[Address(RVA = "0x67AC70", Offset = "0x679670", VA = "0x18067AC70")]
		private void LateUpdate()
		{
		}

		// Token: 0x0600209A RID: 8346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600209A")]
		[Address(RVA = "0x67AD50", Offset = "0x679750", VA = "0x18067AD50")]
		public void SetRadius(float rad)
		{
		}

		// Token: 0x0600209B RID: 8347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600209B")]
		[Address(RVA = "0x67ACC0", Offset = "0x6796C0", VA = "0x18067ACC0")]
		public void SetAlpha(float alpha)
		{
		}

		// Token: 0x0600209C RID: 8348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600209C")]
		[Address(RVA = "0x67AD10", Offset = "0x679710", VA = "0x18067AD10")]
		public void SetColor(Color col)
		{
		}

		// Token: 0x0600209D RID: 8349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600209D")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public ProximityCircle()
		{
		}

		// Token: 0x04001AB5 RID: 6837
		[Token(Token = "0x4001AB5")]
		[FieldOffset(Offset = "0x20")]
		[Header("References")]
		public DecalProjector Circle;

		// Token: 0x04001AB6 RID: 6838
		[Token(Token = "0x4001AB6")]
		[FieldOffset(Offset = "0x28")]
		private bool enabledThisFrame;
	}
}
