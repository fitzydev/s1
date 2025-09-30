using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.VoiceOver
{
	// Token: 0x02000295 RID: 661
	[Token(Token = "0x2000295")]
	[CreateAssetMenu(fileName = "VODatabase", menuName = "ScriptableObjects/VODatabase")]
	[Serializable]
	public class VODatabase : ScriptableObject
	{
		// Token: 0x06000DD4 RID: 3540 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DD4")]
		[Address(RVA = "0xAB7830", Offset = "0xAB6230", VA = "0x180AB7830")]
		public VODatabaseEntry GetEntry(EVOLineType lineType)
		{
			return null;
		}

		// Token: 0x06000DD5 RID: 3541 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DD5")]
		[Address(RVA = "0xAB7970", Offset = "0xAB6370", VA = "0x180AB7970")]
		public AudioClip GetRandomClip(EVOLineType lineType)
		{
			return null;
		}

		// Token: 0x06000DD6 RID: 3542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DD6")]
		[Address(RVA = "0xAB7A90", Offset = "0xAB6490", VA = "0x180AB7A90")]
		public VODatabase()
		{
		}

		// Token: 0x04000E0C RID: 3596
		[Token(Token = "0x4000E0C")]
		[FieldOffset(Offset = "0x18")]
		[Range(0f, 2f)]
		public float VolumeMultiplier;

		// Token: 0x04000E0D RID: 3597
		[Token(Token = "0x4000E0D")]
		[FieldOffset(Offset = "0x20")]
		public List<VODatabaseEntry> Entries;
	}
}
