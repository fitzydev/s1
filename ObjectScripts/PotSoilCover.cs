using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x02000C84 RID: 3204
	[Token(Token = "0x2000C84")]
	public class PotSoilCover : MonoBehaviour
	{
		// Token: 0x06005730 RID: 22320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005730")]
		[Address(RVA = "0x42DA80", Offset = "0x42C480", VA = "0x18042DA80")]
		private void Awake()
		{
		}

		// Token: 0x06005731 RID: 22321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005731")]
		[Address(RVA = "0xA1DC50", Offset = "0xA1C650", VA = "0x180A1DC50")]
		private void OnEnable()
		{
		}

		// Token: 0x06005732 RID: 22322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005732")]
		[Address(RVA = "0xA1D920", Offset = "0xA1C320", VA = "0x180A1D920")]
		public void ConfigureAppearance(Color col, float transparency)
		{
		}

		// Token: 0x06005733 RID: 22323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005733")]
		[Address(RVA = "0xA1DCF0", Offset = "0xA1C6F0", VA = "0x180A1DCF0")]
		public void Reset()
		{
		}

		// Token: 0x06005734 RID: 22324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005734")]
		[Address(RVA = "0xA1DCD0", Offset = "0xA1C6D0", VA = "0x180A1DCD0")]
		public void QueuePour(Vector3 worldSpacePosition)
		{
		}

		// Token: 0x06005735 RID: 22325 RVA: 0x00015918 File Offset: 0x00013B18
		[Token(Token = "0x6005735")]
		[Address(RVA = "0xA1DBC0", Offset = "0xA1C5C0", VA = "0x180A1DBC0")]
		public float GetNormalizedProgress()
		{
			return 0f;
		}

		// Token: 0x06005736 RID: 22326 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005736")]
		[Address(RVA = "0xA1D8B0", Offset = "0xA1C2B0", VA = "0x180A1D8B0")]
		private IEnumerator CheckQueue()
		{
			return null;
		}

		// Token: 0x06005737 RID: 22327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005737")]
		[Address(RVA = "0xA1D7A0", Offset = "0xA1C1A0", VA = "0x180A1D7A0")]
		private void Blank()
		{
		}

		// Token: 0x06005738 RID: 22328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005738")]
		[Address(RVA = "0xA1D9E0", Offset = "0xA1C3E0", VA = "0x180A1D9E0")]
		private void DelayedApplyPour(Vector3 worldSpace)
		{
		}

		// Token: 0x06005739 RID: 22329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005739")]
		[Address(RVA = "0xA1D470", Offset = "0xA1BE70", VA = "0x180A1D470")]
		private void ApplyPour(Vector3 worldSpace)
		{
		}

		// Token: 0x0600573A RID: 22330 RVA: 0x00015930 File Offset: 0x00013B30
		[Token(Token = "0x600573A")]
		[Address(RVA = "0xA1DBE0", Offset = "0xA1C5E0", VA = "0x180A1DBE0")]
		private float GetPourMaskValue(int x, int y)
		{
			return 0f;
		}

		// Token: 0x0600573B RID: 22331 RVA: 0x00015948 File Offset: 0x00013B48
		[Token(Token = "0x600573B")]
		[Address(RVA = "0xA1DAD0", Offset = "0xA1C4D0", VA = "0x180A1DAD0")]
		private float GetCoverage()
		{
			return 0f;
		}

		// Token: 0x0600573C RID: 22332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600573C")]
		[Address(RVA = "0xA1DE00", Offset = "0xA1C800", VA = "0x180A1DE00")]
		public PotSoilCover()
		{
		}

		// Token: 0x0400407A RID: 16506
		[Token(Token = "0x400407A")]
		public const int TEXTURE_SIZE = 128;

		// Token: 0x0400407B RID: 16507
		[Token(Token = "0x400407B")]
		public const int POUR_RADIUS = 32;

		// Token: 0x0400407C RID: 16508
		[Token(Token = "0x400407C")]
		public const int UPDATES_PER_SECOND = 24;

		// Token: 0x0400407D RID: 16509
		[Token(Token = "0x400407D")]
		public const float COVERAGE_THRESHOLD = 0.5f;

		// Token: 0x0400407E RID: 16510
		[Token(Token = "0x400407E")]
		public const float BASE_COVERAGE = 0.215f;

		// Token: 0x0400407F RID: 16511
		[Token(Token = "0x400407F")]
		public const float SUCCESS_COVERAGE_THRESHOLD = 0.95f;

		// Token: 0x04004080 RID: 16512
		[Token(Token = "0x4004080")]
		public const float DELAY = 0.35f;

		// Token: 0x04004081 RID: 16513
		[Token(Token = "0x4004081")]
		[FieldOffset(Offset = "0x20")]
		public float CurrentCoverage;

		// Token: 0x04004082 RID: 16514
		[Token(Token = "0x4004082")]
		[FieldOffset(Offset = "0x24")]
		[Header("Settings")]
		public float Radius;

		// Token: 0x04004083 RID: 16515
		[Token(Token = "0x4004083")]
		[FieldOffset(Offset = "0x28")]
		[Header("References")]
		public MeshRenderer MeshRenderer;

		// Token: 0x04004084 RID: 16516
		[Token(Token = "0x4004084")]
		[FieldOffset(Offset = "0x30")]
		public Texture2D PourMask;

		// Token: 0x04004085 RID: 16517
		[Token(Token = "0x4004085")]
		[FieldOffset(Offset = "0x38")]
		public UnityEvent onSufficientCoverage;

		// Token: 0x04004086 RID: 16518
		[Token(Token = "0x4004086")]
		[FieldOffset(Offset = "0x40")]
		private bool queued;

		// Token: 0x04004087 RID: 16519
		[Token(Token = "0x4004087")]
		[FieldOffset(Offset = "0x44")]
		private Vector3 queuedWorldPos;

		// Token: 0x04004088 RID: 16520
		[Token(Token = "0x4004088")]
		[FieldOffset(Offset = "0x50")]
		private Texture2D mainTex;

		// Token: 0x04004089 RID: 16521
		[Token(Token = "0x4004089")]
		[FieldOffset(Offset = "0x58")]
		private Vector3 relative;

		// Token: 0x0400408A RID: 16522
		[Token(Token = "0x400408A")]
		[FieldOffset(Offset = "0x64")]
		private Vector2 vector2;

		// Token: 0x0400408B RID: 16523
		[Token(Token = "0x400408B")]
		[FieldOffset(Offset = "0x6C")]
		private Vector2 normalizedOffset;

		// Token: 0x0400408C RID: 16524
		[Token(Token = "0x400408C")]
		[FieldOffset(Offset = "0x74")]
		private Vector2 originPixel;
	}
}
