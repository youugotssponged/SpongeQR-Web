namespace SpongeQRWeb.Models.Types;
public enum QRTypes
{
    Message,
    Email,
    Phone,
    URL,
    WIFI,
    Calendar
}

public enum WIFIAuthTypes
{
    None,
    WEP,
    WPA,
    WPA2
}

public enum CalendarEncodeTypes
{
    UNIVERSAL,
    ICAL
}