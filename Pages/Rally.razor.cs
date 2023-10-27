public class Liff_scanQR_Result
{
    public string? value { get; set; }
}

public class Event
{
    public int eventId { get; set; }
    public string? eventName { get; set; }
    public string? eventStartdate { get; set; }
    public string? eventEnddate { get; set; }
    public string? eventImageurl { get; set; }
    public string? eventDescription { get; set; }
    public string? eventUrl { get; set; }
    public string? eventStampurl { get; set; }
    public string? eventLiffid { get; set; }
    public string? eventCreated { get; set; }
    public string? eventUpdated { get; set; }
    public string? eventDeleted { get; set; }
    public List<Checkpoint>? checkpoints { get; set; }
}


public class Checkpoint
{
    public int checkpointId { get; set; }
    public string? checkpointName { get; set; }
    public int checkpointEventId { get; set; }
    public string? checkpointImageurl { get; set; }
    public string? checkpointDescription { get; set; }
    public string? checkpointUrl { get; set; }
    public string? checkpointCreated { get; set; }
    public string? checkpointUpdated { get; set; }
    public string? checkpointDeleted { get; set; }
    public List<Checkin>? checkins { get; set; }
    public string? checkpointQr { get; set; }

}
public class CheckinModel
{
    public List<Checkin>? Checkin { get; set; }
}
public class Checkin
{
    public int checkinId { get; set; }
    public string? checkinUserid { get; set; }
    public string? checkinLineid { get; set; }
    public int checkinCheckpointId { get; set; }
    public DateTime? checkinCreated { get; set; }
    public string? checkinCheckpoint { get; set; }
    public int checkinEventid { get; set; }
    public bool checkinEventcomplete { get; set; }
    public override bool Equals(object? obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }

        Checkin otherCheckin = (Checkin)obj;
        return checkinCheckpointId == otherCheckin.checkinCheckpointId;
    }

    public override int GetHashCode()
    {
        return checkinCheckpointId.GetHashCode();
    }

}
public class EventComplete
{
    public string? lineId { get; set; }
    public int? eventId { get; set; }
}
