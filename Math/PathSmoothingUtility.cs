using System;
using System.Collections.Generic;
using FluffyUnderware.Curvy;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Math
{
	// Token: 0x020004BF RID: 1215
	[Token(Token = "0x20004BF")]
	public class PathSmoothingUtility : MonoBehaviour
	{
		// Token: 0x0600180E RID: 6158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600180E")]
		[Address(RVA = "0x60EFB0", Offset = "0x60D9B0", VA = "0x18060EFB0")]
		private void Awake()
		{
		}

		// Token: 0x0600180F RID: 6159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600180F")]
		[Address(RVA = "0x60F0F0", Offset = "0x60DAF0", VA = "0x18060F0F0")]
		public static PathSmoothingUtility.SmoothedPath CalculateSmoothedPath(List<Vector3> controlPoints, float maxCPDistance = 5f)
		{
			return null;
		}

		// Token: 0x06001810 RID: 6160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001810")]
		[Address(RVA = "0x60F470", Offset = "0x60DE70", VA = "0x18060F470")]
		public static void DrawPath(PathSmoothingUtility.SmoothedPath path, Color col, float duration)
		{
		}

		// Token: 0x06001811 RID: 6161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001811")]
		[Address(RVA = "0x60F5D0", Offset = "0x60DFD0", VA = "0x18060F5D0")]
		private static List<Vector3> InsertIntermediatePoints(List<Vector3> points, float maxDistance)
		{
			return null;
		}

		// Token: 0x06001812 RID: 6162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001812")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public PathSmoothingUtility()
		{
		}

		// Token: 0x040015A9 RID: 5545
		[Token(Token = "0x40015A9")]
		public const float MinControlPointDistance = 0.5f;

		// Token: 0x040015AA RID: 5546
		[Token(Token = "0x40015AA")]
		[FieldOffset(Offset = "0x0")]
		private static CurvySpline spline;

		// Token: 0x020004C0 RID: 1216
		[Token(Token = "0x20004C0")]
		public class SmoothedPath
		{
			// Token: 0x06001813 RID: 6163 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001813")]
			[Address(RVA = "0x610B40", Offset = "0x60F540", VA = "0x180610B40")]
			public void InitializePath()
			{
			}

			// Token: 0x06001814 RID: 6164 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001814")]
			[Address(RVA = "0x610F00", Offset = "0x60F900", VA = "0x180610F00")]
			public SmoothedPath()
			{
			}

			// Token: 0x040015AB RID: 5547
			[Token(Token = "0x40015AB")]
			public const float MARGIN = 10f;

			// Token: 0x040015AC RID: 5548
			[Token(Token = "0x40015AC")]
			[FieldOffset(Offset = "0x10")]
			public List<Vector3> vectorPath;

			// Token: 0x040015AD RID: 5549
			[Token(Token = "0x40015AD")]
			[FieldOffset(Offset = "0x18")]
			public List<Bounds> segmentBounds;
		}
	}
}
