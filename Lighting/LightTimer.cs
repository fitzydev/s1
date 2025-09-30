using System;
using Il2CppDummyDll;
using ScheduleOne.Misc;
using UnityEngine;

namespace ScheduleOne.Lighting
{
	// Token: 0x02000516 RID: 1302
	[Token(Token = "0x2000516")]
	[RequireComponent(typeof(ToggleableLight))]
	public class LightTimer : MonoBehaviour
	{
		// Token: 0x06001A7A RID: 6778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A7A")]
		[Address(RVA = "0x63DF40", Offset = "0x63C940", VA = "0x18063DF40", Slot = "4")]
		protected virtual void Awake()
		{
		}

		// Token: 0x06001A7B RID: 6779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A7B")]
		[Address(RVA = "0x606F60", Offset = "0x605960", VA = "0x180606F60")]
		private void Start()
		{
		}

		// Token: 0x06001A7C RID: 6780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A7C")]
		[Address(RVA = "0x63E090", Offset = "0x63CA90", VA = "0x18063E090", Slot = "5")]
		protected virtual void UpdateState()
		{
		}

		// Token: 0x06001A7D RID: 6781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A7D")]
		[Address(RVA = "0x42DA80", Offset = "0x42C480", VA = "0x18042DA80")]
		private void OnDrawGizmos()
		{
		}

		// Token: 0x06001A7E RID: 6782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A7E")]
		[Address(RVA = "0x63E070", Offset = "0x63CA70", VA = "0x18063E070")]
		private void SetState(bool on)
		{
		}

		// Token: 0x06001A7F RID: 6783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A7F")]
		[Address(RVA = "0x5FDB20", Offset = "0x5FC520", VA = "0x1805FDB20")]
		public LightTimer()
		{
		}

		// Token: 0x040016CE RID: 5838
		[Token(Token = "0x40016CE")]
		[FieldOffset(Offset = "0x20")]
		[Header("Timing")]
		public int StartTime;

		// Token: 0x040016CF RID: 5839
		[Token(Token = "0x40016CF")]
		[FieldOffset(Offset = "0x24")]
		public int EndTime;

		// Token: 0x040016D0 RID: 5840
		[Token(Token = "0x40016D0")]
		[FieldOffset(Offset = "0x28")]
		public int StartTimeOffset;

		// Token: 0x040016D1 RID: 5841
		[Token(Token = "0x40016D1")]
		[FieldOffset(Offset = "0x30")]
		private ToggleableLight toggleableLight;
	}
}
