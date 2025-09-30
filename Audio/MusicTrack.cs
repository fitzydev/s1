using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Audio
{
	// Token: 0x02000854 RID: 2132
	[Token(Token = "0x2000854")]
	[RequireComponent(typeof(AudioSourceController))]
	public class MusicTrack : MonoBehaviour
	{
		// Token: 0x1700083B RID: 2107
		// (get) Token: 0x06003A4B RID: 14923 RVA: 0x0000F9D8 File Offset: 0x0000DBD8
		// (set) Token: 0x06003A4C RID: 14924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700083B")]
		public bool IsPlaying
		{
			[Token(Token = "0x6003A4B")]
			[Address(RVA = "0x4B9020", Offset = "0x4B7A20", VA = "0x1804B9020")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003A4C")]
			[Address(RVA = "0x4B9030", Offset = "0x4B7A30", VA = "0x1804B9030")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06003A4D RID: 14925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A4D")]
		[Address(RVA = "0x81D8D0", Offset = "0x81C2D0", VA = "0x18081D8D0")]
		private void OnValidate()
		{
		}

		// Token: 0x06003A4E RID: 14926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A4E")]
		[Address(RVA = "0x81D8C0", Offset = "0x81C2C0", VA = "0x18081D8C0")]
		public void Enable()
		{
		}

		// Token: 0x06003A4F RID: 14927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A4F")]
		[Address(RVA = "0x81D8B0", Offset = "0x81C2B0", VA = "0x18081D8B0")]
		public void Disable()
		{
		}

		// Token: 0x06003A50 RID: 14928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A50")]
		[Address(RVA = "0x81D8A0", Offset = "0x81C2A0", VA = "0x18081D8A0", Slot = "4")]
		protected virtual void Awake()
		{
		}

		// Token: 0x06003A51 RID: 14929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A51")]
		[Address(RVA = "0x81D9A0", Offset = "0x81C3A0", VA = "0x18081D9A0", Slot = "5")]
		public virtual void Update()
		{
		}

		// Token: 0x06003A52 RID: 14930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A52")]
		[Address(RVA = "0x81D970", Offset = "0x81C370", VA = "0x18081D970", Slot = "6")]
		public virtual void Play()
		{
		}

		// Token: 0x06003A53 RID: 14931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A53")]
		[Address(RVA = "0x7795B0", Offset = "0x777FB0", VA = "0x1807795B0", Slot = "7")]
		public virtual void Stop()
		{
		}

		// Token: 0x06003A54 RID: 14932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A54")]
		[Address(RVA = "0x81DB00", Offset = "0x81C500", VA = "0x18081DB00")]
		public MusicTrack()
		{
		}

		// Token: 0x040028A6 RID: 10406
		[Token(Token = "0x40028A6")]
		[FieldOffset(Offset = "0x21")]
		public bool Enabled;

		// Token: 0x040028A7 RID: 10407
		[Token(Token = "0x40028A7")]
		[FieldOffset(Offset = "0x28")]
		public string TrackName;

		// Token: 0x040028A8 RID: 10408
		[Token(Token = "0x40028A8")]
		[FieldOffset(Offset = "0x30")]
		public int Priority;

		// Token: 0x040028A9 RID: 10409
		[Token(Token = "0x40028A9")]
		[FieldOffset(Offset = "0x34")]
		public float FadeInTime;

		// Token: 0x040028AA RID: 10410
		[Token(Token = "0x40028AA")]
		[FieldOffset(Offset = "0x38")]
		public float FadeOutTime;

		// Token: 0x040028AB RID: 10411
		[Token(Token = "0x40028AB")]
		[FieldOffset(Offset = "0x40")]
		public AudioSourceController Controller;

		// Token: 0x040028AC RID: 10412
		[Token(Token = "0x40028AC")]
		[FieldOffset(Offset = "0x48")]
		public float VolumeMultiplier;

		// Token: 0x040028AD RID: 10413
		[Token(Token = "0x40028AD")]
		[FieldOffset(Offset = "0x4C")]
		public bool AutoFadeOut;

		// Token: 0x040028AE RID: 10414
		[Token(Token = "0x40028AE")]
		[FieldOffset(Offset = "0x50")]
		protected float volumeMultiplier;
	}
}
