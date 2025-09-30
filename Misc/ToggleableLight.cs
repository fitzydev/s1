using System;
using Il2CppDummyDll;
using ScheduleOne.ConstructableScripts;
using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.Misc
{
	// Token: 0x02000CE3 RID: 3299
	[Token(Token = "0x2000CE3")]
	public class ToggleableLight : MonoBehaviour
	{
		// Token: 0x06005D81 RID: 23937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D81")]
		[Address(RVA = "0xA692C0", Offset = "0xA67CC0", VA = "0x180A692C0", Slot = "4")]
		protected virtual void Awake()
		{
		}

		// Token: 0x06005D82 RID: 23938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D82")]
		[Address(RVA = "0xA69330", Offset = "0xA67D30", VA = "0x180A69330")]
		private void OnValidate()
		{
		}

		// Token: 0x06005D83 RID: 23939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D83")]
		[Address(RVA = "0xA69330", Offset = "0xA67D30", VA = "0x180A69330", Slot = "5")]
		protected virtual void Update()
		{
		}

		// Token: 0x06005D84 RID: 23940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D84")]
		[Address(RVA = "0xA69540", Offset = "0xA67F40", VA = "0x180A69540")]
		public void TurnOn()
		{
		}

		// Token: 0x06005D85 RID: 23941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D85")]
		[Address(RVA = "0xA69520", Offset = "0xA67F20", VA = "0x180A69520")]
		public void TurnOff()
		{
		}

		// Token: 0x06005D86 RID: 23942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D86")]
		[Address(RVA = "0xA69360", Offset = "0xA67D60", VA = "0x180A69360", Slot = "6")]
		protected virtual void SetLights(bool active)
		{
		}

		// Token: 0x06005D87 RID: 23943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D87")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public ToggleableLight()
		{
		}

		// Token: 0x040043E0 RID: 17376
		[Token(Token = "0x40043E0")]
		[FieldOffset(Offset = "0x20")]
		public bool isOn;

		// Token: 0x040043E1 RID: 17377
		[Token(Token = "0x40043E1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Header("References")]
		protected OptimizedLight[] lightSources;

		// Token: 0x040043E2 RID: 17378
		[Token(Token = "0x40043E2")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected MeshRenderer[] lightSurfacesMeshes;

		// Token: 0x040043E3 RID: 17379
		[Token(Token = "0x40043E3")]
		[FieldOffset(Offset = "0x38")]
		public int MaterialIndex;

		// Token: 0x040043E4 RID: 17380
		[Token(Token = "0x40043E4")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Header("Materials")]
		protected Material lightOnMat;

		// Token: 0x040043E5 RID: 17381
		[Token(Token = "0x40043E5")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		protected Material lightOffMat;

		// Token: 0x040043E6 RID: 17382
		[Token(Token = "0x40043E6")]
		[FieldOffset(Offset = "0x50")]
		private Constructable_GridBased constructable;

		// Token: 0x040043E7 RID: 17383
		[Token(Token = "0x40043E7")]
		[FieldOffset(Offset = "0x58")]
		private bool lightsApplied;
	}
}
