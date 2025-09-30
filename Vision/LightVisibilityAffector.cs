using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Vision
{
	// Token: 0x0200037A RID: 890
	[Token(Token = "0x200037A")]
	[RequireComponent(typeof(Light))]
	public class LightVisibilityAffector : MonoBehaviour
	{
		// Token: 0x060013D7 RID: 5079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013D7")]
		[Address(RVA = "0x5B0650", Offset = "0x5AF050", VA = "0x1805B0650", Slot = "4")]
		protected virtual void Awake()
		{
		}

		// Token: 0x060013D8 RID: 5080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013D8")]
		[Address(RVA = "0x5B09D0", Offset = "0x5AF3D0", VA = "0x1805B09D0")]
		private void PlayerSpawned()
		{
		}

		// Token: 0x060013D9 RID: 5081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013D9")]
		[Address(RVA = "0x5B0870", Offset = "0x5AF270", VA = "0x1805B0870")]
		private void OnDestroy()
		{
		}

		// Token: 0x060013DA RID: 5082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013DA")]
		[Address(RVA = "0x5B0DB0", Offset = "0x5AF7B0", VA = "0x1805B0DB0", Slot = "5")]
		protected virtual void UpdateVisibility()
		{
		}

		// Token: 0x060013DB RID: 5083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013DB")]
		[Address(RVA = "0x5B0BB0", Offset = "0x5AF5B0", VA = "0x1805B0BB0")]
		private void UpdateAttribute(float visibity)
		{
		}

		// Token: 0x060013DC RID: 5084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013DC")]
		[Address(RVA = "0x5B07B0", Offset = "0x5AF1B0", VA = "0x1805B07B0")]
		private void ClearAttribute()
		{
		}

		// Token: 0x060013DD RID: 5085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013DD")]
		[Address(RVA = "0x5B13D0", Offset = "0x5AFDD0", VA = "0x1805B13D0")]
		public LightVisibilityAffector()
		{
		}

		// Token: 0x040012B9 RID: 4793
		[Token(Token = "0x40012B9")]
		public const float PointLightEffect = 15f;

		// Token: 0x040012BA RID: 4794
		[Token(Token = "0x40012BA")]
		public const float SpotLightEffect = 10f;

		// Token: 0x040012BB RID: 4795
		[Token(Token = "0x40012BB")]
		[FieldOffset(Offset = "0x20")]
		[Header("Settings")]
		public float EffectMultiplier;

		// Token: 0x040012BC RID: 4796
		[Token(Token = "0x40012BC")]
		[FieldOffset(Offset = "0x28")]
		public string uniquenessCode;

		// Token: 0x040012BD RID: 4797
		[Token(Token = "0x40012BD")]
		[FieldOffset(Offset = "0x30")]
		[Tooltip("How far does the player have to move for visibility to be recalculated?")]
		public int updateDistanceThreshold;

		// Token: 0x040012BE RID: 4798
		[Token(Token = "0x40012BE")]
		[FieldOffset(Offset = "0x38")]
		protected Light light;

		// Token: 0x040012BF RID: 4799
		[Token(Token = "0x40012BF")]
		[FieldOffset(Offset = "0x40")]
		protected VisibilityAttribute attribute;
	}
}
