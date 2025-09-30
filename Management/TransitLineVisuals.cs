using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Management
{
	// Token: 0x020004FF RID: 1279
	[Token(Token = "0x20004FF")]
	public class TransitLineVisuals : MonoBehaviour
	{
		// Token: 0x06001A0A RID: 6666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A0A")]
		[Address(RVA = "0x64E070", Offset = "0x64CA70", VA = "0x18064E070")]
		public void SetSourcePosition(Vector3 position)
		{
		}

		// Token: 0x06001A0B RID: 6667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A0B")]
		[Address(RVA = "0x64E030", Offset = "0x64CA30", VA = "0x18064E030")]
		public void SetDestinationPosition(Vector3 position)
		{
		}

		// Token: 0x06001A0C RID: 6668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A0C")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public TransitLineVisuals()
		{
		}

		// Token: 0x04001694 RID: 5780
		[Token(Token = "0x4001694")]
		[FieldOffset(Offset = "0x20")]
		public LineRenderer Renderer;
	}
}
