using System;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using UnityEngine;

namespace ScheduleOne.Tools
{
	// Token: 0x02000925 RID: 2341
	[Token(Token = "0x2000925")]
	[ExecuteInEditMode]
	public class WheelRotator : MonoBehaviour
	{
		// Token: 0x06004025 RID: 16421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004025")]
		[Address(RVA = "0x878C70", Offset = "0x877670", VA = "0x180878C70")]
		private void Start()
		{
		}

		// Token: 0x06004026 RID: 16422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004026")]
		[Address(RVA = "0x878A30", Offset = "0x877430", VA = "0x180878A30")]
		private void LateUpdate()
		{
		}

		// Token: 0x06004027 RID: 16423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004027")]
		[Address(RVA = "0x878D20", Offset = "0x877720", VA = "0x180878D20")]
		public WheelRotator()
		{
		}

		// Token: 0x04002CFF RID: 11519
		[Token(Token = "0x4002CFF")]
		[FieldOffset(Offset = "0x20")]
		public float Radius;

		// Token: 0x04002D00 RID: 11520
		[Token(Token = "0x4002D00")]
		[FieldOffset(Offset = "0x28")]
		public Transform Wheel;

		// Token: 0x04002D01 RID: 11521
		[Token(Token = "0x4002D01")]
		[FieldOffset(Offset = "0x30")]
		public bool Flip;

		// Token: 0x04002D02 RID: 11522
		[Token(Token = "0x4002D02")]
		[FieldOffset(Offset = "0x38")]
		public AudioSourceController Controller;

		// Token: 0x04002D03 RID: 11523
		[Token(Token = "0x4002D03")]
		[FieldOffset(Offset = "0x40")]
		public float AudioVolumeDivisor;

		// Token: 0x04002D04 RID: 11524
		[Token(Token = "0x4002D04")]
		[FieldOffset(Offset = "0x44")]
		public Vector3 RotationAxis;

		// Token: 0x04002D05 RID: 11525
		[Token(Token = "0x4002D05")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Vector3 lastFramePosition;
	}
}
