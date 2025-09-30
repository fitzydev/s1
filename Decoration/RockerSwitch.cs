using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Decoration
{
	// Token: 0x02000CDC RID: 3292
	[Token(Token = "0x2000CDC")]
	public class RockerSwitch : MonoBehaviour
	{
		// Token: 0x06005D50 RID: 23888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D50")]
		[Address(RVA = "0xA65840", Offset = "0xA64240", VA = "0x180A65840")]
		private void Awake()
		{
		}

		// Token: 0x06005D51 RID: 23889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D51")]
		[Address(RVA = "0xA658C0", Offset = "0xA642C0", VA = "0x180A658C0")]
		public void SetIsOn(bool on)
		{
		}

		// Token: 0x06005D52 RID: 23890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D52")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public RockerSwitch()
		{
		}

		// Token: 0x040043B0 RID: 17328
		[Token(Token = "0x40043B0")]
		[FieldOffset(Offset = "0x20")]
		public MeshRenderer ButtonMesh;

		// Token: 0x040043B1 RID: 17329
		[Token(Token = "0x40043B1")]
		[FieldOffset(Offset = "0x28")]
		public Transform ButtonTransform;

		// Token: 0x040043B2 RID: 17330
		[Token(Token = "0x40043B2")]
		[FieldOffset(Offset = "0x30")]
		public Light Light;

		// Token: 0x040043B3 RID: 17331
		[Token(Token = "0x40043B3")]
		[FieldOffset(Offset = "0x38")]
		public bool isOn;
	}
}
