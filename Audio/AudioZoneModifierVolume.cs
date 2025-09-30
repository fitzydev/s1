using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Audio
{
	// Token: 0x02000843 RID: 2115
	[Token(Token = "0x2000843")]
	public class AudioZoneModifierVolume : MonoBehaviour
	{
		// Token: 0x06003A10 RID: 14864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A10")]
		[Address(RVA = "0x80CBC0", Offset = "0x80B5C0", VA = "0x18080CBC0")]
		private void Start()
		{
		}

		// Token: 0x06003A11 RID: 14865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A11")]
		[Address(RVA = "0x80C880", Offset = "0x80B280", VA = "0x18080C880")]
		private void Refresh()
		{
		}

		// Token: 0x06003A12 RID: 14866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A12")]
		[Address(RVA = "0x80CC70", Offset = "0x80B670", VA = "0x18080CC70")]
		public AudioZoneModifierVolume()
		{
		}

		// Token: 0x0400286A RID: 10346
		[Token(Token = "0x400286A")]
		[FieldOffset(Offset = "0x20")]
		public List<AudioZone> Zones;

		// Token: 0x0400286B RID: 10347
		[Token(Token = "0x400286B")]
		[FieldOffset(Offset = "0x28")]
		public float VolumeMultiplier;

		// Token: 0x0400286C RID: 10348
		[Token(Token = "0x400286C")]
		[FieldOffset(Offset = "0x30")]
		private BoxCollider[] colliders;
	}
}
