using System;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using UnityEngine;

namespace ScheduleOne.Skating
{
	// Token: 0x020002DC RID: 732
	[Token(Token = "0x20002DC")]
	public class SkateboardAudio : MonoBehaviour
	{
		// Token: 0x06000FD9 RID: 4057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FD9")]
		[Address(RVA = "0xAE42C0", Offset = "0xAE2CC0", VA = "0x180AE42C0")]
		private void Awake()
		{
		}

		// Token: 0x06000FDA RID: 4058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FDA")]
		[Address(RVA = "0xAE44A0", Offset = "0xAE2EA0", VA = "0x180AE44A0")]
		private void Start()
		{
		}

		// Token: 0x06000FDB RID: 4059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FDB")]
		[Address(RVA = "0xAE4590", Offset = "0xAE2F90", VA = "0x180AE4590")]
		private void Update()
		{
		}

		// Token: 0x06000FDC RID: 4060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FDC")]
		[Address(RVA = "0xAE4430", Offset = "0xAE2E30", VA = "0x180AE4430")]
		public void PlayJump(float force)
		{
		}

		// Token: 0x06000FDD RID: 4061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FDD")]
		[Address(RVA = "0x5A3420", Offset = "0x5A1E20", VA = "0x1805A3420")]
		public void PlayLand()
		{
		}

		// Token: 0x06000FDE RID: 4062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FDE")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public SkateboardAudio()
		{
		}

		// Token: 0x04001017 RID: 4119
		[Token(Token = "0x4001017")]
		[FieldOffset(Offset = "0x20")]
		public Skateboard Board;

		// Token: 0x04001018 RID: 4120
		[Token(Token = "0x4001018")]
		[FieldOffset(Offset = "0x28")]
		[Header("References")]
		public AudioSourceController JumpAudio;

		// Token: 0x04001019 RID: 4121
		[Token(Token = "0x4001019")]
		[FieldOffset(Offset = "0x30")]
		public AudioSourceController LandAudio;

		// Token: 0x0400101A RID: 4122
		[Token(Token = "0x400101A")]
		[FieldOffset(Offset = "0x38")]
		public AudioSourceController RollingAudio;

		// Token: 0x0400101B RID: 4123
		[Token(Token = "0x400101B")]
		[FieldOffset(Offset = "0x40")]
		public AudioSourceController DirtRollingAudio;

		// Token: 0x0400101C RID: 4124
		[Token(Token = "0x400101C")]
		[FieldOffset(Offset = "0x48")]
		public AudioSourceController WindAudio;
	}
}
