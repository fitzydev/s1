using System;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using UnityEngine;

namespace ScheduleOne.VoiceOver
{
	// Token: 0x02000297 RID: 663
	[Token(Token = "0x2000297")]
	[RequireComponent(typeof(AudioSourceController))]
	public class VOEmitter : MonoBehaviour
	{
		// Token: 0x06000DD9 RID: 3545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DD9")]
		[Address(RVA = "0xAB7B10", Offset = "0xAB6510", VA = "0x180AB7B10", Slot = "4")]
		protected virtual void Awake()
		{
		}

		// Token: 0x06000DDA RID: 3546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DDA")]
		[Address(RVA = "0xAB7B60", Offset = "0xAB6560", VA = "0x180AB7B60", Slot = "5")]
		public virtual void Play(EVOLineType lineType)
		{
		}

		// Token: 0x06000DDB RID: 3547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DDB")]
		[Address(RVA = "0x5CDA10", Offset = "0x5CC410", VA = "0x1805CDA10")]
		public void SetRuntimePitchMultiplier(float pitchMultiplier)
		{
		}

		// Token: 0x06000DDC RID: 3548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DDC")]
		[Address(RVA = "0xAB7F30", Offset = "0xAB6930", VA = "0x180AB7F30")]
		public void SetDatabase(VODatabase database, bool writeDefault = true)
		{
		}

		// Token: 0x06000DDD RID: 3549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DDD")]
		[Address(RVA = "0xAB7F10", Offset = "0xAB6910", VA = "0x180AB7F10")]
		public void ResetDatabase()
		{
		}

		// Token: 0x06000DDE RID: 3550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DDE")]
		[Address(RVA = "0xAAD340", Offset = "0xAABD40", VA = "0x180AAD340")]
		public VOEmitter()
		{
		}

		// Token: 0x04000E12 RID: 3602
		[Token(Token = "0x4000E12")]
		public const float PitchVariation = 0.05f;

		// Token: 0x04000E13 RID: 3603
		[Token(Token = "0x4000E13")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private VODatabase Database;

		// Token: 0x04000E14 RID: 3604
		[Token(Token = "0x4000E14")]
		[FieldOffset(Offset = "0x28")]
		[Range(0.5f, 2f)]
		public float PitchMultiplier;

		// Token: 0x04000E15 RID: 3605
		[Token(Token = "0x4000E15")]
		[FieldOffset(Offset = "0x2C")]
		private float runtimePitchMultiplier;

		// Token: 0x04000E16 RID: 3606
		[Token(Token = "0x4000E16")]
		[FieldOffset(Offset = "0x30")]
		protected AudioSourceController audioSourceController;

		// Token: 0x04000E17 RID: 3607
		[Token(Token = "0x4000E17")]
		[FieldOffset(Offset = "0x38")]
		private VODatabase defaultVODatabase;
	}
}
