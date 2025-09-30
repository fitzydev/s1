using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.DevUtilities
{
	// Token: 0x02000768 RID: 1896
	[Token(Token = "0x2000768")]
	public class PositionHistoryTracker : MonoBehaviour
	{
		// Token: 0x17000775 RID: 1909
		// (get) Token: 0x06003352 RID: 13138 RVA: 0x0000E250 File Offset: 0x0000C450
		[Token(Token = "0x17000775")]
		public float RecordedTime
		{
			[Token(Token = "0x6003352")]
			[Address(RVA = "0x788240", Offset = "0x786C40", VA = "0x180788240")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06003353 RID: 13139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003353")]
		[Address(RVA = "0x788040", Offset = "0x786A40", VA = "0x180788040")]
		private void Start()
		{
		}

		// Token: 0x06003354 RID: 13140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003354")]
		[Address(RVA = "0x788060", Offset = "0x786A60", VA = "0x180788060")]
		private void Update()
		{
		}

		// Token: 0x06003355 RID: 13141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003355")]
		[Address(RVA = "0x787F20", Offset = "0x786920", VA = "0x180787F20")]
		private void RecordPosition()
		{
		}

		// Token: 0x06003356 RID: 13142 RVA: 0x0000E268 File Offset: 0x0000C468
		[Token(Token = "0x6003356")]
		[Address(RVA = "0x787E70", Offset = "0x786870", VA = "0x180787E70")]
		public Vector3 GetPositionXSecondsAgo(float secondsAgo)
		{
			return default(Vector3);
		}

		// Token: 0x06003357 RID: 13143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003357")]
		[Address(RVA = "0x787E20", Offset = "0x786820", VA = "0x180787E20")]
		public void ClearHistory()
		{
		}

		// Token: 0x06003358 RID: 13144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003358")]
		[Address(RVA = "0x7881B0", Offset = "0x786BB0", VA = "0x1807881B0")]
		public PositionHistoryTracker()
		{
		}

		// Token: 0x0400239A RID: 9114
		[Token(Token = "0x400239A")]
		[FieldOffset(Offset = "0x20")]
		[Tooltip("Frequency (in seconds) to record the position.")]
		public float recordingFrequency;

		// Token: 0x0400239B RID: 9115
		[Token(Token = "0x400239B")]
		[FieldOffset(Offset = "0x24")]
		[Tooltip("Duration (in seconds) to store the position history.")]
		public float historyDuration;

		// Token: 0x0400239C RID: 9116
		[Token(Token = "0x400239C")]
		[FieldOffset(Offset = "0x28")]
		public List<Vector3> positionHistory;

		// Token: 0x0400239D RID: 9117
		[Token(Token = "0x400239D")]
		[FieldOffset(Offset = "0x30")]
		private float lastRecordTime;
	}
}
