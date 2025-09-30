using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering.Universal;

namespace ScheduleOne.Graffiti
{
	// Token: 0x0200058B RID: 1419
	[Token(Token = "0x200058B")]
	[RequireComponent(typeof(SpraySurface))]
	public class SprayDisplay : MonoBehaviour
	{
		// Token: 0x06001FF3 RID: 8179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FF3")]
		[Address(RVA = "0x67ADA0", Offset = "0x6797A0", VA = "0x18067ADA0")]
		private void Awake()
		{
		}

		// Token: 0x06001FF4 RID: 8180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FF4")]
		[Address(RVA = "0x67AEC0", Offset = "0x6798C0", VA = "0x18067AEC0")]
		private void Redraw()
		{
		}

		// Token: 0x06001FF5 RID: 8181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FF5")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public SprayDisplay()
		{
		}

		// Token: 0x04001A31 RID: 6705
		[Token(Token = "0x4001A31")]
		[FieldOffset(Offset = "0x20")]
		public SpraySurface SpraySurface;

		// Token: 0x04001A32 RID: 6706
		[Token(Token = "0x4001A32")]
		[FieldOffset(Offset = "0x28")]
		public DecalProjector Projector;

		// Token: 0x04001A33 RID: 6707
		[Token(Token = "0x4001A33")]
		[FieldOffset(Offset = "0x30")]
		private Material cachedMaterial;
	}
}
