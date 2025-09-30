using System;
using Il2CppDummyDll;
using ScheduleOne.Noise;
using ScheduleOne.NPCs.Responses;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Vehicles;
using ScheduleOne.Vision;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.NPCs
{
	// Token: 0x02000661 RID: 1633
	[Token(Token = "0x2000661")]
	public class NPCAwareness : MonoBehaviour
	{
		// Token: 0x060028C6 RID: 10438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028C6")]
		[Address(RVA = "0x7016A0", Offset = "0x7000A0", VA = "0x1807016A0", Slot = "4")]
		protected virtual void Awake()
		{
		}

		// Token: 0x060028C7 RID: 10439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028C7")]
		[Address(RVA = "0x701B60", Offset = "0x700560", VA = "0x180701B60")]
		public void SetAwarenessActive(bool active)
		{
		}

		// Token: 0x060028C8 RID: 10440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028C8")]
		[Address(RVA = "0x701BC0", Offset = "0x7005C0", VA = "0x180701BC0")]
		public void VisionEvent(VisionEventReceipt vEvent)
		{
		}

		// Token: 0x060028C9 RID: 10441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028C9")]
		[Address(RVA = "0x701A10", Offset = "0x700410", VA = "0x180701A10")]
		public void NoiseEvent(NoiseEvent nEvent)
		{
		}

		// Token: 0x060028CA RID: 10442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028CA")]
		[Address(RVA = "0x701950", Offset = "0x700350", VA = "0x180701950")]
		public void HitByCar(LandVehicle vehicle)
		{
		}

		// Token: 0x060028CB RID: 10443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028CB")]
		[Address(RVA = "0x6504E0", Offset = "0x64EEE0", VA = "0x1806504E0")]
		public NPCAwareness()
		{
		}

		// Token: 0x04001EB3 RID: 7859
		[Token(Token = "0x4001EB3")]
		public const float PLAYER_AIM_DETECTION_RANGE = 15f;

		// Token: 0x04001EB4 RID: 7860
		[Token(Token = "0x4001EB4")]
		[FieldOffset(Offset = "0x20")]
		public bool AwarenessActiveByDefault;

		// Token: 0x04001EB5 RID: 7861
		[Token(Token = "0x4001EB5")]
		[FieldOffset(Offset = "0x28")]
		[Header("References")]
		public VisionCone VisionCone;

		// Token: 0x04001EB6 RID: 7862
		[Token(Token = "0x4001EB6")]
		[FieldOffset(Offset = "0x30")]
		public Listener Listener;

		// Token: 0x04001EB7 RID: 7863
		[Token(Token = "0x4001EB7")]
		[FieldOffset(Offset = "0x38")]
		public NPCResponses Responses;

		// Token: 0x04001EB8 RID: 7864
		[Token(Token = "0x4001EB8")]
		[FieldOffset(Offset = "0x40")]
		public UnityEvent<Player> onNoticedGeneralCrime;

		// Token: 0x04001EB9 RID: 7865
		[Token(Token = "0x4001EB9")]
		[FieldOffset(Offset = "0x48")]
		public UnityEvent<Player> onNoticedPettyCrime;

		// Token: 0x04001EBA RID: 7866
		[Token(Token = "0x4001EBA")]
		[FieldOffset(Offset = "0x50")]
		public UnityEvent<Player> onNoticedDrugDealing;

		// Token: 0x04001EBB RID: 7867
		[Token(Token = "0x4001EBB")]
		[FieldOffset(Offset = "0x58")]
		public UnityEvent<Player> onNoticedPlayerViolatingCurfew;

		// Token: 0x04001EBC RID: 7868
		[Token(Token = "0x4001EBC")]
		[FieldOffset(Offset = "0x60")]
		public UnityEvent<Player> onNoticedSuspiciousPlayer;

		// Token: 0x04001EBD RID: 7869
		[Token(Token = "0x4001EBD")]
		[FieldOffset(Offset = "0x68")]
		public UnityEvent<NoiseEvent> onGunshotHeard;

		// Token: 0x04001EBE RID: 7870
		[Token(Token = "0x4001EBE")]
		[FieldOffset(Offset = "0x70")]
		public UnityEvent<NoiseEvent> onExplosionHeard;

		// Token: 0x04001EBF RID: 7871
		[Token(Token = "0x4001EBF")]
		[FieldOffset(Offset = "0x78")]
		public UnityEvent<LandVehicle> onHitByCar;

		// Token: 0x04001EC0 RID: 7872
		[Token(Token = "0x4001EC0")]
		[FieldOffset(Offset = "0x80")]
		private NPC npc;
	}
}
