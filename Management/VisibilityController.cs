using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Management
{
	// Token: 0x020004F8 RID: 1272
	[Token(Token = "0x20004F8")]
	public class VisibilityController : MonoBehaviour
	{
		// Token: 0x060019EB RID: 6635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019EB")]
		[Address(RVA = "0x42DA80", Offset = "0x42C480", VA = "0x18042DA80")]
		private void Start()
		{
		}

		// Token: 0x060019EC RID: 6636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019EC")]
		[Address(RVA = "0x650460", Offset = "0x64EE60", VA = "0x180650460")]
		private void OnEnterFullScreen()
		{
		}

		// Token: 0x060019ED RID: 6637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019ED")]
		[Address(RVA = "0x6504A0", Offset = "0x64EEA0", VA = "0x1806504A0")]
		private void OnExitFullScreen()
		{
		}

		// Token: 0x060019EE RID: 6638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019EE")]
		[Address(RVA = "0x6504E0", Offset = "0x64EEE0", VA = "0x1806504E0")]
		public VisibilityController()
		{
		}

		// Token: 0x0400167A RID: 5754
		[Token(Token = "0x400167A")]
		[FieldOffset(Offset = "0x20")]
		public bool visibleOnlyInFullscreen;
	}
}
