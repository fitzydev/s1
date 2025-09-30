using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Lighting
{
	// Token: 0x02000515 RID: 1301
	[Token(Token = "0x2000515")]
	public class LightExposureNode : MonoBehaviour
	{
		// Token: 0x06001A75 RID: 6773 RVA: 0x000093C0 File Offset: 0x000075C0
		[Token(Token = "0x6001A75")]
		[Address(RVA = "0x63DB90", Offset = "0x63C590", VA = "0x18063DB90")]
		public float GetTotalExposure(out float growSpeedMultiplier)
		{
			return 0f;
		}

		// Token: 0x06001A76 RID: 6774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A76")]
		[Address(RVA = "0x63DAD0", Offset = "0x63C4D0", VA = "0x18063DAD0")]
		public void AddSource(UsableLightSource source, float lightAmount)
		{
		}

		// Token: 0x06001A77 RID: 6775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A77")]
		[Address(RVA = "0x63DE60", Offset = "0x63C860", VA = "0x18063DE60")]
		public void RemoveSource(UsableLightSource source)
		{
		}

		// Token: 0x06001A78 RID: 6776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A78")]
		[Address(RVA = "0x63DDC0", Offset = "0x63C7C0", VA = "0x18063DDC0")]
		private void OnDrawGizmos()
		{
		}

		// Token: 0x06001A79 RID: 6777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A79")]
		[Address(RVA = "0x63DEC0", Offset = "0x63C8C0", VA = "0x18063DEC0")]
		public LightExposureNode()
		{
		}

		// Token: 0x040016CC RID: 5836
		[Token(Token = "0x40016CC")]
		[FieldOffset(Offset = "0x20")]
		public float ambientExposure;

		// Token: 0x040016CD RID: 5837
		[Token(Token = "0x40016CD")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<UsableLightSource, float> sources;
	}
}
