using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Audio
{
	// Token: 0x0200085C RID: 2140
	[Token(Token = "0x200085C")]
	public class Zone : MonoBehaviour
	{
		// Token: 0x06003A70 RID: 14960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A70")]
		[Address(RVA = "0x824330", Offset = "0x822D30", VA = "0x180824330", Slot = "4")]
		protected virtual void Awake()
		{
		}

		// Token: 0x06003A71 RID: 14961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A71")]
		[Address(RVA = "0x825190", Offset = "0x823B90", VA = "0x180825190")]
		private void OnDrawGizmos()
		{
		}

		// Token: 0x06003A72 RID: 14962 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A72")]
		[Address(RVA = "0x824F40", Offset = "0x823940", VA = "0x180824F40")]
		protected Vector3[] GetPoints()
		{
			return null;
		}

		// Token: 0x06003A73 RID: 14963 RVA: 0x0000FA38 File Offset: 0x0000DC38
		[Token(Token = "0x6003A73")]
		[Address(RVA = "0x824580", Offset = "0x822F80", VA = "0x180824580")]
		protected bool DoBoundsContainPoint(Vector3 point)
		{
			return default(bool);
		}

		// Token: 0x06003A74 RID: 14964 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A74")]
		[Address(RVA = "0x824620", Offset = "0x823020", VA = "0x180824620")]
		protected Tuple<Vector3, Vector3> GetBoundingPoints()
		{
			return null;
		}

		// Token: 0x06003A75 RID: 14965 RVA: 0x0000FA50 File Offset: 0x0000DC50
		[Token(Token = "0x6003A75")]
		[Address(RVA = "0x8250A0", Offset = "0x823AA0", VA = "0x1808250A0")]
		public bool IsPointInsidePolygon(Vector3 point)
		{
			return default(bool);
		}

		// Token: 0x06003A76 RID: 14966 RVA: 0x0000FA68 File Offset: 0x0000DC68
		[Token(Token = "0x6003A76")]
		[Address(RVA = "0x824360", Offset = "0x822D60", VA = "0x180824360")]
		protected int CalculateWindingNumber(Vector2[] polygon, Vector2 point)
		{
			return 0;
		}

		// Token: 0x06003A77 RID: 14967 RVA: 0x0000FA80 File Offset: 0x0000DC80
		[Token(Token = "0x6003A77")]
		[Address(RVA = "0x824A60", Offset = "0x823460", VA = "0x180824A60")]
		protected Vector3 GetClosestPointOnPolygon(Vector3[] polyPoints, Vector3 point)
		{
			return default(Vector3);
		}

		// Token: 0x06003A78 RID: 14968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A78")]
		[Address(RVA = "0x825A10", Offset = "0x824410", VA = "0x180825A10")]
		public Zone()
		{
		}

		// Token: 0x06003A79 RID: 14969 RVA: 0x0000FA98 File Offset: 0x0000DC98
		[Token(Token = "0x6003A79")]
		[Address(RVA = "0x8257F0", Offset = "0x8241F0", VA = "0x1808257F0")]
		[CompilerGenerated]
		internal static bool <CalculateWindingNumber>g__IsPointOnSegment|12_0(Vector2 start, Vector2 end, Vector2 point)
		{
			return default(bool);
		}

		// Token: 0x06003A7A RID: 14970 RVA: 0x0000FAB0 File Offset: 0x0000DCB0
		[Token(Token = "0x6003A7A")]
		[Address(RVA = "0x8256A0", Offset = "0x8240A0", VA = "0x1808256A0")]
		[CompilerGenerated]
		internal static float <CalculateWindingNumber>g__CrossProduct|12_1(Vector2 start, Vector2 end, Vector2 point)
		{
			return 0f;
		}

		// Token: 0x06003A7B RID: 14971 RVA: 0x0000FAC8 File Offset: 0x0000DCC8
		[Token(Token = "0x6003A7B")]
		[Address(RVA = "0x825700", Offset = "0x824100", VA = "0x180825700")]
		[CompilerGenerated]
		internal static float <CalculateWindingNumber>g__DotProduct|12_2(Vector2 start, Vector2 end, Vector2 point)
		{
			return 0f;
		}

		// Token: 0x06003A7C RID: 14972 RVA: 0x0000FAE0 File Offset: 0x0000DCE0
		[Token(Token = "0x6003A7C")]
		[Address(RVA = "0x825760", Offset = "0x824160", VA = "0x180825760")]
		[CompilerGenerated]
		internal static int <CalculateWindingNumber>g__IsLeft|12_3(Vector2 start, Vector2 end, Vector2 point)
		{
			return 0;
		}

		// Token: 0x06003A7D RID: 14973 RVA: 0x0000FAF8 File Offset: 0x0000DCF8
		[Token(Token = "0x6003A7D")]
		[Address(RVA = "0x8258E0", Offset = "0x8242E0", VA = "0x1808258E0")]
		[CompilerGenerated]
		internal static Vector3 <GetClosestPointOnPolygon>g__ProjectPointOnLineSegment|13_0(Vector3 lineStart, Vector3 lineEnd, Vector3 point)
		{
			return default(Vector3);
		}

		// Token: 0x040028C8 RID: 10440
		[Token(Token = "0x40028C8")]
		public const float UPDATE_INTERVAL = 0.25f;

		// Token: 0x040028C9 RID: 10441
		[Token(Token = "0x40028C9")]
		[FieldOffset(Offset = "0x20")]
		public Transform PointContainer;

		// Token: 0x040028CA RID: 10442
		[Token(Token = "0x40028CA")]
		[FieldOffset(Offset = "0x28")]
		public bool IsClosed;

		// Token: 0x040028CB RID: 10443
		[Token(Token = "0x40028CB")]
		[FieldOffset(Offset = "0x2C")]
		public float VerticalSize;

		// Token: 0x040028CC RID: 10444
		[Token(Token = "0x40028CC")]
		[FieldOffset(Offset = "0x30")]
		[Header("Debug")]
		public Color ZoneColor;

		// Token: 0x040028CD RID: 10445
		[Token(Token = "0x40028CD")]
		[FieldOffset(Offset = "0x40")]
		protected Vector3[] points;
	}
}
