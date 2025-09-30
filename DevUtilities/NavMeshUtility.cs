using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.Management;
using ScheduleOne.NPCs;
using UnityEngine;
using UnityEngine.AI;

namespace ScheduleOne.DevUtilities
{
	// Token: 0x02000759 RID: 1881
	[Token(Token = "0x2000759")]
	public static class NavMeshUtility
	{
		// Token: 0x060032FC RID: 13052 RVA: 0x0000E0A0 File Offset: 0x0000C2A0
		[Token(Token = "0x60032FC")]
		[Address(RVA = "0x7821C0", Offset = "0x780BC0", VA = "0x1807821C0")]
		public static float GetPathLength(NavMeshPath path)
		{
			return 0f;
		}

		// Token: 0x060032FD RID: 13053 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032FD")]
		[Address(RVA = "0x781A80", Offset = "0x780480", VA = "0x180781A80")]
		public static Transform GetAccessPoint(ITransitEntity entity, NPC npc)
		{
			return null;
		}

		// Token: 0x060032FE RID: 13054 RVA: 0x0000E0B8 File Offset: 0x0000C2B8
		[Token(Token = "0x60032FE")]
		[Address(RVA = "0x782390", Offset = "0x780D90", VA = "0x180782390")]
		public static bool IsAtTransitEntity(ITransitEntity entity, NPC npc, float distanceThreshold = 0.4f)
		{
			return default(bool);
		}

		// Token: 0x060032FF RID: 13055 RVA: 0x0000E0D0 File Offset: 0x0000C2D0
		[Token(Token = "0x60032FF")]
		[Address(RVA = "0x7820E0", Offset = "0x780AE0", VA = "0x1807820E0")]
		public static int GetNavMeshAgentID(string name)
		{
			return 0;
		}

		// Token: 0x06003300 RID: 13056 RVA: 0x0000E0E8 File Offset: 0x0000C2E8
		[Token(Token = "0x6003300")]
		[Address(RVA = "0x782730", Offset = "0x781130", VA = "0x180782730")]
		public static bool SamplePosition(Vector3 sourcePosition, out NavMeshHit hit, float maxDistance, int areaMask, bool useCache = true)
		{
			return default(bool);
		}

		// Token: 0x06003301 RID: 13057 RVA: 0x0000E100 File Offset: 0x0000C300
		[Token(Token = "0x6003301")]
		[Address(RVA = "0x782690", Offset = "0x781090", VA = "0x180782690")]
		private static Vector3 Quantize(Vector3 position, float precision = 0.1f)
		{
			return default(Vector3);
		}

		// Token: 0x06003302 RID: 13058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003302")]
		[Address(RVA = "0x7819E0", Offset = "0x7803E0", VA = "0x1807819E0")]
		public static void ClearCache()
		{
		}

		// Token: 0x04002356 RID: 9046
		[Token(Token = "0x4002356")]
		public const float SAMPLE_MAX_DISTANCE = 2f;

		// Token: 0x04002357 RID: 9047
		[Token(Token = "0x4002357")]
		[FieldOffset(Offset = "0x0")]
		public static Dictionary<Vector3, Vector3> SampleCache;

		// Token: 0x04002358 RID: 9048
		[Token(Token = "0x4002358")]
		[FieldOffset(Offset = "0x8")]
		public static List<Vector3> sampleCacheKeys;

		// Token: 0x04002359 RID: 9049
		[Token(Token = "0x4002359")]
		public const float SAMPLE_CACHE_MAX_SQR_DIST = 1f;

		// Token: 0x0400235A RID: 9050
		[Token(Token = "0x400235A")]
		public const float MAX_CACHE_SIZE = 10000f;
	}
}
