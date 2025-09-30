using System;
using System.Collections.Generic;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Casino
{
	// Token: 0x020007D1 RID: 2001
	[Token(Token = "0x20007D1")]
	public class CardController : NetworkBehaviour
	{
		// Token: 0x06003607 RID: 13831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003607")]
		[Address(RVA = "0x7C49D0", Offset = "0x7C33D0", VA = "0x1807C49D0", Slot = "19")]
		public virtual void Awake()
		{
		}

		// Token: 0x06003608 RID: 13832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003608")]
		[Address(RVA = "0x7C6610", Offset = "0x7C5010", VA = "0x1807C6610")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendCardValue(string cardId, PlayingCard.ECardSuit suit, PlayingCard.ECardValue value)
		{
		}

		// Token: 0x06003609 RID: 13833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003609")]
		[Address(RVA = "0x7C4EC0", Offset = "0x7C38C0", VA = "0x1807C4EC0")]
		[ObserversRpc(RunLocally = true)]
		private void SetCardValue(string cardId, PlayingCard.ECardSuit suit, PlayingCard.ECardValue value)
		{
		}

		// Token: 0x0600360A RID: 13834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600360A")]
		[Address(RVA = "0x7C63C0", Offset = "0x7C4DC0", VA = "0x1807C63C0")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendCardFaceUp(string cardId, bool faceUp)
		{
		}

		// Token: 0x0600360B RID: 13835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600360B")]
		[Address(RVA = "0x7C4C90", Offset = "0x7C3690", VA = "0x1807C4C90")]
		[ObserversRpc(RunLocally = true)]
		private void SetCardFaceUp(string cardId, bool faceUp)
		{
		}

		// Token: 0x0600360C RID: 13836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600360C")]
		[Address(RVA = "0x7C6510", Offset = "0x7C4F10", VA = "0x1807C6510")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendCardGlide(string cardId, Vector3 position, Quaternion rotation, float glideTime)
		{
		}

		// Token: 0x0600360D RID: 13837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600360D")]
		[Address(RVA = "0x7C4DF0", Offset = "0x7C37F0", VA = "0x1807C4DF0")]
		[ObserversRpc(RunLocally = true)]
		private void SetCardGlide(string cardId, Vector3 position, Quaternion rotation, float glideTime)
		{
		}

		// Token: 0x0600360E RID: 13838 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600360E")]
		[Address(RVA = "0x7C4A20", Offset = "0x7C3420", VA = "0x1807C4A20")]
		private PlayingCard GetCard(string cardId)
		{
			return null;
		}

		// Token: 0x0600360F RID: 13839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600360F")]
		[Address(RVA = "0x7C6780", Offset = "0x7C5180", VA = "0x1807C6780")]
		public CardController()
		{
		}

		// Token: 0x06003610 RID: 13840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003610")]
		[Address(RVA = "0x7C4AA0", Offset = "0x7C34A0", VA = "0x1807C4AA0", Slot = "20")]
		public virtual void NetworkInitialize___Early()
		{
		}

		// Token: 0x06003611 RID: 13841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003611")]
		[Address(RVA = "0x7C4A80", Offset = "0x7C3480", VA = "0x1807C4A80", Slot = "21")]
		public virtual void NetworkInitialize__Late()
		{
		}

		// Token: 0x06003612 RID: 13842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003612")]
		[Address(RVA = "0x6783D0", Offset = "0x676DD0", VA = "0x1806783D0", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06003613 RID: 13843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003613")]
		[Address(RVA = "0x7C6260", Offset = "0x7C4C60", VA = "0x1807C6260")]
		private void RpcWriter___Server_SendCardValue_3709737967(string cardId, PlayingCard.ECardSuit suit, PlayingCard.ECardValue value)
		{
		}

		// Token: 0x06003614 RID: 13844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003614")]
		[Address(RVA = "0x7C4EC0", Offset = "0x7C38C0", VA = "0x1807C4EC0")]
		public void RpcLogic___SendCardValue_3709737967(string cardId, PlayingCard.ECardSuit suit, PlayingCard.ECardValue value)
		{
		}

		// Token: 0x06003615 RID: 13845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003615")]
		[Address(RVA = "0x7C5800", Offset = "0x7C4200", VA = "0x1807C5800")]
		private void RpcReader___Server_SendCardValue_3709737967(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06003616 RID: 13846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003616")]
		[Address(RVA = "0x7C5CE0", Offset = "0x7C46E0", VA = "0x1807C5CE0")]
		private void RpcWriter___Observers_SetCardValue_3709737967(string cardId, PlayingCard.ECardSuit suit, PlayingCard.ECardValue value)
		{
		}

		// Token: 0x06003617 RID: 13847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003617")]
		[Address(RVA = "0x7C5230", Offset = "0x7C3C30", VA = "0x1807C5230")]
		private void RpcLogic___SetCardValue_3709737967(string cardId, PlayingCard.ECardSuit suit, PlayingCard.ECardValue value)
		{
		}

		// Token: 0x06003618 RID: 13848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003618")]
		[Address(RVA = "0x7C5500", Offset = "0x7C3F00", VA = "0x1807C5500")]
		private void RpcReader___Observers_SetCardValue_3709737967(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003619 RID: 13849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003619")]
		[Address(RVA = "0x7C5E50", Offset = "0x7C4850", VA = "0x1807C5E50")]
		private void RpcWriter___Server_SendCardFaceUp_310431262(string cardId, bool faceUp)
		{
		}

		// Token: 0x0600361A RID: 13850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600361A")]
		[Address(RVA = "0x7C4C90", Offset = "0x7C3690", VA = "0x1807C4C90")]
		public void RpcLogic___SendCardFaceUp_310431262(string cardId, bool faceUp)
		{
		}

		// Token: 0x0600361B RID: 13851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600361B")]
		[Address(RVA = "0x7C55A0", Offset = "0x7C3FA0", VA = "0x1807C55A0")]
		private void RpcReader___Server_SendCardFaceUp_310431262(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x0600361C RID: 13852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600361C")]
		[Address(RVA = "0x7C58B0", Offset = "0x7C42B0", VA = "0x1807C58B0")]
		private void RpcWriter___Observers_SetCardFaceUp_310431262(string cardId, bool faceUp)
		{
		}

		// Token: 0x0600361D RID: 13853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600361D")]
		[Address(RVA = "0x7C5050", Offset = "0x7C3A50", VA = "0x1807C5050")]
		private void RpcLogic___SetCardFaceUp_310431262(string cardId, bool faceUp)
		{
		}

		// Token: 0x0600361E RID: 13854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600361E")]
		[Address(RVA = "0x7C5310", Offset = "0x7C3D10", VA = "0x1807C5310")]
		private void RpcReader___Observers_SetCardFaceUp_310431262(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600361F RID: 13855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600361F")]
		[Address(RVA = "0x7C5FB0", Offset = "0x7C49B0", VA = "0x1807C5FB0")]
		private void RpcWriter___Server_SendCardGlide_2833372058(string cardId, Vector3 position, Quaternion rotation, float glideTime)
		{
		}

		// Token: 0x06003620 RID: 13856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003620")]
		[Address(RVA = "0x7C4DF0", Offset = "0x7C37F0", VA = "0x1807C4DF0")]
		public void RpcLogic___SendCardGlide_2833372058(string cardId, Vector3 position, Quaternion rotation, float glideTime)
		{
		}

		// Token: 0x06003621 RID: 13857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003621")]
		[Address(RVA = "0x7C5650", Offset = "0x7C4050", VA = "0x1807C5650")]
		private void RpcReader___Server_SendCardGlide_2833372058(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06003622 RID: 13858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003622")]
		[Address(RVA = "0x7C5A20", Offset = "0x7C4420", VA = "0x1807C5A20")]
		private void RpcWriter___Observers_SetCardGlide_2833372058(string cardId, Vector3 position, Quaternion rotation, float glideTime)
		{
		}

		// Token: 0x06003623 RID: 13859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003623")]
		[Address(RVA = "0x7C5120", Offset = "0x7C3B20", VA = "0x1807C5120")]
		private void RpcLogic___SetCardGlide_2833372058(string cardId, Vector3 position, Quaternion rotation, float glideTime)
		{
		}

		// Token: 0x06003624 RID: 13860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003624")]
		[Address(RVA = "0x7C53B0", Offset = "0x7C3DB0", VA = "0x1807C53B0")]
		private void RpcReader___Observers_SetCardGlide_2833372058(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003625 RID: 13861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003625")]
		[Address(RVA = "0x7C4760", Offset = "0x7C3160", VA = "0x1807C4760")]
		private void Awake_UserLogic_ScheduleOne.Casino.CardController_Assembly-CSharp.dll()
		{
		}

		// Token: 0x040025BA RID: 9658
		[Token(Token = "0x40025BA")]
		[FieldOffset(Offset = "0x118")]
		private List<PlayingCard> cards;

		// Token: 0x040025BB RID: 9659
		[Token(Token = "0x40025BB")]
		[FieldOffset(Offset = "0x120")]
		private Dictionary<string, PlayingCard> cardDictionary;

		// Token: 0x040025BC RID: 9660
		[Token(Token = "0x40025BC")]
		[FieldOffset(Offset = "0x128")]
		private bool NetworkInitialize___EarlyScheduleOne.Casino.CardControllerAssembly-CSharp.dll_Excuted;

		// Token: 0x040025BD RID: 9661
		[Token(Token = "0x40025BD")]
		[FieldOffset(Offset = "0x129")]
		private bool NetworkInitialize__LateScheduleOne.Casino.CardControllerAssembly-CSharp.dll_Excuted;
	}
}
