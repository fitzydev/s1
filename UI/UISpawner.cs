using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.UI
{
	// Token: 0x02000B10 RID: 2832
	[Token(Token = "0x2000B10")]
	public class UISpawner : MonoBehaviour
	{
		// Token: 0x06004CD8 RID: 19672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CD8")]
		[Address(RVA = "0x93F630", Offset = "0x93E030", VA = "0x18093F630")]
		private void Start()
		{
		}

		// Token: 0x06004CD9 RID: 19673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CD9")]
		[Address(RVA = "0x93F670", Offset = "0x93E070", VA = "0x18093F670")]
		private void Update()
		{
		}

		// Token: 0x06004CDA RID: 19674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CDA")]
		[Address(RVA = "0x93F9A0", Offset = "0x93E3A0", VA = "0x18093F9A0")]
		public UISpawner()
		{
		}

		// Token: 0x040037AD RID: 14253
		[Token(Token = "0x40037AD")]
		[FieldOffset(Offset = "0x20")]
		public RectTransform SpawnArea;

		// Token: 0x040037AE RID: 14254
		[Token(Token = "0x40037AE")]
		[FieldOffset(Offset = "0x28")]
		public GameObject[] Prefabs;

		// Token: 0x040037AF RID: 14255
		[Token(Token = "0x40037AF")]
		[FieldOffset(Offset = "0x30")]
		public float MinInterval;

		// Token: 0x040037B0 RID: 14256
		[Token(Token = "0x40037B0")]
		[FieldOffset(Offset = "0x34")]
		public float MaxInterval;

		// Token: 0x040037B1 RID: 14257
		[Token(Token = "0x40037B1")]
		[FieldOffset(Offset = "0x38")]
		public float SpawnRateMultiplier;

		// Token: 0x040037B2 RID: 14258
		[Token(Token = "0x40037B2")]
		[FieldOffset(Offset = "0x3C")]
		public Vector2 MinScale;

		// Token: 0x040037B3 RID: 14259
		[Token(Token = "0x40037B3")]
		[FieldOffset(Offset = "0x44")]
		public Vector2 MaxScale;

		// Token: 0x040037B4 RID: 14260
		[Token(Token = "0x40037B4")]
		[FieldOffset(Offset = "0x4C")]
		public bool UniformScale;

		// Token: 0x040037B5 RID: 14261
		[Token(Token = "0x40037B5")]
		[FieldOffset(Offset = "0x50")]
		private float nextSpawnTime;

		// Token: 0x040037B6 RID: 14262
		[Token(Token = "0x40037B6")]
		[FieldOffset(Offset = "0x58")]
		public UnityEvent<GameObject> OnSpawn;
	}
}
