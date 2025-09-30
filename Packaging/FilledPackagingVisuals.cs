using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Packaging
{
	// Token: 0x0200093F RID: 2367
	[Token(Token = "0x200093F")]
	public class FilledPackagingVisuals : MonoBehaviour
	{
		// Token: 0x060040A2 RID: 16546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040A2")]
		[Address(RVA = "0x860230", Offset = "0x85EC30", VA = "0x180860230")]
		public void ResetVisuals()
		{
		}

		// Token: 0x060040A3 RID: 16547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040A3")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public FilledPackagingVisuals()
		{
		}

		// Token: 0x04002D92 RID: 11666
		[Token(Token = "0x4002D92")]
		[FieldOffset(Offset = "0x20")]
		public FilledPackagingVisuals.WeedVisuals weedVisuals;

		// Token: 0x04002D93 RID: 11667
		[Token(Token = "0x4002D93")]
		[FieldOffset(Offset = "0x28")]
		public FilledPackagingVisuals.MethVisuals methVisuals;

		// Token: 0x04002D94 RID: 11668
		[Token(Token = "0x4002D94")]
		[FieldOffset(Offset = "0x30")]
		public FilledPackagingVisuals.CocaineVisuals cocaineVisuals;

		// Token: 0x02000940 RID: 2368
		[Token(Token = "0x2000940")]
		[Serializable]
		public class MeshIndexPair
		{
			// Token: 0x060040A4 RID: 16548 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60040A4")]
			[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
			public MeshIndexPair()
			{
			}

			// Token: 0x04002D95 RID: 11669
			[Token(Token = "0x4002D95")]
			[FieldOffset(Offset = "0x10")]
			public MeshRenderer Mesh;

			// Token: 0x04002D96 RID: 11670
			[Token(Token = "0x4002D96")]
			[FieldOffset(Offset = "0x18")]
			public int MaterialIndex;
		}

		// Token: 0x02000941 RID: 2369
		[Token(Token = "0x2000941")]
		[Serializable]
		public class BaseVisuals
		{
			// Token: 0x060040A5 RID: 16549 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60040A5")]
			[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
			public BaseVisuals()
			{
			}

			// Token: 0x04002D97 RID: 11671
			[Token(Token = "0x4002D97")]
			[FieldOffset(Offset = "0x10")]
			public Transform Container;
		}

		// Token: 0x02000942 RID: 2370
		[Token(Token = "0x2000942")]
		[Serializable]
		public class WeedVisuals : FilledPackagingVisuals.BaseVisuals
		{
			// Token: 0x060040A6 RID: 16550 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60040A6")]
			[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
			public WeedVisuals()
			{
			}

			// Token: 0x04002D98 RID: 11672
			[Token(Token = "0x4002D98")]
			[FieldOffset(Offset = "0x18")]
			public FilledPackagingVisuals.MeshIndexPair[] MainMeshes;

			// Token: 0x04002D99 RID: 11673
			[Token(Token = "0x4002D99")]
			[FieldOffset(Offset = "0x20")]
			public FilledPackagingVisuals.MeshIndexPair[] SecondaryMeshes;

			// Token: 0x04002D9A RID: 11674
			[Token(Token = "0x4002D9A")]
			[FieldOffset(Offset = "0x28")]
			public FilledPackagingVisuals.MeshIndexPair[] LeafMeshes;

			// Token: 0x04002D9B RID: 11675
			[Token(Token = "0x4002D9B")]
			[FieldOffset(Offset = "0x30")]
			public FilledPackagingVisuals.MeshIndexPair[] StemMeshes;
		}

		// Token: 0x02000943 RID: 2371
		[Token(Token = "0x2000943")]
		[Serializable]
		public class MethVisuals : FilledPackagingVisuals.BaseVisuals
		{
			// Token: 0x060040A7 RID: 16551 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60040A7")]
			[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
			public MethVisuals()
			{
			}

			// Token: 0x04002D9C RID: 11676
			[Token(Token = "0x4002D9C")]
			[FieldOffset(Offset = "0x18")]
			public MeshRenderer[] CrystalMeshes;
		}

		// Token: 0x02000944 RID: 2372
		[Token(Token = "0x2000944")]
		[Serializable]
		public class CocaineVisuals : FilledPackagingVisuals.BaseVisuals
		{
			// Token: 0x060040A8 RID: 16552 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60040A8")]
			[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
			public CocaineVisuals()
			{
			}

			// Token: 0x04002D9D RID: 11677
			[Token(Token = "0x4002D9D")]
			[FieldOffset(Offset = "0x18")]
			public MeshRenderer[] RockMeshes;
		}
	}
}
