using System.Collections.Generic;
using umi3d.edk;
using UnityEngine;

public class PlanetNotifEvent : MonoBehaviour
{
    [SerializeField] private UMI3DNode node_;
    [SerializeField] private string notifTitle_;
    [SerializeField, TextArea] private string notifDescription_;
    [SerializeField] private float notifDuration_ = 5f;

    public void Global(umi3d.edk.interaction.AbstractInteraction.InteractionEventContent content)
    {
        var notif = new UMI3DNotification(notifTitle_, notifDescription_, notifDuration_, null, null);
        Dispatch(notif);
    }
    public void Local(umi3d.edk.interaction.AbstractInteraction.InteractionEventContent content)
    {
        var notif = new UMI3DNotificationOnObject(notifTitle_, notifDescription_, notifDuration_, null, null, node_);
        Dispatch(notif);
    }


    private void Dispatch(UMI3DNotification notif)
    {
        var transaction = new Transaction() { reliable = true, Operations = new List<Operation>() { notif.GetLoadEntity() } };
        UMI3DServer.Dispatch(transaction);
    }
}
