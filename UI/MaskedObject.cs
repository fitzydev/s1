using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

namespace ScheduleOne.UI
{
	// Token: 0x02000B0B RID: 2827
	[Token(Token = "0x2000B0B")]
	public class MaskedObject : UIBehaviour
	{
		// Token: 0x06004CC0 RID: 19648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CC0")]
		[Address(RVA = "0x92D930", Offset = "0x92C330", VA = "0x18092D930", Slot = "10")]
		protected override void OnRectTransformDimensionsChange()
		{
		}

		// Token: 0x06004CC1 RID: 19649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CC1")]
		[Address(RVA = "0x92D890", Offset = "0x92C290", VA = "0x18092D890", Slot = "4")]
		protected override void Awake()
		{
		}

		// Token: 0x06004CC2 RID: 19650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CC2")]
		[Address(RVA = "0x92DBB0", Offset = "0x92C5B0", VA = "0x18092DBB0", Slot = "6")]
		protected override void Start()
		{
		}

		// Token: 0x06004CC3 RID: 19651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CC3")]
		[Address(RVA = "0x92D8E0", Offset = "0x92C2E0", VA = "0x18092D8E0")]
		public void Initialize(Canvas rootCanvas, RectTransform maskRectTransform)
		{
		}

		// Token: 0x06004CC4 RID: 19652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CC4")]
		[Address(RVA = "0x92D960", Offset = "0x92C360", VA = "0x18092D960")]
		private void SetTargetClippingRect()
		{
		}

		// Token: 0x06004CC5 RID: 19653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CC5")]
		[Address(RVA = "0x92DD40", Offset = "0x92C740", VA = "0x18092DD40")]
		public MaskedObject()
		{
		}

		// Token: 0x04003798 RID: 14232
		[Token(Token = "0x4003798")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasRenderer canvasRendererToClip;

		// Token: 0x04003799 RID: 14233
		[Token(Token = "0x4003799")]
		[FieldOffset(Offset = "0x28")]
		public bool includeChildren;

		// Token: 0x0400379A RID: 14234
		[Token(Token = "0x400379A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Canvas rootCanvas;

		// Token: 0x0400379B RID: 14235
		[Token(Token = "0x400379B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectTransform maskRectTransform;

		// Token: 0x0400379C RID: 14236
		[Token(Token = "0x400379C")]
		[FieldOffset(Offset = "0x40")]
		private bool initialized;

		// Token: 0x0400379D RID: 14237
		[Token(Token = "0x400379D")]
		[FieldOffset(Offset = "0x48")]
		private List<CanvasRenderer> canvasRenderersToClip;
	}
}
