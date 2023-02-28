using SpongeQRWeb.Models.Types;

namespace SpongeQRWeb;

public interface ISpongeQR
{
    // TData will be a class or struct that holds the data from the apropriate form
    // e.g. Generating a wifi auth will need a wifi auth mode chosen from a dropdown in the UI
    Task<string?> GenerateQRData<TFormData>(QRTypes payloadChosen, TFormData data);
    Task<byte[]> GenerateQRFromPayloadData();
    Task<byte[]> ConvertQRToImageType();
}

public class SpongeQR : ISpongeQR
{
    public SpongeQR()
    {

    }

    public Task<byte[]> ConvertQRToImageType()
    {
        throw new NotImplementedException();
    }

    public Task<string?> GenerateQRData<TFormData>(QRTypes payloadChosen, TFormData data)
    {
        throw new NotImplementedException();
    }

    public Task<byte[]> GenerateQRFromPayloadData()
    {
        throw new NotImplementedException();
    }
}