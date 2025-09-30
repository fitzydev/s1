using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.AvatarFramework
{
	// Token: 0x02000A1A RID: 2586
	[Token(Token = "0x2000A1A")]
	public class Eyebrow : MonoBehaviour
	{
		// Token: 0x060046F8 RID: 18168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046F8")]
		[Address(RVA = "0x8F7880", Offset = "0x8F6280", VA = "0x1808F7880")]
		public void SetScale(float _scale)
		{
		}

		// Token: 0x060046F9 RID: 18169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046F9")]
		[Address(RVA = "0x8F78E0", Offset = "0x8F62E0", VA = "0x1808F78E0")]
		public void SetThickness(float thickness)
		{
		}

		// Token: 0x060046FA RID: 18170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046FA")]
		[Address(RVA = "0x8F76F0", Offset = "0x8F60F0", VA = "0x1808F76F0")]
		public void SetRestingAngle(float _angle)
		{
		}

		// Token: 0x060046FB RID: 18171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046FB")]
		[Address(RVA = "0x8F77F0", Offset = "0x8F61F0", VA = "0x1808F77F0")]
		public void SetRestingHeight(float normalizedHeight)
		{
		}

		// Token: 0x060046FC RID: 18172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046FC")]
		[Address(RVA = "0x8F76A0", Offset = "0x8F60A0", VA = "0x1808F76A0")]
		public void SetColor(Color _col)
		{
		}

		// Token: 0x060046FD RID: 18173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046FD")]
		[Address(RVA = "0x8F7940", Offset = "0x8F6340", VA = "0x1808F7940")]
		public Eyebrow()
		{
		}

		// Token: 0x040031D0 RID: 12752
		[Token(Token = "0x40031D0")]
		private const float eyebrowHeightMultiplier = 0.01f;

		// Token: 0x040031D1 RID: 12753
		[Token(Token = "0x40031D1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Vector3 EyebrowDefaultScale;

		// Token: 0x040031D2 RID: 12754
		[Token(Token = "0x40031D2")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Vector3 EyebrowDefaultLocalPos;

		// Token: 0x040031D3 RID: 12755
		[Token(Token = "0x40031D3")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		protected Eyebrow.ESide Side;

		// Token: 0x040031D4 RID: 12756
		[Token(Token = "0x40031D4")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		protected Transform Model;

		// Token: 0x040031D5 RID: 12757
		[Token(Token = "0x40031D5")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		protected MeshRenderer Rend;

		// Token: 0x040031D6 RID: 12758
		[Token(Token = "0x40031D6")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Header("Eyebrow Data - Readonly")]
		private Color col;

		// Token: 0x040031D7 RID: 12759
		[Token(Token = "0x40031D7")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float scale;

		// Token: 0x040031D8 RID: 12760
		[Token(Token = "0x40031D8")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private float thickness;

		// Token: 0x040031D9 RID: 12761
		[Token(Token = "0x40031D9")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float restingAngle;

		// Token: 0x02000A1B RID: 2587
		[Token(Token = "0x2000A1B")]
		public enum ESide
		{
			// Token: 0x040031DB RID: 12763
			[Token(Token = "0x40031DB")]
			Right,
			// Token: 0x040031DC RID: 12764
			[Token(Token = "0x40031DC")]
			Left
		}
	}
}
