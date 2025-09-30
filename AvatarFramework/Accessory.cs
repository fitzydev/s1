using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.AvatarFramework
{
	// Token: 0x02000A08 RID: 2568
	[Token(Token = "0x2000A08")]
	public class Accessory : MonoBehaviour
	{
		// Token: 0x06004630 RID: 17968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004630")]
		[Address(RVA = "0x8ACA10", Offset = "0x8AB410", VA = "0x1808ACA10")]
		private void Awake()
		{
		}

		// Token: 0x06004631 RID: 17969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004631")]
		[Address(RVA = "0x8AC780", Offset = "0x8AB180", VA = "0x1808AC780")]
		public void ApplyColor(Color col)
		{
		}

		// Token: 0x06004632 RID: 17970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004632")]
		[Address(RVA = "0x8AC940", Offset = "0x8AB340", VA = "0x1808AC940")]
		public void ApplyShapeKeys(float gender, float weight)
		{
		}

		// Token: 0x06004633 RID: 17971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004633")]
		[Address(RVA = "0x8ACA90", Offset = "0x8AB490", VA = "0x1808ACA90")]
		public void BindBones(Transform[] bones)
		{
		}

		// Token: 0x06004634 RID: 17972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004634")]
		[Address(RVA = "0x8ACB00", Offset = "0x8AB500", VA = "0x1808ACB00")]
		public Accessory()
		{
		}

		// Token: 0x04003117 RID: 12567
		[Token(Token = "0x4003117")]
		[FieldOffset(Offset = "0x20")]
		[Header("Settings")]
		public string Name;

		// Token: 0x04003118 RID: 12568
		[Token(Token = "0x4003118")]
		[FieldOffset(Offset = "0x28")]
		public string AssetPath;

		// Token: 0x04003119 RID: 12569
		[Token(Token = "0x4003119")]
		[FieldOffset(Offset = "0x30")]
		public bool ReduceFootSize;

		// Token: 0x0400311A RID: 12570
		[Token(Token = "0x400311A")]
		[FieldOffset(Offset = "0x34")]
		[Range(0f, 1f)]
		public float FootSizeReduction;

		// Token: 0x0400311B RID: 12571
		[Token(Token = "0x400311B")]
		[FieldOffset(Offset = "0x38")]
		public bool ShouldBlockHair;

		// Token: 0x0400311C RID: 12572
		[Token(Token = "0x400311C")]
		[FieldOffset(Offset = "0x39")]
		public bool ColorAllMeshes;

		// Token: 0x0400311D RID: 12573
		[Token(Token = "0x400311D")]
		[FieldOffset(Offset = "0x40")]
		[Header("References")]
		public MeshRenderer[] meshesToColor;

		// Token: 0x0400311E RID: 12574
		[Token(Token = "0x400311E")]
		[FieldOffset(Offset = "0x48")]
		public SkinnedMeshRenderer[] skinnedMeshesToColor;

		// Token: 0x0400311F RID: 12575
		[Token(Token = "0x400311F")]
		[FieldOffset(Offset = "0x50")]
		public SkinnedMeshRenderer[] skinnedMeshesToBind;

		// Token: 0x04003120 RID: 12576
		[Token(Token = "0x4003120")]
		[FieldOffset(Offset = "0x58")]
		public SkinnedMeshRenderer[] shapeKeyMeshRends;
	}
}
