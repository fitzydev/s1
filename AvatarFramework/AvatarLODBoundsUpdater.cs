using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.AvatarFramework
{
	// Token: 0x02000A0F RID: 2575
	[Token(Token = "0x2000A0F")]
	public class AvatarLODBoundsUpdater : MonoBehaviour
	{
		// Token: 0x0600469E RID: 18078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600469E")]
		[Address(RVA = "0x8EEF50", Offset = "0x8ED950", VA = "0x1808EEF50")]
		private void Awake()
		{
		}

		// Token: 0x0600469F RID: 18079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600469F")]
		[Address(RVA = "0x8EF0F0", Offset = "0x8EDAF0", VA = "0x1808EF0F0")]
		private void InfrequentUpdate()
		{
		}

		// Token: 0x060046A0 RID: 18080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046A0")]
		[Address(RVA = "0x8EF080", Offset = "0x8EDA80", VA = "0x1808EF080")]
		private void GetLODGroups()
		{
		}

		// Token: 0x060046A1 RID: 18081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046A1")]
		[Address(RVA = "0x8EF270", Offset = "0x8EDC70", VA = "0x1808EF270")]
		private void Recalculate()
		{
		}

		// Token: 0x060046A2 RID: 18082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046A2")]
		[Address(RVA = "0x8EF450", Offset = "0x8EDE50", VA = "0x1808EF450")]
		public AvatarLODBoundsUpdater()
		{
		}

		// Token: 0x04003183 RID: 12675
		[Token(Token = "0x4003183")]
		public const float CHECK_RATE_SECONDS = 1f;

		// Token: 0x04003184 RID: 12676
		[Token(Token = "0x4003184")]
		public const float HIP_OFFSET_THRESHOLD = 5f;

		// Token: 0x04003185 RID: 12677
		[Token(Token = "0x4003185")]
		[FieldOffset(Offset = "0x20")]
		public Avatar Avatar;

		// Token: 0x04003186 RID: 12678
		[Token(Token = "0x4003186")]
		[FieldOffset(Offset = "0x28")]
		private List<LODGroup> lodGroups;

		// Token: 0x04003187 RID: 12679
		[Token(Token = "0x4003187")]
		[FieldOffset(Offset = "0x30")]
		private Vector3 hipOffsetOnLastRefresh;
	}
}
