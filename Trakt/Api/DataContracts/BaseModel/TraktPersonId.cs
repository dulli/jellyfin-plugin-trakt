namespace Trakt.Api.DataContracts.BaseModel
{
    public class TraktPersonId : TraktIMDBandTMDBId
    {
        public int? tvrage { get; set; }
    }
}