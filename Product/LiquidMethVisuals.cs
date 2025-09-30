using System;
using Il2CppDummyDll;
using ScheduleOne.StationFramework;
using UnityEngine;

namespace ScheduleOne.Product
{
	// Token: 0x02000982 RID: 2434
	[Token(Token = "0x2000982")]
	public class LiquidMethVisuals : MonoBehaviour
	{
		// Token: 0x0600429A RID: 17050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600429A")]
		[Address(RVA = "0x87D5C0", Offset = "0x87BFC0", VA = "0x18087D5C0")]
		public void Setup(LiquidMethDefinition def)
		{
		}

		// Token: 0x0600429B RID: 17051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600429B")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public LiquidMethVisuals()
		{
		}

		// Token: 0x04002EBF RID: 11967
		[Token(Token = "0x4002EBF")]
		[FieldOffset(Offset = "0x20")]
		public MeshRenderer StaticLiquidMesh;

		// Token: 0x04002EC0 RID: 11968
		[Token(Token = "0x4002EC0")]
		[FieldOffset(Offset = "0x28")]
		public LiquidContainer LiquidContainer;

		// Token: 0x04002EC1 RID: 11969
		[Token(Token = "0x4002EC1")]
		[FieldOffset(Offset = "0x30")]
		public ParticleSystem PourParticles;
	}
}
