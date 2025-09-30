using System;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using UnityEngine;
using VLB;

namespace ScheduleOne.Lighting
{
	// Token: 0x0200051C RID: 1308
	[Token(Token = "0x200051C")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Light))]
	[RequireComponent(typeof(VolumetricLightBeamSD))]
	public class VolumetricLightTracker : MonoBehaviour
	{
		// Token: 0x06001A97 RID: 6807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A97")]
		[Address(RVA = "0x650640", Offset = "0x64F040", VA = "0x180650640")]
		private void OnValidate()
		{
		}

		// Token: 0x06001A98 RID: 6808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A98")]
		[Address(RVA = "0x6504F0", Offset = "0x64EEF0", VA = "0x1806504F0")]
		private void LateUpdate()
		{
		}

		// Token: 0x06001A99 RID: 6809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A99")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public VolumetricLightTracker()
		{
		}

		// Token: 0x040016EE RID: 5870
		[Token(Token = "0x40016EE")]
		[FieldOffset(Offset = "0x20")]
		public bool Override;

		// Token: 0x040016EF RID: 5871
		[Token(Token = "0x40016EF")]
		[FieldOffset(Offset = "0x21")]
		public bool Enabled;

		// Token: 0x040016F0 RID: 5872
		[Token(Token = "0x40016F0")]
		[FieldOffset(Offset = "0x28")]
		public Light light;

		// Token: 0x040016F1 RID: 5873
		[Token(Token = "0x40016F1")]
		[FieldOffset(Offset = "0x30")]
		public OptimizedLight optimizedLight;

		// Token: 0x040016F2 RID: 5874
		[Token(Token = "0x40016F2")]
		[FieldOffset(Offset = "0x38")]
		public VolumetricLightBeamSD beam;

		// Token: 0x040016F3 RID: 5875
		[Token(Token = "0x40016F3")]
		[FieldOffset(Offset = "0x40")]
		public VolumetricDustParticles dust;
	}
}
